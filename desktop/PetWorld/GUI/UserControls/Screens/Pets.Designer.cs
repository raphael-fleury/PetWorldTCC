namespace PetWorld.GUI.UserControls.Screens
{
    partial class Pets
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.topButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.elementsDisplay1 = new PetWorld.GUI.UserControls.Components.ElementsDisplay();
            this.topButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // topButtons
            // 
            this.topButtons.Controls.Add(this.button1);
            this.topButtons.Controls.Add(this.button2);
            this.topButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.topButtons.Location = new System.Drawing.Point(10, 10);
            this.topButtons.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.topButtons.Name = "topButtons";
            this.topButtons.Size = new System.Drawing.Size(580, 25);
            this.topButtons.TabIndex = 2;
            // 
            // elementsDisplay1
            // 
            this.elementsDisplay1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.elementsDisplay1.Location = new System.Drawing.Point(10, 58);
            this.elementsDisplay1.Name = "elementsDisplay1";
            this.elementsDisplay1.Size = new System.Drawing.Size(580, 532);
            this.elementsDisplay1.TabIndex = 3;
            // 
            // Pets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(205)))));
            this.Controls.Add(this.elementsDisplay1);
            this.Controls.Add(this.topButtons);
            this.Name = "Pets";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(600, 600);
            this.topButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel topButtons;
        private Components.ElementsDisplay elementsDisplay1;
    }
}
