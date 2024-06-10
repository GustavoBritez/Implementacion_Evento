using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5_1
{
    public class Profesor : IPersona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Clase { get; set; }
        public string Materia { get; set; }

        public Profesor()
        {
            Edad = 0;
            Nombre = "default";
            Clase = "default";
            Materia = "---";
        }
        public Profesor(string nombre, int edad, string clase, string materia)
        {
            Edad = edad;
            Nombre = nombre;
            Clase = clase;
            Materia = materia;
        }
        public Profesor(Profesor a)
        {
            Edad = a.Edad;
            Nombre = a.Nombre;
            Clase = a.Clase;
            Materia = a.Materia;
        }

        public void Soy()
        {
            MessageBox.Show($" Soy {this.Clase}, mi nombre es {this.Nombre} ");
        }
        public void My_Class()
        {
            MessageBox.Show($" Soy Mi clase es {this.Clase}");
        }
        public void My_Edad()
        {
            MessageBox.Show($" Mi nombre es {this.Nombre} - Edad: {this.Edad} ");
        }

    }
}
