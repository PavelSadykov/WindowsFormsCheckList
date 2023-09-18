namespace WindowsFormsCheckList
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
            this.checkListBox = new System.Windows.Forms.CheckedListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.markAsDoneButton = new System.Windows.Forms.Button();
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkListBox
            // 
            this.checkListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkListBox.FormattingEnabled = true;
            this.checkListBox.Location = new System.Drawing.Point(64, 108);
            this.checkListBox.Name = "checkListBox";
            this.checkListBox.Size = new System.Drawing.Size(330, 319);
            this.checkListBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(400, 21);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(115, 26);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить задачу";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(400, 153);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(115, 38);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Удалить задачу";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // markAsDoneButton
            // 
            this.markAsDoneButton.Location = new System.Drawing.Point(400, 108);
            this.markAsDoneButton.Name = "markAsDoneButton";
            this.markAsDoneButton.Size = new System.Drawing.Size(115, 39);
            this.markAsDoneButton.TabIndex = 4;
            this.markAsDoneButton.Text = "Отметить выполненным";
            this.markAsDoneButton.UseVisualStyleBackColor = true;
            this.markAsDoneButton.Click += new System.EventHandler(this.markAsDoneButton_Click);
            // 
            // taskTextBox
            // 
            this.taskTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskTextBox.Location = new System.Drawing.Point(64, 21);
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(330, 26);
            this.taskTextBox.TabIndex = 5;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(400, 197);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(115, 36);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Очистить чек лист";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите текст и нажмите кнопку добавить задачу";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.taskTextBox);
            this.Controls.Add(this.markAsDoneButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.checkListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button markAsDoneButton;
        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
    }
}

