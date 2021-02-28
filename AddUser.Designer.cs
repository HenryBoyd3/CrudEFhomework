
namespace CrudEFhomework
{
    partial class AddUser
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
            this.lable1 = new System.Windows.Forms.Label();
            this.firstNbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(13, 13);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(64, 15);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "First Name";
            // 
            // firstNbox
            // 
            this.firstNbox.Location = new System.Drawing.Point(13, 32);
            this.firstNbox.Name = "firstNbox";
            this.firstNbox.Size = new System.Drawing.Size(202, 23);
            this.firstNbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // lastNBox
            // 
            this.lastNBox.Location = new System.Drawing.Point(13, 81);
            this.lastNBox.Name = "lastNBox";
            this.lastNBox.Size = new System.Drawing.Size(202, 23);
            this.lastNBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "City";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(13, 130);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(202, 23);
            this.cityBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Country";
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(13, 179);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(202, 23);
            this.countryBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone";
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(13, 228);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(202, 23);
            this.phoneBox.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(13, 267);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(202, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add User";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 303);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastNBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNbox);
            this.Controls.Add(this.lable1);
            this.Name = "AddUser";
            this.Text = "AddUsercs";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.TextBox firstNbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Button addButton;
    }
}