using DosyaDüzenleme.Interfaceler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyaDüzenleme.DosyaTürleri
{
    
    public class Dosya : IDosya
    {
        public string DosyaAdı { get ; set ; }       
        public long DosyaBoyutu { get ; set ; }
        public DateTime OluşturmaTarihi { get; }
        public DateTime GeçerlilikTarihi { get; set; }
        public virtual string KlasörAdı { get; }
        public virtual string DosyaUzantısı { get; }
        public string DosyaYolu { get; set; }
        public string Açıklama { get ; set ; }
        

        public Dosya(string dosyaYolu, string dosyaAdı, long dosyaBoyutu, DateTime OluşturmaTarihi,string dosyaUzantısı, string KlasörAdı)
        {
            this.KlasörAdı = KlasörAdı;
            this.DosyaUzantısı = dosyaUzantısı;
            this.DosyaYolu= dosyaYolu;
            this.DosyaAdı = dosyaAdı;
            this.DosyaBoyutu = dosyaBoyutu;
            this.OluşturmaTarihi = OluşturmaTarihi;
            
        }

        public override string ToString()
        {
            return this.DosyaAdı;
        }
    }
}
