using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servis_project.Data
{
   public class Connection
    {
        public static zaraEntities dm=new zaraEntities();
        public static prijava_Kupci_Result kupac { get; set; }
    }
}
