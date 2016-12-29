namespace WindowsFormsApplication2
{
    partial class Maincs
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
            this.equipamento = new System.Windows.Forms.Button();
            this.agendamento = new System.Windows.Forms.Button();
            this.cadastrar = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.salas = new System.Windows.Forms.Button();
            this.relatorio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.consultar = new System.Windows.Forms.Button();
            this.btnConsultaEquip = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // equipamento
            // 
            this.equipamento.Location = new System.Drawing.Point(28, 88);
            this.equipamento.Name = "equipamento";
            this.equipamento.Size = new System.Drawing.Size(103, 65);
            this.equipamento.TabIndex = 0;
            this.equipamento.Text = "EQUIPAMENTOS";
            this.equipamento.UseVisualStyleBackColor = true;
            this.equipamento.Click += new System.EventHandler(this.equipamento_Click);
            // 
            // agendamento
            // 
            this.agendamento.Location = new System.Drawing.Point(84, 191);
            this.agendamento.Name = "agendamento";
            this.agendamento.Size = new System.Drawing.Size(103, 65);
            this.agendamento.TabIndex = 1;
            this.agendamento.Text = "AGENDA";
            this.agendamento.UseVisualStyleBackColor = true;
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(364, 191);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(103, 65);
            this.cadastrar.TabIndex = 7;
            this.cadastrar.Text = "CADASTRAR";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(622, 232);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(75, 23);
            this.sair.TabIndex = 8;
            this.sair.Text = "SAIR";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // salas
            // 
            this.salas.Location = new System.Drawing.Point(309, 88);
            this.salas.Name = "salas";
            this.salas.Size = new System.Drawing.Size(103, 65);
            this.salas.TabIndex = 9;
            this.salas.Text = "SALAS";
            this.salas.UseVisualStyleBackColor = true;
            // 
            // relatorio
            // 
            this.relatorio.Location = new System.Drawing.Point(485, 88);
            this.relatorio.Name = "relatorio";
            this.relatorio.Size = new System.Drawing.Size(103, 65);
            this.relatorio.TabIndex = 10;
            this.relatorio.Text = "RELATÓRIO";
            this.relatorio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "NOAR ESTÚDIO";
            // 
            // consultar
            // 
            this.consultar.Location = new System.Drawing.Point(255, 191);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(103, 65);
            this.consultar.TabIndex = 12;
            this.consultar.Text = "CONSULTAR";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // btnConsultaEquip
            // 
            this.btnConsultaEquip.Location = new System.Drawing.Point(137, 88);
            this.btnConsultaEquip.Name = "btnConsultaEquip";
            this.btnConsultaEquip.Size = new System.Drawing.Size(103, 65);
            this.btnConsultaEquip.TabIndex = 13;
            this.btnConsultaEquip.Text = "CONSULTAR EQUIPAMENTO";
            this.btnConsultaEquip.UseVisualStyleBackColor = true;
            // 
            // btnPagamento
            // 
            this.btnPagamento.Location = new System.Drawing.Point(594, 89);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(103, 64);
            this.btnPagamento.TabIndex = 14;
            this.btnPagamento.Text = "PAGAMENTO";
            this.btnPagamento.UseVisualStyleBackColor = true;
            // 
            // Maincs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 267);
            this.Controls.Add(this.btnPagamento);
            this.Controls.Add(this.btnConsultaEquip);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.relatorio);
            this.Controls.Add(this.salas);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.agendamento);
            this.Controls.Add(this.equipamento);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Maincs";
            this.Text = "Maincs";
            this.Load += new System.EventHandler(this.Maincs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button equipamento;
        private System.Windows.Forms.Button agendamento;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Button salas;
        private System.Windows.Forms.Button relatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button btnConsultaEquip;
        private System.Windows.Forms.Button btnPagamento;
    }
}