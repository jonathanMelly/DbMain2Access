namespace Dbmain2AccessImport
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofdSource = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnAnalyser = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.sfdMdb = new System.Windows.Forms.SaveFileDialog();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ofdSource
            // 
            this.ofdSource.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fichier SQL";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(104, 35);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(394, 20);
            this.txtSource.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(520, 33);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(70, 22);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Parcourir";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnAnalyser
            // 
            this.btnAnalyser.Location = new System.Drawing.Point(596, 33);
            this.btnAnalyser.Name = "btnAnalyser";
            this.btnAnalyser.Size = new System.Drawing.Size(70, 22);
            this.btnAnalyser.TabIndex = 3;
            this.btnAnalyser.Text = "Analyser";
            this.btnAnalyser.UseVisualStyleBackColor = true;
            this.btnAnalyser.Click += new System.EventHandler(this.btnAnalyser_Click);
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(326, 340);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(77, 22);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "Créer MDB";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // pnlResult
            // 
            this.pnlResult.AutoScroll = true;
            this.pnlResult.Location = new System.Drawing.Point(39, 95);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(627, 230);
            this.pnlResult.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Résultats d\'analyse";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(700, 385);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnAnalyser);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dbmain2AcessImport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnAnalyser;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.SaveFileDialog sfdMdb;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Label label2;
    }
}

