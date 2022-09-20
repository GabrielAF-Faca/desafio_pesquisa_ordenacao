namespace desafio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_curso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_limpar = new System.Windows.Forms.Button();
            this.button_listar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox_listagem = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 49);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de cadastro/consulta de alunos";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_nome);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(60, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 54);
            this.panel2.TabIndex = 1;
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(52, 17);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(227, 23);
            this.textBox_nome.TabIndex = 1;
            this.textBox_nome.TextChanged += new System.EventHandler(this.atualizar_button);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox_curso);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(60, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 54);
            this.panel3.TabIndex = 1;
            // 
            // textBox_curso
            // 
            this.textBox_curso.Location = new System.Drawing.Point(52, 17);
            this.textBox_curso.Name = "textBox_curso";
            this.textBox_curso.Size = new System.Drawing.Size(227, 23);
            this.textBox_curso.TabIndex = 1;
            this.textBox_curso.TextChanged += new System.EventHandler(this.atualizar_button);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Curso:";
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.Enabled = false;
            this.button_cadastrar.Location = new System.Drawing.Point(172, 190);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.button_cadastrar.TabIndex = 2;
            this.button_cadastrar.Text = "Cadastrar";
            this.button_cadastrar.UseVisualStyleBackColor = true;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.button_cadastrar);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 225);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button_limpar);
            this.panel5.Controls.Add(this.button_listar);
            this.panel5.Location = new System.Drawing.Point(12, 243);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(416, 195);
            this.panel5.TabIndex = 4;
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(172, 105);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(75, 23);
            this.button_limpar.TabIndex = 0;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // button_listar
            // 
            this.button_listar.Location = new System.Drawing.Point(172, 76);
            this.button_listar.Name = "button_listar";
            this.button_listar.Size = new System.Drawing.Size(75, 23);
            this.button_listar.TabIndex = 0;
            this.button_listar.Text = "Listar";
            this.button_listar.UseVisualStyleBackColor = true;
            this.button_listar.Click += new System.EventHandler(this.button_listar_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBox_listagem);
            this.panel6.Location = new System.Drawing.Point(434, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(354, 426);
            this.panel6.TabIndex = 5;
            // 
            // textBox_listagem
            // 
            this.textBox_listagem.Location = new System.Drawing.Point(3, 3);
            this.textBox_listagem.Multiline = true;
            this.textBox_listagem.Name = "textBox_listagem";
            this.textBox_listagem.ReadOnly = true;
            this.textBox_listagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_listagem.Size = new System.Drawing.Size(348, 420);
            this.textBox_listagem.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox textBox_nome;
        private Panel panel3;
        private TextBox textBox_curso;
        private Label label3;
        private Button button_cadastrar;
        private Panel panel4;
        private Panel panel5;
        private Button button_limpar;
        private Button button_listar;
        private Panel panel6;
        private TextBox textBox_listagem;
    }
}