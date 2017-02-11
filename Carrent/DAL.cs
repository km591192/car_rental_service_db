using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Npgsql;
using System.Data.Common;
namespace Carrent
{
    public class DAL
    {
        Database db = new Database();

        public void selectCount (string from)
        {
            FS fs = new FS();
            string query = "SELECT COUNT(1) FROM " + from;

            fs.writequery(query);
        }

        public void selectquerydal(string select, string from, bool where, string swhere, bool groupby, string sgroupby, bool having, string shaving, bool orderby, string sorderby)
        {
            FS fs = new FS();
            string query = "SELECT " + select + " FROM " + from;
            if (where == true)
                query += " WHERE " + swhere;
            if (groupby == true)
                query += " GROUP BY " + sgroupby;
            if (having == true)
                query += " HAVING " + shaving;
            if (orderby == true)
                query += " ORDER BY " + sorderby;

            fs.writequery(query);
        }

        public void insertdal(string table, string values)
        {
            FS fs = new FS();
            string _query = "INSERT INTO " + table + " VALUES(" + values + ");";
            //db.insert(query);
            fs.writequery(_query);
        }
    }
}
