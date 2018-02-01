namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Evento1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bntSalir = new System.Windows.Forms.Button();
            this.bntInsertar = new System.Windows.Forms.Button();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtresidencia = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TXT4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TXT3 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.TXT2 = new System.Windows.Forms.TextBox();
            this.TXT1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Evento1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Evento1
            // 
            this.Evento1.Controls.Add(this.tabPage1);
            this.Evento1.Controls.Add(this.tabPage2);
            this.Evento1.Controls.Add(this.tabPage3);
            this.Evento1.Location = new System.Drawing.Point(25, 24);
            this.Evento1.Name = "Evento1";
            this.Evento1.SelectedIndex = 0;
            this.Evento1.Size = new System.Drawing.Size(496, 313);
            this.Evento1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.BurlyWood;
            this.tabPage1.Controls.Add(this.bntSalir);
            this.tabPage1.Controls.Add(this.bntInsertar);
            this.tabPage1.Controls.Add(this.txtfecha);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtresidencia);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.txtCedula);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(488, 287);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestor Est";
            // 
            // bntSalir
            // 
            this.bntSalir.Location = new System.Drawing.Point(6, 256);
            this.bntSalir.Name = "bntSalir";
            this.bntSalir.Size = new System.Drawing.Size(75, 25);
            this.bntSalir.TabIndex = 10;
            this.bntSalir.Text = "Salir";
            this.bntSalir.UseVisualStyleBackColor = true;
            this.bntSalir.Click += new System.EventHandler(this.bntSalir_Click);
            // 
            // bntInsertar
            // 
            this.bntInsertar.Location = new System.Drawing.Point(372, 218);
            this.bntInsertar.Name = "bntInsertar";
            this.bntInsertar.Size = new System.Drawing.Size(75, 23);
            this.bntInsertar.TabIndex = 9;
            this.bntInsertar.Text = "Insertar";
            this.bntInsertar.UseVisualStyleBackColor = true;
            this.bntInsertar.Click += new System.EventHandler(this.bntInsertar_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.CustomFormat = "d/m/yyyy";
            this.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtfecha.Location = new System.Drawing.Point(227, 131);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(220, 20);
            this.txtfecha.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha Nac:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Residencia:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cedula:";
            // 
            // txtresidencia
            // 
            this.txtresidencia.Location = new System.Drawing.Point(227, 175);
            this.txtresidencia.Name = "txtresidencia";
            this.txtresidencia.Size = new System.Drawing.Size(220, 20);
            this.txtresidencia.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(227, 93);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(227, 49);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(220, 20);
            this.txtCedula.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.TXT4);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.TXT3);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.TXT2);
            this.tabPage2.Controls.Add(this.TXT1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.R);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(488, 287);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar Est";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 11;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label9.Location = new System.Drawing.Point(42, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Residencia:";
            // 
            // TXT4
            // 
            this.TXT4.Enabled = false;
            this.TXT4.Location = new System.Drawing.Point(148, 204);
            this.TXT4.Name = "TXT4";
            this.TXT4.Size = new System.Drawing.Size(220, 20);
            this.TXT4.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.button1.Location = new System.Drawing.Point(459, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXT3
            // 
            this.TXT3.Enabled = false;
            this.TXT3.Location = new System.Drawing.Point(148, 169);
            this.TXT3.Name = "TXT3";
            this.TXT3.Size = new System.Drawing.Size(220, 20);
            this.TXT3.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(36, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Fecha Nacimiento";
            // 
            // TXT2
            // 
            this.TXT2.Enabled = false;
            this.TXT2.Location = new System.Drawing.Point(148, 126);
            this.TXT2.Name = "TXT2";
            this.TXT2.Size = new System.Drawing.Size(220, 20);
            this.TXT2.TabIndex = 5;
            // 
            // TXT1
            // 
            this.TXT1.Enabled = false;
            this.TXT1.Location = new System.Drawing.Point(148, 90);
            this.TXT1.Name = "TXT1";
            this.TXT1.Size = new System.Drawing.Size(220, 20);
            this.TXT1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(42, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(42, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cedula";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // R
            // 
            this.R.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.R.FormattingEnabled = true;
            this.R.Location = new System.Drawing.Point(148, 46);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(220, 21);
            this.R.TabIndex = 1;
            this.R.SelectedIndexChanged += new System.EventHandler(this.R_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(42, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lista Estudiantes";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(488, 287);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Evento";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 28);
            this.button3.TabIndex = 1;
            this.button3.Text = "Iniciar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mous);
            this.button3.MouseHover += new System.EventHandler(this.BTM);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(853, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 371);
            this.Controls.Add(this.Evento1);
            this.Name = "Form1";
            this.Text = "Gestión de Estudiantes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Evento1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Evento1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtresidencia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bntSalir;
        private System.Windows.Forms.Button bntInsertar;
        private System.Windows.Forms.DateTimePicker txtfecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox R;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker TXT3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXT2;
        private System.Windows.Forms.TextBox TXT1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXT4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

