namespace Sistema_vendas.Telas
{
    partial class Pedidos_itens
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
            this.tabControlPedidos = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.txtBuscaCpf = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgwConsulta = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscaPedido = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnInsertReg = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtValorTotalPedido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgwPedidos = new System.Windows.Forms.DataGridView();
            this.Num_ped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_linha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDataHoje = new System.Windows.Forms.TextBox();
            this.cboIdprod = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotallinha = new System.Windows.Forms.TextBox();
            this.tabControlPedidos.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwConsulta)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPedidos
            // 
            this.tabControlPedidos.Controls.Add(this.tabPage2);
            this.tabControlPedidos.Controls.Add(this.tabPage1);
            this.tabControlPedidos.Location = new System.Drawing.Point(4, 1);
            this.tabControlPedidos.Name = "tabControlPedidos";
            this.tabControlPedidos.SelectedIndex = 0;
            this.tabControlPedidos.Size = new System.Drawing.Size(967, 450);
            this.tabControlPedidos.TabIndex = 0;
            this.tabControlPedidos.UseWaitCursor = true;
            this.tabControlPedidos.Click += new System.EventHandler(this.tabCriar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.btnExcluir);
            this.tabPage2.Controls.Add(this.txtBuscaNome);
            this.tabPage2.Controls.Add(this.txtBuscaCpf);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.dgwConsulta);
            this.tabPage2.Controls.Add(this.btnBuscar);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtBuscaPedido);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(959, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar";
            this.tabPage2.UseWaitCursor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(176, 75);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.UseWaitCursor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.Location = new System.Drawing.Point(93, 77);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(77, 20);
            this.txtBuscaNome.TabIndex = 24;
            this.txtBuscaNome.UseWaitCursor = true;
            // 
            // txtBuscaCpf
            // 
            this.txtBuscaCpf.Location = new System.Drawing.Point(93, 45);
            this.txtBuscaCpf.Name = "txtBuscaCpf";
            this.txtBuscaCpf.Size = new System.Drawing.Size(77, 20);
            this.txtBuscaCpf.TabIndex = 23;
            this.txtBuscaCpf.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Nome do cliente";
            this.label12.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Cpf";
            this.label11.UseWaitCursor = true;
            // 
            // dgwConsulta
            // 
            this.dgwConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwConsulta.Location = new System.Drawing.Point(257, 10);
            this.dgwConsulta.Name = "dgwConsulta";
            this.dgwConsulta.Size = new System.Drawing.Size(696, 405);
            this.dgwConsulta.TabIndex = 20;
            this.dgwConsulta.UseWaitCursor = true;
            this.dgwConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwConsulta_CellClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(176, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.UseWaitCursor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Numero Pedido";
            this.label6.UseWaitCursor = true;
            // 
            // txtBuscaPedido
            // 
            this.txtBuscaPedido.Location = new System.Drawing.Point(93, 11);
            this.txtBuscaPedido.Name = "txtBuscaPedido";
            this.txtBuscaPedido.Size = new System.Drawing.Size(77, 20);
            this.txtBuscaPedido.TabIndex = 17;
            this.txtBuscaPedido.UseWaitCursor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.txtTotallinha);
            this.tabPage1.Controls.Add(this.btnInsertReg);
            this.tabPage1.Controls.Add(this.btnInserir);
            this.tabPage1.Controls.Add(this.txtValorTotalPedido);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dgwPedidos);
            this.tabPage1.Controls.Add(this.txtDataHoje);
            this.tabPage1.Controls.Add(this.cboIdprod);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtValor);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtQtde);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtIdPedido);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.txtCpf);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(959, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Criar";
            this.tabPage1.UseWaitCursor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnInsertReg
            // 
            this.btnInsertReg.Location = new System.Drawing.Point(609, 393);
            this.btnInsertReg.Name = "btnInsertReg";
            this.btnInsertReg.Size = new System.Drawing.Size(121, 23);
            this.btnInsertReg.TabIndex = 49;
            this.btnInsertReg.Text = "Inserir registro";
            this.btnInsertReg.UseVisualStyleBackColor = true;
            this.btnInsertReg.UseWaitCursor = true;
            this.btnInsertReg.Click += new System.EventHandler(this.btnInsertReg_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(524, 113);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 48;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.UseWaitCursor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtValorTotalPedido
            // 
            this.txtValorTotalPedido.Location = new System.Drawing.Point(827, 395);
            this.txtValorTotalPedido.Name = "txtValorTotalPedido";
            this.txtValorTotalPedido.Size = new System.Drawing.Size(127, 20);
            this.txtValorTotalPedido.TabIndex = 47;
            this.txtValorTotalPedido.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(754, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Valor total";
            this.label5.UseWaitCursor = true;
            // 
            // dgwPedidos
            // 
            this.dgwPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num_ped,
            this.Cod_prod,
            this.Quantidade,
            this.Valor_linha});
            this.dgwPedidos.Location = new System.Drawing.Point(5, 142);
            this.dgwPedidos.Name = "dgwPedidos";
            this.dgwPedidos.Size = new System.Drawing.Size(949, 247);
            this.dgwPedidos.TabIndex = 45;
            this.dgwPedidos.UseWaitCursor = true;
            // 
            // Num_ped
            // 
            this.Num_ped.HeaderText = "Numero_pedido";
            this.Num_ped.Name = "Num_ped";
            // 
            // Cod_prod
            // 
            this.Cod_prod.HeaderText = "Codigo_produto";
            this.Cod_prod.Name = "Cod_prod";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // Valor_linha
            // 
            this.Valor_linha.HeaderText = "Total";
            this.Valor_linha.Name = "Valor_linha";
            // 
            // txtDataHoje
            // 
            this.txtDataHoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataHoje.Location = new System.Drawing.Point(864, 51);
            this.txtDataHoje.Name = "txtDataHoje";
            this.txtDataHoje.Size = new System.Drawing.Size(90, 22);
            this.txtDataHoje.TabIndex = 44;
            this.txtDataHoje.UseWaitCursor = true;
            // 
            // cboIdprod
            // 
            this.cboIdprod.FormattingEnabled = true;
            this.cboIdprod.Location = new System.Drawing.Point(5, 113);
            this.cboIdprod.Name = "cboIdprod";
            this.cboIdprod.Size = new System.Drawing.Size(211, 21);
            this.cboIdprod.TabIndex = 43;
            this.cboIdprod.UseWaitCursor = true;
            this.cboIdprod.Leave += new System.EventHandler(this.cboIdprod_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "Nome do produto";
            this.label10.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(425, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Total";
            this.label9.UseWaitCursor = true;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(323, 113);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(77, 22);
            this.txtValor.TabIndex = 39;
            this.txtValor.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(320, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Valor";
            this.label8.UseWaitCursor = true;
            // 
            // txtQtde
            // 
            this.txtQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.Location = new System.Drawing.Point(243, 113);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(54, 22);
            this.txtQtde.TabIndex = 37;
            this.txtQtde.UseWaitCursor = true;
            this.txtQtde.Leave += new System.EventHandler(this.txtQtde_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(240, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Qtde";
            this.label7.UseWaitCursor = true;
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPedido.Location = new System.Drawing.Point(865, 12);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(48, 22);
            this.txtIdPedido.TabIndex = 35;
            this.txtIdPedido.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(741, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Data lançamento";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(741, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Numero do pedido";
            this.label3.UseWaitCursor = true;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(81, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(94, 22);
            this.txtNome.TabIndex = 32;
            this.txtNome.UseWaitCursor = true;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(81, 9);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(94, 22);
            this.txtCpf.TabIndex = 31;
            this.txtCpf.UseWaitCursor = true;
            this.txtCpf.Leave += new System.EventHandler(this.txtCpf_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nome";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Cpf";
            this.label1.UseWaitCursor = true;
            // 
            // txtTotallinha
            // 
            this.txtTotallinha.Enabled = false;
            this.txtTotallinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotallinha.Location = new System.Drawing.Point(428, 112);
            this.txtTotallinha.Name = "txtTotallinha";
            this.txtTotallinha.Size = new System.Drawing.Size(77, 22);
            this.txtTotallinha.TabIndex = 50;
            this.txtTotallinha.UseWaitCursor = true;
            // 
            // Pedidos_itens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(973, 454);
            this.Controls.Add(this.tabControlPedidos);
            this.Name = "Pedidos_itens";
            this.Text = "Pedidos";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Pedidos_itens_Load);
            this.tabControlPedidos.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwConsulta)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPedidos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnInsertReg;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtValorTotalPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgwPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_ped;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_linha;
        private System.Windows.Forms.TextBox txtDataHoje;
        private System.Windows.Forms.ComboBox cboIdprod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgwConsulta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscaPedido;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.TextBox txtBuscaCpf;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtTotallinha;
    }
}