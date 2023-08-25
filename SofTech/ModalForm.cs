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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Sudoku_GUI
{
    public partial class ModalForm : Form
    {
        private FormPrincipal formPrincipalIns; // Propiedad para guardar la referencia al Form1
        static Random random = new Random();

        static List<Empleado> dataList = FormPrincipal.empleados;

        int codigo;
        public ModalForm(FormPrincipal formPrincipal)
        {
            InitializeComponent();

            formPrincipalIns = formPrincipal; // Guardar la referencia del Form1 cuando se instancia Form2

            do
            {
                codigo = generarCodigoEmpleado();
            } while (FormPrincipal.tablaHash.ContainsKey(codigo));

            txtBxCodigo.Text = codigo.ToString();
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

            int y = FormPrincipal.parentY += 3;
            this.Location = new Point(FormPrincipal.parentX + 220, y);

            if (y >= i)
            {
                modalEffect_Timer.Stop();
            }
        }

        int i;
        private void ModalForm_Load(object sender, EventArgs e)
        {
            i = FormPrincipal.parentY + 150;

            this.Location = new Point(FormPrincipal.parentX + 220, FormPrincipal.parentY + 150);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbFacil_Click(object sender, EventArgs e)
        {
            //formPrincipalIns.startNewGame(3);
            this.Close();
        }

        private void lbMedio_Click(object sender, EventArgs e)
        {
            //formPrincipalIns.startNewGame(2);
            this.Close();
        }

        private void lbDificil_Click(object sender, EventArgs e)
        {
            //formPrincipalIns.startNewGame(1);
            this.Close();
        }

        private void lbBlanco_Click(object sender, EventArgs e)
        {
            //formPrincipalIns.startNewGame(0);
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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

                Empleado newEmpleado = new Empleado(codigo, nombre, apellido, cargo, pagoPorHora, horasTrabajadas);

                if (newEmpleado != null)
                {
                    if (formPrincipalIns.EmpleadoYaRegistrado(newEmpleado))
                    {
                        DialogResult result = MessageBox.Show("Ya existe un empleado con datos similares", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (result == DialogResult.OK)
                        {
                            FormPrincipal.empleados.Add(newEmpleado);
                            FormPrincipal.tablaHash[codigo] = FormPrincipal.empleados[FormPrincipal.empleados.Count - 1]; // Agregar al diccionario

                            // Actualizar el archivo de texto
                            ActualizarArchivoDeTexto();

                            //Cerrar y eliminar el formulario actual(si existe)
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

                            //tbDatosEmpleados.DataSource = dataList;

                            MessageBox.Show("El empleado ha sido ingresado exitosamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        FormPrincipal.empleados.Add(newEmpleado);
                        FormPrincipal.tablaHash[codigo] = FormPrincipal.empleados[FormPrincipal.empleados.Count - 1]; // Agregar al diccionario

                        // Actualizar el archivo de texto
                        ActualizarArchivoDeTexto();

                        //Cerrar y eliminar el formulario actual(si existe)
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

                        //tbDatosEmpleados.DataSource = dataList;

                        MessageBox.Show("El empleado ha sido ingresado exitosamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No puede ingresar un empleado sin datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ActualizarArchivoDeTexto()
        {
            using (StreamWriter writer = new StreamWriter("nomina.txt"))
            {
                foreach (Empleado empleado in FormPrincipal.empleados)
                {
                    writer.WriteLine($"{empleado.Codigo},{empleado.Nombre},{empleado.Apellido},{empleado.Cargo},{empleado.PagoPorHora},{empleado.HorasTrabajadas}");
                }
            }
        }

        static int generarCodigoEmpleado()
        {
            // Generar un número aleatorio de 6 dígitos
            return random.Next(100000, 1000000); // Genera entre 100000 y 999999
        }

        private void txtBxPagoHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar el evento si no es un número o control
            }
        }

        private void txtBxHorasTrabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar el evento si no es un número o control
            }
        }

        private void lbTituloFormulario_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla ingresada es una letra o un espacio
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b') // '\b' representa la tecla de retroceso
            {
                e.Handled = true; // Bloquear la tecla
            }
        }

        private void txtBxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla ingresada es una letra o un espacio
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b') // '\b' representa la tecla de retroceso
            {
                e.Handled = true; // Bloquear la tecla
            }
        }

        private void txtBxCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla ingresada es una letra o un espacio
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b') // '\b' representa la tecla de retroceso
            {
                e.Handled = true; // Bloquear la tecla
            }
        }
    }
}
