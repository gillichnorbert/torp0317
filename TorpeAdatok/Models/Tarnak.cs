using System;
namespace TorpeAdatok.Models
{
	public class Tarnak
	{
        public int Id { get; set; }
        public string Nev { get; set; }
        public int KozetekID { get; set; }
        public Tarnak()
		{
		}

        public Tarnak(string sor)
        {
            var s = sor.Split(";");
            Id = int.Parse(s[0]);
            Nev = s[1];
            KozetekID = int.Parse(s[2]);
        }

        public override string? ToString()
        {
            return "(" +Id + Nev + KozetekID + ")";
        }
    }
}

