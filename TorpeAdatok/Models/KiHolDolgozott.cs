using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorpeAdatok.Models
{
    public class KiHolDolgozott
    {
        public int Id { get; set; }
        public int TorpekId { get; set; }
        public int TarnakId { get; set; }
        public int KitermeltMennyiseg { get; set; }

        public KiHolDolgozott() { }
        
        public KiHolDolgozott(string sor) {
            var s = sor.Split(";");
            TorpekId = int.Parse(s[0]);
            TarnakId = int.Parse(s[1]);
            KitermeltMennyiseg = int.Parse(s[2]);       
        }

        public override string? ToString()
        {
            return "("+TorpekId+", "+TarnakId+", "+KitermeltMennyiseg+")";
        }
    }
}
