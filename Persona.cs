using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Clase5_1
{
    public interface IPersona 
    {
        public string Nombre { get; set; }
        public int Edad {  get; set; }

        public void Soy();
        public void My_Class();
        public void My_Edad();
    }
}
