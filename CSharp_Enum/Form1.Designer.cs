﻿namespace CSharp_Enum
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tboxName = new System.Windows.Forms.TextBox();
            this.lboxDay = new System.Windows.Forms.ListBox();
            this.lboxTime = new System.Windows.Forms.ListBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnResult2 = new System.Windows.Forms.Button();
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(12, 21);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(100, 21);
            this.tboxName.TabIndex = 0;
            // 
            // lboxDay
            // 
            this.lboxDay.FormattingEnabled = true;
            this.lboxDay.ItemHeight = 12;
            this.lboxDay.Location = new System.Drawing.Point(12, 63);
            this.lboxDay.Name = "lboxDay";
            this.lboxDay.Size = new System.Drawing.Size(120, 148);
            this.lboxDay.TabIndex = 1;
            // 
            // lboxTime
            // 
            this.lboxTime.FormattingEnabled = true;
            this.lboxTime.ItemHeight = 12;
            this.lboxTime.Location = new System.Drawing.Point(160, 63);
            this.lboxTime.Name = "lboxTime";
            this.lboxTime.Size = new System.Drawing.Size(120, 148);
            this.lboxTime.TabIndex = 2;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(12, 226);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "결과보기";
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // btnResult2
            // 
            this.btnResult2.Location = new System.Drawing.Point(117, 226);
            this.btnResult2.Name = "btnResult2";
            this.btnResult2.Size = new System.Drawing.Size(130, 23);
            this.btnResult2.TabIndex = 4;
            this.btnResult2.Text = "StringFormat Test";
            this.btnResult2.UseVisualStyleBackColor = true;
            // 
            // tboxResult
            // 
            this.tboxResult.Enabled = false;
            this.tboxResult.Location = new System.Drawing.Point(11, 280);
            this.tboxResult.Multiline = true;
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(269, 105);
            this.tboxResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 397);
            this.Controls.Add(this.tboxResult);
            this.Controls.Add(this.btnResult2);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lboxTime);
            this.Controls.Add(this.lboxDay);
            this.Controls.Add(this.tboxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.ListBox lboxDay;
        private System.Windows.Forms.ListBox lboxTime;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnResult2;
        private System.Windows.Forms.TextBox tboxResult;
    }
}

