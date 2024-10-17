namespace Baist_kayıt_arayüzü
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            İsimsoyisim = new TextBox();
            telno = new TextBox();
            textBox3 = new TextBox();
            Evadresi = new TextBox();
            Adres = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold);
            label1.Location = new Point(437, 75);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 0;
            label1.Text = "Adı Soyadı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold);
            label2.Location = new Point(374, 123);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 1;
            label2.Text = "Telefon numarası";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold);
            label3.Location = new Point(362, 188);
            label3.Name = "label3";
            label3.Size = new Size(186, 25);
            label3.TabIndex = 2;
            label3.Text = "Tc kimlik numarası";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold);
            label4.Location = new Point(403, 244);
            label4.Name = "label4";
            label4.Size = new Size(145, 25);
            label4.TabIndex = 3;
            label4.Text = "Yaşadığı şehir";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold);
            label5.Location = new Point(452, 295);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 4;
            label5.Text = "Ev adresi";
            // 
            // İsimsoyisim
            // 
            İsimsoyisim.Location = new Point(580, 73);
            İsimsoyisim.Name = "İsimsoyisim";
            İsimsoyisim.Size = new Size(265, 27);
            İsimsoyisim.TabIndex = 5;
            // 
            // telno
            // 
            telno.Location = new Point(580, 124);
            telno.Name = "telno";
            telno.Size = new Size(265, 27);
            telno.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(580, 186);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(265, 27);
            textBox3.TabIndex = 7;
            // 
            // Evadresi
            // 
            Evadresi.Location = new Point(580, 295);
            Evadresi.Multiline = true;
            Evadresi.Name = "Evadresi";
            Evadresi.Size = new Size(265, 90);
            Evadresi.TabIndex = 8;
            // 
            // Adres
            // 
            Adres.FormattingEnabled = true;
            Adres.Items.AddRange(new object[] { "İstanbul", "Ankara", "İzmir" });
            Adres.Location = new Point(580, 244);
            Adres.Name = "Adres";
            Adres.Size = new Size(265, 28);
            Adres.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(751, 421);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Kayıt ol";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1378, 511);
            Controls.Add(button1);
            Controls.Add(Adres);
            Controls.Add(Evadresi);
            Controls.Add(textBox3);
            Controls.Add(telno);
            Controls.Add(İsimsoyisim);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox telno;
        private TextBox textBox3;
        private TextBox Evadresi;
        private ComboBox Adres;
        private Button button1;
        public TextBox İsimsoyisim;
    }
}
