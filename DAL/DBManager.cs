namespace DAL;
using BOL;

using MySql.Data.MySqlClient;
public class DBManager{
    public static string conString =@"server=192.168.10.150;port=3306;user=dac29;password=welcome;database=dac29";

    public static List<Student> getAllStudents(){
        List<Student> allStudents=new List<Student>();

        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=conString;

        try{
            conn.Open();

            MySqlCommand cmd=new MySqlCommand();
            cmd.Connection=conn;

            string query="select * from student";
            cmd.CommandText=query;
            MySqlDataReader reader=cmd.ExecuteReader();

            while(reader.Read()){
                int id=int.Parse(reader["Id"].ToString());
                string name=reader["namefirst"].ToString();
                string Lname=reader["namelast"].ToString();


                Student st=new Student{
                    id=id,
                    fname=name,
                    lname=Lname
                    
                };

                allStudents.Add(st);
            }
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            conn.Close();
        }

        return allStudents;
    }
}

