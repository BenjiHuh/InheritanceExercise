using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile: Animal
    {
        private bool CanRegenerate { get; set; }
        private string MatingCall { get; set; }
        private int NumberOfEggs { get; set; }
        private bool HasScales { get; set; }

        public Reptile()
        {
            CanRegenerate = false;
            MatingCall = "";
            NumberOfEggs = 0;
            HasScales = false;
        }

        public Reptile(bool inputCanRegenerate)
        {
            CanRegenerate = inputCanRegenerate;
            MatingCall = "";
            NumberOfEggs = 0;
            HasScales = false;
        }
        public Reptile(bool inputTalans, string inputMatingCall)
        {
            CanRegenerate = inputTalans;
            MatingCall = inputMatingCall;
            NumberOfEggs = 0;
            HasScales = false;
        }
        public Reptile(bool inputTalans, string inputBirdSong, int inputNumberOfEggs)
        {
            CanRegenerate = inputTalans;
            MatingCall = inputBirdSong;
            NumberOfEggs = inputNumberOfEggs;
            HasScales = false;
        }
        public Reptile(bool inputTalans, string inputBirdSong, int inputWingSpan, bool inputHasScales)
        {
            CanRegenerate = inputTalans;
            MatingCall = inputBirdSong;
            NumberOfEggs = inputWingSpan;
            HasScales = inputHasScales;
        }

        public void PresentReptile()
        {
            Console.WriteLine($"Reptile can regenerate: {CanRegenerate}, mating call: {MatingCall}, numbers of eggs laid in one cycle: {NumberOfEggs}, has scales: {HasScales}");
        }

    }
}
