using QRCoder;
using System.Drawing.Text;
using System.Dynamic;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace kelgis
{
    public partial class Form1 : Form
    {
        // 🔹 Deklarasi variabel global (bisa diakses semua tombol)
        private bool isEditing = false;
        private int editIndex = -1;

        private List<string> daftarnama = new List<string>();

        int hargaGlutatinounsRiceCake = 20000;
        int hargaDessert = 15000;
        int hargaSliceCake = 25000;
        int hargaCheeseCake = 45000;
        int hargaDonat = 10000;
        int hargaCupCake = 12000;
        int hargaAnimalCake = 55000;
        int hargaTomAndJerryCake = 50000;

        int total = 0, diskon = 0, totalBayar = 0;


        public Form1()
        {
            InitializeComponent();

        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (txtUangBayar.Text == "" || txtTotalBayar.Text == "")
            {
                txtUangKembali.Text = "";
                return;
            }
            try
            {
                int UangBayar = int.Parse(txtUangBayar.Text);
                int TotalBayar = int.Parse(txtTotalBayar.Text);

                int kembali = UangBayar - TotalBayar;

                txtUangKembali.Text = kembali.ToString();
                txtUangKembali.ReadOnly = true;
            }
            catch
            {
                txtUangKembali.Text = "Input Tidak Valid!";
            }

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama pemesan tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi pesanan (minimal satu dicentang dan jumlah > 0)
            bool adaPesanan =
                (cbDonat.Checked && !string.IsNullOrEmpty(txtDonat.Text) && int.Parse(txtDonat.Text) > 0) ||
                (cbCupcake.Checked && !string.IsNullOrEmpty(txtCupCake.Text) && int.Parse(txtCupCake.Text) > 0) ||
                (cbCheesecake.Checked && !string.IsNullOrEmpty(txtCheese.Text) && int.Parse(txtCheese.Text) > 0) ||
                (cbSlicecake.Checked && !string.IsNullOrEmpty(txtSlice.Text) && int.Parse(txtSlice.Text) > 0) ||
                (cbDessert.Checked && !string.IsNullOrEmpty(txtDessert.Text) && int.Parse(txtDessert.Text) > 0) ||
                (cbGlutatinounsricecake.Checked && !string.IsNullOrEmpty(txtGlutatinouns.Text) && int.Parse(txtGlutatinouns.Text) > 0) ||
                (cbAnimalcake.Checked && !string.IsNullOrEmpty(txtAnimal.Text) && int.Parse(txtAnimal.Text) > 0) ||
                (cbTomandjerrycake.Checked && !string.IsNullOrEmpty(txtTomAndJerry.Text) && int.Parse(txtTomAndJerry.Text) > 0);

            if (!adaPesanan)
            {
                MessageBox.Show("Silakan pilih minimal satu pesanan dengan jumlah lebih dari 0!",
                                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // hentikan eksekusi
            }

            // === Jika validasi lolos ===
            string nama = txtNama.Text;
            string dataPesanan = "";
            int total = 0;

            if (cbDonat.Checked && !string.IsNullOrEmpty(txtDonat.Text))
            {
                int jumlah = int.Parse(txtDonat.Text);
                int harga = 10000;
                int subtotal = harga * jumlah;
                dataPesanan += $"Donat - Rp{harga:N0} x {jumlah} = Rp{subtotal:N0}\n";
                total += subtotal;
            }

            if (cbCupcake.Checked && !string.IsNullOrEmpty(txtCupCake.Text))
            {
                int jumlah = int.Parse(txtCupCake.Text);
                int harga = 12000;
                int subtotal = harga * jumlah;
                dataPesanan += $"Cup Cake - Rp{harga:N0} x {jumlah} = Rp{subtotal:N0}\n";
                total += subtotal;
            }

            if (cbCheesecake.Checked && !string.IsNullOrEmpty(txtCheese.Text))
            {
                int jumlah = int.Parse(txtCheese.Text);
                int harga = 45000;
                int subtotal = harga * jumlah;
                dataPesanan += $"Cheese Cake - Rp{harga:N0} x {jumlah} = Rp{subtotal:N0}\n";
                total += subtotal;
            }

            if (cbSlicecake.Checked && !string.IsNullOrEmpty(txtSlice.Text))
            {
                int jumlah = int.Parse(txtSlice.Text);
                int harga = 25000;
                int subtotal = harga * jumlah;
                dataPesanan += $"Slice Cake - Rp{harga:N0} x {jumlah} = Rp{subtotal:N0}\n";
                total += subtotal;
            }

            if (cbDessert.Checked && !string.IsNullOrEmpty(txtDessert.Text))
            {
                int jumlah = int.Parse(txtDessert.Text);
                int harga = 15000;
                int subtotal = harga * jumlah;
                dataPesanan += $"Dessert - Rp{harga:N0} x {jumlah} = Rp{subtotal:N0}\n";
                total += subtotal;
            }

            if (cbGlutatinounsricecake.Checked && !string.IsNullOrEmpty(txtGlutatinouns.Text))
            {
                int jumlah = int.Parse(txtGlutatinouns.Text);
                int harga = 20000;
                int subtotal = harga * jumlah;
                dataPesanan += $"Glutinous Rice Cake - Rp{harga:N0} x {jumlah} = Rp{subtotal:N0}\n";
                total += subtotal;
            }

            if (cbAnimalcake.Checked && !string.IsNullOrEmpty(txtAnimal.Text))
            {
                int jumlah = int.Parse(txtAnimal.Text);
                int harga = 55000;
                int subtotal = harga * jumlah;
                dataPesanan += $"Animal Cake - Rp{harga:N0} x {jumlah} = Rp{subtotal:N0}\n";
                total += subtotal;
            }

            if (cbTomandjerrycake.Checked && !string.IsNullOrEmpty(txtTomAndJerry.Text))
            {
                int jumlah = int.Parse(txtTomAndJerry.Text);
                int harga = 50000;
                int subtotal = harga * jumlah;
                dataPesanan += $"Tom & Jerry Cake - Rp{harga:N0} x {jumlah} = Rp{subtotal:N0}\n";
                total += subtotal;
            }

            string listItem = $"{nama.Trim()} | {dataPesanan.Trim()}";

            // === MODE EDIT ===
            if (isEditing && editIndex >= 0)
            {
                listBox1.Items[editIndex] = listItem;
                if (editIndex < daftarnama.Count)
                    daftarnama[editIndex] = listItem;

                MessageBox.Show("Perubahan data berhasil disimpan!", "Edit Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isEditing = false;
                editIndex = -1;
            }
            else
            {
                // === MODE TAMBAH BARU ===
                listBox1.Items.Add(listItem);
                daftarnama.Add(listItem);

                MessageBox.Show("Pesanan berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtHarga.Text = total.ToString("N0");

        }





        private void btnHitung_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (cbGlutatinounsricecake.Checked)
            {
                int jumlah = 0;
                int.TryParse(txtGlutatinouns.Text, out jumlah);
                total += hargaGlutatinounsRiceCake * jumlah;
            }

            if (cbDessert.Checked)
            {
                int jumlah = 0;
                int.TryParse(txtDessert.Text, out jumlah);
                total += hargaDessert * jumlah;
            }

            if (cbSlicecake.Checked)
            {
                int jumlah = 0;
                int.TryParse(txtSlice.Text, out jumlah);
                total += hargaSliceCake * jumlah;
            }

            if (cbCheesecake.Checked)
            {
                int jumlah = 0;
                int.TryParse(txtCheese.Text, out jumlah);
                total += hargaCheeseCake * jumlah;
            }

            if (cbDonat.Checked)
            {
                int jumlah = 0;
                int.TryParse(txtDonat.Text, out jumlah);
                total += hargaDonat * jumlah;
            }

            if (cbCupcake.Checked)
            {
                int jumlah = 0;
                int.TryParse(txtCupCake.Text, out jumlah);
                total += hargaCupCake * jumlah;
            }

            if (cbAnimalcake.Checked)
            {
                int jumlah = 0;
                int.TryParse(txtAnimal.Text, out jumlah);
                total += hargaAnimalCake * jumlah;
            }

            if (cbTomandjerrycake.Checked)
            {
                int jumlah = 0;
                int.TryParse(txtTomAndJerry.Text, out jumlah);
                total += hargaTomAndJerryCake * jumlah;
            }

            double diskon = 0;
            if (total > 100000)
            {
                diskon = total * 0.10;
            }
            else if (total > 50000)
            {
                diskon = total * 0.05;
            }

            double totalBayar = total - diskon;


            txtDiskon.Text = diskon.ToString();
            txtTotalBayar.Text = totalBayar.ToString();
            txtTotalBayar.ReadOnly = true;
            txtUangBayar.Focus();

            txtDiskon.Text = $"{diskon}";

            string metode = rbCash.Checked ? "Cash" : rbDebit.Checked ? "Debit" : rbQris.Checked ? "Qris" : "Belum dipilih";
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            // Validasi metode pembayaran
            if (!rbCash.Checked && !rbDebit.Checked && !rbQris.Checked)
            {
                MessageBox.Show("Silakan pilih metode pembayaran!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // hentikan eksekusi tombol Tampil
            }

            string struk = "";
            // Header toko
            struk += "=== CAGINANANIYA CAKE ===\n";
            struk += "Jl. Cintawana No. 14, Tasikmalaya\n";
            struk += "------------------------------\n";
            struk += "         DATA PESANAN         \n";
            struk += "------------------------------\n";
            struk += "Nama Pemesan: " + txtNama.Text + "\n";
            struk += "Tanggal     : " + dtTanggal.Value.ToShortDateString() + "\n\n";
            struk += "Pesanan:\n";

            int total = 0;

            // Fungsi bantu untuk menambahkan menu
            void TambahPesanan(CheckBox cb, TextBox tb, string namaMenu, int harga)
            {
                if (cb.Checked)
                {
                    int jumlah = int.Parse(tb.Text);
                    int subtotal = harga * jumlah;
                    struk += $"- {namaMenu.PadRight(20)} x{jumlah} = Rp{subtotal:N0}\n";
                    total += subtotal;
                }
            }

            // Tambahkan semua menu
            TambahPesanan(cbGlutatinounsricecake, txtGlutatinouns, "Glutatinouns Rice Cake", 20000);
            TambahPesanan(cbDessert, txtDessert, "Dessert", 15000);
            TambahPesanan(cbSlicecake, txtSlice, "Slice Cake", 25000);
            TambahPesanan(cbCheesecake, txtCheese, "Cheese Cake", 45000);
            TambahPesanan(cbDonat, txtDonat, "Donat", 10000);
            TambahPesanan(cbCupcake, txtCupCake, "Cup Cake", 12000);
            TambahPesanan(cbAnimalcake, txtAnimal, "Animal Cake", 55000);
            TambahPesanan(cbTomandjerrycake, txtTomAndJerry, "Tom And Jerry Cake", 5000);

            // Hitung diskon
            double diskon = 0;
            if (total >= 100000)
                diskon = total * 0.1;
            else if (total >= 50000)
                diskon = total * 0.05;

            double totalBayar = total - diskon;

            txtDiskon.Text = diskon.ToString();
            txtTotalBayar.Text = totalBayar.ToString();

            // Tambahkan subtotal, diskon, total
            struk += "------------------------------\n";
            struk += $"Subtotal   : Rp{total:N0}\n";
            struk += $"Diskon     : Rp{diskon:N0}\n";
            struk += $"Total Bayar: Rp{totalBayar:N0}\n";

            // Metode pembayaran
            string metode = "";
            if (rbCash.Checked)
                metode = "Cash";
            else if (rbDebit.Checked)
                metode = "Debit";
            else if (rbQris.Checked)
                metode = "Qris";
            else
                metode = "Belum Dipilih";

            struk += $"Metode Pembayaran: {metode}\n";

            // Uang bayar & kembalian
            if (!string.IsNullOrEmpty(txtUangBayar.Text))
            {
                double bayar = double.Parse(txtUangBayar.Text);
                double kembali = bayar - totalBayar;
                struk += $"Uang Bayar   : Rp{bayar:N0}\n";
                struk += $"Uang Kembali : Rp{kembali:N0}\n";
            }

            struk += "==============================\n";
            struk += "   Terima Kasih Telah Berbelanja!   \n";

            // Tampilkan struk
            MessageBox.Show(struk, "Struk Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset otomatis semua input
            txtNama.Clear();
            txtGlutatinouns.Clear();
            txtDessert.Clear();
            txtSlice.Clear();
            txtCheese.Clear();
            txtDonat.Clear();
            txtCupCake.Clear();
            txtAnimal.Clear();
            txtTomAndJerry.Clear();
            txtUangBayar.Clear();
            txtDiskon.Clear();
            txtTotalBayar.Clear();
            txtHarga.Clear();

            cbGlutatinounsricecake.Checked = false;
            cbDessert.Checked = false;
            cbSlicecake.Checked = false;
            cbCheesecake.Checked = false;
            cbDonat.Checked = false;
            cbCupcake.Checked = false;
            cbAnimalcake.Checked = false;
            cbTomandjerrycake.Checked = false;

            rbCash.Checked = false;
            rbDebit.Checked = false;
            rbQris.Checked = false;

            pictureQR.Image = null;
            pictureQR.Visible = false;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            txtNama.Clear();
            txtUangBayar.Clear();
            txtDiskon.Clear();
            txtTotalBayar.Clear();
            txtUangKembali.Clear();
            txtHarga.Clear();

            txtGlutatinouns.Text = "";
            txtDessert.Text = "";
            txtSlice.Text = "";
            txtCheese.Text = "";
            txtDonat.Text = "";
            txtCupCake.Text = "";
            txtAnimal.Text = "";
            txtTomAndJerry.Text = "";

            cbGlutatinounsricecake.Checked = false;
            cbDessert.Checked = false;
            cbSlicecake.Checked = false;
            cbCheesecake.Checked = false;
            cbDonat.Checked = false;
            cbCupcake.Checked = false;
            cbAnimalcake.Checked = false;
            cbTomandjerrycake.Checked = false;

            rbCash.Checked = false;
            rbDebit.Checked = false;
            rbQris.Checked = false;

            listBox1.Items.Clear();

            pictureQR.Image = null;
            pictureQR.Visible = false;

            total = 0;
            diskon = 0;
            totalBayar = 0;
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult keluar = MessageBox.Show("Yakin ingin keluar dari aplikasi?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (keluar == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rbQris_CheckedChanged(object sender, EventArgs e)
        {
            txtUangBayar.Enabled = false;     // Tidak perlu input uang bayar
            txtUangKembali.Enabled = false;   // tidak ada uang kembali
            txtUangBayar.Text = "";
            txtUangKembali.Text = "";
            pictureQR.Visible = true;
            pictureQR.Image = Properties.Resources.qrisula;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string keyword = txtCari.Text.Trim().ToLower();
            bool ditemukan = false;

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Masukkan nama yang ingin dicari!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listBox1.Items.Clear(); // Hapus tampilan lama dulu

            // Loop semua data asli di daftarPeserta
            foreach (string data in daftarnama)
            {
                string[] bagian = data.Split('|');
                if (bagian.Length > 0)
                {
                    string nama = bagian[0].Trim().ToLower();
                    if (nama == keyword) // cocokkan nama
                    {
                        listBox1.Items.Add(data);
                        ditemukan = true;
                    }
                }
            }

            if (!ditemukan)
            {
                MessageBox.Show("Nama tidak ditemukan.", "Pencarian", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dtTanggal.Value = DateTime.Today;

            pictureQR.Visible = false;
        }

        private void btnBatalCari_Click(object sender, EventArgs e)
        {
            txtCari.Clear();
            listBox1.Items.Clear();

            // tampilkan kembali semua data dari daftarPeserta
            foreach (string data in daftarnama)
            {
                listBox1.Items.Add(data);
            }


        }

        private void txtTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbDonat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtUK_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbAnimalcake_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih dulu data pesanan yang mau diedit!");
                return;
            }

            string data = listBox1.SelectedItem.ToString();
            string[] bagian1 = data.Split('|');
            if (bagian1.Length < 2)
            {
                MessageBox.Show("Format Data Tidak Sesuai");
                return;
            }

            string namaPemes = bagian1[0].Trim();
            string menuInfo = bagian1[1].Trim();

            txtNama.Text = namaPemes;

            // Reset semua checkbox & textbox
            cbSlicecake.Checked = false; txtSlice.Clear();
            cbGlutatinounsricecake.Checked = false; txtGlutatinouns.Clear();
            cbDonat.Checked = false; txtDonat.Clear();
            cbCupcake.Checked = false; txtCupCake.Clear();
            cbAnimalcake.Checked = false; txtAnimal.Clear();
            cbCheesecake.Checked = false; txtCheese.Clear();
            cbDessert.Checked = false; txtDessert.Clear();
            cbTomandjerrycake.Checked = false; txtTomAndJerry.Clear();

            string[] daftarMenu = menuInfo.Split('\n');
            foreach (string menu in daftarMenu)
            {
                string[] parts = menu.Split('-');
                if (parts.Length < 2) continue;

                string namaMenu = parts[0].Trim();
                string jumlahPart = parts[1].Trim();
                string[] jumlahSplit = jumlahPart.Split('x');
                if (jumlahSplit.Length < 2) continue;

                string jumlahStr = jumlahSplit[1].Split('=')[0].Trim();
                int.TryParse(jumlahStr, out int jumlah);

                switch (namaMenu)
                {
                    case "Slice Cake": cbSlicecake.Checked = true; txtSlice.Text = jumlah.ToString(); break;
                    case "Dessert": cbDessert.Checked = true; txtDessert.Text = jumlah.ToString(); break;
                    case "Glutinous Rice Cake": cbGlutatinounsricecake.Checked = true; txtGlutatinouns.Text = jumlah.ToString(); break;
                    case "Cheese Cake": cbCheesecake.Checked = true; txtCheese.Text = jumlah.ToString(); break;
                    case "Donat": cbDonat.Checked = true; txtDonat.Text = jumlah.ToString(); break;
                    case "Cup Cake": cbCupcake.Checked = true; txtCupCake.Text = jumlah.ToString(); break;
                    case "Animal Cake": cbAnimalcake.Checked = true; txtAnimal.Text = jumlah.ToString(); break;
                    case "Tom & Jerry Cake": cbTomandjerrycake.Checked = true; txtTomAndJerry.Text = jumlah.ToString(); break;
                }
            }

            // Aktifkan mode edit
            isEditing = true;
            editIndex = listBox1.SelectedIndex;

            MessageBox.Show($"Data pemesan '{namaPemes}' siap diedit.\nUbah nama/menu/jumlah lalu klik 'Tambah' untuk menyimpan perubahan.", "Mode Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCash.Checked)
            {
                txtUangBayar.Enabled = true;      // Aktifkan input uang bayar
                txtUangKembali.Enabled = true;    // Aktifkan uang kembali
                txtUangBayar.Text = "";
                txtUangKembali.Text = "";
                pictureQR.Visible = false;
            }
        }

        private void rbDebit_CheckedChanged(object sender, EventArgs e)
        {
            txtUangBayar.Enabled = false;     // Tidak perlu input uang bayar
            txtUangKembali.Enabled = false;   // tidak ada uang kembali
            txtUangBayar.Text = "";
            txtUangKembali.Text = "";
            pictureQR.Visible = false;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            txtNama.Clear();
            txtUangBayar.Clear();
            txtDiskon.Clear();
            txtTotalBayar.Clear();
            txtUangKembali.Clear();
            txtHarga.Clear();

            txtGlutatinouns.Text = "";
            txtDessert.Text = "";
            txtSlice.Text = "";
            txtCheese.Text = "";
            txtDonat.Text = "";
            txtCupCake.Text = "";
            txtAnimal.Text = "";
            txtTomAndJerry.Text = "";

            cbGlutatinounsricecake.Checked = false;
            cbDessert.Checked = false;
            cbSlicecake.Checked = false;
            cbCheesecake.Checked = false;
            cbDonat.Checked = false;
            cbCupcake.Checked = false;
            cbAnimalcake.Checked = false;
            cbTomandjerrycake.Checked = false;
            listBox1.Items.Clear();

            pictureQR.Image = null;
            pictureQR.Visible = false;

            rbCash.Checked = false;
            rbDebit.Checked = false;
            rbQris.Checked = false;


            total = 0;
            diskon = 0;
            totalBayar = 0;

            // Pastikan ada yang dipilih
            if (listBox1.SelectedIndex >= 0)
            {
                DialogResult konfirmasi = MessageBox.Show(
                    "Apakah kamu yakin ingin menghapus pesanan ini?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (konfirmasi == DialogResult.Yes)
                {
                    int index = listBox1.SelectedIndex;

                    // Hapus dari list utama dan tampilan
                    daftarnama.RemoveAt(index);
                    listBox1.Items.RemoveAt(index);

                    MessageBox.Show("Pesanan berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Pilih pesanan yang ingin dihapus terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtGlutatinouns_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // blok input kalau bukan angka
            }
        }

        private void txtDessert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // blok input kalau bukan angka
            }
        }

        private void txtSlice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // blok input kalau bukan angka
            }
        }

        private void txtCheese_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // blok input kalau bukan angka
            }
        }

        private void txtDonat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // blok input kalau bukan angka
            }
        }

        private void txtCupCake_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // blok input kalau bukan angka
            }
        }

        private void txtAnimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // blok input kalau bukan angka
            }
        }

        private void txtTomAndJerry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // blok input kalau bukan angka
            }
        }

        private void dtTanggal_ValueChanged(object sender, EventArgs e)
        {
            if (dtTanggal.Value.Date != DateTime.Today)
            {
                MessageBox.Show("Hanya Tanggal Hari Ini Yang Bisa Dapat Dipilih.",
                    "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtTanggal.Value = DateTime.Today;
            }
        }
    }
}



