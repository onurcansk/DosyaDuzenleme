using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyaDüzenleme.DosyaTürleri
{
    
    public class WinRAR : Dosya
    {
        internal const string _dosyaUzantısı = "rar";
        public override string DosyaUzantısı { get { return _dosyaUzantısı; } }
        private const string _klasörAdı = "Sıkıştırılmış Dosyalar";
        public override string KlasörAdı { get { return _klasörAdı; } }
        internal WinRAR(string dosyaYolu, string dosyaAdı, long dosyaBoyutu, DateTime geçerlilikTarihi) : base(dosyaYolu, dosyaAdı, dosyaBoyutu, geçerlilikTarihi, _dosyaUzantısı, _klasörAdı)
        {
        }
    }
}
