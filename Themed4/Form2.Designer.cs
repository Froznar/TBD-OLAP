namespace Themed4
{
    partial class Form2
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
            this.c1ComboBox1 = new C1.Win.C1Input.C1ComboBox();
            this.c1Button1 = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1ComboBox1
            // 
            this.c1ComboBox1.AllowSpinLoop = false;
            this.c1ComboBox1.GapHeight = 0;
            this.c1ComboBox1.ImagePadding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.c1ComboBox1.ItemsDisplayMember = "";
            this.c1ComboBox1.ItemsValueMember = "";
            this.c1ComboBox1.Location = new System.Drawing.Point(48, 104);
            this.c1ComboBox1.Name = "c1ComboBox1";
            this.c1ComboBox1.Size = new System.Drawing.Size(200, 18);
            this.c1ComboBox1.TabIndex = 0;
            this.c1ComboBox1.Tag = null;
        
            // 
            // c1Button1
            // 
            this.c1Button1.Location = new System.Drawing.Point(103, 165);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Size = new System.Drawing.Size(75, 23);
            this.c1Button1.TabIndex = 1;
            this.c1Button1.Text = "Aceptar";
            this.c1Button1.UseVisualStyleBackColor = true;
            this.c1Button1.Click += c1Button1_Click;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.c1Button1);
            this.Controls.Add(this.c1ComboBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Input.C1ComboBox c1ComboBox1;
        private C1.Win.C1Input.C1Button c1Button1;
    }
}