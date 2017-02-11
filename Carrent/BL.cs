using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using System.Data.Common;

namespace Carrent
{
   public class BL
    {
       DAL dall = new DAL();
       //GSstring gsstr = new GSstring();

       public void insertaccident(string s)
       { dall.insertdal(" \"Carrent\".accident ", s); }

       public void insertmodel(string s)
       { dall.insertdal(" \"Carrent\".models ", s); }

       public void insertcars(string s)
       { dall.insertdal(" \"Carrent\".cars ", s); }

       public void insertla(string s)
       { dall.insertdal(" \"Carrent\".leaseagreement ", s); }

       public void insertclient(string s)
       { dall.insertdal(" \"Carrent\".clients ", s); }

       public void insertpo(string s)
       { dall.insertdal(" \"Carrent\".privateowner ", s); }

       public void selectcountblaccident()
       { dall.selectCount(" \"Carrent\".accident "); }

       public void selectcountblmodel()
       { dall.selectCount(" \"Carrent\".models "); }
       public void selectcountblcars()
       { dall.selectCount(" \"Carrent\".cars "); }
       public void selectcountblla()
       { dall.selectCount(" \"Carrent\".leaseagreement "); }
       public void selectcountblclient()
       { dall.selectCount(" \"Carrent\".clients "); }
       public void selectcountblpo()
       { dall.selectCount(" \"Carrent\".privateowner "); }

       public void carclass(TextBox tb)
       { dall.selectquerydal(" m.carclass ", " \"Carrent\".models m, \"Carrent\".cars c ", true, " c.model_id = m.model_id AND c.cars_id = " + tb.Text, false, " ", false, " ", false, " "); }

    public void selectqueryblfreecars()
    {
        dall.selectquerydal("c1.cars_id,m1.carclass, m1.carmodel, m1.carmarka","\"Carrent\".cars c1,  \"Carrent\".leaseagreement l1, \"Carrent\".models m1", true, "c1.model_id = m1.model_id AND c1.cars_id  NOT IN (select l1.cars_id  from \"Carrent\".leaseagreement l1) AND (NOW() BETWEEN l1.data_start and l1.data_end)", true , "c1.cars_id,m1.carclass, m1.carmodel, m1.carmarka", false, "", true ,"c1.cars_id asc"); 
    }
       public void selectquerybl()
       { 
           dall.selectquerydal("*", " \"Carrent\".cars ", false, " ", false, " ", false, " ", false, " ");
       }
       public void selectqueryblmodels()
       {
           dall.selectquerydal("*", " \"Carrent\".models ", false, " ", false, " ", false, " ", false, " ");
       }
       public void selectqueryblclient()
       {
           dall.selectquerydal("*", " \"Carrent\".clients ", false, " ", false, " ", false, " ", false, " ");
       }
       public void selectqueryblaccident()
       {
           dall.selectquerydal("*", " \"Carrent\".accident ", false, " ", false, " ", false, " ", true, "\"Carrent\".accident.accident_id");
       }
       public void selectqueryblla()
       {
           dall.selectquerydal("*", " \"Carrent\".leaseagreement ", false, " ", false, " ", false, " ", true, "\"Carrent\".leaseagreement.leaseagreement_id ");
       }
       public void selectqueryblpo()
       {
           dall.selectquerydal("*", " \"Carrent\".privateowner ", false, " ", false, " ", false, " ", true, "\"Carrent\".privateowner.privateowner_id");
       }
       public void selectqueryblallcarinfo()
       {
           dall.selectquerydal("\"Carrent\".cars.cars_id as number,\"Carrent\".cars.color,\"Carrent\".models.carmarka,\"Carrent\".models.carmodel, \"Carrent\".models.carclass", "\"Carrent\".cars, \"Carrent\".models", true, "\"Carrent\".models.model_id =  \"Carrent\".cars.model_id",
               true, "\"Carrent\".cars.color,\"Carrent\".cars.cars_id,\"Carrent\".models.carmarka,\"Carrent\".models.carclass,\"Carrent\".models.carmodel", false, " ", true, "\"Carrent\".cars.cars_id ");
       }
       public void selectqueryblallfreecarinfo()
       {
           dall.selectquerydal("\"Carrent\".cars.cars_id as number,\"Carrent\".cars.color,\"Carrent\".models.carmarka,\"Carrent\".models.carmodel, \"Carrent\".models.carclass", "\"Carrent\".cars, \"Carrent\".models", true, "\"Carrent\".models.model_id =  \"Carrent\".cars.model_id AND \"Carrent\".cars.cars_id NOT IN ( SELECT c1.cars_id FROM \"Carrent\".cars c1, \"Carrent\".leaseagreement l1 WHERE c1.cars_id = l1.cars_id AND (NOW() BETWEEN l1.data_start and l1.data_end))",
               true, "\"Carrent\".cars.color,\"Carrent\".cars.cars_id,\"Carrent\".models.carmarka,\"Carrent\".models.carclass,\"Carrent\".models.carmodel", false, " ", true, "\"Carrent\".cars.cars_id ");
       }
       public void selectqueryblallpopcar()
       {
           dall.selectquerydal("l.cars_id AS car_number, m.carmarka, m.carmodel, m.carclass, COUNT(l.cars_id) AS how_much_times", 
               "\"Carrent\".models m,  \"Carrent\".leaseagreement l, \"Carrent\".cars c",
               true, "l.cars_id = c.cars_id AND c.model_id = m.model_id AND m.carmarka IN ( SELECT m1.carmarka FROM \"Carrent\".models m1 , \"Carrent\".cars c1, \"Carrent\".leaseagreement l1 WHERE m1.model_id = c1.model_id AND c1.cars_id = l1.cars_id GROUP BY m1.carmarka ORDER BY  COUNT(m1.carmarka)  desc)",
           true, "m.carmarka, l.cars_id,m.carmodel, m.carclass", false, " ", true, "COUNT(l.cars_id) desc");
       }

