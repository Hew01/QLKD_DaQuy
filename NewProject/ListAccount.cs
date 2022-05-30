using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QuanLy
{
    public class ListAccount
    {
        private static ListAccount instance;
        public static ListAccount Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListAccount();
                return instance;
            }
            set => instance = value;
        }
    }
}

//AI LÀM SQL THÌ LO PHẦN NÀY

 /*     private string sqlAddress;
        private SqlConnection sqlConnect;
        public ListAccount()
        {
            sqlAddress =
                @"";
            sqlConnect = new SqlConnection(sqlAddress);
            sqlConnect.Open();
        }
        public bool IsValidUsername(string username)
        {
            var sqlSelect = new SqlCommand("SELECT * FROM ACCOUNT", sqlConnect);
            var reader = sqlSelect.ExecuteReader();
            while (reader.Read())
            {
                if (reader["STUDENT_ID"].ToString() == username)
                {
                    reader.Close();
                    sqlConnect.Close();
                    return false;
                }
            }
            reader.Close();
            sqlSelect.Dispose();
            return true;
        }
        public bool IsValidAccount(string username, string password)
        {
            var sqlSelect = new SqlCommand("SELECT * FROM ACCOUNT", sqlConnect);
            var reader = sqlSelect.ExecuteReader();
            while (reader.Read())
            {
                if ((reader["STUDENT_ID"].ToString() == username) && (HashPass.Instance.VerifyHash(password, reader["PASS"].ToString())))
                {
                    reader.Close();
                    return true;
                }
            }
            reader.Close();
            sqlSelect.Dispose();
            return false;
        }
        public void SqlInsertInto(string username, string password)
        {
            var sqlInsert = new SqlCommand("INSERT INTO ACCOUNT values (@STUDENT_ID, @PASS)", sqlConnect);
            sqlInsert.Parameters.Add("@STUDENT_ID", SqlDbType.NVarChar);
            sqlInsert.Parameters["@STUDENT_ID"].Value = username;
            sqlInsert.Parameters.Add("@PASS", SqlDbType.NVarChar);
            sqlInsert.Parameters["@PASS"].Value = password;
            sqlInsert.ExecuteNonQuery();
            sqlInsert.Dispose();
        }
        public DataTable GetSubjects(string CurrentUser, ref DataGridView data)
        {
            var sqlGetSub = new SqlCommand("SELECT COURSE_NAME AS 'Tên môn học', LECTURER_NAME AS 'Giáo viên phụ trách' "
                        + "FROM COURSE, ACCOUNT "
                        + "WHERE COURSE.STUDENT_ID=ACCOUNT.STUDENT_ID AND "
                        + "COURSE.STUDENT_ID = '" + CurrentUser + "' ", sqlConnect);
            var reader = sqlGetSub.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            data.DataSource = dt;
            data.Columns[0].Width = 300;
            data.Columns[1].Width = 300;
            data.Update();
            data.Refresh();
            reader.Close();
            sqlGetSub.Dispose();
            return dt;
        }
        public void InsertSubjects(string subjects, string teachers, string username)
        {
            var sqlInsSub = new SqlCommand("INSERT INTO COURSE VALUES (@COURSE_NAME, @STUDENT_ID, @LECTURER_NAME)", sqlConnect);
            sqlInsSub.Parameters.Add("@COURSE_NAME", SqlDbType.NVarChar);
            sqlInsSub.Parameters["@COURSE_NAME"].Value = subjects;
            sqlInsSub.Parameters.Add("@STUDENT_ID", SqlDbType.NVarChar);
            sqlInsSub.Parameters["@STUDENT_ID"].Value = username;
            sqlInsSub.Parameters.Add("@LECTURER_NAME", SqlDbType.NVarChar);
            sqlInsSub.Parameters["@LECTURER_NAME"].Value = teachers;
            sqlInsSub.ExecuteNonQuery();
            sqlInsSub.Dispose();
        }
        public bool IsValidSubject(string subjects, string username)
        {
            var SqlCompSub = new SqlCommand($"SELECT * FROM COURSE WHERE STUDENT_ID='{username}'", sqlConnect);
            var reader = SqlCompSub.ExecuteReader();
            while (reader.Read())
            {
                if (reader["COURSE_NAME"].ToString() == subjects)
                {
                    reader.Close();
                    return false;
                }
            }
            reader.Close();
            SqlCompSub.Dispose();
            return true;
        }
    }

}
*/