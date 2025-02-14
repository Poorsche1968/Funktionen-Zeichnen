namespace FunktionZeichnen
{
    partial class LinearFunktionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAbfangen = new System.Windows.Forms.TextBox();
            this.buttonZeichnen = new System.Windows.Forms.Button();
            this.textBoxNeigung = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Neigung (m)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Abfangen (b)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zeichen";
            // 
            // textBoxAbfangen
            // 
            this.textBoxAbfangen.Location = new System.Drawing.Point(313, 79);
            this.textBoxAbfangen.Name = "textBoxAbfangen";
            this.textBoxAbfangen.Size = new System.Drawing.Size(157, 22);
            this.textBoxAbfangen.TabIndex = 4;
            // 
            // buttonZeichnen
            // 
            this.buttonZeichnen.Location = new System.Drawing.Point(713, 25);
            this.buttonZeichnen.Name = "buttonZeichnen";
            this.buttonZeichnen.Size = new System.Drawing.Size(75, 23);
            this.buttonZeichnen.TabIndex = 5;
            this.buttonZeichnen.Text = "Zeichne ";
            this.buttonZeichnen.UseVisualStyleBackColor = true;
            this.buttonZeichnen.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNeigung
            // 
            this.textBoxNeigung.Location = new System.Drawing.Point(26, 79);
            this.textBoxNeigung.Name = "textBoxNeigung";
            this.textBoxNeigung.Size = new System.Drawing.Size(137, 22);
            this.textBoxNeigung.TabIndex = 6;
            // 
            // LinearFunktionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNeigung);
            this.Controls.Add(this.buttonZeichnen);
            this.Controls.Add(this.textBoxAbfangen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LinearFunktionForm";
            this.Text = "LinearFunktionForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LinearFunktionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAbfangen;
        private System.Windows.Forms.Button buttonZeichnen;
        private System.Windows.Forms.TextBox textBoxNeigung;
    }
}