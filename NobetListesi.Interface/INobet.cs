using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NobetListesi.Interface
{
    public interface INobet
    {
        void NobetList(string adSoyad, string telNo, string mail);
        DataTable NobetListGrid();
        void NobetDongu(DateTime dt);
        DataTable Kisiler(string ay);
    }
}
