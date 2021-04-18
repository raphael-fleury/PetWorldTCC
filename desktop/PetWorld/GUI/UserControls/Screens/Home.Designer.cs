
namespace PetWorld.GUI.UserControls.Screens
{
    partial class Home
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
            this.lblRaphael = new System.Windows.Forms.Label();
            this.lblVitoria = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblCriacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRaphael
            // 
            this.lblRaphael.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaphael.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(34)))), ((int)(((byte)(6)))));
            this.lblRaphael.Location = new System.Drawing.Point(10, 539);
            this.lblRaphael.Name = "lblRaphael";
            this.lblRaphael.Size = new System.Drawing.Size(580, 25);
            this.lblRaphael.TabIndex = 0;
            this.lblRaphael.Text = "Raphael Fleury";
            this.lblRaphael.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVitoria
            // 
            this.lblVitoria.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVitoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(34)))), ((int)(((byte)(6)))));
            this.lblVitoria.Location = new System.Drawing.Point(10, 564);
            this.lblVitoria.Name = "lblVitoria";
            this.lblVitoria.Size = new System.Drawing.Size(580, 25);
            this.lblVitoria.TabIndex = 2;
            this.lblVitoria.Text = "Vitória Basile";
            this.lblVitoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoBox
            // 
            this.logoBox.Image = global::PetWorld.Properties.Resources.PetWorld;
            this.logoBox.Location = new System.Drawing.Point(230, 84);
            this.logoBox.Margin = new System.Windows.Forms.Padding(40);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(140, 140);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 3;
            this.logoBox.TabStop = false;
            // 
            // lblSlogan
            // 
            this.lblSlogan.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(34)))), ((int)(((byte)(6)))));
            this.lblSlogan.Location = new System.Drawing.Point(9, 244);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(580, 25);
            this.lblSlogan.TabIndex = 4;
            this.lblSlogan.Text = "A melhor solução para a sua clínica veterinária.";
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCriacao
            // 
            this.lblCriacao.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(34)))), ((int)(((byte)(6)))));
            this.lblCriacao.Location = new System.Drawing.Point(10, 514);
            this.lblCriacao.Name = "lblCriacao";
            this.lblCriacao.Size = new System.Drawing.Size(580, 25);
            this.lblCriacao.TabIndex = 5;
            this.lblCriacao.Text = "Criação de:";
            this.lblCriacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCriacao);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.lblVitoria);
            this.Controls.Add(this.lblRaphael);
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(600, 600);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRaphael;
        private System.Windows.Forms.Label lblVitoria;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblCriacao;
    }
}
