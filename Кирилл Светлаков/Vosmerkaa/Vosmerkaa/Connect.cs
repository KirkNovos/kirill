using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Vosmerkaa
{
    public class Connect
    {
        public MySqlConnection con;
        public string connectString;
        public MySqlDataAdapter adapter;
        public MySqlDataReader dr;
        MySqlCommand cmd;
        public Connect()
        {
            connectString = "server=127.0.0.1;user=root;password=111111;database=ksvetlakov;sslmode=none";
        }
        public void ConectClose()
        {
            con.Close();
        }
        public DataTable ConDT(string sql)
        {
            con = new MySqlConnection(connectString);
            con.Open(); //открываем БД
            DataTable dt = new DataTable();
            cmd = new MySqlCommand(sql, con);
            try
            {
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
                con.Close(); //закрываем соединение, т.к. оно нам больше не нужно
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public DataSet ConDS(string sql)//загрузка всей таблицы
        {
            DataSet ds = new DataSet();
            try
            {

                con = new MySqlConnection(connectString);
                con.Open();
                adapter = new MySqlDataAdapter(sql, con);
                ds = new DataSet();
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return ds;
        }
        public void SIDU(string sql) //select;insert;update;delit
        {
            con = new MySqlConnection(connectString);
            con.Open();
            MySqlCommand cmd2 = con.CreateCommand();
            try
            {
                cmd2.CommandText = sql;
                cmd2.ExecuteNonQuery();
                con.Close(); //закрываем соединение, т.к. оно нам больше не нужно
                MessageBox.Show("Успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string SEL(string sql) //select;insert;update;delit
        {
            DataTable dt = new DataTable();
            string s = "";
            con = new MySqlConnection(connectString);
            con.Open();
            MySqlCommand cmd2 = con.CreateCommand();
            try
            {
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = sql;
                MySqlDataReader dr1 = cmd2.ExecuteReader();
                while (dr1.Read()) // построчно считываем данные
                {
                    s = dr1.GetValue(0).ToString();
                }
                con.Close(); //закрываем соединение, т.к. оно нам больше не нужно
                             // MessageBox.Show("Успешно");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("s=null:"+ex.Message);
                s = null;
            }
            return s;
        }
    }
}
