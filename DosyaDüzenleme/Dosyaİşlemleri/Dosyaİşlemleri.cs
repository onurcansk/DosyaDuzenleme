using DosyaDüzenleme.DosyaTürleri;
using DosyaDüzenleme.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyaDüzenleme.Dosyaİşlemleri
{
    public class Dosyaİşlemleri
    {
        internal static Dosyalar _dosyalar;
        /// <summary>
        /// Bu metot kullanılarak klasörleme işlemi gerçekleştirilir.
        /// </summary>
        public void İlgiliKlasöreAyır()
        {
            foreach (var item in _dosyalar)
            {
                if (!Directory.Exists($@"{_dosyalar.DüzenlemeYapılacakDosyaUzantısı}\{item.KlasörAdı}"))
                {
                    Directory.CreateDirectory($@"{_dosyalar.DüzenlemeYapılacakDosyaUzantısı}\{item.KlasörAdı} ");
                }
            }
            DosyaTaşı();
        }

        private void DosyaTaşı()
        {
            AynıÖğeleriAyıkla();

            foreach (var item in _dosyalar)
            {
                if (item.GeçerlilikTarihi != default)
                {
                    if (DateTime.Now > item.GeçerlilikTarihi)
                    {
                        ÇöpKutusuOluştur();
                        File.Move(item.DosyaYolu, $@"{_dosyalar.DüzenlemeYapılacakDosyaUzantısı}\Çöp Kutusu\{item.DosyaAdı}");
                        item.DosyaYolu = $@"{_dosyalar.DüzenlemeYapılacakDosyaUzantısı}\Çöp Kutusu\{item.DosyaAdı}";
                        continue;
                    }
                    File.Move(item.DosyaYolu, $@"{_dosyalar.DüzenlemeYapılacakDosyaUzantısı}\{item.KlasörAdı}\{item.DosyaAdı}");
                    item.DosyaYolu = $@"{_dosyalar.DüzenlemeYapılacakDosyaUzantısı}\{item.KlasörAdı}\{item.DosyaAdı}";
                    continue;
                }
                File.Move(item.DosyaYolu, $@"{_dosyalar.DüzenlemeYapılacakDosyaUzantısı}\{item.KlasörAdı}\{item.DosyaAdı}");
                item.DosyaYolu = $@"{_dosyalar.DüzenlemeYapılacakDosyaUzantısı}\{item.KlasörAdı}\{item.DosyaAdı}";

            }
        }
        /// <summary>
        /// İlgili konumdaki dosyalara belirli bir erişim tarihi verilebilir. Bu metot kullanılarak erişim tarihi Datetime.Now ile karşılaştırılır. Erişim tarihi geçen dosyalar oluşturulan Çöp Kutusu klasörüne taşınır.
        /// </summary>
        public Dosya ErişimTarihiGeçenleriTaşı()
        {
            Dosya[] dizi = new Dosya[_dosyalar.Count];
            _dosyalar.DizindekiDosyalar.CopyTo(dizi);

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i].GeçerlilikTarihi != default)
                {
                    if (DateTime.Now > dizi[i].GeçerlilikTarihi)
                    {
                        ÇöpKutusuOluştur();
                        if (File.Exists(dizi[i].DosyaYolu))
                        {
                            File.Move(dizi[i].DosyaYolu, $@"{_dosyalar.DüzenlemeYapılacakDosyaUzantısı}\Çöp Kutusu\{dizi[i].DosyaAdı}");
                            dizi[i].DosyaYolu = $@"{_dosyalar.DüzenlemeYapılacakDosyaUzantısı}\Çöp Kutusu\{dizi[i].DosyaAdı}";
                            return dizi[i];
                        }
                    }
                }
            }
            throw new ErişimTarihiGeçenDosyaBulunamadıException();
        }

        private void AynıÖğeleriAyıkla()
        {
            Dosya[] dizi = new Dosya[_dosyalar.Count];
            _dosyalar.DizindekiDosyalar.CopyTo(dizi);

            for (int i = 0; i < dizi.Length; i++)
            {
                for (int j = i + 1; j < dizi.Length; j++)
                {
                    if (dizi[i].DosyaBoyutu > 80000)
                    {
                        if (dizi[i].DosyaBoyutu == dizi[j].DosyaBoyutu)
                        {
                            ÇöpKutusuOluştur();
                            File.Move(dizi[i].DosyaYolu, $@"{_dosyalar.DüzenlemeYapılacakDosyaUzantısı}\Çöp Kutusu\{dizi[i].DosyaAdı}");
                            _dosyalar.Remove(dizi[i]);
                        }
                    }
                }
            }

        }
        private void ÇöpKutusuOluştur()
        {
            if (!Directory.Exists($@"{_dosyalar.DüzenlemeYapılacakDosyaUzantısı}\Çöp Kutusu"))
            {
                Directory.CreateDirectory($@"{_dosyalar.DüzenlemeYapılacakDosyaUzantısı}\Çöp Kutusu");
            }
        }
    }
}
