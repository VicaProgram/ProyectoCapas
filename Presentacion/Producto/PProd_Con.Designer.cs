namespace Presentacion.Producto
{
    partial class PProd_Con
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
            this.ButEli = new System.Windows.Forms.Button();
            this.ButMod = new System.Windows.Forms.Button();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FInc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CInc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CArr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextIdCli = new System.Windows.Forms.TextBox();
            this.ButSal = new System.Windows.Forms.Button();
            this.ButVol = new System.Windows.Forms.Button();
            this.ComboBus = new System.Windows.Forms.ComboBox();
            this.TextBus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButLimBus = new System.Windows.Forms.Button();
            this.ButBus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButMod2 = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // ButEli
            // 
            this.ButEli.Enabled = false;
            this.ButEli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButEli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButEli.Location = new System.Drawing.Point(866, 201);
            this.ButEli.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ButEli.Name = "ButEli";
            this.ButEli.Size = new System.Drawing.Size(92, 49);
            this.ButEli.TabIndex = 320;
            this.ButEli.TabStop = false;
            this.ButEli.Text = "Eliminar";
            this.ButEli.UseVisualStyleBackColor = true;
            this.ButEli.Visible = false;
            this.ButEli.Click += new System.EventHandler(this.ButEli_Click);
            // 
            // ButMod
            // 
            this.ButMod.Enabled = false;
            this.ButMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButMod.Location = new System.Drawing.Point(777, 201);
            this.ButMod.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ButMod.Name = "ButMod";
            this.ButMod.Size = new System.Drawing.Size(92, 49);
            this.ButMod.TabIndex = 319;
            this.ButMod.TabStop = false;
            this.ButMod.Text = "Actualizar1";
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
            this.IdProd,
            this.Nombre,
            this.FInc,
            this.CInc,
            this.CAct,
            this.CArr,
            this.TAct,
            this.Varr});
            this.Grilla.EnableHeadersVisualStyles = false;
            this.Grilla.Location = new System.Drawing.Point(13, 175);
            this.Grilla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Grilla.MultiSelect = false;
            this.Grilla.Name = "Grilla";
            this.Grilla.ReadOnly = true;
            this.Grilla.RowHeadersVisible = false;
            this.Grilla.Size = new System.Drawing.Size(680, 260);
            this.Grilla.TabIndex = 318;
            this.Grilla.DoubleClick += new System.EventHandler(this.Grilla_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // IdProd
            // 
            this.IdProd.HeaderText = "IdProd";
            this.IdProd.Name = "IdProd";
            this.IdProd.ReadOnly = true;
            this.IdProd.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // FInc
            // 
            this.FInc.HeaderText = "Fecha de Incorporacion";
            this.FInc.Name = "FInc";
            this.FInc.ReadOnly = true;
            // 
            // CInc
            // 
            this.CInc.HeaderText = "Cantidad Inicial";
            this.CInc.Name = "CInc";
            this.CInc.ReadOnly = true;
            this.CInc.Visible = false;
            // 
            // CAct
            // 
            this.CAct.HeaderText = "Cantidad Actual";
            this.CAct.Name = "CAct";
            this.CAct.ReadOnly = true;
            // 
            // CArr
            // 
            this.CArr.HeaderText = "Cantidad Arrendada";
            this.CArr.Name = "CArr";
            this.CArr.ReadOnly = true;
            this.CArr.Visible = false;
            // 
            // TAct
            // 
            this.TAct.HeaderText = "Total Actual";
            this.TAct.Name = "TAct";
            this.TAct.ReadOnly = true;
            // 
            // Varr
            // 
            this.Varr.HeaderText = "Valor Arriendio por unidad";
            this.Varr.Name = "Varr";
            this.Varr.ReadOnly = true;
            this.Varr.Visible = false;
            // 
            // TextIdCli
            // 
            this.TextIdCli.Location = new System.Drawing.Point(848, 382);
            this.TextIdCli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextIdCli.Name = "TextIdCli";
            this.TextIdCli.Size = new System.Drawing.Size(127, 21);
            this.TextIdCli.TabIndex = 317;
            this.TextIdCli.Visible = false;
            // 
            // ButSal
            // 
            this.ButSal.Location = new System.Drawing.Point(949, 291);
            this.ButSal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButSal.Name = "ButSal";
            this.ButSal.Size = new System.Drawing.Size(118, 52);
            this.ButSal.TabIndex = 316;
            this.ButSal.Text = "Salir";
            this.ButSal.UseVisualStyleBackColor = true;
            this.ButSal.Click += new System.EventHandler(this.ButSal_Click);
            // 
            // ButVol
            // 
            this.ButVol.Location = new System.Drawing.Point(751, 291);
            this.ButVol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButVol.Name = "ButVol";
            this.ButVol.Size = new System.Drawing.Size(118, 52);
            this.ButVol.TabIndex = 315;
            this.ButVol.Text = "Volver";
            this.ButVol.UseVisualStyleBackColor = true;
            this.ButVol.Click += new System.EventHandler(this.ButVol_Click);
            // 
            // ComboBus
            // 
            this.ComboBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBus.FormattingEnabled = true;
            this.ComboBus.Location = new System.Drawing.Point(9, 125);
            this.ComboBus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBus.Name = "ComboBus";
            this.ComboBus.Size = new System.Drawing.Size(164, 23);
            this.ComboBus.TabIndex = 314;
            // 
            // TextBus
            // 
            this.TextBus.Location = new System.Drawing.Point(181, 127);
            this.TextBus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBus.Name = "TextBus";
            this.TextBus.Size = new System.Drawing.Size(448, 21);
            this.TextBus.TabIndex = 313;
            this.TextBus.TextChanged += new System.EventHandler(this.TextBus_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 312;
            this.label2.Text = "Buscar Por:";
            // 
            // ButLimBus
            // 
            this.ButLimBus.Location = new System.Drawing.Point(399, 86);
            this.ButLimBus.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ButLimBus.Name = "ButLimBus";
            this.ButLimBus.Size = new System.Drawing.Size(252, 31);
            this.ButLimBus.TabIndex = 311;
            this.ButLimBus.Text = "Limpiar Busqueda";
            this.ButLimBus.UseVisualStyleBackColor = true;
            this.ButLimBus.Click += new System.EventHandler(this.ButLimBus_Click);
            // 
            // ButBus
            // 
            this.ButBus.Location = new System.Drawing.Point(189, 86);
            this.ButBus.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ButBus.Name = "ButBus";
            this.ButBus.Size = new System.Drawing.Size(150, 31);
            this.ButBus.TabIndex = 310;
            this.ButBus.Text = "Buscar";
            this.ButBus.UseVisualStyleBackColor = true;
            this.ButBus.Click += new System.EventHandler(this.ButBus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 309;
            this.label1.Text = "Informacion sobre Producto";
            // 
            // ButMod2
            // 
            this.ButMod2.Enabled = false;
            this.ButMod2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButMod2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButMod2.Location = new System.Drawing.Point(949, 201);
            this.ButMod2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ButMod2.Name = "ButMod2";
            this.ButMod2.Size = new System.Drawing.Size(92, 49);
            this.ButMod2.TabIndex = 321;
            this.ButMod2.TabStop = false;
            this.ButMod2.Text = "Actualizar2";
            this.ButMod2.UseVisualStyleBackColor = true;
            this.ButMod2.Visible = false;
            this.ButMod2.Click += new System.EventHandler(this.ButMod2_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Enabled = false;
            this.BtnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSelect.Location = new System.Drawing.Point(848, 201);
            this.BtnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(118, 49);
            this.BtnSelect.TabIndex = 322;
            this.BtnSelect.TabStop = false;
            this.BtnSelect.Text = "Seleccionar";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Visible = false;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // PProd_Con
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 461);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.ButMod2);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PProd_Con";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PProd_Con";
            this.Load += new System.EventHandler(this.PProd_Con_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button ButEli;
        public System.Windows.Forms.Button ButMod;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.TextBox TextIdCli;
        private System.Windows.Forms.Button ButSal;
        private System.Windows.Forms.Button ButVol;
        public System.Windows.Forms.ComboBox ComboBus;
        private System.Windows.Forms.TextBox TextBus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButLimBus;
        private System.Windows.Forms.Button ButBus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FInc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CInc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn CArr;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Varr;
        public System.Windows.Forms.Button ButMod2;
        public System.Windows.Forms.Button BtnSelect;
    }
}