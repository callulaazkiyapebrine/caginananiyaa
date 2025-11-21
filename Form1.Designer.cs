namespace kelgis
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtNama = new TextBox();
            cbDonat = new CheckBox();
            cbDessert = new CheckBox();
            cbTomandjerrycake = new CheckBox();
            cbSlicecake = new CheckBox();
            cbAnimalcake = new CheckBox();
            cbCupcake = new CheckBox();
            btnTambah = new Button();
            btnHitung = new Button();
            btnBatal = new Button();
            btnKeluar = new Button();
            btnTampil = new Button();
            cbCheesecake = new CheckBox();
            cbGlutatinounsricecake = new CheckBox();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            txtTotalBayar = new TextBox();
            txtDiskon = new TextBox();
            txtUangBayar = new TextBox();
            txtUangKembali = new TextBox();
            rbCash = new RadioButton();
            rbDebit = new RadioButton();
            rbQris = new RadioButton();
            txtCari = new TextBox();
            btnCari = new Button();
            btnBatalCari = new Button();
            dtTanggal = new DateTimePicker();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            txtGlutatinouns = new TextBox();
            txtDessert = new TextBox();
            txtDonat = new TextBox();
            txtCheese = new TextBox();
            txtSlice = new TextBox();
            txtCupCake = new TextBox();
            txtAnimal = new TextBox();
            txtTomAndJerry = new TextBox();
            btnEdit = new Button();
            label5 = new Label();
            label6 = new Label();
            txtHarga = new TextBox();
            label20 = new Label();
            btnHapus = new Button();
            pictureBox1 = new PictureBox();
            pictureQR = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureQR).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 282);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 0;
            label1.Text = "Nama pemesan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 349);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(161, 25);
            label2.TabIndex = 1;
            label2.Text = "Tanggal pembelian";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 400);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 2;
            label3.Text = "Menu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 416);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(752, 842);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(176, 25);
            label7.TabIndex = 6;
            label7.Text = "Metode Pembayaran";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(749, 785);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(97, 25);
            label8.TabIndex = 7;
            label8.Text = "Total Bayar";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(754, 735);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(67, 25);
            label9.TabIndex = 8;
            label9.Text = "Diskon";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(752, 898);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(102, 25);
            label10.TabIndex = 9;
            label10.Text = "Uang Bayar";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(752, 958);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(122, 25);
            label11.TabIndex = 10;
            label11.Text = "Uang Kembali";
            label11.Click += label11_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(229, 282);
            txtNama.Margin = new Padding(2);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(346, 31);
            txtNama.TabIndex = 11;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // cbDonat
            // 
            cbDonat.AutoSize = true;
            cbDonat.Location = new Point(42, 640);
            cbDonat.Margin = new Padding(2);
            cbDonat.Name = "cbDonat";
            cbDonat.Size = new Size(87, 29);
            cbDonat.TabIndex = 13;
            cbDonat.Text = "Donat";
            cbDonat.UseVisualStyleBackColor = true;
            cbDonat.CheckedChanged += cbDonat_CheckedChanged;
            // 
            // cbDessert
            // 
            cbDessert.AutoSize = true;
            cbDessert.Location = new Point(42, 486);
            cbDessert.Margin = new Padding(2);
            cbDessert.Name = "cbDessert";
            cbDessert.Size = new Size(97, 29);
            cbDessert.TabIndex = 14;
            cbDessert.Text = "Dessert";
            cbDessert.UseVisualStyleBackColor = true;
            // 
            // cbTomandjerrycake
            // 
            cbTomandjerrycake.AutoSize = true;
            cbTomandjerrycake.Location = new Point(42, 790);
            cbTomandjerrycake.Margin = new Padding(2);
            cbTomandjerrycake.Name = "cbTomandjerrycake";
            cbTomandjerrycake.Size = new Size(194, 29);
            cbTomandjerrycake.TabIndex = 15;
            cbTomandjerrycake.Text = "Tom And Jerry Cake";
            cbTomandjerrycake.UseVisualStyleBackColor = true;
            // 
            // cbSlicecake
            // 
            cbSlicecake.AutoSize = true;
            cbSlicecake.Location = new Point(42, 536);
            cbSlicecake.Margin = new Padding(2);
            cbSlicecake.Name = "cbSlicecake";
            cbSlicecake.Size = new Size(116, 29);
            cbSlicecake.TabIndex = 16;
            cbSlicecake.Text = "Slice Cake";
            cbSlicecake.UseVisualStyleBackColor = true;
            // 
            // cbAnimalcake
            // 
            cbAnimalcake.AutoSize = true;
            cbAnimalcake.Location = new Point(42, 741);
            cbAnimalcake.Margin = new Padding(2);
            cbAnimalcake.Name = "cbAnimalcake";
            cbAnimalcake.Size = new Size(136, 29);
            cbAnimalcake.TabIndex = 17;
            cbAnimalcake.Text = "Animal Cake";
            cbAnimalcake.UseVisualStyleBackColor = true;
            cbAnimalcake.CheckedChanged += cbAnimalcake_CheckedChanged;
            // 
            // cbCupcake
            // 
            cbCupcake.AutoSize = true;
            cbCupcake.Location = new Point(42, 691);
            cbCupcake.Margin = new Padding(2);
            cbCupcake.Name = "cbCupcake";
            cbCupcake.Size = new Size(113, 29);
            cbCupcake.TabIndex = 18;
            cbCupcake.Text = "Cup Cake";
            cbCupcake.UseVisualStyleBackColor = true;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.Pink;
            btnTambah.Location = new Point(40, 842);
            btnTambah.Margin = new Padding(2);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(112, 49);
            btnTambah.TabIndex = 21;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnHitung
            // 
            btnHitung.BackColor = Color.Pink;
            btnHitung.Location = new Point(754, 622);
            btnHitung.Margin = new Padding(2);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(112, 49);
            btnHitung.TabIndex = 22;
            btnHitung.Text = "Hitung";
            btnHitung.UseVisualStyleBackColor = false;
            btnHitung.Click += btnHitung_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Pink;
            btnBatal.Location = new Point(275, 842);
            btnBatal.Margin = new Padding(2);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(112, 49);
            btnBatal.TabIndex = 23;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.Pink;
            btnKeluar.Location = new Point(158, 842);
            btnKeluar.Margin = new Padding(2);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(112, 49);
            btnKeluar.TabIndex = 24;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = false;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // btnTampil
            // 
            btnTampil.BackColor = Color.Pink;
            btnTampil.Location = new Point(871, 622);
            btnTampil.Margin = new Padding(2);
            btnTampil.Name = "btnTampil";
            btnTampil.Size = new Size(112, 49);
            btnTampil.TabIndex = 25;
            btnTampil.Text = "Tampil";
            btnTampil.UseVisualStyleBackColor = false;
            btnTampil.Click += btnTampil_Click;
            // 
            // cbCheesecake
            // 
            cbCheesecake.AutoSize = true;
            cbCheesecake.Location = new Point(42, 588);
            cbCheesecake.Margin = new Padding(2);
            cbCheesecake.Name = "cbCheesecake";
            cbCheesecake.Size = new Size(137, 29);
            cbCheesecake.TabIndex = 26;
            cbCheesecake.Text = "Cheese Cake";
            cbCheesecake.UseVisualStyleBackColor = true;
            // 
            // cbGlutatinounsricecake
            // 
            cbGlutatinounsricecake.AutoSize = true;
            cbGlutatinounsricecake.Location = new Point(42, 438);
            cbGlutatinounsricecake.Margin = new Padding(2);
            cbGlutatinounsricecake.Name = "cbGlutatinounsricecake";
            cbGlutatinounsricecake.Size = new Size(218, 29);
            cbGlutatinounsricecake.TabIndex = 27;
            cbGlutatinounsricecake.Text = "Glutatinouns Rice Cake";
            cbGlutatinounsricecake.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(754, 342);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(621, 248);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data Pesenan";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(24, 42);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(570, 179);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtTotalBayar
            // 
            txtTotalBayar.Location = new Point(890, 781);
            txtTotalBayar.Margin = new Padding(2);
            txtTotalBayar.Name = "txtTotalBayar";
            txtTotalBayar.Size = new Size(150, 31);
            txtTotalBayar.TabIndex = 31;
            txtTotalBayar.TextChanged += txtTB_TextChanged;
            // 
            // txtDiskon
            // 
            txtDiskon.Location = new Point(890, 731);
            txtDiskon.Margin = new Padding(2);
            txtDiskon.Name = "txtDiskon";
            txtDiskon.Size = new Size(150, 31);
            txtDiskon.TabIndex = 32;
            // 
            // txtUangBayar
            // 
            txtUangBayar.Location = new Point(890, 895);
            txtUangBayar.Margin = new Padding(2);
            txtUangBayar.Name = "txtUangBayar";
            txtUangBayar.Size = new Size(150, 31);
            txtUangBayar.TabIndex = 33;
            txtUangBayar.TextChanged += textBox6_TextChanged;
            // 
            // txtUangKembali
            // 
            txtUangKembali.Location = new Point(890, 955);
            txtUangKembali.Margin = new Padding(2);
            txtUangKembali.Name = "txtUangKembali";
            txtUangKembali.Size = new Size(152, 31);
            txtUangKembali.TabIndex = 34;
            txtUangKembali.TextChanged += txtUK_TextChanged;
            // 
            // rbCash
            // 
            rbCash.AutoSize = true;
            rbCash.Location = new Point(945, 840);
            rbCash.Margin = new Padding(2);
            rbCash.Name = "rbCash";
            rbCash.Size = new Size(75, 29);
            rbCash.TabIndex = 35;
            rbCash.TabStop = true;
            rbCash.Text = "Cash";
            rbCash.UseVisualStyleBackColor = true;
            rbCash.CheckedChanged += rbCash_CheckedChanged;
            // 
            // rbDebit
            // 
            rbDebit.AutoSize = true;
            rbDebit.Location = new Point(1036, 840);
            rbDebit.Margin = new Padding(2);
            rbDebit.Name = "rbDebit";
            rbDebit.Size = new Size(80, 29);
            rbDebit.TabIndex = 36;
            rbDebit.TabStop = true;
            rbDebit.Text = "Debit";
            rbDebit.UseVisualStyleBackColor = true;
            rbDebit.CheckedChanged += rbDebit_CheckedChanged;
            // 
            // rbQris
            // 
            rbQris.AutoSize = true;
            rbQris.Location = new Point(1128, 840);
            rbQris.Margin = new Padding(2);
            rbQris.Name = "rbQris";
            rbQris.Size = new Size(69, 29);
            rbQris.TabIndex = 37;
            rbQris.TabStop = true;
            rbQris.Text = "Qris";
            rbQris.UseVisualStyleBackColor = true;
            rbQris.CheckedChanged += rbQris_CheckedChanged;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(754, 280);
            txtCari.Margin = new Padding(2);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(220, 31);
            txtCari.TabIndex = 38;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.Pink;
            btnCari.Location = new Point(992, 280);
            btnCari.Margin = new Padding(2);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(112, 34);
            btnCari.TabIndex = 39;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            // 
            // btnBatalCari
            // 
            btnBatalCari.BackColor = Color.Pink;
            btnBatalCari.Location = new Point(1115, 280);
            btnBatalCari.Margin = new Padding(2);
            btnBatalCari.Name = "btnBatalCari";
            btnBatalCari.Size = new Size(112, 34);
            btnBatalCari.TabIndex = 40;
            btnBatalCari.Text = "Batal Cari";
            btnBatalCari.UseVisualStyleBackColor = false;
            btnBatalCari.Click += btnBatalCari_Click;
            // 
            // dtTanggal
            // 
            dtTanggal.Location = new Point(229, 342);
            dtTanggal.Margin = new Padding(2);
            dtTanggal.Name = "dtTanggal";
            dtTanggal.Size = new Size(346, 31);
            dtTanggal.TabIndex = 41;
            dtTanggal.ValueChanged += dtTanggal_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(302, 441);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(88, 25);
            label12.TabIndex = 42;
            label12.Text = "Rp20.000";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(302, 486);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(88, 25);
            label13.TabIndex = 43;
            label13.Text = "Rp15.000";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(302, 536);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(88, 25);
            label14.TabIndex = 44;
            label14.Text = "Rp25.000";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(302, 589);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(88, 25);
            label15.TabIndex = 45;
            label15.Text = "Rp45.000";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(302, 641);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(88, 25);
            label16.TabIndex = 46;
            label16.Text = "Rp10.000";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(302, 791);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(74, 25);
            label17.TabIndex = 47;
            label17.Text = "Rp5000";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(302, 741);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(88, 25);
            label18.TabIndex = 48;
            label18.Text = "Rp55.000";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(302, 692);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(88, 25);
            label19.TabIndex = 49;
            label19.Text = "Rp12.000";
            label19.Click += label19_Click;
            // 
            // txtGlutatinouns
            // 
            txtGlutatinouns.Location = new Point(462, 435);
            txtGlutatinouns.Margin = new Padding(2);
            txtGlutatinouns.Multiline = true;
            txtGlutatinouns.Name = "txtGlutatinouns";
            txtGlutatinouns.Size = new Size(110, 32);
            txtGlutatinouns.TabIndex = 50;
            txtGlutatinouns.KeyPress += txtGlutatinouns_KeyPress;
            // 
            // txtDessert
            // 
            txtDessert.Location = new Point(462, 484);
            txtDessert.Margin = new Padding(2);
            txtDessert.Name = "txtDessert";
            txtDessert.Size = new Size(110, 31);
            txtDessert.TabIndex = 51;
            txtDessert.KeyPress += txtDessert_KeyPress;
            // 
            // txtDonat
            // 
            txtDonat.Location = new Point(462, 638);
            txtDonat.Margin = new Padding(2);
            txtDonat.Name = "txtDonat";
            txtDonat.Size = new Size(110, 31);
            txtDonat.TabIndex = 52;
            txtDonat.KeyPress += txtDonat_KeyPress;
            // 
            // txtCheese
            // 
            txtCheese.Location = new Point(462, 586);
            txtCheese.Margin = new Padding(2);
            txtCheese.Name = "txtCheese";
            txtCheese.Size = new Size(110, 31);
            txtCheese.TabIndex = 53;
            txtCheese.TextChanged += textBox4_TextChanged;
            txtCheese.KeyPress += txtCheese_KeyPress;
            // 
            // txtSlice
            // 
            txtSlice.Location = new Point(462, 534);
            txtSlice.Margin = new Padding(2);
            txtSlice.Name = "txtSlice";
            txtSlice.Size = new Size(110, 31);
            txtSlice.TabIndex = 54;
            txtSlice.KeyPress += txtSlice_KeyPress;
            // 
            // txtCupCake
            // 
            txtCupCake.Location = new Point(462, 690);
            txtCupCake.Margin = new Padding(2);
            txtCupCake.Name = "txtCupCake";
            txtCupCake.Size = new Size(110, 31);
            txtCupCake.TabIndex = 55;
            txtCupCake.KeyPress += txtCupCake_KeyPress;
            // 
            // txtAnimal
            // 
            txtAnimal.Location = new Point(462, 741);
            txtAnimal.Margin = new Padding(2);
            txtAnimal.Name = "txtAnimal";
            txtAnimal.Size = new Size(110, 31);
            txtAnimal.TabIndex = 56;
            txtAnimal.KeyPress += txtAnimal_KeyPress;
            // 
            // txtTomAndJerry
            // 
            txtTomAndJerry.Location = new Point(462, 791);
            txtTomAndJerry.Margin = new Padding(2);
            txtTomAndJerry.Name = "txtTomAndJerry";
            txtTomAndJerry.Size = new Size(110, 31);
            txtTomAndJerry.TabIndex = 57;
            txtTomAndJerry.KeyPress += txtTomAndJerry_KeyPress;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Pink;
            btnEdit.Location = new Point(989, 622);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 49);
            btnEdit.TabIndex = 58;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(486, 400);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 59;
            label5.Text = "Jumlah";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(758, 688);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 25);
            label6.TabIndex = 60;
            label6.Text = "Harga";
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(890, 688);
            txtHarga.Margin = new Padding(2);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(150, 31);
            txtHarga.TabIndex = 61;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(485, 22);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(464, 45);
            label20.TabIndex = 62;
            label20.Text = "CAGINANANIYA CAKE";
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Pink;
            btnHapus.Location = new Point(1108, 624);
            btnHapus.Margin = new Padding(4);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(118, 48);
            btnHapus.TabIndex = 63;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LavenderBlush;
            pictureBox1.BackgroundImage = Properties.Resources.WhatsApp_Image_2025_10_30_at_17_16_41;
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2025_10_30_at_17_16_41;
            pictureBox1.Location = new Point(562, 71);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 194);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureQR
            // 
            pictureQR.Image = Properties.Resources.qrisula;
            pictureQR.Location = new Point(1261, 634);
            pictureQR.Name = "pictureQR";
            pictureQR.Size = new Size(402, 399);
            pictureQR.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureQR.TabIndex = 65;
            pictureQR.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1710, 1045);
            Controls.Add(pictureQR);
            Controls.Add(pictureBox1);
            Controls.Add(btnHapus);
            Controls.Add(label20);
            Controls.Add(txtHarga);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnEdit);
            Controls.Add(txtTomAndJerry);
            Controls.Add(txtAnimal);
            Controls.Add(txtCupCake);
            Controls.Add(txtSlice);
            Controls.Add(txtCheese);
            Controls.Add(txtDonat);
            Controls.Add(txtDessert);
            Controls.Add(txtGlutatinouns);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(dtTanggal);
            Controls.Add(btnBatalCari);
            Controls.Add(btnCari);
            Controls.Add(txtCari);
            Controls.Add(rbQris);
            Controls.Add(rbDebit);
            Controls.Add(rbCash);
            Controls.Add(txtUangKembali);
            Controls.Add(txtUangBayar);
            Controls.Add(txtDiskon);
            Controls.Add(txtTotalBayar);
            Controls.Add(groupBox1);
            Controls.Add(cbGlutatinounsricecake);
            Controls.Add(cbCheesecake);
            Controls.Add(btnTampil);
            Controls.Add(btnKeluar);
            Controls.Add(btnBatal);
            Controls.Add(btnHitung);
            Controls.Add(btnTambah);
            Controls.Add(cbCupcake);
            Controls.Add(cbAnimalcake);
            Controls.Add(cbSlicecake);
            Controls.Add(cbTomandjerrycake);
            Controls.Add(cbDessert);
            Controls.Add(cbDonat);
            Controls.Add(txtNama);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "caginananiya cake";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtNama;
        private CheckBox cbDonat;
        private CheckBox cbDessert;
        private CheckBox cbTomandjerrycake;
        private CheckBox cbSlicecake;
        private CheckBox cbAnimalcake;
        private CheckBox cbCupcake;
        private Button btnTambah;
        private Button btnHitung;
        private Button btnBatal;
        private Button btnKeluar;
        private Button btnTampil;
        private CheckBox cbCheesecake;
        private CheckBox cbGlutatinounsricecake;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private TextBox txtTotalBayar;
        private TextBox txtDiskon;
        private TextBox txtUangBayar;
        private TextBox txtUangKembali;
        private RadioButton rbCash;
        private RadioButton rbDebit;
        private RadioButton rbQris;
        private TextBox txtCari;
        private Button btnCari;
        private Button btnBatalCari;
        private DateTimePicker dtTanggal;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox txtGlutatinouns;
        private TextBox txtDessert;
        private TextBox txtDonat;
        private TextBox txtCheese;
        private TextBox txtSlice;
        private TextBox txtCupCake;
        private TextBox txtAnimal;
        private TextBox txtTomAndJerry;
        private Button btnEdit;
        private Label label5;
        private Label label6;
        private TextBox txtHarga;
        private Label label20;
        private Button btnHapus;
        private PictureBox pictureBox1;
        private PictureBox pictureQR;
    }
}
