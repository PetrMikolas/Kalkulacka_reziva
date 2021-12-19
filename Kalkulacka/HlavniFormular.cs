using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using Image = System.Drawing.Image;
using HorizontalAlignment = System.Windows.Forms.HorizontalAlignment;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
using System.Threading;

namespace Kalkulacka {

    public partial class HlavniFormular : Form {

        // instance třídy KeyPress
        private readonly KeyPress handler = new KeyPress();

        // vlastnosti třídy HlavniFormular
        public static int Pocet { get; } = 40;    // Počet řádků ve formuláři
        public double[] PoleTloustky { get; set; } = new double[Pocet];
        public double[] PoleSirky { get; set; } = new double[Pocet];
        public double[] PoleDelky { get; set; } = new double[Pocet];
        public double[] PolePocty { get; set; } = new double[Pocet];
        public double[] PoleVypocetM3 { get; set; } = new double[Pocet];
        public double[] PoleKcZaM3 { get; set; } = new double[Pocet];
        public double[] PoleCenaRadek { get; set; } = new double[Pocet];
        public TextBox[] CisloRadku { get; set; } = new TextBox[Pocet];
        public TextBox[] KlavesaTloustka { get; set; } = new TextBox[Pocet];
        public TextBox[] KlavesaSirka { get; set; } = new TextBox[Pocet];
        public TextBox[] KlavesaDelka { get; set; } = new TextBox[Pocet];
        public TextBox[] KlavesaPocet { get; set; } = new TextBox[Pocet];
        public TextBox[] KlavesaKcZaM3 { get; set; } = new TextBox[Pocet];
        public TextBox[] ZobrazVypocetM3 { get; set; } = new TextBox[Pocet];
        public TextBox[] ZobrazCenaRadekBezDPH { get; set; } = new TextBox[Pocet];
        public TextBox[] ZobrazCenaRadekStred { get; set; } = new TextBox[Pocet];
        public TextBox[] ZobrazCenaRadekDPH { get; set; } = new TextBox[Pocet];

