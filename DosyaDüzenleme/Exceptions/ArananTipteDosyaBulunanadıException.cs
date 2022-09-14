using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyaDüzenleme.Exceptions
{
    public class ArananTipteDosyaBulunanadıException:Exception
    {
        public ArananTipteDosyaBulunanadıException():base("Girilen dizinde aradığınız tipte dosya bulunamadı.")
        {

        }
    }
}
