
namespace Math_Quiz
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
            this.components = new System.ComponentModel.Container();
            this.changeTypeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.firstWord = new System.Windows.Forms.Label();
            this.secondWord = new System.Windows.Forms.Label();
            this.thirdWord = new System.Windows.Forms.Label();
            this.fourthWord = new System.Windows.Forms.Label();
            this.fifthWord = new System.Windows.Forms.Label();
            this.firstBox = new System.Windows.Forms.TextBox();
            this.secondBox = new System.Windows.Forms.TextBox();
            this.thirdBox = new System.Windows.Forms.TextBox();
            this.fourthBox = new System.Windows.Forms.TextBox();
            this.fifthBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changeTypeButton
            // 
            this.changeTypeButton.AutoSize = true;
            this.changeTypeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changeTypeButton.BackColor = System.Drawing.Color.MediumBlue;
            this.changeTypeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeTypeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeTypeButton.Location = new System.Drawing.Point(617, 407);
            this.changeTypeButton.Name = "changeTypeButton";
            this.changeTypeButton.Size = new System.Drawing.Size(190, 34);
            this.changeTypeButton.TabIndex = 34;
            this.changeTypeButton.TabStop = false;
            this.changeTypeButton.Text = "сменить тип теста";
            this.changeTypeButton.UseVisualStyleBackColor = false;
            this.changeTypeButton.Click += new System.EventHandler(this.ChangeType);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(399, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "оставшееся время";
            // 
            // timelabel
            // 
            this.timelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timelabel.Location = new System.Drawing.Point(603, 9);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(200, 30);
            this.timelabel.TabIndex = 35;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.Color.Maroon;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startButton.Location = new System.Drawing.Point(12, 403);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(128, 34);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "начать тест";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.ClickStart);
            // 
            // firstWord
            // 
            this.firstWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstWord.Location = new System.Drawing.Point(80, 73);
            this.firstWord.Name = "firstWord";
            this.firstWord.Size = new System.Drawing.Size(171, 50);
            this.firstWord.TabIndex = 37;
            this.firstWord.Text = "____________";
            this.firstWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondWord
            // 
            this.secondWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondWord.Location = new System.Drawing.Point(80, 123);
            this.secondWord.Name = "secondWord";
            this.secondWord.Size = new System.Drawing.Size(171, 50);
            this.secondWord.TabIndex = 38;
            this.secondWord.Text = "____________";
            this.secondWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thirdWord
            // 
            this.thirdWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdWord.Location = new System.Drawing.Point(80, 173);
            this.thirdWord.Name = "thirdWord";
            this.thirdWord.Size = new System.Drawing.Size(171, 50);
            this.thirdWord.TabIndex = 39;
            this.thirdWord.Text = "____________";
            this.thirdWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fourthWord
            // 
            this.fourthWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourthWord.Location = new System.Drawing.Point(80, 223);
            this.fourthWord.Name = "fourthWord";
            this.fourthWord.Size = new System.Drawing.Size(171, 50);
            this.fourthWord.TabIndex = 40;
            this.fourthWord.Text = "____________";
            this.fourthWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fifthWord
            // 
            this.fifthWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fifthWord.Location = new System.Drawing.Point(80, 273);
            this.fifthWord.Name = "fifthWord";
            this.fifthWord.Size = new System.Drawing.Size(171, 50);
            this.fifthWord.TabIndex = 41;
            this.fifthWord.Text = "____________";
            this.fifthWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstBox
            // 
            this.firstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstBox.Location = new System.Drawing.Point(603, 81);
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(200, 35);
            this.firstBox.TabIndex = 1;
            // 
            // secondBox
            // 
            this.secondBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondBox.Location = new System.Drawing.Point(603, 131);
            this.secondBox.Name = "secondBox";
            this.secondBox.Size = new System.Drawing.Size(200, 35);
            this.secondBox.TabIndex = 2;
            // 
            // thirdBox
            // 
            this.thirdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdBox.Location = new System.Drawing.Point(603, 188);
            this.thirdBox.Name = "thirdBox";
            this.thirdBox.Size = new System.Drawing.Size(200, 35);
            this.thirdBox.TabIndex = 3;
            // 
            // fourthBox
            // 
            this.fourthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourthBox.Location = new System.Drawing.Point(603, 238);
            this.fourthBox.Name = "fourthBox";
            this.fourthBox.Size = new System.Drawing.Size(200, 35);
            this.fourthBox.TabIndex = 4;
            // 
            // fifthBox
            // 
            this.fifthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fifthBox.Location = new System.Drawing.Point(603, 288);
            this.fifthBox.Name = "fifthBox";
            this.fifthBox.Size = new System.Drawing.Size(200, 35);
            this.fifthBox.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(605, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "* вводите слова полностью";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fifthBox);
            this.Controls.Add(this.fourthBox);
            this.Controls.Add(this.thirdBox);
            this.Controls.Add(this.secondBox);
            this.Controls.Add(this.firstBox);
            this.Controls.Add(this.fifthWord);
            this.Controls.Add(this.fourthWord);
            this.Controls.Add(this.thirdWord);
            this.Controls.Add(this.secondWord);
            this.Controls.Add(this.firstWord);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.changeTypeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лингвистический тест (русский язык)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseAll);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeTypeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label firstWord;
        private System.Windows.Forms.Label secondWord;
        private System.Windows.Forms.Label thirdWord;
        private System.Windows.Forms.Label fourthWord;
        private System.Windows.Forms.Label fifthWord;
        private System.Windows.Forms.TextBox firstBox;
        private System.Windows.Forms.TextBox secondBox;
        private System.Windows.Forms.TextBox thirdBox;
        private System.Windows.Forms.TextBox fourthBox;
        private System.Windows.Forms.TextBox fifthBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}