        public HlavniFormular() {
            InitializeComponent();

            // vytvoření polí TextBoxů 
            for (int i = 0; i < Pocet; i++) {
                CisloRadku[i] = new TextBox();
                CisloRadku[i].ReadOnly = true;
                CisloRadku[i].Text = (i + 1).ToString();
                CisloRadku[i].Size = new Size(30, 20);
                CisloRadku[i].TextAlign = HorizontalAlignment.Center;
                CisloRadku[i].TabStop = false;
                tableLayoutPanel.SetRow(CisloRadku[i], i);
                tableLayoutPanel.SetColumn(CisloRadku[i], 0);
                tableLayoutPanel.Controls.Add(CisloRadku[i]);

                KlavesaTloustka[i] = new TextBox { TabIndex = (i * 9) };
                KlavesaTloustka[i].KeyPress += handler.validujTextDesetinnaCisla;
                KlavesaTloustka[i].TextChanged += textBox_TextChanged;
                KlavesaTloustka[i].Size = new Size(46, 20);
                KlavesaTloustka[i].TextAlign = HorizontalAlignment.Right;
                KlavesaTloustka[i].MaxLength = 6;
                tableLayoutPanel.SetRow(KlavesaTloustka[i], i);
                tableLayoutPanel.SetColumn(KlavesaTloustka[i], 1);
                tableLayoutPanel.Controls.Add(KlavesaTloustka[i]);

                KlavesaSirka[i] = new TextBox { TabIndex = (i * 9) + 1 };
                KlavesaSirka[i].KeyPress += handler.validujTextDesetinnaCisla;
                KlavesaSirka[i].TextChanged += textBox_TextChanged;
                KlavesaSirka[i].Size = new Size(46, 20);
                KlavesaSirka[i].TextAlign = HorizontalAlignment.Right;
                KlavesaSirka[i].MaxLength = 6;
                tableLayoutPanel.SetRow(KlavesaSirka[i], i);
                tableLayoutPanel.SetColumn(KlavesaSirka[i], 2);
                tableLayoutPanel.Controls.Add(KlavesaSirka[i]);

                KlavesaDelka[i] = new TextBox { TabIndex = (i * 9) + 2 };
                KlavesaDelka[i].KeyPress += handler.validujTextDesetinnaCisla;
                KlavesaDelka[i].TextChanged += textBox_TextChanged;
                KlavesaDelka[i].Size = new Size(46, 20);
                KlavesaDelka[i].TextAlign = HorizontalAlignment.Right;
                KlavesaDelka[i].MaxLength = 6;
                tableLayoutPanel.SetRow(KlavesaDelka[i], i);
                tableLayoutPanel.SetColumn(KlavesaDelka[i], 3);
                tableLayoutPanel.Controls.Add(KlavesaDelka[i]);

                KlavesaPocet[i] = new TextBox { TabIndex = (i * 9) + 3 };
                KlavesaPocet[i].KeyPress += handler.validujTextCelaCisla;
                KlavesaPocet[i].TextChanged += textBox_TextChanged;
                KlavesaPocet[i].Size = new Size(46, 20);
                KlavesaPocet[i].TextAlign = HorizontalAlignment.Right;
                KlavesaPocet[i].MaxLength = 5;
                tableLayoutPanel.SetRow(KlavesaPocet[i], i);
                tableLayoutPanel.SetColumn(KlavesaPocet[i], 4);
                tableLayoutPanel.Controls.Add(KlavesaPocet[i]);

                ZobrazVypocetM3[i] = new TextBox { };
                ZobrazVypocetM3[i].Size = new Size(55, 20);
                ZobrazVypocetM3[i].TextAlign = HorizontalAlignment.Right;
                ZobrazVypocetM3[i].ReadOnly = true;
                ZobrazVypocetM3[i].TabStop = false;
                tableLayoutPanel.SetRow(ZobrazVypocetM3[i], i);
                tableLayoutPanel.SetColumn(ZobrazVypocetM3[i], 5);
                tableLayoutPanel.Controls.Add(ZobrazVypocetM3[i]);

                KlavesaKcZaM3[i] = new TextBox { TabIndex = (i * 9) + 4 };
                KlavesaKcZaM3[i].KeyPress += handler.validujTextCelaCisla;
                KlavesaKcZaM3[i].TextChanged += textBox_TextChanged;
                KlavesaKcZaM3[i].Size = new Size(71, 20);
                KlavesaKcZaM3[i].TextAlign = HorizontalAlignment.Right;
                KlavesaKcZaM3[i].MaxLength = 6;
                tableLayoutPanel.SetRow(KlavesaKcZaM3[i], i);
                tableLayoutPanel.SetColumn(KlavesaKcZaM3[i], 6);
                tableLayoutPanel.Controls.Add(KlavesaKcZaM3[i]);

                ZobrazCenaRadekBezDPH[i] = new TextBox();
                ZobrazCenaRadekBezDPH[i].TextAlign = HorizontalAlignment.Right;
                ZobrazCenaRadekBezDPH[i].Size = new Size(77, 20);
                ZobrazCenaRadekBezDPH[i].ReadOnly = true;
                ZobrazCenaRadekBezDPH[i].TabStop = false;
                tableLayoutPanel.SetRow(ZobrazCenaRadekBezDPH[i], i);
                tableLayoutPanel.SetColumn(ZobrazCenaRadekBezDPH[i], 7);
                tableLayoutPanel.Controls.Add(ZobrazCenaRadekBezDPH[i]);

                ZobrazCenaRadekStred[i] = new TextBox();
                ZobrazCenaRadekStred[i].TextAlign = HorizontalAlignment.Right;
                ZobrazCenaRadekStred[i].Size = new Size(77, 20);
                ZobrazCenaRadekStred[i].ReadOnly = true;
                ZobrazCenaRadekStred[i].TabStop = false;
                tableLayoutPanel.SetRow(ZobrazCenaRadekStred[i], i);
                tableLayoutPanel.SetColumn(ZobrazCenaRadekStred[i], 8);
                tableLayoutPanel.Controls.Add(ZobrazCenaRadekStred[i]);

                ZobrazCenaRadekDPH[i] = new TextBox();
                ZobrazCenaRadekDPH[i].TextAlign = HorizontalAlignment.Right;
                ZobrazCenaRadekDPH[i].Size = new Size(77, 20);
                ZobrazCenaRadekDPH[i].ReadOnly = true;
                ZobrazCenaRadekDPH[i].TabStop = false;
                tableLayoutPanel.SetRow(ZobrazCenaRadekDPH[i], i);
                tableLayoutPanel.SetColumn(ZobrazCenaRadekDPH[i], 9);
                tableLayoutPanel.Controls.Add(ZobrazCenaRadekDPH[i]);
                vypocetObjem(i);     // načte do buněk nulové nodnoty
                vypocetCen(i);       // načte do buněk nulové nodnoty
            }
        }

        private void Formular_Load(object sender, EventArgs e) {
            vypocetMezisouctu();     // načte do buněk nulové nodnoty
            timerHodiny.Start();
        }

