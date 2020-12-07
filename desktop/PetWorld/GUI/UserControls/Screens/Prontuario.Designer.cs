namespace PetWorld.GUI.UserControls.Screens
{
    partial class Prontuario
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
            this.lbNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Prontuário = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.BackColor = System.Drawing.Color.White;
            this.lbNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNome.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(0, 58);
            this.lbNome.Margin = new System.Windows.Forms.Padding(0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(600, 54);
            this.lbNome.TabIndex = 10;
            this.lbNome.Text = "Nome: ";
            this.lbNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 181);
            this.label1.TabIndex = 9;
            this.label1.Text = "Histórico \r\n\r\n01/04 - Vacinações \r\n\r\n23/05 -  Castração \r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Prontuário
            // 
            this.Prontuário.Dock = System.Windows.Forms.DockStyle.Top;
            this.Prontuário.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prontuário.Location = new System.Drawing.Point(0, 0);
            this.Prontuário.Margin = new System.Windows.Forms.Padding(0);
            this.Prontuário.Name = "Prontuário";
            this.Prontuário.Size = new System.Drawing.Size(600, 58);
            this.Prontuário.TabIndex = 8;
            this.Prontuário.Text = "Prontuário";
            this.Prontuário.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Prontuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(205)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.Prontuário);
            this.Name = "Prontuario";
            this.Size = new System.Drawing.Size(600, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Prontuário;
    }
}
