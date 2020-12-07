
namespace PetWorld.GUI.UserControls.Screens
{
    partial class Selector<T>
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
            this.topButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btReturn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menu = new PetWorld.GUI.UserControls.Screens.Tab();
            this.topButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // topButtons
            // 
            this.topButtons.Controls.Add(this.btReturn);
            this.topButtons.Controls.Add(this.title);
            this.topButtons.Controls.Add(this.button1);
            this.topButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.topButtons.Location = new System.Drawing.Point(0, 0);
            this.topButtons.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.topButtons.Name = "topButtons";
            this.topButtons.Padding = new System.Windows.Forms.Padding(10);
            this.topButtons.Size = new System.Drawing.Size(600, 70);
            this.topButtons.TabIndex = 3;
            // 
            // btReturn
            // 
            this.btReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
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
            this.btReturn.TabIndex = 1;
            this.btReturn.UseVisualStyleBackColor = false;
            this.btReturn.Click += new System.EventHandler(this.Return);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(70, 10);
            this.title.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.title.Name = "title";
            this.title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.title.Size = new System.Drawing.Size(460, 50);
            this.title.TabIndex = 11;
            this.title.Text = "Selecionar";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(102)))), ((int)(((byte)(15)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::PetWorld.Properties.Resources.Done__Black_18px_;
            this.button1.Location = new System.Drawing.Point(540, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Done);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(205)))));
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.Location = new System.Drawing.Point(0, 70);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(600, 530);
            this.menu.TabIndex = 4;
            // 
            // Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menu);
            this.Controls.Add(this.topButtons);
            this.Name = "Selector";
            this.Size = new System.Drawing.Size(600, 600);
            this.topButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.FlowLayoutPanel topButtons;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Label title;
        private Tab menu;
        private System.Windows.Forms.Button button1;
    }
}
