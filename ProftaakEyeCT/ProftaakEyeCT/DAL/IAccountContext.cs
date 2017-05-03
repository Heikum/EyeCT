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

        Account InsertAccount(Account account, Person person);

        bool Login(string gebruikersnaam, string wachtwoord);

        Account GetAccountRights(string username); 

        bool DeleteAccount(int id);

        int GetID();

        int GetAccountIDByUsername(string gebruikersnaam);

        bool UpdateAccount(Account account);

        List<Account> GetAllAccountInformation();
        Account GetAccountByUsername(string username);

        string GetTelNr(string username);
    }
}
