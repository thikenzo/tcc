﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Relatorio : Form
    {


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30");

        public Relatorio()
        {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancoDataSet.Agenda'. Você pode movê-la ou removê-la conforme necessário.
            this.agendaTableAdapter1.Fill(this.bancoDataSet.Agenda);

        }

        private void servico_Enter(object sender, EventArgs e)
        {
            Validar val = new Validar();
            servico.DataSource = val.listarelatorio();
            servico.DisplayMember = "Relatorio";
        }

        private void servico_SelectedIndexChanged(object sender, EventArgs e)
        {
            servico.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuADM ss = new MenuADM();
            ss.Show();
        }
    }
}