        /// <summary>
        /// Vyvolá se při změně hodnoty vlastnosti Text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_TextChanged(object sender, EventArgs e) {
            buttonReset.Enabled = true;
            buttonUlozit.Enabled = true;
            for (int i = 0; i < Pocet; i++) {
                if (KlavesaTloustka[i].Text != "") {
                    PoleTloustky[i] = Convert.ToDouble(KlavesaTloustka[i].Text);
                }
                if (KlavesaSirka[i].Text != "") {
                    PoleSirky[i] = Convert.ToDouble(KlavesaSirka[i].Text);
                }
                if (KlavesaDelka[i].Text != "") {
                    PoleDelky[i] = Convert.ToDouble(KlavesaDelka[i].Text);
                }
                if (KlavesaPocet[i].Text != "") {
                    PolePocty[i] = Convert.ToDouble(KlavesaPocet[i].Text);
                }
                if (KlavesaKcZaM3[i].Text != "") {
                    PoleKcZaM3[i] = Convert.ToDouble(KlavesaKcZaM3[i].Text);
                }
                else {                 // else - pokud uživatel vymaže částku z buňky Kč/m3 a buňka zůstane prázdná, tak se hodnota pole nastaví na nulu a poslední zadaná číslice se tak v poli přepíše na nulu
                    PoleKcZaM3[i] = 0;
                }
                vypocetObjem(i);
                vypocetCen(i);
                vypocetMezisouctu();
                if ((KlavesaTloustka[i].Text == "" || KlavesaTloustka[i].Text == "0") && PoleVypocetM3[i] > 0) {     // v případě výpočtu m2 podbarví žlutě buňky s výpočtem m2 a s cenou za m2
                    ZobrazVypocetM3[i].BackColor = Color.FromArgb(255, 255, 192);
                    KlavesaKcZaM3[i].BackColor = Color.FromArgb(255, 255, 192);
                }
                else {                                                      // větev else musí být naprogramována pro případ, že uživatel v průběhu zadávání upraví hodnoty
                    ZobrazVypocetM3[i].BackColor = SystemColors.Control;
                    KlavesaKcZaM3[i].BackColor = Color.White;
                }
            }
        }

        /// <summary>
        /// Vypočítá objem
        /// </summary>
        /// <param name="index">Index ze smyčky For</param>
        private void vypocetObjem(int index) {          // využití indexu smyčky z metody "textBox_TextChanged" výrazně urychlí výpočty
            double[] pomocna = new double[Pocet];
            if (KlavesaSirka[index].Text == "" || KlavesaDelka[index].Text == "" || KlavesaPocet[index].Text == "") {           // bez zadání všech údajů se výpočet neprovede, resp. bude nula
                pomocna[index] = 0;
            }
            else {
                if (KlavesaTloustka[index].Text == "" || KlavesaTloustka[index].Text == "0") {                              // bez údaju o tloušťce řeziva se vypočítá pouze plocha tj. m2
                    pomocna[index] = PoleSirky[index] * PoleDelky[index] * PolePocty[index];
                }
                else {
                    pomocna[index] = (PoleTloustky[index] / 100) * (PoleSirky[index] / 100) * PoleDelky[index] * PolePocty[index];      // výpočet m3
                }
            }
            PoleVypocetM3[index] = Math.Round(pomocna[index], 3);                // zaokrouhlení na 3 desetinná místa
            ZobrazVypocetM3[index].Text = PoleVypocetM3[index].ToString("f3");   // k formátování lze použít i ("0.000")                                                                                                                                                                                                    
        }

        /// <summary>
        /// Vypočítá jednotlivé ceny
        /// </summary>
        /// <param name="index">Index ze smyčky for</param>        
        private void vypocetCen(int index) {        // využití indexu smyčky z metody "textBox_TextChanged" výrazně urychlí výpočty
            double cenaCelkem = 0;
            double cenaCelkemDPH = 0;
            double cenaCelkemStred = 0;
            // ceny v jednotlivých řádcích
            PoleCenaRadek[index] = Math.Round(PoleVypocetM3[index] * PoleKcZaM3[index], 2);
            ZobrazCenaRadekBezDPH[index].Text = PoleCenaRadek[index].ToString("# ##0.00");
            ZobrazCenaRadekDPH[index].Text = Math.Round((PoleCenaRadek[index] * 1.21), 2).ToString("# ##0.00");
            ZobrazCenaRadekStred[index].Text = Math.Round(((PoleCenaRadek[index] + (PoleCenaRadek[index] * 1.21)) / 2), 2).ToString("# ##0.00");
            // celkové ceny v záhlaví
            for (int i = 0; i < Pocet; i++) {                       //pro výpočet celkových cen musí být použita samostatná smyčka
                cenaCelkem += Math.Round(PoleVypocetM3[i] * PoleKcZaM3[i], 2);
                cenaCelkemDPH += Math.Round((PoleCenaRadek[i] * 1.21), 2);
                cenaCelkemStred += Math.Round(((PoleCenaRadek[i] + (PoleCenaRadek[i] * 1.21)) / 2), 2);
            }
            labelCenaCelkem.Text = cenaCelkem.ToString("# ### ##0.00");
            labelCenaCelkemDPH.Text = cenaCelkemDPH.ToString("# ### ##0.00");
            labelCenaCelkemStred.Text = cenaCelkemStred.ToString("# ### ##0.00");
        }

