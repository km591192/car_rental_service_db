using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using Npgsql;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace Carrent
{

    public class Database
    {
        //localhost, 127.0.0.1

        public BindingSource Selectdatabase(string query, DataGridView dgv)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=km591192;Database=Carrent;");
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand(query, npgSqlConnection);
            NpgsqlDataAdapter npgsqldataadapter = new NpgsqlDataAdapter();
            npgsqldataadapter.SelectCommand = npgSqlCommand;
            DataTable datatable = new DataTable();
            npgsqldataadapter.Fill(datatable);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = datatable;
            dgv.DataSource = bsource;
            npgsqldataadapter.Update(datatable);
            npgSqlConnection.Close();
            return bsource;
        }

        public void countstrdatabase(string query, TextBox tb)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=km591192;Database=Carrent;");
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand(query, npgSqlConnection);
            NpgsqlDataAdapter npgsqldataadapter = new NpgsqlDataAdapter();
            npgsqldataadapter.SelectCommand = npgSqlCommand;
            int s = System.Convert.ToInt16(npgSqlCommand.ExecuteScalar());
            int ss = s + 1;
            tb.Text = System.Convert.ToString(ss);
            //tb.Text = System.Convert.ToString(npgSqlCommand.ExecuteScalar());
            npgSqlConnection.Close();
        }

        public int countstrdatabasereturn(string query)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=km591192;Database=Carrent;");
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand(query, npgSqlConnection);
            NpgsqlDataAdapter npgsqldataadapter = new NpgsqlDataAdapter();
            npgsqldataadapter.SelectCommand = npgSqlCommand;
            int s = System.Convert.ToInt16(npgSqlCommand.ExecuteScalar());
            npgSqlConnection.Close();
            return s;
        }

        public string returnstrfromdatabase(string query)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=km591192;Database=Carrent;");
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand(query, npgSqlConnection);
            NpgsqlDataAdapter npgsqldataadapter = new NpgsqlDataAdapter();
            npgsqldataadapter.SelectCommand = npgSqlCommand;
            string s = System.Convert.ToString(npgSqlCommand.ExecuteScalar());
            npgSqlConnection.Close();
            return s;
        }


        public void insert(string _query)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=km591192;Database=Carrent;");
            try
            {
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand(_query, npgSqlConnection);
                if (npgSqlCommand.ExecuteNonQuery() == 1)
                    MessageBox.Show("Add");
                npgSqlConnection.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        //client role 
        public BindingSource Selectdatabaseclient(string query, DataGridView dgv)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=client;Password=client;Database=Carrent;");
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand(query, npgSqlConnection);
            NpgsqlDataAdapter npgsqldataadapter = new NpgsqlDataAdapter();
            npgsqldataadapter.SelectCommand = npgSqlCommand;
            DataTable datatable = new DataTable();
            npgsqldataadapter.Fill(datatable);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = datatable;
            dgv.DataSource = bsource;
            npgsqldataadapter.Update(datatable);
            npgSqlConnection.Close();
            return bsource;
        }
        public void insertclient(string _query)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=client;Password=client;Database=Carrent;");
            try
            {
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand(_query, npgSqlConnection);
                if (npgSqlCommand.ExecuteNonQuery() == 1)
                    MessageBox.Show("Add");
                npgSqlConnection.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }


        //po role
        public BindingSource Selectdatabasepo(string query, DataGridView dgv)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=po;Password=po;Database=Carrent;");
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand(query, npgSqlConnection);
            NpgsqlDataAdapter npgsqldataadapter = new NpgsqlDataAdapter();
            npgsqldataadapter.SelectCommand = npgSqlCommand;
            DataTable datatable = new DataTable();
            npgsqldataadapter.Fill(datatable);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = datatable;
            dgv.DataSource = bsource;
            npgsqldataadapter.Update(datatable);
            npgSqlConnection.Close();
            return bsource;
        }
        public void insertpo(string _query)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=po;Password=po;Database=Carrent;");
            try
            {
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand(_query, npgSqlConnection);
                if (npgSqlCommand.ExecuteNonQuery() == 1)
                npgSqlConnection.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }


    }
}
