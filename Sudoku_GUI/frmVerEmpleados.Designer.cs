namespace Sudoku_GUI
{
    partial class frmVerEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbDatosEmpleados = new System.Windows.Forms.DataGridView();
            this.lbPruebaEmpleadoSeleccionado = new System.Windows.Forms.Label();
            this.lbPruebaEmpleadoSeleccionado2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmbBxParametro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_principal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBxOrdenarSelect = new System.Windows.Forms.ComboBox();
            this.btnOrdenar = new Sudoku_GUI.buttonTemplate();
            this.btnClean = new Sudoku_GUI.buttonTemplate();
            this.btnBuscar = new Sudoku_GUI.buttonTemplate();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tbDatosEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDatosEmpleados
            // 
            this.tbDatosEmpleados.AllowUserToAddRows = false;
            this.tbDatosEmpleados.AllowUserToDeleteRows = false;
            this.tbDatosEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDatosEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbDatosEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tbDatosEmpleados.BackgroundColor = System.Drawing.Color.White;
            this.tbDatosEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDatosEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbDatosEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbDatosEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tbDatosEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbDatosEmpleados.DefaultCellStyle = dataGridViewCellStyle8;
            this.tbDatosEmpleados.Location = new System.Drawing.Point(12, 204);
            this.tbDatosEmpleados.Name = "tbDatosEmpleados";
            this.tbDatosEmpleados.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbDatosEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.tbDatosEmpleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tbDatosEmpleados.RowTemplate.Height = 24;
            this.tbDatosEmpleados.Size = new System.Drawing.Size(1187, 513);
            this.tbDatosEmpleados.TabIndex = 0;
            this.tbDatosEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbDatosEmpleados_CellContentClick);
            // 
            // lbPruebaEmpleadoSeleccionado
            // 
            this.lbPruebaEmpleadoSeleccionado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPruebaEmpleadoSeleccionado.AutoSize = true;
            this.lbPruebaEmpleadoSeleccionado.Location = new System.Drawing.Point(840, 42);
            this.lbPruebaEmpleadoSeleccionado.Name = "lbPruebaEmpleadoSeleccionado";
            this.lbPruebaEmpleadoSeleccionado.Size = new System.Drawing.Size(44, 16);
            this.lbPruebaEmpleadoSeleccionado.TabIndex = 1;
            this.lbPruebaEmpleadoSeleccionado.Text = "label1";
            // 
            // lbPruebaEmpleadoSeleccionado2
            // 
            this.lbPruebaEmpleadoSeleccionado2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPruebaEmpleadoSeleccionado2.AutoSize = true;
            this.lbPruebaEmpleadoSeleccionado2.Location = new System.Drawing.Point(890, 40);
            this.lbPruebaEmpleadoSeleccionado2.Name = "lbPruebaEmpleadoSeleccionado2";
            this.lbPruebaEmpleadoSeleccionado2.Size = new System.Drawing.Size(44, 16);
            this.lbPruebaEmpleadoSeleccionado2.TabIndex = 2;
            this.lbPruebaEmpleadoSeleccionado2.Text = "label1";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(432, 97);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(204, 28);
            this.txtBuscar.TabIndex = 4;
            // 
            // cmbBxParametro
            // 
            this.cmbBxParametro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbBxParametro.BackColor = System.Drawing.Color.White;
            this.cmbBxParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBxParametro.FormattingEnabled = true;
            this.cmbBxParametro.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "Apellido",
            "Cargo"});
            this.cmbBxParametro.Location = new System.Drawing.Point(150, 97);
            this.cmbBxParametro.Name = "cmbBxParametro";
            this.cmbBxParametro.Size = new System.Drawing.Size(204, 28);
            this.cmbBxParametro.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(7, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar por:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.label2.Location = new System.Drawing.Point(368, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dato:";
            // 
            // label_principal
            // 
            this.label_principal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_principal.AutoSize = true;
            this.label_principal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_principal.Font = new System.Drawing.Font("Hotel De Paris", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_principal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.label_principal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_principal.Location = new System.Drawing.Point(517, 9);
            this.label_principal.Name = "label_principal";
            this.label_principal.Size = new System.Drawing.Size(176, 47);
            this.label_principal.TabIndex = 8;
            this.label_principal.Text = "Nómina";
            this.label_principal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(7, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ordenar por:";
            // 
            // cmbBxOrdenarSelect
            // 
            this.cmbBxOrdenarSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbBxOrdenarSelect.BackColor = System.Drawing.Color.White;
            this.cmbBxOrdenarSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBxOrdenarSelect.FormattingEnabled = true;
            this.cmbBxOrdenarSelect.Items.AddRange(new object[] {
            "Nombre",
            "Apellido",
            "Sueldo Total"});
            this.cmbBxOrdenarSelect.Location = new System.Drawing.Point(150, 144);
            this.cmbBxOrdenarSelect.Name = "cmbBxOrdenarSelect";
            this.cmbBxOrdenarSelect.Size = new System.Drawing.Size(204, 28);
            this.cmbBxOrdenarSelect.TabIndex = 10;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOrdenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnOrdenar.BackgroundColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnOrdenar.BackgroundColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnOrdenar.FlatAppearance.BorderSize = 0;
            this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnOrdenar.ForegroundColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnOrdenar.ForegroundColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnOrdenar.Location = new System.Drawing.Point(372, 144);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(145, 32);
            this.btnOrdenar.TabIndex = 12;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnClean
            // 
            this.btnClean.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnClean.BackgroundColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnClean.BackgroundColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnClean.ForegroundColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnClean.ForegroundColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnClean.Location = new System.Drawing.Point(1008, 94);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(191, 32);
            this.btnClean.TabIndex = 9;
            this.btnClean.Text = "Limpiar búsquedas";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnBuscar.BackgroundColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnBuscar.BackgroundColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnBuscar.ForegroundColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnBuscar.ForegroundColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnBuscar.Location = new System.Drawing.Point(664, 94);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(145, 32);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmVerEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1211, 748);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBxOrdenarSelect);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.label_principal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBxParametro);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lbPruebaEmpleadoSeleccionado2);
            this.Controls.Add(this.lbPruebaEmpleadoSeleccionado);
            this.Controls.Add(this.tbDatosEmpleados);
            this.Name = "frmVerEmpleados";
            this.Text = "frmVerEmpleados";
            this.Load += new System.EventHandler(this.frmVerEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbDatosEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tbDatosEmpleados;
        private System.Windows.Forms.Label lbPruebaEmpleadoSeleccionado;
        private System.Windows.Forms.Label lbPruebaEmpleadoSeleccionado2;
        private buttonTemplate btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbBxParametro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_principal;
        private buttonTemplate btnClean;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBxOrdenarSelect;
        private buttonTemplate btnOrdenar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}