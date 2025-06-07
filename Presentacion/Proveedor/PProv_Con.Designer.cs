namespace Presentacion.Proveedor
{
    partial class PProv_Con
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
            this.ComboBus = new System.Windows.Forms.ComboBox();
            this.TextBus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButLimBus = new System.Windows.Forms.Button();
            this.ButBus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButSal = new System.Windows.Forms.Button();
            this.ButVol = new System.Windows.Forms.Button();
            this.TextIdCli = new System.Windows.Forms.TextBox();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButEli = new System.Windows.Forms.Button();
            this.ButMod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBus
            // 
            this.ComboBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBus.FormattingEnabled = true;
            this.ComboBus.Location = new System.Drawing.Point(12, 96);
            this.ComboBus.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBus.Name = "ComboBus";
            this.ComboBus.Size = new System.Drawing.Size(160, 24);
            this.ComboBus.TabIndex = 268;
            // 
            // TextBus
            // 
            this.TextBus.Location = new System.Drawing.Point(209, 98);
            this.TextBus.Margin = new System.Windows.Forms.Padding(4);
            this.TextBus.Name = "TextBus";
            this.TextBus.Size = new System.Drawing.Size(377, 22);
            this.TextBus.TabIndex = 267;
            this.TextBus.TextChanged += new System.EventHandler(this.TextBus_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 266;
            this.label2.Text = "Buscar Por:";
            // 
            // ButLimBus
            // 
            this.ButLimBus.Location = new System.Drawing.Point(369, 57);
            this.ButLimBus.Margin = new System.Windows.Forms.Padding(5);
            this.ButLimBus.Name = "ButLimBus";
            this.ButLimBus.Size = new System.Drawing.Size(217, 34);
            this.ButLimBus.TabIndex = 265;
            this.ButLimBus.Text = "Limpiar Busqueda";
            this.ButLimBus.UseVisualStyleBackColor = true;
            this.ButLimBus.Click += new System.EventHandler(this.ButLimBus_Click);
            // 
            // ButBus
            // 
            this.ButBus.Location = new System.Drawing.Point(209, 57);
            this.ButBus.Margin = new System.Windows.Forms.Padding(5);
            this.ButBus.Name = "ButBus";
            this.ButBus.Size = new System.Drawing.Size(149, 34);
            this.ButBus.TabIndex = 264;
            this.ButBus.Text = "Buscar";
            this.ButBus.UseVisualStyleBackColor = true;
            this.ButBus.Click += new System.EventHandler(this.ButBus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 269;
            this.label1.Text = "Informacion sobre Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, -309);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 274;
            this.label3.Text = "Actualizar Proveedor";
            // 
            // ButSal
            // 
            this.ButSal.Location = new System.Drawing.Point(895, 318);
            this.ButSal.Margin = new System.Windows.Forms.Padding(4);
            this.ButSal.Name = "ButSal";
            this.ButSal.Size = new System.Drawing.Size(124, 52);
            this.ButSal.TabIndex = 273;
            this.ButSal.Text = "Salir";
            this.ButSal.UseVisualStyleBackColor = true;
            this.ButSal.Click += new System.EventHandler(this.ButSal_Click);
            // 
            // ButVol
            // 
            this.ButVol.Location = new System.Drawing.Point(737, 318);
            this.ButVol.Margin = new System.Windows.Forms.Padding(4);
            this.ButVol.Name = "ButVol";
            this.ButVol.Size = new System.Drawing.Size(124, 52);
            this.ButVol.TabIndex = 271;
            this.ButVol.Text = "Volver";
            this.ButVol.UseVisualStyleBackColor = true;
            this.ButVol.Click += new System.EventHandler(this.ButVol_Click);
            // 
            // TextIdCli
            // 
            this.TextIdCli.Location = new System.Drawing.Point(809, 141);
            this.TextIdCli.Margin = new System.Windows.Forms.Padding(4);
            this.TextIdCli.Name = "TextIdCli";
            this.TextIdCli.Size = new System.Drawing.Size(133, 22);
            this.TextIdCli.TabIndex = 276;
            this.TextIdCli.Visible = false;
            // 
            // Grilla
            // 
            this.Grilla.AllowUserToAddRows = false;
            this.Grilla.AllowUserToDeleteRows = false;
            this.Grilla.AllowUserToResizeColumns = false;
            this.Grilla.AllowUserToResizeRows = false;
            this.Grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.IdProv,
            this.Nombre,
            this.Rut,
            this.IdCom,
            this.Comuna,
            this.Direccion,
            this.Tel,
            this.Email,
            this.Giro,
            this.Descr});
            this.Grilla.EnableHeadersVisualStyles = false;
            this.Grilla.Location = new System.Drawing.Point(12, 122);
            this.Grilla.Margin = new System.Windows.Forms.Padding(4);
            this.Grilla.Name = "Grilla";
            this.Grilla.ReadOnly = true;
            this.Grilla.RowHeadersVisible = false;
            this.Grilla.Size = new System.Drawing.Size(574, 335);
            this.Grilla.TabIndex = 291;
            this.Grilla.DoubleClick += new System.EventHandler(this.Grilla_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // IdProv
            // 
            this.IdProv.HeaderText = "IdProv";
            this.IdProv.Name = "IdProv";
            this.IdProv.ReadOnly = true;
            this.IdProv.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Rut
            // 
            this.Rut.HeaderText = "Rut";
            this.Rut.Name = "Rut";
            this.Rut.ReadOnly = true;
            // 
            // IdCom
            // 
            this.IdCom.HeaderText = "IdCom";
            this.IdCom.Name = "IdCom";
            this.IdCom.ReadOnly = true;
            this.IdCom.Visible = false;
            // 
            // Comuna
            // 
            this.Comuna.HeaderText = "Comuna";
            this.Comuna.Name = "Comuna";
            this.Comuna.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Visible = false;
            // 
            // Tel
            // 
            this.Tel.HeaderText = "Tel";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            this.Tel.Visible = false;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
            // 
            // Giro
            // 
            this.Giro.HeaderText = "Giro";
            this.Giro.Name = "Giro";
            this.Giro.ReadOnly = true;
            // 
            // Descr
            // 
            this.Descr.HeaderText = "Descr";
            this.Descr.Name = "Descr";
            this.Descr.ReadOnly = true;
            this.Descr.Visible = false;
            // 
            // ButEli
            // 
            this.ButEli.Enabled = false;
            this.ButEli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButEli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButEli.Location = new System.Drawing.Point(825, 240);
            this.ButEli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButEli.Name = "ButEli";
            this.ButEli.Size = new System.Drawing.Size(105, 49);
            this.ButEli.TabIndex = 293;
            this.ButEli.TabStop = false;
            this.ButEli.Text = "Eliminar";
            this.ButEli.UseVisualStyleBackColor = true;
            this.ButEli.Visible = false;
            this.ButEli.Click += new System.EventHandler(this.ButEli_Click);
            // 
            // ButMod
            // 
            this.ButMod.Enabled = false;
            this.ButMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButMod.Location = new System.Drawing.Point(825, 240);
            this.ButMod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButMod.Name = "ButMod";
            this.ButMod.Size = new System.Drawing.Size(105, 49);
            this.ButMod.TabIndex = 292;
            this.ButMod.TabStop = false;
            this.ButMod.Text = "Actualizar";
            this.ButMod.UseVisualStyleBackColor = true;
            this.ButMod.Visible = false;
            this.ButMod.Click += new System.EventHandler(this.ButMod_Click);
            // 
            // PProv_Con
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 461);
            this.Controls.Add(this.ButEli);
            this.Controls.Add(this.ButMod);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.TextIdCli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButSal);
            this.Controls.Add(this.ButVol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBus);
            this.Controls.Add(this.TextBus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButLimBus);
            this.Controls.Add(this.ButBus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PProv_Con";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.PProv_Con_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox ComboBus;
        private System.Windows.Forms.TextBox TextBus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButLimBus;
        private System.Windows.Forms.Button ButBus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButSal;
        private System.Windows.Forms.Button ButVol;
        private System.Windows.Forms.TextBox TextIdCli;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descr;
        public System.Windows.Forms.Button ButEli;
        public System.Windows.Forms.Button ButMod;
    }
}