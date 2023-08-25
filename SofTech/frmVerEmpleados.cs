using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku_GUI
{

    public partial class frmVerEmpleados : Form
    {

        FormPrincipal formPrincipalIns;
        static List<Empleado> dataList = FormPrincipal.empleados;

        public frmVerEmpleados()
        {
            // Inicialización u otras operaciones que puedan ser necesarias
        }
        public frmVerEmpleados(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            formPrincipalIns = formPrincipal;
        }
        private void frmVerEmpleados_Load(object sender, EventArgs e)
        {
            tbDatosEmpleados.AutoGenerateColumns = true;
            tbDatosEmpleados.DataSource = dataList;

            // Agregar las columnas de opciones con botones "Editar" y "Eliminar"
            DataGridViewButtonColumn optionsColumn = new DataGridViewButtonColumn();
            optionsColumn.Name = "Opcion Editar";
            optionsColumn.Text = "Editar";
            optionsColumn.UseColumnTextForButtonValue = true;
            tbDatosEmpleados.Columns.Add(optionsColumn);

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "Opcion Eliminar";
            deleteColumn.Text = "Eliminar";
            deleteColumn.UseColumnTextForButtonValue = true;
            tbDatosEmpleados.Columns.Add(deleteColumn);
        }

        private void tbDatosEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == tbDatosEmpleados.Columns["Opcion Editar"].Index)
                {
                    Empleado selectedEmpleado = dataList[e.RowIndex];
                    // Aquí puedes abrir un formulario de edición pasando el objeto 'selectedLibro'
                    EditRowWithSelectedEmpleado(selectedEmpleado);
                }
                else if (e.ColumnIndex == tbDatosEmpleados.Columns["Opcion Eliminar"].Index)
                {
                    Empleado selectedEmpleado = dataList[e.RowIndex];
                    // Aquí puedes realizar la acción de eliminación del objeto 'selectedLibro'
                    // y luego actualizar la vista del DataGridView
                    //dataList.Remove(selectedLibro);
                    //tbDatosEmpleados.Refresh();
                    DeleteRowWithSelectedEmpleado(selectedEmpleado);
                }
            }
        }
        public int parentX, parentY;
        public void EditRowWithSelectedEmpleado(Empleado empleado)
        {
            Form modalBackground = new Form();
            using (FrmModalEditarEmpleado modal = new FrmModalEditarEmpleado(formPrincipalIns, this, empleado))
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = formPrincipalIns.Size;
                modalBackground.Location = formPrincipalIns.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                parentX = this.Location.X + 220;
                parentY = this.Location.Y + 36;

                modal.ShowDialog();
                modalBackground.Dispose();
            }

        }

        private void DeleteRowWithSelectedEmpleado(Empleado empleado)
        {

            DialogResult result = MessageBox.Show("¿Está seguro de eliminar al empleado "+empleado.Nombre+" de código "+empleado.Codigo+"?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                if (empleado != null)
                {
                    FormPrincipal.empleados.Remove(empleado);
                    FormPrincipal.tablaHash.Remove(empleado.Codigo);

                    Console.WriteLine("Empleado eliminado exitosamente.");

                    // Actualizar el archivo de texto
                    ActualizarArchivoDeTexto();


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


                    MessageBox.Show("El empleado ha sido eliminado exitosamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un problema", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchTerm = txtBuscar.Text.Trim().ToLower();
            string opcionSeleccionada = cmbBxParametro.Text;
            List<Empleado> searchResults;

            if (string.IsNullOrEmpty(opcionSeleccionada) && !string.IsNullOrEmpty(searchTerm))
            {
                searchResults = dataList
                .Where(empleado =>
                empleado.Codigo.ToString().Contains(searchTerm) ||
                empleado.Nombre.ToLower().Contains(searchTerm) ||
                empleado.Apellido.ToLower().Contains(searchTerm) ||
                empleado.Cargo.ToLower().Contains(searchTerm))
                .ToList();

                tbDatosEmpleados.DataSource = searchResults;

            }
            else if (!string.IsNullOrEmpty(opcionSeleccionada) && !string.IsNullOrEmpty(searchTerm))
            {
                if (cmbBxParametro.Text == "Codigo")
                {
                    searchResults = dataList
                    .Where(empleado =>
                        empleado.Codigo.ToString().Contains(searchTerm)).ToList();

                    tbDatosEmpleados.DataSource = searchResults;
                }
                else if (cmbBxParametro.Text == "Nombre")
                {
                    searchResults = dataList
                    .Where(empleado => empleado.Nombre.ToLower().Contains(searchTerm)).ToList();

                    tbDatosEmpleados.DataSource = searchResults;
                }
                else if (cmbBxParametro.Text == "Apellido")
                {
                    searchResults = dataList
                    .Where(empleado => empleado.Apellido.ToLower().Contains(searchTerm)).ToList();

                    tbDatosEmpleados.DataSource = searchResults;
                }
                else if (cmbBxParametro.Text == "Cargo")
                {
                    searchResults = dataList
                    .Where(empleado => empleado.Cargo.ToLower().Contains(searchTerm)).ToList();

                    tbDatosEmpleados.DataSource = searchResults;
                }
                else
                {
                    tbDatosEmpleados.DataSource = dataList;
                }
            }
            else
            {
                tbDatosEmpleados.DataSource = dataList;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string optionSelected = cmbBxOrdenarSelect.Text;

            if (optionSelected == "Nombre")
            {
                List<Empleado> empleadosOrdenados = MergeSortByNombre(dataList);
                dataList = empleadosOrdenados;
                // Actualizar el archivo de texto
                ActualizarArchivoDeTexto();
                tbDatosEmpleados.DataSource = dataList;
            }
            else if (optionSelected == "Apellido")
            {
                List<Empleado> empleadosOrdenados = MergeSortByApellido(dataList);
                dataList = empleadosOrdenados;
                // Actualizar el archivo de texto
                ActualizarArchivoDeTexto();
                tbDatosEmpleados.DataSource = dataList;
            }
            else if (optionSelected == "Sueldo Total")
            {
                Console.WriteLine("---- Ordenar por sueldo total ----");
                List<Empleado> empleadosOrdenados = MergeSortBySueldoTotal(dataList);
                dataList = empleadosOrdenados;
                // Actualizar el archivo de texto
                ActualizarArchivoDeTexto();
                tbDatosEmpleados.DataSource = dataList;
            }
        }

        static List<Empleado> MergeSortByNombre(List<Empleado> employees)
        {
            if (employees.Count <= 1)
            {
                return employees;
            }

            int middle = employees.Count / 2;
            List<Empleado> left = employees.GetRange(0, middle);
            List<Empleado> right = employees.GetRange(middle, employees.Count - middle);

            left = MergeSortByNombre(left);
            right = MergeSortByNombre(right);

            return MergeByNombre(left, right);
        }

        static List<Empleado> MergeByNombre(List<Empleado> left, List<Empleado> right)
        {
            List<Empleado> result = new List<Empleado>();
            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (string.Compare(left[leftIndex].Nombre, right[rightIndex].Nombre) <= 0)
                {
                    result.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    result.Add(right[rightIndex]);
                    rightIndex++;
                }
            }

            while (leftIndex < left.Count)
            {
                result.Add(left[leftIndex]);
                leftIndex++;
            }

            while (rightIndex < right.Count)
            {
                result.Add(right[rightIndex]);
                rightIndex++;
            }

            return result;
        }

        static List<Empleado> MergeSortByApellido(List<Empleado> employees)
        {
            if (employees.Count <= 1)
            {
                return employees;
            }

            int middle = employees.Count / 2;
            List<Empleado> left = employees.GetRange(0, middle);
            List<Empleado> right = employees.GetRange(middle, employees.Count - middle);

            left = MergeSortByApellido(left);
            right = MergeSortByApellido(right);

            return MergeByApellido(left, right);
        }

        static List<Empleado> MergeByApellido(List<Empleado> left, List<Empleado> right)
        {
            List<Empleado> result = new List<Empleado>();
            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (string.Compare(left[leftIndex].Apellido, right[rightIndex].Apellido) <= 0)
                {
                    result.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    result.Add(right[rightIndex]);
                    rightIndex++;
                }
            }

            while (leftIndex < left.Count)
            {
                result.Add(left[leftIndex]);
                leftIndex++;
            }

            while (rightIndex < right.Count)
            {
                result.Add(right[rightIndex]);
                rightIndex++;
            }

            return result;
        }

        static List<Empleado> MergeSortBySueldoTotal(List<Empleado> employees)
        {
            if (employees.Count <= 1)
            {
                return employees;
            }

            int middle = employees.Count / 2;
            List<Empleado> left = employees.GetRange(0, middle);
            List<Empleado> right = employees.GetRange(middle, employees.Count - middle);

            left = MergeSortBySueldoTotal(left);
            right = MergeSortBySueldoTotal(right);

            return MergeBySueldoTotal(left, right);
        }

        static List<Empleado> MergeBySueldoTotal(List<Empleado> left, List<Empleado> right)
        {
            List<Empleado> result = new List<Empleado>();
            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (left[leftIndex].SueldoTotal <= right[rightIndex].SueldoTotal)
                {
                    result.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    result.Add(right[rightIndex]);
                    rightIndex++;
                }
            }

            result.AddRange(left.GetRange(leftIndex, left.Count - leftIndex));
            result.AddRange(right.GetRange(rightIndex, right.Count - rightIndex));

            return result;
        }

        
        private void btnClean_Click(object sender, EventArgs e)
        {
            cmbBxParametro.Select();
            txtBuscar.Text = "";
            tbDatosEmpleados.DataSource = dataList;
        }

        private void btnEliminarDatos_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Está seguro de eliminar todos los datos?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                FormPrincipal.empleados.Clear();
                FormPrincipal.tablaHash.Clear();
                dataList.Clear();
                ActualizarArchivoDeTexto();
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

                MessageBox.Show("Los datos se han eliminado exitosamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ActualizarArchivoDeTexto()
        {
            using (StreamWriter writer = new StreamWriter("nomina.txt"))
            {
                foreach (Empleado empleado in dataList)
                {
                    writer.WriteLine($"{empleado.Codigo},{empleado.Nombre},{empleado.Apellido},{empleado.Cargo},{empleado.PagoPorHora},{empleado.HorasTrabajadas}");
                }
            }
        }
    }
}
