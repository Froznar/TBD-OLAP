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
            this.components = new System.ComponentModel.Container();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            this.c1OlapPage1 = new C1.Win.Olap.C1OlapPage();
            this.alemanaventasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alemana_ventasDataSet = new Themed4.Alemana_ventasDataSet();
            this.DimJer = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1OlapPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alemanaventasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alemana_ventasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // c1OlapPage1
            // 
            this.c1OlapPage1.BackColor = System.Drawing.Color.White;
            this.c1OlapPage1.DataSource = this.alemanaventasDataSetBindingSource;
            this.c1OlapPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1OlapPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1OlapPage1.Location = new System.Drawing.Point(0, 0);
            this.c1OlapPage1.Margin = new System.Windows.Forms.Padding(2);
            this.c1OlapPage1.Name = "c1OlapPage1";
            this.c1OlapPage1.Size = new System.Drawing.Size(668, 463);
            this.c1OlapPage1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.c1OlapPage1, "(default)");
            this.c1OlapPage1.Load += new System.EventHandler(this.c1OlapPage1_Load);
            // 
            // alemanaventasDataSetBindingSource
            // 
            this.alemanaventasDataSetBindingSource.DataSource = this.alemana_ventasDataSet;
            this.alemanaventasDataSetBindingSource.Position = 0;
            // 
            // alemana_ventasDataSet
            // 
            this.alemana_ventasDataSet.DataSetName = "Alemana_ventasDataSet";
            this.alemana_ventasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DimJer
            // 
            this.DimJer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DimJer.BackColor = System.Drawing.Color.White;
            this.DimJer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.DimJer.FormattingEnabled = true;
            this.DimJer.Location = new System.Drawing.Point(426, 255);
            this.DimJer.Margin = new System.Windows.Forms.Padding(2);
            this.DimJer.Name = "DimJer";
            this.DimJer.Size = new System.Drawing.Size(231, 184);
            this.DimJer.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.DimJer, "(default)");
            this.DimJer.SelectedIndexChanged += new System.EventHandler(this.DimJer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(0, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.c1ThemeController1.SetTheme(this.label1, "(default)");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 463);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DimJer);
            this.Controls.Add(this.c1OlapPage1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.c1ThemeController1.SetTheme(this, "(default)");
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1OlapPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alemanaventasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alemana_ventasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
        private C1.Win.Olap.C1OlapPage c1OlapPage1;
        private System.Windows.Forms.CheckedListBox DimJer;
        private System.Windows.Forms.BindingSource alemanaventasDataSetBindingSource;
        private Alemana_ventasDataSet alemana_ventasDataSet;
        private System.Windows.Forms.Label label1;
    }
}

