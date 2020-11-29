namespace PetWorld.GUI.UserControls.Components
{
    partial class Pet
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblRaça = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btDetails = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonsPanel.SuspendLayout();
            this.labelsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(5, 10);
            this.lblName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(217, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRaça
            // 
            this.lblRaça.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaça.Location = new System.Drawing.Point(5, 45);
            this.lblRaça.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblRaça.Name = "lblRaça";
            this.lblRaça.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblRaça.Size = new System.Drawing.Size(153, 15);
            this.lblRaça.TabIndex = 1;
            this.lblRaça.Text = "Raça:";
            // 
            // lblEspecie
            // 
            this.lblEspecie.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecie.Location = new System.Drawing.Point(5, 65);
            this.lblEspecie.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblEspecie.Size = new System.Drawing.Size(153, 15);
            this.lblEspecie.TabIndex = 2;
            this.lblEspecie.Text = "Espécie:";
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsavel.Location = new System.Drawing.Point(5, 85);
            this.lblResponsavel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblResponsavel.Size = new System.Drawing.Size(153, 15);
            this.lblResponsavel.TabIndex = 3;
            this.lblResponsavel.Text = "Responsável:";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.btDetails);
            this.buttonsPanel.Controls.Add(this.button1);
            this.buttonsPanel.Controls.Add(this.button2);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonsPanel.Location = new System.Drawing.Point(220, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(50, 150);
            this.buttonsPanel.TabIndex = 4;
            // 
            // btDetails
            // 
            this.btDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btDetails.FlatAppearance.BorderSize = 0;
            this.btDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(102)))), ((int)(((byte)(15)))));
            this.btDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDetails.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDetails.Location = new System.Drawing.Point(0, 0);
            this.btDetails.Margin = new System.Windows.Forms.Padding(0);
            this.btDetails.Name = "btDetails";
            this.btDetails.Size = new System.Drawing.Size(50, 50);
            this.btDetails.TabIndex = 0;
            this.btDetails.Text = "...";
            this.btDetails.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(171)))), ((int)(((byte)(39)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(120)))), ((int)(((byte)(28)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(145)))), ((int)(((byte)(34)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(44)))), ((int)(((byte)(34)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(33)))), ((int)(((byte)(26)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(51)))), ((int)(((byte)(39)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 100);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // labelsPanel
            // 
            this.labelsPanel.Controls.Add(this.lblName);
            this.labelsPanel.Controls.Add(this.lblRaça);
            this.labelsPanel.Controls.Add(this.lblEspecie);
            this.labelsPanel.Controls.Add(this.lblResponsavel);
            this.labelsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelsPanel.Location = new System.Drawing.Point(0, 0);
            this.labelsPanel.Name = "labelsPanel";
            this.labelsPanel.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.labelsPanel.Size = new System.Drawing.Size(220, 150);
            this.labelsPanel.TabIndex = 5;
            // 
            // Pet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.labelsPanel);
            this.Controls.Add(this.buttonsPanel);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.Name = "Pet";
            this.Size = new System.Drawing.Size(270, 150);
            this.buttonsPanel.ResumeLayout(false);
            this.labelsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRaça;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.FlowLayoutPanel buttonsPanel;
        private System.Windows.Forms.FlowLayoutPanel labelsPanel;
        private System.Windows.Forms.Button btDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
