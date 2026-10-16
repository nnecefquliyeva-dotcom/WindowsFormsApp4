namespace WindowsFormsApp4
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCix = new System.Windows.Forms.Button();
            this.btnVur = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.lblNetice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(12, 58);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 26);
            this.txtA.TabIndex = 0;
            this.txtA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(118, 58);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 26);
            this.txtB.TabIndex = 1;
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(24, 90);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(75, 23);
            this.btnTopla.TabIndex = 2;
            this.btnTopla.Text = "+";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCix
            // 
            this.btnCix.Location = new System.Drawing.Point(24, 119);
            this.btnCix.Name = "btnCix";
            this.btnCix.Size = new System.Drawing.Size(75, 23);
            this.btnCix.TabIndex = 3;
            this.btnCix.Text = "-";
            this.btnCix.UseVisualStyleBackColor = true;
            this.btnCix.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVur
            // 
            this.btnVur.Location = new System.Drawing.Point(24, 148);
            this.btnVur.Name = "btnVur";
            this.btnVur.Size = new System.Drawing.Size(75, 23);
            this.btnVur.TabIndex = 4;
            this.btnVur.Text = "*";
            this.btnVur.UseVisualStyleBackColor = true;
            this.btnVur.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBol
            // 
            this.btnBol.Location = new System.Drawing.Point(24, 177);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(75, 23);
            this.btnBol.TabIndex = 5;
            this.btnBol.Text = "/";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // lblNetice
            // 
            this.lblNetice.AutoSize = true;
            this.lblNetice.Location = new System.Drawing.Point(34, 215);
            this.lblNetice.Name = "lblNetice";
            this.lblNetice.Size = new System.Drawing.Size(52, 20);
            this.lblNetice.TabIndex = 6;
            this.lblNetice.Text = "netice";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNetice);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnVur);
            this.Controls.Add(this.btnCix);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnCix;
        private System.Windows.Forms.Button btnVur;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Label lblNetice;
    }
}

