using IL2CPU.API.Attribs;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.System.Graphics;

namespace COS.COSMAIN.Resources
{
    public class Assets
    {
        public const string Base = "COS.COSMAIN.Resources.Audio.";
        public const string Base2 = "COS.COSMAIN.Resources.GraphicTest.";

        [ManifestResourceStream(ResourceName = Base + "startup.wav")] public readonly static byte[] StartupWave;
        [ManifestResourceStream(ResourceName = Base2 + "wall.bmp")] public readonly static byte[] gtestwall;
        [ManifestResourceStream(ResourceName = Base2 + "pointer.bmp")] public readonly static byte[] cursor;
        [ManifestResourceStream(ResourceName = Base2 + "notification_icon.bmp")] public readonly static byte[] NotifyIcon;

        public static Bitmap GTestWall = new Bitmap(gtestwall);
        public static Bitmap Cursor = new Bitmap(cursor);

    }
}
