namespace PetWorld.GUI.UserControls.Screens
{
    partial class ClienteDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.btReturn = new System.Windows.Forms.Button();
            this.formPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.labelsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.labelsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.btReturn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 50);
            this.panel1.TabIndex = 3;
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(50, 0);
            this.title.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.title.Size = new System.Drawing.Size(530, 50);
            this.title.TabIndex = 9;
            this.title.Text = "Nome";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btReturn
            // 
            this.btReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btReturn.Dock = System.Windows.Forms.DockStyle.Left;
            this.btReturn.FlatAppearance.BorderSize = 0;
            this.btReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(102)))), ((int)(((byte)(15)))));
            this.btReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReturn.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReturn.Image = global::PetWorld.Properties.Resources.Arrow_Left__Black_18px_;
            this.btReturn.Location = new System.Drawing.Point(0, 0);
            this.btReturn.Margin = new System.Windows.Forms.Padding(0);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(50, 50);
            this.btReturn.TabIndex = 8;
            this.btReturn.UseVisualStyleBackColor = false;
            this.btReturn.Click += new System.EventHandler(this.Return);
            // 
            // formPanel
            // 
            this.formPanel.Controls.Add(this.lbNome);
            this.formPanel.Controls.Add(this.lbCPF);
            this.formPanel.Controls.Add(this.lbTelefone);
            this.formPanel.Controls.Add(this.lbEndereco);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.formPanel.Location = new System.Drawing.Point(110, 60);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(480, 530);
            this.formPanel.TabIndex = 5;
            // 
            // lbNome
            // 
            this.lbNome.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(0, 10);
            this.lbNome.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(300, 20);
            this.lbNome.TabIndex = 3;
            this.lbNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCPF
            // 
            this.lbCPF.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.Location = new System.Drawing.Point(0, 40);
            this.lbCPF.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(300, 20);
            this.lbCPF.TabIndex = 4;
            this.lbCPF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTelefone
            // 
            this.lbTelefone.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.Location = new System.Drawing.Point(0, 70);
            this.lbTelefone.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(300, 20);
            this.lbTelefone.TabIndex = 5;
            this.lbTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbEndereco
            // 
            this.lbEndereco.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndereco.Location = new System.Drawing.Point(0, 100);
            this.lbEndereco.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(300, 20);
            this.lbEndereco.TabIndex = 6;
            this.lbEndereco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelsPanel
            // 
            this.labelsPanel.Controls.Add(this.label);
            this.labelsPanel.Controls.Add(this.label1);
            this.labelsPanel.Controls.Add(this.label2);
            this.labelsPanel.Controls.Add(this.label3);
            this.labelsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.labelsPanel.Location = new System.Drawing.Point(10, 60);
            this.labelsPanel.Name = "labelsPanel";
            this.labelsPanel.Size = new System.Drawing.Size(100, 530);
            this.labelsPanel.TabIndex = 4;
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(0, 10);
            this.label.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 20);
            this.label.TabIndex = 2;
            this.label.Text = "Nome:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "CPF:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Endereço:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClienteDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(205)))));
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.labelsPanel);
            this.Controls.Add(this.panel1);
            this.Name = "ClienteDetails";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(600, 600);
            this.panel1.ResumeLayout(false);
            this.formPanel.ResumeLayout(false);
            this.labelsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel formPanel;
        private System.Windows.Forms.FlowLayoutPanel labelsPanel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbEndereco;
    }
}
