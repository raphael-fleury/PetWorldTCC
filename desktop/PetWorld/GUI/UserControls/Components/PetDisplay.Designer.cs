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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRaca = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.labelsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sexIconBox = new System.Windows.Forms.PictureBox();
            this.buttonsPanel.SuspendLayout();
            this.labelsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sexIconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNome.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(5, 10);
            this.lblNome.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblNome.Name = "lblNome";
            this.lblNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNome.Size = new System.Drawing.Size(203, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRaca
            // 
            this.lblRaca.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRaca.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaca.Location = new System.Drawing.Point(5, 65);
            this.lblRaca.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblRaca.Size = new System.Drawing.Size(203, 15);
            this.lblRaca.TabIndex = 1;
            this.lblRaca.Text = "Raça: ";
            // 
            // lblEspecie
            // 
            this.lblEspecie.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEspecie.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecie.Location = new System.Drawing.Point(5, 45);
            this.lblEspecie.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblEspecie.Size = new System.Drawing.Size(203, 15);
            this.lblEspecie.TabIndex = 2;
            this.lblEspecie.Text = "Espécie: ";
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResponsavel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsavel.Location = new System.Drawing.Point(5, 85);
            this.lblResponsavel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblResponsavel.Size = new System.Drawing.Size(203, 30);
            this.lblResponsavel.TabIndex = 3;
            this.lblResponsavel.Text = "Responsável:";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.btnDetails);
            this.buttonsPanel.Controls.Add(this.btnEdit);
            this.buttonsPanel.Controls.Add(this.btnDelete);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonsPanel.Location = new System.Drawing.Point(220, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(50, 150);
            this.buttonsPanel.TabIndex = 4;
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btnDetails.FlatAppearance.BorderSize = 0;
            this.btnDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(102)))), ((int)(((byte)(15)))));
            this.btnDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.Image = global::PetWorld.Properties.Resources.More_Horizontal__Black_18px_;
            this.btnDetails.Location = new System.Drawing.Point(0, 0);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(0);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(50, 50);
            this.btnDetails.TabIndex = 0;
            this.btnDetails.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(171)))), ((int)(((byte)(39)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(120)))), ((int)(((byte)(28)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(145)))), ((int)(((byte)(34)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::PetWorld.Properties.Resources.Edit__White_18px_;
            this.btnEdit.Location = new System.Drawing.Point(0, 50);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 50);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(44)))), ((int)(((byte)(34)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(33)))), ((int)(((byte)(26)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(51)))), ((int)(((byte)(39)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::PetWorld.Properties.Resources.X__White_18px_;
            this.btnDelete.Location = new System.Drawing.Point(0, 100);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // labelsPanel
            // 
            this.labelsPanel.Controls.Add(this.lblNome);
            this.labelsPanel.Controls.Add(this.lblEspecie);
            this.labelsPanel.Controls.Add(this.lblRaca);
            this.labelsPanel.Controls.Add(this.lblResponsavel);
            this.labelsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelsPanel.Location = new System.Drawing.Point(0, 0);
            this.labelsPanel.Name = "labelsPanel";
            this.labelsPanel.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.labelsPanel.Size = new System.Drawing.Size(220, 120);
            this.labelsPanel.TabIndex = 5;
            // 
            // sexIconBox
            // 
            this.sexIconBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sexIconBox.Image = global::PetWorld.Properties.Resources.Male;
            this.sexIconBox.Location = new System.Drawing.Point(198, 126);
            this.sexIconBox.Name = "sexIconBox";
            this.sexIconBox.Size = new System.Drawing.Size(16, 16);
            this.sexIconBox.TabIndex = 6;
            this.sexIconBox.TabStop = false;
            // 
            // PetDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.sexIconBox);
            this.Controls.Add(this.labelsPanel);
            this.Controls.Add(this.buttonsPanel);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.Name = "PetDisplay";
            this.Size = new System.Drawing.Size(270, 150);
            this.buttonsPanel.ResumeLayout(false);
            this.labelsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sexIconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.FlowLayoutPanel buttonsPanel;
        private System.Windows.Forms.FlowLayoutPanel labelsPanel;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox sexIconBox;
    }
}
