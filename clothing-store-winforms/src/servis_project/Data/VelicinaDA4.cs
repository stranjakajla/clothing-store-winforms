using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servis_project.Data
{
    public class VelicinaDA4
    {
        public static List<Velicina> velicinacombo()
        {
            return Connection.dm.Velicinacombo().ToList();
        }
    }
}
