using System.Diagnostics;

namespace EasySwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayManager dm = new DisplayManager();
            uint bpp = dm.GetBitsPerPixel();

            dm.SetBitsPerPixel(bpp == 16u ? 32u : 16u);
        }
    }
}