        /// <summary>
        /// Zachytává shodné ceny za m3 nebo m2 na jednotlivých řádcích
        /// </summary>
        /// <param name="prvniCena">První shodná cena</param>
        /// <param name="druhaCena">Druhá shodná cena</param>
        /// <param name="tretiCena">Třetí shodná cena</param>
        private void shodneCeny(out double prvniCena, out double druhaCena, out double tretiCena) {
            prvniCena = 0;
            druhaCena = 0;
            tretiCena = 0;
            double prvniPocet = 0;
            double druhyPocet = 0;
            double tretiPocet = 0;
            for (int i = 0; i < PoleKcZaM3.Length - 1; i++) {
                for (int j = i + 1; j < PoleKcZaM3.Length; j++) {
                    if (PoleKcZaM3[i] == PoleKcZaM3[j] && PoleKcZaM3[i] != 0) {
                        prvniPocet++;
                        if (prvniPocet == 1) {
                            prvniCena = PoleKcZaM3[i];
                        }
                        if (PoleKcZaM3[i] == PoleKcZaM3[j] && (PoleKcZaM3[i] != prvniCena)) {
                            druhyPocet++;
                            if (druhyPocet == 1) {
                                druhaCena = PoleKcZaM3[i];
                            }
                            if (PoleKcZaM3[i] == PoleKcZaM3[j] && (PoleKcZaM3[i] != druhaCena)) {
                                tretiPocet++;
                                if (tretiPocet == 1) {
                                    tretiCena = PoleKcZaM3[i];
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        ///Vypočítá mezisoučty 
        /// </summary>
        private void vypocetMezisouctu() {
            shodneCeny(out double prvniCena, out double druhaCena, out double tretiCena);
            double soucetMetryKrychlovePrvniCena = 0;
            double soucetMetryKrychloveDruhaCena = 0;
            double soucetMetryKrychloveTretiCena = 0;
            // sčíta m3 nebo m2 dle shodných cen 
            for (int i = 0; i < Pocet; i++) {
                if (PoleKcZaM3[i] == prvniCena && PoleKcZaM3[i] != 0) {
                    soucetMetryKrychlovePrvniCena += PoleVypocetM3[i];
                }
                if (PoleKcZaM3[i] == druhaCena && PoleKcZaM3[i] != 0) {
                    soucetMetryKrychloveDruhaCena += PoleVypocetM3[i];
                }
                if (PoleKcZaM3[i] == tretiCena && PoleKcZaM3[i] != 0) {
                    soucetMetryKrychloveTretiCena += PoleVypocetM3[i];
                }
            }

            double mezisoucetPrvniCenaBezDph = prvniCena * soucetMetryKrychlovePrvniCena;
            double mezisoucetDruhaCenaBezDph = druhaCena * soucetMetryKrychloveDruhaCena;
            double mezisoucetTretiCenaBezDph = tretiCena * soucetMetryKrychloveTretiCena;

            labelMeziPrvniKc.Text = prvniCena.ToString("#,#.");
            labelMeziPrvniM3.Text = soucetMetryKrychlovePrvniCena.ToString("0.000");
            labelMeziPrvniBezDPH.Text = mezisoucetPrvniCenaBezDph.ToString("#,0.00");
            labelMeziPrvniDPH.Text = (mezisoucetPrvniCenaBezDph * 1.21).ToString("#,0.00");
            labelMeziPrvniStred.Text = ((mezisoucetPrvniCenaBezDph + (mezisoucetPrvniCenaBezDph * 1.21)) / 2).ToString("#,0.00");

            labelMeziDruhaKcM3.Text = druhaCena.ToString("#,#");
            labelMeziDruhaM3.Text = soucetMetryKrychloveDruhaCena.ToString("0.000");
            labelMeziDruhaBezDPH.Text = mezisoucetDruhaCenaBezDph.ToString("#,0.00");
            labelMeziDruhaDPH.Text = (mezisoucetDruhaCenaBezDph * 1.21).ToString("#,0.00");
            labelMeziDruhaStred.Text = ((mezisoucetDruhaCenaBezDph + (mezisoucetDruhaCenaBezDph * 1.21)) / 2).ToString("#,0.00");

            labelMeziTretiKcM3.Text = tretiCena.ToString("#,#");
            labelMeziTretiM3.Text = soucetMetryKrychloveTretiCena.ToString("0.000");
            labelMeziTretiBezDPH.Text = mezisoucetTretiCenaBezDph.ToString("#,0.00");
            labelMeziTretiDPH.Text = (mezisoucetTretiCenaBezDph * 1.21).ToString("#,0.00");
            labelMeziTretiStred.Text = ((mezisoucetTretiCenaBezDph + (mezisoucetTretiCenaBezDph * 1.21)) / 2).ToString("#,0.00");
        }

        /// <summary>
        /// Nastaví focus do 1. buňky řádku, ve kterém bude v buňce ve sloupci Objem [m3] nula
        /// </summary>
        /// <param name="index">Index ze smyčky for</param>
        private void nastavFocus(int index) {
            if (index == 0 && PoleVypocetM3[0] == 0) {
                KlavesaTloustka[0].Focus();
            }
            if (index != 0) {
                if (PoleVypocetM3[index] == 0 && PoleVypocetM3[index - 1] != 0) {
                    KlavesaTloustka[index].Focus();
                }
            }
        }

        /// <summary>
        /// Resetuje celý formulář
        /// </summary>
        private void reset() {
            for (int i = 0; i < Pocet; i++) {
                KlavesaTloustka[i].Clear();
                KlavesaSirka[i].Clear();
                KlavesaDelka[i].Clear();
                KlavesaPocet[i].Clear();
                KlavesaKcZaM3[i].Clear();
                ZobrazVypocetM3[i].BackColor = SystemColors.Control;
                KlavesaKcZaM3[i].BackColor = Color.White;
                progressBar.Value = (i * 100 / (Pocet - 1));
                labelProgress.Text = " " + (i * 100 / (Pocet - 1)).ToString() + " %";
                labelProgress.Update();
            }
            checkBoxSkryt.Checked = false;
            checkBoxZkopirovat.Checked = false;
            Thread.Sleep(500);
            progressBar.Value = 0;
            labelProgress.Text = string.Empty;
            buttonReset.Enabled = false;
            buttonUlozit.Enabled = false;
            KlavesaTloustka[0].Focus();     //nastaví kurzor do 1. buňky 1. sloupce
        }

        /// <summary>
        /// Po zatrhnutí checkboxu zůstane zobrazena pouze cena střed, ostatní ceny se skryjí.
        /// </summary>
        /// <param name="name">Jméno CheckBoxu</param>
        private void skryjCeny(CheckBox name) {
            if (name.Checked) {
                for (int i = 0; i < Pocet; i++) {
                    KlavesaKcZaM3[i].PasswordChar = ' ';
                    KlavesaKcZaM3[i].ReadOnly = true;
                    KlavesaKcZaM3[i].TabStop = false;
                    ZobrazCenaRadekBezDPH[i].PasswordChar = ' ';
                    ZobrazCenaRadekDPH[i].PasswordChar = ' ';
                    nastavFocus(i);
                }
                labelMeziPrvniKc.ForeColor = SystemColors.Control;
                labelMeziPrvniBezDPH.ForeColor = SystemColors.Control;
                labelMeziPrvniDPH.ForeColor = SystemColors.Control;
                labelMeziDruhaKcM3.ForeColor = SystemColors.Control;
                labelMeziDruhaBezDPH.ForeColor = SystemColors.Control;
                labelMeziDruhaDPH.ForeColor = SystemColors.Control;
                labelMeziTretiKcM3.ForeColor = SystemColors.Control;
                labelMeziTretiBezDPH.ForeColor = SystemColors.Control;
                labelMeziTretiDPH.ForeColor = SystemColors.Control;
                labelCenaCelkem.ForeColor = SystemColors.Control;
                labelCenaCelkemDPH.ForeColor = SystemColors.Control;
                labelDruhaCenaDPH.ForeColor = SystemColors.Control;
                labelTretiCenaDPH.ForeColor = SystemColors.Control;
                labelPrvniCenaDPH.ForeColor = SystemColors.Control;
            }
            else {
                for (int i = 0; i < Pocet; i++) {
                    KlavesaKcZaM3[i].PasswordChar = '\0';
                    KlavesaKcZaM3[i].ReadOnly = false;
                    KlavesaKcZaM3[i].TabStop = true;
                    ZobrazCenaRadekBezDPH[i].PasswordChar = '\0';
                    ZobrazCenaRadekDPH[i].PasswordChar = '\0';
                    nastavFocus(i);
                }
                labelMeziPrvniKc.ForeColor = Color.Black;
                labelMeziPrvniBezDPH.ForeColor = Color.Black;
                labelMeziPrvniDPH.ForeColor = Color.Black;
                labelMeziDruhaKcM3.ForeColor = Color.Black;
                labelMeziDruhaBezDPH.ForeColor = Color.Black;
                labelMeziDruhaDPH.ForeColor = Color.Black;
                labelMeziTretiKcM3.ForeColor = Color.Black;
                labelMeziTretiBezDPH.ForeColor = Color.Black;
                labelMeziTretiDPH.ForeColor = Color.Black;
                labelCenaCelkem.ForeColor = Color.Black;
                labelCenaCelkemDPH.ForeColor = Color.Black;
                labelDruhaCenaDPH.ForeColor = Color.Black;
                labelTretiCenaDPH.ForeColor = Color.Black;
                labelPrvniCenaDPH.ForeColor = Color.Black;
            }
        }

        // přenos bitových bloků
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern bool BitBlt(
        IntPtr hdcDest,     // handle to destination DC  
        int nXDest,         // x-coord of destination upper-left corner  
        int nYDest,         // y-coord of destination upper-left corner  
        int nWidth,         // width of destination rectangle  
        int nHeight,        // height of destination rectangle  
        IntPtr hdcSrc,      // handle to source DC  
        int nXSrc,          // x-coordinate of source upper-left corner  
        int nYSrc,          // y-coordinate of source upper-left corner  
        int dwRop           // raster operation code  
        );

        /// <summary>
        /// Vytvoří obraz formuláře pro ukládání a tisk
        /// </summary>
        /// <returns>Obraz formuláře</returns>
        private Image obrazFormulare() {
            Graphics g1 = CreateGraphics();
            Image obraz = new Bitmap(ClientRectangle.Width, ClientRectangle.Height, g1);
            Graphics g2 = Graphics.FromImage(obraz);
            IntPtr dc1 = g1.GetHdc();
            IntPtr dc2 = g2.GetHdc();
            BitBlt(dc2, 0, 0, ClientRectangle.Width, ClientRectangle.Height, dc1, 0, 0, 13369376);
            g1.ReleaseHdc(dc1);
            g2.ReleaseHdc(dc2);
            return obraz;
        }

        #region Metody pro tisk formuláře
        public Stream StreamToPrint { get; private set; }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e) {
            Image image = Image.FromStream(StreamToPrint);
            int x = 39;  // e.MarginBounds.X;
            int y = 39;  // e.MarginBounds.Y;
            int width = image.Width - 90;
            int height = image.Height - 50;
            Rectangle destRect = new Rectangle(x, y, width, height);
            e.Graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
        }

        private void startPrint(Stream streamToPrint) {
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            this.StreamToPrint = streamToPrint;
            PrintDialog printDialog = new PrintDialog();
            printDialog.AllowSomePages = true;
            printDialog.ShowHelp = true;
            printDialog.Document = printDocument;
            printDialog.Document.DocumentName = "Cenová nabídka";
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK) {
                printDocument.Print();
            }
        }

        /// <summary>
        /// Vytiskne formulář
        /// </summary>
        private void tisk() {
            Image obraz = obrazFormulare();
            string pathSlozkaTempKalkulackaReziva = @"C:\Windows\Temp\KalkulackaReziva";
            if (!Directory.Exists(pathSlozkaTempKalkulackaReziva)) {
                Directory.CreateDirectory(pathSlozkaTempKalkulackaReziva);
            }
            string pathSoubor = $"{pathSlozkaTempKalkulackaReziva}{Path.DirectorySeparatorChar}file.Png";
            obraz.Save(pathSoubor, ImageFormat.Png);
            FileStream fileStream = new FileStream(pathSoubor, FileMode.Open);
            startPrint(fileStream);
            fileStream.Close();
            if (File.Exists(pathSoubor)) {
                File.Delete(pathSoubor);
            }
        }
        #endregion

        /// <summary>
        /// Uloží obraz formuláře do Png souboru a zavolá metodu pro uložení hodnot do CSV souboru
        /// </summary>
        private void ulozSoubor() {
            InputBox inputBox = new InputBox();  //instance třídy InputBox
            Image obraz = obrazFormulare();
            string nazevSlozky = "Cenové nabídky";
            string pathSlozkaDesktopCenoveNabidky = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), nazevSlozky);
            if (!Directory.Exists(pathSlozkaDesktopCenoveNabidky)) {
                Directory.CreateDirectory(pathSlozkaDesktopCenoveNabidky);
                MessageBox.Show($"Na pracovní ploše počítače byla vytvořena složka s názvem \"{nazevSlozky}\"", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string pathSoubor = "";
            string nazevSouboru = $"Cenová nabídka řeziva {DateTime.Now.ToString("d.M.yyyy H.mm.ss")}";       // implicitní název souboru
            bool duplicitniNazevSouboru = true;
            bool souborUlozen = true;

            try {
                while (duplicitniNazevSouboru) {
                    if (inputBox.input(ref nazevSouboru) == DialogResult.OK) {                                // explicitní název souboru
                        pathSoubor = $"{pathSlozkaDesktopCenoveNabidky}{Path.DirectorySeparatorChar}{nazevSouboru}.Png";
                        if (!File.Exists(pathSoubor)) {
                            obraz.Save(pathSoubor, ImageFormat.Png);
                            duplicitniNazevSouboru = false;
                        }
                        else {
                            MessageBox.Show($"Soubor se neuložil, jelikož jste zadali název souboru, který již existuje ve složce \"{nazevSlozky}\"\n\nZkuste to prosím znovu s jiným názvem souboru\n", "Upozornění - duplicitní název souboru", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else {
                        duplicitniNazevSouboru = false;
                        souborUlozen = false;
                    }
                }

                if (File.Exists(pathSoubor) && souborUlozen) {
                    buttonUlozit.Enabled = false;
                    MessageBox.Show($"Soubor byl uložen do složky \"{nazevSlozky}\"", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Soubor nebyl uložen!", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ulozCsvSoubor(souborUlozen, nazevSouboru);
            }
            catch (System.Runtime.InteropServices.ExternalException) { MessageBox.Show($"Antivirový program zablokoval uložení souboru.\nPovolte aplikaci v nastavení štítu proti ransomwaru", "Soubor nebyl uložen!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>
        /// Uloží zadané hodnoty do CSV souboru
        /// </summary>
        /// <param name="PngSouborUlozen">Informace, zda byl uložen Png soubor</param>
        /// <param name="jmenoSouboru">Název, pod kterým se soubor uloží</param>
        private void ulozCsvSoubor(bool PngSouborUlozen, string jmenoSouboru) {
            string nazevSlozky = "KalkulackaReziva";
            string pathSlozkaAppDataLocalKalkulackaReziva = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), nazevSlozky);
            string pathSoubor = $"{pathSlozkaAppDataLocalKalkulackaReziva}{Path.DirectorySeparatorChar}{jmenoSouboru}.csv";
            try {
                if (PngSouborUlozen) {
                    if (!Directory.Exists(pathSlozkaAppDataLocalKalkulackaReziva)) {
                        Directory.CreateDirectory(pathSlozkaAppDataLocalKalkulackaReziva);
                    }

                    using (StreamWriter sw = new StreamWriter(pathSoubor)) {
                        // záhlaví tabulky se ukládá pro případ, že by chtěl uživatel pracovat s CSV souborem například v aplikaci Excel
                        string zahlaviTabulka = "Tloustka [cm]; Sirka [cm] palubky [m] ; Delka [cm] palubky [m]; Pocet [ks]; Objem [m3] palubky [m2]; Kc/m3 palubky Kc/m2; Cena bez DPH; Cena stred; Cena s DPH";
                        sw.WriteLine(zahlaviTabulka);
                        for (int i = 0; i < Pocet; i++) {
                            string radek = $"{KlavesaTloustka[i].Text};{KlavesaSirka[i].Text};{KlavesaDelka[i].Text};{KlavesaPocet[i].Text};{ZobrazVypocetM3[i].Text};{KlavesaKcZaM3[i].Text};{ZobrazCenaRadekBezDPH[i].Text};{ZobrazCenaRadekStred[i].Text};{ZobrazCenaRadekDPH[i].Text}";
                            sw.WriteLine(radek);
                        }
                        // zápatí tabulky se ukládá pro případ, že by chtěl uživatel pracovat s CSV souborem například v aplikaci Excel
                        string zapatiTabulky = ";" + ";" + ";" + ";" + ";" + "Celkove ceny v Kc:" + ";" + labelCenaCelkem.Text + ";" + labelCenaCelkemStred.Text + ";" + labelCenaCelkemDPH.Text;
                        sw.WriteLine(zapatiTabulky);
                        sw.Flush();
                    }
                }
            }
            catch (UnauthorizedAccessException) { MessageBox.Show("Nepodařilo se vytvořit složku pro uložení hodnot " + pathSlozkaAppDataLocalKalkulackaReziva + "\nZkontrolujte prosím svá opravnění", "Hodnoty pro načtení nebyly uloženy!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>
        /// Zobrazí dialogové okno pro výběr CSV souboru s uloženými hodnotami a poté zavolá metodu pro načítání hodnot
        /// </summary>
        private void startNacitani() {
            string pathAppDataLocalSlozkaKalkulackaReziva = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "KalkulackaReziva");
            string pathSoubor;
            string jmenoSouboru = string.Empty;

            if (!Directory.Exists(pathAppDataLocalSlozkaKalkulackaReziva)) {
                Directory.CreateDirectory(pathAppDataLocalSlozkaKalkulackaReziva);
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = pathAppDataLocalSlozkaKalkulackaReziva;
            openFileDialog.Filter = "CSV (textový soubor s oddělovači) (*.csv)|*.csv";
            openFileDialog.CheckPathExists = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.Title = "Uložiště";
            openFileDialog.FileName = string.Empty;
            try {
                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    pathSoubor = openFileDialog.FileName;
                    jmenoSouboru = Path.GetFileNameWithoutExtension(pathSoubor);
                    nacitaniHodnot(pathSoubor);
                }
                else {
                    MessageBox.Show("Nevybrali jste žádný soubor k načtení", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException) { reset(); MessageBox.Show("Proces nemůže přistupovat k souboru:\n" + "\"" + jmenoSouboru + "\"" + "\n\nTento soubor je využíván jiným procesem", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>
        /// Načte do formuláře hodnoty z uloženého CSV souboru 
        /// </summary>
        /// <param name="pathFile">Cesta k souboru</param>
        private void nacitaniHodnot(string pathFile) {
            try {
                using (StreamReader sr = new StreamReader(pathFile)) {
                    string radek = sr.ReadLine();       // načte první řádek se záhlavím tabulky, aby se nevyhodila výjimka, že vybraný soubor neobsahuje hodnoty k načtení
                    for (int i = 0; i < Pocet; i++) {
                        radek = sr.ReadLine();
                        string[] bunkyRadku = radek.Split(';');
                        KlavesaTloustka[i].Text = bunkyRadku[0];
                        KlavesaSirka[i].Text = bunkyRadku[1];
                        KlavesaDelka[i].Text = bunkyRadku[2];
                        KlavesaPocet[i].Text = bunkyRadku[3];
                        KlavesaKcZaM3[i].Text = bunkyRadku[5];
                        progressBar.Value = (i * 100 / (Pocet - 1));
                        labelProgress.Text = " " + (i * 100 / (Pocet - 1)).ToString() + " %";
                        labelProgress.Update();
                        nastavFocus(i);
                    }
                }
                string jmenoSouboru = Path.GetFileNameWithoutExtension(pathFile);
                MessageBox.Show("Byly načteny hodnoty ze souboru:\n\n" + "\"" + jmenoSouboru + "\"", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBar.Value = 0;
                labelProgress.Text = string.Empty;
            }
            catch (IndexOutOfRangeException) { reset(); MessageBox.Show("Vybraný soubor neobsahuje hodnoty k načtení", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (FormatException) { reset(); MessageBox.Show("Vybraný soubor neobsahuje hodnoty k načtení", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (NullReferenceException) { reset(); MessageBox.Show("Vybraný soubor neobsahuje hodnoty k načtení", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>
        /// Nastaví, které klávesy budou ovládat posouvání kurzoru
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Definuje klávesy, které budou ovládat kurzor</param>
        private void Formular_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter || e.KeyCode == Keys.Right) {   //při stisku klávesy Enter nebo šipky doprava se kurzor posune na další pozici
                SendKeys.SendWait("{TAB}");
            }
            if (e.KeyCode == Keys.Left) {                               //při stisku klávesy šipky doleva se kurzor vrátí na předchozí pozici
                SendKeys.SendWait("+{TAB}");
            }
        }

        /// <summary>
        /// Vypne zvuk při stisku klávesy Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Definuje klávesu</param>
        private void Formular_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Return)
                e.Handled = true;
        }

        /// <summary>
        /// Zkopíruje text z buňky na 1. řádku ve sloupci Kč/m3 do ostatních buněk ve sloupci Kč/m3.
        /// Text se zkopíruje pouze v řádcích, kde bude ve sloupci Objem [m3] nulová hodnota.
        /// </summary>
        /// <param name="name">Jméno CheckBoxu</param>
        private void zkopirujText(CheckBox name) {
            for (int i = 0; i < Pocet - 1; i++) {
                if (name.Checked && PoleVypocetM3[i + 1] == 0) {
                    KlavesaKcZaM3[i + 1].Text = KlavesaKcZaM3[0].Text;
                    nastavFocus(i);
                }
                else {
                    if (PoleVypocetM3[i + 1] == 0) {
                        KlavesaKcZaM3[i + 1].Clear();
                        nastavFocus(i);
                    }
                }
            }
        }

        // Zobrazí datum a čas
        private void timerHodiny_Tick(object sender, EventArgs e) {
            labelDatumACas.Text = DateTime.Now.ToString("dddd d. MMMM yyyy  H:mm:ss");
        }

        // Zobrazí nápovědu
        private void buttonNapoveda_Click(object sender, EventArgs e) {
            Napoveda napoveda = new Napoveda();   //instance třídy Napoveda
            napoveda.ShowDialog();
        }

        // Ukončí formulář
        private void buttonKonec_Click(object sender, EventArgs e) {
            Close();
        }

        // Skryje ceny
        private void checkBoxSkryt_CheckedChanged(object sender, EventArgs e) {
            skryjCeny(checkBoxSkryt);
        }

        // Resetuje formulář
        private void buttonReset_Click(object sender, EventArgs e) {
            reset();
        }

        // Zkopíruje Kč/m3 z prvního řádku do prázdných řádků
        private void checkBoxZkopirovat_CheckedChanged_1(object sender, EventArgs e) {
            zkopirujText(checkBoxZkopirovat);
        }

        // Uloží soubor
        private void buttonUlozit_Click(object sender, EventArgs e) {
            ulozSoubor();
        }

        // Načte uložené hodnoty
        private void buttonNacist_Click(object sender, EventArgs e) {
            startNacitani();
        }

        // Zahájí tisk 
        private void buttonTisk_Click(object sender, EventArgs e) {
            tisk();
        }
    }
}


