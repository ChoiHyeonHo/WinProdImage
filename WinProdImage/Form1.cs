using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinProdImage
{
    public partial class Form1 : Form
    {
        DataTable dtImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            ProductDB db = new ProductDB();
            dataGridView1.DataSource = db.GetProductList();
            db.Dispose();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            lblProductID.Text = dataGridView1["productID", e.RowIndex].Value.ToString();
            txtProductName.Text = dataGridView1["productName", e.RowIndex].Value.ToString();
            txtProductPrice.Text = dataGridView1["productPrice", e.RowIndex].Value.ToString();

            //선택된 제품의 등록된 이미지 목록을 listbox에 바인딩
            BindProductImageList(int.Parse(lblProductID.Text));

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //유효성 체크
            if (lblProductID.Text.Trim().Length < 1 || txtProductName.Text.Trim().Length < 1)
            {
                MessageBox.Show("이미지 추가를 할 제품을 선택하세요");
                return;
            }

            //제품명, 제품번호를 같이 생성자에 보내준다.
            int pid = int.Parse(lblProductID.Text);
            string pname = txtProductName.Text;
            Form2 frm = new Form2(pid, pname);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //이미지 목록을 조회해서 ListBox에 바인딩
                BindProductImageList(pid);
            }

        }

        private void BindProductImageList(int pid)
        {
            listBox1.Items.Clear();
            pictureBox1.Image = null;

            ProductDB db = new ProductDB();
            dtImage = db.GetProductImageList(pid);
            db.Dispose();
            foreach (DataRow dr in dtImage.Rows)
            {
                listBox1.Items.Add(dr["productImgFileName"].ToString());
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                string filePath = listBox1.SelectedItems[0].ToString();

                if (filePath.Contains("BLOB이미지"))
                {
                    string imgID = filePath.Replace("BLOB이미지/", "");
                    DataRow[] drArr = dtImage.Select("productImageID="+ imgID);
                    if (drArr.Length > 0)
                    {
                        byte[] imageData = (byte[])drArr[0]["productImage"];
                        MemoryStream ms = new MemoryStream(imageData);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.ImageLocation = filePath;
                    //ImageLocation 속성은 로컬경로, http, url경로로부터 이미지를 보여주게 됨
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lblProductID.Text.Trim().Length < 1 || txtProductName.Text.Trim().Length < 1)
            {
                MessageBox.Show("이미지 삭제를 할 제품을 선택하세요");
                return;
            }
            if (listBox1.SelectedItems.Count < 1)
            {
                MessageBox.Show("삭제할 이미지를 선택하세요.");
                return;
            }

            pictureBox1.Image = null;

            //제품명, 이미지 경로를 이용해서 삭제한다.
            int pid = int.Parse(lblProductID.Text);
            string path = listBox1.SelectedItems[0].ToString();
            ProductDB db = new ProductDB();
            bool bResult = db.DelProductImamge(pid, path);
            if (bResult)
            {
                MessageBox.Show("성공적으로 이미지가 삭제되었습니다.");
            }
            else
            {
                MessageBox.Show("이미지를 삭제하는 중에 오류가 발생했습니다. 다시 시도하여 주십시오.");
            }
        }
    }
}
