using System;
namespace TorpeAdatok.Models
{
	public class Torpek
	{
        public int Id { get; set; }
        public string Nev { get; set; }
        public string Klan { get; set; }
        public string Nem { get; set; }
        public int Suly { get; set; }
        public int Magassag { get; set; }

        public Torpek()
		{
        }

        public Torpek(string sor)
        {
            var s = sor.Split(";");
            Id = int.Parse(s[0]);
            Nev = s[1];
            Klan = s[2];
            Nem = s[3];
            Suly = int.Parse(s[4]);
            Magassag = int.Parse(s[5]);
        }

        public override string? ToString()
        {
            return "(" + Id + ", " + Nev + ", " + Klan + ", " + Nem + ", " + Suly + ", " + Magassag + ")";
        }
    }
}

