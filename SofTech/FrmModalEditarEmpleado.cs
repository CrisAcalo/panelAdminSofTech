using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku_GUI
{
    public partial class FrmModalEditarEmpleado : Form
    {

        private FormPrincipal formPrincipalIns; // Propiedad para guardar la referencia al Form1
        private frmVerEmpleados formVerEmpleadosIns; // Propiedad para guardar la referencia al Form1
        static Random random = new Random();

        private Empleado empleadoIns;
        public FrmModalEditarEmpleado(FormPrincipal formPrincipal,frmVerEmpleados formVerEmpleados,Empleado empleado)
        {
            InitializeComponent();
            formPrincipalIns = formPrincipal;

            formVerEmpleadosIns = formVerEmpleados;
            lb_bienvenida.Text = "Hola "+empleado.Nombre.ToString()+"!";
            txtBxNombre.Text = empleado.Nombre.ToString();
            txtBxApellido.Text = empleado.Apellido.ToString();
            txtBxCargo.Text = empleado.Cargo.ToString();
            txtBxPagoHora.Text = empleado.PagoPorHora.ToString();
            txtBxHorasTrabajo.Text = empleado.HorasTrabajadas.ToString();
            txtBxCodigo.Text = empleado.Codigo.ToString();

            empleadoIns = empleado;
        }
        int i;

        private void FrmModalEditarEmpleado_Load(object sender, EventArgs e)
        {
            i = formVerEmpleadosIns.parentY + 150;

            this.Location = new Point(formVerEmpleadosIns.parentX + 220, formVerEmpleadosIns.parentY + 150);
        }

        private void modalEffect_Timer_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                modalEffect_Timer.Stop();
            }
            else
            {
                Opacity += .03;
            }

            int y = formVerEmpleadosIns.parentY += 3;
            this.Location = new Point(formVerEmpleadosIns.parentX + 220, y);

            if (y >= i)
            {
                modalEffect_Timer.Stop();
            }
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBxNombre.Text) && !string.IsNullOrEmpty(txtBxApellido.Text)
                && !string.IsNullOrEmpty(txtBxCargo.Text) && !string.IsNullOrEmpty(txtBxPagoHora.Text)
                && !string.IsNullOrEmpty(txtBxHorasTrabajo.Text))
            {
                string nombre = txtBxNombre.Text;
                string apellido = txtBxApellido.Text;
                string cargo = txtBxCargo.Text;
                double pagoPorHora = Double.Parse(txtBxPagoHora.Text);
                double horasTrabajadas = Double.Parse(txtBxHorasTrabajo.Text);

                Empleado empleado = BuscarEmpleadoPorCodigo(empleadoIns.Codigo);
                //frmVerEmpleados frmVer = new frmVerEmpleados(formPrincipalIns);

                if (empleado != null)
                {
                    empleado.Nombre = nombre;
                    empleado.Apellido = apellido;
                    empleado.Cargo = cargo;
                    empleado.PagoPorHora = pagoPorHora;
                    empleado.HorasTrabajadas = horasTrabajadas;
                    empleado.SueldoTotal = empleado.CalcularSueldoTotal();

                    this.Close();

                    MessageBox.Show("El empleado ha sido acatualizado exitosamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Actualizar el archivo de texto
                    ActualizarArchivoDeTexto();
                    //formPrincipalIns.AbrirFormulario<frmVerEmpleados>(formPrincipalIns);

                    // Cerrar y eliminar el formulario actual (si existe)
                    if (formPrincipalIns.panelFormularios.Controls.Count > 0)
                    {
                        var currentForm = formPrincipalIns.panelFormularios.Controls[0] as Form;
                        currentForm.Close();
                        formPrincipalIns.panelFormularios.Controls.Clear();
                    }

                    // Crear una nueva instancia del formulario recibido como parámetro
                    Form formulario = new frmVerEmpleados(formPrincipalIns);
                    formulario.TopLevel = false;
                    formulario.FormBorderStyle = FormBorderStyle.None;
                    formulario.Dock = DockStyle.Fill;
                    formPrincipalIns.panelFormularios.Controls.Add(formulario);
                    formPrincipalIns.panelFormularios.Tag = formulario;
                    formulario.Show();
                    formulario.BringToFront();
                }
                else
                {
                    MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        static Empleado BuscarEmpleadoPorCodigo(int codigo)
        {
            if (FormPrincipal.tablaHash.ContainsKey(codigo))
            {
                return FormPrincipal.tablaHash[codigo];
            }
            return null;
        }

        static void ActualizarArchivoDeTexto()
        {
            string archivo = "nomina.txt";

            File.WriteAllText("nomina.txt", string.Empty);

            using (StreamWriter writer = new StreamWriter(archivo))
            {
                foreach (Empleado empleado in FormPrincipal.empleados)
                {
                    writer.WriteLine($"{empleado.Codigo},{empleado.Nombre},{empleado.Apellido},{empleado.Cargo},{empleado.PagoPorHora},{empleado.HorasTrabajadas}");
                }
            }
        }
    }
}
