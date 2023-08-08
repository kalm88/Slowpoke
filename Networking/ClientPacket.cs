//SlowPoke
// Type: Flintstones.ClientPacket
//SlowPoke
//SlowPoke
//SlowPoke

using System;
using System.Security.Cryptography;

namespace Flintstones
{
  public class ClientPacket : Packet
  {
    public ClientPacket(byte opcode)
    {
      this.signature = (byte) 170;
      this.bodyData = new byte[0];
      this.opcode = opcode;
    }

    public ClientPacket(byte[] rawData)
    {
      this.signature = rawData[0];
      this.length = (ushort) ((uint) rawData[1] * 256U + (uint) rawData[2]);
      this.opcode = rawData[3];
      if (this.ShouldEncrypt)
      {
        this.ordinal = rawData[4];
        this.bodyData = new byte[rawData.Length - 5];
        Array.Copy((Array) rawData, 5, (Array) this.bodyData, 0, this.bodyData.Length);
      }
      else
      {
        this.bodyData = new byte[rawData.Length - 4];
        Array.Copy((Array) rawData, 4, (Array) this.bodyData, 0, this.bodyData.Length);
      }
    }

    public override bool ShouldEncrypt => this.Opcode != (byte) 0 && this.Opcode != (byte) 16 && this.Opcode != (byte) 87 && this.Opcode != (byte) 98;

    public override bool UseDefaultKey => this.Opcode == (byte) 2 || this.Opcode == (byte) 3 || this.Opcode == (byte) 4 || this.Opcode == (byte) 11 || this.Opcode == (byte) 38 || this.Opcode == (byte) 45 || this.Opcode == (byte) 58 || this.Opcode == (byte) 66 || this.Opcode == (byte) 67 || this.Opcode == (byte) 75 || this.Opcode == (byte) 87 || this.Opcode == (byte) 98 || this.Opcode == (byte) 104 || this.Opcode == (byte) 113 || this.Opcode == (byte) 115 || this.Opcode == (byte) 123;

    public override void Encrypt(Client client)
    {
      int count = this.bodyData.Length - 7;
      Random random = new Random();
      ushort bRand = (ushort) (random.Next(65277) + 256);
      byte sRand = (byte) (random.Next(155) + 100);
      byte[] numArray1 = this.UseDefaultKey ? client.Key : client.GenerateKey(bRand, sRand);
      for (int index = 0; index < count; ++index)
      {
        this.bodyData[index] ^= numArray1[index % numArray1.Length];
        this.bodyData[index] ^= Packet.saltTable[(int) client.Seed][index / numArray1.Length % Packet.saltTable[(int) client.Seed].Length];
        if (index / numArray1.Length % Packet.saltTable[(int) client.Seed].Length != (int) this.ordinal)
          this.bodyData[index] ^= Packet.saltTable[(int) client.Seed][(int) this.ordinal];
      }
      byte[] numArray2 = new byte[count + 2];
      numArray2[0] = this.opcode;
      numArray2[1] = this.ordinal;
      Buffer.BlockCopy((Array) this.bodyData, 0, (Array) numArray2, 2, count);
      byte[] hash = MD5.Create().ComputeHash(numArray2);
      this.bodyData[count] = hash[13];
      this.bodyData[count + 1] = hash[3];
      this.bodyData[count + 2] = hash[11];
      this.bodyData[count + 3] = hash[7];
      this.bodyData[count + 4] = (byte) ((int) bRand % 256 ^ 112);
      this.bodyData[count + 5] = (byte) ((uint) sRand ^ 35U);
      this.bodyData[count + 6] = (byte) (((int) bRand >> 8) % 256 ^ 116);
    }

    public override void Decrypt(Client client)
    {
      int num = this.bodyData.Length - 7;
      ushort bRand = (ushort) (((int) this.bodyData[num + 6] << 8 | (int) this.bodyData[num + 4]) ^ 29808);
      byte sRand = (byte) ((uint) this.bodyData[num + 5] ^ 35U);
      byte[] numArray = this.UseDefaultKey ? client.Key : client.GenerateKey(bRand, sRand);
      for (int index = 0; index < num; ++index)
      {
        this.bodyData[index] ^= numArray[index % numArray.Length];
        this.bodyData[index] ^= Packet.saltTable[(int) client.Seed][index / numArray.Length % Packet.saltTable[(int) client.Seed].Length];
        if (index / numArray.Length % Packet.saltTable[(int) client.Seed].Length != (int) this.ordinal)
          this.bodyData[index] ^= Packet.saltTable[(int) client.Seed][(int) this.ordinal];
      }
    }

    public void GenerateDialogHeader()
    {
      ushort num = 0;
      for (int index = 0; index < this.bodyData.Length - 6; ++index)
        num = (ushort) ((uint) this.bodyData[6 + index] ^ (uint) (ushort) ((uint) num << 8) ^ (uint) Packet.dialogCrcTable[(int) num >> 8]);
      Random random = new Random();
      this.bodyData[0] = (byte) random.Next();
      this.bodyData[1] = (byte) random.Next();
      this.bodyData[2] = (byte) ((this.bodyData.Length - 4) / 256);
      this.bodyData[3] = (byte) ((this.bodyData.Length - 4) % 256);
      this.bodyData[4] = (byte) ((uint) num / 256U);
      this.bodyData[5] = (byte) ((uint) num % 256U);
    }

    public void EncryptDialog()
    {
      int num1 = (int) this.bodyData[2] << 8 | (int) this.bodyData[3];
      int num2 = (int) (byte) ((uint) this.bodyData[1] ^ (uint) (byte) ((uint) this.bodyData[0] - 45U));
      byte num3 = (byte) (num2 + 114);
      byte num4 = (byte) (num2 + 40);
      this.bodyData[2] ^= num3;
      this.bodyData[3] ^= (byte) (((int) num3 + 1) % 256);
      for (int index = 0; index < num1; ++index)
        this.bodyData[4 + index] ^= (byte) (((int) num4 + index) % 256);
    }

    public void DecryptDialog()
    {
      int num1 = (int) (byte) ((uint) this.bodyData[1] ^ (uint) (byte) ((uint) this.bodyData[0] - 45U));
      byte num2 = (byte) (num1 + 114);
      byte num3 = (byte) (num1 + 40);
      this.bodyData[2] ^= num2;
      this.bodyData[3] ^= (byte) (((int) num2 + 1) % 256);
      int num4 = (int) this.bodyData[2] << 8 | (int) this.bodyData[3];
      for (int index = 0; index < num4; ++index)
        this.bodyData[4 + index] ^= (byte) (((int) num3 + index) % 256);
    }
  }
}
