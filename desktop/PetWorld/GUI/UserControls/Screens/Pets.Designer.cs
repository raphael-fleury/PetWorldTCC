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
            this.topButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.elementsDisplay1 = new PetWorld.GUI.UserControls.Components.ElementsDisplay();
            this.btAdd = new System.Windows.Forms.Button();
            this.topButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // topButtons
            // 
            this.topButtons.Controls.Add(this.btAdd);
            this.topButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.topButtons.Location = new System.Drawing.Point(10, 10);
            this.topButtons.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.topButtons.Name = "topButtons";
            this.topButtons.Size = new System.Drawing.Size(580, 50);
            this.topButtons.TabIndex = 2;
            // 
            // elementsDisplay1
            // 
            this.elementsDisplay1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.elementsDisplay1.Location = new System.Drawing.Point(10, 90);
            this.elementsDisplay1.Name = "elementsDisplay1";
            this.elementsDisplay1.Size = new System.Drawing.Size(580, 500);
            this.elementsDisplay1.TabIndex = 3;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(102)))), ((int)(((byte)(15)))));
            this.btAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Image = global::PetWorld.Properties.Resources.Add__Black_18px_;
            this.btAdd.Location = new System.Drawing.Point(0, 0);
            this.btAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(50, 50);
            this.btAdd.TabIndex = 1;
            this.btAdd.UseVisualStyleBackColor = false;
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
        private System.Windows.Forms.FlowLayoutPanel topButtons;
        private System.Windows.Forms.Button btAdd;
        private Components.ElementsDisplay elementsDisplay1;
    }
}
