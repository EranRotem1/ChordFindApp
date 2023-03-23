namespace TestingChords.Models
{
    public class Chord
    {
        //public Chord()
        //{
        //    if (Name[1] == 'b' || Name[1] == '#')
        //    {
        //        Accidental = Name[1].ToString();
        //        Tone = Name[0].ToString() + Accidental;
        //    }
        //    else { Tone = Name[0].ToString(); }

        //    int index = Tones.FindIndex(x => x.Contains(Tone.ToLower()));
        //    var intervals = new List<int>() { 2, 2, 1, 2, 2, 2 };
        //    foreach (var num in intervals)
        //    {
        //        index += num;
        //        if (index >= 12)
        //        {
        //            index -= 11;
        //            Index.Add(Tones[index]);
        //        }
        //        Index.Add(Tones[index]);
        //    }
            
        //}
        public bool SimpleSearch { get; set; } = true;
        public string Name { get; set; } = "C";
        public string Tone { get; set; }
        public string? Type { get; set; }
        public string? Extension { get; set; }
        public string? Inst { get; set; } = "both";
        public string? Progression { get; set; } = "None";
        public List<string> Progressions = new List<string>() { "None", "Triads", "7th Chords", "Tone Chords" };

        public List<string> Tones = new List<string>() { "a", "a#", "b", "c", "c#", "d", "d#", "e", "f", "f#", "g", "g#" };
        public List<string> TonesFlat = new List<string>() { "a", "bb", "b", "c", "db", "d", "eb", "e", "f", "gb", "g", "ab" };

        public List<string> ToneChords = new List<string> { 
            "maj", "m", "dim", "aug", "maj7", "7", "m7", "m7b5", "dim7",
            "m(maj7)", "sus2", "sus4", "6", "6/9", "9", "11", "13", "5"};
        public List<string> Index = new List<string>();
        public string? Accidental { get; set; }
    }
}
