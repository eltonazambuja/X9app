using AdvancedHMICS.Libs;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace AdvancedHMICS.Views.Arquivo
{
    public partial class Teste : Form
    {
        Sender send = new Sender();
        public Teste(Sender sd)
        {
            InitializeComponent();
            send = sd;
        }

        private void Teste_Load(object sender, EventArgs e)
        {
            Clear();
            
        }
        private void Clear()
        {
            TxtPara.Text = "";
            TxtAssunto.Text = "";
            TxtConteudo.Text = "";
            BtnEnviar.Enabled = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
            Close();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SendMsgPerson.Send(send, TxtPara.Text, TxtAssunto.Text, TxtConteudo.Text) == 1)
                {
                    MessageBox.Show("Mensagem Enviada com Sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.GetBaseException());
            }
            
            
        }

        private void TxtPara_TextChanged(object sender, EventArgs e)
        {
            if (TxtPara.Text.Length > 4)
            {
                BtnEnviar.Enabled = true;
            }
            else
            {
                BtnEnviar.Enabled = false;
            }
        }
    }
}
