namespace LeagueOverwolfLauncher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.progressBar_loading = new System.Windows.Forms.ProgressBar();
            this.button4_StopThread = new System.Windows.Forms.Button();
            this.label_informations = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar_loading
            // 
            this.progressBar_loading.BackColor = System.Drawing.Color.Black;
            this.progressBar_loading.Location = new System.Drawing.Point(12, 186);
            this.progressBar_loading.Maximum = 6;
            this.progressBar_loading.Name = "progressBar_loading";
            this.progressBar_loading.Size = new System.Drawing.Size(159, 23);
            this.progressBar_loading.Step = 1;
            this.progressBar_loading.TabIndex = 3;
            this.progressBar_loading.Visible = false;
            // 
            // button4_StopThread
            // 
            this.button4_StopThread.BackColor = System.Drawing.Color.White;
            this.button4_StopThread.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4_StopThread.BackgroundImage")));
            this.button4_StopThread.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4_StopThread.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button4_StopThread.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4_StopThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4_StopThread.ForeColor = System.Drawing.Color.White;
            this.button4_StopThread.Location = new System.Drawing.Point(12, 29);
            this.button4_StopThread.Name = "button4_StopThread";
            this.button4_StopThread.Size = new System.Drawing.Size(159, 30);
            this.button4_StopThread.TabIndex = 1;
            this.button4_StopThread.Text = "Stop AutoLaunch";
            this.button4_StopThread.UseVisualStyleBackColor = false;
            this.button4_StopThread.Click += new System.EventHandler(this.Button4_StopThread_Click);
            // 
            // label_informations
            // 
            this.label_informations.AutoSize = true;
            this.label_informations.BackColor = System.Drawing.Color.Transparent;
            this.label_informations.ForeColor = System.Drawing.Color.White;
            this.label_informations.Location = new System.Drawing.Point(12, 13);
            this.label_informations.Name = "label_informations";
            this.label_informations.Size = new System.Drawing.Size(41, 13);
            this.label_informations.TabIndex = 5;
            this.label_informations.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(105, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 133);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 101);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // button_quit
            // 
            this.button_quit.BackColor = System.Drawing.Color.White;
            this.button_quit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_quit.BackgroundImage")));
            this.button_quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_quit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_quit.ForeColor = System.Drawing.Color.White;
            this.button_quit.Location = new System.Drawing.Point(12, 68);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(70, 30);
            this.button_quit.TabIndex = 2;
            this.button_quit.Text = "Quitter";
            this.button_quit.UseVisualStyleBackColor = false;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(178, 220);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.button4_StopThread);
            this.Controls.Add(this.progressBar_loading);
            this.Controls.Add(this.label_informations);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeagueOfLegends - Overwolf Luncher";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar_loading;
        private System.Windows.Forms.Button button4_StopThread;
        private System.Windows.Forms.Label label_informations;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_quit;
    }
}

