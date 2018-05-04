namespace Themed4
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
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            this.c1OlapPage1 = new C1.Win.Olap.C1OlapPage();
            this.DimJer = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1OlapPage1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1OlapPage1
            // 
            this.c1OlapPage1.BackColor = System.Drawing.Color.White;
            this.c1OlapPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1OlapPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1OlapPage1.Location = new System.Drawing.Point(0, 0);
            this.c1OlapPage1.Margin = new System.Windows.Forms.Padding(2);
            this.c1OlapPage1.Name = "c1OlapPage1";
            this.c1OlapPage1.Size = new System.Drawing.Size(891, 570);
            this.c1OlapPage1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.c1OlapPage1, "(default)");
            this.c1OlapPage1.Load += new System.EventHandler(this.c1OlapPage1_Load);
            // 
            // DimJer
            // 
            this.DimJer.BackColor = System.Drawing.Color.White;
            this.DimJer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.DimJer.FormattingEnabled = true;
            this.DimJer.Location = new System.Drawing.Point(584, 345);
            this.DimJer.Name = "DimJer";
            this.DimJer.Size = new System.Drawing.Size(307, 225);
            this.DimJer.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.DimJer, "(default)");
            this.DimJer.SelectedIndexChanged += new System.EventHandler(this.DimJer_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 570);
            this.Controls.Add(this.DimJer);
            this.Controls.Add(this.c1OlapPage1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.c1ThemeController1.SetTheme(this, "(default)");
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1OlapPage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
        private C1.Win.Olap.C1OlapPage c1OlapPage1;
        private System.Windows.Forms.CheckedListBox DimJer;
    }
}

