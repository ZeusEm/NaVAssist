﻿namespace ChatBotProject
{
    partial class bubble
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblmessgae = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblmessgae
            // 
            this.lblmessgae.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmessgae.BackColor = System.Drawing.Color.Transparent;
            this.lblmessgae.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessgae.ForeColor = System.Drawing.Color.White;
            this.lblmessgae.Location = new System.Drawing.Point(10, 13);
            this.lblmessgae.Name = "lblmessgae";
            this.lblmessgae.Size = new System.Drawing.Size(616, 43);
            this.lblmessgae.TabIndex = 2;
            this.lblmessgae.Text = "I\'m a Barbie girl in the Barbie world. Life in plastic, it\'s fantastic! You can b" +
    "rush my hair, undress me everywhere. Imagination, life is your creation. Come on" +
    ", Barbie, let\'s go party!";
            this.lblmessgae.Click += new System.EventHandler(this.lblmessgae_Click);
            // 
            // bubble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.lblmessgae);
            this.Name = "bubble";
            this.Size = new System.Drawing.Size(644, 66);
            this.Load += new System.EventHandler(this.bubble_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lblmessgae;
    }
}