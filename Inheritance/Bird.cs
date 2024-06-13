using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance
{
    internal class Bird : Animal
    {
        private bool hasTalans { get; set; }
        private string birdSong { get; set; }
        private int wingSpan { get; set; }
        private bool canSwim { get; set; }

        public Bird()
        {
            hasTalans = false;
            birdSong = "";
            wingSpan = 0;
            canSwim = false;
        }
    
        public Bird (bool inputTalans)
        {
            hasTalans = inputTalans;
            birdSong = "";
            wingSpan = 0;
            canSwim = false;
        }
        public Bird (bool inputTalans, string inputBirdSong)
        {
            hasTalans = inputTalans;
            birdSong = inputBirdSong;
            wingSpan = 0;
            canSwim = false;
        }
        public Bird (bool inputTalans, string inputBirdSong, int inputWingSpan)
        {
            hasTalans = inputTalans;
            birdSong = inputBirdSong;
            wingSpan = inputWingSpan;
            canSwim = false;
        }
        public Bird (bool inputTalans, string inputBirdSong, int inputWingSpan, bool inputCanSwim)
        {
            hasTalans = inputTalans;
            birdSong = inputBirdSong;
            wingSpan = inputWingSpan;
            canSwim = inputCanSwim;
        }

        public void PresentBird()
        {
            Console.WriteLine($"Bird has talans: {hasTalans}, bird song: {birdSong}, wing span: {wingSpan}, can swim: {canSwim}");
        }

    }
}
