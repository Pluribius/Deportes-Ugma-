
namespace ugma1
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chk_deporte = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rdEdadA = new System.Windows.Forms.RadioButton();
            this.rdEdadB = new System.Windows.Forms.RadioButton();
            this.rdEdadC = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.box_camisetas = new System.Windows.Forms.ComboBox();
            this.btn_registrarse = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.box_camisetas);
            this.panel1.Location = new System.Drawing.Point(30, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 691);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.chk_deporte);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(38, 421);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 166);
            this.panel3.TabIndex = 8;
            // 
            // chk_deporte
            // 
            this.chk_deporte.BackColor = System.Drawing.Color.SteelBlue;
            this.chk_deporte.FormattingEnabled = true;
            this.chk_deporte.Items.AddRange(new object[] {
            "Atletismo",
            "Natación",
            "Ciclismo",
            "Levantamiento de pesas"});
            this.chk_deporte.Location = new System.Drawing.Point(19, 31);
            this.chk_deporte.Name = "chk_deporte";
            this.chk_deporte.Size = new System.Drawing.Size(195, 114);
            this.chk_deporte.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(78, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Disciplina";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.SteelBlue;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nombre.Location = new System.Drawing.Point(38, 153);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(250, 43);
            this.txt_nombre.TabIndex = 5;
            this.txt_nombre.Text = "Nombre";
            this.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.rdEdadA);
            this.panel2.Controls.Add(this.rdEdadB);
            this.panel2.Controls.Add(this.rdEdadC);
            this.panel2.Location = new System.Drawing.Point(38, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 137);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(91, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad";
            // 
            // rdEdadA
            // 
            this.rdEdadA.AutoSize = true;
            this.rdEdadA.Location = new System.Drawing.Point(61, 47);
            this.rdEdadA.Name = "rdEdadA";
            this.rdEdadA.Size = new System.Drawing.Size(128, 24);
            this.rdEdadA.TabIndex = 0;
            this.rdEdadA.TabStop = true;
            this.rdEdadA.Text = "Menores de 18";
            this.rdEdadA.UseVisualStyleBackColor = true;
            this.rdEdadA.CheckedChanged += new System.EventHandler(this.rdEdadA_CheckedChanged);
            // 
            // rdEdadB
            // 
            this.rdEdadB.AutoSize = true;
            this.rdEdadB.Location = new System.Drawing.Point(61, 77);
            this.rdEdadB.Name = "rdEdadB";
            this.rdEdadB.Size = new System.Drawing.Size(113, 24);
            this.rdEdadB.TabIndex = 1;
            this.rdEdadB.TabStop = true;
            this.rdEdadB.Text = "18 a 40 años";
            this.rdEdadB.UseVisualStyleBackColor = true;
            this.rdEdadB.CheckedChanged += new System.EventHandler(this.rdEdadB_CheckedChanged);
            // 
            // rdEdadC
            // 
            this.rdEdadC.AutoSize = true;
            this.rdEdadC.Location = new System.Drawing.Point(61, 107);
            this.rdEdadC.Name = "rdEdadC";
            this.rdEdadC.Size = new System.Drawing.Size(127, 24);
            this.rdEdadC.TabIndex = 2;
            this.rdEdadC.TabStop = true;
            this.rdEdadC.Text = "Mayores de 40";
            this.rdEdadC.UseVisualStyleBackColor = true;
            this.rdEdadC.CheckedChanged += new System.EventHandler(this.rdEdadC_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 106);
            this.label1.TabIndex = 6;
            this.label1.Text = "Registro";
            // 
            // box_camisetas
            // 
            this.box_camisetas.BackColor = System.Drawing.Color.SteelBlue;
            this.box_camisetas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box_camisetas.FormattingEnabled = true;
            this.box_camisetas.Items.AddRange(new object[] {
            "Pequeña",
            "Mediana",
            "Grande",
            "Extra grande"});
            this.box_camisetas.Location = new System.Drawing.Point(38, 627);
            this.box_camisetas.Name = "box_camisetas";
            this.box_camisetas.Size = new System.Drawing.Size(250, 39);
            this.box_camisetas.TabIndex = 4;
            this.box_camisetas.Text = "Tamaño de Camiseta";
            // 
            // btn_registrarse
            // 
            this.btn_registrarse.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_registrarse.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_registrarse.Location = new System.Drawing.Point(30, 747);
            this.btn_registrarse.Name = "btn_registrarse";
            this.btn_registrarse.Size = new System.Drawing.Size(327, 49);
            this.btn_registrarse.TabIndex = 2;
            this.btn_registrarse.Text = "Filtrar";
            this.btn_registrarse.UseVisualStyleBackColor = false;
            this.btn_registrarse.Click += new System.EventHandler(this.btn_registrarse_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(451, 156);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(495, 575);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(508, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 59);
            this.label4.TabIndex = 9;
            this.label4.Text = "Eventos Disponibles";
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.SkyBlue;
            this.Cancelar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cancelar.Location = new System.Drawing.Point(451, 747);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(220, 49);
            this.Cancelar.TabIndex = 10;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_imprimir.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_imprimir.Location = new System.Drawing.Point(726, 747);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(220, 49);
            this.btn_imprimir.TabIndex = 11;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(987, 799);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_registrarse);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox box_camisetas;
        private System.Windows.Forms.CheckedListBox chk_deporte;
        private System.Windows.Forms.RadioButton rdEdadC;
        private System.Windows.Forms.RadioButton rdEdadB;
        private System.Windows.Forms.RadioButton rdEdadA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_registrarse;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_imprimir;
    }
}