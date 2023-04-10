namespace Messenger
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
            this.rtbAfisareMesaj = new System.Windows.Forms.RichTextBox();
            this.btnMaria = new System.Windows.Forms.Button();
            this.btnIonel = new System.Windows.Forms.Button();
            this.rtbEditareMesaj = new System.Windows.Forms.RichTextBox();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnIncarcare = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbAfisareMesaj
            // 
            this.rtbAfisareMesaj.Enabled = false;
            this.rtbAfisareMesaj.Location = new System.Drawing.Point(12, 12);
            this.rtbAfisareMesaj.Name = "rtbAfisareMesaj";
            this.rtbAfisareMesaj.Size = new System.Drawing.Size(460, 194);
            this.rtbAfisareMesaj.TabIndex = 0;
            this.rtbAfisareMesaj.Text = "";
            // 
            // btnMaria
            // 
            this.btnMaria.Location = new System.Drawing.Point(12, 226);
            this.btnMaria.Name = "btnMaria";
            this.btnMaria.Size = new System.Drawing.Size(61, 30);
            this.btnMaria.TabIndex = 1;
            this.btnMaria.Text = "Maria";
            this.btnMaria.UseVisualStyleBackColor = true;
            this.btnMaria.Click += new System.EventHandler(this.btnMaria_Click);
            // 
            // btnIonel
            // 
            this.btnIonel.Location = new System.Drawing.Point(411, 226);
            this.btnIonel.Name = "btnIonel";
            this.btnIonel.Size = new System.Drawing.Size(61, 30);
            this.btnIonel.TabIndex = 2;
            this.btnIonel.Text = "Ionel";
            this.btnIonel.UseVisualStyleBackColor = true;
            this.btnIonel.Click += new System.EventHandler(this.btnIonel_Click);
            // 
            // rtbEditareMesaj
            // 
            this.rtbEditareMesaj.Location = new System.Drawing.Point(79, 226);
            this.rtbEditareMesaj.Name = "rtbEditareMesaj";
            this.rtbEditareMesaj.Size = new System.Drawing.Size(326, 30);
            this.rtbEditareMesaj.TabIndex = 3;
            this.rtbEditareMesaj.Text = "";
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(12, 279);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(105, 23);
            this.btnSalvare.TabIndex = 4;
            this.btnSalvare.Text = "Salvare mesaje";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnIncarcare
            // 
            this.btnIncarcare.Location = new System.Drawing.Point(367, 279);
            this.btnIncarcare.Name = "btnIncarcare";
            this.btnIncarcare.Size = new System.Drawing.Size(105, 23);
            this.btnIncarcare.TabIndex = 5;
            this.btnIncarcare.Text = "Incarcare mesaje";
            this.btnIncarcare.UseVisualStyleBackColor = true;
            this.btnIncarcare.Click += new System.EventHandler(this.btnIncarcare_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(123, 279);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(238, 23);
            this.btnSterge.TabIndex = 6;
            this.btnSterge.Text = "Sterge fereastra mesaje";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 314);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnIncarcare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.rtbEditareMesaj);
            this.Controls.Add(this.btnIonel);
            this.Controls.Add(this.btnMaria);
            this.Controls.Add(this.rtbAfisareMesaj);
            this.Name = "Form1";
            this.Text = "M E S S E N G E R";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAfisareMesaj;
        private System.Windows.Forms.Button btnMaria;
        private System.Windows.Forms.Button btnIonel;
        private System.Windows.Forms.RichTextBox rtbEditareMesaj;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnIncarcare;
        private System.Windows.Forms.Button btnSterge;
    }
}

