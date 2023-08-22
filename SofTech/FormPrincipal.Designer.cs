namespace Sudoku_GUI
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnImportarDatos = new Sudoku_GUI.buttonTemplate();
            this.btnVer = new Sudoku_GUI.buttonTemplate();
            this.panelWithBorder1 = new Sudoku_GUI.PanelWithBorder();
            this.label_principal = new System.Windows.Forms.Label();
            this.btnModal = new System.Windows.Forms.Button();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelContenedor.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.panelWithBorder1.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panelContenedor.Controls.Add(this.panelFormularios);
            this.panelContenedor.Controls.Add(this.pnlMenu);
            this.panelContenedor.Controls.Add(this.panelBarraTitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1479, 831);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.Color.White;
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(250, 36);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1229, 795);
            this.panelFormularios.TabIndex = 18;
            this.panelFormularios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormularios_Paint);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.pnlMenu.Controls.Add(this.btnImportarDatos);
            this.pnlMenu.Controls.Add(this.btnVer);
            this.pnlMenu.Controls.Add(this.panelWithBorder1);
            this.pnlMenu.Controls.Add(this.btnModal);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 36);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(250, 795);
            this.pnlMenu.TabIndex = 17;
            // 
            // btnImportarDatos
            // 
            this.btnImportarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnImportarDatos.BackgroundColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnImportarDatos.BackgroundColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnImportarDatos.FlatAppearance.BorderSize = 0;
            this.btnImportarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnImportarDatos.ForegroundColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnImportarDatos.ForegroundColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnImportarDatos.Location = new System.Drawing.Point(0, 207);
            this.btnImportarDatos.Name = "btnImportarDatos";
            this.btnImportarDatos.Size = new System.Drawing.Size(250, 60);
            this.btnImportarDatos.TabIndex = 21;
            this.btnImportarDatos.Text = "Importar Datos";
            this.btnImportarDatos.UseVisualStyleBackColor = false;
            this.btnImportarDatos.Click += new System.EventHandler(this.btnImportarDatos_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnVer.BackgroundColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.btnVer.BackgroundColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnVer.ForegroundColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.btnVer.ForegroundColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.btnVer.Location = new System.Drawing.Point(0, 333);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(250, 60);
            this.btnVer.TabIndex = 20;
            this.btnVer.Text = "Ver Empleados";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // panelWithBorder1
            // 
            this.panelWithBorder1.BackColor = System.Drawing.Color.Transparent;
            this.panelWithBorder1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.panelWithBorder1.Controls.Add(this.label_principal);
            this.panelWithBorder1.Location = new System.Drawing.Point(47, 25);
            this.panelWithBorder1.Name = "panelWithBorder1";
            this.panelWithBorder1.Size = new System.Drawing.Size(158, 127);
            this.panelWithBorder1.TabIndex = 19;
            // 
            // label_principal
            // 
            this.label_principal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_principal.AutoSize = true;
            this.label_principal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_principal.Font = new System.Drawing.Font("Hotel De Paris", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_principal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.label_principal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_principal.Location = new System.Drawing.Point(11, 11);
            this.label_principal.Name = "label_principal";
            this.label_principal.Size = new System.Drawing.Size(130, 94);
            this.label_principal.TabIndex = 1;
            this.label_principal.Text = "Sof\r\nTech";
            this.label_principal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_principal.Click += new System.EventHandler(this.label_principal_Click);
            // 
            // btnModal
            // 
            this.btnModal.BackColor = System.Drawing.Color.Transparent;
            this.btnModal.FlatAppearance.BorderSize = 0;
            this.btnModal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnModal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.btnModal.Location = new System.Drawing.Point(0, 270);
            this.btnModal.Margin = new System.Windows.Forms.Padding(0);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(250, 60);
            this.btnModal.TabIndex = 16;
            this.btnModal.Text = "Añadir";
            this.btnModal.UseVisualStyleBackColor = false;
            this.btnModal.Click += new System.EventHandler(this.button1_Click);
            this.btnModal.MouseEnter += new System.EventHandler(this.btnModal_MouseEnter);
            this.btnModal.MouseLeave += new System.EventHandler(this.btnModal_MouseLeave);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.panelBarraTitulo.Controls.Add(this.panel1);
            this.panelBarraTitulo.Controls.Add(this.label1);
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnRestaurar);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1479, 36);
            this.panelBarraTitulo.TabIndex = 13;
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 249);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(707, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "SofTech";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::Sudoku_GUI.Properties.Resources.minimizar_2_16;
            this.btnMaximizar.Location = new System.Drawing.Point(1408, 7);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(21, 20);
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Sudoku_GUI.Properties.Resources.menos_2_16;
            this.btnMinimizar.Location = new System.Drawing.Point(1363, 6);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 20);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = global::Sudoku_GUI.Properties.Resources.minimizar_2_16;
            this.btnRestaurar.Location = new System.Drawing.Point(1408, 6);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(21, 20);
            this.btnRestaurar.TabIndex = 1;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Sudoku_GUI.Properties.Resources.close1;
            this.btnCerrar.Location = new System.Drawing.Point(1448, 7);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 20);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 831);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.panelContenedor.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.panelWithBorder1.ResumeLayout(false);
            this.panelWithBorder1.PerformLayout();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_principal;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel panel1;
        private PanelWithBorder panelWithBorder1;
        private buttonTemplate btnVer;
        public System.Windows.Forms.Panel panelFormularios;
        private buttonTemplate btnImportarDatos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

