using System;
namespace TorpeAdatok.Models
{
	public class Kozetek
	{
        public int Id { get; set; }
        public string Nev { get; set; }

        public Kozetek()
		{
		}

        public Kozetek(string sor)
        {
            var s = sor.Split(";");
            Id = int.Parse(s[0]);
            Nev = s[1];
        }


        public override string? ToString()
        {
            return "(" + Id + ", " + Nev+ ")";
        }
    }
}

