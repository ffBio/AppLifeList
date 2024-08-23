namespace LifeList {
    partial class Form1 {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ListBox listBoxTarefas;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxTarefa;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCarregar;

        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            dateTimePicker = new DateTimePicker();
            listBoxTarefas = new ListBox();
            textBoxDescricao = new TextBox();
            textBoxTarefa = new TextBox();
            buttonAdicionar = new Button();
            buttonRemover = new Button();
            buttonSalvar = new Button();
            buttonCarregar = new Button();
            SuspendLayout();
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(12, 12);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 0;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // listBoxTarefas
            // 
            listBoxTarefas.FormattingEnabled = true;
            listBoxTarefas.ItemHeight = 15;
            listBoxTarefas.Location = new Point(12, 150);
            listBoxTarefas.Name = "listBoxTarefas";
            listBoxTarefas.Size = new Size(776, 274);
            listBoxTarefas.TabIndex = 1;
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.Location = new Point(12, 41);
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(200, 23);
            textBoxDescricao.TabIndex = 2;
            textBoxDescricao.TextChanged += textBoxDescricao_TextChanged;
            // 
            // textBoxTarefa
            // 
            textBoxTarefa.Location = new Point(12, 70);
            textBoxTarefa.Name = "textBoxTarefa";
            textBoxTarefa.Size = new Size(200, 23);
            textBoxTarefa.TabIndex = 3;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Location = new Point(218, 12);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(75, 23);
            buttonAdicionar.TabIndex = 4;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.Location = new Point(218, 41);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(75, 23);
            buttonRemover.TabIndex = 5;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(218, 70);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 23);
            buttonSalvar.TabIndex = 6;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonCarregar
            // 
            buttonCarregar.Location = new Point(218, 99);
            buttonCarregar.Name = "buttonCarregar";
            buttonCarregar.Size = new Size(75, 23);
            buttonCarregar.TabIndex = 7;
            buttonCarregar.Text = "Carregar";
            buttonCarregar.UseVisualStyleBackColor = true;
            buttonCarregar.Click += buttonCarregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCarregar);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonRemover);
            Controls.Add(buttonAdicionar);
            Controls.Add(textBoxTarefa);
            Controls.Add(textBoxDescricao);
            Controls.Add(listBoxTarefas);
            Controls.Add(dateTimePicker);
            Name = "Form1";
            Text = "Life List";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
