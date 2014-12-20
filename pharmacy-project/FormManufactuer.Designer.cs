namespace cs322_projekat_pharmacy
{
    partial class FormManufactuer
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
            this.lbl_parahraph = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lb_manufactuersList = new System.Windows.Forms.ListBox();
            this.dgv_orderMedicines = new System.Windows.Forms.DataGridView();
            this.btn_order = new System.Windows.Forms.Button();
            this.pnl_orderMedicines = new System.Windows.Forms.Panel();
            this.btn_exitPanel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_response = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderMedicines)).BeginInit();
            this.pnl_orderMedicines.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_parahraph
            // 
            this.lbl_parahraph.AutoSize = true;
            this.lbl_parahraph.BackColor = System.Drawing.Color.Transparent;
            this.lbl_parahraph.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parahraph.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_parahraph.Location = new System.Drawing.Point(18, 67);
            this.lbl_parahraph.Name = "lbl_parahraph";
            this.lbl_parahraph.Size = new System.Drawing.Size(223, 18);
            this.lbl_parahraph.TabIndex = 6;
            this.lbl_parahraph.Text = "Lista proizvođača/dobavljača lekova";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Trebuchet MS", 28.25F);
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_title.Location = new System.Drawing.Point(12, 18);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(310, 49);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "Panel dobavljača";
            // 
            // lb_manufactuersList
            // 
            this.lb_manufactuersList.BackColor = System.Drawing.SystemColors.Window;
            this.lb_manufactuersList.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_manufactuersList.FormattingEnabled = true;
            this.lb_manufactuersList.ItemHeight = 22;
            this.lb_manufactuersList.Location = new System.Drawing.Point(21, 100);
            this.lb_manufactuersList.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lb_manufactuersList.Name = "lb_manufactuersList";
            this.lb_manufactuersList.Size = new System.Drawing.Size(578, 268);
            this.lb_manufactuersList.TabIndex = 7;
            this.lb_manufactuersList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.displayMedicines);
            // 
            // dgv_orderMedicines
            // 
            this.dgv_orderMedicines.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgv_orderMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orderMedicines.Location = new System.Drawing.Point(0, 0);
            this.dgv_orderMedicines.Name = "dgv_orderMedicines";
            this.dgv_orderMedicines.Size = new System.Drawing.Size(578, 284);
            this.dgv_orderMedicines.TabIndex = 8;
            // 
            // btn_order
            // 
            this.btn_order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_order.BackColor = System.Drawing.Color.Transparent;
            this.btn_order.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.Location = new System.Drawing.Point(440, 290);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(138, 52);
            this.btn_order.TabIndex = 16;
            this.btn_order.Text = "Poruči >";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.order);
            // 
            // pnl_orderMedicines
            // 
            this.pnl_orderMedicines.BackColor = System.Drawing.Color.Transparent;
            this.pnl_orderMedicines.Controls.Add(this.lbl_response);
            this.pnl_orderMedicines.Controls.Add(this.btn_exitPanel);
            this.pnl_orderMedicines.Controls.Add(this.btn_order);
            this.pnl_orderMedicines.Controls.Add(this.dgv_orderMedicines);
            this.pnl_orderMedicines.Location = new System.Drawing.Point(21, 88);
            this.pnl_orderMedicines.Name = "pnl_orderMedicines";
            this.pnl_orderMedicines.Size = new System.Drawing.Size(578, 341);
            this.pnl_orderMedicines.TabIndex = 17;
            this.pnl_orderMedicines.Visible = false;
            // 
            // btn_exitPanel
            // 
            this.btn_exitPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_exitPanel.BackColor = System.Drawing.Color.Transparent;
            this.btn_exitPanel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitPanel.Location = new System.Drawing.Point(296, 290);
            this.btn_exitPanel.Name = "btn_exitPanel";
            this.btn_exitPanel.Size = new System.Drawing.Size(138, 52);
            this.btn_exitPanel.TabIndex = 17;
            this.btn_exitPanel.Text = "< Nazad";
            this.btn_exitPanel.UseVisualStyleBackColor = false;
            this.btn_exitPanel.Click += new System.EventHandler(this.exitPanel);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(461, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 52);
            this.button2.TabIndex = 18;
            this.button2.Text = "< Nazad";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.exitForm);
            // 
            // lbl_response
            // 
            this.lbl_response.AutoSize = true;
            this.lbl_response.Location = new System.Drawing.Point(0, 308);
            this.lbl_response.Name = "lbl_response";
            this.lbl_response.Size = new System.Drawing.Size(0, 13);
            this.lbl_response.TabIndex = 18;
            // 
            // FormManufactuer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cs322_projekat_pharmacy.Properties.Resources.gray_background_640x480;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.pnl_orderMedicines);
            this.Controls.Add(this.lb_manufactuersList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_parahraph);
            this.Controls.Add(this.lbl_title);
            this.Name = "FormManufactuer";
            this.Text = "FormManufactuer";
            this.Load += new System.EventHandler(this.FormManufactuer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderMedicines)).EndInit();
            this.pnl_orderMedicines.ResumeLayout(false);
            this.pnl_orderMedicines.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_parahraph;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ListBox lb_manufactuersList;
        private System.Windows.Forms.DataGridView dgv_orderMedicines;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Panel pnl_orderMedicines;
        private System.Windows.Forms.Button btn_exitPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_response;


    }
}