﻿namespace esheraz
{
    partial class СhatForm
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
            this.components = new System.ComponentModel.Container();
            this.PoleVvoda = new System.Windows.Forms.TextBox();
            this.chatik = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PoleVvoda
            // 
            this.PoleVvoda.Location = new System.Drawing.Point(12, 235);
            this.PoleVvoda.Multiline = true;
            this.PoleVvoda.Name = "PoleVvoda";
            this.PoleVvoda.Size = new System.Drawing.Size(268, 37);
            this.PoleVvoda.TabIndex = 0;
            // 
            // chatik
            // 
            this.chatik.Location = new System.Drawing.Point(12, 12);
            this.chatik.Multiline = true;
            this.chatik.Name = "chatik";
            this.chatik.ReadOnly = true;
            this.chatik.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.chatik.Size = new System.Drawing.Size(345, 190);
            this.chatik.TabIndex = 1;
            this.chatik.TabStop = false;
            this.chatik.Text = "Denis: Привет!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 2;
            this.button1.TabStop = false;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сюда вводим сообщение:";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // СhatForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 284);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chatik);
            this.Controls.Add(this.PoleVvoda);
            this.Name = "СhatForm";
            this.Text = "ChatikForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PoleVvoda;
        private System.Windows.Forms.TextBox chatik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label2;
    }
}

