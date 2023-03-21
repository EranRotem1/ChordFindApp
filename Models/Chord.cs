namespace TestingChords.Models
{
    public class Chord
    {
        public bool SimpleSearch { get; set; } = true;
        public string Name { get; set; } = "C";
        public string? Tone { get; set; }
        public string? Type { get; set; }
        public string? Extension { get; set; }
        public string? Inst { get; set; }
        public bool Progression { get; set; }
        public bool TriadOrSeventh { get; set; }

    }
}
