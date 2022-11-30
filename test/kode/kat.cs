using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.code;

internal class Kat
{
    public string? Farve { get; set; }

    public Kat(string farve)
    {
        Farve = farve;
    }

    public void SkiftFarve()
    {
        Farve = "Gul";
    }
}