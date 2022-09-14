using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyaDüzenleme.Exceptions
{
    public class ListedeÜrünYokException:Exception
    {
        public ListedeÜrünYokException():base("Girilen dizinde dosya bulunamadı.")
        {

        }
    }
}
