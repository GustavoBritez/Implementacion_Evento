using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5_1
{
    public class Alumno : IPersona
    {
        public string Nombre { get; set; }
        public int Edad {  get; set; }
        public string Clase {  get; set; }
        public string Materia { get; set; }

        public Alumno()
        {
            Edad = 0;
            Nombre = "default";
            Clase = "default";
            Materia = "---";
        }
        public Alumno ( string nombre, int edad, string clase)
        {
            Edad = edad;
            Nombre = nombre;
            Clase = clase;
            Materia = "---";
        }
        public Alumno( Alumno a )
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
            MessageBox.Show( $" Soy Mi clase es {this.Clase}" );
        }
        public void My_Edad()
        {
            MessageBox.Show($" Mi nombre es {this.Nombre} - Edad: {this.Edad} ");
        }

    }
}
