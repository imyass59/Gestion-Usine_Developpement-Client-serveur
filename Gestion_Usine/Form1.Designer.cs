﻿
namespace Gestion_Usine
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validationDeLaSaisieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDesEmployésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesArticlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.productionParPériodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histigrammeDeProductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sommaireDeLaideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.productionToolStripMenuItem,
            this.etatsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(984, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employésToolStripMenuItem,
            this.articlesToolStripMenuItem,
            this.quitterToolStripMenuItem,
            this.quitterToolStripMenuItem1});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.fichierToolStripMenuItem.Text = "Fichier";
            this.fichierToolStripMenuItem.Click += new System.EventHandler(this.fichierToolStripMenuItem_Click);
            // 
            // employésToolStripMenuItem
            // 
            this.employésToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employésToolStripMenuItem.Name = "employésToolStripMenuItem";
            this.employésToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.employésToolStripMenuItem.Text = "Employés ";
            this.employésToolStripMenuItem.Click += new System.EventHandler(this.employésToolStripMenuItem_Click);
            // 
            // articlesToolStripMenuItem
            // 
            this.articlesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articlesToolStripMenuItem.Name = "articlesToolStripMenuItem";
            this.articlesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.articlesToolStripMenuItem.Text = "Articles ";
            this.articlesToolStripMenuItem.Click += new System.EventHandler(this.articlesToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(135, 6);
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.quitterToolStripMenuItem1.Text = "Quitter";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click);
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saisieToolStripMenuItem,
            this.validationDeLaSaisieToolStripMenuItem,
            this.consultationToolStripMenuItem});
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // saisieToolStripMenuItem
            // 
            this.saisieToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saisieToolStripMenuItem.Name = "saisieToolStripMenuItem";
            this.saisieToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.saisieToolStripMenuItem.Text = "Saisie";
            this.saisieToolStripMenuItem.Click += new System.EventHandler(this.saisieToolStripMenuItem_Click);
            // 
            // validationDeLaSaisieToolStripMenuItem
            // 
            this.validationDeLaSaisieToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationDeLaSaisieToolStripMenuItem.Name = "validationDeLaSaisieToolStripMenuItem";
            this.validationDeLaSaisieToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.validationDeLaSaisieToolStripMenuItem.Text = "Validation de la saisie";
            this.validationDeLaSaisieToolStripMenuItem.Click += new System.EventHandler(this.validationDeLaSaisieToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.consultationToolStripMenuItem.Text = "Consultation";
            this.consultationToolStripMenuItem.Click += new System.EventHandler(this.consultationToolStripMenuItem_Click);
            // 
            // etatsToolStripMenuItem
            // 
            this.etatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listDesEmployésToolStripMenuItem,
            this.listeDesArticlesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.productionParPériodeToolStripMenuItem,
            this.histigrammeDeProductionToolStripMenuItem});
            this.etatsToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etatsToolStripMenuItem.Name = "etatsToolStripMenuItem";
            this.etatsToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.etatsToolStripMenuItem.Text = "Etats";
            // 
            // listDesEmployésToolStripMenuItem
            // 
            this.listDesEmployésToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDesEmployésToolStripMenuItem.Name = "listDesEmployésToolStripMenuItem";
            this.listDesEmployésToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.listDesEmployésToolStripMenuItem.Text = "List des Employés";
            this.listDesEmployésToolStripMenuItem.Click += new System.EventHandler(this.listDesEmployésToolStripMenuItem_Click);
            // 
            // listeDesArticlesToolStripMenuItem
            // 
            this.listeDesArticlesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeDesArticlesToolStripMenuItem.Name = "listeDesArticlesToolStripMenuItem";
            this.listeDesArticlesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.listeDesArticlesToolStripMenuItem.Text = "Liste des Articles";
            this.listeDesArticlesToolStripMenuItem.Click += new System.EventHandler(this.listeDesArticlesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(228, 6);
            // 
            // productionParPériodeToolStripMenuItem
            // 
            this.productionParPériodeToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionParPériodeToolStripMenuItem.Name = "productionParPériodeToolStripMenuItem";
            this.productionParPériodeToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.productionParPériodeToolStripMenuItem.Text = "Production par période";
            this.productionParPériodeToolStripMenuItem.Click += new System.EventHandler(this.productionParPériodeToolStripMenuItem_Click);
            // 
            // histigrammeDeProductionToolStripMenuItem
            // 
            this.histigrammeDeProductionToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histigrammeDeProductionToolStripMenuItem.Name = "histigrammeDeProductionToolStripMenuItem";
            this.histigrammeDeProductionToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.histigrammeDeProductionToolStripMenuItem.Text = "Histigramme de production";
            this.histigrammeDeProductionToolStripMenuItem.Click += new System.EventHandler(this.histigrammeDeProductionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem,
            this.sommaireDeLaideToolStripMenuItem});
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 29);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // sommaireDeLaideToolStripMenuItem
            // 
            this.sommaireDeLaideToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sommaireDeLaideToolStripMenuItem.Name = "sommaireDeLaideToolStripMenuItem";
            this.sommaireDeLaideToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.sommaireDeLaideToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.sommaireDeLaideToolStripMenuItem.Text = "Sommaire de l\'aide";
            this.sommaireDeLaideToolStripMenuItem.Click += new System.EventHandler(this.sommaireDeLaideToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Usine v1.0.3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saisieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validationDeLaSaisieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listDesEmployésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesArticlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem productionParPériodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histigrammeDeProductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sommaireDeLaideToolStripMenuItem;
    }
}

