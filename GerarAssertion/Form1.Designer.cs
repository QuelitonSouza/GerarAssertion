namespace GerarAssertion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_clientId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_urlsso = new TextBox();
            btn_gerar = new Button();
            label3 = new Label();
            txt_file = new TextBox();
            btn_abrir = new Button();
            txt_assertion_token = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_scope = new TextBox();
            label6 = new Label();
            txt_token = new TextBox();
            SuspendLayout();
            // 
            // txt_clientId
            // 
            txt_clientId.Location = new Point(12, 22);
            txt_clientId.Name = "txt_clientId";
            txt_clientId.Size = new Size(405, 23);
            txt_clientId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 1;
            label1.Text = "ClientId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "Url SSO";
            // 
            // txt_urlsso
            // 
            txt_urlsso.Location = new Point(12, 112);
            txt_urlsso.Name = "txt_urlsso";
            txt_urlsso.Size = new Size(405, 23);
            txt_urlsso.TabIndex = 2;
            // 
            // btn_gerar
            // 
            btn_gerar.Location = new Point(319, 188);
            btn_gerar.Name = "btn_gerar";
            btn_gerar.Size = new Size(102, 42);
            btn_gerar.TabIndex = 4;
            btn_gerar.Text = "Gerar";
            btn_gerar.UseVisualStyleBackColor = true;
            btn_gerar.Click += btn_gerar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 141);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 6;
            label3.Text = "Private Pem";
            // 
            // txt_file
            // 
            txt_file.BackColor = SystemColors.ScrollBar;
            txt_file.BorderStyle = BorderStyle.FixedSingle;
            txt_file.Enabled = false;
            txt_file.Location = new Point(12, 159);
            txt_file.Name = "txt_file";
            txt_file.Size = new Size(346, 23);
            txt_file.TabIndex = 5;
            // 
            // btn_abrir
            // 
            btn_abrir.Location = new Point(364, 159);
            btn_abrir.Name = "btn_abrir";
            btn_abrir.Size = new Size(58, 23);
            btn_abrir.TabIndex = 7;
            btn_abrir.Text = "Abrir";
            btn_abrir.UseVisualStyleBackColor = true;
            btn_abrir.Click += btn_abrir_Click;
            // 
            // txt_assertion_token
            // 
            txt_assertion_token.Font = new Font("Segoe UI", 8F);
            txt_assertion_token.Location = new Point(432, 24);
            txt_assertion_token.Multiline = true;
            txt_assertion_token.Name = "txt_assertion_token";
            txt_assertion_token.Size = new Size(579, 122);
            txt_assertion_token.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(434, 6);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 9;
            label4.Text = "Assertion Token";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 49);
            label5.Name = "label5";
            label5.Size = new Size(172, 15);
            label5.TabIndex = 11;
            label5.Text = "Scope(s) - separado por espaço";
            // 
            // txt_scope
            // 
            txt_scope.Location = new Point(10, 67);
            txt_scope.Name = "txt_scope";
            txt_scope.Size = new Size(405, 23);
            txt_scope.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(434, 149);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 13;
            label6.Text = "Token (Bearer)";
            // 
            // txt_token
            // 
            txt_token.Font = new Font("Segoe UI", 8F);
            txt_token.Location = new Point(432, 167);
            txt_token.Multiline = true;
            txt_token.Name = "txt_token";
            txt_token.Size = new Size(579, 120);
            txt_token.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1023, 293);
            Controls.Add(label6);
            Controls.Add(txt_token);
            Controls.Add(label5);
            Controls.Add(txt_scope);
            Controls.Add(label4);
            Controls.Add(txt_assertion_token);
            Controls.Add(btn_abrir);
            Controls.Add(label3);
            Controls.Add(txt_file);
            Controls.Add(btn_gerar);
            Controls.Add(label2);
            Controls.Add(txt_urlsso);
            Controls.Add(label1);
            Controls.Add(txt_clientId);
            Name = "Form1";
            Text = "Gerar Assertion Token";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_clientId;
        private Label label1;
        private Label label2;
        private TextBox txt_urlsso;
        private Button btn_gerar;
        private Label label3;
        private TextBox txt_file;
        private Button btn_abrir;
        private TextBox txt_assertion_token;
        private Label label4;
        private Label label5;
        private TextBox txt_scope;
        private Label label6;
        private TextBox txt_token;
    }
}
