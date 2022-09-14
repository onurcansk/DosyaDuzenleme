using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyaDüzenleme.DosyaTürleri
{
    public class Bmp:Dosya
    {
        internal const string _dosyaUzantısı = "bmp";
        public override string DosyaUzantısı { get { return _dosyaUzantısı; } }
        private const string _klasörAdı = "Resim Dosyası";
        public override string KlasörAdı { get { return _klasörAdı; } }
        internal Bmp(string dosyaYolu, string dosyaAdı, long dosyaBoyutu, DateTime geçerlilikTarihi) : base(dosyaYolu, dosyaAdı, dosyaBoyutu, geçerlilikTarihi, _dosyaUzantısı, _klasörAdı)
        {
        }
    }
}
