namespace PetWorld.GUI.UserControls.Components
{
    partial class ElementsDisplay
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
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFilterByName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilter.Location = new System.Drawing.Point(0, 25);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(580, 20);
            this.txtFilter.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 45);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.Name = "panel";
            this.panel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel.Size = new System.Drawing.Size(580, 455);
            this.panel.TabIndex = 2;
            // 
            // lblFilterByName
            // 
            this.lblFilterByName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFilterByName.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterByName.Location = new System.Drawing.Point(0, 0);
            this.lblFilterByName.Margin = new System.Windows.Forms.Padding(0);
            this.lblFilterByName.Name = "lblFilterByName";
            this.lblFilterByName.Size = new System.Drawing.Size(580, 25);
            this.lblFilterByName.TabIndex = 3;
            this.lblFilterByName.Text = "Filtrar por nome";
            this.lblFilterByName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ElementsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblFilterByName);
            this.Name = "ElementsDisplay";
            this.Size = new System.Drawing.Size(580, 500);
            this.Resize += new System.EventHandler(this.OnResize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.FlowLayoutPanel panel;
        private System.Windows.Forms.Label lblFilterByName;
    }
}
