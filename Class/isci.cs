using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    internal class isci
    {
        public string name { get; set; }
        public string vezife { get; set; }
        public int emek_haqqi { get; set; }

        

        public int EmekHaqqininArtimi()
        {
            Console.WriteLine("emek haqqinin ne qeder artdigini yazin:");
            int.TryParse(Console.ReadLine(), out int artanEmekHaqqi);
            return emek_haqqi = emek_haqqi + artanEmekHaqqi;
        }
        public int gelenVergiFaizi()
        {
            Console.WriteLine("vergini faizini yazin:");
            int.TryParse(Console.ReadLine().Trim(), out int vergiFaizi);
            emek_haqqi = emek_haqqi * vergiFaizi / 100;
            return emek_haqqi;
        }
    }
}
