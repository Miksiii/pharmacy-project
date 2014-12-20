namespace cs322_projekat_pharmacy
{
    partial class FormOrder
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_orders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Trebuchet MS", 28.25F);
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_title.Location = new System.Drawing.Point(12, 18);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(255, 49);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "Narudžbenice";
            // 
            // lbl_parahraph
            // 
            this.lbl_parahraph.AutoSize = true;
            this.lbl_parahraph.BackColor = System.Drawing.Color.Transparent;
            this.lbl_parahraph.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parahraph.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_parahraph.Location = new System.Drawing.Point(18, 67);
            this.lbl_parahraph.Name = "lbl_parahraph";
            this.lbl_parahraph.Size = new System.Drawing.Size(118, 18);
            this.lbl_parahraph.TabIndex = 7;
            this.lbl_parahraph.Text = "Lista narudžbenica";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(474, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 52);
            this.button1.TabIndex = 18;
            this.button1.Text = "< Nazad";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.exitForm);
            // 
            // dgv_orders
            // 
            this.dgv_orders.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orders.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_orders.Location = new System.Drawing.Point(21, 102);
            this.dgv_orders.Name = "dgv_orders";
            this.dgv_orders.Size = new System.Drawing.Size(591, 269);
            this.dgv_orders.TabIndex = 19;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cs322_projekat_pharmacy.Properties.Resources.gray_background_640x480;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.dgv_orders);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_parahraph);
            this.Controls.Add(this.lbl_title);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_parahraph;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_orders;
    }
}