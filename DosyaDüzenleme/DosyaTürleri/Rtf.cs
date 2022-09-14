using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyaDüzenleme.DosyaTürleri
{
    public class Rtf:Dosya
    {
        internal const string _dosyaUzantısı = "rtf";
        public override string DosyaUzantısı { get { return _dosyaUzantısı; } }
        private const string _klasörAdı = "Metin Belgesi";
        public override string KlasörAdı { get { return _klasörAdı; } }
        internal Rtf(string dosyaYolu, string dosyaAdı, long dosyaBoyutu, DateTime geçerlilikTarihi) : base(dosyaYolu, dosyaAdı, dosyaBoyutu, geçerlilikTarihi, _dosyaUzantısı, _klasörAdı)
        {
        }
    }
}
