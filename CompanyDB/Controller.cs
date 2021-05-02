using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyDB
{
    public enum PRIVILIAGE { FULL_ACCESS, VIEW_ONLY, NONE };


    class Controller
    {
        DBManager dbMan;

        static Controller controller;
        public static Controller getObject()
        {
            if (controller == null)
                controller = new Controller();
            return controller;
        }
        private Controller()
        {
            dbMan = new DBManager();
        }

        public int insertNewEmployee(string ssn, string name, string birthDate, string sex, string salary, string superSsn, string Dno)
        {
            string query = "insert into Employee (SSN,name,Bdate,Sex,Salary,Super_SSN,Dno) " +
                "values ( " + ssn + ",'" + name + "','" + birthDate + "','" + sex + "'," + salary + "," + superSsn + "," + Dno
                + ");";

            return dbMan.ExecuteNonQuery(query);

        }

        public int updateEmployee(string ssn, string name, string birthDate, string sex, string salary, string superSsn, string Dno, string originalSSN)
        {
            string query = "update Employee " +
                "set SSN = "+ssn+" ,name = '" + name + "', Bdate = '" + birthDate + "', Sex = '" + sex + "', Salary = " + salary + ", Super_SSN = " + superSsn + ", Dno = " + Dno + " WHERE SSN = "+ originalSSN + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable selectAllEmployeesSsnName()
        {

            string query = "SELECT SSN, name FROM Employee";
            return dbMan.ExcuteReader(query);
        }

        public DataTable selectAllEmployees()
        {
            string query= "SELECT E.SSN,E.name AS Name,E.Bdate AS 'Birth date',E.Sex, E.Salary,SE.name AS 'Supervisor',D.Dname AS 'Department name' " +
                "From((Employee AS E LEFT JOIN Employee SE ON E.Super_SSN = SE.SSN) LEFT JOIN Department AS D ON E.Dno = D.Dnumber)";
            return dbMan.ExcuteReader(query);
        }
        
        public DataTable selectAllEmployeesInDept(string dept)
        {
            string query= "SELECT E.SSN, E.name AS Name,E.Bdate AS 'Birth date',E.Sex, E.Salary,SE.name AS 'Supervisor',D.Dname AS 'Department name'" +
                " From((Employee AS E LEFT JOIN Employee SE ON E.Super_SSN = SE.SSN) JOIN Department AS D ON E.Dno = D.Dnumber AND D.Dname = '"+dept+"' )";
            return dbMan.ExcuteReader(query);
        }

        public bool isSSNExist(string ssn)
        {
            string query = "SELECT COUNT(*) FROM Employee WHERE SSN =" + ssn + ";";
            int dt = (int) dbMan.ExcuteScalar(query);
            if (dt != 0)
                return true;
            return false;
        }

        public DataTable selectEmpAtSSN(string ssn)
        {
            string query = " SELECT * FROM Employee WHERE SSN = " + ssn+";";
            return dbMan.ExcuteReader(query);
        }

        public int getNumberInProject(string projName)
        {
            string query = "SELECT COUNT(E.name) FROM Employee AS E,Works_On AS W, Project AS j WHERE W.Essn=E.SSN AND W.Pno=j.Pnumber AND j.Pname='"+ projName + "';";
            return (int)dbMan.ExcuteScalar(query);
        }

        
        
        public DataTable selectAllDepartmentNumsName()
        {

            string query = "SELECT Dname, Dnumber FROM Department";
            return dbMan.ExcuteReader(query);
        }
        public DataTable selectAllDepartmentNames()
        {

            string query = "SELECT Dname FROM Department";
            return dbMan.ExcuteReader(query);
        }


        public bool isDeptNumExist(string department_num)
        {
            string query = "SELECT COUNT(*) FROM Department WHERE Dnumber =" + department_num + ";";
            int dt = (int)dbMan.ExcuteScalar(query);
            if (dt != 0)
                return true;
            return false;
        }


        public int getProjWithNumber(string projecNum)
        {
            string query = "SELECT COUNT(*) FROM Project WHERE Pnumber = " + projecNum + ";";
            return (int)dbMan.ExcuteScalar(query);
        }

        public int getAllWorkingOnProject(string proNum)
        {
            string query = "SELECT COUNT(Essn) FROM Works_On WHERE Pno = " + proNum;
            return (int)dbMan.ExcuteScalar(query);
        }

        public int deleteProject(string projNum)
        {
            string query = "DELETE FROM Project where Pnumber =  " + projNum;
            return dbMan.ExecuteNonQuery(query);

        }



        /// //////////////////////////////////////////////project
        public int insertProject(string Pname, string Pnumber, string Plocation, string Dnum)
        {
            string query = "INSERT INTO Project (Pname,Pnumber,Plocation,Dnum) VALUES ( '" + Pname + "'," + Pnumber + ",'" + Plocation + "' , " + Dnum + " );";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable selectProjects(string location)
        {
            string query = "SELECT Pname,Dname" +
                " FROM Department AS D,Project AS P, Dept_Locations AS L " +
                "WHERE L.Dlocation='"+location+"' AND D.Dnumber = L.Dnumber AND P.Dnum=D.Dnumber;";

            return dbMan.ExcuteReader(query);
        }


        ////////////////////////Depatment locations
        
        public DataTable selectAllDeptLocations()
        {
            string query = "SELECT DISTINCT Dlocation FROM Dept_Locations;";
            return dbMan.ExcuteReader(query);
        }



        ////////////////////////LOGIN

        public PRIVILIAGE CheckPassword_Basic(string userName, string pass)
        {
            string query = "SELECT * FROM Users_Basic WHERE username = '" + userName + "' AND password = '" + pass + "';";
            DataTable dt = dbMan.ExcuteReader(query);
            if (dt==null || dt.Rows.Count == 0)
                return PRIVILIAGE.NONE;
            else 
            {
                if (Int32.Parse(dt.Rows[0]["Priv"].ToString()) == 1)
                    return PRIVILIAGE.FULL_ACCESS;
                else 
                    return PRIVILIAGE.VIEW_ONLY;
            }


        }
    }
}
