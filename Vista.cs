using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Clase5_1
{
    public class Vista
    {
        public List<Alumno> lista_alumno = new();
        public List<Profesor> lista_profesor = new();
        public List<Object> Vista_Combinada()
        {
            List<Object> lista_ = new();
            lista_.AddRange(lista_alumno);
            lista_.AddRange(lista_profesor);
            return lista_;
        }

        public void Agregar_Clase(Profesor a)
        {
            lista_profesor.Add(new Profesor(a));
        }
        public void Eliminar_Clase(Profesor a)
        {
            lista_profesor.Remove(a);
        }
        public void Agregar_Clase( Alumno a )
        {
            lista_alumno.Add(new Alumno(a));
        }
        public void Eliminar_Clase( Alumno a )
        {
            lista_alumno.Remove(a);
        }
    }
}
