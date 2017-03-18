using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomatedTestingSystem.Database.ConnectionStrings;

namespace AutomatedTestingSystem.Database
{
    internal static class Database
    {
        /// <summary>
        /// Получение строк, используя процедуру
        /// </summary>
        /// <param name="procedureName">Имя процедуры</param>
        /// <param name="parameters">Параметры процедуры</param>
        /// <returns></returns>
        internal static DataRowCollection GetRowsUsingProcedure(string procedureName, IEnumerable<SqlParameter> parameters)
        {
            return GetRows(procedureName, CommandType.StoredProcedure, parameters);
        }
        /// <summary>
        /// Получение строк, используя запрос
        /// </summary>
        /// <param name="query">Запрос, с помощью которого нужно получить строки</param>
        /// <param name="parameters">Параметры запроса</param>
        /// <returns></returns>
        internal static DataRowCollection GetRowsUsingQuery(string query, IEnumerable<SqlParameter> parameters)
        {
            return GetRows(query, CommandType.Text, parameters);
        }
        /// <summary>
        /// Получение строк, используя объект <see cref="CommandType"/>
        /// </summary>
        /// <param name="query">Имя запроса</param>
        /// <param name="commandType">Тип команды</param>
        /// <param name="parameters">Параметры запроса</param>
        /// <returns></returns>
        internal static DataRowCollection GetRows(string query, CommandType commandType, IEnumerable<SqlParameter> parameters)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                {
                    dataAdapter.SelectCommand.CommandType = commandType;
                    dataAdapter.SelectCommand.CommandTimeout = 15;

                    if (parameters != null)
                    {
                        parameters.ToList().ForEach(x => dataAdapter.SelectCommand.Parameters.Add(x));
                    }

                    using (DataTable dt = new DataTable())
                    {
                        dataAdapter.Fill(dt);
                        return dt.Rows;
                    }
                }
            }
        }

        /// <summary>
        /// Выполнение запроса в БД
        /// </summary>
        /// <param name="query">Запрос, который необходимо выполнить</param>
        /// <param name="parameters">Коллекция параметров, используемых в запросе</param>
        /// <param name="commandType">Тип запроса</param>
        /// <returns></returns>
        internal static object ExecScalar(string query, IEnumerable<SqlParameter> parameters, CommandType commandType)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = commandType;
                    command.CommandTimeout = 15;

                    if (parameters != null)
                    {
                        parameters.ToList().ForEach(x => command.Parameters.Add(x));
                    }

                    return command.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Получение строки, используя процедуру
        /// </summary>
        /// <param name="procedureName">Имя процедуры</param>
        /// <param name="parameters">Параметры процедуры</param>
        /// <returns></returns>
        internal static DataRow GetRowUsingProcedure(string procedureName, IEnumerable<SqlParameter> parameters)
        {
            var output = GetRowsUsingProcedure(procedureName, parameters);
            if (output.Count == 0)
            {
                throw new IndexOutOfRangeException($"Процедура {procedureName} не вернула ни одной строки");
            }

            return output[0];
        }
        /// <summary>
        /// Получение строки, используя запрос
        /// </summary>
        /// <param name="query">Запрос, с помощью которого нужно получить строку</param>
        /// <param name="parameters">Параметры запроса</param>
        /// <returns></returns>
        internal static DataRow GetRowUsingQuery(string query, IEnumerable<SqlParameter> parameters)
        {
            var output = GetRowsUsingQuery(query, parameters);
            if(output.Count == 0)
            {
                throw new IndexOutOfRangeException($"Запрос {query} не вернул ни одной строки");
            }

            return output[0];
        }
    }
}
