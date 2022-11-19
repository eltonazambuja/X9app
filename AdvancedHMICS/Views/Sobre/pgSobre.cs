using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedHMICS.Views.Sobre
{
    public partial class pgSobre : Form
    {
        public pgSobre()
        {
            InitializeComponent();
        }

        private void LinkContato_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.linkedin.com/in/elton-azambuja-7a622b96/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.GetBaseException());
               
            }
            
        }
    }
}
