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
            this.title = new System.Windows.Forms.Label();
            this.btReturn = new System.Windows.Forms.Button();
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
            this.header.Controls.Add(this.title);
            this.header.Controls.Add(this.btReturn);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Padding = new System.Windows.Forms.Padding(10);
            this.header.Size = new System.Drawing.Size(600, 70);
            this.header.TabIndex = 6;
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(60, 10);
            this.title.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.title.Size = new System.Drawing.Size(530, 50);
            this.title.TabIndex = 9;
            this.title.Text = "Título";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btReturn
            // 
            this.btReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btReturn.Dock = System.Windows.Forms.DockStyle.Left;
            this.btReturn.Enabled = false;
            this.btReturn.FlatAppearance.BorderSize = 0;
            this.btReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(102)))), ((int)(((byte)(15)))));
            this.btReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReturn.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReturn.Image = global::PetWorld.Properties.Resources.Arrow_Left__Black_18px_;
            this.btReturn.Location = new System.Drawing.Point(10, 10);
            this.btReturn.Margin = new System.Windows.Forms.Padding(0);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(50, 50);
            this.btReturn.TabIndex = 8;
            this.btReturn.UseVisualStyleBackColor = false;
            // 
            // Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(205)))));
            this.Controls.Add(this.header);
            this.Controls.Add(this.screen);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Tab";
            this.Size = new System.Drawing.Size(600, 600);
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TabScreen screen;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btReturn;
    }
}
