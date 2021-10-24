﻿namespace EasyCPDLC
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.outputTable = new System.Windows.Forms.TableLayoutPanel();
            this.atcButton = new System.Windows.Forms.Button();
            this.telexButton = new System.Windows.Forms.Button();
            this.retrieveButton = new System.Windows.Forms.Button();
            this.atcUnitLabel = new System.Windows.Forms.Label();
            this.atcUnitDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Oxygen", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.titleLabel.Location = new System.Drawing.Point(339, 3);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(186, 41);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "EasyCPDLC";
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Oxygen", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.exitButton.Location = new System.Drawing.Point(515, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(24, 24);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // outputTable
            // 
            this.outputTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.outputTable.ColumnCount = 2;
            this.outputTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.outputTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 433F));
            this.outputTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.outputTable.Location = new System.Drawing.Point(12, 66);
            this.outputTable.Name = "outputTable";
            this.outputTable.RowCount = 1;
            this.outputTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outputTable.Size = new System.Drawing.Size(513, 112);
            this.outputTable.TabIndex = 3;
            this.outputTable.Click += new System.EventHandler(this.outputTable_Click);
            // 
            // atcButton
            // 
            this.atcButton.Enabled = false;
            this.atcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atcButton.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Bold);
            this.atcButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.atcButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.atcButton.Location = new System.Drawing.Point(243, 12);
            this.atcButton.Name = "atcButton";
            this.atcButton.Size = new System.Drawing.Size(90, 48);
            this.atcButton.TabIndex = 4;
            this.atcButton.Text = "ATC";
            this.atcButton.UseVisualStyleBackColor = true;
            this.atcButton.Click += new System.EventHandler(this.requestButton_Click);
            // 
            // telexButton
            // 
            this.telexButton.Enabled = false;
            this.telexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.telexButton.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Bold);
            this.telexButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.telexButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.telexButton.Location = new System.Drawing.Point(147, 12);
            this.telexButton.Name = "telexButton";
            this.telexButton.Size = new System.Drawing.Size(90, 48);
            this.telexButton.TabIndex = 5;
            this.telexButton.Text = "TELEX";
            this.telexButton.UseVisualStyleBackColor = true;
            this.telexButton.Click += new System.EventHandler(this.telexButton_Click);
            // 
            // retrieveButton
            // 
            this.retrieveButton.Enabled = false;
            this.retrieveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retrieveButton.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Bold);
            this.retrieveButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.retrieveButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.retrieveButton.Location = new System.Drawing.Point(12, 12);
            this.retrieveButton.Name = "retrieveButton";
            this.retrieveButton.Size = new System.Drawing.Size(129, 48);
            this.retrieveButton.TabIndex = 6;
            this.retrieveButton.Text = "CONNECT";
            this.retrieveButton.UseVisualStyleBackColor = true;
            this.retrieveButton.Click += new System.EventHandler(this.retrieveButton_Click);
            // 
            // atcUnitLabel
            // 
            this.atcUnitLabel.AutoSize = true;
            this.atcUnitLabel.Font = new System.Drawing.Font("Oxygen", 11F, System.Drawing.FontStyle.Bold);
            this.atcUnitLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.atcUnitLabel.Location = new System.Drawing.Point(343, 44);
            this.atcUnitLabel.Name = "atcUnitLabel";
            this.atcUnitLabel.Size = new System.Drawing.Size(135, 19);
            this.atcUnitLabel.TabIndex = 7;
            this.atcUnitLabel.Text = "Current ATC Unit: ";
            // 
            // atcUnitDisplay
            // 
            this.atcUnitDisplay.AutoSize = true;
            this.atcUnitDisplay.Font = new System.Drawing.Font("Oxygen", 11F, System.Drawing.FontStyle.Bold);
            this.atcUnitDisplay.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.atcUnitDisplay.Location = new System.Drawing.Point(471, 44);
            this.atcUnitDisplay.Name = "atcUnitDisplay";
            this.atcUnitDisplay.Size = new System.Drawing.Size(51, 19);
            this.atcUnitDisplay.TabIndex = 8;
            this.atcUnitDisplay.Text = "NONE";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(537, 187);
            this.Controls.Add(this.atcUnitDisplay);
            this.Controls.Add(this.atcUnitLabel);
            this.Controls.Add(this.retrieveButton);
            this.Controls.Add(this.telexButton);
            this.Controls.Add(this.atcButton);
            this.Controls.Add(this.outputTable);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TableLayoutPanel outputTable;
        private System.Windows.Forms.Button atcButton;
        private System.Windows.Forms.Button telexButton;
        private System.Windows.Forms.Button retrieveButton;
        private System.Windows.Forms.Label atcUnitLabel;
        private System.Windows.Forms.Label atcUnitDisplay;
    }
}

