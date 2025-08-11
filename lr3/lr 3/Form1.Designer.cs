namespace lr_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpDishes = new System.Windows.Forms.GroupBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.rtbOrderSummary = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstMenuGroups = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(226, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ресторан X - заказ";
            // 
            // grpDishes
            // 
            this.grpDishes.Location = new System.Drawing.Point(309, 60);
            this.grpDishes.Name = "grpDishes";
            this.grpDishes.Size = new System.Drawing.Size(400, 292);
            this.grpDishes.TabIndex = 2;
            this.grpDishes.TabStop = false;
            this.grpDishes.Text = "Блюда";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(475, 379);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(183, 62);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Заказать";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // rtbOrderSummary
            // 
            this.rtbOrderSummary.Location = new System.Drawing.Point(13, 379);
            this.rtbOrderSummary.Name = "rtbOrderSummary";
            this.rtbOrderSummary.ReadOnly = true;
            this.rtbOrderSummary.Size = new System.Drawing.Size(411, 126);
            this.rtbOrderSummary.TabIndex = 4;
            this.rtbOrderSummary.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(475, 460);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 30);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstMenuGroups
            // 
            this.lstMenuGroups.FormattingEnabled = true;
            this.lstMenuGroups.ItemHeight = 16;
            this.lstMenuGroups.Location = new System.Drawing.Point(10, 60);
            this.lstMenuGroups.Name = "lstMenuGroups";
            this.lstMenuGroups.Size = new System.Drawing.Size(200, 292);
            this.lstMenuGroups.TabIndex = 6;
            this.lstMenuGroups.SelectedIndexChanged += new System.EventHandler(this.lstMenuGroups_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.lstMenuGroups);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rtbOrderSummary);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grpDishes);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpDishes;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.RichTextBox rtbOrderSummary;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstMenuGroups;
    }
}

