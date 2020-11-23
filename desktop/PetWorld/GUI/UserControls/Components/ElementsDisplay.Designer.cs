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
            this.textBox = new System.Windows.Forms.TextBox();
            this.items = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(580, 20);
            this.textBox.TabIndex = 0;
            // 
            // items
            // 
            this.items.AutoScroll = true;
            this.items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.items.Location = new System.Drawing.Point(0, 20);
            this.items.Margin = new System.Windows.Forms.Padding(0);
            this.items.Name = "items";
            this.items.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.items.Size = new System.Drawing.Size(580, 480);
            this.items.TabIndex = 2;
            // 
            // ElementsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.items);
            this.Controls.Add(this.textBox);
            this.Name = "ElementsDisplay";
            this.Size = new System.Drawing.Size(580, 500);
            this.Resize += new System.EventHandler(this.OnResize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.FlowLayoutPanel items;
    }
}
