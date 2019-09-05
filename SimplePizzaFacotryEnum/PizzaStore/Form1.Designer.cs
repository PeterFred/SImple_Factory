namespace PizzaStore
{
    partial class PizzaStore
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
            this.LabelQuestion = new System.Windows.Forms.Label();
            this.ListBoxPizza = new System.Windows.Forms.ListBox();
            this.ButtonOrder = new System.Windows.Forms.Button();
            this.ButtonHomeDelivery = new System.Windows.Forms.Button();
            this.LabelResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelQuestion
            // 
            this.LabelQuestion.AutoSize = true;
            this.LabelQuestion.Location = new System.Drawing.Point(110, 46);
            this.LabelQuestion.Name = "LabelQuestion";
            this.LabelQuestion.Size = new System.Drawing.Size(176, 13);
            this.LabelQuestion.TabIndex = 0;
            this.LabelQuestion.Text = "What Type Of Pizza Do You Want?";
            // 
            // ListBoxPizza
            // 
            this.ListBoxPizza.FormattingEnabled = true;
            this.ListBoxPizza.Location = new System.Drawing.Point(348, 55);
            this.ListBoxPizza.Name = "ListBoxPizza";
            this.ListBoxPizza.Size = new System.Drawing.Size(120, 95);
            this.ListBoxPizza.TabIndex = 1;
            // 
            // ButtonOrder
            // 
            this.ButtonOrder.Location = new System.Drawing.Point(113, 247);
            this.ButtonOrder.Name = "ButtonOrder";
            this.ButtonOrder.Size = new System.Drawing.Size(75, 23);
            this.ButtonOrder.TabIndex = 2;
            this.ButtonOrder.Text = "Order Here";
            this.ButtonOrder.UseVisualStyleBackColor = true;
            this.ButtonOrder.Click += new System.EventHandler(this.ButtonOrder_Click);
            // 
            // ButtonHomeDelivery
            // 
            this.ButtonHomeDelivery.Location = new System.Drawing.Point(348, 349);
            this.ButtonHomeDelivery.Name = "ButtonHomeDelivery";
            this.ButtonHomeDelivery.Size = new System.Drawing.Size(75, 23);
            this.ButtonHomeDelivery.TabIndex = 3;
            this.ButtonHomeDelivery.Text = "For Home Delivery Click Here";
            this.ButtonHomeDelivery.UseVisualStyleBackColor = true;
            // 
            // LabelResults
            // 
            this.LabelResults.AutoSize = true;
            this.LabelResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LabelResults.Location = new System.Drawing.Point(348, 256);
            this.LabelResults.Name = "LabelResults";
            this.LabelResults.Size = new System.Drawing.Size(0, 13);
            this.LabelResults.TabIndex = 4;
            // 
            // PizzaStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelResults);
            this.Controls.Add(this.ButtonHomeDelivery);
            this.Controls.Add(this.ButtonOrder);
            this.Controls.Add(this.ListBoxPizza);
            this.Controls.Add(this.LabelQuestion);
            this.Name = "PizzaStore";
            this.Text = "PIZZA STORE";
            this.Load += new System.EventHandler(this.PizzaStore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelQuestion;
        private System.Windows.Forms.ListBox ListBoxPizza;
        private System.Windows.Forms.Button ButtonOrder;
        private System.Windows.Forms.Button ButtonHomeDelivery;
        private System.Windows.Forms.Label LabelResults;
    }
}

