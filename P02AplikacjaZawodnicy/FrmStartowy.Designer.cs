namespace P02AplikacjaZawodnicy
{
    partial class FrmStartowy
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.btnSzczegoly = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtSzukaj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chWykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rbSortujImie = new System.Windows.Forms.RadioButton();
            this.rbSortujNazwisko = new System.Windows.Forms.RadioButton();
            this.rbSortujKraj = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.numStrona = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLiczbaStron = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chWykres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStrona)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(12, 67);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(344, 251);
            this.lbDane.TabIndex = 0;
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(12, 12);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // btnSzczegoly
            // 
            this.btnSzczegoly.Location = new System.Drawing.Point(228, 12);
            this.btnSzczegoly.Name = "btnSzczegoly";
            this.btnSzczegoly.Size = new System.Drawing.Size(128, 23);
            this.btnSzczegoly.TabIndex = 2;
            this.btnSzczegoly.Text = "Pokaż szczegóły";
            this.btnSzczegoly.UseVisualStyleBackColor = true;
            this.btnSzczegoly.Click += new System.EventHandler(this.btnSzczegoly_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(93, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtSzukaj
            // 
            this.txtSzukaj.Location = new System.Drawing.Point(57, 41);
            this.txtSzukaj.Name = "txtSzukaj";
            this.txtSzukaj.Size = new System.Drawing.Size(299, 20);
            this.txtSzukaj.TabIndex = 4;
            this.txtSzukaj.TextChanged += new System.EventHandler(this.txtSzukaj_TextChanged);
            this.txtSzukaj.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSzukaj_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Szukaj";
            // 
            // chWykres
            // 
            chartArea4.Name = "ChartArea1";
            this.chWykres.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chWykres.Legends.Add(legend4);
            this.chWykres.Location = new System.Drawing.Point(381, 126);
            this.chWykres.Name = "chWykres";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chWykres.Series.Add(series4);
            this.chWykres.Size = new System.Drawing.Size(291, 186);
            this.chWykres.TabIndex = 6;
            this.chWykres.Text = "chart1";
            // 
            // rbSortujImie
            // 
            this.rbSortujImie.AutoSize = true;
            this.rbSortujImie.Location = new System.Drawing.Point(391, 44);
            this.rbSortujImie.Name = "rbSortujImie";
            this.rbSortujImie.Size = new System.Drawing.Size(44, 17);
            this.rbSortujImie.TabIndex = 7;
            this.rbSortujImie.TabStop = true;
            this.rbSortujImie.Text = "Imie";
            this.rbSortujImie.UseVisualStyleBackColor = true;
            this.rbSortujImie.CheckedChanged += new System.EventHandler(this.rbSortuj_CheckedChanged);
            // 
            // rbSortujNazwisko
            // 
            this.rbSortujNazwisko.AutoSize = true;
            this.rbSortujNazwisko.Location = new System.Drawing.Point(391, 67);
            this.rbSortujNazwisko.Name = "rbSortujNazwisko";
            this.rbSortujNazwisko.Size = new System.Drawing.Size(71, 17);
            this.rbSortujNazwisko.TabIndex = 8;
            this.rbSortujNazwisko.TabStop = true;
            this.rbSortujNazwisko.Text = "Nazwisko";
            this.rbSortujNazwisko.UseVisualStyleBackColor = true;
            this.rbSortujNazwisko.CheckedChanged += new System.EventHandler(this.rbSortuj_CheckedChanged);
            // 
            // rbSortujKraj
            // 
            this.rbSortujKraj.AutoSize = true;
            this.rbSortujKraj.Location = new System.Drawing.Point(391, 90);
            this.rbSortujKraj.Name = "rbSortujKraj";
            this.rbSortujKraj.Size = new System.Drawing.Size(43, 17);
            this.rbSortujKraj.TabIndex = 9;
            this.rbSortujKraj.TabStop = true;
            this.rbSortujKraj.Text = "Kraj";
            this.rbSortujKraj.UseVisualStyleBackColor = true;
            this.rbSortujKraj.CheckedChanged += new System.EventHandler(this.rbSortuj_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sortowanie";
            // 
            // numStrona
            // 
            this.numStrona.Location = new System.Drawing.Point(143, 324);
            this.numStrona.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStrona.Name = "numStrona";
            this.numStrona.Size = new System.Drawing.Size(44, 20);
            this.numStrona.TabIndex = 11;
            this.numStrona.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStrona.ValueChanged += new System.EventHandler(this.numStrona_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Strona";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "z";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLiczbaStron
            // 
            this.lblLiczbaStron.AutoSize = true;
            this.lblLiczbaStron.Location = new System.Drawing.Point(211, 326);
            this.lblLiczbaStron.Name = "lblLiczbaStron";
            this.lblLiczbaStron.Size = new System.Drawing.Size(63, 13);
            this.lblLiczbaStron.TabIndex = 14;
            this.lblLiczbaStron.Text = "LiczbaStron";
            this.lblLiczbaStron.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmStartowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 355);
            this.Controls.Add(this.lblLiczbaStron);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numStrona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbSortujKraj);
            this.Controls.Add(this.rbSortujNazwisko);
            this.Controls.Add(this.rbSortujImie);
            this.Controls.Add(this.chWykres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSzukaj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnSzczegoly);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.lbDane);
            this.Name = "FrmStartowy";
            this.Text = "Zawodnicy";
            ((System.ComponentModel.ISupportInitialize)(this.chWykres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStrona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Button btnSzczegoly;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtSzukaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chWykres;
        private System.Windows.Forms.RadioButton rbSortujImie;
        private System.Windows.Forms.RadioButton rbSortujNazwisko;
        private System.Windows.Forms.RadioButton rbSortujKraj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numStrona;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLiczbaStron;
    }
}

