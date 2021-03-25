using System.Runtime.InteropServices;

namespace OutBoardMusic
{

    class Program {
        static void Main(string[] args) {

            Song.DannyBoy();
        
        }
    }

    class Music {
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
    public static class tone {
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
        public const int D5 = 587;
        public const int E5 = 659;
    }

    public static class time {
        public const double whole = 4000;
        public const double half = 2000;
        public const double dottedhalf = 3000;
        public const double quarter = 1000;
    }

    public static class Song{
        public static void DannyBoy() {
            Music myMusic = new Music(140);
            //Play gets called with the name of the note to be played (which is a member of the tone struct),
            //the length the note is to be played (which is a member of the time struct),
            //and the tempo in beats per minute.
            myMusic.Play(tone.B3, time.quarter);     // Oh
            myMusic.Play(tone.C4, time.quarter);     // Dan-
            myMusic.Play(tone.D4, time.quarter);     // ny 
            myMusic.Play(tone.E4, time.dottedhalf);  // Boy
            myMusic.Play(tone.D4, time.quarter);     // the
            myMusic.Play(tone.E4, time.quarter);     // pipes
            myMusic.Play(tone.A4, time.quarter);     // the
            myMusic.Play(tone.G4, time.quarter);     // pipes
            myMusic.Play(tone.E4, time.quarter);     // are
            myMusic.Play(tone.D4, time.quarter);     // ca-
            myMusic.Play(tone.C4, time.quarter);     // all-
            myMusic.Play(tone.A3, time.dottedhalf);  // ing

            myMusic.Play(tone.C4, time.quarter);     // from
            myMusic.Play(tone.E4, time.quarter);     // glen
            myMusic.Play(tone.F4, time.quarter);     // to
            myMusic.Play(tone.G4, time.dottedhalf);  // glen
            myMusic.Play(tone.A4, time.quarter);     // and
            myMusic.Play(tone.G4, time.quarter);     // down
            myMusic.Play(tone.E4, time.quarter);     // the
            myMusic.Play(tone.C4, time.quarter);     // moun-
            myMusic.Play(tone.E4, time.quarter);     // tain
            myMusic.Play(tone.D4, time.dottedhalf);  // side. 

            myMusic.Play(tone.B3, time.quarter);     // The
            myMusic.Play(tone.C4, time.quarter);     // Sum-
            myMusic.Play(tone.D4, time.quarter);     // mer's 
            myMusic.Play(tone.E4, time.dottedhalf);  // gone
            myMusic.Play(tone.D4, time.quarter);     // and
            myMusic.Play(tone.E4, time.quarter);     // all
            myMusic.Play(tone.A4, time.quarter);     // the
            myMusic.Play(tone.G4, time.quarter);     // ros-
            myMusic.Play(tone.E4, time.quarter);     // es
            myMusic.Play(tone.D4, time.quarter);     // fa-
            myMusic.Play(tone.C4, time.quarter);     // all-
            myMusic.Play(tone.A3, time.dottedhalf);  // ing.

            myMusic.Play(tone.B3, time.quarter);     // It's
            myMusic.Play(tone.C4, time.quarter);     // you,
            myMusic.Play(tone.D4, time.quarter);     // it's
            myMusic.Play(tone.E4, time.dottedhalf);  // you
            myMusic.Play(tone.F4, time.quarter);     // must
            myMusic.Play(tone.E4, time.quarter);     // go
            myMusic.Play(tone.D4, time.quarter);     // and
            myMusic.Play(tone.C4, time.quarter);     // I
            myMusic.Play(tone.D4, time.quarter);     // must
            myMusic.Play(tone.C4, time.dottedhalf);  // bide.

            myMusic.Play(tone.G4, time.quarter);     // But
            myMusic.Play(tone.A4, time.quarter);     // come 
            myMusic.Play(tone.B4, time.quarter);     // ye
            myMusic.Play(tone.C5, time.dottedhalf);  // back
            myMusic.Play(tone.B4, time.quarter);     // when
            myMusic.Play(tone.B4, time.quarter);     // sum-
            myMusic.Play(tone.A4, time.quarter);     // ers
            myMusic.Play(tone.G4, time.quarter);     // in
            myMusic.Play(tone.A4, time.quarter);     // the
            myMusic.Play(tone.G4, time.quarter);     // me-
            myMusic.Play(tone.E4, time.quarter);     // a-
            myMusic.Play(tone.C4, time.half);        // dow
            myMusic.Play(tone.G4, time.quarter);     // or
            myMusic.Play(tone.A4, time.quarter);     // when
            myMusic.Play(tone.B4, time.quarter);     // the
            myMusic.Play(tone.C5, time.dottedhalf);  // leaves
            myMusic.Play(tone.B4, time.quarter);     // are
            myMusic.Play(tone.B4, time.quarter);     // hushed
            myMusic.Play(tone.A4, time.quarter);     // and
            myMusic.Play(tone.G4, time.quarter);     // white
            myMusic.Play(tone.E4, time.quarter);     // with
            myMusic.Play(tone.D4, time.dottedhalf);  // snow.

            myMusic.Play(tone.G4, time.quarter);     // It's
            myMusic.Play(tone.G4, time.quarter);     // I'll
            myMusic.Play(tone.G4, time.quarter);     // be
            myMusic.Play(tone.E5, time.dottedhalf);  // here
            myMusic.Play(tone.D5, time.quarter);     // in
            myMusic.Play(tone.D5, time.quarter);     // sun
            myMusic.Play(tone.C5, time.quarter);     // shine
            myMusic.Play(tone.A4, time.quarter);     // or
            myMusic.Play(tone.C5, time.quarter);     // in
            myMusic.Play(tone.G4, time.quarter);     // sha-
            myMusic.Play(tone.E4, time.quarter);     // ad-
            myMusic.Play(tone.C4, time.half);        // ow.
            myMusic.Play(tone.B3, time.quarter);     // Oh
            myMusic.Play(tone.C4, time.quarter);     // Dan-
            myMusic.Play(tone.D4, time.quarter);     // ny
            myMusic.Play(tone.E4, time.quarter);     // Boy!
            myMusic.Play(tone.A4, time.quarter);     // Oh
            myMusic.Play(tone.G4, time.quarter);     // Dan
            myMusic.Play(tone.E4, time.quarter);     // -ny
            myMusic.Play(tone.D4, time.quarter);     // Boy!
            myMusic.Play(tone.C4, time.quarter);     // I
            myMusic.Play(tone.A3, time.quarter);     // loved
            myMusic.Play(tone.B3, time.quarter);     // you
            myMusic.Play(tone.C4, time.whole);       // so.
        }
    }
}
