
namespace DietarySupplementsApp
{
    partial class RequestsList
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
            this.btnRequest = new System.Windows.Forms.Button();
            this.gvRequestsList = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvRequestsList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnRequest.Location = new System.Drawing.Point(165, 479);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(188, 55);
            this.btnRequest.TabIndex = 21;
            this.btnRequest.Text = "Request New Product";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // gvRequestsList
            // 
            this.gvRequestsList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gvRequestsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRequestsList.Location = new System.Drawing.Point(69, 155);
            this.gvRequestsList.Name = "gvRequestsList";
            this.gvRequestsList.RowHeadersWidth = 62;
            this.gvRequestsList.RowTemplate.Height = 28;
            this.gvRequestsList.Size = new System.Drawing.Size(737, 249);
            this.gvRequestsList.TabIndex = 20;
            this.gvRequestsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRequestsList_CellContentClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(183, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(422, 68);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Requests Listing";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 55);
            this.button1.TabIndex = 23;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RequestsList
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(838, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.gvRequestsList);
            this.Name = "RequestsList";
            this.Text = "Requests List";
            this.Load += new System.EventHandler(this.RequestsList_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gvRequestsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEditRecord;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gvRecordList;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.DataGridView gvRequestsList;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button1;
    }
}