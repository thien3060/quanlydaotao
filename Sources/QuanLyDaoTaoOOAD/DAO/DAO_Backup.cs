using System.Collections.Generic;
using System.Data;
using System.Linq;
using DTO;
using System;

namespace DAO
{
    public class DAO_Backup
    {
        public Connection Connection = new Connection();

        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        private void AddParameter(string fileName, string path)
        {
            parameters.Clear();
            parameters.Add("@path", path + @"\" + fileName);
            parameters.Add("@ten", fileName);
            parameters.Add("@databasename", "QuanLyDaoTao");
        }

        public void Backup(string fileName, string path)
        {
            AddParameter(fileName, path);
            Connection.ExecuteSqlWithParameter(@"BACKUP DATABASE @databasename TO  DISK = @path WITH NOFORMAT, NOINIT,  NAME = @ten, SKIP, NOREWIND, NOUNLOAD,  STATS = 10", parameters);
        }
        public void Restore(string path)
        {
            parameters.Clear();
            parameters.Add("@path", path);
            parameters.Add("@databasename", "QuanLyDaoTao");
            Connection.ExecuteSqlWithParameter("Use master RESTORE DATABASE @databasename FROM  DISK = @path WITH  FILE = 1,  NOUNLOAD, REPLACE,  STATS = 10", parameters);
        }
    }
}