       public void selectqueryblaallfreepopcar()
       {
           dall.selectquerydal("l.cars_id AS car_number, m.carmarka, m.carmodel, m.carclass, COUNT(l.cars_id) AS how_much_times", 
               "  \"Carrent\".models m,  \"Carrent\".leaseagreement l, \"Carrent\".cars c ",
               true, "l.cars_id = c.cars_id AND c.model_id = m.model_id AND m.carmarka IN ( SELECT m1.carmarka FROM \"Carrent\".models m1 , \"Carrent\".cars c1, \"Carrent\".leaseagreement l1 WHERE m1.model_id = c1.model_id AND c1.cars_id = l1.cars_id GROUP BY m1.carmarka ORDER BY  COUNT(m1.carmarka)  desc) AND c.cars_id NOT IN (SELECT c1.cars_id FROM \"Carrent\".cars c1, \"Carrent\".leaseagreement l1 WHERE c1.cars_id = l1.cars_id AND (NOW() BETWEEN l1.data_start and l1.data_end))", 
              true, "m.carmarka, l.cars_id,m.carmodel, m.carclass", false, " ", true, "COUNT(l.cars_id) desc");     
       }

       public void selectqueryblcarincity(TextBox tb)
       {
           dall.selectquerydal("c.cars_id ,po.city", "\"Carrent\".cars c, \"Carrent\".privateowner po", true,
               "c.cars_id = po.cars_id AND c.cars_id NOT IN (SELECT c1.cars_id FROM \"Carrent\".cars c1, \"Carrent\".leaseagreement l1 WHERE c1.cars_id = l1.cars_id AND (NOW() BETWEEN l1.data_start and l1.data_end)) AND po.city LIKE '" + tb.Text.Trim() + "%' "
                ,false," ",false," ",false, " ");
       }

