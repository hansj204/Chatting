namespace Chatting
{
    partial class Client
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
            this.client_ip = new System.Windows.Forms.TextBox();
            this.client_port = new System.Windows.Forms.TextBox();
            this.client_open = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.clientname = new System.Windows.Forms.TextBox();
            this.client_close = new System.Windows.Forms.Button();
            this.client_change = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.client_talk = new System.Windows.Forms.TextBox();
            this.client_send = new System.Windows.Forms.Button();
            this.talking_client = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // client_ip
            // 
            this.client_ip.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.client_ip.Location = new System.Drawing.Point(137, 99);
            this.client_ip.Name = "client_ip";
            this.client_ip.Size = new System.Drawing.Size(260, 31);
            this.client_ip.TabIndex = 2;
            // 
            // client_port
            // 
            this.client_port.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.client_port.Location = new System.Drawing.Point(137, 148);
            this.client_port.Name = "client_port";
            this.client_port.Size = new System.Drawing.Size(260, 31);
            this.client_port.TabIndex = 3;
            // 
            // client_open
            // 
            this.client_open.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.client_open.Location = new System.Drawing.Point(96, 219);
            this.client_open.Name = "client_open";
            this.client_open.Size = new System.Drawing.Size(82, 39);
            this.client_open.TabIndex = 4;
            this.client_open.Text = "열기";
            this.client_open.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(451, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "내 이름(수정 가능)";
            // 
            // clientname
            // 
            this.clientname.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.clientname.Location = new System.Drawing.Point(456, 143);
            this.clientname.Name = "clientname";
            this.clientname.Size = new System.Drawing.Size(260, 31);
            this.clientname.TabIndex = 7;
            // 
            // client_close
            // 
            this.client_close.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.client_close.Location = new System.Drawing.Point(259, 219);
            this.client_close.Name = "client_close";
            this.client_close.Size = new System.Drawing.Size(82, 39);
            this.client_close.TabIndex = 8;
            this.client_close.Text = "종료";
            this.client_close.UseVisualStyleBackColor = true;
            this.client_close.Click += new System.EventHandler(this.Client_close_Click);
            // 
            // client_change
            // 
            this.client_change.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.client_change.Location = new System.Drawing.Point(537, 206);
            this.client_change.Name = "client_change";
            this.client_change.Size = new System.Drawing.Size(82, 39);
            this.client_change.TabIndex = 9;
            this.client_change.Text = "변경";
            this.client_change.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "접속할 채팅방 정보";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(424, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "내 정보";
            // 
            // client_talk
            // 
            this.client_talk.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.client_talk.Location = new System.Drawing.Point(38, 582);
            this.client_talk.Name = "client_talk";
            this.client_talk.Size = new System.Drawing.Size(591, 31);
            this.client_talk.TabIndex = 12;
            // 
            // client_send
            // 
            this.client_send.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.client_send.Location = new System.Drawing.Point(665, 579);
            this.client_send.Name = "client_send";
            this.client_send.Size = new System.Drawing.Size(82, 39);
            this.client_send.TabIndex = 13;
            this.client_send.Text = "보내기";
            this.client_send.UseVisualStyleBackColor = true;
            // 
            // talking_client
            // 
            this.talking_client.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.talking_client.Location = new System.Drawing.Point(12, 278);
            this.talking_client.Multiline = true;
            this.talking_client.Name = "talking_client";
            this.talking_client.Size = new System.Drawing.Size(741, 284);
            this.talking_client.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chatting.Properties.Resources.back2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Chatting.Properties.Resources.back2;
            this.pictureBox2.Location = new System.Drawing.Point(424, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(329, 205);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(768, 638);
            this.Controls.Add(this.talking_client);
            this.Controls.Add(this.client_send);
            this.Controls.Add(this.client_talk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.client_change);
            this.Controls.Add(this.client_close);
            this.Controls.Add(this.clientname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.client_open);
            this.Controls.Add(this.client_port);
            this.Controls.Add(this.client_ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Client";
            this.Text = "server";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox client_ip;
        private System.Windows.Forms.TextBox client_port;
        private System.Windows.Forms.Button client_open;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clientname;
        private System.Windows.Forms.Button client_close;
        private System.Windows.Forms.Button client_change;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox client_talk;
        private System.Windows.Forms.Button client_send;
        private System.Windows.Forms.TextBox talking_client;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}