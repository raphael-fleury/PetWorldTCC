namespace PetWorld.GUI.UserControls.Components
{
    partial class EnderecoForm
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
            this.estados = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumEndereco = new System.Windows.Forms.MaskedTextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.MaskedTextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // estados
            // 
            this.estados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estados.FormattingEnabled = true;
            this.estados.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RR",
            "RO",
            "RJ",
            "RN",
            "RS",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.estados.Location = new System.Drawing.Point(306, 121);
            this.estados.Name = "estados";
            this.estados.Size = new System.Drawing.Size(44, 21);
            this.estados.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(249, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Estado*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(100, 121);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(149, 20);
            this.txtCidade.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cidade*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(100, 91);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(250, 20);
            this.txtBairro.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Bairro*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumEndereco
            // 
            this.txtNumEndereco.Location = new System.Drawing.Point(100, 60);
            this.txtNumEndereco.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.txtNumEndereco.Mask = "000000";
            this.txtNumEndereco.Name = "txtNumEndereco";
            this.txtNumEndereco.Size = new System.Drawing.Size(44, 20);
            this.txtNumEndereco.TabIndex = 22;
            this.txtNumEndereco.ValidatingType = typeof(int);
            // 
            // lblEndereco
            // 
            this.lblEndereco.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(0, 0);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(100, 20);
            this.lblEndereco.TabIndex = 16;
            this.lblEndereco.Text = "Endereço:";
            this.lblEndereco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Logradouro*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Número:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(235, 61);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(115, 20);
            this.txtComplemento.TabIndex = 20;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(100, 30);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(0);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(250, 20);
            this.txtLogradouro.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Complemento:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EnderecoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.estados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EnderecoForm";
            this.Size = new System.Drawing.Size(364, 156);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox estados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtNumEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtComplemento;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label3;
    }
}
