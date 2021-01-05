namespace TicTacToe
{
    partial class fParameters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fParameters));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPlayerTwo = new System.Windows.Forms.TextBox();
            this.tbPlayerOne = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbTwo = new System.Windows.Forms.RadioButton();
            this.rbWunderkind = new System.Windows.Forms.RadioButton();
            this.rbProfessional = new System.Windows.Forms.RadioButton();
            this.rbAmateur = new System.Windows.Forms.RadioButton();
            this.rbNewbie = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbO = new System.Windows.Forms.RadioButton();
            this.rbX = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPlayerTwo);
            this.groupBox1.Controls.Add(this.tbPlayerOne);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbTwo);
            this.groupBox1.Controls.Add(this.rbWunderkind);
            this.groupBox1.Controls.Add(this.rbProfessional);
            this.groupBox1.Controls.Add(this.rbAmateur);
            this.groupBox1.Controls.Add(this.rbNewbie);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Уровень";
            // 
            // tbPlayerTwo
            // 
            this.tbPlayerTwo.Location = new System.Drawing.Point(345, 107);
            this.tbPlayerTwo.Name = "tbPlayerTwo";
            this.tbPlayerTwo.Size = new System.Drawing.Size(89, 20);
            this.tbPlayerTwo.TabIndex = 8;
            // 
            // tbPlayerOne
            // 
            this.tbPlayerOne.Location = new System.Drawing.Point(345, 70);
            this.tbPlayerOne.Name = "tbPlayerOne";
            this.tbPlayerOne.Size = new System.Drawing.Size(89, 20);
            this.tbPlayerOne.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя второго игрока:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя первого игрока:";
            // 
            // rbTwo
            // 
            this.rbTwo.AutoSize = true;
            this.rbTwo.Location = new System.Drawing.Point(195, 34);
            this.rbTwo.Name = "rbTwo";
            this.rbTwo.Size = new System.Drawing.Size(71, 17);
            this.rbTwo.TabIndex = 4;
            this.rbTwo.TabStop = true;
            this.rbTwo.Text = "На двоих";
            this.rbTwo.UseVisualStyleBackColor = true;
            this.rbTwo.CheckedChanged += new System.EventHandler(this.rbTwo_CheckedChanged);
            // 
            // rbWunderkind
            // 
            this.rbWunderkind.AutoSize = true;
            this.rbWunderkind.Location = new System.Drawing.Point(27, 146);
            this.rbWunderkind.Name = "rbWunderkind";
            this.rbWunderkind.Size = new System.Drawing.Size(85, 17);
            this.rbWunderkind.TabIndex = 3;
            this.rbWunderkind.TabStop = true;
            this.rbWunderkind.Text = "Вундеркинд";
            this.rbWunderkind.UseVisualStyleBackColor = true;
            // 
            // rbProfessional
            // 
            this.rbProfessional.AutoSize = true;
            this.rbProfessional.Location = new System.Drawing.Point(27, 108);
            this.rbProfessional.Name = "rbProfessional";
            this.rbProfessional.Size = new System.Drawing.Size(101, 17);
            this.rbProfessional.TabIndex = 2;
            this.rbProfessional.TabStop = true;
            this.rbProfessional.Text = "Профессионал";
            this.rbProfessional.UseVisualStyleBackColor = true;
            // 
            // rbAmateur
            // 
            this.rbAmateur.AutoSize = true;
            this.rbAmateur.Location = new System.Drawing.Point(27, 71);
            this.rbAmateur.Name = "rbAmateur";
            this.rbAmateur.Size = new System.Drawing.Size(76, 17);
            this.rbAmateur.TabIndex = 1;
            this.rbAmateur.TabStop = true;
            this.rbAmateur.Text = "Любитель";
            this.rbAmateur.UseVisualStyleBackColor = true;
            // 
            // rbNewbie
            // 
            this.rbNewbie.AutoSize = true;
            this.rbNewbie.Checked = true;
            this.rbNewbie.Location = new System.Drawing.Point(27, 34);
            this.rbNewbie.Name = "rbNewbie";
            this.rbNewbie.Size = new System.Drawing.Size(68, 17);
            this.rbNewbie.TabIndex = 0;
            this.rbNewbie.TabStop = true;
            this.rbNewbie.Text = "Новичок";
            this.rbNewbie.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbO);
            this.groupBox2.Controls.Add(this.rbX);
            this.groupBox2.Location = new System.Drawing.Point(12, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 71);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фигурка";
            // 
            // rbO
            // 
            this.rbO.AutoSize = true;
            this.rbO.Location = new System.Drawing.Point(210, 35);
            this.rbO.Name = "rbO";
            this.rbO.Size = new System.Drawing.Size(33, 17);
            this.rbO.TabIndex = 1;
            this.rbO.Text = "O";
            this.rbO.UseVisualStyleBackColor = true;
            // 
            // rbX
            // 
            this.rbX.AutoSize = true;
            this.rbX.Checked = true;
            this.rbX.Location = new System.Drawing.Point(27, 35);
            this.rbX.Name = "rbX";
            this.rbX.Size = new System.Drawing.Size(32, 17);
            this.rbX.TabIndex = 0;
            this.rbX.TabStop = true;
            this.rbX.Text = "X";
            this.rbX.UseVisualStyleBackColor = true;
            // 
            // fParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 380);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fParameters";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Параметр";
            this.Load += new System.EventHandler(this.fParameters_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPlayerTwo;
        private System.Windows.Forms.TextBox tbPlayerOne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.RadioButton rbTwo;
        public System.Windows.Forms.RadioButton rbWunderkind;
        public System.Windows.Forms.RadioButton rbProfessional;
        public System.Windows.Forms.RadioButton rbAmateur;
        public System.Windows.Forms.RadioButton rbNewbie;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbO;
        private System.Windows.Forms.RadioButton rbX;
    }
}