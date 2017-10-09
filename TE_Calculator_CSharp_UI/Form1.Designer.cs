namespace TE_Calculator_CSharp_UI
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
            this.txtbWeerstand = new System.Windows.Forms.TextBox();
            this.txtbSpanning = new System.Windows.Forms.TextBox();
            this.txtbStroom = new System.Windows.Forms.TextBox();
            this.txtbVermogen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBerekenSpanning = new System.Windows.Forms.Button();
            this.btnBerekenStroom = new System.Windows.Forms.Button();
            this.btnBerekenWeerstand = new System.Windows.Forms.Button();
            this.btnBerekenVermogen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbWeerstand
            // 
            this.txtbWeerstand.Location = new System.Drawing.Point(70, 64);
            this.txtbWeerstand.Name = "txtbWeerstand";
            this.txtbWeerstand.Size = new System.Drawing.Size(100, 20);
            this.txtbWeerstand.TabIndex = 0;
            this.txtbWeerstand.Text = "0";
            // 
            // txtbSpanning
            // 
            this.txtbSpanning.Location = new System.Drawing.Point(70, 12);
            this.txtbSpanning.Name = "txtbSpanning";
            this.txtbSpanning.Size = new System.Drawing.Size(100, 20);
            this.txtbSpanning.TabIndex = 1;
            this.txtbSpanning.Text = "0";
            // 
            // txtbStroom
            // 
            this.txtbStroom.Location = new System.Drawing.Point(70, 38);
            this.txtbStroom.Name = "txtbStroom";
            this.txtbStroom.Size = new System.Drawing.Size(100, 20);
            this.txtbStroom.TabIndex = 2;
            this.txtbStroom.Text = "0";
            // 
            // txtbVermogen
            // 
            this.txtbVermogen.Location = new System.Drawing.Point(70, 90);
            this.txtbVermogen.Name = "txtbVermogen";
            this.txtbVermogen.Size = new System.Drawing.Size(100, 20);
            this.txtbVermogen.TabIndex = 3;
            this.txtbVermogen.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vermogen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Weerstand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stroom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Spanning";
            // 
            // btnBerekenSpanning
            // 
            this.btnBerekenSpanning.Location = new System.Drawing.Point(176, 12);
            this.btnBerekenSpanning.Name = "btnBerekenSpanning";
            this.btnBerekenSpanning.Size = new System.Drawing.Size(75, 23);
            this.btnBerekenSpanning.TabIndex = 8;
            this.btnBerekenSpanning.Text = "Bereken";
            this.btnBerekenSpanning.UseVisualStyleBackColor = true;
            this.btnBerekenSpanning.Click += new System.EventHandler(this.btnBerekenSpanning_Click);
            // 
            // btnBerekenStroom
            // 
            this.btnBerekenStroom.Location = new System.Drawing.Point(176, 38);
            this.btnBerekenStroom.Name = "btnBerekenStroom";
            this.btnBerekenStroom.Size = new System.Drawing.Size(75, 23);
            this.btnBerekenStroom.TabIndex = 9;
            this.btnBerekenStroom.Text = "Bereken";
            this.btnBerekenStroom.UseVisualStyleBackColor = true;
            this.btnBerekenStroom.Click += new System.EventHandler(this.btnBerekenStroom_Click);
            // 
            // btnBerekenWeerstand
            // 
            this.btnBerekenWeerstand.Location = new System.Drawing.Point(176, 64);
            this.btnBerekenWeerstand.Name = "btnBerekenWeerstand";
            this.btnBerekenWeerstand.Size = new System.Drawing.Size(75, 23);
            this.btnBerekenWeerstand.TabIndex = 10;
            this.btnBerekenWeerstand.Text = "Bereken";
            this.btnBerekenWeerstand.UseVisualStyleBackColor = true;
            this.btnBerekenWeerstand.Click += new System.EventHandler(this.btnBerekenWeerstand_Click);
            // 
            // btnBerekenVermogen
            // 
            this.btnBerekenVermogen.Location = new System.Drawing.Point(176, 90);
            this.btnBerekenVermogen.Name = "btnBerekenVermogen";
            this.btnBerekenVermogen.Size = new System.Drawing.Size(75, 23);
            this.btnBerekenVermogen.TabIndex = 11;
            this.btnBerekenVermogen.Text = "Bereken";
            this.btnBerekenVermogen.UseVisualStyleBackColor = true;
            this.btnBerekenVermogen.Click += new System.EventHandler(this.btnBerekenVermogen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.btnBerekenVermogen);
            this.Controls.Add(this.btnBerekenWeerstand);
            this.Controls.Add(this.btnBerekenStroom);
            this.Controls.Add(this.btnBerekenSpanning);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbVermogen);
            this.Controls.Add(this.txtbStroom);
            this.Controls.Add(this.txtbSpanning);
            this.Controls.Add(this.txtbWeerstand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbWeerstand;
        private System.Windows.Forms.TextBox txtbSpanning;
        private System.Windows.Forms.TextBox txtbStroom;
        private System.Windows.Forms.TextBox txtbVermogen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBerekenSpanning;
        private System.Windows.Forms.Button btnBerekenStroom;
        private System.Windows.Forms.Button btnBerekenWeerstand;
        private System.Windows.Forms.Button btnBerekenVermogen;
    }
}

