using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProject
{
    public partial class FormDichVu : Form
    {
        public static List<DVLIst> dVLists = new List<DVLIst>();
        public static DataGridView dgv;
        public int selection;
        public FormDichVu()
        {
            InitializeComponent();
            dgv = dataGridView1;
            tbSoPhieu.Select();
            tbSoPhieu.Focus();
            BtnAdd.Enabled = false;
            //BtnEdit.Enabled = false;
            //BtnDelete.Enabled = false;
        }

       public void LoadData()
        {
            using(DB_QLKDEntities db=new DB_QLKDEntities())
            {
                int maPDV = Convert.ToInt32(tbSoPhieu.Text);
                var result = from ctpdv in db.CT_PDV
                             join pdv in db.PHIEUDVs on ctpdv.MaPDV equals pdv.MaPDV
                             join dv in db.DICHVUs on ctpdv.MaDV equals dv.MaDV
                             where ctpdv.MaPDV==maPDV
                             select new PhieuDichVu
                             {
                                 Loại_Dịch_Vụ = dv.LoaiDV,
                                 Đơn_Giá_Dịch_Vụ = ctpdv.DonGiaDV.Value,
                                 Đơn_Giá_Được_Tính = ctpdv.DonGiaDuocTinh.Value,
                                 Số_Lượng=ctpdv.SoLuongDV.Value,
                                 Thành_Tiền=ctpdv.ThanhTien.Value,
                                 Trả_Trước=ctpdv.TraTruoc.Value,
                                 Còn_Lại=ctpdv.ConLai.Value,
                                 Ngày_Giao=ctpdv.NgayGiao.Value,
                                 Tình_Trạng=ctpdv.TinhTrang,
                             };

                var tongTien = from c in db.PHIEUDVs
                               where c.MaPDV == maPDV
                               select c.TongTien;
                var tongTienTraTruoc = from c in db.PHIEUDVs
                                       where c.MaPDV == maPDV
                                       select c.TongTienTraTruoc;
                var tongTienConLai = from c in db.PHIEUDVs
                                     where c.MaPDV == maPDV
                                     select c.TongTienConLai;
                tbTongTien.Text = tongTien.First().ToString();
                tbTongTraTruoc.Text = tongTienTraTruoc.First().ToString();
                tbTongConLai.Text = tongTienConLai.First().ToString();

                dgv.DataSource = result.ToList();
            }
        }
        //Xử lí dgv
        private bool IsEmptyCell(DataGridViewRow row)
        {
            for (int i = 0; i < row.Cells.Count; i++)
            {
                if (row.Cells[i].Value == null
                    || row.Cells[i].Value == DBNull.Value
                    || String.IsNullOrWhiteSpace(row.Cells[i].Value.ToString()))
                    return true;
            }
            return false;
        }
        private bool IsTBValid()
        {
            if (!(string.IsNullOrEmpty(TBTraTruoc.Text)) &&
                (CBLoaiDV.SelectedIndex != -1) &&
                (!(string.IsNullOrEmpty(TBSoLuong.Text))))
                return true;
            else return false;
        }
        private void BtnAdd_Visible()
        {
            if (IsTBValid())
                BtnAdd.Enabled = true;
            else BtnAdd.Enabled = false;
        }
        private void ResetInputBH()
        {
            CBLoaiDV.SelectedIndex = -1;
            TBTraTruoc.Text = "";
            TBSoLuong.Text = "";
        }
       
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using(DB_QLKDEntities db=new DB_QLKDEntities())
            {
                int maPDV = Convert.ToInt32(tbSoPhieu.Text);
                string tenKH = tbKhachHang.Text;
                int sdt = Convert.ToInt32(tbSoDienThoai.Text);
                DateTime ngayLapPhieu = dtNgayLapPhieu.Value;
                DateTime ngayGiao = dtNgayGiao.Value;
                int soLuong = Convert.ToInt32(TBSoLuong.Text);
                long traTruoc = Convert.ToInt64(TBTraTruoc.Text);
                int maDV = Convert.ToInt32((from c in db.DICHVUs
                                            where c.LoaiDV == CBLoaiDV.Text
                                            select c.MaDV).First().ToString());
                long donGia= Convert.ToInt64((from c in db.DICHVUs
                                            where c.LoaiDV == CBLoaiDV.Text
                                            select c.DonGiaDV).First().ToString());
                long thanhTien = donGia * soLuong;
                long conLai = (thanhTien - traTruoc) < 0 ? 0 : (thanhTien - traTruoc);
                DB_QLKD.Add_CTPhieuDichVu(maPDV, maDV, soLuong, donGia, thanhTien, traTruoc, conLai, ngayGiao, ngayLapPhieu, tenKH, sdt);
                LoadData();
                MessageBox.Show("Thêm thành công!", "Thông Báo");
                ResetInputBH();
            }
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (DB_QLKDEntities db = new DB_QLKDEntities())
            {
                if (tbSoPhieu.Text=="" || dgv.RowCount==0)
                    MessageBox.Show("Bạn vẫn chưa điền thông tin!");
                else
                {
                    int maPDV = Convert.ToInt32(tbSoPhieu.Text);
                    string loaiDV = dgv.SelectedCells[0].OwningRow.Cells["Loại_Dịch_Vụ"].Value.ToString();
                    int maDV = Convert.ToInt32((from c in db.DICHVUs
                                                where c.LoaiDV == loaiDV
                                                select c.MaDV).First().ToString());
                    DB_QLKD.Delete_CTPDV(maPDV, maDV);
                    LoadData();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                    ResetInputBH();
                }
            }
                
        }


        private void TBTraTruoc_TextChanged(object sender, EventArgs e)
        {
            BtnAdd_Visible();
        }

        private void CBLoaiDV_DropDown(object sender, EventArgs e)
        {
            using(DB_QLKDEntities db=new DB_QLKDEntities())
            {
                var loaiSP = from c in db.DICHVUs
                             select c.LoaiDV;
                CBLoaiDV.DataSource = loaiSP.ToList();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if(tbSoPhieu.Text=="")
            {
                 MessageBox.Show("Bạn chưa nhập mã phiếu!", "Thông Báo");
            }
            else
            {
                LoadData();
            }
        }

        

        private void TBSoLuong_TextChanged(object sender, EventArgs e)
        {
            BtnAdd_Visible();
        }

  
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            using (DB_QLKDEntities db=new DB_QLKDEntities())
            {
                int maPDV = Convert.ToInt32(tbSoPhieu.Text);
                string loaiDV = dgv.SelectedCells[0].OwningRow.Cells["Loại_Dịch_Vụ"].Value.ToString();
                long donGiaDV = Convert.ToInt64(dgv.SelectedCells[0].OwningRow.Cells["Đơn_Giá_Dịch_Vụ"].Value.ToString());
                int donGiaTinh = Convert.ToInt32(dgv.SelectedCells[0].OwningRow.Cells["Đơn_Giá_Được_Tính"].Value.ToString());
                int soLuong = Convert.ToInt32(dgv.SelectedCells[0].OwningRow.Cells["Số_Lượng"].Value.ToString());
                long thanhTien = Convert.ToInt64(dgv.SelectedCells[0].OwningRow.Cells["Thành_Tiền"].Value.ToString());
                long traTruoc = Convert.ToInt64(dgv.SelectedCells[0].OwningRow.Cells["Trả_Trước"].Value.ToString());
                long conLai = Convert.ToInt64(dgv.SelectedCells[0].OwningRow.Cells["Còn_Lại"].Value.ToString());
                string tinhTrang = dgv.SelectedCells[0].OwningRow.Cells["Tình_Trạng"].Value.ToString();
                DateTime ngayGiao = Convert.ToDateTime(dgv.SelectedCells[0].OwningRow.Cells["Ngày_Giao"].Value.ToString());
                int maDV = Convert.ToInt32((from c in db.DICHVUs
                                            where c.LoaiDV == loaiDV
                                            select c.MaDV).First().ToString());
                DB_QLKD.Edit_CTPDV(maPDV, maDV, soLuong, traTruoc, ngayGiao, tinhTrang);
                LoadData();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
                ResetInputBH();
            }



            
        }
    }
}