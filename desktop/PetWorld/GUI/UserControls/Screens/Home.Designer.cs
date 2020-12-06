
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
            this.raphael = new System.Windows.Forms.Label();
            this.steffanie = new System.Windows.Forms.Label();
            this.vitoria = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.chamada = new System.Windows.Forms.Label();
            this.criacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // raphael
            // 
            this.raphael.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raphael.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(34)))), ((int)(((byte)(6)))));
            this.raphael.Location = new System.Drawing.Point(10, 500);
            this.raphael.Name = "raphael";
            this.raphael.Size = new System.Drawing.Size(580, 25);
            this.raphael.TabIndex = 0;
            this.raphael.Text = "Raphael Imperator";
            this.raphael.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // steffanie
            // 
            this.steffanie.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steffanie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(34)))), ((int)(((byte)(6)))));
            this.steffanie.Location = new System.Drawing.Point(10, 525);
            this.steffanie.Name = "steffanie";
            this.steffanie.Size = new System.Drawing.Size(580, 25);
            this.steffanie.TabIndex = 1;
            this.steffanie.Text = "Steffanie Graner";
            this.steffanie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vitoria
            // 
            this.vitoria.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vitoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(34)))), ((int)(((byte)(6)))));
            this.vitoria.Location = new System.Drawing.Point(10, 550);
            this.vitoria.Name = "vitoria";
            this.vitoria.Size = new System.Drawing.Size(580, 25);
            this.vitoria.TabIndex = 2;
            this.vitoria.Text = "Vitória Basile";
            this.vitoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.vitoria.Click += new System.EventHandler(this.vitoria_Click);
            // 
            // logoBox
            // 
            this.logoBox.Image = global::PetWorld.Properties.Resources.PetWorld;
            this.logoBox.Location = new System.Drawing.Point(230, 92);
            this.logoBox.Margin = new System.Windows.Forms.Padding(40);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(140, 140);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 3;
            this.logoBox.TabStop = false;
            // 
            // chamada
            // 
            this.chamada.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chamada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(34)))), ((int)(((byte)(6)))));
            this.chamada.Location = new System.Drawing.Point(9, 252);
            this.chamada.Name = "chamada";
            this.chamada.Size = new System.Drawing.Size(580, 25);
            this.chamada.TabIndex = 4;
            this.chamada.Text = "A melhor solução para a sua clínica veterinária.";
            this.chamada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // criacao
            // 
            this.criacao.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(34)))), ((int)(((byte)(6)))));
            this.criacao.Location = new System.Drawing.Point(10, 475);
            this.criacao.Name = "criacao";
            this.criacao.Size = new System.Drawing.Size(580, 25);
            this.criacao.TabIndex = 5;
            this.criacao.Text = "Criação de:";
            this.criacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.criacao);
            this.Controls.Add(this.chamada);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.vitoria);
            this.Controls.Add(this.steffanie);
            this.Controls.Add(this.raphael);
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(600, 600);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label raphael;
        private System.Windows.Forms.Label steffanie;
        private System.Windows.Forms.Label vitoria;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label chamada;
        private System.Windows.Forms.Label criacao;
    }
}
