using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom6_QuanLyThuVien
{
    internal class Ketnoi
    {
        SqlConnection conn;
        string kn = @"Server=LAPTOP-TKDRUJMP;Database=qLyThuVien;Integrated Security=True";
        public void ketnoi()
        {
            conn = new SqlConnection(kn);
            conn.Open();
        }
        public void dongkn()
        {
            conn.Close();
        }

        //CRUD
        public DataTable Readdata(string sql, SqlParameter[] sqlParameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                ketnoi();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (sqlParameters != null)
                    {
                        cmd.Parameters.AddRange(sqlParameters);
                    }
                    using (SqlDataReader sr = cmd.ExecuteReader())
                    {
                        dt.Load(sr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dongkn();
            }
            return dt;
        }

        public void CUD(string table, SqlParameter[] sqlParameters = null)
        {
            try
            {
                ketnoi();
                using (SqlCommand cmd = new SqlCommand(table, conn))
                {
                    if (sqlParameters != null)
                    {
                        cmd.Parameters.AddRange(sqlParameters);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dongkn();
            }
        }
        public string TongTien()
        {
            string tongtien = "0"; // Mặc định là 0 nếu không có kết quả
            string sql = "SELECT Sum(ThanhTien) FROM MuonTra WHERE TinhTrang = N'Đã trả';";

            using (SqlConnection conn = new SqlConnection(kn))
            {
                try
                {
                    conn.Open(); // Mở kết nối CSDL

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Thực thi câu lệnh SQL và nhận giá trị duy nhất từ câu truy vấn
                        object result = cmd.ExecuteScalar();

                        // Kiểm tra nếu kết quả không rỗng và không phải là NULL
                        if (result != null && result != DBNull.Value)
                        {
                            tongtien = result.ToString(); // Chuyển đổi kết quả thành chuỗi
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi (có thể log hoặc hiển thị thông báo)
                    Console.WriteLine("Lỗi khi lấy tổng tiền: " + ex.Message);
                }
            }

            return tongtien; // Trả về tổng tiền dưới dạng chuỗi
        }
    }
}