       public void selectqueryblpopcarincity(TextBox tb)
       {
           dall.selectquerydal("c.cars_id AS car_number, m.carmarka, m.carmodel, m.carclass, po.city, COUNT(l.cars_id) AS how_much_times", 
               "\"Carrent\".models m,  \"Carrent\".leaseagreement l, \"Carrent\".cars c, \"Carrent\".privateowner po", true, 
               "l.cars_id = c.cars_id AND c.model_id = m.model_id AND m.carmarka IN ( SELECT m1.carmarka FROM \"Carrent\".models m1 , \"Carrent\".cars c1, \"Carrent\".leaseagreement l1 WHERE m1.model_id = c1.model_id AND c1.cars_id = l1.cars_id GROUP BY m1.carmarka ORDER BY  COUNT(m1.carmarka)  desc) AND c.cars_id NOT IN (SELECT c1.cars_id FROM \"Carrent\".cars c1, \"Carrent\".leaseagreement l1 WHERE c1.cars_id = l1.cars_id AND (NOW() BETWEEN l1.data_start and l1.data_end))AND po.cars_id = c.cars_id AND po.city LIKE '" + tb.Text.Trim() + "%' AND m.model_id = c.model_id",true,
               "c.cars_id, m.carmarka, l.cars_id,m.carmodel, m.carclass,po.city", false, " ", true, " COUNT(l.cars_id) desc");
       }

       public void sqmorestatisticpo(TextBox tbpoid)
       {
           dall.selectquerydal("l.leaseagreement_id, l.cars_id , cl.name  AS client_name, cl.surname AS client_surname, l.data_start, l.data_end, SUM(l.totalprice) AS sum",
               "\"Carrent\".clients cl, \"Carrent\".leaseagreement l, \"Carrent\".cars c, \"Carrent\".privateowner po", true,
               "po.privateowner_id = " + tbpoid.Text.ToString() + " AND po.cars_id = c.cars_id AND c.cars_id = l.cars_id AND cl.client_id = l.client_id ", true,
               "l.cars_id , cl.name, cl.surname,  l.data_start, l.data_end, l.leaseagreement_id", false, "", true, "SUM(l.totalprice) desc");
       }

       public void sqstatisticpo(TextBox tbpoid)
       {
           dall.selectquerydal("l.leaseagreement_id, l.cars_id , cl.name  AS client_name, cl.surname AS client_surname, SUM(l.totalprice) AS sum, COUNT(l.cars_id) AS how_much_times",
               "\"Carrent\".clients cl, \"Carrent\".leaseagreement l, \"Carrent\".cars c, \"Carrent\".privateowner po", true,
               "po.privateowner_id = " + tbpoid.Text.ToString() + " AND po.cars_id = c.cars_id AND c.cars_id = l.cars_id AND cl.client_id = l.client_id", true,
               "l.cars_id , cl.name, cl.surname, l.leaseagreement_id", false, "", true, "SUM(l.totalprice) desc, COUNT (l.cars_id)");
       }

       public void sqowneraccidentstatistic(TextBox tbpoid)
       {
           dall.selectquerydal("l.leaseagreement_id, l.cars_id , cl.name  AS client_name, cl.surname AS client_surname, l.data_start, l.data_end, a.accidentdate, a.end_date",
              "\"Carrent\".clients cl, \"Carrent\".leaseagreement l, \"Carrent\".cars c, \"Carrent\".privateowner po, \"Carrent\".accident a", true,
              "po.privateowner_id = " + tbpoid.Text.ToString() + " AND po.cars_id = c.cars_id AND c.cars_id = l.cars_id AND cl.client_id = l.client_id AND l.leaseagreement_id = a.leaseagreement_id", true,
              "l.cars_id , cl.name, cl.surname,  l.data_start, l.data_end, a.accidentdate, a.end_date,l.leaseagreement_id", false, "", false, "");
       }

       public void sqownermyclient(TextBox tbpoid)
       {
           dall.selectquerydal("cl.name  AS client_name, cl.surname AS client_surname, cl.phonenumber",
             "\"Carrent\".clients cl, \"Carrent\".leaseagreement l, \"Carrent\".cars c, \"Carrent\".privateowner po", true,
             "po.privateowner_id = " + tbpoid.Text.ToString() + " AND po.cars_id = c.cars_id AND c.cars_id = l.cars_id AND cl.client_id = l.client_id ", true,
             "cl.name, cl.surname,  cl.phonenumber", false, "", false, "");
       }
    }
}
