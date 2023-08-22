namespace Sudoku_GUI
{
    partial class ModalForm
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
            this.components = new System.ComponentModel.Container();
            this.modalEffect_Timer = new System.Windows.Forms.Timer(this.components);
            this.lbTituloFormulario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCancel = new System.Windows.Forms.Label();
            this.lbIngreseDatos = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtBxNombre = new System.Windows.Forms.TextBox();
            this.txtBxApellido = new System.Windows.Forms.TextBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.txtBxCargo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxPagoHora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxHorasTrabajo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new Sudoku_GUI.buttonTemplate();
            this.txtBxCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // modalEffect_Timer
            // 
            this.modalEffect_Timer.Enabled = true;
            this.modalEffect_Timer.Interval = 1;
            this.modalEffect_Timer.Tick += new System.EventHandler(this.modalEffect_Timer_Tick);
            // 
            // lbTituloFormulario
            // 
            this.lbTituloFormulario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTituloFormulario.AutoSize = true;
            this.lbTituloFormulario.Font = new System.Drawing.Font("Hotel De Paris", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloFormulario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.lbTituloFormulario.Location = new System.Drawing.Point(301, 0);
            this.lbTituloFormulario.Name = "lbTituloFormulario";
            this.lbTituloFormulario.Size = new System.Drawing.Size(354, 43);
            this.lbTituloFormulario.TabIndex = 3;
            this.lbTituloFormulario.Text = "Nuevo Empleado";
            this.lbTituloFormulario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTituloFormulario.Click += new System.EventHandler(this.lbTituloFormulario_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.lbCancel);
            this.panel1.Controls.Add(this.lbTituloFormulario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 52);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbCancel
            // 
            this.lbCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCancel.AutoSize = true;
            this.lbCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.lbCancel.Location = new System.Drawing.Point(928, 9);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(34, 32);
            this.lbCancel.TabIndex = 8;
            this.lbCancel.Text = "X";
            this.lbCancel.Click += new System.EventHandler(this.lbCancel_Click);
            // 
            // lbIngreseDatos
            // 
            this.lbIngreseDatos.AutoSize = true;
            this.lbIngreseDatos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbIngreseDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngreseDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.lbIngreseDatos.Location = new System.Drawing.Point(75, 76);
            this.lbIngreseDatos.Name = "lbIngreseDatos";
            this.lbIngreseDatos.Size = new System.Drawing.Size(377, 25);
            this.lbIngreseDatos.TabIndex = 8;
            this.lbIngreseDatos.Text = "Ingrese los datos del nuevo empleado";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.lbNombre.Location = new System.Drawing.Point(75, 140);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(87, 25);
            this.lbNombre.TabIndex = 9;
            this.lbNombre.Text = "Nombre";
            // 
            // txtBxNombre
            // 
            this.txtBxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxNombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBxNombre.Location = new System.Drawing.Point(238, 137);
            this.txtBxNombre.Name = "txtBxNombre";
            this.txtBxNombre.Size = new System.Drawing.Size(214, 30);
            this.txtBxNombre.TabIndex = 10;
            // 
            // txtBxApellido
            // 
            this.txtBxApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxApellido.Location = new System.Drawing.Point(675, 137);
            this.txtBxApellido.Name = "txtBxApellido";
            this.txtBxApellido.Size = new System.Drawing.Size(214, 30);
            this.txtBxApellido.TabIndex = 12;
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.lbApellido.Location = new System.Drawing.Point(511, 144);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(90, 25);
            this.lbApellido.TabIndex = 11;
            this.lbApellido.Text = "Apellido";
            // 
            // txtBxCargo
            // 
            this.txtBxCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxCargo.Location = new System.Drawing.Point(309, 187);
            this.txtBxCargo.Name = "txtBxCargo";
            this.txtBxCargo.Size = new System.Drawing.Size(580, 30);
            this.txtBxCargo.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(75, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cargo";
            // 
            // txtBxPagoHora
            // 
            this.txtBxPagoHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPagoHora.Location = new System.Drawing.Point(309, 241);
            this.txtBxPagoHora.Name = "txtBxPagoHora";
            this.txtBxPagoHora.Size = new System.Drawing.Size(580, 30);
            this.txtBxPagoHora.TabIndex = 16;
            this.txtBxPagoHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxPagoHora_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.label2.Location = new System.Drawing.Point(75, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Pago por Hora";
            // 
            // txtBxHorasTrabajo
            // 
            this.txtBxHorasTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxHorasTrabajo.Location = new System.Drawing.Point(309, 295);
            this.txtBxHorasTrabajo.Name = "txtBxHorasTrabajo";
            this.txtBxHorasTrabajo.Size = new System.Drawing.Size(580, 30);
            this.txtBxHorasTrabajo.TabIndex = 18;
            this.txtBxHorasTrabajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxHorasTrabajo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(75, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Horas de Trabajo";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnAdd.BackgroundColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnAdd.BackgroundColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnAdd.ForegroundColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnAdd.ForegroundColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnAdd.Location = new System.Drawing.Point(348, 418);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(278, 52);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBxCodigo
            // 
            this.txtBxCodigo.Enabled = false;
            this.txtBxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxCodigo.Location = new System.Drawing.Point(309, 353);
            this.txtBxCodigo.Name = "txtBxCodigo";
            this.txtBxCodigo.Size = new System.Drawing.Size(580, 30);
            this.txtBxCodigo.TabIndex = 21;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.lbCodigo.Location = new System.Drawing.Point(75, 356);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(81, 25);
            this.lbCodigo.TabIndex = 20;
            this.lbCodigo.Text = "Código";
            // 
            // ModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(966, 506);
            this.Controls.Add(this.txtBxCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBxHorasTrabajo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxPagoHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxCargo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxApellido);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.txtBxNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbIngreseDatos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModalForm";
            this.Opacity = 0D;
            this.Text = "ModalForm";
            this.Load += new System.EventHandler(this.ModalForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer modalEffect_Timer;
        private System.Windows.Forms.Label lbTituloFormulario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCancel;
        private System.Windows.Forms.Label lbIngreseDatos;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtBxNombre;
        private System.Windows.Forms.TextBox txtBxApellido;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.TextBox txtBxCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxPagoHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxHorasTrabajo;
        private System.Windows.Forms.Label label3;
        private buttonTemplate btnAdd;
        private System.Windows.Forms.TextBox txtBxCodigo;
        private System.Windows.Forms.Label lbCodigo;
    }
}