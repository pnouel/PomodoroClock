namespace PomodoroClock
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.moveObj = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.moveObj.SuspendLayout();
            this.SuspendLayout();
            // 
            // moveObj
            // 
            this.moveObj.BackgroundImage = global::PomodoroClock.Properties.Resources.bgTomatoF;
            this.moveObj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moveObj.Controls.Add(this.textBox3);
            this.moveObj.Controls.Add(this.textBox2);
            this.moveObj.Controls.Add(this.textBox1);
            this.moveObj.Controls.Add(this.btnClose);
            this.moveObj.Controls.Add(this.btnReset);
            this.moveObj.Controls.Add(this.btnStop);
            this.moveObj.Controls.Add(this.btnStart);
            this.moveObj.Location = new System.Drawing.Point(0, 0);
            this.moveObj.Name = "moveObj";
            this.moveObj.Size = new System.Drawing.Size(469, 411);
            this.moveObj.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(235, 326);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 38);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Salir";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkRed;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.Location = new System.Drawing.Point(76, 265);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 38);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.DarkRed;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStop.Location = new System.Drawing.Point(49, 197);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(117, 38);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Parar";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkRed;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStart.Location = new System.Drawing.Point(76, 129);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(117, 38);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(202, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 75);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(280, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(72, 75);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "00";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(358, 184);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(72, 75);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "00";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(481, 437);
            this.Controls.Add(this.moveObj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.moveObj.ResumeLayout(false);
            this.moveObj.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel moveObj;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

