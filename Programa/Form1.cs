using Programa.Datos;
using Programa.Model;
using System.Data;
using System.Drawing.Text;

namespace Programa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa un nombre");
            }
            else if (txtNombre.Text.Trim().Length <= 5)
            {
                MessageBox.Show("Ingresa un numero Mayor a 5 Caracteres");
            }
            else if (txtCalificacion.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa una calificacion");
            }
            else
            { 
            
              try 
                {
                    Alumno Al = new Alumno();
                    Al.Nombre = txtNombre.Text;
                    Al.Calificacion = Convert.ToInt32(txtCalificacion.Text.Trim());

                    if (AlumnoContraller.guardar(Al))
                    {
                        llenarGrid();
                        limpiarCampos();
                        MessageBox.Show("Alumno guardado correctamente");
                    }
                  
                }catch (Exception A)

                {
                    MessageBox.Show(A.Message);
                }
            }
           
        }

        private void llenarGrid()
        {
            DataTable datos = AlumnoContraller.Listar();
            if (datos ==null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }

            else
            {
                dgLista.DataSource = datos.DefaultView;

            }

        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtCalificacion.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if  (txtNombre.Text.Trim()=="")
            {
                MessageBox.Show("Ingreso un nombre");
            }
            else
            {
                Alumno Al = AlumnoContraller.consultar(txtNombre.Text.Trim());
                if (Al == null)
                {
                    MessageBox.Show("no existe el Alumno" + txtNombre);
                    limpiarCampos();
                }
                else
                {
                    txtNombre.Text = Al.Nombre;
                    txtCalificacion.Text = Al.Calificacion.ToString();
                }
            }
        }
    }
}