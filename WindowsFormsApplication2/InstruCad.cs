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
using DevExpress.XtraEditors;
using DevExpress.XtraBars;

namespace WindowsFormsApplication2
{
    public partial class InstruCad : XtraForm
    {
        public InstruCad()
        {
            InitializeComponent();

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();

            this.Height = 450; //altura
            this.Width = 690; //largura

            radionacional.Checked = false;

            btnEditar.Enabled = false;
        }

        public class BDComun
        {
            public static SqlConnection ObterConexao()
            {
                SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kenzo\Documents\data.mdf;Integrated Security=True;Connect Timeout=30");
                Conn.Open();

                return Conn;

            }
           
        }
        
        public Int64 Id { get; set; }



        static string strCn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THIAGO KOSHIBA\DESKTOP\WINDOWSFORMSAPPLICATION2\BANCO.MDF;Integrated Security=True;Connect Timeout=30";
        SqlConnection conexao = new SqlConnection(strCn);


        public string classificacao { get; set; }
        public Cliente ClieteAtual { get; set; }
        public Instrum InstrumAtual { get; set; }
        public string situacao { get; set; }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuADM ss = new MenuADM();
            ss.Show();
        }



        void limpar()
        {
            txtNomeEquip.Clear();
            txtValor.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radiointernacional.Checked = false;
            radionacional.Checked = false;

        }


        private void combotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            combotipo.Text = "";
            

            if (combotipo.Text == "")
            {
                label10.Visible = true;
            }
            else
            {
                label10.Visible = false;
            }

        }

        private void combotipo_Enter(object sender, EventArgs e)
        {
            Validar val = new Validar();
            combotipo.DataSource = val.listanivel1();
            combotipo.DisplayMember = "Tipos";
        }

        private void radionacional_CheckedChanged(object sender, EventArgs e)
        {
            classificacao = "Nacional";
                label8.Visible = false;

        }

        private void radiointernacional_CheckedChanged(object sender, EventArgs e)
        {
            classificacao = "Internacional";
            label8.Visible = false;
        }

        

private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtNomeEquip.Text == "" || classificacao == "" || combotipo.Text == "" || txtValor.Text == "" || radionacional.Checked == false && radiointernacional.Checked == false || radioButton1.Checked == false && radioButton2.Checked == false)
            {
                   // MessageBox.Show("Deve preencher todos os campos!!", "ERRO AO CADASTRAR");
                

                if(txtNomeEquip.Text  == "")
                {
                    label7.Visible = true;
                }

                if (radiointernacional.Checked == false && radionacional.Checked == false)
                {
                    label8.Visible = true;
                }

                if (txtValor.Text == "")
                {
                    label9.Visible = true;
                }

                if (combotipo.Text == "")
                {
                    label10.Visible = true;
                }

                if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    label11.Visible = true;
                }

                label12.Visible = true;
            }
            else
            {
                Instrum Instrum = new Instrum();
                Instrum.NomeEquip = txtNomeEquip.Text;
                Instrum.Classificacao = classificacao;
                Instrum.Tipo = combotipo.Text;
                Instrum.valor = txtValor.Text;
                Instrum.Situacao = situacao;



                int resultado = InstrumFunc.Adicionar(Instrum);

                if (resultado > 0)
                {
                    MessageBox.Show("Instrumento cadastrado! ", "CADASTRO");
                    limpar();
                    combotipo.Text = "";
                    classificacao = "";
                    radiointernacional.Checked = false;
                    radionacional.Checked = false;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                }

                else
                {
                    MessageBox.Show("Não se pode guardar os dados, erro ao guardar");
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (txtNomeEquip.Text == "" || classificacao == "" || combotipo.Text == "" || txtValor.Text == "" || situacao == "")
            {
                MessageBox.Show("Deve preencher todos os campos!!", "ERRO AO EDITAR");
            }

            Instrum pInstrum = new Instrum();
            pInstrum.Id = Id;
            pInstrum.NomeEquip = txtNomeEquip.Text;
            pInstrum.Classificacao = classificacao;
            pInstrum.Tipo = combotipo.Text;
            pInstrum.valor = txtValor.Text;
            pInstrum.Situacao = situacao;



            int resultado = InstrumFunc.Editar(pInstrum);

            if (resultado > 0)
            {

                MessageBox.Show("Alteração dos dados do Instrumento OK!");
                limpar();

                combotipo.Text = "";

                radiointernacional.Checked = false;
                radionacional.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }

            else
            {
                MessageBox.Show("Não se pode editar o Instrumento, Erro!!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void InstruCad_Load(object sender, EventArgs e)
        {

        }

       // public System.Windows.Forms.Button BtnAdicionar;

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            situacao = "Ativo";
            label11.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            situacao = "Inativo";
            label11.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNomeEquip_TextChanged(object sender, EventArgs e)
        {
            if (txtNomeEquip.Text == "")
            {
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            if (txtValor.Text == "")
            {
                label9.Visible = true;
            }
            else
            {
                label7.Visible = false;
            }
        }
    }
    }