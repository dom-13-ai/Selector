namespace Selector
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Txtnombre = new TextBox();
            groupBox1 = new GroupBox();
            ChkLectura = new CheckBox();
            ChkProgramacion = new CheckBox();
            ChkArte = new CheckBox();
            ChkMusica = new CheckBox();
            ChkDeportes = new CheckBox();
            groupBox2 = new GroupBox();
            RbEnLinea = new RadioButton();
            RbHibrida = new RadioButton();
            RbPresencial = new RadioButton();
            btnLimpiar = new Button();
            BtnResumen = new Button();
            label2 = new Label();
            TxtResumen = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 29);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del estudiante";
            label1.Click += label1_Click;
            // 
            // Txtnombre
            // 
            Txtnombre.Location = new Point(204, 26);
            Txtnombre.Name = "Txtnombre";
            Txtnombre.Size = new Size(304, 23);
            Txtnombre.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ChkLectura);
            groupBox1.Controls.Add(ChkProgramacion);
            groupBox1.Controls.Add(ChkArte);
            groupBox1.Controls.Add(ChkMusica);
            groupBox1.Controls.Add(ChkDeportes);
            groupBox1.Location = new Point(70, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 153);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actividades favoritas (Pueden ser varios)";
            // 
            // ChkLectura
            // 
            ChkLectura.AutoSize = true;
            ChkLectura.Location = new Point(3, 128);
            ChkLectura.Name = "ChkLectura";
            ChkLectura.Size = new Size(65, 19);
            ChkLectura.TabIndex = 4;
            ChkLectura.Text = "Lectura";
            ChkLectura.UseVisualStyleBackColor = true;
            // 
            // ChkProgramacion
            // 
            ChkProgramacion.AutoSize = true;
            ChkProgramacion.Location = new Point(3, 103);
            ChkProgramacion.Name = "ChkProgramacion";
            ChkProgramacion.Size = new Size(101, 19);
            ChkProgramacion.TabIndex = 3;
            ChkProgramacion.Text = "Programación";
            ChkProgramacion.UseVisualStyleBackColor = true;
            // 
            // ChkArte
            // 
            ChkArte.AutoSize = true;
            ChkArte.Location = new Point(3, 78);
            ChkArte.Name = "ChkArte";
            ChkArte.Size = new Size(48, 19);
            ChkArte.TabIndex = 2;
            ChkArte.Text = "Arte";
            ChkArte.UseVisualStyleBackColor = true;
            // 
            // ChkMusica
            // 
            ChkMusica.AutoSize = true;
            ChkMusica.Location = new Point(3, 53);
            ChkMusica.Name = "ChkMusica";
            ChkMusica.Size = new Size(64, 19);
            ChkMusica.TabIndex = 1;
            ChkMusica.Text = "Música";
            ChkMusica.UseVisualStyleBackColor = true;
            // 
            // ChkDeportes
            // 
            ChkDeportes.AutoSize = true;
            ChkDeportes.Location = new Point(3, 28);
            ChkDeportes.Name = "ChkDeportes";
            ChkDeportes.Size = new Size(73, 19);
            ChkDeportes.TabIndex = 0;
            ChkDeportes.Text = "Deportes";
            ChkDeportes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RbEnLinea);
            groupBox2.Controls.Add(RbHibrida);
            groupBox2.Controls.Add(RbPresencial);
            groupBox2.Location = new Point(410, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(283, 153);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modalidad preferida (Elige una)";
            // 
            // RbEnLinea
            // 
            RbEnLinea.AutoSize = true;
            RbEnLinea.Location = new Point(13, 118);
            RbEnLinea.Name = "RbEnLinea";
            RbEnLinea.Size = new Size(66, 19);
            RbEnLinea.TabIndex = 2;
            RbEnLinea.TabStop = true;
            RbEnLinea.Text = "En línea";
            RbEnLinea.UseVisualStyleBackColor = true;
            // 
            // RbHibrida
            // 
            RbHibrida.AutoSize = true;
            RbHibrida.Location = new Point(13, 82);
            RbHibrida.Name = "RbHibrida";
            RbHibrida.Size = new Size(64, 19);
            RbHibrida.TabIndex = 1;
            RbHibrida.TabStop = true;
            RbHibrida.Text = "Hibrida";
            RbHibrida.UseVisualStyleBackColor = true;
            // 
            // RbPresencial
            // 
            RbPresencial.AutoSize = true;
            RbPresencial.Location = new Point(13, 43);
            RbPresencial.Name = "RbPresencial";
            RbPresencial.Size = new Size(78, 19);
            RbPresencial.TabIndex = 0;
            RbPresencial.TabStop = true;
            RbPresencial.Text = "Presencial";
            RbPresencial.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(618, 262);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // BtnResumen
            // 
            BtnResumen.Location = new Point(410, 262);
            BtnResumen.Name = "BtnResumen";
            BtnResumen.Size = new Size(133, 23);
            BtnResumen.TabIndex = 5;
            BtnResumen.Text = "Mostrar resumen";
            BtnResumen.UseVisualStyleBackColor = true;
            BtnResumen.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 292);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "Resumen";
            // 
            // TxtResumen
            // 
            TxtResumen.Location = new Point(70, 310);
            TxtResumen.Multiline = true;
            TxtResumen.Name = "TxtResumen";
            TxtResumen.ReadOnly = true;
            TxtResumen.Size = new Size(621, 222);
            TxtResumen.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 544);
            Controls.Add(TxtResumen);
            Controls.Add(label2);
            Controls.Add(BtnResumen);
            Controls.Add(btnLimpiar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Txtnombre);
            Controls.Add(label1);
            ForeColor = SystemColors.Highlight;
            Name = "Form1";
            Text = "Preferencias de actividades";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Txtnombre;
        private GroupBox groupBox1;
        private CheckBox ChkLectura;
        private CheckBox ChkProgramacion;
        private CheckBox ChkArte;
        private CheckBox ChkMusica;
        private CheckBox ChkDeportes;
        private GroupBox groupBox2;
        private RadioButton RbEnLinea;
        private RadioButton RbHibrida;
        private RadioButton RbPresencial;
        private Button btnLimpiar;
        private Button BtnResumen;
        private Label label2;
        private TextBox TxtResumen;
    }
}
