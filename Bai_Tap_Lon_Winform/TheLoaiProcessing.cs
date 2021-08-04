﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Bai_Tap_Lon_Winform
    
{
    class TheLoaiProcessing
    {
        DBConnection db = new DBConnection();

        public DataTable loadDL()
        {
            String sql = "Select *from TheLoai";
            DataTable dt = new DataTable();
            dt = db.getTable(sql);
            return dt;
        }
        public void addTheLoai(String maTL,String tenTL)
        {
            try
            {

                string sql = "Insert Into TheLoai Values('" + maTL + "',N'" + tenTL+ "')";
                db.getExecuteNonQuery(sql);
                MessageBox.Show("Mã Thể Loại " + maTL + " Được thêm Vào Hệ Thống", "Thêm TL Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void editTheLoai(String maTL,String tenTL)
        {
            try
            {

                String sql = "Update  TheLoai Set TenTL=N'" + tenTL + "' where MaTL='" + maTL + "'";
                db.getExecuteNonQuery(sql);
                MessageBox.Show("Cập Nhật Thành Công Thể Loại  ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void xoaTheLoai(String maTL)
        {
            try
            {
                
               String sql = "Delete from TheLoai where MaTL='" + maTL + "'";
                db.getExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Khi Xóa Thể Loại" + maTL);

            }
        }
        public DataTable timTheLoai(String maTL,DataGridView dgr)
        {
            DataTable dt = new DataTable();
            try
            {
               
                String sql = "Select * from TheLoai Where MaTL='" + maTL + "'";
                db.getExecuteNonQuery(sql);
                 dt= db.getTable(sql);
                if (dt.Rows.Count == 1)
                {
                    dgr.DataSource = dt;
                }
                else { MessageBox.Show("Không Tìm Thấy Dữ Liệu. Vui Lòng kiểm tra lại !");
                }
                return dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return dt;
            }
           
        }
    }
}