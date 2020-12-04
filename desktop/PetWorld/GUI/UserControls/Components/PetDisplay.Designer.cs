namespace PetWorld.GUI.UserControls.Components
{
    partial class PetDisplay
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
            this.lblRaca = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.moreButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
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
            // lblRaca
            // 
            this.lblRaca.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaca.Location = new System.Drawing.Point(5, 65);
            this.lblRaca.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblRaca.Size = new System.Drawing.Size(153, 15);
            this.lblRaca.TabIndex = 1;
            this.lblRaca.Text = "Raça: ";
            // 
            // lblEspecie
            // 
            this.lblEspecie.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecie.Location = new System.Drawing.Point(5, 45);
            this.lblEspecie.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblEspecie.Size = new System.Drawing.Size(153, 15);
            this.lblEspecie.TabIndex = 2;
            this.lblEspecie.Text = "Espécie: ";
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
            this.lblResponsavel.Text = "Responsável: ";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.moreButton);
            this.buttonsPanel.Controls.Add(this.editButton);
            this.buttonsPanel.Controls.Add(this.deleteButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonsPanel.Location = new System.Drawing.Point(220, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(50, 150);
            this.buttonsPanel.TabIndex = 4;
            // 
            // moreButton
            // 
            this.moreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.moreButton.FlatAppearance.BorderSize = 0;
            this.moreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(102)))), ((int)(((byte)(15)))));
            this.moreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.moreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreButton.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreButton.Image = global::PetWorld.Properties.Resources.More_Horizontal__Black_18px_;
            this.moreButton.Location = new System.Drawing.Point(0, 0);
            this.moreButton.Margin = new System.Windows.Forms.Padding(0);
            this.moreButton.Name = "moreButton";
            this.moreButton.Size = new System.Drawing.Size(50, 50);
            this.moreButton.TabIndex = 0;
            this.moreButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(171)))), ((int)(((byte)(39)))));
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(120)))), ((int)(((byte)(28)))));
            this.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(145)))), ((int)(((byte)(34)))));
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Image = global::PetWorld.Properties.Resources.Edit__White_18px_;
            this.editButton.Location = new System.Drawing.Point(0, 50);
            this.editButton.Margin = new System.Windows.Forms.Padding(0);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(50, 50);
            this.editButton.TabIndex = 1;
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(44)))), ((int)(((byte)(34)))));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(33)))), ((int)(((byte)(26)))));
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(51)))), ((int)(((byte)(39)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Image = global::PetWorld.Properties.Resources.X__White_18px_;
            this.deleteButton.Location = new System.Drawing.Point(0, 100);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(50, 50);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // labelsPanel
            // 
            this.labelsPanel.Controls.Add(this.lblName);
            this.labelsPanel.Controls.Add(this.lblEspecie);
            this.labelsPanel.Controls.Add(this.lblRaca);
            this.labelsPanel.Controls.Add(this.lblResponsavel);
            this.labelsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelsPanel.Location = new System.Drawing.Point(0, 0);
            this.labelsPanel.Name = "labelsPanel";
            this.labelsPanel.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.labelsPanel.Size = new System.Drawing.Size(220, 150);
            this.labelsPanel.TabIndex = 5;
            // 
            // PetDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.labelsPanel);
            this.Controls.Add(this.buttonsPanel);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.Name = "PetDisplay";
            this.Size = new System.Drawing.Size(270, 150);
            this.buttonsPanel.ResumeLayout(false);
            this.labelsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.FlowLayoutPanel buttonsPanel;
        private System.Windows.Forms.FlowLayoutPanel labelsPanel;
        private System.Windows.Forms.Button moreButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
    }
}
