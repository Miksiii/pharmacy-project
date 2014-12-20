namespace cs322_projekat_pharmacy
{
    partial class FormMedicine
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
            this.dgv_AvaialbleMedicines = new System.Windows.Forms.DataGridView();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.lbl_response = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AvaialbleMedicines)).BeginInit();
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
            this.lbl_title.Size = new System.Drawing.Size(252, 49);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Stanje lekova";
            // 
            // lbl_parahraph
            // 
            this.lbl_parahraph.AutoSize = true;
            this.lbl_parahraph.BackColor = System.Drawing.Color.Transparent;
            this.lbl_parahraph.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parahraph.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_parahraph.Location = new System.Drawing.Point(18, 58);
            this.lbl_parahraph.Name = "lbl_parahraph";
            this.lbl_parahraph.Size = new System.Drawing.Size(180, 18);
            this.lbl_parahraph.TabIndex = 5;
            this.lbl_parahraph.Text = "Trenutno stanje i lista lekova";
            // 
            // dgv_AvaialbleMedicines
            // 
            this.dgv_AvaialbleMedicines.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_AvaialbleMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AvaialbleMedicines.Location = new System.Drawing.Point(21, 94);
            this.dgv_AvaialbleMedicines.Name = "dgv_AvaialbleMedicines";
            this.dgv_AvaialbleMedicines.Size = new System.Drawing.Size(591, 277);
            this.dgv_AvaialbleMedicines.TabIndex = 6;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(330, 377);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(138, 52);
            this.btn_exit.TabIndex = 19;
            this.btn_exit.Text = "< Nazad";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.exitForm);
            // 
            // btn_purchase
            // 
            this.btn_purchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_purchase.BackColor = System.Drawing.Color.Transparent;
            this.btn_purchase.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchase.Location = new System.Drawing.Point(474, 377);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(138, 52);
            this.btn_purchase.TabIndex = 20;
            this.btn_purchase.Text = "Prodaj >";
            this.btn_purchase.UseVisualStyleBackColor = false;
            this.btn_purchase.Click += new System.EventHandler(this.purchase);
            // 
            // lbl_response
            // 
            this.lbl_response.AutoSize = true;
            this.lbl_response.BackColor = System.Drawing.Color.Transparent;
            this.lbl_response.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_response.Location = new System.Drawing.Point(18, 395);
            this.lbl_response.Name = "lbl_response";
            this.lbl_response.Size = new System.Drawing.Size(0, 16);
            this.lbl_response.TabIndex = 21;
            // 
            // FormMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cs322_projekat_pharmacy.Properties.Resources.gray_background_640x480;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lbl_response);
            this.Controls.Add(this.btn_purchase);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.dgv_AvaialbleMedicines);
            this.Controls.Add(this.lbl_parahraph);
            this.Controls.Add(this.lbl_title);
            this.Name = "FormMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMedicine";
            this.Load += new System.EventHandler(this.FormMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AvaialbleMedicines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_parahraph;
        private System.Windows.Forms.DataGridView dgv_AvaialbleMedicines;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.Label lbl_response;
    }
}