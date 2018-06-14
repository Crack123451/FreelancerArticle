using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace FreelancerArticle
{
    class Wallet
    {
        public static SqlCommand RequestInfoWalletUser(string login, string who)
        {
            SqlCommand command = new SqlCommand
                ("SELECT [№ Кошелька],[Сумма] FROM [Wallets] WHERE [№ Кошелька] = (SELECT [№ Кошелька] FROM [" + who + "] WHERE [Логин]='" + login + "')", User.sqlConnection);
            return command;
        }

        public static SqlCommand UpdateMoneyToDatabase(string sum, string login, string who)
        {
            SqlCommand command = new SqlCommand
                ("UPDATE [Wallets] SET [Сумма]=[Сумма]+" + sum + " WHERE [№ Кошелька] = (SELECT [№ Кошелька] FROM [" + who + "] WHERE [Логин]='" + login + "')", User.sqlConnection);
            return command;
        }

        /*public static SqlCommand RequestWalletAttributes(string attributesDatabase)
        {
            SqlCommand command = new SqlCommand
                ("SELECT [" + attributesDatabase + "] FROM [Wallets]", User.sqlConnection);
            return command;
        }*/

        public static SqlCommand InsertInfoWallet(string wallet, string sum)
        {
            SqlCommand command = new SqlCommand
                ("INSERT INTO [Wallets]([№ Кошелька],[Сумма]) VALUES ('" + wallet + "','" + sum + "')", User.sqlConnection);
            return command;
        }
    }
}
