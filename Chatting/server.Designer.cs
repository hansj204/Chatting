namespace Chatting
{
    partial class Server
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.server_ip = new System.Windows.Forms.TextBox();
            this.server_port = new System.Windows.Forms.TextBox();
            this.server_open = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.servername = new System.Windows.Forms.TextBox();
            this.server_close = new System.Windows.Forms.Button();
            this.server_change = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.server_talk = new System.Windows.Forms.TextBox();
            this.server_send = new System.Windows.Forms.Button();
            this.talking_server = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(33, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(33, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORT";
            // 
            // server_ip
            // 
            this.server_ip.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.server_ip.Location = new System.Drawing.Point(137, 99);
            this.server_ip.Name = "server_ip";
            this.server_ip.Size = new System.Drawing.Size(260, 31);
            this.server_ip.TabIndex = 2;
            // 
            // server_port
            // 
            this.server_port.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.server_port.Location = new System.Drawing.Point(137, 148);
            this.server_port.Name = "server_port";
            this.server_port.Size = new System.Drawing.Size(260, 31);
            this.server_port.TabIndex = 3;
            // 
            // server_open
            // 
            this.server_open.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.server_open.Location = new System.Drawing.Point(96, 219);
            this.server_open.Name = "server_open";
            this.server_open.Size = new System.Drawing.Size(82, 39);
            this.server_open.TabIndex = 4;
            this.server_open.Text = "열기";
            this.server_open.UseVisualStyleBackColor = true;
            this.server_open.Click += new System.EventHandler(this.Server_open_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(462, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "내 이름(수정 가능)";
            // 
            // servername
            // 
            this.servername.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.servername.Location = new System.Drawing.Point(454, 147);
            this.servername.Name = "servername";
            this.servername.Size = new System.Drawing.Size(260, 31);
            this.servername.TabIndex = 7;
            // 
            // server_close
            // 
            this.server_close.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.server_close.Location = new System.Drawing.Point(259, 219);
            this.server_close.Name = "server_close";
            this.server_close.Size = new System.Drawing.Size(82, 39);
            this.server_close.TabIndex = 8;
            this.server_close.Text = "종료";
            this.server_close.UseVisualStyleBackColor = true;
            this.server_close.Click += new System.EventHandler(this.Server_close_Click);
            // 
            // server_change
            // 
            this.server_change.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.server_change.Location = new System.Drawing.Point(547, 219);
            this.server_change.Name = "server_change";
            this.server_change.Size = new System.Drawing.Size(82, 39);
            this.server_change.TabIndex = 9;
            this.server_change.Text = "변경";
            this.server_change.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(23, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "채팅방 정보";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(449, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "내 정보";
            // 
            // server_talk
            // 
            this.server_talk.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.server_talk.Location = new System.Drawing.Point(12, 582);
            this.server_talk.Name = "server_talk";
            this.server_talk.Size = new System.Drawing.Size(627, 31);
            this.server_talk.TabIndex = 12;
            // 
            // server_send
            // 
            this.server_send.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.server_send.Location = new System.Drawing.Point(665, 579);
            this.server_send.Name = "server_send";
            this.server_send.Size = new System.Drawing.Size(82, 39);
            this.server_send.TabIndex = 13;
            this.server_send.Text = "보내기";
            this.server_send.UseVisualStyleBackColor = true;
            // 
            // talking_server
            // 
            this.talking_server.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.talking_server.Location = new System.Drawing.Point(12, 278);
            this.talking_server.Multiline = true;
            this.talking_server.Name = "talking_server";
            this.talking_server.Size = new System.Drawing.Size(735, 284);
            this.talking_server.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Chatting.Properties.Resources.back2;
            this.pictureBox2.Location = new System.Drawing.Point(12, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(407, 205);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chatting.Properties.Resources.back2;
            this.pictureBox1.Location = new System.Drawing.Point(441, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(763, 638);
            this.Controls.Add(this.talking_server);
            this.Controls.Add(this.server_send);
            this.Controls.Add(this.server_talk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.server_change);
            this.Controls.Add(this.server_close);
            this.Controls.Add(this.servername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.server_open);
            this.Controls.Add(this.server_port);
            this.Controls.Add(this.server_ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Server";
            this.Text = "server";
            this.Load += new System.EventHandler(this.Server_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox server_ip;
        private System.Windows.Forms.TextBox server_port;
        private System.Windows.Forms.Button server_open;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox servername;
        private System.Windows.Forms.Button server_close;
        private System.Windows.Forms.Button server_change;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox server_talk;
        private System.Windows.Forms.Button server_send;
        private System.Windows.Forms.TextBox talking_server;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}