﻿using MySqlConnector;
using QLNVSSV.DATA.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace QLNVSSV.DATA.Database
{
    public class DatabaseContext<T> : IDisposable, IDatabaseContext<T>
    {
        protected readonly string _connectionString = "server=127.0.0.1;user id=root;password=anhphong1;port=3306;database=qlnv;";
        MySqlConnection _sqlConnection;
        MySqlCommand _sqlCommand;

        public DatabaseContext()
        {
            _sqlConnection = new MySqlConnection(_connectionString);

            _sqlConnection.Open();
            _sqlCommand = _sqlConnection.CreateCommand();
            _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
        }

        public bool CheckDuplicate(T entity, PropertyInfo property, bool isAddNew)
        {
            throw new NotImplementedException();
        }

        public int DeleteById(object id)
        {
            //lay ten class
            var entityName = typeof(T).Name;

            _sqlCommand.Parameters.Clear();

            //dinh nghia cac proc theo format
            _sqlCommand.CommandText= $"Proc_Delete{entityName}ById";
            _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlCommand.Parameters.AddWithValue("id", id);

            if (_sqlConnection.State == System.Data.ConnectionState.Closed)
                _sqlConnection.Open();
            /*
            if (_sqlCommand.Parameters.Count > 0)
            {
                _sqlCommand.Parameters[0].Value = id;
            }
            */
            var affectRows = _sqlCommand.ExecuteNonQuery();
            return affectRows;
        }

        public void Dispose()
        {
            _sqlConnection.Dispose();
        }


        //get all
       
        public IEnumerable<T> Get()
        {
            var listInstance = new List<T>();
            var entityName = typeof(T).Name;
            _sqlCommand.CommandText= $"Proc_Get{entityName}";
            _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            if (_sqlConnection.State == System.Data.ConnectionState.Closed)
                _sqlConnection.Open();



            MySqlDataReader mySqlDataReader = _sqlCommand.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                var instance = Activator.CreateInstance<T>();
                for(int i = 0; i < mySqlDataReader.FieldCount; i++)
                {
                    var columnName = mySqlDataReader.GetName(i);
                    var value = mySqlDataReader.GetValue(i);
                    var propertyInfo = instance.GetType().GetProperty(columnName);
                    if (propertyInfo != null && value != DBNull.Value)
                    {
                        if (propertyInfo.PropertyType == typeof(Boolean))
                            propertyInfo.SetValue(instance, Convert.ToBoolean(value));
                        else
                            propertyInfo.SetValue(instance, value);
                    }
                }
                listInstance.Add(instance);
            }
            return listInstance;
        }
        //lay data theo proceduce truyen vao
        public IEnumerable<T> Get(string storeName)
        {
            throw new NotImplementedException();
        }

        public object Get(string storeName, string code)
        {
            throw new NotImplementedException();
        }

        public T GetById(object id)
        {
            var className = typeof(T).Name;
            _sqlCommand.CommandText = $"Proc_Get{className}ById";
            _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            if (_sqlConnection.State == System.Data.ConnectionState.Closed)
                _sqlConnection.Open();

            _sqlCommand.Parameters.AddWithValue($"@{className}Id", id);


            MySqlDataReader mySqlDataReader = _sqlCommand.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                var instance = Activator.CreateInstance<T>();
                
                //lay thuoc tinh cua bang
                for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                {
                    var columnName = mySqlDataReader.GetName(i);
                    var value = mySqlDataReader.GetValue(i);

                    //get thuoc tinh cua object
                    var propertyInfo = instance.GetType().GetProperty(columnName);


                    if (propertyInfo != null && value != DBNull.Value)
                    {
                        if (propertyInfo.PropertyType == typeof(Boolean))
                            propertyInfo.SetValue(instance, Convert.ToBoolean(value));
                        else
                            propertyInfo.SetValue(instance, value);
                    }
                }
                return instance;
            }
            return default;
        }

        public int GetCountRecord()
        {
            var totalRecord = 0;
            var entityName = typeof(T).Name;
            _sqlCommand.CommandText = $"select count(*) from {entityName}";
            _sqlCommand.CommandType = System.Data.CommandType.Text;

            MySqlDataReader mySqlDataReader = _sqlCommand.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                totalRecord = Convert.ToInt32(mySqlDataReader["count(*)"]);
            }
            return totalRecord;
        }

        public int Insert(T entity)
        {

            var entityName = typeof(T).Name;
            _sqlCommand.Parameters.Clear();
            _sqlCommand.CommandText= $"Proc_Insert{entityName}";
            _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            if (_sqlConnection.State == System.Data.ConnectionState.Closed)
                _sqlConnection.Open();

            MySqlCommandBuilder.DeriveParameters(_sqlCommand);
            // lay ra parametter cua command

            var parameters = _sqlCommand.Parameters;

            //lay tat ca cac property cua object
            var properties = typeof(T).GetProperties();

            foreach(var property in properties)
            {
                //get key va value cua object post len
                var propertyName = property.Name;
                var propertyValue = property.GetValue(entity);
                foreach (MySqlParameter param in parameters)
                {
                    var paramName = param.ParameterName;
                    if (paramName == $"@{propertyName}")
                        param.Value = propertyValue;
                }

            }


            var affectRows = _sqlCommand.ExecuteNonQuery();
            return affectRows;
        }

        public int Update(T entity)
        {
            var entityName = typeof(T).Name;
            _sqlCommand.Parameters.Clear();
            _sqlCommand.CommandText= $"Proc_Update{entityName}";
            _sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            if (_sqlConnection.State == System.Data.ConnectionState.Closed)
                _sqlConnection.Open();

            MySqlCommandBuilder.DeriveParameters(_sqlCommand);
            var parameters = _sqlCommand.Parameters;

            //lay tat ca cac property cua object
            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                //get key va value cua object post len
                var propertyName = property.Name;
                var propertyValue = property.GetValue(entity);
                foreach (MySqlParameter param in parameters)
                {
                    var paramName = param.ParameterName;
                    if (paramName == $"@{propertyName}")
                        param.Value = propertyValue;
                }

            }

            var affectRows = _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
            return affectRows;
        }
    }
}