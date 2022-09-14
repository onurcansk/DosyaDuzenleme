using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyaDüzenleme.Exceptions
{
    public class ErişimTarihiGeçenDosyaBulunamadıException:Exception
    {
        public ErişimTarihiGeçenDosyaBulunamadıException():base("Erişim tarihi geçen dosya bulunamadı.")
        {

        }
    }
}
