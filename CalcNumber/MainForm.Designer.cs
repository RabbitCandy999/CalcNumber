namespace CalcNumber
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_TextIndex = new System.Windows.Forms.Label();
            this.lab_TextProblem = new System.Windows.Forms.Label();
            this.lab_Text = new System.Windows.Forms.Label();
            this.txb_Result = new System.Windows.Forms.TextBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Result = new System.Windows.Forms.Button();
            this.btn_GiveUp = new System.Windows.Forms.Button();
            this.lab_Result = new System.Windows.Forms.Label();
            this.lab_Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_TextIndex
            // 
            this.lab_TextIndex.AutoSize = true;
            this.lab_TextIndex.Font = new System.Drawing.Font("微软雅黑", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_TextIndex.Location = new System.Drawing.Point(12, 9);
            this.lab_TextIndex.Name = "lab_TextIndex";
            this.lab_TextIndex.Size = new System.Drawing.Size(116, 48);
            this.lab_TextIndex.TabIndex = 0;
            this.lab_TextIndex.Text = "第1题";
            // 
            // lab_TextProblem
            // 
            this.lab_TextProblem.AutoSize = true;
            this.lab_TextProblem.Font = new System.Drawing.Font("微软雅黑", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_TextProblem.Location = new System.Drawing.Point(12, 67);
            this.lab_TextProblem.Name = "lab_TextProblem";
            this.lab_TextProblem.Size = new System.Drawing.Size(598, 48);
            this.lab_TextProblem.TabIndex = 1;
            this.lab_TextProblem.Text = "计算：3333333333+3333333333";
            // 
            // lab_Text
            // 
            this.lab_Text.AutoSize = true;
            this.lab_Text.Font = new System.Drawing.Font("微软雅黑", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Text.Location = new System.Drawing.Point(12, 127);
            this.lab_Text.Name = "lab_Text";
            this.lab_Text.Size = new System.Drawing.Size(353, 48);
            this.lab_Text.TabIndex = 2;
            this.lab_Text.Text = "请输入你的计算结果";
            // 
            // txb_Result
            // 
            this.txb_Result.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Result.Location = new System.Drawing.Point(20, 178);
            this.txb_Result.Name = "txb_Result";
            this.txb_Result.Size = new System.Drawing.Size(602, 47);
            this.txb_Result.TabIndex = 3;
            // 
            // btn_Next
            // 
            this.btn_Next.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Next.Location = new System.Drawing.Point(20, 231);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(170, 49);
            this.btn_Next.TabIndex = 4;
            this.btn_Next.Text = "下一题";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Result
            // 
            this.btn_Result.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Result.Location = new System.Drawing.Point(196, 231);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(249, 49);
            this.btn_Result.TabIndex = 5;
            this.btn_Result.Text = "验证结果";
            this.btn_Result.UseVisualStyleBackColor = true;
            this.btn_Result.Click += new System.EventHandler(this.btn_Result_Click);
            // 
            // btn_GiveUp
            // 
            this.btn_GiveUp.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_GiveUp.Location = new System.Drawing.Point(451, 231);
            this.btn_GiveUp.Name = "btn_GiveUp";
            this.btn_GiveUp.Size = new System.Drawing.Size(170, 49);
            this.btn_GiveUp.TabIndex = 6;
            this.btn_GiveUp.Text = "交卷";
            this.btn_GiveUp.UseVisualStyleBackColor = true;
            this.btn_GiveUp.Click += new System.EventHandler(this.btn_GiveUp_Click);
            // 
            // lab_Result
            // 
            this.lab_Result.AutoSize = true;
            this.lab_Result.Font = new System.Drawing.Font("微软雅黑", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Result.Location = new System.Drawing.Point(12, 283);
            this.lab_Result.Name = "lab_Result";
            this.lab_Result.Size = new System.Drawing.Size(0, 48);
            this.lab_Result.TabIndex = 7;
            // 
            // lab_Score
            // 
            this.lab_Score.AutoSize = true;
            this.lab_Score.Font = new System.Drawing.Font("微软雅黑", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Score.Location = new System.Drawing.Point(424, 9);
            this.lab_Score.Name = "lab_Score";
            this.lab_Score.Size = new System.Drawing.Size(153, 48);
            this.lab_Score.TabIndex = 8;
            this.lab_Score.Text = "得分：0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 343);
            this.Controls.Add(this.lab_Score);
            this.Controls.Add(this.lab_Result);
            this.Controls.Add(this.btn_GiveUp);
            this.Controls.Add(this.btn_Result);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.txb_Result);
            this.Controls.Add(this.lab_Text);
            this.Controls.Add(this.lab_TextProblem);
            this.Controls.Add(this.lab_TextIndex);
            this.MaximumSize = new System.Drawing.Size(652, 390);
            this.MinimumSize = new System.Drawing.Size(652, 390);
            this.Name = "MainForm";
            this.Text = "小学计算题";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_TextIndex;
        private System.Windows.Forms.Label lab_TextProblem;
        private System.Windows.Forms.Label lab_Text;
        private System.Windows.Forms.TextBox txb_Result;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Result;
        private System.Windows.Forms.Button btn_GiveUp;
        private System.Windows.Forms.Label lab_Result;
        private System.Windows.Forms.Label lab_Score;
    }
}

