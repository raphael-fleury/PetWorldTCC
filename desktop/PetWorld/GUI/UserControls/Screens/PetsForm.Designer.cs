namespace PetWorld.GUI.UserControls.Screens
{
    partial class PetsForm
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
            this.btDone = new System.Windows.Forms.Button();
            this.formPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.rbsSexo = new System.Windows.Forms.FlowLayoutPanel();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.cbCastrado = new System.Windows.Forms.CheckBox();
            this.btEscolherCliente = new System.Windows.Forms.Button();
            this.labelsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblRaca = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblCastrado = new System.Windows.Forms.Label();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.rbsSexo.SuspendLayout();
            this.labelsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.btReturn);
            this.panel1.Controls.Add(this.btDone);
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
            this.title.Size = new System.Drawing.Size(480, 50);
            this.title.TabIndex = 9;
            this.title.Text = "Adicionar Pet";
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
            // btDone
            // 
            this.btDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btDone.Dock = System.Windows.Forms.DockStyle.Right;
            this.btDone.FlatAppearance.BorderSize = 0;
            this.btDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(102)))), ((int)(((byte)(15)))));
            this.btDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDone.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDone.Image = global::PetWorld.Properties.Resources.Done__Black_18px_;
            this.btDone.Location = new System.Drawing.Point(530, 0);
            this.btDone.Margin = new System.Windows.Forms.Padding(0);
            this.btDone.Name = "btDone";
            this.btDone.Size = new System.Drawing.Size(50, 50);
            this.btDone.TabIndex = 10;
            this.btDone.UseVisualStyleBackColor = false;
            this.btDone.Click += new System.EventHandler(this.Done);
            // 
            // formPanel
            // 
            this.formPanel.Controls.Add(this.txtNome);
            this.formPanel.Controls.Add(this.txtEspecie);
            this.formPanel.Controls.Add(this.txtRaca);
            this.formPanel.Controls.Add(this.rbsSexo);
            this.formPanel.Controls.Add(this.cbCastrado);
            this.formPanel.Controls.Add(this.btEscolherCliente);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.formPanel.Location = new System.Drawing.Point(110, 60);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(480, 530);
            this.formPanel.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(0, 10);
            this.txtNome.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(250, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(0, 40);
            this.txtEspecie.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(250, 20);
            this.txtEspecie.TabIndex = 1;
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(0, 70);
            this.txtRaca.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(250, 20);
            this.txtRaca.TabIndex = 2;
            // 
            // rbsSexo
            // 
            this.rbsSexo.Controls.Add(this.rbMasculino);
            this.rbsSexo.Controls.Add(this.rbFeminino);
            this.rbsSexo.Location = new System.Drawing.Point(0, 100);
            this.rbsSexo.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.rbsSexo.Name = "rbsSexo";
            this.rbsSexo.Size = new System.Drawing.Size(250, 20);
            this.rbsSexo.TabIndex = 3;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.Location = new System.Drawing.Point(3, 3);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(79, 3);
            this.rbFeminino.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 1;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // cbCastrado
            // 
            this.cbCastrado.AutoSize = true;
            this.cbCastrado.Location = new System.Drawing.Point(3, 134);
            this.cbCastrado.Margin = new System.Windows.Forms.Padding(3, 14, 0, 0);
            this.cbCastrado.Name = "cbCastrado";
            this.cbCastrado.Size = new System.Drawing.Size(15, 14);
            this.cbCastrado.TabIndex = 4;
            this.cbCastrado.UseVisualStyleBackColor = true;
            // 
            // btEscolherCliente
            // 
            this.btEscolherCliente.Location = new System.Drawing.Point(0, 158);
            this.btEscolherCliente.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btEscolherCliente.Name = "btEscolherCliente";
            this.btEscolherCliente.Size = new System.Drawing.Size(75, 25);
            this.btEscolherCliente.TabIndex = 5;
            this.btEscolherCliente.Text = "Escolher...";
            this.btEscolherCliente.UseVisualStyleBackColor = true;
            // 
            // labelsPanel
            // 
            this.labelsPanel.Controls.Add(this.lblNome);
            this.labelsPanel.Controls.Add(this.lblEspecie);
            this.labelsPanel.Controls.Add(this.lblRaca);
            this.labelsPanel.Controls.Add(this.lblSexo);
            this.labelsPanel.Controls.Add(this.lblCastrado);
            this.labelsPanel.Controls.Add(this.lblResponsavel);
            this.labelsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.labelsPanel.Location = new System.Drawing.Point(10, 60);
            this.labelsPanel.Name = "labelsPanel";
            this.labelsPanel.Size = new System.Drawing.Size(100, 530);
            this.labelsPanel.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(0, 10);
            this.lblNome.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(100, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEspecie
            // 
            this.lblEspecie.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecie.Location = new System.Drawing.Point(0, 40);
            this.lblEspecie.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(100, 20);
            this.lblEspecie.TabIndex = 3;
            this.lblEspecie.Text = "Espécie:";
            this.lblEspecie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRaca
            // 
            this.lblRaca.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaca.Location = new System.Drawing.Point(0, 70);
            this.lblRaca.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(100, 20);
            this.lblRaca.TabIndex = 4;
            this.lblRaca.Text = "Raça:";
            this.lblRaca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSexo
            // 
            this.lblSexo.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(0, 100);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(100, 20);
            this.lblSexo.TabIndex = 5;
            this.lblSexo.Text = "Sexo:";
            this.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCastrado
            // 
            this.lblCastrado.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCastrado.Location = new System.Drawing.Point(0, 130);
            this.lblCastrado.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblCastrado.Name = "lblCastrado";
            this.lblCastrado.Size = new System.Drawing.Size(100, 20);
            this.lblCastrado.TabIndex = 6;
            this.lblCastrado.Text = "Castrado:";
            this.lblCastrado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsavel.Location = new System.Drawing.Point(0, 160);
            this.lblResponsavel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(100, 20);
            this.lblResponsavel.TabIndex = 7;
            this.lblResponsavel.Text = "Responsável:";
            this.lblResponsavel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(205)))));
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.labelsPanel);
            this.Controls.Add(this.panel1);
            this.Name = "PetsForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(600, 600);
            this.panel1.ResumeLayout(false);
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.rbsSexo.ResumeLayout(false);
            this.rbsSexo.PerformLayout();
            this.labelsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel formPanel;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.FlowLayoutPanel rbsSexo;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.CheckBox cbCastrado;
        private System.Windows.Forms.Button btEscolherCliente;
        private System.Windows.Forms.FlowLayoutPanel labelsPanel;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblCastrado;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Button btDone;
    }
}
