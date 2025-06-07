namespace Presentacion.Producto
{
    partial class PProd_Ing
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextCAR = new System.Windows.Forms.TextBox();
            this.LblDescr = new System.Windows.Forms.Label();
            this.ButSal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ButLim = new System.Windows.Forms.Button();
            this.ButVol = new System.Windows.Forms.Button();
            this.ButIng = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TextVAPU = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextCA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextTA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TextFeIn = new System.Windows.Forms.TextBox();
            this.TextNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextCAR);
            this.groupBox1.Controls.Add(this.LblDescr);
            this.groupBox1.Controls.Add(this.ButSal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ButLim);
            this.groupBox1.Controls.Add(this.ButVol);
            this.groupBox1.Controls.Add(this.ButIng);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TextVAPU);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TextCA);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TextTA);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TextFeIn);
            this.groupBox1.Controls.Add(this.TextNom);
            this.groupBox1.Location = new System.Drawing.Point(26, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(989, 376);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos ";
            // 
            // TextCAR
            // 
            this.TextCAR.Location = new System.Drawing.Point(269, 220);
            this.TextCAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextCAR.Name = "TextCAR";
            this.TextCAR.Size = new System.Drawing.Size(278, 24);
            this.TextCAR.TabIndex = 28;
            this.TextCAR.TextChanged += new System.EventHandler(this.TextCAR_TextChanged);
            this.TextCAR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextCAR_KeyPress);
            // 
            // LblDescr
            // 
            this.LblDescr.AutoSize = true;
            this.LblDescr.Location = new System.Drawing.Point(39, 220);
            this.LblDescr.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblDescr.Name = "LblDescr";
            this.LblDescr.Size = new System.Drawing.Size(141, 18);
            this.LblDescr.TabIndex = 27;
            this.LblDescr.Text = "Cantidad Arrendada:";
            // 
            // ButSal
            // 
            this.ButSal.Location = new System.Drawing.Point(795, 251);
            this.ButSal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButSal.Name = "ButSal";
            this.ButSal.Size = new System.Drawing.Size(114, 46);
            this.ButSal.TabIndex = 26;
            this.ButSal.Text = "Salir";
            this.ButSal.UseVisualStyleBackColor = true;
            this.ButSal.Click += new System.EventHandler(this.ButSal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // ButLim
            // 
            this.ButLim.Enabled = false;
            this.ButLim.Location = new System.Drawing.Point(627, 251);
            this.ButLim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButLim.Name = "ButLim";
            this.ButLim.Size = new System.Drawing.Size(114, 46);
            this.ButLim.TabIndex = 25;
            this.ButLim.Text = "Limpiar";
            this.ButLim.UseVisualStyleBackColor = true;
            this.ButLim.Click += new System.EventHandler(this.ButLim_Click);
            // 
            // ButVol
            // 
            this.ButVol.Location = new System.Drawing.Point(798, 146);
            this.ButVol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButVol.Name = "ButVol";
            this.ButVol.Size = new System.Drawing.Size(114, 46);
            this.ButVol.TabIndex = 24;
            this.ButVol.Text = "Volver";
            this.ButVol.UseVisualStyleBackColor = true;
            this.ButVol.Click += new System.EventHandler(this.ButVol_Click);
            // 
            // ButIng
            // 
            this.ButIng.Enabled = false;
            this.ButIng.Location = new System.Drawing.Point(627, 146);
            this.ButIng.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButIng.Name = "ButIng";
            this.ButIng.Size = new System.Drawing.Size(114, 46);
            this.ButIng.TabIndex = 23;
            this.ButIng.Text = "Ingresar";
            this.ButIng.UseVisualStyleBackColor = true;
            this.ButIng.Click += new System.EventHandler(this.ButIng_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha de Incorporacion:";
            // 
            // TextVAPU
            // 
            this.TextVAPU.Location = new System.Drawing.Point(269, 328);
            this.TextVAPU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextVAPU.Name = "TextVAPU";
            this.TextVAPU.Size = new System.Drawing.Size(277, 24);
            this.TextVAPU.TabIndex = 20;
            this.TextVAPU.TextChanged += new System.EventHandler(this.TextVAPU_TextChanged);
            this.TextVAPU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextVAPU_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 274);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total Actual:";
            // 
            // TextCA
            // 
            this.TextCA.Location = new System.Drawing.Point(267, 169);
            this.TextCA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextCA.Name = "TextCA";
            this.TextCA.Size = new System.Drawing.Size(278, 24);
            this.TextCA.TabIndex = 19;
            this.TextCA.TextChanged += new System.EventHandler(this.TextCA_TextChanged);
            this.TextCA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextCA_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 173);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cantidad Inicial:";
            // 
            // TextTA
            // 
            this.TextTA.Location = new System.Drawing.Point(267, 269);
            this.TextTA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextTA.Name = "TextTA";
            this.TextTA.Size = new System.Drawing.Size(278, 24);
            this.TextTA.TabIndex = 18;
            this.TextTA.TextChanged += new System.EventHandler(this.TextTA_TextChanged);
            this.TextTA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextTA_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 328);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Valor Arriendo por Unidad:";
            // 
            // TextFeIn
            // 
            this.TextFeIn.Location = new System.Drawing.Point(267, 119);
            this.TextFeIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextFeIn.Name = "TextFeIn";
            this.TextFeIn.Size = new System.Drawing.Size(278, 24);
            this.TextFeIn.TabIndex = 17;
            this.TextFeIn.TextChanged += new System.EventHandler(this.TextFeIn_TextChanged);
            this.TextFeIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextFeIn_KeyPress);
            // 
            // TextNom
            // 
            this.TextNom.Location = new System.Drawing.Point(267, 65);
            this.TextNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextNom.Name = "TextNom";
            this.TextNom.Size = new System.Drawing.Size(280, 24);
            this.TextNom.TabIndex = 13;
            this.TextNom.TextChanged += new System.EventHandler(this.TextNom_TextChanged);
            this.TextNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextNom_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ingresar Nuevo Producto";
            // 
            // PProd_Ing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 457);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PProd_Ing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Producto";
            this.Load += new System.EventHandler(this.PProd_Ing_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextCAR;
        private System.Windows.Forms.Label LblDescr;
        private System.Windows.Forms.Button ButSal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButLim;
        private System.Windows.Forms.Button ButVol;
        private System.Windows.Forms.Button ButIng;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextVAPU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextCA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextTA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextFeIn;
        private System.Windows.Forms.TextBox TextNom;
        private System.Windows.Forms.Label label1;
    }
}