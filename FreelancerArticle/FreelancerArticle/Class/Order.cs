using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerArticle
{
    class Order
    {
        public static SqlCommand RequestInfoOrder(string order)
        {
            SqlCommand command = new SqlCommand
                ("SELECT [Тема],[Название],[Подробное описание],[Количество символов],[Бюджет] FROM [Order] WHERE [№ Заказа]='" + order + "'", User.sqlConnection);
            return command;
        }

        public static SqlCommand ChechLastNumberOrder()
        {
            SqlCommand command = new SqlCommand
                ("SELECT [№ Заказа] FROM [Order]", User.sqlConnection);
            return command;
        }

        public static SqlCommand DeleteOrder(string numberOrder)
        {
            SqlCommand command = new SqlCommand
                ("DELETE FROM [Order] WHERE [№ Заказа]='" + numberOrder + "'", User.sqlConnection);
            return command;
        }

        public static SqlCommand InsertInfoToDatabaseOrder(string numberOrder, string loginCustomer, string topic, string title, string description, string countSymbol, string money)
        {
            SqlCommand command = new SqlCommand
                ("INSERT INTO [Order]([№ Заказа],[Заказчик],[Тема],[Название],[Подробное описание],[Количество символов],[Бюджет],[Состояние]) " +
                "VALUES ('" + numberOrder + "',N'" + loginCustomer + "',N'" + topic + "',N'" + title + "',N'" + description + "','" + countSymbol + "','" + money + "',N'Нет фрилансера')", User.sqlConnection);
            return command;
        }
    }
}
