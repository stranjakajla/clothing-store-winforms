using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servis_project.Data
{
    public class BojaDA
    {
        public static List<Boja> bojacombo()
        {
            return Connection.dm.Bojacombo().ToList();
        }
    }
}
