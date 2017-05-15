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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio));
            this.servico = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.agendaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bancoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoDataSet = new WindowsFormsApplication2.bancoDataSet();
            this.agendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pgtoCartaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salaCadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salaCadTableAdapter = new WindowsFormsApplication2.bancoDataSetTableAdapters.SalaCadTableAdapter();
            this.pgtoCartaoTableAdapter = new WindowsFormsApplication2.bancoDataSetTableAdapters.PgtoCartaoTableAdapter();
            this.pgtoCartaoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoDataSet1 = new WindowsFormsApplication2.bancoDataSet();
            this.agendaTableAdapter1 = new WindowsFormsApplication2.bancoDataSetTableAdapters.AgendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgtoCartaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaCadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgtoCartaoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet1)).BeginInit();
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
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(1704, 739);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(150, 65);
            this.btnVoltar.TabIndex = 29;
            this.btnVoltar.Text = "MENU";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.agendaBindingSource2;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(39, 217);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "Sala";
            series1.YValueMembers = "Id";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1838, 374);
            this.chart1.TabIndex = 30;
            this.chart1.Text = "chart1";
            // 
            // agendaBindingSource2
            // 
            this.agendaBindingSource2.DataMember = "Agenda";
            this.agendaBindingSource2.DataSource = this.bancoDataSetBindingSource;
            // 
            // bancoDataSetBindingSource
            // 
            this.bancoDataSetBindingSource.DataSource = this.bancoDataSet;
            this.bancoDataSetBindingSource.Position = 0;
            // 
            // bancoDataSet
            // 
            this.bancoDataSet.DataSetName = "bancoDataSet";
            this.bancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaBindingSource1
            // 
            this.agendaBindingSource1.DataMember = "Agenda";
            this.agendaBindingSource1.DataSource = this.bancoDataSetBindingSource;
            // 
            // pgtoCartaoBindingSource
            // 
            this.pgtoCartaoBindingSource.DataMember = "PgtoCartao";
            this.pgtoCartaoBindingSource.DataSource = this.bancoDataSetBindingSource;
            // 
            // salaCadBindingSource
            // 
            this.salaCadBindingSource.DataMember = "SalaCad";
            this.salaCadBindingSource.DataSource = this.bancoDataSet;
            // 
            // salaCadTableAdapter
            // 
            this.salaCadTableAdapter.ClearBeforeFill = true;
            // 
            // pgtoCartaoTableAdapter
            // 
            this.pgtoCartaoTableAdapter.ClearBeforeFill = true;
            // 
            // pgtoCartaoBindingSource1
            // 
            this.pgtoCartaoBindingSource1.DataMember = "PgtoCartao";
            this.pgtoCartaoBindingSource1.DataSource = this.bancoDataSetBindingSource;
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataMember = "Agenda";
            this.agendaBindingSource.DataSource = this.bancoDataSet1;
            this.agendaBindingSource.Sort = "";
            // 
            // bancoDataSet1
            // 
            this.bancoDataSet1.DataSetName = "bancoDataSet";
            this.bancoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaTableAdapter1
            // 
            this.agendaTableAdapter1.ClearBeforeFill = true;
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1943, 867);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.servico);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Relatorio";
            this.Text = "Relatorio";
            this.Load += new System.EventHandler(this.Relatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgtoCartaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaCadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgtoCartaoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox servico;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource bancoDataSetBindingSource;
        private bancoDataSet bancoDataSet;
        private System.Windows.Forms.BindingSource salaCadBindingSource;
        private bancoDataSetTableAdapters.SalaCadTableAdapter salaCadTableAdapter;
        private System.Windows.Forms.BindingSource pgtoCartaoBindingSource;
        private bancoDataSetTableAdapters.PgtoCartaoTableAdapter pgtoCartaoTableAdapter;
        private bancoDataSetTableAdapters.AgendaTableAdapter agendaTableAdapter1;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private bancoDataSet bancoDataSet1;
        private System.Windows.Forms.BindingSource pgtoCartaoBindingSource1;
        private System.Windows.Forms.BindingSource agendaBindingSource1;
        private System.Windows.Forms.BindingSource agendaBindingSource2;
    }
}