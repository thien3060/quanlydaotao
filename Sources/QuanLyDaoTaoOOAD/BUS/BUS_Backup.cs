using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_Backup
    {
        private DAO_Backup backup = new DAO_Backup();
        public void BackupDatabase(string fileName, string path)
        {
            backup.Backup(fileName, path);
        }
        public void RestoreDatabase(string path)
        {
            backup.Restore(path);
        }
    }
}
