using DosyaDüzenleme.DosyaTürleri;
using DosyaDüzenleme.Interfaceler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyaDüzenleme.Dosyaİşlemleri
{
    public class DosyaTürüÜretim
    {
        private static DosyaTürüÜretim _dosyaTürüÜretim;
        public static DosyaTürüÜretim GetDosyaTürüÜretim()
        {
            if (_dosyaTürüÜretim == null)
            {
                _dosyaTürüÜretim = new DosyaTürüÜretim();
            }
            return _dosyaTürüÜretim;
        }
        private DosyaTürüÜretim()
        {

        }
        public Dosya DosyaNesnesiOluştur(string dosyaYolu, string dosyaUzantısı, string dosyaAdı, long dosyaBoyutu, DateTime OluşturmaTarihi)
        {
            switch (dosyaUzantısı.ToLower())
            {
                case MetinBelgesi._dosyaUzantısı: return new MetinBelgesi(dosyaYolu, dosyaAdı, dosyaBoyutu, OluşturmaTarihi);
                case MicrosoftAccess._dosyaUzantısı: return new MicrosoftAccess(dosyaYolu, dosyaAdı, dosyaBoyutu, OluşturmaTarihi);
                case Excel._dosyaUzantısı: return new Excel(dosyaYolu, dosyaAdı, dosyaBoyutu, OluşturmaTarihi);
                case PowerPoint._dosyaUzantısı: return new PowerPoint(dosyaYolu, dosyaAdı, dosyaBoyutu, OluşturmaTarihi);
                case WordBelgesi._dosyaUzantısı: return new WordBelgesi(dosyaYolu, dosyaAdı, dosyaBoyutu, OluşturmaTarihi);
                case WinRAR._dosyaUzantısı: return new WinRAR(dosyaYolu, dosyaAdı, dosyaBoyutu, OluşturmaTarihi);
                case PNG._dosyaUzantısı: return new PNG(dosyaYolu, dosyaAdı, dosyaBoyutu, OluşturmaTarihi);
                case Bmp._dosyaUzantısı: return new Bmp(dosyaYolu, dosyaAdı, dosyaBoyutu, OluşturmaTarihi);
                case ZIP._dosyaUzantısı: return new ZIP(dosyaYolu, dosyaAdı, dosyaBoyutu, OluşturmaTarihi);
                case Rtf._dosyaUzantısı: return new Rtf(dosyaYolu, dosyaAdı, dosyaBoyutu, OluşturmaTarihi);              
                default:
                    return null;
            }
        }
    }
}
