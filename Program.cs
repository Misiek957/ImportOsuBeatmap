using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OsuLoaderLib;

namespace ImportOsuBeatmap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BeatMap beatmap = OsuLoaderLib.OsuLoader.LoadDotOsu("C:/Assets/Osu/KatyushaMania.osu");
            Console.WriteLine("Passed");
        }
    }
}
