namespace WindowsFormsApplication2
{
    partial class Relatorio
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
            this.servico = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // servico
            // 
            this.servico.FormattingEnabled = true;
            this.servico.Location = new System.Drawing.Point(162, 90);
            this.servico.Margin = new System.Windows.Forms.Padding(6);
            this.servico.Name = "servico";
            this.servico.Size = new System.Drawing.Size(238, 33);
            this.servico.TabIndex = 0;
            this.servico.SelectedIndexChanged += new System.EventHandler(this.servico_SelectedIndexChanged);
            this.servico.Enter += new System.EventHandler(this.servico_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(513, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(432, 31);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1943, 867);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.servico);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Relatorio";
            this.Text = "Relatorio";
            this.Load += new System.EventHandler(this.Relatorio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox servico;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}