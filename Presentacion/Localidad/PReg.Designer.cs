namespace Presentacion.Localidad
{
    partial class PReg
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
            this.ButBus = new System.Windows.Forms.Button();
            this.ButLimBus = new System.Windows.Forms.Button();
            this.ButVol = new System.Windows.Forms.Button();
            this.CheckIng = new System.Windows.Forms.CheckBox();
            this.CheckMod = new System.Windows.Forms.CheckBox();
            this.CheckEli = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButIng = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ButLim = new System.Windows.Forms.Button();
            this.ButSal = new System.Windows.Forms.Button();
            this.TextBus = new System.Windows.Forms.TextBox();
            this.TextIngMod = new System.Windows.Forms.TextBox();
            this.ButEli = new System.Windows.Forms.Button();
            this.ButMod = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.ComboBusReg = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // ButBus
            // 
            this.ButBus.Location = new System.Drawing.Point(147, 66);
            this.ButBus.Margin = new System.Windows.Forms.Padding(4);
            this.ButBus.Name = "ButBus";
            this.ButBus.Size = new System.Drawing.Size(100, 28);
            this.ButBus.TabIndex = 0;
            this.ButBus.Text = "Buscar";
            this.ButBus.UseVisualStyleBackColor = true;
            this.ButBus.Click += new System.EventHandler(this.ButBus_Click);
            // 
            // ButLimBus
            // 
            this.ButLimBus.Location = new System.Drawing.Point(316, 66);
            this.ButLimBus.Margin = new System.Windows.Forms.Padding(4);
            this.ButLimBus.Name = "ButLimBus";
            this.ButLimBus.Size = new System.Drawing.Size(220, 28);
            this.ButLimBus.TabIndex = 1;
            this.ButLimBus.Text = "Limpiar Busqueda";
            this.ButLimBus.UseVisualStyleBackColor = true;
            this.ButLimBus.Click += new System.EventHandler(this.ButLimBus_Click);
            // 
            // ButVol
            // 
            this.ButVol.Location = new System.Drawing.Point(732, 345);
            this.ButVol.Margin = new System.Windows.Forms.Padding(4);
            this.ButVol.Name = "ButVol";
            this.ButVol.Size = new System.Drawing.Size(100, 28);
            this.ButVol.TabIndex = 2;
            this.ButVol.Text = "Volver";
            this.ButVol.UseVisualStyleBackColor = true;
            this.ButVol.Click += new System.EventHandler(this.ButVol_Click);
            // 
            // CheckIng
            // 
            this.CheckIng.AutoSize = true;
            this.CheckIng.Location = new System.Drawing.Point(718, 74);
            this.CheckIng.Margin = new System.Windows.Forms.Padding(4);
            this.CheckIng.Name = "CheckIng";
            this.CheckIng.Size = new System.Drawing.Size(75, 20);
            this.CheckIng.TabIndex = 3;
            this.CheckIng.Text = "Ingresar";
            this.CheckIng.UseVisualStyleBackColor = true;
            this.CheckIng.CheckedChanged += new System.EventHandler(this.CheckIng_CheckedChanged);
            // 
            // CheckMod
            // 
            this.CheckMod.AutoSize = true;
            this.CheckMod.Enabled = false;
            this.CheckMod.Location = new System.Drawing.Point(834, 74);
            this.CheckMod.Margin = new System.Windows.Forms.Padding(4);
            this.CheckMod.Name = "CheckMod";
            this.CheckMod.Size = new System.Drawing.Size(81, 20);
            this.CheckMod.TabIndex = 4;
            this.CheckMod.Text = "Modificar";
            this.CheckMod.UseVisualStyleBackColor = true;
            this.CheckMod.CheckedChanged += new System.EventHandler(this.CheckMod_CheckedChanged);
            // 
            // CheckEli
            // 
            this.CheckEli.AutoSize = true;
            this.CheckEli.Enabled = false;
            this.CheckEli.Location = new System.Drawing.Point(948, 74);
            this.CheckEli.Margin = new System.Windows.Forms.Padding(4);
            this.CheckEli.Name = "CheckEli";
            this.CheckEli.Size = new System.Drawing.Size(74, 20);
            this.CheckEli.TabIndex = 5;
            this.CheckEli.Text = "Eliminar";
            this.CheckEli.UseVisualStyleBackColor = true;
            this.CheckEli.CheckedChanged += new System.EventHandler(this.CheckEli_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(583, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Regiones";
            // 
            // ButIng
            // 
            this.ButIng.Location = new System.Drawing.Point(718, 249);
            this.ButIng.Name = "ButIng";
            this.ButIng.Size = new System.Drawing.Size(97, 25);
            this.ButIng.TabIndex = 8;
            this.ButIng.Text = "Ingresar";
            this.ButIng.UseVisualStyleBackColor = true;
            this.ButIng.Visible = false;
            this.ButIng.Click += new System.EventHandler(this.ButIng_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Buscar Por:";
            // 
            // ButLim
            // 
            this.ButLim.Location = new System.Drawing.Point(962, 345);
            this.ButLim.Name = "ButLim";
            this.ButLim.Size = new System.Drawing.Size(100, 28);
            this.ButLim.TabIndex = 10;
            this.ButLim.Text = "Limpiar";
            this.ButLim.UseVisualStyleBackColor = true;
            this.ButLim.Click += new System.EventHandler(this.ButLim_Click);
            // 
            // ButSal
            // 
            this.ButSal.Location = new System.Drawing.Point(848, 408);
            this.ButSal.Name = "ButSal";
            this.ButSal.Size = new System.Drawing.Size(100, 28);
            this.ButSal.TabIndex = 11;
            this.ButSal.Text = "Salir";
            this.ButSal.UseVisualStyleBackColor = true;
            this.ButSal.Click += new System.EventHandler(this.ButSal_Click);
            // 
            // TextBus
            // 
            this.TextBus.Location = new System.Drawing.Point(147, 110);
            this.TextBus.Name = "TextBus";
            this.TextBus.Size = new System.Drawing.Size(320, 22);
            this.TextBus.TabIndex = 12;
            this.TextBus.TextChanged += new System.EventHandler(this.TextBus_TextChanged);
            // 
            // TextIngMod
            // 
            this.TextIngMod.Enabled = false;
            this.TextIngMod.Location = new System.Drawing.Point(718, 157);
            this.TextIngMod.Name = "TextIngMod";
            this.TextIngMod.Size = new System.Drawing.Size(196, 22);
            this.TextIngMod.TabIndex = 13;
            this.TextIngMod.TextChanged += new System.EventHandler(this.TextIngMod_TextChanged);
            this.TextIngMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextIngMod_KeyPress);
            // 
            // ButEli
            // 
            this.ButEli.Location = new System.Drawing.Point(948, 249);
            this.ButEli.Name = "ButEli";
            this.ButEli.Size = new System.Drawing.Size(97, 25);
            this.ButEli.TabIndex = 15;
            this.ButEli.Text = "Eliminar";
            this.ButEli.UseVisualStyleBackColor = true;
            this.ButEli.Visible = false;
            this.ButEli.Click += new System.EventHandler(this.ButEli_Click);
            // 
            // ButMod
            // 
            this.ButMod.Location = new System.Drawing.Point(834, 249);
            this.ButMod.Name = "ButMod";
            this.ButMod.Size = new System.Drawing.Size(97, 25);
            this.ButMod.TabIndex = 16;
            this.ButMod.Text = "Modificar";
            this.ButMod.UseVisualStyleBackColor = true;
            this.ButMod.Visible = false;
            this.ButMod.Click += new System.EventHandler(this.ButMod_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(124, 8);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(89, 22);
            this.textId.TabIndex = 17;
            this.textId.Visible = false;
            // 
            // ComboBusReg
            // 
            this.ComboBusReg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBusReg.FormattingEnabled = true;
            this.ComboBusReg.Location = new System.Drawing.Point(11, 8);
            this.ComboBusReg.Name = "ComboBusReg";
            this.ComboBusReg.Size = new System.Drawing.Size(108, 24);
            this.ComboBusReg.TabIndex = 244;
            this.ComboBusReg.Visible = false;
            this.ComboBusReg.SelectedIndexChanged += new System.EventHandler(this.ComboBusReg_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(715, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 19;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Grilla
            // 
            this.Grilla.AllowUserToAddRows = false;
            this.Grilla.AllowUserToDeleteRows = false;
            this.Grilla.AllowUserToResizeColumns = false;
            this.Grilla.AllowUserToResizeRows = false;
            this.Grilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Id,
            this.Region});
            this.Grilla.EnableHeadersVisualStyles = false;
            this.Grilla.Location = new System.Drawing.Point(34, 138);
            this.Grilla.Name = "Grilla";
            this.Grilla.ReadOnly = true;
            this.Grilla.RowHeadersVisible = false;
            this.Grilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grilla.Size = new System.Drawing.Size(580, 307);
            this.Grilla.TabIndex = 245;
            this.Grilla.DoubleClick += new System.EventHandler(this.Grilla_DoubleClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Region
            // 
            this.Region.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Region.HeaderText = "Region";
            this.Region.Name = "Region";
            this.Region.ReadOnly = true;
            // 
            // PReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 457);
            this.ControlBox = false;
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboBusReg);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.ButMod);
            this.Controls.Add(this.ButEli);
            this.Controls.Add(this.TextIngMod);
            this.Controls.Add(this.TextBus);
            this.Controls.Add(this.ButSal);
            this.Controls.Add(this.ButLim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButIng);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckEli);
            this.Controls.Add(this.CheckMod);
            this.Controls.Add(this.CheckIng);
            this.Controls.Add(this.ButVol);
            this.Controls.Add(this.ButLimBus);
            this.Controls.Add(this.ButBus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PReg";
            this.Text = "Region";
            this.Load += new System.EventHandler(this.PReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButBus;
        private System.Windows.Forms.Button ButLimBus;
        private System.Windows.Forms.Button ButVol;
        private System.Windows.Forms.CheckBox CheckIng;
        private System.Windows.Forms.CheckBox CheckMod;
        private System.Windows.Forms.CheckBox CheckEli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButIng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButLim;
        private System.Windows.Forms.Button ButSal;
        private System.Windows.Forms.TextBox TextBus;
        private System.Windows.Forms.TextBox TextIngMod;
        private System.Windows.Forms.Button ButEli;
        private System.Windows.Forms.Button ButMod;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox ComboBusReg;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
    }
}