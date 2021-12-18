
using System;
using System.IO;

namespace Kalkulacka {
    partial class HlavniFormular {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HlavniFormular));
            this.labelCenaSDPH = new System.Windows.Forms.Label();
            this.labelCenaStred = new System.Windows.Forms.Label();
            this.labelCenaBezDPH = new System.Windows.Forms.Label();
            this.labelCenaM3 = new System.Windows.Forms.Label();
            this.labelTitulekM3 = new System.Windows.Forms.Label();
            this.labelKusy = new System.Windows.Forms.Label();
            this.labelDelka = new System.Windows.Forms.Label();
            this.labelSirka = new System.Windows.Forms.Label();
            this.labelTloustka = new System.Windows.Forms.Label();
            this.labelTextPalubkyM = new System.Windows.Forms.Label();
            this.labelPalubkyM2 = new System.Windows.Forms.Label();
            this.labelCenaM2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMeziTretiDPH = new System.Windows.Forms.Label();
            this.labelTretiCenaDPH = new System.Windows.Forms.Label();
            this.labelMeziTretiStred = new System.Windows.Forms.Label();
            this.labelTretiCenaStred = new System.Windows.Forms.Label();
            this.labelMeziTretiBezDPH = new System.Windows.Forms.Label();
            this.labelTretiCenaBezDPH = new System.Windows.Forms.Label();
            this.labelMeziTretiM3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.labelMeziTretiKcM3 = new System.Windows.Forms.Label();
            this.labelTretiKcM3 = new System.Windows.Forms.Label();
            this.labelMeziDruhaDPH = new System.Windows.Forms.Label();
            this.labelDruhaCenaDPH = new System.Windows.Forms.Label();
            this.labelMeziDruhaStred = new System.Windows.Forms.Label();
            this.labelDruhaCenaStred = new System.Windows.Forms.Label();
            this.labelMeziDruhaBezDPH = new System.Windows.Forms.Label();
            this.labelDruhaCenaBezDPH = new System.Windows.Forms.Label();
            this.labelMeziDruhaM3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelMeziDruhaKcM3 = new System.Windows.Forms.Label();
            this.labelDruhaKcM3 = new System.Windows.Forms.Label();
            this.labelMeziPrvniDPH = new System.Windows.Forms.Label();
            this.labelPrvniCenaDPH = new System.Windows.Forms.Label();
            this.labelMeziPrvniStred = new System.Windows.Forms.Label();
            this.labelPrvniCenaStred = new System.Windows.Forms.Label();
            this.labelMeziPrvniBezDPH = new System.Windows.Forms.Label();
            this.labelPrvniCenaBezDPH = new System.Windows.Forms.Label();
            this.labelMeziPrvniM3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelMeziPrvniKc = new System.Windows.Forms.Label();
            this.labelPrvniKcM3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelCenaCelkemDPH = new System.Windows.Forms.Label();
            this.labelCenaCelkemStred = new System.Windows.Forms.Label();
            this.labelCenaCelkem = new System.Windows.Forms.Label();
            this.labelCelkovaCenaDPH = new System.Windows.Forms.Label();
            this.labelCelkovaCenaStred = new System.Windows.Forms.Label();
            this.labelCelkovaCenaBezDPH = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonTisk = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.labelPalubkyM = new System.Windows.Forms.Label();
            this.buttonNapoveda = new System.Windows.Forms.Button();
            this.timerHodiny = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonNacist = new System.Windows.Forms.Button();
            this.buttonUlozit = new System.Windows.Forms.Button();
            this.buttonKonec = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelDatumACas = new System.Windows.Forms.Label();
            this.toolTipReset = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxSkryt = new System.Windows.Forms.CheckBox();
            this.toolTipOstatní = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipUlozit = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxZkopirovat = new System.Windows.Forms.CheckBox();
            this.toolTipNacist = new System.Windows.Forms.ToolTip(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCenaSDPH
            // 
            this.labelCenaSDPH.AutoSize = true;
            this.labelCenaSDPH.Location = new System.Drawing.Point(724, 131);
            this.labelCenaSDPH.Name = "labelCenaSDPH";
            this.labelCenaSDPH.Size = new System.Drawing.Size(66, 13);
            this.labelCenaSDPH.TabIndex = 71;
            this.labelCenaSDPH.Text = "Cena s DPH";
            // 
            // labelCenaStred
            // 
            this.labelCenaStred.AutoSize = true;
            this.labelCenaStred.Location = new System.Drawing.Point(634, 131);
            this.labelCenaStred.Name = "labelCenaStred";
            this.labelCenaStred.Size = new System.Drawing.Size(59, 13);
            this.labelCenaStred.TabIndex = 70;
            this.labelCenaStred.Text = "Cena střed";
            // 
            // labelCenaBezDPH
            // 
            this.labelCenaBezDPH.AutoSize = true;
            this.labelCenaBezDPH.Location = new System.Drawing.Point(530, 131);
            this.labelCenaBezDPH.Name = "labelCenaBezDPH";
            this.labelCenaBezDPH.Size = new System.Drawing.Size(78, 13);
            this.labelCenaBezDPH.TabIndex = 69;
            this.labelCenaBezDPH.Text = "Cena bez DPH";
            // 
            // labelCenaM3
            // 
            this.labelCenaM3.AutoSize = true;
            this.labelCenaM3.Location = new System.Drawing.Point(440, 131);
            this.labelCenaM3.Name = "labelCenaM3";
            this.labelCenaM3.Size = new System.Drawing.Size(36, 13);
            this.labelCenaM3.TabIndex = 68;
            this.labelCenaM3.Text = "Kč/m³";
            // 
            // labelTitulekM3
            // 
            this.labelTitulekM3.AutoSize = true;
            this.labelTitulekM3.Location = new System.Drawing.Point(352, 131);
            this.labelTitulekM3.Name = "labelTitulekM3";
            this.labelTitulekM3.Size = new System.Drawing.Size(63, 13);
            this.labelTitulekM3.TabIndex = 67;
            this.labelTitulekM3.Text = "Objem [ m³ ]";
            // 
            // labelKusy
            // 
            this.labelKusy.AutoSize = true;
            this.labelKusy.Location = new System.Drawing.Point(281, 131);
            this.labelKusy.Name = "labelKusy";
            this.labelKusy.Size = new System.Drawing.Size(55, 13);
            this.labelKusy.TabIndex = 66;
            this.labelKusy.Text = "Počet [ks]";
            // 
            // labelDelka
            // 
            this.labelDelka.AutoSize = true;
            this.labelDelka.Location = new System.Drawing.Point(215, 131);
            this.labelDelka.Name = "labelDelka";
            this.labelDelka.Size = new System.Drawing.Size(52, 13);
            this.labelDelka.TabIndex = 65;
            this.labelDelka.Text = "Délka [m]";
            // 
            // labelSirka
            // 
            this.labelSirka.AutoSize = true;
            this.labelSirka.Location = new System.Drawing.Point(147, 131);
            this.labelSirka.Name = "labelSirka";
            this.labelSirka.Size = new System.Drawing.Size(57, 13);
            this.labelSirka.TabIndex = 64;
            this.labelSirka.Text = "Šířka [cm]";
            // 
            // labelTloustka
            // 
            this.labelTloustka.AutoSize = true;
            this.labelTloustka.Location = new System.Drawing.Point(69, 131);
            this.labelTloustka.Name = "labelTloustka";
            this.labelTloustka.Size = new System.Drawing.Size(72, 13);
            this.labelTloustka.TabIndex = 63;
            this.labelTloustka.Text = "Tloušťka [cm]";
            // 
            // labelTextPalubkyM
            // 
            this.labelTextPalubkyM.AutoSize = true;
            this.labelTextPalubkyM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelTextPalubkyM.Location = new System.Drawing.Point(145, 112);
            this.labelTextPalubkyM.Name = "labelTextPalubkyM";
            this.labelTextPalubkyM.Size = new System.Drawing.Size(62, 13);
            this.labelTextPalubkyM.TabIndex = 81;
            this.labelTextPalubkyM.Text = "Palubky [m]";
            // 
            // labelPalubkyM2
            // 
            this.labelPalubkyM2.AutoSize = true;
            this.labelPalubkyM2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelPalubkyM2.Location = new System.Drawing.Point(348, 112);
            this.labelPalubkyM2.Name = "labelPalubkyM2";
            this.labelPalubkyM2.Size = new System.Drawing.Size(71, 13);
            this.labelPalubkyM2.TabIndex = 82;
            this.labelPalubkyM2.Text = "Palubky [ m² ]";
            // 
            // labelCenaM2
            // 
            this.labelCenaM2.AutoSize = true;
            this.labelCenaM2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelCenaM2.Location = new System.Drawing.Point(440, 112);
            this.labelCenaM2.Name = "labelCenaM2";
            this.labelCenaM2.Size = new System.Drawing.Size(36, 13);
            this.labelCenaM2.TabIndex = 83;
            this.labelCenaM2.Text = "Kč/m²";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMeziTretiDPH);
            this.groupBox1.Controls.Add(this.labelTretiCenaDPH);
            this.groupBox1.Controls.Add(this.labelMeziTretiStred);
            this.groupBox1.Controls.Add(this.labelTretiCenaStred);
            this.groupBox1.Controls.Add(this.labelMeziTretiBezDPH);
            this.groupBox1.Controls.Add(this.labelTretiCenaBezDPH);
            this.groupBox1.Controls.Add(this.labelMeziTretiM3);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.labelMeziTretiKcM3);
            this.groupBox1.Controls.Add(this.labelTretiKcM3);
            this.groupBox1.Controls.Add(this.labelMeziDruhaDPH);
            this.groupBox1.Controls.Add(this.labelDruhaCenaDPH);
            this.groupBox1.Controls.Add(this.labelMeziDruhaStred);
            this.groupBox1.Controls.Add(this.labelDruhaCenaStred);
            this.groupBox1.Controls.Add(this.labelMeziDruhaBezDPH);
            this.groupBox1.Controls.Add(this.labelDruhaCenaBezDPH);
            this.groupBox1.Controls.Add(this.labelMeziDruhaM3);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.labelMeziDruhaKcM3);
            this.groupBox1.Controls.Add(this.labelDruhaKcM3);
            this.groupBox1.Controls.Add(this.labelMeziPrvniDPH);
            this.groupBox1.Controls.Add(this.labelPrvniCenaDPH);
            this.groupBox1.Controls.Add(this.labelMeziPrvniStred);
            this.groupBox1.Controls.Add(this.labelPrvniCenaStred);
            this.groupBox1.Controls.Add(this.labelMeziPrvniBezDPH);
            this.groupBox1.Controls.Add(this.labelPrvniCenaBezDPH);
            this.groupBox1.Controls.Add(this.labelMeziPrvniM3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.labelMeziPrvniKc);
            this.groupBox1.Controls.Add(this.labelPrvniKcM3);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 84);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mezisoučty rozdělené podle opakujících se Kč/m³  [ palubky Kč/m² ]";
            // 
            // labelMeziTretiDPH
            // 
            this.labelMeziTretiDPH.Location = new System.Drawing.Point(418, 60);
            this.labelMeziTretiDPH.Name = "labelMeziTretiDPH";
            this.labelMeziTretiDPH.Size = new System.Drawing.Size(62, 13);
            this.labelMeziTretiDPH.TabIndex = 33;
            this.labelMeziTretiDPH.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTretiCenaDPH
            // 
            this.labelTretiCenaDPH.AutoSize = true;
            this.labelTretiCenaDPH.Location = new System.Drawing.Point(382, 60);
            this.labelTretiCenaDPH.Name = "labelTretiCenaDPH";
            this.labelTretiCenaDPH.Size = new System.Drawing.Size(41, 13);
            this.labelTretiCenaDPH.TabIndex = 32;
            this.labelTretiCenaDPH.Text = "s DPH:";
            this.labelTretiCenaDPH.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMeziTretiStred
            // 
            this.labelMeziTretiStred.Location = new System.Drawing.Point(318, 60);
            this.labelMeziTretiStred.Name = "labelMeziTretiStred";
            this.labelMeziTretiStred.Size = new System.Drawing.Size(62, 13);
            this.labelMeziTretiStred.TabIndex = 31;
            this.labelMeziTretiStred.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTretiCenaStred
            // 
            this.labelTretiCenaStred.AutoSize = true;
            this.labelTretiCenaStred.Location = new System.Drawing.Point(288, 60);
            this.labelTretiCenaStred.Name = "labelTretiCenaStred";
            this.labelTretiCenaStred.Size = new System.Drawing.Size(34, 13);
            this.labelTretiCenaStred.TabIndex = 30;
            this.labelTretiCenaStred.Text = "střed:";
            this.labelTretiCenaStred.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMeziTretiBezDPH
            // 
            this.labelMeziTretiBezDPH.Location = new System.Drawing.Point(225, 60);
            this.labelMeziTretiBezDPH.Name = "labelMeziTretiBezDPH";
            this.labelMeziTretiBezDPH.Size = new System.Drawing.Size(62, 13);
            this.labelMeziTretiBezDPH.TabIndex = 29;
            this.labelMeziTretiBezDPH.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTretiCenaBezDPH
            // 
            this.labelTretiCenaBezDPH.AutoSize = true;
            this.labelTretiCenaBezDPH.Location = new System.Drawing.Point(149, 60);
            this.labelTretiCenaBezDPH.Name = "labelTretiCenaBezDPH";
            this.labelTretiCenaBezDPH.Size = new System.Drawing.Size(81, 13);
            this.labelTretiCenaBezDPH.TabIndex = 28;
            this.labelTretiCenaBezDPH.Text = "Cena bez DPH:";
            // 
            // labelMeziTretiM3
            // 
            this.labelMeziTretiM3.Location = new System.Drawing.Point(107, 60);
            this.labelMeziTretiM3.Name = "labelMeziTretiM3";
            this.labelMeziTretiM3.Size = new System.Drawing.Size(40, 13);
            this.labelMeziTretiM3.TabIndex = 27;
            this.labelMeziTretiM3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(86, 60);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 13);
            this.label22.TabIndex = 26;
            this.label22.Text = "m³ :";
            // 
            // labelMeziTretiKcM3
            // 
            this.labelMeziTretiKcM3.Location = new System.Drawing.Point(45, 60);
            this.labelMeziTretiKcM3.Name = "labelMeziTretiKcM3";
            this.labelMeziTretiKcM3.Size = new System.Drawing.Size(40, 13);
            this.labelMeziTretiKcM3.TabIndex = 25;
            this.labelMeziTretiKcM3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTretiKcM3
            // 
            this.labelTretiKcM3.AutoSize = true;
            this.labelTretiKcM3.Location = new System.Drawing.Point(6, 60);
            this.labelTretiKcM3.Name = "labelTretiKcM3";
            this.labelTretiKcM3.Size = new System.Drawing.Size(42, 13);
            this.labelTretiKcM3.TabIndex = 24;
            this.labelTretiKcM3.Text = "Kč/m³ :";
            // 
            // labelMeziDruhaDPH
            // 
            this.labelMeziDruhaDPH.Location = new System.Drawing.Point(418, 41);
            this.labelMeziDruhaDPH.Name = "labelMeziDruhaDPH";
            this.labelMeziDruhaDPH.Size = new System.Drawing.Size(62, 13);
            this.labelMeziDruhaDPH.TabIndex = 23;
            this.labelMeziDruhaDPH.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDruhaCenaDPH
            // 
            this.labelDruhaCenaDPH.AutoSize = true;
            this.labelDruhaCenaDPH.Location = new System.Drawing.Point(382, 41);
            this.labelDruhaCenaDPH.Name = "labelDruhaCenaDPH";
            this.labelDruhaCenaDPH.Size = new System.Drawing.Size(41, 13);
            this.labelDruhaCenaDPH.TabIndex = 22;
            this.labelDruhaCenaDPH.Text = "s DPH:";
            this.labelDruhaCenaDPH.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMeziDruhaStred
            // 
            this.labelMeziDruhaStred.Location = new System.Drawing.Point(318, 41);
            this.labelMeziDruhaStred.Name = "labelMeziDruhaStred";
            this.labelMeziDruhaStred.Size = new System.Drawing.Size(62, 13);
            this.labelMeziDruhaStred.TabIndex = 21;
            this.labelMeziDruhaStred.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDruhaCenaStred
            // 
            this.labelDruhaCenaStred.AutoSize = true;
            this.labelDruhaCenaStred.Location = new System.Drawing.Point(288, 41);
            this.labelDruhaCenaStred.Name = "labelDruhaCenaStred";
            this.labelDruhaCenaStred.Size = new System.Drawing.Size(34, 13);
            this.labelDruhaCenaStred.TabIndex = 20;
            this.labelDruhaCenaStred.Text = "střed:";
            this.labelDruhaCenaStred.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMeziDruhaBezDPH
            // 
            this.labelMeziDruhaBezDPH.Location = new System.Drawing.Point(225, 41);
            this.labelMeziDruhaBezDPH.Name = "labelMeziDruhaBezDPH";
            this.labelMeziDruhaBezDPH.Size = new System.Drawing.Size(62, 13);
            this.labelMeziDruhaBezDPH.TabIndex = 19;
            this.labelMeziDruhaBezDPH.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDruhaCenaBezDPH
            // 
            this.labelDruhaCenaBezDPH.AutoSize = true;
            this.labelDruhaCenaBezDPH.Location = new System.Drawing.Point(149, 41);
            this.labelDruhaCenaBezDPH.Name = "labelDruhaCenaBezDPH";
            this.labelDruhaCenaBezDPH.Size = new System.Drawing.Size(81, 13);
            this.labelDruhaCenaBezDPH.TabIndex = 18;
            this.labelDruhaCenaBezDPH.Text = "Cena bez DPH:";
            // 
            // labelMeziDruhaM3
            // 
            this.labelMeziDruhaM3.Location = new System.Drawing.Point(107, 41);
            this.labelMeziDruhaM3.Name = "labelMeziDruhaM3";
            this.labelMeziDruhaM3.Size = new System.Drawing.Size(40, 13);
            this.labelMeziDruhaM3.TabIndex = 17;
            this.labelMeziDruhaM3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(86, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "m³ :";
            // 
            // labelMeziDruhaKcM3
            // 
            this.labelMeziDruhaKcM3.Location = new System.Drawing.Point(45, 41);
            this.labelMeziDruhaKcM3.Name = "labelMeziDruhaKcM3";
            this.labelMeziDruhaKcM3.Size = new System.Drawing.Size(40, 13);
            this.labelMeziDruhaKcM3.TabIndex = 15;
            this.labelMeziDruhaKcM3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDruhaKcM3
            // 
            this.labelDruhaKcM3.AutoSize = true;
            this.labelDruhaKcM3.Location = new System.Drawing.Point(6, 41);
            this.labelDruhaKcM3.Name = "labelDruhaKcM3";
            this.labelDruhaKcM3.Size = new System.Drawing.Size(42, 13);
            this.labelDruhaKcM3.TabIndex = 14;
            this.labelDruhaKcM3.Text = "Kč/m³ :";
            // 
            // labelMeziPrvniDPH
            // 
            this.labelMeziPrvniDPH.Location = new System.Drawing.Point(418, 21);
            this.labelMeziPrvniDPH.Name = "labelMeziPrvniDPH";
            this.labelMeziPrvniDPH.Size = new System.Drawing.Size(62, 13);
            this.labelMeziPrvniDPH.TabIndex = 13;
            this.labelMeziPrvniDPH.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPrvniCenaDPH
            // 
            this.labelPrvniCenaDPH.AutoSize = true;
            this.labelPrvniCenaDPH.Location = new System.Drawing.Point(382, 21);
            this.labelPrvniCenaDPH.Name = "labelPrvniCenaDPH";
            this.labelPrvniCenaDPH.Size = new System.Drawing.Size(41, 13);
            this.labelPrvniCenaDPH.TabIndex = 12;
            this.labelPrvniCenaDPH.Text = "s DPH:";
            this.labelPrvniCenaDPH.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMeziPrvniStred
            // 
            this.labelMeziPrvniStred.Location = new System.Drawing.Point(318, 21);
            this.labelMeziPrvniStred.Name = "labelMeziPrvniStred";
            this.labelMeziPrvniStred.Size = new System.Drawing.Size(62, 13);
            this.labelMeziPrvniStred.TabIndex = 11;
            this.labelMeziPrvniStred.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPrvniCenaStred
            // 
            this.labelPrvniCenaStred.AutoSize = true;
            this.labelPrvniCenaStred.Location = new System.Drawing.Point(288, 21);
            this.labelPrvniCenaStred.Name = "labelPrvniCenaStred";
            this.labelPrvniCenaStred.Size = new System.Drawing.Size(34, 13);
            this.labelPrvniCenaStred.TabIndex = 10;
            this.labelPrvniCenaStred.Text = "střed:";
            this.labelPrvniCenaStred.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMeziPrvniBezDPH
            // 
            this.labelMeziPrvniBezDPH.Location = new System.Drawing.Point(225, 21);
            this.labelMeziPrvniBezDPH.Name = "labelMeziPrvniBezDPH";
            this.labelMeziPrvniBezDPH.Size = new System.Drawing.Size(62, 13);
            this.labelMeziPrvniBezDPH.TabIndex = 9;
            this.labelMeziPrvniBezDPH.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPrvniCenaBezDPH
            // 
            this.labelPrvniCenaBezDPH.Location = new System.Drawing.Point(149, 21);
            this.labelPrvniCenaBezDPH.Name = "labelPrvniCenaBezDPH";
            this.labelPrvniCenaBezDPH.Size = new System.Drawing.Size(81, 13);
            this.labelPrvniCenaBezDPH.TabIndex = 8;
            this.labelPrvniCenaBezDPH.Text = "Cena bez DPH:";
            // 
            // labelMeziPrvniM3
            // 
            this.labelMeziPrvniM3.Location = new System.Drawing.Point(107, 21);
            this.labelMeziPrvniM3.Name = "labelMeziPrvniM3";
            this.labelMeziPrvniM3.Size = new System.Drawing.Size(40, 13);
            this.labelMeziPrvniM3.TabIndex = 7;
            this.labelMeziPrvniM3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(86, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "m³ :";
            // 
            // labelMeziPrvniKc
            // 
            this.labelMeziPrvniKc.Location = new System.Drawing.Point(45, 21);
            this.labelMeziPrvniKc.Name = "labelMeziPrvniKc";
            this.labelMeziPrvniKc.Size = new System.Drawing.Size(40, 13);
            this.labelMeziPrvniKc.TabIndex = 3;
            this.labelMeziPrvniKc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPrvniKcM3
            // 
            this.labelPrvniKcM3.AutoSize = true;
            this.labelPrvniKcM3.Location = new System.Drawing.Point(6, 21);
            this.labelPrvniKcM3.Name = "labelPrvniKcM3";
            this.labelPrvniKcM3.Size = new System.Drawing.Size(42, 13);
            this.labelPrvniKcM3.TabIndex = 88;
            this.labelPrvniKcM3.Text = "Kč/m³ :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelCenaCelkemDPH);
            this.groupBox2.Controls.Add(this.labelCenaCelkemStred);
            this.groupBox2.Controls.Add(this.labelCenaCelkem);
            this.groupBox2.Controls.Add(this.labelCelkovaCenaDPH);
            this.groupBox2.Controls.Add(this.labelCelkovaCenaStred);
            this.groupBox2.Controls.Add(this.labelCelkovaCenaBezDPH);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(512, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 84);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Celková cena za materiál v Kč";
            // 
            // labelCenaCelkemDPH
            // 
            this.labelCenaCelkemDPH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCenaCelkemDPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCenaCelkemDPH.Location = new System.Drawing.Point(208, 46);
            this.labelCenaCelkemDPH.Name = "labelCenaCelkemDPH";
            this.labelCenaCelkemDPH.Size = new System.Drawing.Size(77, 20);
            this.labelCenaCelkemDPH.TabIndex = 86;
            this.labelCenaCelkemDPH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCenaCelkemStred
            // 
            this.labelCenaCelkemStred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCenaCelkemStred.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCenaCelkemStred.Location = new System.Drawing.Point(114, 46);
            this.labelCenaCelkemStred.Name = "labelCenaCelkemStred";
            this.labelCenaCelkemStred.Size = new System.Drawing.Size(77, 20);
            this.labelCenaCelkemStred.TabIndex = 85;
            this.labelCenaCelkemStred.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCenaCelkem
            // 
            this.labelCenaCelkem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCenaCelkem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCenaCelkem.Location = new System.Drawing.Point(19, 46);
            this.labelCenaCelkem.Name = "labelCenaCelkem";
            this.labelCenaCelkem.Size = new System.Drawing.Size(77, 20);
            this.labelCenaCelkem.TabIndex = 84;
            this.labelCenaCelkem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCelkovaCenaDPH
            // 
            this.labelCelkovaCenaDPH.AutoSize = true;
            this.labelCelkovaCenaDPH.Location = new System.Drawing.Point(213, 25);
            this.labelCelkovaCenaDPH.Name = "labelCelkovaCenaDPH";
            this.labelCelkovaCenaDPH.Size = new System.Drawing.Size(66, 13);
            this.labelCelkovaCenaDPH.TabIndex = 83;
            this.labelCelkovaCenaDPH.Text = "Cena s DPH";
            // 
            // labelCelkovaCenaStred
            // 
            this.labelCelkovaCenaStred.AutoSize = true;
            this.labelCelkovaCenaStred.Location = new System.Drawing.Point(122, 24);
            this.labelCelkovaCenaStred.Name = "labelCelkovaCenaStred";
            this.labelCelkovaCenaStred.Size = new System.Drawing.Size(59, 13);
            this.labelCelkovaCenaStred.TabIndex = 82;
            this.labelCelkovaCenaStred.Text = "Cena střed";
            // 
            // labelCelkovaCenaBezDPH
            // 
            this.labelCelkovaCenaBezDPH.AutoSize = true;
            this.labelCelkovaCenaBezDPH.Location = new System.Drawing.Point(19, 24);
            this.labelCelkovaCenaBezDPH.Name = "labelCelkovaCenaBezDPH";
            this.labelCelkovaCenaBezDPH.Size = new System.Drawing.Size(78, 13);
            this.labelCelkovaCenaBezDPH.TabIndex = 81;
            this.labelCelkovaCenaBezDPH.Text = "Cena bez DPH";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoScroll = true;
            this.tableLayoutPanel.ColumnCount = 10;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel.Location = new System.Drawing.Point(22, 155);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(801, 518);
            this.tableLayoutPanel.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Řádek č.";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonReset.Enabled = false;
            this.buttonReset.Location = new System.Drawing.Point(21, 15);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(65, 23);
            this.buttonReset.TabIndex = 88;
            this.buttonReset.Text = "&Reset";
            this.toolTipReset.SetToolTip(this.buttonReset, "Reset vymaže všechny zadané a vypočítané údaje!  Alt + R");
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonTisk
            // 
            this.buttonTisk.Location = new System.Drawing.Point(282, 15);
            this.buttonTisk.Name = "buttonTisk";
            this.buttonTisk.Size = new System.Drawing.Size(65, 23);
            this.buttonTisk.TabIndex = 91;
            this.buttonTisk.Text = "&Tisk";
            this.toolTipOstatní.SetToolTip(this.buttonTisk, "Alt + T");
            this.buttonTisk.UseVisualStyleBackColor = true;
            this.buttonTisk.Click += new System.EventHandler(this.buttonTisk_Click);
            // 
            // labelPalubkyM
            // 
            this.labelPalubkyM.AutoSize = true;
            this.labelPalubkyM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelPalubkyM.Location = new System.Drawing.Point(211, 112);
            this.labelPalubkyM.Name = "labelPalubkyM";
            this.labelPalubkyM.Size = new System.Drawing.Size(62, 13);
            this.labelPalubkyM.TabIndex = 90;
            this.labelPalubkyM.Text = "Palubky [m]";
            // 
            // buttonNapoveda
            // 
            this.buttonNapoveda.Location = new System.Drawing.Point(368, 15);
            this.buttonNapoveda.Name = "buttonNapoveda";
            this.buttonNapoveda.Size = new System.Drawing.Size(65, 23);
            this.buttonNapoveda.TabIndex = 92;
            this.buttonNapoveda.Text = "&Nápověda";
            this.toolTipOstatní.SetToolTip(this.buttonNapoveda, "Alt + N");
            this.buttonNapoveda.UseVisualStyleBackColor = true;
            this.buttonNapoveda.Click += new System.EventHandler(this.buttonNapoveda_Click);
            // 
            // timerHodiny
            // 
            this.timerHodiny.Tick += new System.EventHandler(this.timerHodiny_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonNacist);
            this.groupBox3.Controls.Add(this.buttonUlozit);
            this.groupBox3.Controls.Add(this.buttonKonec);
            this.groupBox3.Controls.Add(this.buttonNapoveda);
            this.groupBox3.Controls.Add(this.buttonReset);
            this.groupBox3.Controls.Add(this.buttonTisk);
            this.groupBox3.Location = new System.Drawing.Point(269, 682);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 47);
            this.groupBox3.TabIndex = 93;
            this.groupBox3.TabStop = false;
            // 
            // buttonNacist
            // 
            this.buttonNacist.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonNacist.Location = new System.Drawing.Point(195, 15);
            this.buttonNacist.Name = "buttonNacist";
            this.buttonNacist.Size = new System.Drawing.Size(65, 23);
            this.buttonNacist.TabIndex = 90;
            this.buttonNacist.Text = "N&ačíst";
            this.toolTipNacist.SetToolTip(this.buttonNacist, "Načte do kalkulačky hodnoty z uloženého souboru  Alt + A");
            this.buttonNacist.UseVisualStyleBackColor = false;
            this.buttonNacist.Click += new System.EventHandler(this.buttonNacist_Click);
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonUlozit.Enabled = false;
            this.buttonUlozit.Location = new System.Drawing.Point(108, 15);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(65, 23);
            this.buttonUlozit.TabIndex = 89;
            this.buttonUlozit.Text = "&Uložit";
            this.toolTipUlozit.SetToolTip(this.buttonUlozit, "Uloží cenovou nabídku a hodnoty pro načtení  Alt + U");
            this.buttonUlozit.UseVisualStyleBackColor = false;
            this.buttonUlozit.Click += new System.EventHandler(this.buttonUlozit_Click);
            // 
            // buttonKonec
            // 
            this.buttonKonec.Location = new System.Drawing.Point(455, 15);
            this.buttonKonec.Name = "buttonKonec";
            this.buttonKonec.Size = new System.Drawing.Size(65, 23);
            this.buttonKonec.TabIndex = 93;
            this.buttonKonec.Text = "&Konec";
            this.toolTipOstatní.SetToolTip(this.buttonKonec, "Alt + K");
            this.buttonKonec.UseVisualStyleBackColor = true;
            this.buttonKonec.Click += new System.EventHandler(this.buttonKonec_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelDatumACas);
            this.groupBox4.Location = new System.Drawing.Point(15, 682);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 47);
            this.groupBox4.TabIndex = 94;
            this.groupBox4.TabStop = false;
            // 
            // labelDatumACas
            // 
            this.labelDatumACas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDatumACas.Location = new System.Drawing.Point(6, 17);
            this.labelDatumACas.Margin = new System.Windows.Forms.Padding(0);
            this.labelDatumACas.Name = "labelDatumACas";
            this.labelDatumACas.Size = new System.Drawing.Size(237, 17);
            this.labelDatumACas.TabIndex = 0;
            this.labelDatumACas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolTipReset
            // 
            this.toolTipReset.AutomaticDelay = 2000;
            this.toolTipReset.AutoPopDelay = 5000;
            this.toolTipReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolTipReset.ForeColor = System.Drawing.Color.Black;
            this.toolTipReset.InitialDelay = 20;
            this.toolTipReset.IsBalloon = true;
            this.toolTipReset.ReshowDelay = 20;
            // 
            // checkBoxSkryt
            // 
            this.checkBoxSkryt.AutoSize = true;
            this.checkBoxSkryt.Location = new System.Drawing.Point(15, 107);
            this.checkBoxSkryt.Name = "checkBoxSkryt";
            this.checkBoxSkryt.Size = new System.Drawing.Size(76, 17);
            this.checkBoxSkryt.TabIndex = 96;
            this.checkBoxSkryt.Text = "Skrýt ceny";
            this.checkBoxSkryt.UseVisualStyleBackColor = true;
            this.checkBoxSkryt.CheckedChanged += new System.EventHandler(this.checkBoxSkryt_CheckedChanged);
            // 
            // toolTipOstatní
            // 
            this.toolTipOstatní.IsBalloon = true;
            // 
            // toolTipUlozit
            // 
            this.toolTipUlozit.AutomaticDelay = 2000;
            this.toolTipUlozit.AutoPopDelay = 5000;
            this.toolTipUlozit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolTipUlozit.InitialDelay = 20;
            this.toolTipUlozit.IsBalloon = true;
            this.toolTipUlozit.ReshowDelay = 20;
            // 
            // checkBoxZkopirovat
            // 
            this.checkBoxZkopirovat.AutoSize = true;
            this.checkBoxZkopirovat.Location = new System.Drawing.Point(512, 107);
            this.checkBoxZkopirovat.Name = "checkBoxZkopirovat";
            this.checkBoxZkopirovat.Size = new System.Drawing.Size(288, 17);
            this.checkBoxZkopirovat.TabIndex = 97;
            this.checkBoxZkopirovat.Text = "Zkopírovat Kč/m³ z prvního řádku do prázdných řádků";
            this.checkBoxZkopirovat.UseVisualStyleBackColor = true;
            this.checkBoxZkopirovat.CheckedChanged += new System.EventHandler(this.checkBoxZkopirovat_CheckedChanged_1);
            // 
            // toolTipNacist
            // 
            this.toolTipNacist.AutomaticDelay = 2000;
            this.toolTipNacist.AutoPopDelay = 5000;
            this.toolTipNacist.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolTipNacist.InitialDelay = 20;
            this.toolTipNacist.IsBalloon = true;
            this.toolTipNacist.ReshowDelay = 20;
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.progressBar.Location = new System.Drawing.Point(15, 735);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(750, 15);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 98;
            // 
            // labelProgress
            // 
            this.labelProgress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelProgress.Location = new System.Drawing.Point(771, 735);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(42, 15);
            this.labelProgress.TabIndex = 99;
            // 
            // HlavniFormular
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(837, 759);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.checkBoxZkopirovat);
            this.Controls.Add(this.checkBoxSkryt);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labelPalubkyM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelCenaM2);
            this.Controls.Add(this.labelPalubkyM2);
            this.Controls.Add(this.labelTextPalubkyM);
            this.Controls.Add(this.labelCenaSDPH);
            this.Controls.Add(this.labelCenaStred);
            this.Controls.Add(this.labelCenaBezDPH);
            this.Controls.Add(this.labelCenaM3);
            this.Controls.Add(this.labelTitulekM3);
            this.Controls.Add(this.labelKusy);
            this.Controls.Add(this.labelDelka);
            this.Controls.Add(this.labelSirka);
            this.Controls.Add(this.labelTloustka);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "HlavniFormular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulačka řeziva";
            this.Load += new System.EventHandler(this.Formular_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Formular_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Formular_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCenaSDPH;
        private System.Windows.Forms.Label labelCenaStred;
        private System.Windows.Forms.Label labelCenaBezDPH;
        private System.Windows.Forms.Label labelCenaM3;
        private System.Windows.Forms.Label labelTitulekM3;
        private System.Windows.Forms.Label labelKusy;
        private System.Windows.Forms.Label labelDelka;
        private System.Windows.Forms.Label labelSirka;
        private System.Windows.Forms.Label labelTloustka;
        private System.Windows.Forms.Label labelTextPalubkyM;
        private System.Windows.Forms.Label labelPalubkyM2;
        private System.Windows.Forms.Label labelCenaM2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPrvniKcM3;
        private System.Windows.Forms.Label labelMeziPrvniKc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelCenaCelkemDPH;
        private System.Windows.Forms.Label labelCenaCelkemStred;
        public System.Windows.Forms.Label labelCenaCelkem;
        private System.Windows.Forms.Label labelCelkovaCenaDPH;
        private System.Windows.Forms.Label labelCelkovaCenaStred;
        private System.Windows.Forms.Label labelCelkovaCenaBezDPH;
        private System.Windows.Forms.Label labelMeziPrvniDPH;
        private System.Windows.Forms.Label labelPrvniCenaDPH;
        private System.Windows.Forms.Label labelMeziPrvniStred;
        private System.Windows.Forms.Label labelPrvniCenaStred;
        private System.Windows.Forms.Label labelMeziPrvniBezDPH;
        private System.Windows.Forms.Label labelPrvniCenaBezDPH;
        private System.Windows.Forms.Label labelMeziPrvniM3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMeziDruhaDPH;
        private System.Windows.Forms.Label labelDruhaCenaDPH;
        private System.Windows.Forms.Label labelMeziDruhaStred;
        private System.Windows.Forms.Label labelDruhaCenaStred;
        private System.Windows.Forms.Label labelMeziDruhaBezDPH;
        private System.Windows.Forms.Label labelDruhaCenaBezDPH;
        private System.Windows.Forms.Label labelMeziDruhaM3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelMeziDruhaKcM3;
        private System.Windows.Forms.Label labelDruhaKcM3;
        private System.Windows.Forms.Label labelMeziTretiDPH;
        private System.Windows.Forms.Label labelTretiCenaDPH;
        private System.Windows.Forms.Label labelMeziTretiStred;
        private System.Windows.Forms.Label labelTretiCenaStred;
        private System.Windows.Forms.Label labelMeziTretiBezDPH;
        private System.Windows.Forms.Label labelTretiCenaBezDPH;
        private System.Windows.Forms.Label labelMeziTretiM3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelMeziTretiKcM3;
        private System.Windows.Forms.Label labelTretiKcM3;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonTisk;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Label labelPalubkyM;
        private System.Windows.Forms.Button buttonNapoveda;
        private System.Windows.Forms.Timer timerHodiny;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonKonec;
        private System.Windows.Forms.Label labelDatumACas;
        private System.Windows.Forms.ToolTip toolTipReset;
        private System.Windows.Forms.CheckBox checkBoxSkryt;
        private System.Windows.Forms.ToolTip toolTipOstatní;
        private System.Windows.Forms.Button buttonUlozit;
        private System.Windows.Forms.ToolTip toolTipUlozit;
        private System.Windows.Forms.CheckBox checkBoxZkopirovat;
        private System.Windows.Forms.Button buttonNacist;
        private System.Windows.Forms.ToolTip toolTipNacist;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelProgress;
    }
}