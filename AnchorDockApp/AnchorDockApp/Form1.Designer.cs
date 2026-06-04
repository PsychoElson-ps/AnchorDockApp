namespace AnchorDockApp
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
            this.panelNav = new System.Windows.Forms.Panel();
            this.panelWork = new System.Windows.Forms.Panel();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.panelWork.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.LightGray;
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(113, 450);
            this.panelNav.TabIndex = 0;
            this.panelNav.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelWork
            // 
            this.panelWork.BackColor = System.Drawing.Color.White;
            this.panelWork.Controls.Add(this.btnClick);
            this.panelWork.Controls.Add(this.txtInput);
            this.panelWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWork.Location = new System.Drawing.Point(113, 0);
            this.panelWork.Name = "panelWork";
            this.panelWork.Size = new System.Drawing.Size(687, 450);
            this.panelWork.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(147, 105);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(85, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "Введите текст";
            // 
            // btnClick
            // 
            this.btnClick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClick.Location = new System.Drawing.Point(94, 148);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(187, 103);
            this.btnClick.TabIndex = 1;
            this.btnClick.Text = "Нажми меня";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelWork);
            this.Controls.Add(this.panelNav);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelWork.ResumeLayout(false);
            this.panelWork.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel panelWork;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.TextBox txtInput;
    }
}

