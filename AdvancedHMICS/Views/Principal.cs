
using AdvancedHMICS.Libs;
using AdvancedHMICS.Views.Arquivo;
using AdvancedHMICS.Views.Sobre;
using System;
using System.Windows.Forms;

namespace AdvancedHMICS.Views
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        private void Principal_Load(object sender, EventArgs e)
        { 
            NotIcon.Text = "X9app";
            NotIcon.BalloonTipText = "Aplicação funcionando...";
            NotIcon.ShowBalloonTip(1000);
            NotIcon.Visible = true;
            Hide();
        }       
        public Sender send = new Sender();//configurar email.
        private void NotIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        //Descarga Centrifugas
        private void BindFalhaDescargaCent1_ValueSelectColor2Changed(object sender, EventArgs e)
        {
            if (CLP_Past.Read("CENT1.Falha_Descarga") == "True")
            {
                MessageBox.Show("teste");
                SendMsg.Send(send, "Manutenção", "Centrifuga 300", "Falha na descarga da centrifuga 300");
            }
        }

        private void BindFalhaDescargaCent2_ValueSelectColor2Changed(object sender, EventArgs e)
        {
            if (CLP_Past.Read("CENT2.Falha_Descarga") == "True")
            {
                MessageBox.Show("teste");
                SendMsg.Send(send, "Manutenção", "Centrifuga Bactofuga", "Falha na descarga da centrifuga Bactofuga");
            }
        }

        private void BindFalhaDescargaCent3_ValueSelectColor2Changed(object sender, EventArgs e)
        {
            if (CLP_Past.Read("CENT3.Falha_Descarga") == "True")
            {
                SendMsg.Send(send, "Manutenção", "Centrifuga 130", "Falha na descarga da centrifuga 130");
            }
        }
        //Falha Corrente Centrifuga
        private void BindCorrenteAlta1_ValueSelectColor2Changed(object sender, EventArgs e)
        {
            if (CLP_Past.Read("CENT1.Falha_IAH") == "True")
            {
                SendMsg.Send(send, "Manutenção", "Centrifuga 300", "Falha de Corrente Alta");
            }
        }
        private void BindCorrenteAlta2_ValueSelectColor2Changed(object sender, EventArgs e)
        {
            if (CLP_Past.Read("CENT2.Falha_IAH") == "True")
            {
                SendMsg.Send(send, "Manutenção", "Centrifuga Bactofuga", "Falha de Corrente Alta");
            }
        }
        private void BindCorrenteAlta3_ValueSelectColor2Changed(object sender, EventArgs e)
        {
            if (CLP_Past.Read("CENT3.Falha_IAH") == "True")
            {
                SendMsg.Send(send, "Manutenção", "Centrifuga 130", "Falha de Corrente Alta");
            }
        }
        //falha recuperação de rotação
        private void BindRecuperacao1_ValueSelectColor2Changed(object sender, EventArgs e)
        {
            if (CLP_Past.Read("CENT1.Falha_SAL") == "True")
            {
                SendMsg.Send(send, "Manutenção", "Centrifuga 300", "Falha na recuperação de rotação após uma descarga");
            }
        }
        private void BindRecuperacao2_ValueSelectColor2Changed(object sender, EventArgs e)
        {
            if (CLP_Past.Read("CENT2.Falha_SAL") == "True")
            {
                SendMsg.Send(send, "Manutenção", "Centrifuga Bactofuga", "Falha na recuperação de rotação após uma descarga");
            }
        }
        private void BindRecuperacao3_ValueSelectColor2Changed(object sender, EventArgs e)
        {
            if (CLP_Past.Read("CENT3.Falha_SAL") == "True")
            {
                SendMsg.Send(send, "Manutenção", "Centrifuga 130", "Falha na recuperação de rotação após uma descarga");
            }
        }
        //Tempo Enchimento das Tinas 1 - 4
        private void BindEncherT1_ValueSelectColor2Changed(object sender, EventArgs e)
        {
            if (CLP_Tinas.Read("TempoEnchimentoT1.DN") == "True")
            {
                SendMsg.Send(send, "Queijaria", "Tina 1", $"Demora no enchimento do lote:{CLP_Tinas.Read("T1_LOTE")}, data: {DateTime.Now}");
            }
        }
        private void BindEncherT2_ValueSelectColor2Changed(object sender, EventArgs e)
        {
            if (CLP_Tinas.Read("TempoEnchimentoT2.DN") == "True")
            {
                SendMsg.Send(send, "Queijaria", "Tina 2", $"Demora no enchimento do lote:{CLP_Tinas.Read("T2_LOTE")}, data: {DateTime.Now}");
            }
        }
        private void BindEncherT3_ValueSelectColor2Changed(object sender, EventArgs e)
        {
            if (CLP_Tinas.Read("TempoEnchimentoT3.DN") == "True")
            {
                SendMsg.Send(send, "Queijaria", "Tina 3", $"Demora no enchimento do lote:{CLP_Tinas.Read("T3_LOTE")}, data: {DateTime.Now}");
            }
        }
        private void BindEncherT4_ValueSelectColor2Changed(object sender, EventArgs e)
        {
            if (CLP_Tinas.Read("TempoEnchimentoT4.DN") == "True")
            {
                SendMsg.Send(send, "Queijaria", "Tina 4", $"Demora no enchimento do lote:{CLP_Tinas.Read("T4_LOTE")}, data: {DateTime.Now}");
            }
        }
        //Aquecimento Tinas
        private void BindAquecertT1_ValueSelectColor2Changed(object sender, EventArgs e)
        {
            if (CLP_Tinas.Read("TempoAquecimentoT1.DN") == "True")
            {
                SendMsg.Send(send, "Queijaria", "Tina 1", $"Demora no aquecimento do lote:{CLP_Tinas.Read("T4_LOTE")}, data: {DateTime.Now}");
            }
        }
        private void BindAquecertT2_ValueSelectColor2Changed(object sender, EventArgs e)
        {
            if (CLP_Tinas.Read("TempoAquecimentoT2.DN") == "True")
            {
                SendMsg.Send(send, "Queijaria", "Tina 1", $"Demora no aquecimento do lote:{CLP_Tinas.Read("T4_LOTE")}, data: {DateTime.Now}");
            }
        }
        private void BindAquecertT3_ValueSelectColor2Changed(object sender, EventArgs e)
        {
            if (CLP_Tinas.Read("TempoAquecimentoT3.DN") == "True")
            {
                SendMsg.Send(send, "Queijaria", "Tina 1", $"Demora no aquecimento do lote:{CLP_Tinas.Read("T4_LOTE")}, data: {DateTime.Now}");
            }
        }
        private void BindAquecertT4_ValueSelectColor2Changed(object sender, EventArgs e)
        {
            if (CLP_Tinas.Read("TempoAquecimentoT4.DN") == "True")
            {
                SendMsg.Send(send, "Queijaria", "Tina 1", $"Demora no aquecimento do lote:{CLP_Tinas.Read("T4_LOTE")}, data: {DateTime.Now}");
            }
        }

        private void TesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teste ts = new Teste(send);
            ts.Show();
        }

        private void SobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           pgSobre sb = new pgSobre();
            sb.Show();
        }
    }
}
