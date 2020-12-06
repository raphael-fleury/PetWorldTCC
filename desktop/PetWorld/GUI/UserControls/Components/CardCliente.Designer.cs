namespace PetWorld.GUI.UserControls.Components
{
    partial class CardCliente
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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbPets = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.labelsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.detailsButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.buttonsPanel.SuspendLayout();
            this.labelsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNome.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(5, 10);
            this.lbNome.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lbNome.Name = "lbNome";
            this.lbNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbNome.Size = new System.Drawing.Size(203, 25);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            this.lbNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTelefone
            // 
            this.lbTelefone.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTelefone.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.Location = new System.Drawing.Point(5, 64);
            this.lbTelefone.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbTelefone.Size = new System.Drawing.Size(203, 15);
            this.lbTelefone.TabIndex = 1;
            this.lbTelefone.Text = "Telefone: ";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbEndereco.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndereco.Location = new System.Drawing.Point(5, 45);
            this.lbEndereco.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbEndereco.Size = new System.Drawing.Size(66, 14);
            this.lbEndereco.TabIndex = 2;
            this.lbEndereco.Text = "Endereço: ";
            // 
            // lbPets
            // 
            this.lbPets.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPets.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPets.Location = new System.Drawing.Point(5, 84);
            this.lbPets.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbPets.Name = "lbPets";
            this.lbPets.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbPets.Size = new System.Drawing.Size(203, 30);
            this.lbPets.TabIndex = 3;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.detailsButton);
            this.buttonsPanel.Controls.Add(this.editButton);
            this.buttonsPanel.Controls.Add(this.deleteButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonsPanel.Location = new System.Drawing.Point(220, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(50, 150);
            this.buttonsPanel.TabIndex = 4;
            // 
            // labelsPanel
            // 
            this.labelsPanel.Controls.Add(this.lbNome);
            this.labelsPanel.Controls.Add(this.lbEndereco);
            this.labelsPanel.Controls.Add(this.lbTelefone);
            this.labelsPanel.Controls.Add(this.lbPets);
            this.labelsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelsPanel.Location = new System.Drawing.Point(0, 0);
            this.labelsPanel.Name = "labelsPanel";
            this.labelsPanel.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.labelsPanel.Size = new System.Drawing.Size(220, 150);
            this.labelsPanel.TabIndex = 5;
            // 
            // detailsButton
            // 
            this.detailsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.detailsButton.FlatAppearance.BorderSize = 0;
            this.detailsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(102)))), ((int)(((byte)(15)))));
            this.detailsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.detailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detailsButton.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsButton.Image = global::PetWorld.Properties.Resources.More_Horizontal__Black_18px_;
            this.detailsButton.Location = new System.Drawing.Point(0, 0);
            this.detailsButton.Margin = new System.Windows.Forms.Padding(0);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(50, 50);
            this.detailsButton.TabIndex = 0;
            this.detailsButton.UseVisualStyleBackColor = false;
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
            // ClienteDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.labelsPanel);
            this.Controls.Add(this.buttonsPanel);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.Name = "ClienteDisplay";
            this.Size = new System.Drawing.Size(270, 150);
            this.buttonsPanel.ResumeLayout(false);
            this.labelsPanel.ResumeLayout(false);
            this.labelsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbPets;
        private System.Windows.Forms.FlowLayoutPanel buttonsPanel;
        private System.Windows.Forms.FlowLayoutPanel labelsPanel;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
    }
}
