namespace PetWorld.GUI.UserControls.Screens
{
    partial class PetDetails
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
            this.labelsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbEspecie = new System.Windows.Forms.Label();
            this.lbRaca = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbCastrado = new System.Windows.Forms.Label();
            this.lbResponsavel = new System.Windows.Forms.Label();
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
            this.formPanel.Controls.Add(this.lbEspecie);
            this.formPanel.Controls.Add(this.lbRaca);
            this.formPanel.Controls.Add(this.lbSexo);
            this.formPanel.Controls.Add(this.lbCastrado);
            this.formPanel.Controls.Add(this.lbResponsavel);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.formPanel.Location = new System.Drawing.Point(110, 60);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(480, 530);
            this.formPanel.TabIndex = 5;
            // 
            // labelsPanel
            // 
            this.labelsPanel.Controls.Add(this.label);
            this.labelsPanel.Controls.Add(this.label1);
            this.labelsPanel.Controls.Add(this.label2);
            this.labelsPanel.Controls.Add(this.label3);
            this.labelsPanel.Controls.Add(this.label4);
            this.labelsPanel.Controls.Add(this.label5);
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
            this.label1.Text = "Espécie:";
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
            this.label2.Text = "Raça:";
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
            this.label3.Text = "Sexo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Castrado:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Responsável:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // lbEspecie
            // 
            this.lbEspecie.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEspecie.Location = new System.Drawing.Point(0, 40);
            this.lbEspecie.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbEspecie.Name = "lbEspecie";
            this.lbEspecie.Size = new System.Drawing.Size(300, 20);
            this.lbEspecie.TabIndex = 4;
            this.lbEspecie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRaca
            // 
            this.lbRaca.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRaca.Location = new System.Drawing.Point(0, 70);
            this.lbRaca.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbRaca.Name = "lbRaca";
            this.lbRaca.Size = new System.Drawing.Size(300, 20);
            this.lbRaca.TabIndex = 5;
            this.lbRaca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSexo
            // 
            this.lbSexo.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexo.Location = new System.Drawing.Point(0, 100);
            this.lbSexo.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(300, 20);
            this.lbSexo.TabIndex = 6;
            this.lbSexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCastrado
            // 
            this.lbCastrado.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCastrado.Location = new System.Drawing.Point(0, 130);
            this.lbCastrado.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbCastrado.Name = "lbCastrado";
            this.lbCastrado.Size = new System.Drawing.Size(300, 20);
            this.lbCastrado.TabIndex = 7;
            this.lbCastrado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbResponsavel
            // 
            this.lbResponsavel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResponsavel.Location = new System.Drawing.Point(0, 160);
            this.lbResponsavel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbResponsavel.Name = "lbResponsavel";
            this.lbResponsavel.Size = new System.Drawing.Size(300, 20);
            this.lbResponsavel.TabIndex = 8;
            this.lbResponsavel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PetDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(205)))));
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.labelsPanel);
            this.Controls.Add(this.panel1);
            this.Name = "PetDetails";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbEspecie;
        private System.Windows.Forms.Label lbRaca;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbCastrado;
        private System.Windows.Forms.Label lbResponsavel;
    }
}
