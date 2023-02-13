namespace ApiLecture.Models
{
    public class HallOfFameResponse
    {
        public Complete[] complete { get; set; }
        public Tiny[] tiny { get; set; }
    }

    public class Complete
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string innovation { get; set; }
        public int year { get; set; }
    }

    public class Tiny
    {
        public string name { get; set; }
        public string invented { get; set; }
        public int year { get; set; }
    }

}
