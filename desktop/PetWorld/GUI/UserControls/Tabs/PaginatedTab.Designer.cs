using PetWorld.GUI.UserControls.Screens;

namespace PetWorld.GUI.UserControls.Tabs
{
    partial class PaginatedTab
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
            this.screen = new PetWorld.GUI.UserControls.Screens.TabScreen();
            this.header = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(205)))));
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Margin = new System.Windows.Forms.Padding(0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(600, 600);
            this.screen.TabIndex = 5;
            // 
            // header
            // 
            this.header.Controls.Add(this.lblTitle);
            this.header.Controls.Add(this.btnReturn);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Padding = new System.Windows.Forms.Padding(10);
            this.header.Size = new System.Drawing.Size(600, 70);
            this.header.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(60, 10);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(530, 50);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Título";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReturn.Enabled = false;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(102)))), ((int)(((byte)(15)))));
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Image = global::PetWorld.Properties.Resources.Arrow_Left__Black_18px_;
            this.btnReturn.Location = new System.Drawing.Point(10, 10);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(50, 50);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // PaginatedTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(205)))));
            this.Controls.Add(this.header);
            this.Controls.Add(this.screen);
            this.Name = "PaginatedTab";
            this.Controls.SetChildIndex(this.screen, 0);
            this.Controls.SetChildIndex(this.header, 0);
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TabScreen screen;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnReturn;
    }
}
