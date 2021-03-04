
namespace CrudEFhomework
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
            this.userView = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.radioName = new System.Windows.Forms.RadioButton();
            this.radioCity = new System.Windows.Forms.RadioButton();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.radioLetter = new System.Windows.Forms.RadioButton();
            this.filterBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userView)).BeginInit();
            this.SuspendLayout();
            // 
            // userView
            // 
            this.userView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.userView.Location = new System.Drawing.Point(12, 12);
            this.userView.Name = "userView";
            this.userView.RowTemplate.Height = 25;
            this.userView.Size = new System.Drawing.Size(693, 660);
            this.userView.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(714, 190);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add User";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(714, 311);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(714, 248);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(714, 67);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 4;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(714, 23);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 5;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.button5_Click);
            // 
            // radioName
            // 
            this.radioName.AutoSize = true;
            this.radioName.Location = new System.Drawing.Point(717, 96);
            this.radioName.Name = "radioName";
            this.radioName.Size = new System.Drawing.Size(81, 19);
            this.radioName.TabIndex = 6;
            this.radioName.TabStop = true;
            this.radioName.Text = "Last Name";
            this.radioName.UseVisualStyleBackColor = true;
            // 
            // radioCity
            // 
            this.radioCity.AutoSize = true;
            this.radioCity.Location = new System.Drawing.Point(717, 122);
            this.radioCity.Name = "radioCity";
            this.radioCity.Size = new System.Drawing.Size(46, 19);
            this.radioCity.TabIndex = 7;
            this.radioCity.TabStop = true;
            this.radioCity.Text = "City";
            this.radioCity.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(804, 23);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(233, 23);
            this.searchBox.TabIndex = 8;
            // 
            // radioLetter
            // 
            this.radioLetter.AutoSize = true;
            this.radioLetter.Location = new System.Drawing.Point(717, 147);
            this.radioLetter.Name = "radioLetter";
            this.radioLetter.Size = new System.Drawing.Size(99, 19);
            this.radioLetter.TabIndex = 9;
            this.radioLetter.TabStop = true;
            this.radioLetter.Text = "Starting Letter";
            this.radioLetter.UseVisualStyleBackColor = true;
            // 
            // filterBox
            // 
            this.filterBox.Location = new System.Drawing.Point(804, 67);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(233, 23);
            this.filterBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(804, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add user will bring up a new window to enter data.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(804, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter a last name you want to update then select and edit the data you want to ch" +
    "age";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(804, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 54);
            this.label3.TabIndex = 13;
            this.label3.Text = "To delete a user search for the name you want to delete then select the user and " +
    "then click delete button\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 684);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.radioLetter);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.radioCity);
            this.Controls.Add(this.radioName);
            this.Controls.Add(this.search);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.userView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userView;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.RadioButton radioName;
        private System.Windows.Forms.RadioButton radioCity;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.RadioButton radioLetter;
        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

