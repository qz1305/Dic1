using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HASHTABLE
{
    public partial class frmMain : Form
    {
        //Properties
        MyDictionary myDictionary;
        private bool isExist = false;
        private bool isChange = false;
        //Constructor
        public frmMain()
        {
            InitializeComponent();
            myDictionary = new MyDictionary();
            myDictionary.myHashTable.InitHashTable();
            myDictionary.LoadData(@"C:\Users\Admin\Desktop\Input.txt");

        }
        //Method
        //Hàm tìm kiếm một từ điền
        private Node Search()
        {
            Node sub = myDictionary.SearchDictionary(txbEng.Text.ToLower().Trim());
            if (sub == null)
            {
                lbNotify.Text = "Không tìm thấy kết quả";
                picSearch.Visible = true;
            }
            else
            {
                txbViet.Text = sub.value;
                lbNotify.Text = "";
                picSearch.Visible = false;
            }
            return sub;
        }
        //Hàm xử lý sự kiện khi nhấn button thoát, sẽ lưu lại dữ liệu người dùng
        private void btnQuit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát sao ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (isChange)
                    myDictionary.BackUp("Input.txt");
                Application.Exit();
            }
        }
        //Hàm xử lý sự kiện thay đổi text box english, sẽ tìm kiếm từ tiếng việt tương ứng
        private void txbEng_TextChanged(object sender, EventArgs e)
        {
            Search();
            if (txbEng.Text == "")
            {
                txbViet.Text = "";
                lbNotify.Text = "Xin mời nhập bất cứ từ gì bạn muốn tra cứu";
                picSearch.Visible = false;
            }
        }
        //Hàm xóa một từ điển
        private void Remove()
        {
            Node sub = Search();
            if (sub != null)
            {
                if (MessageBox.Show("Bạn có muốn xóa từ này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    isChange = true;
                    lbNotify.Text = "Đã xóa thành công";
                    myDictionary.RemoveDictionary(txbEng.Text.ToLower().Trim());
                }
            }
        }
        //Hàm xử lý sự kiện nhấn button Xóa
        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }
        //Hàm xử lý sự kiện nhấn thêm từ sẽ hiện ra button lưu
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            this.ActiveControl = txbViet;
        }
        //Hàm thêm một từ điển,  nếu từ điển đã tồn tại, người dùng có thể thay đổi nội dung
        private void Add()
        {
            picSearch.Visible = true;
            if (isExist)
            {
                myDictionary.ChangeDictionary(txbEng.Text.ToLower().Trim(), txbViet.Text);
                lbNotify.Text = "Lưu thay đổi thành công";
                isExist = false;
            }
            else
            {
                bool flag = myDictionary.AddDictionary(txbEng.Text.ToLower().Trim(), txbViet.Text);
                if (flag == false)
                    lbNotify.Text = "Thêm vào không thành công";
                else
                    lbNotify.Text = "Thêm vào thành công";
            }
        }
        //Hàm xử lý sự kiện nhất button lưu
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (txbEng.Text.Trim() == "")
                MessageBox.Show("Không được để trống từ cần dịch", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Node sub = myDictionary.SearchDictionary(txbEng.Text.ToLower().Trim());
                if (sub != null)
                {
                    if (MessageBox.Show("Từ này đã tồn tại bạn có muốn thay đổi nội dung không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        isExist = true;
                        flag = true;
                    }
                    else
                    {
                        txbViet.Text = sub.value;
                        flag = false;
                    }
                }
                else
                    flag = true;
            }
            if (flag)
            {
                isChange = true;
                Add();
            }
            btnSave.Visible = false;
        }
        //Hàm xử lý sự kiện txbViet thay đổi
        private void txbViet_TextChanged(object sender, EventArgs e)
        {
            btnSave.Visible = true;
        }
        //Hàm xử lý sự kiện khi nhân vào các button thì button sẽ đổi màu
        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Lime;
        }
        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.PaleGreen;
        }
    }
}
