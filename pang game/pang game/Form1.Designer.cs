﻿using System;

namespace pang_game
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
            this.pbPlayerShip = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerShip)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayerShip
            // 
            this.pbPlayerShip.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayerShip.BackgroundImage = global::pang_game.Properties.Resources.player;
            this.pbPlayerShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlayerShip.InitialImage = null;
            this.pbPlayerShip.Location = new System.Drawing.Point(375, 269);
            this.pbPlayerShip.Name = "pbPlayerShip";
            this.pbPlayerShip.Size = new System.Drawing.Size(113, 87);
            this.pbPlayerShip.TabIndex = 0;
            this.pbPlayerShip.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pang_game.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 480);
            this.Controls.Add(this.pbPlayerShip);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerShip)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.PictureBox pbPlayerShip;
        private System.Windows.Forms.Timer timer1;
    }
}

