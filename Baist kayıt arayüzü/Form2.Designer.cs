namespace Baist_kayıt_arayüzü
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            İsimsoyisminiz = new Label();
            Soyadınız = new Label();
            Telefonno = new Label();
            Yaşadığınızsehirtitle = new Label();
            Yasadiginizsehir = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 54);
            label1.Name = "label1";
            label1.Size = new Size(231, 30);
            label1.TabIndex = 0;
            label1.Text = "Kaydınız tamamlandı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(155, 128);
            label2.Name = "label2";
            label2.Size = new Size(78, 30);
            label2.TabIndex = 1;
            label2.Text = "Adınız";
            // 
            // İsimsoyisminiz
            // 
            İsimsoyisminiz.AutoSize = true;
            İsimsoyisminiz.Font = new Font("Segoe UI Symbol", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            İsimsoyisminiz.Location = new Point(270, 128);
            İsimsoyisminiz.Name = "İsimsoyisminiz";
            İsimsoyisminiz.Size = new Size(0, 30);
            İsimsoyisminiz.TabIndex = 2;
            // 
            // Soyadınız
            // 
            Soyadınız.AutoSize = true;
            Soyadınız.Font = new Font("Segoe UI Symbol", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Soyadınız.Location = new Point(50, 186);
            Soyadınız.Name = "Soyadınız";
            Soyadınız.Size = new Size(183, 30);
            Soyadınız.TabIndex = 3;
            Soyadınız.Text = "Telefon numrası";
            // 
            // Telefonno
            // 
            Telefonno.AutoSize = true;
            Telefonno.Font = new Font("Segoe UI Symbol", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Telefonno.Location = new Point(270, 186);
            Telefonno.Name = "Telefonno";
            Telefonno.Size = new Size(0, 30);
            Telefonno.TabIndex = 4;
            // 
            // Yaşadığınızsehirtitle
            // 
            Yaşadığınızsehirtitle.AutoSize = true;
            Yaşadığınızsehirtitle.Font = new Font("Segoe UI Symbol", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Yaşadığınızsehirtitle.Location = new Point(42, 247);
            Yaşadığınızsehirtitle.Name = "Yaşadığınızsehirtitle";
            Yaşadığınızsehirtitle.Size = new Size(191, 30);
            Yaşadığınızsehirtitle.TabIndex = 5;
            Yaşadığınızsehirtitle.Text = "Yaşadığınız şehir";
            // 
            // Yasadiginizsehir
            // 
            Yasadiginizsehir.AutoSize = true;
            Yasadiginizsehir.Font = new Font("Segoe UI Symbol", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Yasadiginizsehir.Location = new Point(270, 247);
            Yasadiginizsehir.Name = "Yasadiginizsehir";
            Yasadiginizsehir.Size = new Size(0, 30);
            Yasadiginizsehir.TabIndex = 6;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Yasadiginizsehir);
            Controls.Add(Yaşadığınızsehirtitle);
            Controls.Add(Telefonno);
            Controls.Add(Soyadınız);
            Controls.Add(İsimsoyisminiz);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label Soyadınız;
        private Label Yaşadığınızsehirtitle;
        public Label İsimsoyisminiz;
        public Label Telefonno;
        public Label Yasadiginizsehir;
    }
}