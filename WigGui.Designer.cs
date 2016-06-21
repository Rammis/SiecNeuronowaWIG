namespace SiecNeuronowa
{
    partial class WigGui
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_wczytaj_dane = new System.Windows.Forms.Button();
            this.button_nauka = new System.Windows.Forms.Button();
            this.button_prognozuj = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox_ilosc_danych = new System.Windows.Forms.ComboBox();
            this.comboBox_pierwsza_warstwa = new System.Windows.Forms.ComboBox();
            this.comboBox_druga_warstwa = new System.Windows.Forms.ComboBox();
            this.label_nowa_ilosc_danych = new System.Windows.Forms.Label();
            this.label_nowa_pierwsza_warstwa = new System.Windows.Forms.Label();
            this.label_nowa_druga_warstwa = new System.Windows.Forms.Label();
            this.button_zatwierdz_nowa_siec = new System.Windows.Forms.Button();
            this.label_wynik_prognozowany = new System.Windows.Forms.Label();
            this.label_wartosc_wynik_prognozowany = new System.Windows.Forms.Label();
            this.panel_konfiguracja = new System.Windows.Forms.Panel();
            this.panel_wczytaj_siec = new System.Windows.Forms.Panel();
            this.label_wczytaj_siec = new System.Windows.Forms.Label();
            this.button_wczytaj_siec = new System.Windows.Forms.Button();
            this.panel_nowa_siec = new System.Windows.Forms.Panel();
            this.label_nowa_siec = new System.Windows.Forms.Label();
            this.label_konfiguracja_sieci = new System.Windows.Forms.Label();
            this.label_ilosc_danych = new System.Windows.Forms.Label();
            this.label_pierwsza_warstwa = new System.Windows.Forms.Label();
            this.label_druga_warstwa = new System.Windows.Forms.Label();
            this.label_wartosc_ilosc_danych = new System.Windows.Forms.Label();
            this.label_wartosc_pierwsza_warstwa = new System.Windows.Forms.Label();
            this.label_wartosc_druga_warstwa = new System.Windows.Forms.Label();
            this.tableLayoutPanel_dane = new System.Windows.Forms.TableLayoutPanel();
            this.label_ilosc_nauk = new System.Windows.Forms.Label();
            this.label_wartosc_ilosc_nauk = new System.Windows.Forms.Label();
            this.button_zakoncz_symulacje = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel_siec = new System.Windows.Forms.TableLayoutPanel();
            this.label_nazwa_sieci = new System.Windows.Forms.Label();
            this.label_wartosc_nazwa_sieci = new System.Windows.Forms.Label();
            this.tableLayoutPanel_wyniki = new System.Windows.Forms.TableLayoutPanel();
            this.label_wynik_oczekiwany = new System.Windows.Forms.Label();
            this.label_wartosc_wynik_oczekiwany = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.combobox_ilosc_nauk = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel_konfiguracja.SuspendLayout();
            this.panel_wczytaj_siec.SuspendLayout();
            this.panel_nowa_siec.SuspendLayout();
            this.tableLayoutPanel_dane.SuspendLayout();
            this.tableLayoutPanel_siec.SuspendLayout();
            this.tableLayoutPanel_wyniki.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 307);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(859, 422);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // button_wczytaj_dane
            // 
            this.button_wczytaj_dane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_wczytaj_dane.Enabled = false;
            this.button_wczytaj_dane.Location = new System.Drawing.Point(882, 183);
            this.button_wczytaj_dane.Name = "button_wczytaj_dane";
            this.button_wczytaj_dane.Size = new System.Drawing.Size(188, 56);
            this.button_wczytaj_dane.TabIndex = 1;
            this.button_wczytaj_dane.Text = "Wczytaj dane uczące";
            this.button_wczytaj_dane.UseVisualStyleBackColor = true;
            this.button_wczytaj_dane.Visible = false;
            this.button_wczytaj_dane.Click += new System.EventHandler(this.wczytajDane_Click);
            // 
            // button_nauka
            // 
            this.button_nauka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_nauka.Enabled = false;
            this.button_nauka.Location = new System.Drawing.Point(979, 342);
            this.button_nauka.Name = "button_nauka";
            this.button_nauka.Size = new System.Drawing.Size(188, 52);
            this.button_nauka.TabIndex = 2;
            this.button_nauka.Text = "Testuj";
            this.button_nauka.UseVisualStyleBackColor = true;
            this.button_nauka.Visible = false;
            this.button_nauka.Click += new System.EventHandler(this.nauka_Click);
            // 
            // button_prognozuj
            // 
            this.button_prognozuj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_prognozuj.Enabled = false;
            this.button_prognozuj.Location = new System.Drawing.Point(979, 264);
            this.button_prognozuj.Name = "button_prognozuj";
            this.button_prognozuj.Size = new System.Drawing.Size(188, 50);
            this.button_prognozuj.TabIndex = 3;
            this.button_prognozuj.Text = "Nauka";
            this.button_prognozuj.UseVisualStyleBackColor = true;
            this.button_prognozuj.Visible = false;
            this.button_prognozuj.Click += new System.EventHandler(this.prognozuj_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox_ilosc_danych
            // 
            this.comboBox_ilosc_danych.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ilosc_danych.FormattingEnabled = true;
            this.comboBox_ilosc_danych.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_ilosc_danych.Location = new System.Drawing.Point(28, 54);
            this.comboBox_ilosc_danych.Name = "comboBox_ilosc_danych";
            this.comboBox_ilosc_danych.Size = new System.Drawing.Size(140, 21);
            this.comboBox_ilosc_danych.TabIndex = 4;
            // 
            // comboBox_pierwsza_warstwa
            // 
            this.comboBox_pierwsza_warstwa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_pierwsza_warstwa.FormattingEnabled = true;
            this.comboBox_pierwsza_warstwa.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_pierwsza_warstwa.Location = new System.Drawing.Point(242, 54);
            this.comboBox_pierwsza_warstwa.Name = "comboBox_pierwsza_warstwa";
            this.comboBox_pierwsza_warstwa.Size = new System.Drawing.Size(149, 21);
            this.comboBox_pierwsza_warstwa.TabIndex = 5;
            // 
            // comboBox_druga_warstwa
            // 
            this.comboBox_druga_warstwa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_druga_warstwa.FormattingEnabled = true;
            this.comboBox_druga_warstwa.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_druga_warstwa.Location = new System.Drawing.Point(439, 54);
            this.comboBox_druga_warstwa.Name = "comboBox_druga_warstwa";
            this.comboBox_druga_warstwa.Size = new System.Drawing.Size(140, 21);
            this.comboBox_druga_warstwa.TabIndex = 6;
            // 
            // label_nowa_ilosc_danych
            // 
            this.label_nowa_ilosc_danych.AutoSize = true;
            this.label_nowa_ilosc_danych.Location = new System.Drawing.Point(65, 38);
            this.label_nowa_ilosc_danych.Name = "label_nowa_ilosc_danych";
            this.label_nowa_ilosc_danych.Size = new System.Drawing.Size(67, 13);
            this.label_nowa_ilosc_danych.TabIndex = 7;
            this.label_nowa_ilosc_danych.Text = "Ilość danych";
            // 
            // label_nowa_pierwsza_warstwa
            // 
            this.label_nowa_pierwsza_warstwa.AutoSize = true;
            this.label_nowa_pierwsza_warstwa.Location = new System.Drawing.Point(266, 38);
            this.label_nowa_pierwsza_warstwa.Name = "label_nowa_pierwsza_warstwa";
            this.label_nowa_pierwsza_warstwa.Size = new System.Drawing.Size(91, 13);
            this.label_nowa_pierwsza_warstwa.TabIndex = 8;
            this.label_nowa_pierwsza_warstwa.Text = "Pierwsza warstwa";
            // 
            // label_nowa_druga_warstwa
            // 
            this.label_nowa_druga_warstwa.AutoSize = true;
            this.label_nowa_druga_warstwa.Location = new System.Drawing.Point(470, 35);
            this.label_nowa_druga_warstwa.Name = "label_nowa_druga_warstwa";
            this.label_nowa_druga_warstwa.Size = new System.Drawing.Size(78, 13);
            this.label_nowa_druga_warstwa.TabIndex = 9;
            this.label_nowa_druga_warstwa.Text = "Druga warstwa";
            // 
            // button_zatwierdz_nowa_siec
            // 
            this.button_zatwierdz_nowa_siec.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button_zatwierdz_nowa_siec.Location = new System.Drawing.Point(282, 91);
            this.button_zatwierdz_nowa_siec.Name = "button_zatwierdz_nowa_siec";
            this.button_zatwierdz_nowa_siec.Size = new System.Drawing.Size(75, 23);
            this.button_zatwierdz_nowa_siec.TabIndex = 10;
            this.button_zatwierdz_nowa_siec.Text = "Zatwierdź";
            this.button_zatwierdz_nowa_siec.UseVisualStyleBackColor = true;
            this.button_zatwierdz_nowa_siec.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_wynik_prognozowany
            // 
            this.label_wynik_prognozowany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_wynik_prognozowany.AutoSize = true;
            this.label_wynik_prognozowany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_wynik_prognozowany.Location = new System.Drawing.Point(4, 17);
            this.label_wynik_prognozowany.Name = "label_wynik_prognozowany";
            this.label_wynik_prognozowany.Size = new System.Drawing.Size(272, 25);
            this.label_wynik_prognozowany.TabIndex = 11;
            this.label_wynik_prognozowany.Text = "Wynik prognozowany:";
            this.label_wynik_prognozowany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_wynik_prognozowany.Visible = false;
            // 
            // label_wartosc_wynik_prognozowany
            // 
            this.label_wartosc_wynik_prognozowany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_wartosc_wynik_prognozowany.AutoSize = true;
            this.label_wartosc_wynik_prognozowany.Location = new System.Drawing.Point(4, 82);
            this.label_wartosc_wynik_prognozowany.Name = "label_wartosc_wynik_prognozowany";
            this.label_wartosc_wynik_prognozowany.Size = new System.Drawing.Size(272, 13);
            this.label_wartosc_wynik_prognozowany.TabIndex = 12;
            this.label_wartosc_wynik_prognozowany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_wartosc_wynik_prognozowany.Visible = false;
            // 
            // panel_konfiguracja
            // 
            this.panel_konfiguracja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_konfiguracja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_konfiguracja.Controls.Add(this.panel_wczytaj_siec);
            this.panel_konfiguracja.Controls.Add(this.panel_nowa_siec);
            this.panel_konfiguracja.Controls.Add(this.label_konfiguracja_sieci);
            this.panel_konfiguracja.Location = new System.Drawing.Point(12, 12);
            this.panel_konfiguracja.Name = "panel_konfiguracja";
            this.panel_konfiguracja.Size = new System.Drawing.Size(1235, 164);
            this.panel_konfiguracja.TabIndex = 13;
            // 
            // panel_wczytaj_siec
            // 
            this.panel_wczytaj_siec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_wczytaj_siec.AutoSize = true;
            this.panel_wczytaj_siec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_wczytaj_siec.Controls.Add(this.label_wczytaj_siec);
            this.panel_wczytaj_siec.Controls.Add(this.button_wczytaj_siec);
            this.panel_wczytaj_siec.Location = new System.Drawing.Point(624, 40);
            this.panel_wczytaj_siec.Name = "panel_wczytaj_siec";
            this.panel_wczytaj_siec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel_wczytaj_siec.Size = new System.Drawing.Size(598, 117);
            this.panel_wczytaj_siec.TabIndex = 21;
            // 
            // label_wczytaj_siec
            // 
            this.label_wczytaj_siec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_wczytaj_siec.AutoSize = true;
            this.label_wczytaj_siec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_wczytaj_siec.Location = new System.Drawing.Point(239, 23);
            this.label_wczytaj_siec.Name = "label_wczytaj_siec";
            this.label_wczytaj_siec.Size = new System.Drawing.Size(133, 25);
            this.label_wczytaj_siec.TabIndex = 14;
            this.label_wczytaj_siec.Text = "Wczytaj sieć";
            this.label_wczytaj_siec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_wczytaj_siec
            // 
            this.button_wczytaj_siec.Location = new System.Drawing.Point(272, 72);
            this.button_wczytaj_siec.Name = "button_wczytaj_siec";
            this.button_wczytaj_siec.Size = new System.Drawing.Size(75, 23);
            this.button_wczytaj_siec.TabIndex = 12;
            this.button_wczytaj_siec.Text = "Wczytaj";
            this.button_wczytaj_siec.UseVisualStyleBackColor = true;
            this.button_wczytaj_siec.Click += new System.EventHandler(this.button_wczytaj_siec_Click);
            // 
            // panel_nowa_siec
            // 
            this.panel_nowa_siec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_nowa_siec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_nowa_siec.Controls.Add(this.button_zatwierdz_nowa_siec);
            this.panel_nowa_siec.Controls.Add(this.label_nowa_ilosc_danych);
            this.panel_nowa_siec.Controls.Add(this.label_nowa_siec);
            this.panel_nowa_siec.Controls.Add(this.comboBox_ilosc_danych);
            this.panel_nowa_siec.Controls.Add(this.comboBox_druga_warstwa);
            this.panel_nowa_siec.Controls.Add(this.comboBox_pierwsza_warstwa);
            this.panel_nowa_siec.Controls.Add(this.label_nowa_druga_warstwa);
            this.panel_nowa_siec.Controls.Add(this.label_nowa_pierwsza_warstwa);
            this.panel_nowa_siec.Location = new System.Drawing.Point(3, 40);
            this.panel_nowa_siec.Name = "panel_nowa_siec";
            this.panel_nowa_siec.Size = new System.Drawing.Size(615, 119);
            this.panel_nowa_siec.TabIndex = 20;
            // 
            // label_nowa_siec
            // 
            this.label_nowa_siec.AutoSize = true;
            this.label_nowa_siec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nowa_siec.Location = new System.Drawing.Point(264, 0);
            this.label_nowa_siec.Name = "label_nowa_siec";
            this.label_nowa_siec.Size = new System.Drawing.Size(111, 25);
            this.label_nowa_siec.TabIndex = 13;
            this.label_nowa_siec.Text = "Nowa sieć";
            // 
            // label_konfiguracja_sieci
            // 
            this.label_konfiguracja_sieci.AutoSize = true;
            this.label_konfiguracja_sieci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_konfiguracja_sieci.Location = new System.Drawing.Point(542, 9);
            this.label_konfiguracja_sieci.Name = "label_konfiguracja_sieci";
            this.label_konfiguracja_sieci.Size = new System.Drawing.Size(153, 20);
            this.label_konfiguracja_sieci.TabIndex = 11;
            this.label_konfiguracja_sieci.Text = "Konfiguracja Sieci";
            // 
            // label_ilosc_danych
            // 
            this.label_ilosc_danych.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ilosc_danych.AutoSize = true;
            this.label_ilosc_danych.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ilosc_danych.Location = new System.Drawing.Point(4, 18);
            this.label_ilosc_danych.Name = "label_ilosc_danych";
            this.label_ilosc_danych.Size = new System.Drawing.Size(120, 13);
            this.label_ilosc_danych.TabIndex = 14;
            this.label_ilosc_danych.Text = "Ilość danych";
            this.label_ilosc_danych.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_ilosc_danych.Visible = false;
            // 
            // label_pierwsza_warstwa
            // 
            this.label_pierwsza_warstwa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_pierwsza_warstwa.AutoSize = true;
            this.label_pierwsza_warstwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_pierwsza_warstwa.Location = new System.Drawing.Point(131, 18);
            this.label_pierwsza_warstwa.Name = "label_pierwsza_warstwa";
            this.label_pierwsza_warstwa.Size = new System.Drawing.Size(120, 13);
            this.label_pierwsza_warstwa.TabIndex = 15;
            this.label_pierwsza_warstwa.Text = "Pierwsza warstwa";
            this.label_pierwsza_warstwa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_pierwsza_warstwa.Visible = false;
            // 
            // label_druga_warstwa
            // 
            this.label_druga_warstwa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_druga_warstwa.AutoSize = true;
            this.label_druga_warstwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_druga_warstwa.Location = new System.Drawing.Point(258, 18);
            this.label_druga_warstwa.Name = "label_druga_warstwa";
            this.label_druga_warstwa.Size = new System.Drawing.Size(120, 13);
            this.label_druga_warstwa.TabIndex = 16;
            this.label_druga_warstwa.Text = "Druga Warstwa";
            this.label_druga_warstwa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_wartosc_ilosc_danych
            // 
            this.label_wartosc_ilosc_danych.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_wartosc_ilosc_danych.AutoSize = true;
            this.label_wartosc_ilosc_danych.Location = new System.Drawing.Point(4, 68);
            this.label_wartosc_ilosc_danych.Name = "label_wartosc_ilosc_danych";
            this.label_wartosc_ilosc_danych.Size = new System.Drawing.Size(120, 13);
            this.label_wartosc_ilosc_danych.TabIndex = 17;
            this.label_wartosc_ilosc_danych.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_wartosc_pierwsza_warstwa
            // 
            this.label_wartosc_pierwsza_warstwa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_wartosc_pierwsza_warstwa.AutoSize = true;
            this.label_wartosc_pierwsza_warstwa.Location = new System.Drawing.Point(131, 68);
            this.label_wartosc_pierwsza_warstwa.Name = "label_wartosc_pierwsza_warstwa";
            this.label_wartosc_pierwsza_warstwa.Size = new System.Drawing.Size(120, 13);
            this.label_wartosc_pierwsza_warstwa.TabIndex = 18;
            this.label_wartosc_pierwsza_warstwa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_wartosc_druga_warstwa
            // 
            this.label_wartosc_druga_warstwa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_wartosc_druga_warstwa.AutoSize = true;
            this.label_wartosc_druga_warstwa.Location = new System.Drawing.Point(258, 68);
            this.label_wartosc_druga_warstwa.Name = "label_wartosc_druga_warstwa";
            this.label_wartosc_druga_warstwa.Size = new System.Drawing.Size(120, 13);
            this.label_wartosc_druga_warstwa.TabIndex = 19;
            this.label_wartosc_druga_warstwa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_dane
            // 
            this.tableLayoutPanel_dane.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_dane.ColumnCount = 4;
            this.tableLayoutPanel_dane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_dane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_dane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_dane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_dane.Controls.Add(this.label_ilosc_danych, 0, 0);
            this.tableLayoutPanel_dane.Controls.Add(this.label_pierwsza_warstwa, 1, 0);
            this.tableLayoutPanel_dane.Controls.Add(this.label_wartosc_pierwsza_warstwa, 1, 1);
            this.tableLayoutPanel_dane.Controls.Add(this.label_wartosc_druga_warstwa, 2, 1);
            this.tableLayoutPanel_dane.Controls.Add(this.label_druga_warstwa, 2, 0);
            this.tableLayoutPanel_dane.Controls.Add(this.label_ilosc_nauk, 3, 0);
            this.tableLayoutPanel_dane.Controls.Add(this.label_wartosc_ilosc_nauk, 3, 1);
            this.tableLayoutPanel_dane.Controls.Add(this.label_wartosc_ilosc_danych, 0, 1);
            this.tableLayoutPanel_dane.Location = new System.Drawing.Point(55, 183);
            this.tableLayoutPanel_dane.Name = "tableLayoutPanel_dane";
            this.tableLayoutPanel_dane.RowCount = 2;
            this.tableLayoutPanel_dane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_dane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_dane.Size = new System.Drawing.Size(510, 100);
            this.tableLayoutPanel_dane.TabIndex = 21;
            this.tableLayoutPanel_dane.Visible = false;
            // 
            // label_ilosc_nauk
            // 
            this.label_ilosc_nauk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ilosc_nauk.AutoSize = true;
            this.label_ilosc_nauk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ilosc_nauk.Location = new System.Drawing.Point(385, 18);
            this.label_ilosc_nauk.Name = "label_ilosc_nauk";
            this.label_ilosc_nauk.Size = new System.Drawing.Size(121, 13);
            this.label_ilosc_nauk.TabIndex = 20;
            this.label_ilosc_nauk.Text = "Ilość epok";
            this.label_ilosc_nauk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_ilosc_nauk.Visible = false;
            // 
            // label_wartosc_ilosc_nauk
            // 
            this.label_wartosc_ilosc_nauk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_wartosc_ilosc_nauk.AutoSize = true;
            this.label_wartosc_ilosc_nauk.Location = new System.Drawing.Point(385, 68);
            this.label_wartosc_ilosc_nauk.Name = "label_wartosc_ilosc_nauk";
            this.label_wartosc_ilosc_nauk.Size = new System.Drawing.Size(121, 13);
            this.label_wartosc_ilosc_nauk.TabIndex = 21;
            this.label_wartosc_ilosc_nauk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_zakoncz_symulacje
            // 
            this.button_zakoncz_symulacje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_zakoncz_symulacje.Location = new System.Drawing.Point(979, 418);
            this.button_zakoncz_symulacje.Name = "button_zakoncz_symulacje";
            this.button_zakoncz_symulacje.Size = new System.Drawing.Size(188, 52);
            this.button_zakoncz_symulacje.TabIndex = 22;
            this.button_zakoncz_symulacje.Text = "Zakończ symulacje";
            this.button_zakoncz_symulacje.UseVisualStyleBackColor = true;
            this.button_zakoncz_symulacje.Visible = false;
            this.button_zakoncz_symulacje.Click += new System.EventHandler(this.button_zakoncz_symulacje_Click);
            // 
            // tableLayoutPanel_siec
            // 
            this.tableLayoutPanel_siec.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_siec.ColumnCount = 1;
            this.tableLayoutPanel_siec.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_siec.Controls.Add(this.label_nazwa_sieci, 0, 0);
            this.tableLayoutPanel_siec.Controls.Add(this.label_wartosc_nazwa_sieci, 0, 1);
            this.tableLayoutPanel_siec.Location = new System.Drawing.Point(659, 182);
            this.tableLayoutPanel_siec.Name = "tableLayoutPanel_siec";
            this.tableLayoutPanel_siec.RowCount = 2;
            this.tableLayoutPanel_siec.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_siec.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_siec.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel_siec.TabIndex = 22;
            this.tableLayoutPanel_siec.Visible = false;
            // 
            // label_nazwa_sieci
            // 
            this.label_nazwa_sieci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_nazwa_sieci.AutoSize = true;
            this.label_nazwa_sieci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nazwa_sieci.Location = new System.Drawing.Point(4, 17);
            this.label_nazwa_sieci.Name = "label_nazwa_sieci";
            this.label_nazwa_sieci.Size = new System.Drawing.Size(192, 16);
            this.label_nazwa_sieci.TabIndex = 0;
            this.label_nazwa_sieci.Text = "Nazwa sieci";
            this.label_nazwa_sieci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_wartosc_nazwa_sieci
            // 
            this.label_wartosc_nazwa_sieci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_wartosc_nazwa_sieci.AutoSize = true;
            this.label_wartosc_nazwa_sieci.Location = new System.Drawing.Point(4, 68);
            this.label_wartosc_nazwa_sieci.Name = "label_wartosc_nazwa_sieci";
            this.label_wartosc_nazwa_sieci.Size = new System.Drawing.Size(192, 13);
            this.label_wartosc_nazwa_sieci.TabIndex = 1;
            this.label_wartosc_nazwa_sieci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_wyniki
            // 
            this.tableLayoutPanel_wyniki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_wyniki.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_wyniki.ColumnCount = 1;
            this.tableLayoutPanel_wyniki.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_wyniki.Controls.Add(this.label_wynik_prognozowany, 0, 0);
            this.tableLayoutPanel_wyniki.Controls.Add(this.label_wartosc_wynik_prognozowany, 0, 1);
            this.tableLayoutPanel_wyniki.Controls.Add(this.label_wynik_oczekiwany, 0, 2);
            this.tableLayoutPanel_wyniki.Controls.Add(this.label_wartosc_wynik_oczekiwany, 0, 3);
            this.tableLayoutPanel_wyniki.Location = new System.Drawing.Point(933, 491);
            this.tableLayoutPanel_wyniki.Name = "tableLayoutPanel_wyniki";
            this.tableLayoutPanel_wyniki.RowCount = 4;
            this.tableLayoutPanel_wyniki.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_wyniki.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_wyniki.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_wyniki.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_wyniki.Size = new System.Drawing.Size(280, 238);
            this.tableLayoutPanel_wyniki.TabIndex = 23;
            this.tableLayoutPanel_wyniki.Visible = false;
            // 
            // label_wynik_oczekiwany
            // 
            this.label_wynik_oczekiwany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_wynik_oczekiwany.AutoSize = true;
            this.label_wynik_oczekiwany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_wynik_oczekiwany.Location = new System.Drawing.Point(4, 135);
            this.label_wynik_oczekiwany.Name = "label_wynik_oczekiwany";
            this.label_wynik_oczekiwany.Size = new System.Drawing.Size(272, 25);
            this.label_wynik_oczekiwany.TabIndex = 13;
            this.label_wynik_oczekiwany.Text = "Wynik oczekiwany:";
            this.label_wynik_oczekiwany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_wartosc_wynik_oczekiwany
            // 
            this.label_wartosc_wynik_oczekiwany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_wartosc_wynik_oczekiwany.AutoSize = true;
            this.label_wartosc_wynik_oczekiwany.Location = new System.Drawing.Point(4, 201);
            this.label_wartosc_wynik_oczekiwany.Name = "label_wartosc_wynik_oczekiwany";
            this.label_wartosc_wynik_oczekiwany.Size = new System.Drawing.Size(272, 13);
            this.label_wartosc_wynik_oczekiwany.TabIndex = 14;
            this.label_wartosc_wynik_oczekiwany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1076, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 56);
            this.button1.TabIndex = 24;
            this.button1.Text = "Wczytaj dane testowe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // combobox_ilosc_nauk
            // 
            this.combobox_ilosc_nauk.Location = new System.Drawing.Point(873, 281);
            this.combobox_ilosc_nauk.Name = "combobox_ilosc_nauk";
            this.combobox_ilosc_nauk.Size = new System.Drawing.Size(100, 20);
            this.combobox_ilosc_nauk.TabIndex = 25;
            // 
            // WigGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this.combobox_ilosc_nauk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel_wyniki);
            this.Controls.Add(this.tableLayoutPanel_siec);
            this.Controls.Add(this.button_zakoncz_symulacje);
            this.Controls.Add(this.tableLayoutPanel_dane);
            this.Controls.Add(this.panel_konfiguracja);
            this.Controls.Add(this.button_prognozuj);
            this.Controls.Add(this.button_nauka);
            this.Controls.Add(this.button_wczytaj_dane);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WigGui";
            this.Text = "Sieć neuronowa - WIG";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel_konfiguracja.ResumeLayout(false);
            this.panel_konfiguracja.PerformLayout();
            this.panel_wczytaj_siec.ResumeLayout(false);
            this.panel_wczytaj_siec.PerformLayout();
            this.panel_nowa_siec.ResumeLayout(false);
            this.panel_nowa_siec.PerformLayout();
            this.tableLayoutPanel_dane.ResumeLayout(false);
            this.tableLayoutPanel_dane.PerformLayout();
            this.tableLayoutPanel_siec.ResumeLayout(false);
            this.tableLayoutPanel_siec.PerformLayout();
            this.tableLayoutPanel_wyniki.ResumeLayout(false);
            this.tableLayoutPanel_wyniki.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button_wczytaj_dane;
        private System.Windows.Forms.Button button_nauka;
        private System.Windows.Forms.Button button_prognozuj;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox_ilosc_danych;
        private System.Windows.Forms.ComboBox comboBox_pierwsza_warstwa;
        private System.Windows.Forms.ComboBox comboBox_druga_warstwa;
        private System.Windows.Forms.Label label_nowa_ilosc_danych;
        private System.Windows.Forms.Label label_nowa_pierwsza_warstwa;
        private System.Windows.Forms.Label label_nowa_druga_warstwa;
        private System.Windows.Forms.Button button_zatwierdz_nowa_siec;
        private System.Windows.Forms.Label label_wynik_prognozowany;
        private System.Windows.Forms.Label label_wartosc_wynik_prognozowany;
        private System.Windows.Forms.Panel panel_konfiguracja;
        private System.Windows.Forms.Label label_ilosc_danych;
        private System.Windows.Forms.Label label_pierwsza_warstwa;
        private System.Windows.Forms.Label label_druga_warstwa;
        private System.Windows.Forms.Label label_wartosc_ilosc_danych;
        private System.Windows.Forms.Label label_wartosc_pierwsza_warstwa;
        private System.Windows.Forms.Label label_wartosc_druga_warstwa;
        private System.Windows.Forms.Button button_wczytaj_siec;
        private System.Windows.Forms.Label label_konfiguracja_sieci;
        private System.Windows.Forms.Label label_wczytaj_siec;
        private System.Windows.Forms.Label label_nowa_siec;
        private System.Windows.Forms.Panel panel_nowa_siec;
        private System.Windows.Forms.Panel panel_wczytaj_siec;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_dane;
        private System.Windows.Forms.Label label_ilosc_nauk;
        private System.Windows.Forms.Label label_wartosc_ilosc_nauk;
        private System.Windows.Forms.Button button_zakoncz_symulacje;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_siec;
        private System.Windows.Forms.Label label_nazwa_sieci;
        private System.Windows.Forms.Label label_wartosc_nazwa_sieci;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_wyniki;
        private System.Windows.Forms.Label label_wynik_oczekiwany;
        private System.Windows.Forms.Label label_wartosc_wynik_oczekiwany;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox combobox_ilosc_nauk;
    }
}