namespace Sudoku_GUI
{
    partial class FrmModalEditarEmpleado
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
            this.lbCancel = new System.Windows.Forms.Label();
            this.lbTituloFormulario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelWithBorder1 = new Sudoku_GUI.PanelWithBorder();
            this.btnCancel = new Sudoku_GUI.buttonTemplate();
            this.txtBxCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.btnSaveChanges = new Sudoku_GUI.buttonTemplate();
            this.txtBxHorasTrabajo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxPagoHora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxCargo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxApellido = new System.Windows.Forms.TextBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.txtBxNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lb_bienvenida = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelWithBorder1.SuspendLayout();
            this.SuspendLayout();
            // 
            // modalEffect_Timer
            // 
            this.modalEffect_Timer.Enabled = true;
            this.modalEffect_Timer.Interval = 1;
            this.modalEffect_Timer.Tick += new System.EventHandler(this.modalEffect_Timer_Tick);
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
            // lbTituloFormulario
            // 
            this.lbTituloFormulario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTituloFormulario.AutoSize = true;
            this.lbTituloFormulario.Font = new System.Drawing.Font("Hotel De Paris", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloFormulario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.lbTituloFormulario.Location = new System.Drawing.Point(301, 0);
            this.lbTituloFormulario.Name = "lbTituloFormulario";
            this.lbTituloFormulario.Size = new System.Drawing.Size(366, 43);
            this.lbTituloFormulario.TabIndex = 3;
            this.lbTituloFormulario.Text = "Editar Empleado";
            this.lbTituloFormulario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.panel1.TabIndex = 8;
            // 
            // panelWithBorder1
            // 
            this.panelWithBorder1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.panelWithBorder1.Controls.Add(this.btnCancel);
            this.panelWithBorder1.Controls.Add(this.txtBxCodigo);
            this.panelWithBorder1.Controls.Add(this.lbCodigo);
            this.panelWithBorder1.Controls.Add(this.btnSaveChanges);
            this.panelWithBorder1.Controls.Add(this.txtBxHorasTrabajo);
            this.panelWithBorder1.Controls.Add(this.label3);
            this.panelWithBorder1.Controls.Add(this.txtBxPagoHora);
            this.panelWithBorder1.Controls.Add(this.label2);
            this.panelWithBorder1.Controls.Add(this.txtBxCargo);
            this.panelWithBorder1.Controls.Add(this.label1);
            this.panelWithBorder1.Controls.Add(this.txtBxApellido);
            this.panelWithBorder1.Controls.Add(this.lbApellido);
            this.panelWithBorder1.Controls.Add(this.txtBxNombre);
            this.panelWithBorder1.Controls.Add(this.lbNombre);
            this.panelWithBorder1.Controls.Add(this.lb_bienvenida);
            this.panelWithBorder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWithBorder1.Location = new System.Drawing.Point(0, 52);
            this.panelWithBorder1.Name = "panelWithBorder1";
            this.panelWithBorder1.Size = new System.Drawing.Size(966, 454);
            this.panelWithBorder1.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnCancel.BackgroundColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnCancel.BackgroundColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnCancel.ForegroundColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnCancel.ForegroundColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnCancel.Location = new System.Drawing.Point(207, 390);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(278, 52);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBxCodigo
            // 
            this.txtBxCodigo.Enabled = false;
            this.txtBxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxCodigo.Location = new System.Drawing.Point(310, 319);
            this.txtBxCodigo.Name = "txtBxCodigo";
            this.txtBxCodigo.Size = new System.Drawing.Size(580, 30);
            this.txtBxCodigo.TabIndex = 49;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.lbCodigo.Location = new System.Drawing.Point(76, 322);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(81, 25);
            this.lbCodigo.TabIndex = 48;
            this.lbCodigo.Text = "Código";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnSaveChanges.BackgroundColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnSaveChanges.BackgroundColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnSaveChanges.ForegroundColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnSaveChanges.ForegroundColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnSaveChanges.Location = new System.Drawing.Point(491, 390);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(278, 52);
            this.btnSaveChanges.TabIndex = 47;
            this.btnSaveChanges.Text = "Guardar";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtBxHorasTrabajo
            // 
            this.txtBxHorasTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxHorasTrabajo.Location = new System.Drawing.Point(310, 261);
            this.txtBxHorasTrabajo.Name = "txtBxHorasTrabajo";
            this.txtBxHorasTrabajo.Size = new System.Drawing.Size(580, 30);
            this.txtBxHorasTrabajo.TabIndex = 46;
            this.txtBxHorasTrabajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxHorasTrabajo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(76, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Horas de Trabajo";
            // 
            // txtBxPagoHora
            // 
            this.txtBxPagoHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPagoHora.Location = new System.Drawing.Point(310, 207);
            this.txtBxPagoHora.Name = "txtBxPagoHora";
            this.txtBxPagoHora.Size = new System.Drawing.Size(580, 30);
            this.txtBxPagoHora.TabIndex = 44;
            this.txtBxPagoHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxPagoHora_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.label2.Location = new System.Drawing.Point(76, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Pago por Hora";
            // 
            // txtBxCargo
            // 
            this.txtBxCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxCargo.Location = new System.Drawing.Point(310, 153);
            this.txtBxCargo.Name = "txtBxCargo";
            this.txtBxCargo.Size = new System.Drawing.Size(580, 30);
            this.txtBxCargo.TabIndex = 42;
            this.txtBxCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxCargo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(76, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Cargo";
            // 
            // txtBxApellido
            // 
            this.txtBxApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxApellido.Location = new System.Drawing.Point(676, 103);
            this.txtBxApellido.Name = "txtBxApellido";
            this.txtBxApellido.Size = new System.Drawing.Size(214, 30);
            this.txtBxApellido.TabIndex = 40;
            this.txtBxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxApellido_KeyPress);
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.lbApellido.Location = new System.Drawing.Point(512, 110);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(90, 25);
            this.lbApellido.TabIndex = 39;
            this.lbApellido.Text = "Apellido";
            // 
            // txtBxNombre
            // 
            this.txtBxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxNombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBxNombre.Location = new System.Drawing.Point(239, 103);
            this.txtBxNombre.Name = "txtBxNombre";
            this.txtBxNombre.Size = new System.Drawing.Size(214, 30);
            this.txtBxNombre.TabIndex = 38;
            this.txtBxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxNombre_KeyPress);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.lbNombre.Location = new System.Drawing.Point(76, 106);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(87, 25);
            this.lbNombre.TabIndex = 37;
            this.lbNombre.Text = "Nombre";
            // 
            // lb_bienvenida
            // 
            this.lb_bienvenida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_bienvenida.AutoSize = true;
            this.lb_bienvenida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_bienvenida.Font = new System.Drawing.Font("Hotel De Paris", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.lb_bienvenida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_bienvenida.Location = new System.Drawing.Point(75, 37);
            this.lb_bienvenida.Name = "lb_bienvenida";
            this.lb_bienvenida.Size = new System.Drawing.Size(170, 33);
            this.lb_bienvenida.TabIndex = 36;
            this.lb_bienvenida.Text = "Empleado";
            this.lb_bienvenida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmModalEditarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 506);
            this.Controls.Add(this.panelWithBorder1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModalEditarEmpleado";
            this.Opacity = 0D;
            this.Text = "FrmModalEditarEmpleado";
            this.Load += new System.EventHandler(this.FrmModalEditarEmpleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelWithBorder1.ResumeLayout(false);
            this.panelWithBorder1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer modalEffect_Timer;
        private System.Windows.Forms.Label lbCancel;
        private System.Windows.Forms.Label lbTituloFormulario;
        private System.Windows.Forms.Panel panel1;
        private PanelWithBorder panelWithBorder1;
        private buttonTemplate btnCancel;
        private System.Windows.Forms.TextBox txtBxCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private buttonTemplate btnSaveChanges;
        private System.Windows.Forms.TextBox txtBxHorasTrabajo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxPagoHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxApellido;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.TextBox txtBxNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lb_bienvenida;
    }
}