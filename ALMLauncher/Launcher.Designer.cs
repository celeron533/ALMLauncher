﻿namespace ALMLauncher
{
    partial class Launcher
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
            this.buttonLau = new System.Windows.Forms.Button();
            this.listBoxDep = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLau
            // 
            this.buttonLau.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLau.Location = new System.Drawing.Point(705, 437);
            this.buttonLau.Name = "buttonLau";
            this.buttonLau.Size = new System.Drawing.Size(168, 55);
            this.buttonLau.TabIndex = 0;
            this.buttonLau.Text = "Launch";
            this.buttonLau.UseVisualStyleBackColor = true;
            this.buttonLau.Click += new System.EventHandler(this.buttonLau_Click);
            // 
            // listBoxDep
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.listBoxDep, 2);
            this.listBoxDep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDep.FormattingEnabled = true;
            this.listBoxDep.ItemHeight = 20;
            this.listBoxDep.Location = new System.Drawing.Point(13, 13);
            this.listBoxDep.Name = "listBoxDep";
            this.listBoxDep.Size = new System.Drawing.Size(860, 418);
            this.listBoxDep.TabIndex = 1;
            this.listBoxDep.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxDep_MouseDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.listBoxDep, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonLau, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(886, 505);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 505);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Launcher";
            this.Text = "HP-ALM Launcher";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLau;
        private System.Windows.Forms.ListBox listBoxDep;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
