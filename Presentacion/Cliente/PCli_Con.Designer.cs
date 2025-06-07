namespace Presentacion.Cliente
{
    partial class PCli_Con
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
            this.label1 = new System.Windows.Forms.Label();
            this.ButEli = new System.Windows.Forms.Button();
            this.ButMod = new System.Windows.Forms.Button();
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
            this.TextIdCli = new System.Windows.Forms.TextBox();
            this.ButSal = new System.Windows.Forms.Button();
            this.ButVol = new System.Windows.Forms.Button();
            this.ComboBus = new System.Windows.Forms.ComboBox();
            this.TextBus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButLimBus = new System.Windows.Forms.Button();
            this.ButBus = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 297;
            this.label1.Text = "Informacion sobre Cliente";
            // 
            // ButEli
            // 
            this.ButEli.Enabled = false;
            this.ButEli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButEli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButEli.Location = new System.Drawing.Point(852, 227);
            this.ButEli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButEli.Name = "ButEli";
            this.ButEli.Size = new System.Drawing.Size(118, 49);
            this.ButEli.TabIndex = 308;
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
            this.ButMod.Location = new System.Drawing.Point(852, 227);
            this.ButMod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButMod.Name = "ButMod";
            this.ButMod.Size = new System.Drawing.Size(118, 49);
            this.ButMod.TabIndex = 307;
            this.ButMod.TabStop = false;
            this.ButMod.Text = "Actualizar";
            this.ButMod.UseVisualStyleBackColor = true;
            this.ButMod.Visible = false;
            this.ButMod.Click += new System.EventHandler(this.ButMod_Click);
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
            this.Grilla.Location = new System.Drawing.Point(13, 124);
            this.Grilla.Margin = new System.Windows.Forms.Padding(4);
            this.Grilla.MultiSelect = false;
            this.Grilla.Name = "Grilla";
            this.Grilla.ReadOnly = true;
            this.Grilla.RowHeadersVisible = false;
            this.Grilla.Size = new System.Drawing.Size(618, 324);
            this.Grilla.TabIndex = 306;
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
            // TextIdCli
            // 
            this.TextIdCli.Location = new System.Drawing.Point(837, 114);
            this.TextIdCli.Margin = new System.Windows.Forms.Padding(4);
            this.TextIdCli.Name = "TextIdCli";
            this.TextIdCli.Size = new System.Drawing.Size(149, 22);
            this.TextIdCli.TabIndex = 305;
            this.TextIdCli.Visible = false;
            // 
            // ButSal
            // 
            this.ButSal.Location = new System.Drawing.Point(931, 305);
            this.ButSal.Margin = new System.Windows.Forms.Padding(4);
            this.ButSal.Name = "ButSal";
            this.ButSal.Size = new System.Drawing.Size(140, 52);
            this.ButSal.TabIndex = 304;
            this.ButSal.Text = "Salir";
            this.ButSal.UseVisualStyleBackColor = true;
            this.ButSal.Click += new System.EventHandler(this.ButSal_Click);
            // 
            // ButVol
            // 
            this.ButVol.Location = new System.Drawing.Point(753, 305);
            this.ButVol.Margin = new System.Windows.Forms.Padding(4);
            this.ButVol.Name = "ButVol";
            this.ButVol.Size = new System.Drawing.Size(140, 52);
            this.ButVol.TabIndex = 303;
            this.ButVol.Text = "Volver";
            this.ButVol.UseVisualStyleBackColor = true;
            this.ButVol.Click += new System.EventHandler(this.ButVol_Click);
            // 
            // ComboBus
            // 
            this.ComboBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBus.FormattingEnabled = true;
            this.ComboBus.Location = new System.Drawing.Point(13, 80);
            this.ComboBus.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBus.Name = "ComboBus";
            this.ComboBus.Size = new System.Drawing.Size(180, 24);
            this.ComboBus.TabIndex = 302;
            // 
            // TextBus
            // 
            this.TextBus.Location = new System.Drawing.Point(231, 83);
            this.TextBus.Margin = new System.Windows.Forms.Padding(4);
            this.TextBus.Name = "TextBus";
            this.TextBus.Size = new System.Drawing.Size(424, 22);
            this.TextBus.TabIndex = 301;
            this.TextBus.TextChanged += new System.EventHandler(this.TextBus_TextChanged);
            this.TextBus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBus_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 300;
            this.label2.Text = "Buscar Por:";
            // 
            // ButLimBus
            // 
            this.ButLimBus.Location = new System.Drawing.Point(411, 40);
            this.ButLimBus.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ButLimBus.Name = "ButLimBus";
            this.ButLimBus.Size = new System.Drawing.Size(255, 34);
            this.ButLimBus.TabIndex = 299;
            this.ButLimBus.Text = "Limpiar Busqueda";
            this.ButLimBus.UseVisualStyleBackColor = true;
            this.ButLimBus.Click += new System.EventHandler(this.ButLimBus_Click);
            // 
            // ButBus
            // 
            this.ButBus.Location = new System.Drawing.Point(231, 40);
            this.ButBus.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ButBus.Name = "ButBus";
            this.ButBus.Size = new System.Drawing.Size(168, 34);
            this.ButBus.TabIndex = 298;
            this.ButBus.Text = "Buscar";
            this.ButBus.UseVisualStyleBackColor = true;
            this.ButBus.Click += new System.EventHandler(this.ButBus_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Enabled = false;
            this.BtnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSelect.Location = new System.Drawing.Point(852, 227);
            this.BtnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(118, 49);
            this.BtnSelect.TabIndex = 309;
            this.BtnSelect.TabStop = false;
            this.BtnSelect.Text = "Seleccionar";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Visible = false;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // PCli_Con
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 461);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.ButEli);
            this.Controls.Add(this.ButMod);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.TextIdCli);
            this.Controls.Add(this.ButSal);
            this.Controls.Add(this.ButVol);
            this.Controls.Add(this.ComboBus);
            this.Controls.Add(this.TextBus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButLimBus);
            this.Controls.Add(this.ButBus);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PCli_Con";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.PCli_Con_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button ButEli;
        public System.Windows.Forms.Button ButMod;
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
        private System.Windows.Forms.TextBox TextIdCli;
        private System.Windows.Forms.Button ButSal;
        private System.Windows.Forms.Button ButVol;
        public System.Windows.Forms.ComboBox ComboBus;
        private System.Windows.Forms.TextBox TextBus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButLimBus;
        private System.Windows.Forms.Button ButBus;
        public System.Windows.Forms.Button BtnSelect;
    }
}