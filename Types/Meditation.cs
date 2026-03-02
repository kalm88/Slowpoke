using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flintstones
{

  /// <summary>
  /// Class that gives the correct dugon meditation responses.
  /// </summary>
  public static class Meditation
  {
    public static Dictionary<string, Dictionary<DugonColor, Action>> DugonMediation(Client client)
    {
      return new Dictionary<string, Dictionary<DugonColor, Action>>
      {
        {
          "A bat flutters",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.White,  () => client.PopupOption5() },
            { DugonColor.Red,    () => client.PopupOption4() },
            { DugonColor.Brown,  () => client.PopupOption3() },
            { DugonColor.Purple, () => client.PopupOption2() },
            { DugonColor.Blue,   () => client.PopupOption1() }
          }
        },
        {
          "A candle flame dances",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Yellow, () => client.PopupOption5() },
            { DugonColor.Green,  () => client.PopupOption4() },
            { DugonColor.White,  () => client.PopupOption3() },
            { DugonColor.Black,  () => client.PopupOption2() },
            { DugonColor.Brown,  () => client.PopupOption1() }
          }
        },
        {
          "A cold, gray, empty room",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Blue,   () => client.PopupOption5() },
            { DugonColor.White,  () => client.PopupOption4() },
            { DugonColor.Black,  () => client.PopupOption3() },
            { DugonColor.Red,    () => client.PopupOption2() },
            { DugonColor.Purple, () => client.PopupOption1() }
          }
        },
        {
          "A crab sits still",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Black,  () => client.PopupOption5() },
            { DugonColor.Brown,  () => client.PopupOption4() },
            { DugonColor.Purple, () => client.PopupOption3() },
            { DugonColor.Yellow, () => client.PopupOption2() },
            { DugonColor.Green,  () => client.PopupOption1() }
          }
        },
        {  "A cross",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Black,  () => client.PopupOption5() },
            { DugonColor.Brown,  () => client.PopupOption4() },
            { DugonColor.Purple, () => client.PopupOption3() },
            { DugonColor.Yellow, () => client.PopupOption2() },
            { DugonColor.Green,  () => client.PopupOption1() }
          }
        },
        {
          "A die yields success",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.White,  () => client.PopupOption5() },
            { DugonColor.Red,    () => client.PopupOption4() },
            { DugonColor.Brown,  () => client.PopupOption3() },
            { DugonColor.Purple, () => client.PopupOption2() },
            { DugonColor.Blue,   () => client.PopupOption1() }
          }
        },
        {
          "A flower wilts",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Blue,   () => client.PopupOption5() },
            { DugonColor.White,  () => client.PopupOption4() },
            { DugonColor.Black,  () => client.PopupOption3() },
            { DugonColor.Red,    () => client.PopupOption2() },
            { DugonColor.Purple, () => client.PopupOption1() }
          }
        },
        {
          "A hand softly touches",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Purple, () => client.PopupOption5() },
            { DugonColor.Blue,   () => client.PopupOption4() },
            { DugonColor.Green,  () => client.PopupOption3() },
            { DugonColor.White,  () => client.PopupOption2() },
            { DugonColor.Red,    () => client.PopupOption1() }
          }
        },
        {
          "A leafless, winter tree",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Blue,   () => client.PopupOption5() },
            { DugonColor.White,  () => client.PopupOption4() },
            { DugonColor.Black,  () => client.PopupOption3() },
            { DugonColor.Red,    () => client.PopupOption2() },
            { DugonColor.Purple, () => client.PopupOption1() }
          }
        },
        {
          "A lock deftly undone",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.White,  () => client.PopupOption5() },
            { DugonColor.Red,    () => client.PopupOption4() },
            { DugonColor.Brown,  () => client.PopupOption3() },
            { DugonColor.Purple, () => client.PopupOption2() },
            { DugonColor.Blue,   () => client.PopupOption1() }
          }
        },
        {
          "A pyre consumes you",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Yellow, () => client.PopupOption5() },
            { DugonColor.Green,  () => client.PopupOption4() },
            { DugonColor.White,  () => client.PopupOption3() },
            { DugonColor.Black,  () => client.PopupOption2() },
            { DugonColor.Brown,  () => client.PopupOption1() }
          }
        },
        {
          "A spark dances in your chest",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Yellow, () => client.PopupOption5() },
            { DugonColor.Green,  () => client.PopupOption4() },
            { DugonColor.White,  () => client.PopupOption3() },
            { DugonColor.Black,  () => client.PopupOption2() },
            { DugonColor.Brown,  () => client.PopupOption1() }
          }
        },
        {
          "A well-cobbled path",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Black,  () => client.PopupOption5() },
            { DugonColor.Brown,  () => client.PopupOption4() },
            { DugonColor.Purple, () => client.PopupOption3() },
            { DugonColor.Yellow, () => client.PopupOption2() },
            { DugonColor.Green,  () => client.PopupOption1() }
          }
        },
        {
          "A wolf lunges at your throat",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Green,  () => client.PopupOption5() },
            { DugonColor.Black,  () => client.PopupOption4() },
            { DugonColor.Red,    () => client.PopupOption3() },
            { DugonColor.Brown,  () => client.PopupOption2() },
            { DugonColor.Yellow, () => client.PopupOption1() }
          }
        },
        {
          "A word",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Black,  () => client.PopupOption5() },
            { DugonColor.Brown,  () => client.PopupOption4() },
            { DugonColor.Purple, () => client.PopupOption3() },
            { DugonColor.Yellow, () => client.PopupOption2() },
            { DugonColor.Green,  () => client.PopupOption1() }
          }
        },
        {
          "Aha!",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Red,    () => client.PopupOption5() },
            { DugonColor.Purple, () => client.PopupOption4() },
            { DugonColor.Yellow, () => client.PopupOption3() },
            { DugonColor.Blue,   () => client.PopupOption2() },
            { DugonColor.White,  () => client.PopupOption1() }
          }
        },
        {
          "An invigorating cry",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Green,  () => client.PopupOption5() },
            { DugonColor.Black,   () => client.PopupOption4() },
            { DugonColor.Red,    () => client.PopupOption3() },
            { DugonColor.Brown,  () => client.PopupOption2() },
            { DugonColor.Yellow, () => client.PopupOption1() }
          }
        },
        {
          "All fades away",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Blue,   () => client.PopupOption5() },
            { DugonColor.White,  () => client.PopupOption4() },
            { DugonColor.Black,  () => client.PopupOption3() },
            { DugonColor.Red,    () => client.PopupOption2() },
            { DugonColor.Purple, () => client.PopupOption1() }
          }
        },
        {
          "As without, within; as outside, inside",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Brown,  () => client.PopupOption5() },
            { DugonColor.Yellow, () => client.PopupOption4() },
            { DugonColor.Blue,   () => client.PopupOption3() },
            { DugonColor.Green,  () => client.PopupOption2() },
            { DugonColor.Black,  () => client.PopupOption1() }
          }
        },
        {
          "Blushing countenance of sunset",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Purple, () => client.PopupOption5() },
            { DugonColor.Blue,   () => client.PopupOption4() },
            { DugonColor.Green,  () => client.PopupOption3() },
            { DugonColor.White,  () => client.PopupOption2() },
            { DugonColor.Red,    () => client.PopupOption1() }
          }
        },
        {
          "Clash",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Green,  () => client.PopupOption5() },
            { DugonColor.Black,  () => client.PopupOption4() },
            { DugonColor.Red,    () => client.PopupOption3() },
            { DugonColor.Brown,  () => client.PopupOption2() },
            { DugonColor.Yellow, () => client.PopupOption1() }
          }
        },
        {
          "Cool, running river",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Brown,  () => client.PopupOption5() },
            { DugonColor.Yellow, () => client.PopupOption4() },
            { DugonColor.Blue,   () => client.PopupOption3() },
            { DugonColor.Green,  () => client.PopupOption2() },
            { DugonColor.Black,  () => client.PopupOption1() }
          }
        },
        {
          "Discovery",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Red,    () => client.PopupOption5() },
            { DugonColor.Purple, () => client.PopupOption4() },
            { DugonColor.Yellow, () => client.PopupOption3() },
            { DugonColor.Blue,   () => client.PopupOption2() },
            { DugonColor.White,  () => client.PopupOption1() }
          }
        },
        {
          "Dissipation",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Blue,   () => client.PopupOption5() },
            { DugonColor.White,  () => client.PopupOption4() },
            { DugonColor.Black,  () => client.PopupOption3() },
            { DugonColor.Red,    () => client.PopupOption2() },
            { DugonColor.Purple, () => client.PopupOption1() }
          }
        },
        {
          "Flames envelop you",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Yellow, () => client.PopupOption5() },
            { DugonColor.Green,  () => client.PopupOption4() },
            { DugonColor.White,  () => client.PopupOption3() },
            { DugonColor.Black,  () => client.PopupOption2() },
            { DugonColor.Brown,  () => client.PopupOption1() }
          }
        },
        {
          "Flash of light",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Red,    () => client.PopupOption5() },
            { DugonColor.Purple, () => client.PopupOption4() },
            { DugonColor.Yellow, () => client.PopupOption3() },
            { DugonColor.Blue,   () => client.PopupOption2() },
            { DugonColor.White,  () => client.PopupOption1() }
          }
        },
        {
          "Gentle violet light surrounds you",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Purple, () => client.PopupOption5() },
            { DugonColor.Blue,   () => client.PopupOption4() },
            { DugonColor.Green,  () => client.PopupOption3() },
            { DugonColor.White,  () => client.PopupOption2() },
            { DugonColor.Red,    () => client.PopupOption1() }
          }
        },
        {
          "Glint of gold",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.White,  () => client.PopupOption5() },
            { DugonColor.Red,    () => client.PopupOption4() },
            { DugonColor.Brown,  () => client.PopupOption3() },
            { DugonColor.Purple, () => client.PopupOption2() },
            { DugonColor.Blue,   () => client.PopupOption1() }
          }
        },
        {
          "Heat swells from below",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Yellow, () => client.PopupOption5() },
            { DugonColor.Green,  () => client.PopupOption4() },
            { DugonColor.White,  () => client.PopupOption3() },
            { DugonColor.Black,  () => client.PopupOption2() },
            { DugonColor.Brown,  () => client.PopupOption1() }
          }
        },
        {
          "Let go",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Blue,   () => client.PopupOption5() },
            { DugonColor.White,  () => client.PopupOption4() },
            { DugonColor.Black,  () => client.PopupOption3() },
            { DugonColor.Red,    () => client.PopupOption2() },
            { DugonColor.Purple, () => client.PopupOption1() }
          }
        },
        {
          "Light beneath the waves",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Red,    () => client.PopupOption5() },
            { DugonColor.Purple, () => client.PopupOption4() },
            { DugonColor.Yellow, () => client.PopupOption3() },
            { DugonColor.Blue,   () => client.PopupOption2() },
            { DugonColor.White,  () => client.PopupOption1() }
          }
        },
        {
          "Light twinkles",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Yellow, () => client.PopupOption5() },
            { DugonColor.Green,  () => client.PopupOption4() },
            { DugonColor.White,  () => client.PopupOption3() },
            { DugonColor.Black,  () => client.PopupOption2() },
            { DugonColor.Brown,  () => client.PopupOption1() }
          }
        },
        {
          "Lush green leaves",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Brown,  () => client.PopupOption5() },
            { DugonColor.Yellow, () => client.PopupOption4() },
            { DugonColor.Blue ,  () => client.PopupOption3() },
            { DugonColor.Green,  () => client.PopupOption2() },
            { DugonColor.Black,  () => client.PopupOption1() }
          }
        },
        {
          "Mantis in the garden",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Brown,  () => client.PopupOption5() },
            { DugonColor.Yellow, () => client.PopupOption4() },
            { DugonColor.Blue,   () => client.PopupOption3() },
            { DugonColor.Green,  () => client.PopupOption2() },
            { DugonColor.Black,  () => client.PopupOption1() }
          }
        },
        {
          "Mother's caress",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Purple, () => client.PopupOption5() },
            { DugonColor.Blue,   () => client.PopupOption4() },
            { DugonColor.Green,  () => client.PopupOption3() },
            { DugonColor.White,  () => client.PopupOption2() },
            { DugonColor.Red,    () => client.PopupOption1() }
          }
        },
        {
          "Myriad, distant stars",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Red,    () => client.PopupOption5() },
            { DugonColor.Purple, () => client.PopupOption4() },
            { DugonColor.Yellow, () => client.PopupOption3() },
            { DugonColor.Blue,   () => client.PopupOption2() },
            { DugonColor.White,  () => client.PopupOption1() }
          }
        },
        {
          "Ocean waves reflect light",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Purple, () => client.PopupOption5() },
            { DugonColor.Blue,   () => client.PopupOption4() },
            { DugonColor.Green,  () => client.PopupOption3() },
            { DugonColor.White,  () => client.PopupOption2() },
            { DugonColor.Red,    () => client.PopupOption1() }
          }
        },
        {
          "Passion",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Yellow, () => client.PopupOption5() },
            { DugonColor.Green,  () => client.PopupOption4() },
            { DugonColor.White,  () => client.PopupOption3() },
            { DugonColor.Black,  () => client.PopupOption2() },
            { DugonColor.Brown,  () => client.PopupOption1() }
          }
        },
        {
          "Peaceful mountain",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Brown,  () => client.PopupOption5() },
            { DugonColor.Yellow, () => client.PopupOption4() },
            { DugonColor.Blue,   () => client.PopupOption3() },
            { DugonColor.Green,  () => client.PopupOption2() },
            { DugonColor.Black,  () => client.PopupOption1() }
          }
        },
        {
          "Profound understanding",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Red,    () => client.PopupOption5() },
            { DugonColor.Purple, () => client.PopupOption4() },
            { DugonColor.Yellow, () => client.PopupOption3() },
            { DugonColor.Blue,   () => client.PopupOption2() },
            { DugonColor.White,  () => client.PopupOption1() }
          }
        },
        {
          "Rays reflect in crystals at sharp angles",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.White,  () => client.PopupOption5() },
            { DugonColor.Red,    () => client.PopupOption4() },
            { DugonColor.Brown,  () => client.PopupOption3() },
            { DugonColor.Purple, () => client.PopupOption2() },
            { DugonColor.Blue,   () => client.PopupOption1() }
          }
        },
        {
          "Sages concur",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Black,  () => client.PopupOption5() },
            { DugonColor.Brown,  () => client.PopupOption4() },
            { DugonColor.Purple, () => client.PopupOption3() },
            { DugonColor.Yellow, () => client.PopupOption2() },
            { DugonColor.Green,  () => client.PopupOption1() }
          }
        },
        {
          "Satyrs dance about you",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Yellow,  () => client.PopupOption5() },
            { DugonColor.Green,   () => client.PopupOption4() },
            { DugonColor.White,   () => client.PopupOption3() },
            { DugonColor.Black,   () => client.PopupOption2() },
            { DugonColor.Brown,   () => client.PopupOption1() }
          }
        },
        {
          "Serene stream",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Brown,  () => client.PopupOption5() },
            { DugonColor.Yellow, () => client.PopupOption4() },
            { DugonColor.Blue,   () => client.PopupOption3() },
            { DugonColor.Green,  () => client.PopupOption2() },
            { DugonColor.Black,  () => client.PopupOption1() }
          }
        },
        {
          "Stillness",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Brown,  () => client.PopupOption5() },
            { DugonColor.Yellow, () => client.PopupOption4() },
            { DugonColor.Blue,   () => client.PopupOption3() },
            { DugonColor.Green,  () => client.PopupOption2() },
            { DugonColor.Black,  () => client.PopupOption1() }
          }
        },
        {
          "Stone tablet",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Black,  () => client.PopupOption5() },
            { DugonColor.Brown,  () => client.PopupOption4() },
            { DugonColor.Purple, () => client.PopupOption3() },
            { DugonColor.Yellow, () => client.PopupOption2() },
            { DugonColor.Green,  () => client.PopupOption1() }
          }
        },
        {
          "Sweat trickles down your chest",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Green,  () => client.PopupOption5() },
            { DugonColor.Black,  () => client.PopupOption4() },
            { DugonColor.Red,    () => client.PopupOption3() },
            { DugonColor.Brown,  () => client.PopupOption2() },
            { DugonColor.Yellow, () => client.PopupOption1() }
          }
        },
        {
          "Swords stab into you",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Green,  () => client.PopupOption5() },
            { DugonColor.Black,  () => client.PopupOption4() },
            { DugonColor.Red,    () => client.PopupOption3() },
            { DugonColor.Brown,  () => client.PopupOption2() },
            { DugonColor.Yellow, () => client.PopupOption1() }
          }
        },
        {
          "Swiftly dashing deer",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.White,  () => client.PopupOption5() },
            { DugonColor.Red,    () => client.PopupOption4() },
            { DugonColor.Brown,  () => client.PopupOption3() },
            { DugonColor.Purple, () => client.PopupOption2() },
            { DugonColor.Blue,   () => client.PopupOption1() }
          }
        },
        {
          "The hand turns over",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.White,  () => client.PopupOption5() },
            { DugonColor.Red,    () => client.PopupOption4() },
            { DugonColor.Brown,  () => client.PopupOption3() },
            { DugonColor.Purple, () => client.PopupOption2() },
            { DugonColor.Blue,   () => client.PopupOption1() }
          }
        },
        {
          "The median appears obvious",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Black,  () => client.PopupOption5() },
            { DugonColor.Brown,  () => client.PopupOption4() },
            { DugonColor.Purple, () => client.PopupOption3() },
            { DugonColor.Yellow, () => client.PopupOption2() },
            { DugonColor.Green,  () => client.PopupOption1() }
          }
        },
        {
          "The moon shines as if smiling",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Purple, () => client.PopupOption5() },
            { DugonColor.Blue,   () => client.PopupOption4() },
            { DugonColor.Green,  () => client.PopupOption3() },
            { DugonColor.White,  () => client.PopupOption2() },
            { DugonColor.Red,    () => client.PopupOption1() }
          }
        },
        {
          "The other cheek is offered",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Purple, () => client.PopupOption5() },
            { DugonColor.Blue,   () => client.PopupOption4() },
            { DugonColor.Green,  () => client.PopupOption3() },
            { DugonColor.White,  () => client.PopupOption2() },
            { DugonColor.Red,    () => client.PopupOption1() }
          }
        },
        {
          "The way is revealed",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Red,    () => client.PopupOption5() },
            { DugonColor.Purple, () => client.PopupOption4() },
            { DugonColor.Yellow, () => client.PopupOption3() },
            { DugonColor.Blue,   () => client.PopupOption2() },
            { DugonColor.White,  () => client.PopupOption1() }
          }
        },
        {
          "The wolf whizzes by",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.White,  () => client.PopupOption5() },
            { DugonColor.Red,    () => client.PopupOption4() },
            { DugonColor.Brown,  () => client.PopupOption3() },
            { DugonColor.Purple, () => client.PopupOption2() },
            { DugonColor.Blue,   () => client.PopupOption1() }
          }
        },
        {
          "Trickle of thoughts",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Red,    () => client.PopupOption5() },
            { DugonColor.Purple, () => client.PopupOption4() },
            { DugonColor.Yellow, () => client.PopupOption3() },
            { DugonColor.Blue,   () => client.PopupOption2() },
            { DugonColor.White,  () => client.PopupOption1() }
          }
        },
        {
          "Unbroken stare",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Green,  () => client.PopupOption5() },
            { DugonColor.Black,  () => client.PopupOption4() },
            { DugonColor.Red,    () => client.PopupOption3() },
            { DugonColor.Brown,  () => client.PopupOption2() },
            { DugonColor.Yellow, () => client.PopupOption1() }
          }
        },
        {
          "You taste blood",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Green,  () => client.PopupOption5() },
            { DugonColor.Black,  () => client.PopupOption4() },
            { DugonColor.Red,    () => client.PopupOption3() },
            { DugonColor.Brown,  () => client.PopupOption2() },
            { DugonColor.Yellow, () => client.PopupOption1() }
          }
        },
        {
          "You feel cold and numb",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Blue,   () => client.PopupOption5() },
            { DugonColor.White,  () => client.PopupOption4() },
            { DugonColor.Black,  () => client.PopupOption3() },
            { DugonColor.Red,    () => client.PopupOption2() },
            { DugonColor.Purple, () => client.PopupOption1() }
          }
        },
        {
          "Your body lies on an unlit pyre",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Blue,   () => client.PopupOption5() },
            { DugonColor.White,  () => client.PopupOption4() },
            { DugonColor.Black,  () => client.PopupOption3() },
            { DugonColor.Red,    () => client.PopupOption2() },
            { DugonColor.Purple, () => client.PopupOption1() }
          }
        },
        {
          "Your empty hands cusp the wind",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Brown,  () => client.PopupOption5() },
            { DugonColor.Yellow, () => client.PopupOption4() },
            { DugonColor.Blue,   () => client.PopupOption3() },
            { DugonColor.Green,  () => client.PopupOption2() },
            { DugonColor.Black,  () => client.PopupOption1() }
          }
        },
        {
          "Your heart gently warms",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Purple, () => client.PopupOption5() },
            { DugonColor.Blue,   () => client.PopupOption4() },
            { DugonColor.Green,  () => client.PopupOption3() },
            { DugonColor.White,  () => client.PopupOption2() },
            { DugonColor.Red,    () => client.PopupOption1() }
          }
        },
        {
          "Your left shoulder and right balance",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Black,  () => client.PopupOption5() },
            { DugonColor.Brown,  () => client.PopupOption4() },
            { DugonColor.Purple, () => client.PopupOption3() },
            { DugonColor.Yellow, () => client.PopupOption2() },
            { DugonColor.Green,  () => client.PopupOption1() }
          }
        },
        {
          "Your muscles breathe easily",
          new Dictionary<DugonColor, Action>
          {
            { DugonColor.Green,  () => client.PopupOption5() },
            { DugonColor.Black,  () => client.PopupOption4() },
            { DugonColor.Red,    () => client.PopupOption3() },
            { DugonColor.Brown,  () => client.PopupOption2() },
            { DugonColor.Yellow, () => client.PopupOption1() }
          }
        }
      };
    }
  }
}