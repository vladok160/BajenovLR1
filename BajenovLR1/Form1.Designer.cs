namespace BajenovLR1
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
            this.label4 = new System.Windows.Forms.Label();
            this.TimeOfDoing = new System.Windows.Forms.Label();
            this.ErrorRate = new System.Windows.Forms.Label();
            this.Iterations = new System.Windows.Forms.Label();
            this.ResultF = new System.Windows.Forms.Label();
            this.ResultX = new System.Windows.Forms.Label();
            this.StartSekuchMethod = new System.Windows.Forms.Button();
            this.StartNuRafMethod = new System.Windows.Forms.Button();
            this.StartKasanieMethod = new System.Windows.Forms.Button();
            this.StartFibonaciMethod = new System.Windows.Forms.Button();
            this.StartGoldSearchMethod = new System.Windows.Forms.Button();
            this.StartDihotomiaMethod = new System.Windows.Forms.Button();
            this.StartPassiveSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Epsilon = new System.Windows.Forms.TextBox();
            this.X1 = new System.Windows.Forms.TextBox();
            this.X0 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "%";
            // 
            // TimeOfDoing
            // 
            this.TimeOfDoing.AutoSize = true;
            this.TimeOfDoing.Location = new System.Drawing.Point(299, 78);
            this.TimeOfDoing.Name = "TimeOfDoing";
            this.TimeOfDoing.Size = new System.Drawing.Size(114, 15);
            this.TimeOfDoing.TabIndex = 36;
            this.TimeOfDoing.Text = "Время выполнения";
            // 
            // ErrorRate
            // 
            this.ErrorRate.AutoSize = true;
            this.ErrorRate.Location = new System.Drawing.Point(299, 36);
            this.ErrorRate.Name = "ErrorRate";
            this.ErrorRate.Size = new System.Drawing.Size(83, 15);
            this.ErrorRate.TabIndex = 35;
            this.ErrorRate.Text = "Погрешность";
            // 
            // Iterations
            // 
            this.Iterations.AutoSize = true;
            this.Iterations.Location = new System.Drawing.Point(142, 119);
            this.Iterations.Name = "Iterations";
            this.Iterations.Size = new System.Drawing.Size(127, 15);
            this.Iterations.TabIndex = 34;
            this.Iterations.Text = "Количество итераций";
            // 
            // ResultF
            // 
            this.ResultF.AutoSize = true;
            this.ResultF.Location = new System.Drawing.Point(142, 78);
            this.ResultF.Name = "ResultF";
            this.ResultF.Size = new System.Drawing.Size(69, 15);
            this.ResultF.TabIndex = 33;
            this.ResultF.Text = "Результат F";
            // 
            // ResultX
            // 
            this.ResultX.AutoSize = true;
            this.ResultX.Location = new System.Drawing.Point(142, 36);
            this.ResultX.Name = "ResultX";
            this.ResultX.Size = new System.Drawing.Size(70, 15);
            this.ResultX.TabIndex = 32;
            this.ResultX.Text = "Результат X";
            // 
            // StartSekuchMethod
            // 
            this.StartSekuchMethod.Location = new System.Drawing.Point(327, 244);
            this.StartSekuchMethod.Name = "StartSekuchMethod";
            this.StartSekuchMethod.Size = new System.Drawing.Size(99, 55);
            this.StartSekuchMethod.TabIndex = 31;
            this.StartSekuchMethod.Text = "Метод секущих";
            this.StartSekuchMethod.UseVisualStyleBackColor = true;
            this.StartSekuchMethod.Click += new System.EventHandler(this.StartSekuchMethod_Click);
            // 
            // StartNuRafMethod
            // 
            this.StartNuRafMethod.Location = new System.Drawing.Point(117, 244);
            this.StartNuRafMethod.Name = "StartNuRafMethod";
            this.StartNuRafMethod.Size = new System.Drawing.Size(99, 55);
            this.StartNuRafMethod.TabIndex = 30;
            this.StartNuRafMethod.Text = "Метод Ньютона-Раффсона";
            this.StartNuRafMethod.UseVisualStyleBackColor = true;
            this.StartNuRafMethod.Click += new System.EventHandler(this.StartNuRafMethod_Click);
            // 
            // StartKasanieMethod
            // 
            this.StartKasanieMethod.Location = new System.Drawing.Point(432, 183);
            this.StartKasanieMethod.Name = "StartKasanieMethod";
            this.StartKasanieMethod.Size = new System.Drawing.Size(99, 55);
            this.StartKasanieMethod.TabIndex = 29;
            this.StartKasanieMethod.Text = "Метод касательных";
            this.StartKasanieMethod.UseVisualStyleBackColor = true;
            this.StartKasanieMethod.Click += new System.EventHandler(this.StartKasanieMethod_Click);
            // 
            // StartFibonaciMethod
            // 
            this.StartFibonaciMethod.Location = new System.Drawing.Point(327, 183);
            this.StartFibonaciMethod.Name = "StartFibonaciMethod";
            this.StartFibonaciMethod.Size = new System.Drawing.Size(99, 55);
            this.StartFibonaciMethod.TabIndex = 28;
            this.StartFibonaciMethod.Text = "Фибоначчи";
            this.StartFibonaciMethod.UseVisualStyleBackColor = true;
            this.StartFibonaciMethod.Click += new System.EventHandler(this.StartFibonaciMethod_Click);
            // 
            // StartGoldSearchMethod
            // 
            this.StartGoldSearchMethod.Location = new System.Drawing.Point(222, 183);
            this.StartGoldSearchMethod.Name = "StartGoldSearchMethod";
            this.StartGoldSearchMethod.Size = new System.Drawing.Size(99, 55);
            this.StartGoldSearchMethod.TabIndex = 27;
            this.StartGoldSearchMethod.Text = "Золотое сечение";
            this.StartGoldSearchMethod.UseVisualStyleBackColor = true;
            this.StartGoldSearchMethod.Click += new System.EventHandler(this.StartGoldSearchMethod_Click);
            // 
            // StartDihotomiaMethod
            // 
            this.StartDihotomiaMethod.Location = new System.Drawing.Point(117, 183);
            this.StartDihotomiaMethod.Name = "StartDihotomiaMethod";
            this.StartDihotomiaMethod.Size = new System.Drawing.Size(99, 55);
            this.StartDihotomiaMethod.TabIndex = 26;
            this.StartDihotomiaMethod.Text = "Метод дихотомии";
            this.StartDihotomiaMethod.UseVisualStyleBackColor = true;
            this.StartDihotomiaMethod.Click += new System.EventHandler(this.StartDihotomiaMethod_Click);
            // 
            // StartPassiveSearch
            // 
            this.StartPassiveSearch.Location = new System.Drawing.Point(12, 183);
            this.StartPassiveSearch.Name = "StartPassiveSearch";
            this.StartPassiveSearch.Size = new System.Drawing.Size(99, 55);
            this.StartPassiveSearch.TabIndex = 25;
            this.StartPassiveSearch.Text = "Пассивный поиск";
            this.StartPassiveSearch.UseVisualStyleBackColor = true;
            this.StartPassiveSearch.Click += new System.EventHandler(this.StartPassiveSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Поле для Epsilon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Поле для X1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Поле для X0";
            // 
            // Epsilon
            // 
            this.Epsilon.Location = new System.Drawing.Point(12, 111);
            this.Epsilon.Name = "Epsilon";
            this.Epsilon.Size = new System.Drawing.Size(100, 23);
            this.Epsilon.TabIndex = 21;
            this.Epsilon.Text = "0,001";
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(12, 70);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(100, 23);
            this.X1.TabIndex = 20;
            this.X1.Text = "0,5";
            // 
            // X0
            // 
            this.X0.Location = new System.Drawing.Point(12, 28);
            this.X0.Name = "X0";
            this.X0.Size = new System.Drawing.Size(100, 23);
            this.X0.TabIndex = 19;
            this.X0.Text = "-1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 308);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TimeOfDoing);
            this.Controls.Add(this.ErrorRate);
            this.Controls.Add(this.Iterations);
            this.Controls.Add(this.ResultF);
            this.Controls.Add(this.ResultX);
            this.Controls.Add(this.StartSekuchMethod);
            this.Controls.Add(this.StartNuRafMethod);
            this.Controls.Add(this.StartKasanieMethod);
            this.Controls.Add(this.StartFibonaciMethod);
            this.Controls.Add(this.StartGoldSearchMethod);
            this.Controls.Add(this.StartDihotomiaMethod);
            this.Controls.Add(this.StartPassiveSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Epsilon);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.X0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "ЛР1 Баженов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private Label TimeOfDoing;
        private Label ErrorRate;
        private Label Iterations;
        private Label ResultF;
        private Label ResultX;
        private Button StartSekuchMethod;
        private Button StartNuRafMethod;
        private Button StartKasanieMethod;
        private Button StartFibonaciMethod;
        private Button StartGoldSearchMethod;
        private Button StartDihotomiaMethod;
        private Button StartPassiveSearch;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Epsilon;
        private TextBox X1;
        private TextBox X0;
    }
}