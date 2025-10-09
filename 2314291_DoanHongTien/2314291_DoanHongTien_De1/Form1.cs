
using System.Windows.Forms;

namespace _2314291_DoanHongTien_De1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "dskh.txt");
            Docfile(filePath);
            HienThiDanhSach();
        }
        List<KhachHang> danhsachKhachHang = new List<KhachHang>();
        public void Docfile(string filename)
        {
            try
            {
                if (!File.Exists(filename))
                {
                    MessageBox.Show("Không tìm thấy file: " + filename);
                    return;
                }

                danhsachKhachHang.Clear();
                string[] lines = File.ReadAllLines(filename);

                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] r = line.Split(',');
                    if (r.Length == 4)
                    {
                        danhsachKhachHang.Add(new KhachHang
                        {
                            MaKhachHang = r[0].Trim(),
                            TenKhachHang = r[1].Trim(),
                            SDT = r[2].Trim(),
                            DiaChi = r[3].Trim()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file: " + ex.Message);
            }
        }

        private void HienThiDanhSach()
        {

            listView1.Items.Clear();

            foreach (var kh in danhsachKhachHang)
            {
                ListViewItem item = new ListViewItem(kh.MaKhachHang);
                item.SubItems.Add(kh.TenKhachHang);
                item.SubItems.Add(kh.SDT);
                item.SubItems.Add(kh.DiaChi);

                listView1.Items.Add(item);
            }
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            mtSTD.Clear();
            txtDiaChi.Clear();
            txtTimKiem.Clear();
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtMaKH.Text = item.SubItems[0].Text;
                txtTenKH.Text = item.SubItems[1].Text;
                mtSTD.Text = item.SubItems[2].Text;
                txtDiaChi.Text = item.SubItems[3].Text;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maKH =txtMaKH.Text.Trim();
            string tenKH=txtTenKH.Text.Trim();
            string sdt = mtSTD.Text.Trim();
            string diachia =txtDiaChi.Text.Trim();
            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Mã khach hang không được để trống", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isUpdate = false;
            foreach(ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].Text ==maKH)
                {
                    item.SubItems[0].Text = tenKH;
                    item.SubItems[1].Text = sdt;
                    item.SubItems[2].Text = diachia;
                    isUpdate = true;
                    break;
                }
            }
            if(!isUpdate)
            {
                ListViewItem newitem =  new ListViewItem(maKH);
                newitem.SubItems.Add(tenKH);
                newitem.SubItems.Add((sdt).ToString());
                newitem.SubItems.Add(diachia);
                listView1.Items.Add(newitem);
                txtMaKH.Clear();
                txtTenKH.Clear();
                mtSTD.Clear();
                txtDiaChi.Clear();
            }

        }
    }
}
