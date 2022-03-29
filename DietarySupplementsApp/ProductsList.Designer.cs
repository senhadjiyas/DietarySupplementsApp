
namespace DietarySupplementsApp
{
    partial class ProductsList
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
            this.label5 = new System.Windows.Forms.Label();
            this.gvProductsList = new System.Windows.Forms.DataGridView();
            this.btnRequest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductsList)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(413, 68);
            this.label5.TabIndex = 18;
            this.label5.Text = "Products Listing";
            // 
            // gvProductsList
            // 
            this.gvProductsList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gvProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProductsList.GridColor = System.Drawing.SystemColors.ControlLight;
            this.gvProductsList.Location = new System.Drawing.Point(44, 144);
            this.gvProductsList.Name = "gvProductsList";
            this.gvProductsList.RowHeadersWidth = 62;
            this.gvProductsList.RowTemplate.Height = 28;
            this.gvProductsList.Size = new System.Drawing.Size(863, 262);
            this.gvProductsList.TabIndex = 17;
            this.gvProductsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProductsList_CellContentClick);
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(156, 454);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(188, 60);
            this.btnRequest.TabIndex = 19;
            this.btnRequest.Text = "Request New Product";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(720, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 60);
            this.button1.TabIndex = 20;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(498, 454);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(134, 60);
            this.btnOrders.TabIndex = 21;
            this.btnOrders.Text = "My Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // ProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 559);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gvProductsList);
            this.Name = "ProductsList";
            this.Text = "Products List";
            this.Load += new System.EventHandler(this.ProductsList_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gvProductsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gvProductsList;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOrders;
    }
}