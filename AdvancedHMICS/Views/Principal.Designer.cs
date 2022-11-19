namespace AdvancedHMICS.Views
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.NotIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TesteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BindAquecertT4 = new AdvancedHMIControls.BasicIndicator();
            this.CLP_Past = new AdvancedHMIDrivers.EthernetIPforCLXCom(this.components);
            this.BindAquecertT3 = new AdvancedHMIControls.BasicIndicator();
            this.BindAquecertT2 = new AdvancedHMIControls.BasicIndicator();
            this.BindAquecertT1 = new AdvancedHMIControls.BasicIndicator();
            this.BindEncherT4 = new AdvancedHMIControls.BasicIndicator();
            this.BindEncherT3 = new AdvancedHMIControls.BasicIndicator();
            this.BindEncherT2 = new AdvancedHMIControls.BasicIndicator();
            this.BindEncherT1 = new AdvancedHMIControls.BasicIndicator();
            this.BindStatusPLCtinas = new AdvancedHMIControls.BasicIndicator();
            this.CLP_Tinas = new AdvancedHMIDrivers.EthernetIPforCLXCom(this.components);
            this.BindRecuperacao3 = new AdvancedHMIControls.BasicIndicator();
            this.BindRecuperacao2 = new AdvancedHMIControls.BasicIndicator();
            this.BindRecuperacao1 = new AdvancedHMIControls.BasicIndicator();
            this.basicIndicator1 = new AdvancedHMIControls.BasicIndicator();
            this.BindCorrenteAlta3 = new AdvancedHMIControls.BasicIndicator();
            this.BindCorrenteAlta2 = new AdvancedHMIControls.BasicIndicator();
            this.BindCorrenteAlta1 = new AdvancedHMIControls.BasicIndicator();
            this.BindFalhaDescargaCent3 = new AdvancedHMIControls.BasicIndicator();
            this.BindFalhaDescargaCent2 = new AdvancedHMIControls.BasicIndicator();
            this.BindFalhaDescargaCent1 = new AdvancedHMIControls.BasicIndicator();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLP_Past)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLP_Tinas)).BeginInit();
            this.SuspendLayout();
            // 
            // NotIcon
            // 
            this.NotIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotIcon.Icon")));
            this.NotIcon.Text = "X9App";
            this.NotIcon.Visible = true;
            this.NotIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotIcon_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Falha de Descarga da Centrifuga Pasteruziador 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Falha de Descarga da Centrifuga Pasteurizador 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Falha de Descarga da Centrifuga Pasteurizador 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Corrente Alta Centrifuga Pasteurizador 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Corrente Alta Centrifuga Pasteurizador 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Corrente Alta Centrifuga Pasteurizador 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Status PLC Pasteurizador";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Falha de Recuperação de rotação Centrifuga 3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Falha de Recuperação de rotação Centrifuga 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Falha de Recuperação de rotação Centrifuga 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(470, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Status PLC Tinas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(470, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Demora ao encher tinta 4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(470, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Demora ao encher tinta 3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(470, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Demora ao encher tinta 2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(470, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Demora ao encher tinta 1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(470, 341);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Demora ao aquecer tinta 4";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(470, 305);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Demora ao aquecer tinta 3";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(470, 269);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(133, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Demora ao aquecer tinta 2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(470, 233);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(133, 13);
            this.label19.TabIndex = 31;
            this.label19.Text = "Demora ao aquecer tinta 1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArquivoToolStripMenuItem,
            this.SobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1174, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ArquivoToolStripMenuItem
            // 
            this.ArquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TesteToolStripMenuItem});
            this.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem";
            this.ArquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ArquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // TesteToolStripMenuItem
            // 
            this.TesteToolStripMenuItem.Name = "TesteToolStripMenuItem";
            this.TesteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TesteToolStripMenuItem.Text = "Teste";
            this.TesteToolStripMenuItem.Click += new System.EventHandler(this.TesteToolStripMenuItem_Click);
            // 
            // SobreToolStripMenuItem
            // 
            this.SobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SobreToolStripMenuItem1});
            this.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem";
            this.SobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.SobreToolStripMenuItem.Text = "Sobre";
            // 
            // SobreToolStripMenuItem1
            // 
            this.SobreToolStripMenuItem1.Name = "SobreToolStripMenuItem1";
            this.SobreToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.SobreToolStripMenuItem1.Text = "Sobre";
            this.SobreToolStripMenuItem1.Click += new System.EventHandler(this.SobreToolStripMenuItem1_Click);
            // 
            // BindAquecertT4
            // 
            this.BindAquecertT4.Color1 = System.Drawing.Color.DarkGray;
            this.BindAquecertT4.Color2 = System.Drawing.Color.Green;
            this.BindAquecertT4.Color3 = System.Drawing.Color.Red;
            this.BindAquecertT4.ComComponent = this.CLP_Past;
            this.BindAquecertT4.Location = new System.Drawing.Point(434, 332);
            this.BindAquecertT4.Name = "BindAquecertT4";
            this.BindAquecertT4.OutlineColor = System.Drawing.Color.Transparent;
            this.BindAquecertT4.OutlineWidth = 1;
            this.BindAquecertT4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.BindAquecertT4.PLCAddressSelectColor2 = "TempoEnchimentoT4.DN";
            this.BindAquecertT4.SelectColor2 = true;
            this.BindAquecertT4.SelectColor3 = false;
            this.BindAquecertT4.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round;
            this.BindAquecertT4.Size = new System.Drawing.Size(30, 30);
            this.BindAquecertT4.SuppressErrorDisplay = true;
            this.BindAquecertT4.TabIndex = 36;
            // 
            // CLP_Past
            // 
            this.CLP_Past.CIPConnectionSize = 508;
            this.CLP_Past.DisableMultiServiceRequest = false;
            this.CLP_Past.DisableSubscriptions = false;
            this.CLP_Past.IniFileName = "";
            this.CLP_Past.IniFileSection = null;
            this.CLP_Past.IPAddress = "192.168.1.31";
            this.CLP_Past.PollRateOverride = 500;
            this.CLP_Past.Port = 44818;
            this.CLP_Past.ProcessorSlot = 0;
            this.CLP_Past.RoutePath = null;
            this.CLP_Past.Timeout = 4000;
            // 
            // BindAquecertT3
            // 
            this.BindAquecertT3.Color1 = System.Drawing.Color.DarkGray;
            this.BindAquecertT3.Color2 = System.Drawing.Color.Green;
            this.BindAquecertT3.Color3 = System.Drawing.Color.Red;
            this.BindAquecertT3.ComComponent = this.CLP_Past;
            this.BindAquecertT3.Location = new System.Drawing.Point(434, 296);
            this.BindAquecertT3.Name = "BindAquecertT3";
            this.BindAquecertT3.OutlineColor = System.Drawing.Color.Transparent;
            this.BindAquecertT3.OutlineWidth = 1;
            this.BindAquecertT3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.BindAquecertT3.PLCAddressSelectColor2 = "TempoEnchimentoT3.DN";
            this.BindAquecertT3.SelectColor2 = true;
            this.BindAquecertT3.SelectColor3 = false;
            this.BindAquecertT3.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round;
            this.BindAquecertT3.Size = new System.Drawing.Size(30, 30);
            this.BindAquecertT3.SuppressErrorDisplay = true;
            this.BindAquecertT3.TabIndex = 34;
            // 
            // BindAquecertT2
            // 
            this.BindAquecertT2.Color1 = System.Drawing.Color.DarkGray;
            this.BindAquecertT2.Color2 = System.Drawing.Color.Green;
            this.BindAquecertT2.Color3 = System.Drawing.Color.Red;
            this.BindAquecertT2.ComComponent = this.CLP_Past;
            this.BindAquecertT2.Location = new System.Drawing.Point(434, 260);
            this.BindAquecertT2.Name = "BindAquecertT2";
            this.BindAquecertT2.OutlineColor = System.Drawing.Color.Transparent;
            this.BindAquecertT2.OutlineWidth = 1;
            this.BindAquecertT2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.BindAquecertT2.PLCAddressSelectColor2 = "TempoEnchimentoT2.DN";
            this.BindAquecertT2.SelectColor2 = true;
            this.BindAquecertT2.SelectColor3 = false;
            this.BindAquecertT2.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round;
            this.BindAquecertT2.Size = new System.Drawing.Size(30, 30);
            this.BindAquecertT2.SuppressErrorDisplay = true;
            this.BindAquecertT2.TabIndex = 32;
            // 
            // BindAquecertT1
            // 
            this.BindAquecertT1.Color1 = System.Drawing.Color.DarkGray;
            this.BindAquecertT1.Color2 = System.Drawing.Color.Green;
            this.BindAquecertT1.Color3 = System.Drawing.Color.Red;
            this.BindAquecertT1.ComComponent = this.CLP_Past;
            this.BindAquecertT1.Location = new System.Drawing.Point(434, 224);
            this.BindAquecertT1.Name = "BindAquecertT1";
            this.BindAquecertT1.OutlineColor = System.Drawing.Color.Transparent;
            this.BindAquecertT1.OutlineWidth = 1;
            this.BindAquecertT1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.BindAquecertT1.PLCAddressSelectColor2 = "TempoEnchimentoT1.DN";
            this.BindAquecertT1.SelectColor2 = true;
            this.BindAquecertT1.SelectColor3 = false;
            this.BindAquecertT1.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round;
            this.BindAquecertT1.Size = new System.Drawing.Size(30, 30);
            this.BindAquecertT1.SuppressErrorDisplay = true;
            this.BindAquecertT1.TabIndex = 30;
            this.BindAquecertT1.ValueSelectColor2Changed += new System.EventHandler(this.BindAquecertT1_ValueSelectColor2Changed);
            // 
            // BindEncherT4
            // 
            this.BindEncherT4.Color1 = System.Drawing.Color.DarkGray;
            this.BindEncherT4.Color2 = System.Drawing.Color.Green;
            this.BindEncherT4.Color3 = System.Drawing.Color.Red;
            this.BindEncherT4.ComComponent = this.CLP_Past;
            this.BindEncherT4.Location = new System.Drawing.Point(434, 188);
            this.BindEncherT4.Name = "BindEncherT4";
            this.BindEncherT4.OutlineColor = System.Drawing.Color.Transparent;
            this.BindEncherT4.OutlineWidth = 1;
            this.BindEncherT4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.BindEncherT4.PLCAddressSelectColor2 = "TempoEnchimentoT4.DN";
            this.BindEncherT4.SelectColor2 = true;
            this.BindEncherT4.SelectColor3 = false;
            this.BindEncherT4.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round;
            this.BindEncherT4.Size = new System.Drawing.Size(30, 30);
            this.BindEncherT4.SuppressErrorDisplay = true;
            this.BindEncherT4.TabIndex = 28;
            this.BindEncherT4.ValueSelectColor2Changed += new System.EventHandler(this.BindEncherT4_ValueSelectColor2Changed);
            // 
            // BindEncherT3
            // 
            this.BindEncherT3.Color1 = System.Drawing.Color.DarkGray;
            this.BindEncherT3.Color2 = System.Drawing.Color.Green;
            this.BindEncherT3.Color3 = System.Drawing.Color.Red;
            this.BindEncherT3.ComComponent = this.CLP_Past;
            this.BindEncherT3.Location = new System.Drawing.Point(434, 152);
            this.BindEncherT3.Name = "BindEncherT3";
            this.BindEncherT3.OutlineColor = System.Drawing.Color.Transparent;
            this.BindEncherT3.OutlineWidth = 1;
            this.BindEncherT3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.BindEncherT3.PLCAddressSelectColor2 = "TempoEnchimentoT3.DN";
            this.BindEncherT3.SelectColor2 = true;
            this.BindEncherT3.SelectColor3 = false;
            this.BindEncherT3.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round;
            this.BindEncherT3.Size = new System.Drawing.Size(30, 30);
            this.BindEncherT3.SuppressErrorDisplay = true;
            this.BindEncherT3.TabIndex = 26;
            this.BindEncherT3.ValueSelectColor2Changed += new System.EventHandler(this.BindEncherT3_ValueSelectColor2Changed);
            // 
            // BindEncherT2
            // 
            this.BindEncherT2.Color1 = System.Drawing.Color.DarkGray;
            this.BindEncherT2.Color2 = System.Drawing.Color.Green;
            this.BindEncherT2.Color3 = System.Drawing.Color.Red;
            this.BindEncherT2.ComComponent = this.CLP_Past;
            this.BindEncherT2.Location = new System.Drawing.Point(434, 116);
            this.BindEncherT2.Name = "BindEncherT2";
            this.BindEncherT2.OutlineColor = System.Drawing.Color.Transparent;
            this.BindEncherT2.OutlineWidth = 1;
            this.BindEncherT2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.BindEncherT2.PLCAddressSelectColor2 = "TempoEnchimentoT2.DN";
            this.BindEncherT2.SelectColor2 = true;
            this.BindEncherT2.SelectColor3 = false;
            this.BindEncherT2.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round;
            this.BindEncherT2.Size = new System.Drawing.Size(30, 30);
            this.BindEncherT2.SuppressErrorDisplay = true;
            this.BindEncherT2.TabIndex = 24;
            this.BindEncherT2.ValueSelectColor2Changed += new System.EventHandler(this.BindEncherT2_ValueSelectColor2Changed);
            // 
            // BindEncherT1
            // 
            this.BindEncherT1.Color1 = System.Drawing.Color.DarkGray;
            this.BindEncherT1.Color2 = System.Drawing.Color.Green;
            this.BindEncherT1.Color3 = System.Drawing.Color.Red;
            this.BindEncherT1.ComComponent = this.CLP_Past;
            this.BindEncherT1.Location = new System.Drawing.Point(434, 80);
            this.BindEncherT1.Name = "BindEncherT1";
            this.BindEncherT1.OutlineColor = System.Drawing.Color.Transparent;
            this.BindEncherT1.OutlineWidth = 1;
            this.BindEncherT1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.BindEncherT1.PLCAddressSelectColor2 = "TempoEnchimentoT1.DN";
            this.BindEncherT1.SelectColor2 = true;
            this.BindEncherT1.SelectColor3 = false;
            this.BindEncherT1.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round;
            this.BindEncherT1.Size = new System.Drawing.Size(30, 30);
            this.BindEncherT1.SuppressErrorDisplay = true;
            this.BindEncherT1.TabIndex = 22;
            this.BindEncherT1.ValueSelectColor2Changed += new System.EventHandler(this.BindEncherT1_ValueSelectColor2Changed);
            // 
            // BindStatusPLCtinas
            // 
            this.BindStatusPLCtinas.Color1 = System.Drawing.Color.DarkGray;
            this.BindStatusPLCtinas.Color2 = System.Drawing.Color.Green;
            this.BindStatusPLCtinas.Color3 = System.Drawing.Color.Red;
            this.BindStatusPLCtinas.ComComponent = this.CLP_Tinas;
            this.BindStatusPLCtinas.Location = new System.Drawing.Point(434, 44);
            this.BindStatusPLCtinas.Name = "BindStatusPLCtinas";
            this.BindStatusPLCtinas.OutlineColor = System.Drawing.Color.Transparent;
            this.BindStatusPLCtinas.OutlineWidth = 1;
            this.BindStatusPLCtinas.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.BindStatusPLCtinas.PLCAddressSelectColor2 = "Status_PLC3.DN";
            this.BindStatusPLCtinas.SelectColor2 = true;
            this.BindStatusPLCtinas.SelectColor3 = false;
            this.BindStatusPLCtinas.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round;
            this.BindStatusPLCtinas.Size = new System.Drawing.Size(30, 30);
            this.BindStatusPLCtinas.SuppressErrorDisplay = true;
            this.BindStatusPLCtinas.TabIndex = 20;
            // 
            // CLP_Tinas
            // 
            this.CLP_Tinas.CIPConnectionSize = 508;
            this.CLP_Tinas.DisableMultiServiceRequest = false;
            this.CLP_Tinas.DisableSubscriptions = false;
            this.CLP_Tinas.IniFileName = "";
            this.CLP_Tinas.IniFileSection = null;
            this.CLP_Tinas.IPAddress = "192.168.1.12";
            this.CLP_Tinas.PollRateOverride = 500;
            this.CLP_Tinas.Port = 44818;
            this.CLP_Tinas.ProcessorSlot = 0;
            this.CLP_Tinas.RoutePath = null;
            this.CLP_Tinas.Timeout = 4000;
            // 
            // BindRecuperacao3
            // 
            this.BindRecuperacao3.Color1 = System.Drawing.Color.DarkGray;
            this.BindRecuperacao3.Color2 = System.Drawing.Color.Green;
            this.BindRecuperacao3.Color3 = System.Drawing.Color.Red;
            this.BindRecuperacao3.ComComponent = this.CLP_Past;
            this.BindRecuperacao3.Location = new System.Drawing.Point(12, 368);
            this.BindRecuperacao3.Name = "BindRecuperacao3";
            this.BindRecuperacao3.OutlineColor = System.Drawing.Color.Transparent;
            this.BindRecuperacao3.OutlineWidth = 1;
            this.BindRecuperacao3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.BindRecuperacao3.PLCAddressSelectColor2 = "CENT3.Falha_Descarga";
            this.BindRecuperacao3.SelectColor2 = true;
            this.BindRecuperacao3.SelectColor3 = false;
            this.BindRecuperacao3.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round;
            this.BindRecuperacao3.Size = new System.Drawing.Size(30, 30);
            this.BindRecuperacao3.SuppressErrorDisplay = true;
            this.BindRecuperacao3.TabIndex = 18;
            this.BindRecuperacao3.ValueSelectColor2Changed += new System.EventHandler(this.BindRecuperacao3_ValueSelectColor2Changed);
            // 
            // BindRecuperacao2
            // 
            this.BindRecuperacao2.Color1 = System.Drawing.Color.DarkGray;
            this.BindRecuperacao2.Color2 = System.Drawing.Color.Green;
            this.BindRecuperacao2.Color3 = System.Drawing.Color.Red;
            this.BindRecuperacao2.ComComponent = this.CLP_Past;
            this.BindRecuperacao2.Location = new System.Drawing.Point(12, 332);
            this.BindRecuperacao2.Name = "BindRecuperacao2";
            this.BindRecuperacao2.OutlineColor = System.Drawing.Color.Transparent;
            this.BindRecuperacao2.OutlineWidth = 1;
            this.BindRecuperacao2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.BindRecuperacao2.PLCAddressSelectColor2 = "CENT3.Falha_Descarga";
            this.BindRecuperacao2.SelectColor2 = true;
            this.BindRecuperacao2.SelectColor3 = false;
            this.BindRecuperacao2.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round;
            this.BindRecuperacao2.Size = new System.Drawing.Size(30, 30);
            this.BindRecuperacao2.SuppressErrorDisplay = true;
            this.BindRecuperacao2.TabIndex = 16;
            this.BindRecuperacao2.ValueSelectColor2Changed += new System.EventHandler(this.BindRecuperacao2_ValueSelectColor2Changed);
            // 
            // BindRecuperacao1
            // 
            this.BindRecuperacao1.Color1 = System.Drawing.Color.DarkGray;
            this.BindRecuperacao1.Color2 = System.Drawing.Color.Green;
            this.BindRecuperacao1.Color3 = System.Drawing.Color.Red;
            this.BindRecuperacao1.ComComponent = this.CLP_Past;
            this.BindRecuperacao1.Location = new System.Drawing.Point(12, 296);
            this.BindRecuperacao1.Name = "BindRecuperacao1";
            this.BindRecuperacao1.OutlineColor = System.Drawing.Color.Transparent;
            this.BindRecuperacao1.OutlineWidth = 1;
            this.BindRecuperacao1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.BindRecuperacao1.PLCAddressSelectColor2 = "CENT1.Falha_IAH";
            this.BindRecuperacao1.SelectColor2 = true;
            this.BindRecuperacao1.SelectColor3 = false;
            this.BindRecuperacao1.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round;
            this.BindRecuperacao1.Size = new System.Drawing.Size(30, 30);
            this.BindRecuperacao1.SuppressErrorDisplay = true;
            this.BindRecuperacao1.TabIndex = 14;
            this.BindRecuperacao1.ValueSelectColor2Changed += new System.EventHandler(this.BindRecuperacao1_ValueSelectColor2Changed);
            // 
            // basicIndicator1
            // 
            this.basicIndicator1.Color1 = System.Drawing.Color.DarkGray;
            this.basicIndicator1.Color2 = System.Drawing.Color.Green;
            this.basicIndicator1.Color3 = System.Drawing.Color.Red;
            this.basicIndicator1.ComComponent = this.CLP_Past;
            this.basicIndicator1.Location = new System.Drawing.Point(12, 44);
            this.basicIndicator1.Name = "basicIndicator1";
            this.basicIndicator1.OutlineColor = System.Drawing.Color.Transparent;
            this.basicIndicator1.OutlineWidth = 1;
            this.basicIndicator1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.basicIndicator1.PLCAddressSelectColor2 = "PulseBit.DN";
            this.basicIndicator1.SelectColor2 = true;
            this.basicIndicator1.SelectColor3 = false;
            this.basicIndicator1.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round;
            this.basicIndicator1.Size = new System.Drawing.Size(30, 30);
            this.basicIndicator1.SuppressErrorDisplay = true;
            this.basicIndicator1.TabIndex = 12;
            // 
            // BindCorrenteAlta3
            // 
            this.BindCorrenteAlta3.Color1 = System.Drawing.Color.DarkGray;
            this.BindCorrenteAlta3.Color2 = System.Drawing.Color.Green;
            this.BindCorrenteAlta3.Color3 = System.Drawing.Color.Red;
            this.BindCorrenteAlta3.ComComponent = this.CLP_Past;
            this.BindCorrenteAlta3.Location = new System.Drawing.Point(12, 260);
            this.BindCorrenteAlta3.Name = "BindCorrenteAlta3";
            this.BindCorrenteAlta3.OutlineColor = System.Drawing.Color.Transparent;
            this.BindCorrenteAlta3.OutlineWidth = 1;
            this.BindCorrenteAlta3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.BindCorrenteAlta3.PLCAddressSelectColor2 = "CENT3.Falha_Descarga";
            this.BindCorrenteAlta3.SelectColor2 = true;
            this.BindCorrenteAlta3.SelectColor3 = false;
            this.BindCorrenteAlta3.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round;
            this.BindCorrenteAlta3.Size = new System.Drawing.Size(30, 30);
            this.BindCorrenteAlta3.SuppressErrorDisplay = true;
            this.BindCorrenteAlta3.TabIndex = 10;
            this.BindCorrenteAlta3.ValueSelectColor2Changed += new System.EventHandler(this.BindCorrenteAlta3_ValueSelectColor2Changed);
            // 
            // BindCorrenteAlta2
            // 
            this.BindCorrenteAlta2.Color1 = System.Drawing.Color.DarkGray;
            this.BindCorrenteAlta2.Color2 = System.Drawing.Color.Green;
            this.BindCorrenteAlta2.Color3 = System.Drawing.Color.Red;
            this.BindCorrenteAlta2.ComComponent = this.CLP_Past;
            this.BindCorrenteAlta2.Location = new System.Drawing.Point(12, 224);
            this.BindCorrenteAlta2.Name = "BindCorrenteAlta2";
            this.BindCorrenteAlta2.OutlineColor = System.Drawing.Color.Transparent;
            this.BindCorrenteAlta2.OutlineWidth = 1;
            this.BindCorrenteAlta2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.BindCorrenteAlta2.PLCAddressSelectColor2 = "CENT3.Falha_Descarga";
            this.BindCorrenteAlta2.SelectColor2 = true;
            this.BindCorrenteAlta2.SelectColor3 = false;
            this.BindCorrenteAlta2.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round;
            this.BindCorrenteAlta2.Size = new System.Drawing.Size(30, 30);
            this.BindCorrenteAlta2.SuppressErrorDisplay = true;
            this.BindCorrenteAlta2.TabIndex = 8;
            this.BindCorrenteAlta2.ValueSelectColor2Changed += new System.EventHandler(this.BindCorrenteAlta2_ValueSelectColor2Changed);
            // 
            // BindCorrenteAlta1
            // 
            this.BindCorrenteAlta1.Color1 = System.Drawing.Color.DarkGray;
            this.BindCorrenteAlta1.Color2 = System.Drawing.Color.Green;
            this.BindCorrenteAlta1.Color3 = System.Drawing.Color.Red;
            this.BindCorrenteAlta1.ComComponent = this.CLP_Past;
            this.BindCorrenteAlta1.Location = new System.Drawing.Point(12, 188);
            this.BindCorrenteAlta1.Name = "BindCorrenteAlta1";
            this.BindCorrenteAlta1.OutlineColor = System.Drawing.Color.Transparent;
            this.BindCorrenteAlta1.OutlineWidth = 1;
            this.BindCorrenteAlta1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.BindCorrenteAlta1.PLCAddressSelectColor2 = "CENT1.Falha_IAH";
            this.BindCorrenteAlta1.SelectColor2 = true;
            this.BindCorrenteAlta1.SelectColor3 = false;
            this.BindCorrenteAlta1.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round;
            this.BindCorrenteAlta1.Size = new System.Drawing.Size(30, 30);
            this.BindCorrenteAlta1.SuppressErrorDisplay = true;
            this.BindCorrenteAlta1.TabIndex = 6;
            this.BindCorrenteAlta1.ValueSelectColor2Changed += new System.EventHandler(this.BindCorrenteAlta1_ValueSelectColor2Changed);
            // 
            // BindFalhaDescargaCent3
            // 
            this.BindFalhaDescargaCent3.Color1 = System.Drawing.Color.DarkGray;
            this.BindFalhaDescargaCent3.Color2 = System.Drawing.Color.Green;
            this.BindFalhaDescargaCent3.Color3 = System.Drawing.Color.Red;
            this.BindFalhaDescargaCent3.ComComponent = this.CLP_Past;
            this.BindFalhaDescargaCent3.Location = new System.Drawing.Point(12, 152);
            this.BindFalhaDescargaCent3.Name = "BindFalhaDescargaCent3";
            this.BindFalhaDescargaCent3.OutlineColor = System.Drawing.Color.Transparent;
            this.BindFalhaDescargaCent3.OutlineWidth = 1;
            this.BindFalhaDescargaCent3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.BindFalhaDescargaCent3.PLCAddressSelectColor2 = "CENT3.Falha_Descarga";
            this.BindFalhaDescargaCent3.SelectColor2 = true;
            this.BindFalhaDescargaCent3.SelectColor3 = false;
            this.BindFalhaDescargaCent3.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round;
            this.BindFalhaDescargaCent3.Size = new System.Drawing.Size(30, 30);
            this.BindFalhaDescargaCent3.SuppressErrorDisplay = true;
            this.BindFalhaDescargaCent3.TabIndex = 4;
            this.BindFalhaDescargaCent3.ValueSelectColor2Changed += new System.EventHandler(this.BindFalhaDescargaCent3_ValueSelectColor2Changed);
            // 
            // BindFalhaDescargaCent2
            // 
            this.BindFalhaDescargaCent2.Color1 = System.Drawing.Color.DarkGray;
            this.BindFalhaDescargaCent2.Color2 = System.Drawing.Color.Green;
            this.BindFalhaDescargaCent2.Color3 = System.Drawing.Color.Red;
            this.BindFalhaDescargaCent2.ComComponent = this.CLP_Past;
            this.BindFalhaDescargaCent2.Location = new System.Drawing.Point(12, 116);
            this.BindFalhaDescargaCent2.Name = "BindFalhaDescargaCent2";
            this.BindFalhaDescargaCent2.OutlineColor = System.Drawing.Color.Transparent;
            this.BindFalhaDescargaCent2.OutlineWidth = 1;
            this.BindFalhaDescargaCent2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.BindFalhaDescargaCent2.PLCAddressSelectColor2 = "CENT2.Falha_Descarga";
            this.BindFalhaDescargaCent2.SelectColor2 = true;
            this.BindFalhaDescargaCent2.SelectColor3 = false;
            this.BindFalhaDescargaCent2.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round;
            this.BindFalhaDescargaCent2.Size = new System.Drawing.Size(30, 30);
            this.BindFalhaDescargaCent2.SuppressErrorDisplay = true;
            this.BindFalhaDescargaCent2.TabIndex = 2;
            this.BindFalhaDescargaCent2.ValueSelectColor2Changed += new System.EventHandler(this.BindFalhaDescargaCent2_ValueSelectColor2Changed);
            // 
            // BindFalhaDescargaCent1
            // 
            this.BindFalhaDescargaCent1.Color1 = System.Drawing.Color.DarkGray;
            this.BindFalhaDescargaCent1.Color2 = System.Drawing.Color.Green;
            this.BindFalhaDescargaCent1.Color3 = System.Drawing.Color.Red;
            this.BindFalhaDescargaCent1.ComComponent = this.CLP_Past;
            this.BindFalhaDescargaCent1.Location = new System.Drawing.Point(12, 80);
            this.BindFalhaDescargaCent1.Name = "BindFalhaDescargaCent1";
            this.BindFalhaDescargaCent1.OutlineColor = System.Drawing.Color.Transparent;
            this.BindFalhaDescargaCent1.OutlineWidth = 1;
            this.BindFalhaDescargaCent1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.BindFalhaDescargaCent1.PLCAddressSelectColor2 = "CENT1.Falha_Descarga";
            this.BindFalhaDescargaCent1.SelectColor2 = true;
            this.BindFalhaDescargaCent1.SelectColor3 = false;
            this.BindFalhaDescargaCent1.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round;
            this.BindFalhaDescargaCent1.Size = new System.Drawing.Size(30, 30);
            this.BindFalhaDescargaCent1.SuppressErrorDisplay = true;
            this.BindFalhaDescargaCent1.TabIndex = 0;
            this.BindFalhaDescargaCent1.ValueSelectColor2Changed += new System.EventHandler(this.BindFalhaDescargaCent1_ValueSelectColor2Changed);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 616);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.BindAquecertT4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.BindAquecertT3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.BindAquecertT2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.BindAquecertT1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BindEncherT4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BindEncherT3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BindEncherT2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.BindEncherT1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BindStatusPLCtinas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BindRecuperacao3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BindRecuperacao2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BindRecuperacao1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.basicIndicator1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BindCorrenteAlta3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BindCorrenteAlta2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BindCorrenteAlta1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BindFalhaDescargaCent3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BindFalhaDescargaCent2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BindFalhaDescargaCent1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.ShowInTaskbar = false;
            this.Text = "X9app";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLP_Past)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLP_Tinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.NotifyIcon NotIcon;
        public AdvancedHMIDrivers.EthernetIPforCLXCom CLP_Past;
        private AdvancedHMIControls.BasicIndicator BindFalhaDescargaCent1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private AdvancedHMIControls.BasicIndicator BindFalhaDescargaCent2;
        private System.Windows.Forms.Label label3;
        private AdvancedHMIControls.BasicIndicator BindFalhaDescargaCent3;
        private System.Windows.Forms.Label label4;
        private AdvancedHMIControls.BasicIndicator BindCorrenteAlta1;
        private System.Windows.Forms.Label label5;
        private AdvancedHMIControls.BasicIndicator BindCorrenteAlta2;
        private System.Windows.Forms.Label label6;
        private AdvancedHMIControls.BasicIndicator BindCorrenteAlta3;
        private AdvancedHMIControls.BasicIndicator basicIndicator1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private AdvancedHMIControls.BasicIndicator BindRecuperacao3;
        private System.Windows.Forms.Label label9;
        private AdvancedHMIControls.BasicIndicator BindRecuperacao2;
        private System.Windows.Forms.Label label10;
        private AdvancedHMIControls.BasicIndicator BindRecuperacao1;
        private System.Windows.Forms.Label label11;
        private AdvancedHMIControls.BasicIndicator BindStatusPLCtinas;
        public AdvancedHMIDrivers.EthernetIPforCLXCom CLP_Tinas;
        private System.Windows.Forms.Label label12;
        private AdvancedHMIControls.BasicIndicator BindEncherT4;
        private System.Windows.Forms.Label label13;
        private AdvancedHMIControls.BasicIndicator BindEncherT3;
        private System.Windows.Forms.Label label14;
        private AdvancedHMIControls.BasicIndicator BindEncherT2;
        private System.Windows.Forms.Label label15;
        private AdvancedHMIControls.BasicIndicator BindEncherT1;
        private System.Windows.Forms.Label label16;
        private AdvancedHMIControls.BasicIndicator BindAquecertT4;
        private System.Windows.Forms.Label label17;
        private AdvancedHMIControls.BasicIndicator BindAquecertT3;
        private System.Windows.Forms.Label label18;
        private AdvancedHMIControls.BasicIndicator BindAquecertT2;
        private System.Windows.Forms.Label label19;
        private AdvancedHMIControls.BasicIndicator BindAquecertT1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TesteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SobreToolStripMenuItem1;
    }
}