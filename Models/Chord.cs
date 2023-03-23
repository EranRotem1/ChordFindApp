namespace TestingChords.Models
{
    public class Chord
    {
        public Chord()
        {
            if (Name[1] == 'b' || Name[1] == '#')
            {
                Accidental = Name[1].ToString();
                Tone = Name[0].ToString() + Accidental;
            }
            else { Tone = Name[0].ToString(); }
            //if (Tones.Contains(Name[0]))
            //{

            //}
        }
        public bool SimpleSearch { get; set; } = true;
        public string Name { get; set; } = "Cmaj";
        public string Tone { get; set; }
        public string? Type { get; set; }
        public string? Extension { get; set; }
        public string? Inst { get; set; } = "both";
        public string? Progression { get; set; } = "none";
        public List<string> Tones = new List<string>() { "a", "a#", "b", "c", "c#", "d", "d#", "e", "f", "f#", "g", "g#" };
        public List<string> ToneChords = new List<string> { "maj", "m", "dim", "aug", "maj7", "7", "m7", "m7b5", "dim7",
            "m(maj7)", "sus2", "sus4", "6", "6/9", "9", "11", "13", "5"};
        public string Accidental { get; set; }
    }
}
