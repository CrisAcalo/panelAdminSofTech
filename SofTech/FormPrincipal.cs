using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Sudoku_GUI
{
    public partial class FormPrincipal : Form
    {
        public static Dictionary<int, Empleado> tablaHash = new Dictionary<int, Empleado>();

        //Lista donde se guardan los empleados
        public static List<Empleado> empleados = new List<Empleado>();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        int lx, ly;
        int sw, sh;

        public static int parentX, parentY;


        Random random = new Random();

        public FormPrincipal()
        {
            CargarDatosDesdeArchivo();
            InitializeComponent();
            //InitializeButtonEvents();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

        }


        public void CargarDatosDesdeArchivo()
        {
            if (File.Exists("nomina.txt"))
            {
                string[] lines = File.ReadAllLines("nomina.txt");

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 6)
                    {
                        int codigo = int.Parse(parts[0]);
                        string nombre = parts[1];
                        string apellido = parts[2];
                        string cargo = parts[3];
                        double pagoPorHora = double.Parse(parts[4]);
                        double horasTrabajadas = double.Parse(parts[5]);

                        Empleado newEmpleado = new Empleado(codigo, nombre, apellido, cargo, pagoPorHora, horasTrabajadas);

                        if (!EmpleadoYaRegistrado(newEmpleado))
                        {
                            empleados.Add(newEmpleado);
                            tablaHash[codigo] = empleados[empleados.Count - 1]; // Agregar al diccionario
                        }
                    }
                }
            }
        }
        private void btnImportarDatos_Click(object sender, EventArgs e)
        {
            int size = -1;
            bool errorFormato = false;
            openFileDialog1.Title = "Archivo de datos a importar";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult result = openFileDialog1.ShowDialog(); // Mostrar el cuadro de diálogo.

            if (result == DialogResult.OK) // Comprobar el resultado.
            {
                string file = openFileDialog1.FileName;

                DialogResult resultConfirm = MessageBox.Show("¿Está seguro que desea importar el archivo: " + file + "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (resultConfirm == DialogResult.OK)
                {
                    try
                    {
                        if (File.Exists(file))
                        {
                            string[] lines = File.ReadAllLines(file);
                            if (lines.Length==0)
                            {
                                MessageBox.Show("Archivo Vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                foreach (string line in lines)
                                {
                                    string[] parts = line.Split(',');

                                    if (parts.Length == 6)
                                    {
                                        int codigo;
                                        if (int.TryParse(parts[0], out codigo) && !tablaHash.ContainsKey(codigo))
                                        {
                                            string nombre = parts[1];
                                            string apellido = parts[2];
                                            string cargo = parts[3];
                                            double pagoPorHora;
                                            if (double.TryParse(parts[4], out pagoPorHora))
                                            {
                                                double horasTrabajadas;
                                                if (double.TryParse(parts[5], out horasTrabajadas))
                                                {

                                                    empleados.Add(new Empleado(codigo, nombre, apellido, cargo, pagoPorHora, horasTrabajadas));
                                                    tablaHash[codigo] = empleados[empleados.Count - 1]; // Agregar al diccionario
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Error en el formato de las horas trabajadas en la línea: " + line, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Error en el formato del pago por hora en la línea: " + line, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("El código de empleado de la línea: " + line + " ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        errorFormato = true;
                                    }
                                }
                                if (errorFormato)
                                {
                                    MessageBox.Show("El archivo tiene un error de formato en una de sus líneas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                //Cerrar y eliminar el formulario actual(si existe)
                                if (panelFormularios.Controls.Count > 0)
                                {
                                    var currentForm = panelFormularios.Controls[0] as Form;
                                    currentForm.Close();
                                    panelFormularios.Controls.Clear();
                                }

                                // Crear una nueva instancia del formulario recibido como parámetro
                                Form formulario = new frmVerEmpleados(this);
                                formulario.TopLevel = false;
                                formulario.FormBorderStyle = FormBorderStyle.None;
                                formulario.Dock = DockStyle.Fill;
                                panelFormularios.Controls.Add(formulario);
                                panelFormularios.Tag = formulario;
                                formulario.Show();
                                formulario.BringToFront();

                                //MessageBox.Show("Los datos se han importado exitosamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error de entrada/salida: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        //---------------------------------------------------------------------------------------------------------//
        //---------------------------- CODIGO PARA MEJORAR LA MOVILIDAD DE LA VENTANA -----------------------------//
        //---------------------------------------------------------------------------------------------------------//

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            parentX = this.Location.X;
            parentY = this.Location.Y;

            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

        }

        private void label_principal_Click(object sender, EventArgs e)
        {

        }

        private void btnModal_MouseEnter(object sender, EventArgs e)
        {
            this.btnModal.BackColor = Color.FromArgb(100, 255, 218);
            this.btnModal.ForeColor = Color.FromArgb(10, 26, 36);
        }

        private void btnModal_MouseLeave(object sender, EventArgs e)
        {
            this.btnModal.BackColor = Color.FromArgb(10, 26, 36);
            this.btnModal.ForeColor = Color.FromArgb(100, 255, 218);
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            parentX = this.Location.X;
            parentY = this.Location.Y;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<frmVerEmpleados>(this);

            // Cerrar y eliminar el formulario actual (si existe)
            if (panelFormularios.Controls.Count > 0)
            {
                var currentForm = panelFormularios.Controls[0] as Form;
                currentForm.Close();
                panelFormularios.Controls.Clear();
            }

            // Crear una nueva instancia del formulario recibido como parámetro
            frmVerEmpleados formulario = new frmVerEmpleados(this);
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelFormularios.Controls.Add(formulario);
            panelFormularios.Tag = formulario;
            formulario.Show();
            formulario.BringToFront();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelFormularios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (ModalForm modal = new ModalForm(this))
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                parentX = this.Location.X;
                parentY = this.Location.Y;

                modal.ShowDialog();
                modalBackground.Dispose();

            }
        }


        public void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            // Cerrar y eliminar el formulario actual (si existe)
            if (panelFormularios.Controls.Count > 0)
            {
                var currentForm = panelFormularios.Controls[0] as Form;
                currentForm.Close();
                panelFormularios.Controls.Clear();
            }

            // Crear y mostrar una nueva instancia del formulario
            Form formulario = new MiForm();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelFormularios.Controls.Add(formulario);
            panelFormularios.Tag = formulario;
            formulario.Show();
            formulario.BringToFront();
        }

        public void AbrirFormulario<MiForm>(Form formParametro) where MiForm : Form, new()
        {
            // Cerrar y eliminar el formulario actual (si existe)
            if (panelFormularios.Controls.Count > 0)
            {
                var currentForm = panelFormularios.Controls[0] as Form;
                currentForm.Close();
                panelFormularios.Controls.Clear();
            }

            // Crear una nueva instancia del formulario recibido como parámetro
            Form formulario = new MiForm();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelFormularios.Controls.Add(formulario);
            panelFormularios.Tag = formulario;
            formulario.Show();
            formulario.BringToFront();
        }

        public bool EmpleadoYaRegistrado(Empleado empleado)
        {
            foreach (Empleado emp in empleados)
            {
                if (emp.Apellido == empleado.Apellido &&
                    emp.Nombre == empleado.Nombre &&
                    emp.Cargo == empleado.Cargo &&
                    emp.PagoPorHora == empleado.PagoPorHora &&
                    emp.HorasTrabajadas == empleado.HorasTrabajadas)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
