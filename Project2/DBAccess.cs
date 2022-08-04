using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class DBAccess
    {
        // DB 정보
        string server = "127.0.0.1";
        string port = "3306";
        string username = "root";
        string password = "1234";
        string database = "userdb";
        string table = "user3";

        // 싱글톤
        private static DBAccess instrance = new DBAccess();
        public static DBAccess Instance { get { return instrance; } }
        public DBAccess() { }

        private MySqlConnection Connect()
        {
            //DB 접속 커넥션 생성
            string strConn = $"server={server};port={port};username={username};password={password};database={database};";
            MySqlConnection conn = new MySqlConnection(strConn);
            return conn;
        }


        public void InsertUser(string uid, string name, string hp, string age) 
        { 
       
            MySqlConnection conn = Connect();

            try
            {
                // DB 접속
                conn.Open();

                // SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * INTO {table} VALUES('{uid}','{name}','{hp}','{age}')";
                cmd.ExecuteNonQuery();


            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                // DB 종료
                conn.Close();

            }
           

        }
        public void selectUser() { }
     
        public List<User> SelectUsers() 
        {

            List<User> userList = new List<User>();
         
            MySqlConnection conn = Connect();
            try
            {
                // DB 접속
                conn.Open();

                // SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM {table}";
                MySqlDataReader reader = cmd.ExecuteReader();

                // 결과처리
                while (reader.Read())
                {
                    User user = new User();
                    user.Uid = reader[0].ToString();
                    user.Name = reader[1].ToString();
                    user.Hp = reader[2].ToString();
                    user.Age = int.Parse(reader[3].ToString());

                    userList.Add(user);

                }
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                // DB 종료
                conn.Close();
            }


            return userList;


        }
        public void UpdateUser(string uid, string name, string hp, string age) 
        {
            MySqlConnection conn = Connect();
            try
            {
                // DB 접속
                conn.Open();

                // SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"UPDATE {table} SET `name` = '{name}', `hp`='{hp}', `age`='{age}' WHERE `uid` = '{uid}' ";
                MySqlDataReader reader = cmd.ExecuteReader();

                
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                // DB 종료
                conn.Close();
            }

        }

        public void DeleteUser() { }

    }
}
