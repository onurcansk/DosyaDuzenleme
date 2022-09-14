using DosyaDüzenleme.Interfaceler;

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using DosyaDüzenleme.DosyaTürleri;
using System.Web.UI.WebControls;
using DosyaDüzenleme.Exceptions;
using Newtonsoft.Json;

namespace DosyaDüzenleme.Dosyaİşlemleri
{
    /// <summary>
    /// Constructor'da gönderilen parametredeki dosya yolunda bulunan bütün dosyaları bir listeye ekler. Bu listeye direkt instance üzerinden ulaşılabilir.
    /// </summary>
    public class Dosyalar : IList<Dosya>
    {

        internal List<string> TümDosyalar;

        internal List<Dosya> DizindekiDosyalar;
        internal string DüzenlemeYapılacakDosyaUzantısı { get; set; }

        public int Count => ((ICollection<Dosya>)DizindekiDosyalar).Count;

        public bool IsReadOnly => ((ICollection<Dosya>)DizindekiDosyalar).IsReadOnly;

        public Dosya this[int index] { get => ((IList<Dosya>)DizindekiDosyalar)[index]; set => ((IList<Dosya>)DizindekiDosyalar)[index] = value; }

        public Dosyalar()
        {
            TümDosyalar = new List<string>();
            DizindekiDosyalar = new List<Dosya>();
            GeriSerileştirme();
            Dosyaİşlemleri._dosyalar = this;
        }

        ~Dosyalar()
        {
            Serileştirme();
        }

        /// <summary>
        /// Sınıf oluşturulurken gönderilen dosya yolundaki dosyaların nesnesinin tutulduğu listeyi geri döndürür.
        /// </summary>
        /// <returns></returns>
        public List<Dosya> GetDosyalar()
        {
            return DizindekiDosyalar;
        }
        /// <summary>
        /// Sınıf oluşturulurken gönderilen dosya yolundaki dosyaların nesnesinin tutulduğu listenin içerisinden istenilen türdeki dosyaların listesini geri döndürür.
        /// </summary>
        /// <param name="uzantı"></param>
        /// <returns></returns>
        /// <exception cref="ArananTipteDosyaBulunanadıException"></exception>
        public List<Dosya> GetDosyalar(string uzantı)
        {
            List<Dosya> list = new List<Dosya>();
            foreach (var item in DizindekiDosyalar)
            {
                if (item.DosyaUzantısı == uzantı)
                {
                    list.Add(item);
                }
            }

            if (list.Count > 0)
            {
                return list;
            }
            else
            {
                throw new ArananTipteDosyaBulunanadıException();
            }
        }

        public void TümDosyalarıAl(string dosyaUzantısı)
        {
            this.DüzenlemeYapılacakDosyaUzantısı = dosyaUzantısı;
            string[] tümDosyalar = Directory.GetFiles(DüzenlemeYapılacakDosyaUzantısı);
            if (tümDosyalar.Length == 0)
            {
                DizindekiDosyalar.Clear();
                throw new ListedeÜrünYokException();
            }
            TümDosyalar.AddRange(tümDosyalar);
            DosyaNesneleriOlustur();
        }

        private void DosyaNesneleriOlustur()
        {
            DizindekiDosyalar.Clear();        
            foreach (string item in TümDosyalar)
            {
                FileInfo fileInfo = new FileInfo(item);
                DateTime OluşturmaZamani = Directory.GetCreationTime(item);
                string extension = fileInfo.Extension;
                string dosyaAdı = fileInfo.Name;
                long dosyaBoyutu = fileInfo.Length;
                Dosya dosya = DosyaTürüÜretim.GetDosyaTürüÜretim().DosyaNesnesiOluştur(item, extension.Remove(0, 1), dosyaAdı, dosyaBoyutu, OluşturmaZamani);
                DizindekiDosyalar.Add(dosya);
            }
            TümDosyalar.Clear();
        }


        private void Serileştirme()
        {
            JsonSerializer js = new JsonSerializer();

            Directory.CreateDirectory($@"Serialization");

            StreamWriter sw = new StreamWriter($@"Serialization\serial.json");

            JsonWriter jkw = new JsonTextWriter(sw);

            js.Serialize(jkw, this);
            sw.Close();
            jkw.Close();
        }

        public void Serileştirme(string Konum)
        {
            JsonSerializer js = new JsonSerializer();
            Directory.CreateDirectory($@"{Konum}\Serialization");
            StreamWriter sw = new StreamWriter($@"{Konum}\Serialization\serial.json");
            JsonWriter jkw = new JsonTextWriter(sw);
            js.Serialize(jkw, DizindekiDosyalar);
            sw.Close();
            jkw.Close();
        }


        private void GeriSerileştirme()
        {
           
            JsonSerializer js = new JsonSerializer();
            if (File.Exists($@"Serialization\serial.json"))
            {
                StreamReader sr = new StreamReader($@"Serialization\serial.json");
                JsonReader jsonReader = new JsonTextReader(sr);
                DizindekiDosyalar = js.Deserialize<List<Dosya>>(jsonReader);
                jsonReader.Close();
                sr.Close();
            }

        }

        private void GeriSerileştirme(string konum)
        {
            JsonSerializer js = new JsonSerializer();
            if (File.Exists($@"{konum}\Serialization\serial.json"))
            {
                StreamReader sr = new StreamReader($@"{konum}\Serialization\serial.json");
                JsonReader jsonReader = new JsonTextReader(sr);
                DizindekiDosyalar = js.Deserialize<List<Dosya>>(jsonReader);
                jsonReader.Close();
                sr.Close();
            }


        }


        public int IndexOf(Dosya item)
        {
            return ((IList<Dosya>)DizindekiDosyalar).IndexOf(item);
        }

        public void Insert(int index, Dosya item)
        {
            ((IList<Dosya>)DizindekiDosyalar).Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            ((IList<Dosya>)DizindekiDosyalar).RemoveAt(index);
        }

        public void Add(Dosya item)
        {
            ((ICollection<Dosya>)DizindekiDosyalar).Add(item);
        }

        public void Clear()
        {
            ((ICollection<Dosya>)DizindekiDosyalar).Clear();
        }

        public bool Contains(Dosya item)
        {
            return ((ICollection<Dosya>)DizindekiDosyalar).Contains(item);
        }

        public void CopyTo(Dosya[] array, int arrayIndex)
        {
            ((ICollection<Dosya>)DizindekiDosyalar).CopyTo(array, arrayIndex);
        }

        public bool Remove(Dosya item)
        {
            return ((ICollection<Dosya>)DizindekiDosyalar).Remove(item);
        }
        public IEnumerator<Dosya> GetEnumerator()
        {
            return ((IEnumerable<Dosya>)DizindekiDosyalar).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)DizindekiDosyalar).GetEnumerator();
        }
    }
}
