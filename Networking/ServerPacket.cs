//SlowPoke
// Type: Flintstones.ServerPacket
//SlowPoke
//SlowPoke
//SlowPoke

using System;

namespace Flintstones
{
  public class ServerPacket : Packet
  {
    public ServerPacket(byte opcode)
    {
      this.signature = (byte) 170;
      this.bodyData = new byte[0];
      this.opcode = opcode;
    }

    public ServerPacket(byte[] rawData)
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

    public override bool ShouldEncrypt => this.Opcode != (byte) 0 && this.Opcode != (byte) 3 && this.Opcode != (byte) 111 && this.Opcode != (byte) 126;

    public override bool UseDefaultKey => this.Opcode == (byte) 1 || this.Opcode == (byte) 2 || this.Opcode == (byte) 10 || this.Opcode == (byte) 86 || this.Opcode == (byte) 96 || this.Opcode == (byte) 98 || this.Opcode == (byte) 102 || this.Opcode == (byte) 111;

    public override void Encrypt(Client client)
    {
      int index1 = this.bodyData.Length - 3;
      Random random = new Random();
      ushort bRand = (ushort) (random.Next() % 65277 + 256);
      byte sRand = (byte) (random.Next() % 155 + 100);
      byte[] numArray = this.UseDefaultKey ? client.Key : client.GenerateKey(bRand, sRand);
      for (int index2 = 0; index2 < index1; ++index2)
      {
        this.bodyData[index2] ^= numArray[index2 % numArray.Length];
        this.bodyData[index2] ^= Packet.saltTable[(int) client.Seed][index2 / numArray.Length % Packet.saltTable[(int) client.Seed].Length];
        if (index2 / numArray.Length % Packet.saltTable[(int) client.Seed].Length != (int) this.ordinal)
          this.bodyData[index2] ^= Packet.saltTable[(int) client.Seed][(int) this.ordinal];
      }
      this.bodyData[index1] = (byte) ((int) bRand % 256 ^ 116);
      this.bodyData[index1 + 1] = (byte) ((uint) sRand ^ 36U);
      this.bodyData[index1 + 2] = (byte) (((int) bRand >> 8) % 256 ^ 100);
    }

    public override void Decrypt(Client client)
    {
      int index1 = this.bodyData.Length - 3;
      ushort bRand = (ushort) (((int) this.bodyData[index1 + 2] << 8 | (int) this.bodyData[index1]) ^ 25716);
      byte sRand = (byte) ((uint) this.bodyData[index1 + 1] ^ 36U);
      byte[] numArray = this.UseDefaultKey ? client.Key : client.GenerateKey(bRand, sRand);
      for (int index2 = 0; index2 < index1; ++index2)
      {
        this.bodyData[index2] ^= numArray[index2 % numArray.Length];
        this.bodyData[index2] ^= Packet.saltTable[(int) client.Seed][index2 / numArray.Length % Packet.saltTable[(int) client.Seed].Length];
        if (index2 / numArray.Length % Packet.saltTable[(int) client.Seed].Length != (int) this.ordinal)
          this.bodyData[index2] ^= Packet.saltTable[(int) client.Seed][(int) this.ordinal];
      }
    }
  }
}
