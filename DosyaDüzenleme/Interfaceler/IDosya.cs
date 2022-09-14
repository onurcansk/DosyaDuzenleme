using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyaDüzenleme.Interfaceler
{
    public interface IDosya
    {
        string DosyaAdı { get; set; }
        long DosyaBoyutu { get; set; }
        DateTime OluşturmaTarihi { get;}
        DateTime GeçerlilikTarihi { get; set; }
        
        string Açıklama { get; set; }
        string DosyaYolu { get; set; }
    }
}
