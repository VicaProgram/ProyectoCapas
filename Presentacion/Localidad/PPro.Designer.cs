namespace Presentacion.Localidad
{
    partial class PPro
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
            this.ComboIngModReg = new System.Windows.Forms.ComboBox();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboBus = new System.Windows.Forms.ComboBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.ButMod = new System.Windows.Forms.Button();
            this.ButEli = new System.Windows.Forms.Button();
            this.TextIngMod = new System.Windows.Forms.TextBox();
            this.TextBus = new System.Windows.Forms.TextBox();
            this.ButSal = new System.Windows.Forms.Button();
            this.ButLim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ButIng = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckEli = new System.Windows.Forms.CheckBox();
            this.CheckMod = new System.Windows.Forms.CheckBox();
            this.CheckIng = new System.Windows.Forms.CheckBox();
            this.ButVol = new System.Windows.Forms.Button();
            this.ButLimBus = new System.Windows.Forms.Button();
            this.ButBus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textReg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboIngModReg
            // 
            this.ComboIngModReg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboIngModReg.Enabled = false;
            this.ComboIngModReg.FormattingEnabled = true;
            this.ComboIngModReg.Location = new System.Drawing.Point(694, 225);
            this.ComboIngModReg.Margin = new System.Windows.Forms.Padding(4);
            this.ComboIngModReg.Name = "ComboIngModReg";
            this.ComboIngModReg.Size = new System.Drawing.Size(160, 24);
            this.ComboIngModReg.TabIndex = 291;
            this.ComboIngModReg.SelectedIndexChanged += new System.EventHandler(this.ComboIngModReg_SelectedIndexChanged);
            // 
            // Grilla
            // 
            this.Grilla.AllowUserToAddRows = false;
            this.Grilla.AllowUserToDeleteRows = false;
            this.Grilla.AllowUserToResizeColumns = false;
            this.Grilla.AllowUserToResizeRows = false;
            this.Grilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.IdProvincia,
            this.Provincia,
            this.Id,
            this.Region});
            this.Grilla.EnableHeadersVisualStyles = false;
            this.Grilla.Location = new System.Drawing.Point(13, 129);
            this.Grilla.Margin = new System.Windows.Forms.Padding(4);
            this.Grilla.MultiSelect = false;
            this.Grilla.Name = "Grilla";
            this.Grilla.ReadOnly = true;
            this.Grilla.RowHeadersVisible = false;
            this.Grilla.Size = new System.Drawing.Size(549, 330);
            this.Grilla.TabIndex = 290;
            this.Grilla.DoubleClick += new System.EventHandler(this.Grilla_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // IdProvincia
            // 
            this.IdProvincia.HeaderText = "IdProvincia";
            this.IdProvincia.Name = "IdProvincia";
            this.IdProvincia.ReadOnly = true;
            this.IdProvincia.Visible = false;
            // 
            // Provincia
            // 
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(694, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 288;
            // 
            // ComboBus
            // 
            this.ComboBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBus.FormattingEnabled = true;
            this.ComboBus.Location = new System.Drawing.Point(3, 93);
            this.ComboBus.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBus.Name = "ComboBus";
            this.ComboBus.Size = new System.Drawing.Size(160, 24);
            this.ComboBus.TabIndex = 289;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(337, 497);
            this.textId.Margin = new System.Windows.Forms.Padding(4);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(132, 22);
            this.textId.TabIndex = 287;
            this.textId.Visible = false;
            // 
            // ButMod
            // 
            this.ButMod.Location = new System.Drawing.Point(830, 288);
            this.ButMod.Margin = new System.Windows.Forms.Padding(4);
            this.ButMod.Name = "ButMod";
            this.ButMod.Size = new System.Drawing.Size(89, 28);
            this.ButMod.TabIndex = 286;
            this.ButMod.Text = "Modificar";
            this.ButMod.UseVisualStyleBackColor = true;
            this.ButMod.Visible = false;
            this.ButMod.Click += new System.EventHandler(this.ButMod_Click);
            // 
            // ButEli
            // 
            this.ButEli.Location = new System.Drawing.Point(966, 288);
            this.ButEli.Margin = new System.Windows.Forms.Padding(4);
            this.ButEli.Name = "ButEli";
            this.ButEli.Size = new System.Drawing.Size(89, 28);
            this.ButEli.TabIndex = 285;
            this.ButEli.Text = "Eliminar";
            this.ButEli.UseVisualStyleBackColor = true;
            this.ButEli.Visible = false;
            this.ButEli.Click += new System.EventHandler(this.ButEli_Click);
            // 
            // TextIngMod
            // 
            this.TextIngMod.Enabled = false;
            this.TextIngMod.Location = new System.Drawing.Point(694, 156);
            this.TextIngMod.Margin = new System.Windows.Forms.Padding(4);
            this.TextIngMod.Name = "TextIngMod";
            this.TextIngMod.Size = new System.Drawing.Size(200, 22);
            this.TextIngMod.TabIndex = 284;
            this.TextIngMod.TextChanged += new System.EventHandler(this.TextIngMod_TextChanged);
            this.TextIngMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextIngMod_KeyPress);
            // 
            // TextBus
            // 
            this.TextBus.Location = new System.Drawing.Point(197, 96);
            this.TextBus.Margin = new System.Windows.Forms.Padding(4);
            this.TextBus.Name = "TextBus";
            this.TextBus.Size = new System.Drawing.Size(377, 22);
            this.TextBus.TabIndex = 283;
            this.TextBus.TextChanged += new System.EventHandler(this.TextBus_TextChanged);
            this.TextBus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBus_KeyPress);
            // 
            // ButSal
            // 
            this.ButSal.Location = new System.Drawing.Point(830, 404);
            this.ButSal.Margin = new System.Windows.Forms.Padding(4);
            this.ButSal.Name = "ButSal";
            this.ButSal.Size = new System.Drawing.Size(89, 28);
            this.ButSal.TabIndex = 282;
            this.ButSal.Text = "Salir";
            this.ButSal.UseVisualStyleBackColor = true;
            this.ButSal.Click += new System.EventHandler(this.ButSal_Click);
            // 
            // ButLim
            // 
            this.ButLim.Location = new System.Drawing.Point(966, 371);
            this.ButLim.Margin = new System.Windows.Forms.Padding(4);
            this.ButLim.Name = "ButLim";
            this.ButLim.Size = new System.Drawing.Size(89, 28);
            this.ButLim.TabIndex = 281;
            this.ButLim.Text = "Limpiar";
            this.ButLim.UseVisualStyleBackColor = true;
            this.ButLim.Click += new System.EventHandler(this.ButLim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 280;
            this.label2.Text = "Buscar Por:";
            // 
            // ButIng
            // 
            this.ButIng.Location = new System.Drawing.Point(694, 288);
            this.ButIng.Margin = new System.Windows.Forms.Padding(4);
            this.ButIng.Name = "ButIng";
            this.ButIng.Size = new System.Drawing.Size(89, 28);
            this.ButIng.TabIndex = 279;
            this.ButIng.Text = "Ingresar";
            this.ButIng.UseVisualStyleBackColor = true;
            this.ButIng.Visible = false;
            this.ButIng.Click += new System.EventHandler(this.ButIng_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(578, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 278;
            this.label1.Text = "Provincias";
            // 
            // CheckEli
            // 
            this.CheckEli.AutoSize = true;
            this.CheckEli.Enabled = false;
            this.CheckEli.Location = new System.Drawing.Point(966, 70);
            this.CheckEli.Margin = new System.Windows.Forms.Padding(5);
            this.CheckEli.Name = "CheckEli";
            this.CheckEli.Size = new System.Drawing.Size(74, 20);
            this.CheckEli.TabIndex = 277;
            this.CheckEli.Text = "Eliminar";
            this.CheckEli.UseVisualStyleBackColor = true;
            this.CheckEli.CheckedChanged += new System.EventHandler(this.CheckEli_CheckedChanged);
            // 
            // CheckMod
            // 
            this.CheckMod.AutoSize = true;
            this.CheckMod.Enabled = false;
            this.CheckMod.Location = new System.Drawing.Point(830, 70);
            this.CheckMod.Margin = new System.Windows.Forms.Padding(5);
            this.CheckMod.Name = "CheckMod";
            this.CheckMod.Size = new System.Drawing.Size(81, 20);
            this.CheckMod.TabIndex = 276;
            this.CheckMod.Text = "Modificar";
            this.CheckMod.UseVisualStyleBackColor = true;
            this.CheckMod.CheckedChanged += new System.EventHandler(this.CheckMod_CheckedChanged);
            // 
            // CheckIng
            // 
            this.CheckIng.AutoSize = true;
            this.CheckIng.Location = new System.Drawing.Point(694, 70);
            this.CheckIng.Margin = new System.Windows.Forms.Padding(5);
            this.CheckIng.Name = "CheckIng";
            this.CheckIng.Size = new System.Drawing.Size(75, 20);
            this.CheckIng.TabIndex = 275;
            this.CheckIng.Text = "Ingresar";
            this.CheckIng.UseVisualStyleBackColor = true;
            this.CheckIng.CheckedChanged += new System.EventHandler(this.CheckIng_CheckedChanged);
            // 
            // ButVol
            // 
            this.ButVol.Location = new System.Drawing.Point(694, 371);
            this.ButVol.Margin = new System.Windows.Forms.Padding(5);
            this.ButVol.Name = "ButVol";
            this.ButVol.Size = new System.Drawing.Size(89, 28);
            this.ButVol.TabIndex = 274;
            this.ButVol.Text = "Volver";
            this.ButVol.UseVisualStyleBackColor = true;
            this.ButVol.Click += new System.EventHandler(this.ButVol_Click);
            // 
            // ButLimBus
            // 
            this.ButLimBus.Location = new System.Drawing.Point(367, 35);
            this.ButLimBus.Margin = new System.Windows.Forms.Padding(5);
            this.ButLimBus.Name = "ButLimBus";
            this.ButLimBus.Size = new System.Drawing.Size(189, 34);
            this.ButLimBus.TabIndex = 273;
            this.ButLimBus.Text = "Limpiar Busqueda";
            this.ButLimBus.UseVisualStyleBackColor = true;
            this.ButLimBus.Click += new System.EventHandler(this.ButLimBus_Click);
            // 
            // ButBus
            // 
            this.ButBus.Location = new System.Drawing.Point(207, 35);
            this.ButBus.Margin = new System.Windows.Forms.Padding(5);
            this.ButBus.Name = "ButBus";
            this.ButBus.Size = new System.Drawing.Size(149, 34);
            this.ButBus.TabIndex = 272;
            this.ButBus.Text = "Buscar";
            this.ButBus.UseVisualStyleBackColor = true;
            this.ButBus.Click += new System.EventHandler(this.ButBus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 292;
            this.label3.Text = "Region";
            // 
            // textReg
            // 
            this.textReg.Location = new System.Drawing.Point(337, 529);
            this.textReg.Margin = new System.Windows.Forms.Padding(4);
            this.textReg.Name = "textReg";
            this.textReg.Size = new System.Drawing.Size(132, 22);
            this.textReg.TabIndex = 293;
            this.textReg.Visible = false;
            // 
            // PPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 461);
            this.Controls.Add(this.textReg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboIngModReg);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboBus);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PPro";
            this.Text = "Provincia";
            this.Load += new System.EventHandler(this.PPro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox ComboIngModReg;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox ComboBus;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Button ButMod;
        private System.Windows.Forms.Button ButEli;
        private System.Windows.Forms.TextBox TextIngMod;
        private System.Windows.Forms.TextBox TextBus;
        private System.Windows.Forms.Button ButSal;
        private System.Windows.Forms.Button ButLim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButIng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckEli;
        private System.Windows.Forms.CheckBox CheckMod;
        private System.Windows.Forms.CheckBox CheckIng;
        private System.Windows.Forms.Button ButVol;
        private System.Windows.Forms.Button ButLimBus;
        private System.Windows.Forms.Button ButBus;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textReg;
    }
}