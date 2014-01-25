﻿/*
 * Copyright (c) 2010-2014 Updater <https://github.com/BenDol/Basic-Updater>
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */
using System.Drawing;

namespace Updater.Interface {
    partial class Ui {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ui));
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblUptodate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.imgTick = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customTabControl1 = new System.Windows.Forms.CustomTabControl();
            this.tabChangelog = new System.Windows.Forms.TabPage();
            this.txtboxChangelog = new System.Windows.Forms.TextBox();
            this.tabUpdatelogs = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnClose = new Updater.Interface.GlossyButton();
            this.prettyProgress1 = new Updater.Interface.PrettyProgressBar();
            this.btnPlay = new Updater.Interface.GlossyButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customTabControl1.SuspendLayout();
            this.tabChangelog.SuspendLayout();
            this.tabUpdatelogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(7, 274);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(76, 11);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status: Waiting...";
            // 
            // lblUptodate
            // 
            this.lblUptodate.AutoSize = true;
            this.lblUptodate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUptodate.Location = new System.Drawing.Point(412, 283);
            this.lblUptodate.Name = "lblUptodate";
            this.lblUptodate.Size = new System.Drawing.Size(62, 13);
            this.lblUptodate.TabIndex = 7;
            this.lblUptodate.Text = "Up to date!";
            this.lblUptodate.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Moltors", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblName.Location = new System.Drawing.Point(4, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(182, 37);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Gamename";
            this.lblName.Visible = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = global::Updater.Properties.Resources.minimize_icon;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Location = new System.Drawing.Point(469, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(16, 16);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMinimize_MouseClick);
            this.btnMinimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMinimize_MouseDown);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            // 
            // imgTick
            // 
            this.imgTick.Image = global::Updater.Properties.Resources.tick_blue;
            this.imgTick.Location = new System.Drawing.Point(475, 277);
            this.imgTick.Name = "imgTick";
            this.imgTick.Size = new System.Drawing.Size(27, 26);
            this.imgTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTick.TabIndex = 6;
            this.imgTick.TabStop = false;
            this.imgTick.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Image = global::Updater.Properties.Resources.refresh_normal;
            this.btnRefresh.Location = new System.Drawing.Point(5, 304);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(45, 47);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.MouseEnter += new System.EventHandler(this.btnRefresh_MouseEnter);
            this.btnRefresh.MouseLeave += new System.EventHandler(this.btnRefresh_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Updater.Properties.Resources.repair;
            this.pictureBox1.Location = new System.Drawing.Point(479, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // customTabControl1
            // 
            this.customTabControl1.Controls.Add(this.tabChangelog);
            this.customTabControl1.Controls.Add(this.tabUpdatelogs);
            this.customTabControl1.DisplayStyle = System.Windows.Forms.TabStyle.Chrome;
            // 
            // 
            // 
            this.customTabControl1.DisplayStyleProvider.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.customTabControl1.DisplayStyleProvider.BorderColorHot = System.Drawing.SystemColors.ControlDark;
            this.customTabControl1.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.customTabControl1.DisplayStyleProvider.CloserColor = System.Drawing.Color.DarkGray;
            this.customTabControl1.DisplayStyleProvider.CloserColorActive = System.Drawing.Color.White;
            this.customTabControl1.DisplayStyleProvider.FocusTrack = false;
            this.customTabControl1.DisplayStyleProvider.HotTrack = true;
            this.customTabControl1.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customTabControl1.DisplayStyleProvider.Opacity = 1F;
            this.customTabControl1.DisplayStyleProvider.Overlap = 16;
            this.customTabControl1.DisplayStyleProvider.Padding = new System.Drawing.Point(7, 5);
            this.customTabControl1.DisplayStyleProvider.Radius = 16;
            this.customTabControl1.DisplayStyleProvider.ShowTabCloser = false;
            this.customTabControl1.DisplayStyleProvider.TextColor = System.Drawing.SystemColors.ControlText;
            this.customTabControl1.DisplayStyleProvider.TextColorDisabled = System.Drawing.SystemColors.ControlDark;
            this.customTabControl1.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this.customTabControl1.HotTrack = true;
            this.customTabControl1.Location = new System.Drawing.Point(4, 53);
            this.customTabControl1.Name = "customTabControl1";
            this.customTabControl1.SelectedIndex = 0;
            this.customTabControl1.Size = new System.Drawing.Size(502, 220);
            this.customTabControl1.TabIndex = 13;
            // 
            // tabChangelog
            // 
            this.tabChangelog.Controls.Add(this.splitContainer2);
            this.tabChangelog.Location = new System.Drawing.Point(4, 25);
            this.tabChangelog.Name = "tabChangelog";
            this.tabChangelog.Padding = new System.Windows.Forms.Padding(3);
            this.tabChangelog.Size = new System.Drawing.Size(494, 191);
            this.tabChangelog.TabIndex = 0;
            this.tabChangelog.Text = "Changelog";
            this.tabChangelog.ToolTipText = "New updates changelog";
            this.tabChangelog.UseVisualStyleBackColor = true;
            // 
            // txtboxChangelog
            // 
            this.txtboxChangelog.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxChangelog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxChangelog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxChangelog.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxChangelog.Location = new System.Drawing.Point(0, 0);
            this.txtboxChangelog.Multiline = true;
            this.txtboxChangelog.Name = "txtboxChangelog";
            this.txtboxChangelog.ReadOnly = true;
            this.txtboxChangelog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxChangelog.Size = new System.Drawing.Size(322, 185);
            this.txtboxChangelog.TabIndex = 1;
            this.txtboxChangelog.TabStop = false;
            // 
            // tabUpdatelogs
            // 
            this.tabUpdatelogs.Controls.Add(this.splitContainer1);
            this.tabUpdatelogs.Location = new System.Drawing.Point(4, 25);
            this.tabUpdatelogs.Name = "tabUpdatelogs";
            this.tabUpdatelogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdatelogs.Size = new System.Drawing.Size(494, 191);
            this.tabUpdatelogs.TabIndex = 1;
            this.tabUpdatelogs.Text = "Update Logs";
            this.tabUpdatelogs.ToolTipText = "Previous update information";
            this.tabUpdatelogs.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Size = new System.Drawing.Size(488, 183);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(162, 183);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(325, 183);
            this.textBox1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtboxChangelog);
            this.splitContainer2.Size = new System.Drawing.Size(488, 185);
            this.splitContainer2.SplitterDistance = 162;
            this.splitContainer2.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 14;
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(162, 185);
            this.listBox2.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.ActiveBackColor = System.Drawing.Color.Transparent;
            this.btnClose.ActiveBorderColor = System.Drawing.Color.Transparent;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Updater.Properties.Resources.close_icon;
            this.btnClose.BorderColor = System.Drawing.Color.Transparent;
            this.btnClose.BtnText = "";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverBorderColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(490, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.StandbyBackColor = System.Drawing.Color.Transparent;
            this.btnClose.StandbyBorderColor = System.Drawing.Color.Transparent;
            this.btnClose.TabIndex = 10;
            this.btnClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseClick);
            this.btnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseDown);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // prettyProgress1
            // 
            this.prettyProgress1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prettyProgress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prettyProgress1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.prettyProgress1.Location = new System.Drawing.Point(54, 310);
            this.prettyProgress1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.prettyProgress1.Name = "prettyProgress1";
            this.prettyProgress1.Size = new System.Drawing.Size(368, 37);
            this.prettyProgress1.TabIndex = 9;
            this.prettyProgress1.Value = 0F;
            // 
            // btnPlay
            // 
            this.btnPlay.ActiveBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPlay.ActiveBorderColor = System.Drawing.Color.White;
            this.btnPlay.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPlay.BorderColor = System.Drawing.Color.White;
            this.btnPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnPlay.BtnText = "Updating";
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Enabled = false;
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlay.HoverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnPlay.HoverBorderColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(427, 309);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(76, 39);
            this.btnPlay.StandbyBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPlay.StandbyBorderColor = System.Drawing.Color.White;
            this.btnPlay.TabIndex = 8;
            // 
            // Ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(511, 355);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customTabControl1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.prettyProgress1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblUptodate);
            this.Controls.Add(this.imgTick);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ui";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.MaximumSizeChanged += new System.EventHandler(this.Ui_MaximumSizeChanged);
            this.SizeChanged += new System.EventHandler(this.Ui_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Ui_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.imgTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customTabControl1.ResumeLayout(false);
            this.tabChangelog.ResumeLayout(false);
            this.tabUpdatelogs.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox imgTick;
        private System.Windows.Forms.Label lblUptodate;
        private GlossyButton btnPlay;
        private PrettyProgressBar prettyProgress1;
        private GlossyButton btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtboxChangelog;
        private System.Windows.Forms.CustomTabControl customTabControl1;
        private System.Windows.Forms.TabPage tabChangelog;
        private System.Windows.Forms.TabPage tabUpdatelogs;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox listBox2;
    }
}

