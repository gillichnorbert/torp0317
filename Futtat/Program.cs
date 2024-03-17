// See https://aka.ms/new-console-template for more information
using TorpeAdatok.Data;
using TorpeAdatok.Models;

var _context = new Context();

if (!_context.KiHolDolgozott.Any()) {
    var sorok = File.ReadAllLines(@"Users/gillichnorbert/adatok/torp/kihol.csv").Skip(1);
    foreach (var s in sorok)
    {
        _context.KiHolDolgozott.Add(new KiHolDolgozott(s));
    }
    _context.SaveChanges();
}

foreach (var item in _context.KiHolDolgozott)
{
    Console.WriteLine(item);
}

if (!_context.Kozetek.Any())
{
    var sorok = File.ReadAllLines(@"Users/gillichnorbert/adatok/torp/kozetek.csv").Skip(1);
    foreach (var s in sorok)
    {
        _context.Kozetek.Add(new Kozetek(s));
    }
    _context.SaveChanges();
}

foreach (var item in _context.Kozetek)
{
    Console.WriteLine(item);
}


