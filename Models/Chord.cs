namespace TestingChords.Models
{
    public class Chord
    {
        //public Chord() 
        //{
        //    Name = Tone + Type + Extension;
        //}
        public bool SimpleSearch { get; set; } = true;
        public string Name { get; set; } = "Cmaj7";
        public string? Tone { get; set; }
        public string? Type { get; set; }
        public string? Extension { get; set; }
        public string? Inst { get; set; }
        public string? Progression { get; set; }
        public bool TriadOrSeventh { get; set; }
        
    }
}
