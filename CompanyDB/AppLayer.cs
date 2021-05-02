using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDB
{
    class AppLayer
    {


        Controller controller;
        private static AppLayer appPlayerObj;

        public static AppLayer getObject()
        {
            if (appPlayerObj == null)
                appPlayerObj = new AppLayer();
            return appPlayerObj;

        }
        private AppLayer()
        {
            controller = Controller.getObject();

        }

        public int insertNewEmployee(string ssn, string name, string birthDate, string sex, string salary, string superSsn, string Dno)
        {

            if (string.IsNullOrEmpty(name))
                name = "NULL";
            if (string.IsNullOrEmpty(birthDate))
                birthDate = "NULL";
            if (string.IsNullOrEmpty(sex))
                sex = "NULL";
            if (string.IsNullOrEmpty(salary))
                salary = "NULL";
            if (string.IsNullOrEmpty(superSsn))
                superSsn = "NULL";
            if (string.IsNullOrEmpty(Dno))
                Dno = "NULL";
            return controller.insertNewEmployee(ssn, name, birthDate, sex, salary, superSsn, Dno);

        }

        public int updateNewEmployee(string ssn, string name, string birthDate, string sex, string salary, string superSsn, string Dno, string originalSSN)
        {

            if (string.IsNullOrEmpty(name))
                name = "NULL";
            if (string.IsNullOrEmpty(birthDate))
                birthDate = "NULL";
            if (string.IsNullOrEmpty(sex))
                sex = "NULL";
            if (string.IsNullOrEmpty(salary))
                salary = "NULL";
            if (string.IsNullOrEmpty(superSsn))
                superSsn = "NULL";
            if (string.IsNullOrEmpty(Dno))
                Dno = "NULL";
            return controller.updateEmployee(ssn, name, birthDate, sex, salary, superSsn, Dno, originalSSN);

        }

        public DataTable selectAllEmployeesInDept(string dept)
        {
            if (dept == "All")
                return controller.selectAllEmployees();
            else
                return controller.selectAllEmployeesInDept(dept);
        }

        public PRIVILIAGE CheckPassword_Basic(string userName, string pass)
        {
            return controller.CheckPassword_Basic(userName, pass);
        }

        public DataTable selectAllDepartmentNumsName()
        {
            return controller.selectAllDepartmentNumsName();
        }

        public bool isProjNumExist(string projNum)
        {
            int num = controller.getProjWithNumber(projNum);
            return num > 0 ? true : false;

        }

        public int insertProject(string Pname, string Pnumber, string Plocation, string Dnum)
        {
            if (string.IsNullOrEmpty(Pname))
                Pname = "NULL";
            if (string.IsNullOrEmpty(Plocation))
                Plocation = "NULL";
            if (string.IsNullOrEmpty(Dnum))
                Dnum = "NULL";
            return controller.insertProject(Pname, Pnumber, Plocation, Dnum);
        }

        public DataTable selectAllDeptLocations()
        {
            return controller.selectAllDeptLocations();
        }
        
        public DataTable selectProjects(string location)
        {
            return controller.selectProjects(location);
        }
    }
}
