using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents.DAL
{
    public interface IAccountContext
    {
        List<Account> GetAllAccounts();

        List<Account> GetAllStudents();

        List<Account> GetAllAdmins();

        Account InsertStudent(Student student);

        Account InsertAdmin(Admin admin);

        bool DeleteAccount(int id);

        bool UpdateAccount(Account account);

        List<Account> GetAllAccountInformation();
    }
}
