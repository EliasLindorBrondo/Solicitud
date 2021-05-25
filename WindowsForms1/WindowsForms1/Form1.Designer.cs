
namespace WindowsForms1
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
            this.bt1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.combo2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbmensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(307, 91);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 23);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "Solicitar ";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Solicitar Inscripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Profesion";
            // 
            // combo1
            // 
            this.combo1.FormattingEnabled = true;
            this.combo1.Items.AddRange(new object[] {
            "Ingeniero",
            "Contador",
            "Psicologia",
            "Enfermero"});
            this.combo1.Location = new System.Drawing.Point(26, 93);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(121, 21);
            this.combo1.TabIndex = 3;
            this.combo1.Text = "Elegir";
            this.combo1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // combo2
            // 
            this.combo2.FormattingEnabled = true;
            this.combo2.Items.AddRange(new object[] {
            "MAÑANA",
            "TARDE",
            "NOCHE"});
            this.combo2.Location = new System.Drawing.Point(167, 93);
            this.combo2.Name = "combo2";
            this.combo2.Size = new System.Drawing.Size(121, 21);
            this.combo2.TabIndex = 4;
            this.combo2.Text = "Elegir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Horario";
            // 
            // lbmensaje
            // 
            this.lbmensaje.AutoSize = true;
            this.lbmensaje.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmensaje.Location = new System.Drawing.Point(23, 145);
            this.lbmensaje.Name = "lbmensaje";
            this.lbmensaje.Size = new System.Drawing.Size(0, 17);
            this.lbmensaje.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 291);
            this.Controls.Add(this.lbmensaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo2);
            this.Controls.Add(this.combo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt1);
            this.Name = "Form1";
            this.Text = "Profesiones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo1;
        private System.Windows.Forms.ComboBox combo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbmensaje;
    }
}

