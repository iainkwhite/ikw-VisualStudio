namespace WinFormsHelloWorld
{
    partial class HelloWorld
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
            this.button1 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.AutoSize = true;
            this.TextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TextBox1.Location = new System.Drawing.Point(38, 42);
            this.TextBox1.MinimumSize = new System.Drawing.Size(60, 0);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Padding = new System.Windows.Forms.Padding(2);
            this.TextBox1.Size = new System.Drawing.Size(61, 19);
            this.TextBox1.TabIndex = 1;
            this.TextBox1.Text = "Hello Julie";
            this.TextBox1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 222);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.button1);
            this.Name = "HelloWorld";
            this.Text = "HelloWorldWindow";
            this.Load += new System.EventHandler(this.HelloWorld_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TextBox1;
        private System.Windows.Forms.Button button2;
    }
}

