﻿using System.Windows.Forms;

namespace PetWorld.GUI.Forms
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.screen = new PetWorld.GUI.UserControls.Tabs.Tab();
            this.rbHome = new PetWorld.GUI.UserControls.Components.SidebarButton();
            this.rbPets = new PetWorld.GUI.UserControls.Components.SidebarButton();
            this.rbClientes = new PetWorld.GUI.UserControls.Components.SidebarButton();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.sidebar.Controls.Add(this.logoBox);
            this.sidebar.Controls.Add(this.rbHome);
            this.sidebar.Controls.Add(this.rbPets);
            this.sidebar.Controls.Add(this.rbClientes);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 600);
            this.sidebar.TabIndex = 4;
            // 
            // logoBox
            // 
            this.logoBox.Image = global::PetWorld.Properties.Resources.PetWorld;
            this.logoBox.Location = new System.Drawing.Point(40, 40);
            this.logoBox.Margin = new System.Windows.Forms.Padding(40);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(120, 120);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(205)))));
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(200, 0);
            this.screen.Margin = new System.Windows.Forms.Padding(0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(600, 600);
            this.screen.TabIndex = 3;
            // 
            // rbHome
            // 
            this.rbHome.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.rbHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbHome.FlatAppearance.BorderSize = 0;
            this.rbHome.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(34)))), ((int)(((byte)(6)))));
            this.rbHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(102)))), ((int)(((byte)(15)))));
            this.rbHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.rbHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbHome.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(34)))), ((int)(((byte)(6)))));
            this.rbHome.Location = new System.Drawing.Point(0, 200);
            this.rbHome.Margin = new System.Windows.Forms.Padding(0);
            this.rbHome.Name = "rbHome";
            this.rbHome.Size = new System.Drawing.Size(200, 45);
            this.rbHome.TabIndex = 5;
            this.rbHome.TabStop = true;
            this.rbHome.Text = "Início";
            this.rbHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbHome.UseVisualStyleBackColor = true;
            // 
            // rbPets
            // 
            this.rbPets.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.rbPets.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbPets.FlatAppearance.BorderSize = 0;
            this.rbPets.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(34)))), ((int)(((byte)(6)))));
            this.rbPets.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(102)))), ((int)(((byte)(15)))));
            this.rbPets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.rbPets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbPets.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(34)))), ((int)(((byte)(6)))));
            this.rbPets.Location = new System.Drawing.Point(0, 245);
            this.rbPets.Margin = new System.Windows.Forms.Padding(0);
            this.rbPets.Name = "rbPets";
            this.rbPets.Size = new System.Drawing.Size(200, 45);
            this.rbPets.TabIndex = 6;
            this.rbPets.TabStop = true;
            this.rbPets.Text = "Pets";
            this.rbPets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPets.UseVisualStyleBackColor = true;
            // 
            // rbClientes
            // 
            this.rbClientes.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.rbClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbClientes.FlatAppearance.BorderSize = 0;
            this.rbClientes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(34)))), ((int)(((byte)(6)))));
            this.rbClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(102)))), ((int)(((byte)(15)))));
            this.rbClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.rbClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbClientes.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(34)))), ((int)(((byte)(6)))));
            this.rbClientes.Location = new System.Drawing.Point(0, 290);
            this.rbClientes.Margin = new System.Windows.Forms.Padding(0);
            this.rbClientes.Name = "rbClientes";
            this.rbClientes.Size = new System.Drawing.Size(200, 45);
            this.rbClientes.TabIndex = 7;
            this.rbClientes.TabStop = true;
            this.rbClientes.Text = "Clientes";
            this.rbClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbClientes.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet World";
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Tabs.Tab screen;
        private FlowLayoutPanel sidebar;
        private PictureBox logoBox;
        private UserControls.Components.SidebarButton rbHome;
        private UserControls.Components.SidebarButton rbPets;
        private UserControls.Components.SidebarButton rbClientes;
    }
}

