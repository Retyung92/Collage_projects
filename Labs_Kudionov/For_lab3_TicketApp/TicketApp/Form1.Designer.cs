namespace TicketApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Generate = new System.Windows.Forms.Button();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTicket = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Генератор и проверка счастливых билетов";
            // 
            // Button_Generate
            // 
            this.Button_Generate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button_Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Generate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Generate.Location = new System.Drawing.Point(173, 68);
            this.Button_Generate.Name = "Button_Generate";
            this.Button_Generate.Size = new System.Drawing.Size(188, 58);
            this.Button_Generate.TabIndex = 1;
            this.Button_Generate.Text = "Сгенерировать билет";
            this.Button_Generate.UseVisualStyleBackColor = false;
            this.Button_Generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelInstruction
            // 
            this.labelInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstruction.Location = new System.Drawing.Point(128, 146);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(282, 25);
            this.labelInstruction.TabIndex = 2;
            this.labelInstruction.Text = "Нажмите кнопку для генерации";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(89, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 66);
            this.label3.TabIndex = 3;
            this.label3.Text = "Счастливый билет - это билет, в котором\r\n сумма первых трех цифр равна сумме посл" +
    "едних трех цифр";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTicket
            // 
            this.labelTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTicket.Location = new System.Drawing.Point(189, 181);
            this.labelTicket.Name = "labelTicket";
            this.labelTicket.Size = new System.Drawing.Size(172, 25);
            this.labelTicket.TabIndex = 4;
            this.labelTicket.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(189, 215);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(172, 25);
            this.labelResult.TabIndex = 5;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 341);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelTicket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.Button_Generate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Generate;
        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTicket;
        private System.Windows.Forms.Label labelResult;
    }
}

