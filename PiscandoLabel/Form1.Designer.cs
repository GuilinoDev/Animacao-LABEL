namespace PiscandoLabel
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelOpenbar = new System.Windows.Forms.Label();
            this.labelVisitar = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelOpenbar
            // 
            this.labelOpenbar.AutoSize = true;
            this.labelOpenbar.BackColor = System.Drawing.Color.Transparent;
            this.labelOpenbar.Font = new System.Drawing.Font("Ink Free", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpenbar.ForeColor = System.Drawing.Color.Red;
            this.labelOpenbar.Location = new System.Drawing.Point(45, 83);
            this.labelOpenbar.Name = "labelOpenbar";
            this.labelOpenbar.Size = new System.Drawing.Size(283, 79);
            this.labelOpenbar.TabIndex = 0;
            this.labelOpenbar.Text = "Open bar";
            // 
            // labelVisitar
            // 
            this.labelVisitar.AutoSize = true;
            this.labelVisitar.BackColor = System.Drawing.Color.Black;
            this.labelVisitar.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisitar.ForeColor = System.Drawing.Color.Yellow;
            this.labelVisitar.Location = new System.Drawing.Point(95, 173);
            this.labelVisitar.Name = "labelVisitar";
            this.labelVisitar.Size = new System.Drawing.Size(179, 26);
            this.labelVisitar.TabIndex = 1;
            this.labelVisitar.Text = "Venha nos visitar!!!";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(400, 262);
            this.Controls.Add(this.labelVisitar);
            this.Controls.Add(this.labelOpenbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOpenbar;
        private System.Windows.Forms.Label labelVisitar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

