using System;
using System.Configuration;
using System.Data;
using System.Reflection;
using System.Text;
using ST.Exceptions;
using ST.Model;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace ST.Utils
{
	/// <summary>
	/// Summary description for DBUtils.
	/// </summary>
	public class DBUtils
	{
		public DBUtils()
		{
		}

		public static string strConnectDB(string pServer, string pDatabase, string pUsername, string pPassword)
		{
			try
			{
				StringBuilder strConnectDB = new StringBuilder();
				strConnectDB.Append("Server=" + pServer + ";");
				strConnectDB.Append("database=" + pDatabase + ";");				
				strConnectDB.Append("uid=" + pUsername + ";");
				strConnectDB.Append("pwd=" + pPassword + ";");
                strConnectDB.Append("Connection Timeout=600;");
				return strConnectDB.ToString();
			}
			catch
			{
				throw new FacadeException("Can not connect to DB");
			}
		}
        
        public static bool GetInforConnectionString(ref string[] GetInfor, ref string err)
        {
            try
            {
                string[] Infor = new string[4];//0:server,1:Database;2:User,3:Pass

                //string strPath = Application.StartupPath.ToString() + @"\default.ini";
                string strPath = Application.StartupPath.ToString() + @"\" + Global.DefaultFileName;
                FileStream file = new FileStream(strPath, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(file);
                int i = 0;
                while (i < 4)
                {
                    Infor[i] = sr.ReadLine();
                    i = i + 1;
                }
                sr.Close();
                file.Close();
                GetInfor = Infor;
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public static bool GetParamConnectionString(string[] Input, ref string[] Ouput, ref string err)
        {
            try
            {
                for (int i = 0; i < Input.Length; i++)
                {
                    //Ouput[i] = Decrypt(Input[i],
                    //                                passPhrase,
                    //                                saltValue,
                    //                                hashAlgorithm,
                    //                                passwordIterations,
                    //                                initVector,
                    //                                keySize);
                    Ouput[i] = MD5.DecryptPassword(Input[i]);
                }
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        #region MH - GM
        public static string passPhrase = "Pas5pr@se";        // can be any string
        public static string saltValue = "s@1tValue";        // can be any string
        public static string hashAlgorithm = "SHA1";             // can be "MD5"
        public static int passwordIterations = 2;                  // can be any number
        public static string initVector = "@CSS@CSS@CSS@CSS"; // must be 16 bytes
        public static int keySize = 256;
        public static string Encrypt(string plainText,
                                     string passPhrase,
                                     string saltValue,
                                     string hashAlgorithm,
                                     int passwordIterations,
                                     string initVector,
                                     int keySize)
        {
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);

            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            PasswordDeriveBytes password = new PasswordDeriveBytes(
                                                            passPhrase,
                                                            saltValueBytes,
                                                            hashAlgorithm,
                                                            passwordIterations);

            byte[] keyBytes = password.GetBytes(keySize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();

            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(
                                                             keyBytes,
                                                             initVectorBytes);

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                                                         encryptor,
                                                         CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();

            byte[] cipherTextBytes = memoryStream.ToArray();

            memoryStream.Close();
            cryptoStream.Close();
            string cipherText = Convert.ToBase64String(cipherTextBytes);

            return cipherText;
        }


        public static string Decrypt(string cipherText,
                                 string passPhrase,
                                 string saltValue,
                                 string hashAlgorithm,
                                 int passwordIterations,
                                 string initVector,
                                 int keySize)
        {
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);

            // Convert our ciphertext into a byte array.
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);

            PasswordDeriveBytes password = new PasswordDeriveBytes(
                                                            passPhrase,
                                                            saltValueBytes,
                                                            hashAlgorithm,
                                                            passwordIterations);

            byte[] keyBytes = password.GetBytes(keySize / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;

            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(
                                                             keyBytes,
                                                             initVectorBytes);
            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                                                          decryptor,
                                                          CryptoStreamMode.Read);

            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes,
                                                       0,
                                                       plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            string plainText = Encoding.UTF8.GetString(plainTextBytes,
                                                       0,
                                                       decryptedByteCount);

            // Return decrypted string.   
            return plainText;
        }

        #endregion

		public static string GetDBConnectionString()
		{
            try
            {
                if (Global.ConnectionString.Equals(""))
                {
                    //GetNewDBConnectionString(20);
                }
                return Global.ConnectionString;
            }
            catch
            {
                throw new FacadeException("Can not connect to DB");
            }
		}

        public static string GetDBConnectionString(int _timeout)
        {
            try
            {
                if (Global.ConnectionString.Equals(""))
                {
                    //GetNewDBConnectionString(_timeout);
                }
                return Global.ConnectionString;
            }
            catch
            {
                throw new FacadeException("Can not connect to DB");
            }
        }
        public static void GetNewDBConnectionString(int timeout)
        {
            try
            {
                string[] InputInfor = new string[4];
                string[] OutputInfor = new string[4];
                string err = "";
                GetInforConnectionString(ref InputInfor, ref err);
                GetParamConnectionString(InputInfor, ref OutputInfor, ref err);
                string pServerName = OutputInfor[0];
                string pDatabaseName = OutputInfor[1];
                string pUsername = OutputInfor[2];
                string pPassword = OutputInfor[3];
                StringBuilder connectionString = new StringBuilder();
                connectionString.Append("Server=" + pServerName + ";");
                connectionString.Append("database=" + pDatabaseName + ";");
                connectionString.Append("uid=" + pUsername + ";");
                connectionString.Append("pwd= " + pPassword + ";");

                connectionString.Append("Connection Timeout= " + timeout + ";");

                //Global.ConnectionString = connectionString.ToString();
            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới Database");
            }
        }

        public static string GetDBConnectionStringNotSave(int timeout)
        {
            try
            {
                if (String.IsNullOrEmpty(Global.ConnectionString))
                {
                    //Global.ConnectionString = GetDBConnectionString();
                }
                int _SubStr = Global.ConnectionString.LastIndexOf('=') + 1;
                return Global.ConnectionString.Substring(0, _SubStr) + timeout + ";";
            }
            catch
            {
                throw new FacadeException("Can not connect to DB");
            }
        }

		public static string GetReportConnectionString()
		{
			string pServerName="";
			string pDatabaseName="";
			string pUsername = "";
			string pPassword = "";

            //string strPath = Application.StartupPath.ToString()+ @"\default.ini";
            string strPath = Application.StartupPath.ToString() + @"\" +Global.DefaultFileName;
			FileStream file = new FileStream(strPath, FileMode.OpenOrCreate, FileAccess.Read);
			StreamReader sr = new StreamReader(file);
			int i=0;
			while (i<4)  
			{
				if (i ==0)
					pServerName = sr.ReadLine();
				if (i==1)
					pDatabaseName = sr.ReadLine();
				if (i==2)
					pUsername = sr.ReadLine();
				if (i==3)
					pPassword = sr.ReadLine();
				i= i+1;
			}
			sr.Close();
			file.Close();
			try
			{
				StringBuilder connectionString = new StringBuilder();
				connectionString.Append("Provider=SQLOLEDB.1;");
		  		connectionString.Append("Server="+pServerName.Trim()+";");
				connectionString.Append("database="+pDatabaseName.Trim()+";");
				
                //connectionString.Append("uid=sa;");
                //connectionString.Append("pwd=;");

                connectionString.Append("uid=" + pUsername + ";");
                connectionString.Append("pwd= " + pPassword + ";");
                //-- datdp Edit 100609 --- doi dong connectionString.Append("Connection Timeout=15;"); xuong duoi nhu sau:
                connectionString.Append("Connection Timeout=15;");

				return connectionString.ToString();
				
			}
			catch
			{
				throw new FacadeException("Can not connect to DB");
			}
		}

        /// <summary>
		/// /////////////////////
		/// </summary>
		/// <param name="mode"></param>
		/// <returns></returns>
		public static string SQLInsert(BaseModel mode)
		{
			string tableName = mode.GetType().Name;
			tableName = tableName.Substring(0, tableName.Length - 5);

			string Insert = "insert into " + tableName + " (";
			PropertyInfo[] propertiesName = mode.GetType().GetProperties();

            for (int i = 0; i < propertiesName.Length; i++)
            {
                object[] arrAtt = propertiesName[i].GetCustomAttributes(true);
                if (arrAtt.Length > 0)
                {
                    continue;
                }
                if (!tableName.Equals("Tree_Members")&& !tableName.Equals("PaymentTrans"))
                {
                    if (!propertiesName[i].Name.Equals("ID"))
                    {
                        Insert = Insert + propertiesName[i].Name;
                        Insert = Insert + ",";
                    }
                }
                else
                {
                    Insert = Insert + propertiesName[i].Name;
                    Insert = Insert + ",";
                }
            }
			Insert = Insert.Substring(0, Insert.Length - 1);
			Insert = Insert + ") values (";
            for (int i = 0; i < propertiesName.Length; i++)
            {
                object[] arrAtt = propertiesName[i].GetCustomAttributes(true);
                if (arrAtt.Length > 0)
                {
                    continue;
                }
                if (!tableName.Equals("Tree_Members") && !tableName.Equals("PaymentTrans"))
                {
                    if (!propertiesName[i].Name.Equals("ID"))
                    {
                        Insert = Insert + "@";
                        Insert = Insert + propertiesName[i].Name;
                        Insert = Insert + ",";
                    }
                }
                else
                {
                    Insert = Insert + "@";
                    Insert = Insert + propertiesName[i].Name;
                    Insert = Insert + ",";
                }
            }
			Insert = Insert.Substring(0, Insert.Length - 1);
            if (!tableName.Equals("Tree_Members") && !tableName.Equals("PaymentTrans"))
                Insert = Insert + ") Select Scope_Identity()";
            else
                Insert = Insert + ")";
			return Insert;
		}
        public static string SQLInsertTemp(string tableName, DataTable Source)
        {
            string Insert = "insert into " + tableName + " (";

            for (int i = 0; i < Source.Columns.Count; i++)
            {
                Insert = Insert + Source.Columns[i].ColumnName;
                Insert = Insert + ",";
            }
            Insert = Insert.Substring(0, Insert.Length - 1);
            Insert = Insert + ") values (";
            for (int i = 0; i < Source.Columns.Count; i++)
            {
                Insert = Insert + "@";
                Insert = Insert + Source.Columns[i].ColumnName;
                Insert = Insert + ",";
            }
            Insert = Insert.Substring(0, Insert.Length - 1);
            Insert = Insert + ")";
            return Insert;
        }
        public static string SQLUpdate(BaseModel model)
        {
            string tableName = model.GetType().Name;
            tableName = tableName.Substring(0, tableName.Length - 5);

            string Update = "UPDATE " + tableName + " SET ";
            PropertyInfo[] propertiesName = model.GetType().GetProperties();
            //if (!tableName.Equals("Members"))
            //{
            for (int i = 0; i < propertiesName.Length; i++)
            {
                object[] arrAtt = propertiesName[i].GetCustomAttributes(true);
                if (arrAtt.Length > 0)
                {
                    continue;
                }
                if (!propertiesName[i].Name.Equals("ID"))
                {
                    Update = Update + propertiesName[i].Name;
                    Update = Update + "=@" + propertiesName[i].Name;
                    Update = Update + ",";
                }
            }
            Update = Update.Substring(0, Update.Length - 1);
            Update = Update + " WHERE ID=" + model.GetType().GetProperty("ID").GetValue(model, null).ToString();
            //}
            //else
            //{
            //    for (int i = 0; i < propertiesName.Length; i++)
            //    {
            //        if (!propertiesName[i].Name.Equals("UserName"))
            //        {
            //            Update = Update + propertiesName[i].Name;
            //            Update = Update + "=@" + propertiesName[i].Name;
            //            Update = Update + ",";
            //        }
            //    }
            //    Update = Update.Substring(0, Update.Length - 1);
            //    Update = Update + " WHERE UserName='" + model.GetType().GetProperty("UserName").GetValue(model, null).ToString() + "'";
            //}
            return Update;
        }
        public static string SQLUpdate(BaseModel model,string field)
        {
            string tableName = model.GetType().Name;
            tableName = tableName.Substring(0, tableName.Length - 5);

            string Update = "UPDATE " + tableName + " SET ";
            PropertyInfo[] propertiesName = model.GetType().GetProperties();
            for (int i = 0; i < propertiesName.Length; i++)
            {
                if (!propertiesName[i].Name.Equals("ID") && !propertiesName[i].Name.Equals(field))
                {
                    Update = Update + propertiesName[i].Name;
                    Update = Update + "=@" + propertiesName[i].Name;
                    Update = Update + ",";
                }
            }
            Update = Update.Substring(0, Update.Length - 1);
            Update = Update + " WHERE ID=" + model.GetType().GetProperty("ID").GetValue(model, null).ToString();
            return Update;
        }

		public static string SQLSelect(string tableName, string field, object value)
		{
			return SQLSelect(tableName, new Expression(field, value));
		}

		public static string SQLSelect(string tableName, string field, object value, string op)
		{
			return SQLSelect(tableName, new Expression(field, value, op));
		}

		public static string SQLSelect(string tableName, Expression exp)
		{
            string sql = "SELECT *, ROW_NUMBER() over (order by (select 1)) as STT FROM " + tableName + " with (nolock) ";
			if (exp != null)
				sql += " WHERE " + exp.ToString();
			return sql;
		}

		public static string SQLSelectMax(string tableName, string field, string field1, object value)
		{
			return SQLSelectMax(tableName , field, new Expression(field1, value));
		}

		public static string SQLSelectMaxRoot(string tableName, string field)
		{
			return SQLSelectMax(tableName , field);
		}

		public static string SQLSelectMax(string tableName, string field)
		{
			string sql = "SELECT Max(" + field + ") FROM " + tableName;
			return sql;
		}
        public static string SQLSelectMinRoot(string tableName, string field)
        {
            return SQLSelectMin(tableName, field);
        }
        public static string SQLSelectMin(string tableName, string field)
        {
            string sql = "SELECT Min(" + field + ") FROM " + tableName;
            return sql;
        }

		public static string SQLSelectMax(string tableName, string field, Expression exp)
		{
			string sql = "SELECT Max(" + field + ") FROM " + tableName;
			if (exp != null)
				sql += " WHERE " + exp.ToString();
			return sql;
		}

		public static string SQLSelectCount(string tableName, string field, Expression exp)
		{
			string sql = "SELECT count(" + field + ") FROM " + tableName;
			if (exp != null)
				sql += " WHERE " + exp.ToString();
			return sql;
		}

		public static string SQLDelete(string tableName, Expression exp)
		{
			string sql = "DELETE FROM " + tableName;
			if (exp != null)
				sql += " WHERE " + exp.ToString();
			return sql;
		}

		public static string SQLDelete(string tableName, Int64 IDvalue)
		{
			string Delete = "DELETE FROM " + tableName + " WHERE ID=" + IDvalue;
			return Delete;
		}

		public static string SQLDelete(string tableName, string field, string value)
		{
			string Delete = "delete FROM " + tableName + " WHERE " + field + "='" + value + "'";
			return Delete;
		}

		public static string SQLDelete(string tableName, string field, Int64 value)
		{
			string Delete = "delete FROM " + tableName + " WHERE " + field + "=" + value;
			return Delete;
		}

		public static SqlDbType ConvertToSQLType(Type type)
		{
			if (type == typeof (string))
			{
				return SqlDbType.NVarChar;
			}
			if (type == typeof (int))
			{
				return SqlDbType.Int;
			}
			if (type == typeof (Int16))
			{
				return SqlDbType.TinyInt;
			}
			if (type == typeof (Int64))
			{
				return SqlDbType.BigInt;
			}
			if (type == typeof (DateTime))
			{
				return SqlDbType.DateTime;
			}
            if (type == typeof(DateTime?))
            {
                return SqlDbType.DateTime;
            }
			if (type == typeof (long))
			{
				return SqlDbType.BigInt;
			}
			if (type == typeof (Decimal))
			{
				return SqlDbType.Decimal;
			}
            if (type == typeof(Byte[]))
            {
                return SqlDbType.Image;
            }
            if (type == typeof(Guid))
            {
                return SqlDbType.UniqueIdentifier;
            }
			return SqlDbType.NVarChar;
		}

        //Insert vào bảng eventlog 
        private static string GetDescription(string strTableName, ActionType Action)
        {
            return ("Table: " + strTableName + " Action: " + Action.ToString() + " ");
        }

        public static string GetDescription(string strTableName, ActionType Action, string Code)
        {
            return (GetDescription(strTableName, Action) + "With Code: " + Code + " Event: OK");
        }

        public static string GetDescription(string strTableName, ActionType Action, int ID)
        {
            return (GetDescription(strTableName, Action) + "With iD: " + ID.ToString() + " Event: OK");
        }

        public static string GetDescription(string strTableName, ActionType Action, string Code, string strError)
        {
            return (GetDescription(strTableName, Action) + "With Code: " + Code + " Event: " + strError);
        }

        public static string GetDescription(string strTableName, ActionType Action, int ID, string strError)
        {
            return (GetDescription(strTableName, Action) + "With iD: " + ID.ToString() + " Event: " + strError);
        }

        //Sử dụng một trường tùy ý
        public static string GetDescription(string strTableName, ActionType Action, string strColumnName, int value)
        {
            return (GetDescription(strTableName, Action) + "With " + strColumnName + ": " + value.ToString() + " Event: OK");
        }

        public static string GetDescription(string strTableName, ActionType Action, string strColumnName, int value, string strError)
        {
            return (GetDescription(strTableName, Action) + "With " + strColumnName + ": " + value.ToString() + " Event: " + strError);
        }

        public static string GetDescription(string strTableName, ActionType Action, string strColumnName, string value, string strError)
        {
            return (GetDescription(strTableName, Action) + "With " + strColumnName + ": " + value + " Event: " + strError);
        }

        public enum ActionType
        {
            DELETE,
            INSERT,
            UPDATE,
            ERROR
        }

        public static string GetOtherDBConnectionString(int dbType)
        {
            try
            {
                string filename = "default.ini";
                switch (dbType)
                {
                    case 1: filename = "default_Interface.ini"; break;
                    case 2: filename = Global.Default_PBX_Interface; break;
                }
                string[] InputInfor = new string[4];
                string[] OutputInfor = new string[4];
                string err = "";
                GetInforConnectionString(ref InputInfor, ref err, filename);
                GetParamConnectionString(InputInfor, ref OutputInfor, ref err);

                string pServerName = OutputInfor[0];
                string pDatabaseName = OutputInfor[1];
                string pUsername = OutputInfor[2];
                string pPassword = OutputInfor[3];
                StringBuilder connectionString = new StringBuilder();
                connectionString.Append("Server=" + pServerName + ";");
                connectionString.Append("database=" + pDatabaseName + ";");
                connectionString.Append("uid=" + pUsername + ";");
                connectionString.Append("pwd= " + pPassword + ";");

                connectionString.Append("Connection Timeout=10;");
                return connectionString.ToString();
            }
            catch
            {
                throw new FacadeException("Can not connect to DB");
            }
        }

        public static bool GetInforConnectionString(ref string[] GetInfor, ref string err, string filename)
        {
            try
            {
                string[] Infor = new string[4];//0:server,1:Database;2:User,3:Pass

                string strPath = Application.StartupPath + @"\" + filename;
                FileStream file = new FileStream(strPath, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(file);
                int i = 0;
                while (i < 4)
                {
                    Infor[i] = sr.ReadLine();
                    i = i + 1;
                }
                sr.Close();
                file.Close();
                GetInfor = Infor;
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }


	}
}
