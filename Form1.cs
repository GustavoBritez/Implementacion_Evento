using Microsoft.VisualBasic;

namespace Clase5_1
{
    public partial class Form1 : Form
    {
        Vista lista;
        public Form1()
        {
            InitializeComponent();
            lista = new Vista();
        }


        #region " Mostrar"

        public void Mostrar()
        {
            DGV_Clases.DataSource = null;
            DGV_Clases.DataSource = lista.Vista_Combinada();
        }
        #endregion

        private void Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                string Nombre = Interaction.InputBox("Nombre:");
                int Edad = Convert.ToInt32(Interaction.InputBox("Edad:"));
                string tipo = string.Empty;
                if (C_Alumno.Checked == true)
                {
                    tipo = "Alumno";
                    Alumno a = new(Nombre, Edad, tipo);
                    lista.Agregar_Clase(a);
                }
                if (C_Profesor.Checked == true)
                {
                    tipo = "Profesor";
                    string Materia = Interaction.InputBox("Materia:");
                    Profesor p = new(Nombre,Edad,tipo,Materia);
                    lista.Agregar_Clase(p);
                }
             
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                Mostrar();
            }
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                Mostrar();
            }
        }
    }
}