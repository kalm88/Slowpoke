//SlowPoke
// Type: Flintstones.Properties.Resources
//SlowPoke
//SlowPoke
//SlowPoke

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Flintstones.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (Flintstones.Properties.Resources.resourceMan == null)
          Flintstones.Properties.Resources.resourceMan = new ResourceManager("Flintstones.Properties.Resources", typeof (Flintstones.Properties.Resources).Assembly);
        return Flintstones.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => Flintstones.Properties.Resources.resourceCulture;
      set => Flintstones.Properties.Resources.resourceCulture = value;
    }
  }
}
