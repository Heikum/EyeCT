using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents.DAL
{
    public interface IAccountContext
    {
        List<Student> GetAllStudents();

        List<Admin> GetAllAdmins();

        Student GetStudentByUsername(string Username);

        Admin GetAdminByUsername(string Username);
    }
}
