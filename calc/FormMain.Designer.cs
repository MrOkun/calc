
namespace calc
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.First_Number_Box = new System.Windows.Forms.TextBox();
            this.Second_Number_Box = new System.Windows.Forms.TextBox();
            this.Operator_Box = new System.Windows.Forms.ComboBox();
            this.Ansver_Box = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // First_Number_Box
            // 
            this.First_Number_Box.Location = new System.Drawing.Point(12, 12);
            this.First_Number_Box.Name = "First_Number_Box";
            this.First_Number_Box.Size = new System.Drawing.Size(100, 23);
            this.First_Number_Box.TabIndex = 0;
            this.First_Number_Box.TextChanged += new System.EventHandler(this.First_Number_Box_TextChanged);
            // 
            // Second_Number_Box
            // 
            this.Second_Number_Box.Location = new System.Drawing.Point(164, 12);
            this.Second_Number_Box.Name = "Second_Number_Box";
            this.Second_Number_Box.Size = new System.Drawing.Size(100, 23);
            this.Second_Number_Box.TabIndex = 1;
            this.Second_Number_Box.TextChanged += new System.EventHandler(this.Second_Number_Box_TextChanged);
            // 
            // Operator_Box
            // 
            this.Operator_Box.FormattingEnabled = true;
            this.Operator_Box.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.Operator_Box.Location = new System.Drawing.Point(119, 12);
            this.Operator_Box.Name = "Operator_Box";
            this.Operator_Box.Size = new System.Drawing.Size(39, 23);
            this.Operator_Box.TabIndex = 2;
            this.Operator_Box.SelectedIndexChanged += new System.EventHandler(this.Operator_Box_SelectedIndexChanged);
            // 
            // Ansver_Box
            // 
            this.Ansver_Box.Location = new System.Drawing.Point(270, 12);
            this.Ansver_Box.Name = "Ansver_Box";
            this.Ansver_Box.ReadOnly = true;
            this.Ansver_Box.Size = new System.Drawing.Size(98, 23);
            this.Ansver_Box.TabIndex = 5;
            this.Ansver_Box.Click += new System.EventHandler(this.Ansver_Box_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(306, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 154);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Ansver_Box);
            this.Controls.Add(this.Operator_Box);
            this.Controls.Add(this.Second_Number_Box);
            this.Controls.Add(this.First_Number_Box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(398, 193);
            this.MinimumSize = new System.Drawing.Size(398, 193);
            this.Name = "FormMain";
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox First_Number_Box;
        private System.Windows.Forms.TextBox Second_Number_Box;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Ansver_Box;
        private System.Windows.Forms.ComboBox Operator_Box;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

