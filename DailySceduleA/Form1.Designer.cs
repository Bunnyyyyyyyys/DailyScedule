namespace DailyScheduleApp
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
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listBoxSchedule = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTask
            // 
            this.textBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxTask.Location = new System.Drawing.Point(28, 75);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(318, 113);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.TextChanged += new System.EventHandler(this.textBoxTask_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonAdd.Location = new System.Drawing.Point(386, 75);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(223, 43);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonRemove.Location = new System.Drawing.Point(386, 145);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(223, 43);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // listBoxSchedule
            // 
            this.listBoxSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.listBoxSchedule.FormattingEnabled = true;
            this.listBoxSchedule.ItemHeight = 22;
            this.listBoxSchedule.Location = new System.Drawing.Point(28, 280);
            this.listBoxSchedule.Name = "listBoxSchedule";
            this.listBoxSchedule.Size = new System.Drawing.Size(581, 202);
            this.listBoxSchedule.TabIndex = 3;
            this.listBoxSchedule.SelectedIndexChanged += new System.EventHandler(this.listBoxSchedule_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите задачу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(23, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Список задач";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 527);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSchedule);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxTask);
            this.Name = "Form1";
            this.Text = "График на день";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxTask;
        public System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.Button buttonRemove;
        public System.Windows.Forms.ListBox listBoxSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

