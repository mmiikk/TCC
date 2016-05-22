using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using TCC.Model;

namespace TCC.Helper
{
    class sqlWorker
    {
        
        static DataSet loadData(string query)
        {
            DataSet dataSet = new DataSet();
           
                string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
                connectionString = connectionString.Replace("IP", Settings1.Default.ServerIP);
                connectionString = connectionString.Replace("DBUser", Settings1.Default.DBUser);
                connectionString = connectionString.Replace("DBPassword", Settings1.Default.DBPassword);
                connectionString = connectionString.Replace("DBName", Settings1.Default.DBName);

                //set connection with connection string from web config
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    //try execute query
                    try
                    {
                        //open connection
                        connection.Open();

                        //get data from sql
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                        {

                            //fill data set
                            dataAdapter.Fill(dataSet);

                            return dataSet;
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }


                }
           
        }

        public ObservableCollection<Element> loadDataAsObservableCollection(int StationID)
        {
            ObservableCollection<Element> ElementsSet = new ObservableCollection<Element>();
           
                try
                {
                    DataSet Data = loadData("Select * from " + Settings1.Default.DBName + ".[dbo].[Elements] where Station_ID = " + StationID + " order by ID asc");
                    foreach (DataRow row in Data.Tables[0].Rows)
                    {
                        Element obj = new Element();
                        obj.ID = (int)row["ID"];
                        //obj.Station_ID = (byte)row["Station_ID"];
                        obj.Position_X = (int)row["Position_X"];
                        obj.Position_Y = (int)row["Position_Y"];
                        obj.Width = (int)row["Width"];
                        obj.Height = (int)row["Height"];
                        obj.Name = (string)row["Name"];
                        obj.Position_Name = (string)row["Position_Name"];
                        obj.ShowBorder = (bool)row["ShowBorder"];
                        obj.ShowName = (bool)row["ShowName"];
                        obj.OnTop = (bool)row["OnTop"];

                        ElementsSet.Add(obj);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }


                return ElementsSet;
            
        }

    }
}
