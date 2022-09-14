using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyaDüzenleme.DosyaTürleri
{   
    public class WordBelgesi : Dosya
    {
        internal const string _dosyaUzantısı = "docx";
        public override string DosyaUzantısı { get { return _dosyaUzantısı; } }
        private const string _klasörAdı = "Microsoft Word";
        public override string KlasörAdı { get { return _klasörAdı; } }
        internal WordBelgesi(string dosyaYolu, string dosyaAdı, long dosyaBoyutu, DateTime geçerlilikTarihi) : base(dosyaYolu, dosyaAdı, dosyaBoyutu, geçerlilikTarihi, _dosyaUzantısı, _klasörAdı)
        {
        }
    }
}
