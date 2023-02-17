namespace Motaz_Store
{
    partial class ReportsForm
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
            this.pnl_Line = new System.Windows.Forms.Panel();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.btn_Sells = new System.Windows.Forms.Button();
            this.Pnl_Holder = new System.Windows.Forms.Panel();
            this.btn_Sells_FPrice = new System.Windows.Forms.Button();
            this.pnl_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Line
            // 
            this.pnl_Line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(113)))), ((int)(((byte)(44)))));
            this.pnl_Line.Location = new System.Drawing.Point(253, 310);
            this.pnl_Line.Name = "pnl_Line";
            this.pnl_Line.Size = new System.Drawing.Size(200, 3);
            this.pnl_Line.TabIndex = 2;
            this.pnl_Line.Visible = false;
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(113)))), ((int)(((byte)(44)))));
            this.pnl_Top.Controls.Add(this.btn_Sells_FPrice);
            this.pnl_Top.Controls.Add(this.btn_Sells);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(957, 39);
            this.pnl_Top.TabIndex = 3;
            // 
            // btn_Sells
            // 
            this.btn_Sells.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Sells.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(38)))));
            this.btn_Sells.FlatAppearance.BorderSize = 0;
            this.btn_Sells.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(71)))), ((int)(((byte)(31)))));
            this.btn_Sells.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(71)))), ((int)(((byte)(31)))));
            this.btn_Sells.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sells.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sells.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.btn_Sells.Location = new System.Drawing.Point(800, 0);
            this.btn_Sells.Name = "btn_Sells";
            this.btn_Sells.Size = new System.Drawing.Size(157, 39);
            this.btn_Sells.TabIndex = 0;
            this.btn_Sells.Text = "مبيعات ومصاريف";
            this.btn_Sells.UseVisualStyleBackColor = true;
            this.btn_Sells.Click += new System.EventHandler(this.Top_Btns_Click);
            // 
            // Pnl_Holder
            // 
            this.Pnl_Holder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Holder.Location = new System.Drawing.Point(0, 39);
            this.Pnl_Holder.Name = "Pnl_Holder";
            this.Pnl_Holder.Size = new System.Drawing.Size(957, 488);
            this.Pnl_Holder.TabIndex = 4;
            // 
            // btn_Sells_FPrice
            // 
            this.btn_Sells_FPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Sells_FPrice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(6)))), ((int)(((byte)(38)))));
            this.btn_Sells_FPrice.FlatAppearance.BorderSize = 0;
            this.btn_Sells_FPrice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(71)))), ((int)(((byte)(31)))));
            this.btn_Sells_FPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(71)))), ((int)(((byte)(31)))));
            this.btn_Sells_FPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sells_FPrice.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sells_FPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.btn_Sells_FPrice.Location = new System.Drawing.Point(678, 0);
            this.btn_Sells_FPrice.Name = "btn_Sells_FPrice";
            this.btn_Sells_FPrice.Size = new System.Drawing.Size(122, 39);
            this.btn_Sells_FPrice.TabIndex = 1;
            this.btn_Sells_FPrice.Text = "البيع والجملة";
            this.btn_Sells_FPrice.UseVisualStyleBackColor = true;
            this.btn_Sells_FPrice.Click += new System.EventHandler(this.Top_Btns_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(957, 527);
            this.Controls.Add(this.pnl_Line);
            this.Controls.Add(this.Pnl_Holder);
            this.Controls.Add(this.pnl_Top);
            this.Font = new System.Drawing.Font("Cairo SemiBold", 9.749999F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(59)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "ReportsForm";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.pnl_Top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Line;
        private System.Windows.Forms.Panel pnl_Top;
        public System.Windows.Forms.Button btn_Sells;
        private System.Windows.Forms.Panel Pnl_Holder;
        public System.Windows.Forms.Button btn_Sells_FPrice;
    }
}