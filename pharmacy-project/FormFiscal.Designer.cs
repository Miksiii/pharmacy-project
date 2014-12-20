namespace cs322_projekat_pharmacy
{
    partial class FormFiscal
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_parahraph = new System.Windows.Forms.Label();
            this.btn_exitPanel = new System.Windows.Forms.Button();
            this.dgv_fiscals = new System.Windows.Forms.DataGridView();
            this.lbl_response = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fiscals)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Trebuchet MS", 28.25F);
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(268, 49);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Fiskalni računi";
            // 
            // lbl_parahraph
            // 
            this.lbl_parahraph.AutoSize = true;
            this.lbl_parahraph.BackColor = System.Drawing.Color.Transparent;
            this.lbl_parahraph.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parahraph.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_parahraph.Location = new System.Drawing.Point(18, 58);
            this.lbl_parahraph.Name = "lbl_parahraph";
            this.lbl_parahraph.Size = new System.Drawing.Size(206, 18);
            this.lbl_parahraph.TabIndex = 5;
            this.lbl_parahraph.Text = "Lista svih izdatih fiskalnih računa";
            // 
            // btn_exitPanel
            // 
            this.btn_exitPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_exitPanel.BackColor = System.Drawing.Color.Transparent;
            this.btn_exitPanel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitPanel.Location = new System.Drawing.Point(461, 377);
            this.btn_exitPanel.Name = "btn_exitPanel";
            this.btn_exitPanel.Size = new System.Drawing.Size(138, 52);
            this.btn_exitPanel.TabIndex = 18;
            this.btn_exitPanel.Text = "< Nazad";
            this.btn_exitPanel.UseVisualStyleBackColor = false;
            this.btn_exitPanel.Click += new System.EventHandler(this.exitForm);
            // 
            // dgv_fiscals
            // 
            this.dgv_fiscals.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_fiscals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fiscals.Location = new System.Drawing.Point(21, 94);
            this.dgv_fiscals.Name = "dgv_fiscals";
            this.dgv_fiscals.Size = new System.Drawing.Size(578, 267);
            this.dgv_fiscals.TabIndex = 19;
            // 
            // lbl_response
            // 
            this.lbl_response.AutoSize = true;
            this.lbl_response.BackColor = System.Drawing.Color.Transparent;
            this.lbl_response.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_response.Location = new System.Drawing.Point(21, 392);
            this.lbl_response.Name = "lbl_response";
            this.lbl_response.Size = new System.Drawing.Size(0, 16);
            this.lbl_response.TabIndex = 20;
            // 
            // FormFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cs322_projekat_pharmacy.Properties.Resources.gray_background_640x480;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lbl_response);
            this.Controls.Add(this.dgv_fiscals);
            this.Controls.Add(this.btn_exitPanel);
            this.Controls.Add(this.lbl_parahraph);
            this.Controls.Add(this.lbl_title);
            this.Name = "FormFiscal";
            this.Text = "FormFiscal";
            this.Load += new System.EventHandler(this.FormFiscal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fiscals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_parahraph;
        private System.Windows.Forms.Button btn_exitPanel;
        private System.Windows.Forms.DataGridView dgv_fiscals;
        private System.Windows.Forms.Label lbl_response;
    }
}