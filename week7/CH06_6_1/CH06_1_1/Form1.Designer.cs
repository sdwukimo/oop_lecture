﻿namespace CH06_6_1
{
    partial class Form1
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
            this.txt_CatShoutNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_AmountOfCats = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CatSignUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CatName = new System.Windows.Forms.TextBox();
            this.btn_Contest = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_AmountOfDogs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_DogSignUp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DogName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_DogShoutNum = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_CatShoutNum
            // 
            this.txt_CatShoutNum.Location = new System.Drawing.Point(152, 33);
            this.txt_CatShoutNum.Name = "txt_CatShoutNum";
            this.txt_CatShoutNum.Size = new System.Drawing.Size(100, 22);
            this.txt_CatShoutNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "叫聲次數";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_AmountOfCats);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_CatSignUp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_CatName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_CatShoutNum);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 180);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "貓咪叫聲大賽報名";
            // 
            // txt_AmountOfCats
            // 
            this.txt_AmountOfCats.Location = new System.Drawing.Point(154, 135);
            this.txt_AmountOfCats.Name = "txt_AmountOfCats";
            this.txt_AmountOfCats.Size = new System.Drawing.Size(98, 22);
            this.txt_AmountOfCats.TabIndex = 9;
            this.txt_AmountOfCats.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "已報名貓數";
            // 
            // btn_CatSignUp
            // 
            this.btn_CatSignUp.Location = new System.Drawing.Point(152, 76);
            this.btn_CatSignUp.Name = "btn_CatSignUp";
            this.btn_CatSignUp.Size = new System.Drawing.Size(100, 23);
            this.btn_CatSignUp.TabIndex = 7;
            this.btn_CatSignUp.Text = "報名";
            this.btn_CatSignUp.UseVisualStyleBackColor = true;
            this.btn_CatSignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "名字";
            // 
            // txt_CatName
            // 
            this.txt_CatName.Location = new System.Drawing.Point(8, 33);
            this.txt_CatName.Name = "txt_CatName";
            this.txt_CatName.Size = new System.Drawing.Size(100, 22);
            this.txt_CatName.TabIndex = 5;
            // 
            // btn_Contest
            // 
            this.btn_Contest.Location = new System.Drawing.Point(109, 215);
            this.btn_Contest.Name = "btn_Contest";
            this.btn_Contest.Size = new System.Drawing.Size(75, 23);
            this.btn_Contest.TabIndex = 6;
            this.btn_Contest.Text = "開始比賽";
            this.btn_Contest.UseVisualStyleBackColor = true;
            this.btn_Contest.Click += new System.EventHandler(this.btn_Contest_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_AmountOfDogs);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_DogSignUp);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_DogName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_DogShoutNum);
            this.groupBox2.Location = new System.Drawing.Point(300, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 180);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "狗狗叫聲大賽報名";
            // 
            // txt_AmountOfDogs
            // 
            this.txt_AmountOfDogs.Location = new System.Drawing.Point(154, 135);
            this.txt_AmountOfDogs.Name = "txt_AmountOfDogs";
            this.txt_AmountOfDogs.Size = new System.Drawing.Size(98, 22);
            this.txt_AmountOfDogs.TabIndex = 9;
            this.txt_AmountOfDogs.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "已報名貓狗數";
            // 
            // btn_DogSignUp
            // 
            this.btn_DogSignUp.Location = new System.Drawing.Point(152, 76);
            this.btn_DogSignUp.Name = "btn_DogSignUp";
            this.btn_DogSignUp.Size = new System.Drawing.Size(100, 23);
            this.btn_DogSignUp.TabIndex = 7;
            this.btn_DogSignUp.Text = "報名";
            this.btn_DogSignUp.UseVisualStyleBackColor = true;
            this.btn_DogSignUp.Click += new System.EventHandler(this.btn_DogSignUp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "名字";
            // 
            // txt_DogName
            // 
            this.txt_DogName.Location = new System.Drawing.Point(8, 33);
            this.txt_DogName.Name = "txt_DogName";
            this.txt_DogName.Size = new System.Drawing.Size(100, 22);
            this.txt_DogName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "叫聲次數";
            // 
            // txt_DogShoutNum
            // 
            this.txt_DogShoutNum.Location = new System.Drawing.Point(152, 33);
            this.txt_DogShoutNum.Name = "txt_DogShoutNum";
            this.txt_DogShoutNum.Size = new System.Drawing.Size(100, 22);
            this.txt_DogShoutNum.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 262);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Contest);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "貓咪叫聲大賽";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_CatShoutNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_AmountOfCats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_CatSignUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CatName;
        private System.Windows.Forms.Button btn_Contest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_AmountOfDogs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_DogSignUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DogName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_DogShoutNum;
    }
}
