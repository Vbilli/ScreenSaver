namespace DllTest
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.toolButton1 = new _SCREEN_CAPTURE.ToolButton();
            this.colorBox1 = new _SCREEN_CAPTURE.ColorBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbxText1 = new DllTest.tbxText();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // toolButton1
            // 
            this.toolButton1.BtnImage = null;
            this.toolButton1.IsSelected = true;
            this.toolButton1.IsSelectedBtn = true;
            this.toolButton1.IsSingleSelectedBtn = true;
            this.toolButton1.Location = new System.Drawing.Point(64, 156);
            this.toolButton1.Name = "toolButton1";
            this.toolButton1.Size = new System.Drawing.Size(82, 21);
            this.toolButton1.TabIndex = 2;
            this.toolButton1.Text = "toolButton1";
            // 
            // colorBox1
            // 
            this.colorBox1.Location = new System.Drawing.Point(30, 12);
            this.colorBox1.Name = "colorBox1";
            this.colorBox1.Size = new System.Drawing.Size(165, 35);
            this.colorBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 111);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 90);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxText1
            // 
            this.tbxText1.Location = new System.Drawing.Point(12, 76);
            this.tbxText1.Multiline = true;
            this.tbxText1.Name = "tbxText1";
            this.tbxText1.Size = new System.Drawing.Size(107, 54);
            this.tbxText1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 268);
            this.Controls.Add(this.tbxText1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolButton1);
            this.Controls.Add(this.colorBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private _SCREEN_CAPTURE.ColorBox colorBox1;
        private _SCREEN_CAPTURE.ToolButton toolButton1;
        private System.Windows.Forms.TextBox textBox1;
        private tbxText tbxText1;






    }
}

