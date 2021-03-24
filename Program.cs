using System.Runtime.InteropServices;

namespace OutBoardMusic
{
    
    class Program
    {
        static void Main(string[] args) {

            Music myMusic = new Music(69);
            //Play gets called with the name of the note to be played (which is a member of the tone struct),
            //the length the note is to be played (which is a member of the time struct),
            //and the tempo in beats per minute.
            myMusic.Play(tone.B3, time.quarter);
            myMusic.Play(tone.C4, time.quarter);
            myMusic.Play(tone.D4, time.quarter);
            myMusic.Play(tone.E4, time.dottedhalf);
            myMusic.Play(tone.D4, time.quarter);
            myMusic.Play(tone.E4, time.quarter);
            myMusic.Play(tone.A4, time.quarter);
            myMusic.Play(tone.G4, time.quarter);
            myMusic.Play(tone.E4, time.quarter);
            myMusic.Play(tone.D4, time.quarter);
            myMusic.Play(tone.C4, time.quarter);
            myMusic.Play(tone.A3, time.dottedhalf);
        }
    }

    class Music
    {
        public double tempo = 60;
        public Music(double tempo) {
            this.tempo = tempo; 
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool Beep(uint dwFreq, uint dwDuration);

        public void Play(uint tone, double time) {
            double conversion_factor = 1 / (this.tempo / 60);
            Beep(tone, (uint)(time * conversion_factor));
        }

        public static void Play(string tone, string time) { 
        
        }

    }
    public static class tone
    {
        public const int A3 = 220;
        public const int B3 = 247;
        public const int C4 = 262;
        public const int D4 = 294;
        public const int E4 = 330;
        public const int F4 = 349;
        public const int G4 = 392;
        public const int A4 = 440;
        public const int B4 = 494;
        public const int C5 = 523;
    }

    public static class time
    {
        public const double whole = 4000;
        public const double half = 2000;
        public const double dottedhalf = 3000;
        public const double quarter = 1000;
    }
}
