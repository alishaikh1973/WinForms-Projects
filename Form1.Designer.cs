﻿namespace FILE_IO
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.btnwrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCreateDirectory = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnStreamWrite = new System.Windows.Forms.Button();
            this.btnStreamRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(78, 39);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 25);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblName.Location = new System.Drawing.Point(78, 114);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSal.Location = new System.Drawing.Point(78, 195);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(68, 25);
            this.lblSal.TabIndex = 2;
            this.lblSal.Text = "Salary";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(192, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(131, 26);
            this.txtId.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(192, 111);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(131, 26);
            this.txtName.TabIndex = 4;
            // 
            // txtsal
            // 
            this.txtsal.Location = new System.Drawing.Point(192, 192);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(131, 26);
            this.txtsal.TabIndex = 5;
            // 
            // btnwrite
            // 
            this.btnwrite.BackColor = System.Drawing.Color.Red;
            this.btnwrite.Location = new System.Drawing.Point(82, 274);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(87, 40);
            this.btnwrite.TabIndex = 6;
            this.btnwrite.Text = "Write";
            this.btnwrite.UseVisualStyleBackColor = false;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.Red;
            this.btnRead.Location = new System.Drawing.Point(219, 274);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(91, 40);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnCreateDirectory
            // 
            this.btnCreateDirectory.Location = new System.Drawing.Point(406, 33);
            this.btnCreateDirectory.Name = "btnCreateDirectory";
            this.btnCreateDirectory.Size = new System.Drawing.Size(147, 34);
            this.btnCreateDirectory.TabIndex = 8;
            this.btnCreateDirectory.Text = "Create Directory";
            this.btnCreateDirectory.UseVisualStyleBackColor = true;
            this.btnCreateDirectory.Click += new System.EventHandler(this.btnCreateDirectory_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "CreateFile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(575, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(307, 156);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // btnStreamWrite
            // 
            this.btnStreamWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStreamWrite.Location = new System.Drawing.Point(511, 195);
            this.btnStreamWrite.Name = "btnStreamWrite";
            this.btnStreamWrite.Size = new System.Drawing.Size(157, 39);
            this.btnStreamWrite.TabIndex = 11;
            this.btnStreamWrite.Text = "Stream Write";
            this.btnStreamWrite.UseVisualStyleBackColor = false;
            this.btnStreamWrite.Click += new System.EventHandler(this.btnStreamWrite_Click);
            // 
            // btnStreamRead
            // 
            this.btnStreamRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStreamRead.Location = new System.Drawing.Point(774, 195);
            this.btnStreamRead.Name = "btnStreamRead";
            this.btnStreamRead.Size = new System.Drawing.Size(154, 39);
            this.btnStreamRead.TabIndex = 12;
            this.btnStreamRead.Text = "StreamRead";
            this.btnStreamRead.UseVisualStyleBackColor = false;
            this.btnStreamRead.Click += new System.EventHandler(this.btnStreamRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.btnStreamRead);
            this.Controls.Add(this.btnStreamWrite);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCreateDirectory);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.txtsal);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Name = "Form1";
            this.Text = "File IO Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCreateDirectory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnStreamWrite;
        private System.Windows.Forms.Button btnStreamRead;
    }
}

