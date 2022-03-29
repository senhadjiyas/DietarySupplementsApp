
namespace DietarySupplementsApp
{
    partial class OrdersList
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gvOrdersList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrdersList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(533, 414);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(128, 55);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(81, 414);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(188, 55);
            this.btnOrder.TabIndex = 23;
            this.btnOrder.Text = "Order New ";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 68);
            this.label5.TabIndex = 22;
            this.label5.Text = "My Orders ";
            // 
            // gvOrdersList
            // 
            this.gvOrdersList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gvOrdersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrdersList.GridColor = System.Drawing.SystemColors.ControlLight;
            this.gvOrdersList.Location = new System.Drawing.Point(12, 106);
            this.gvOrdersList.Name = "gvOrdersList";
            this.gvOrdersList.RowHeadersWidth = 62;
            this.gvOrdersList.RowTemplate.Height = 28;
            this.gvOrdersList.Size = new System.Drawing.Size(863, 262);
            this.gvOrdersList.TabIndex = 21;
            this.gvOrdersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProductsList_CellContentClick);
            // 
            // OrdersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 540);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gvOrdersList);
            this.Name = "OrdersList";
            this.Text = "My Orders";
            this.Load += new System.EventHandler(this.OrdersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrdersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gvOrdersList;
    }
}