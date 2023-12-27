namespace BLL;

using BOL;
using DAL;


public class studentManager{
    public List<Student> getStudent(){

        List<Student> allStudent=new List<Student>();

        allStudent=DBManager.getAllStudents();

        return allStudent;
    }
}


