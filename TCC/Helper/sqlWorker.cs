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
                        obj.Station_ID = (byte)row["Station_ID"];
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

        public ObservableCollection<Value> loadValuesAsObservableCollection(int StationID, int ID)
        {
            ObservableCollection<Value> ValuesSet = new ObservableCollection<Value>();
            string query = String.Format("Select v.*, p.Name from {0}.[dbo].[Values] v, {0}.[dbo].[PLC] p where v.Station_ID = {2} and v.ID in ( {1}, (select {1}+1000), (select {1}+2000), (select {1}+3000), (select {1}+4000), (select {1}+5000) ) and v.PLC_ID = p.ID order by ID asc",
                Settings1.Default.DBName,
                ID,
                StationID

                );
            DataSet Data = loadData(query);
            foreach (DataRow row in Data.Tables[0].Rows)
            {
                Value obj = new Value();
                obj.ID = (int)row["ID"];
                //obj.Station_ID = (byte)row["Station_ID"];
                obj.Type = (string)row["Type"];
                obj.DB = (int)row["DB"];
                obj.StartByte = (int)row["StartByte"];
                obj.Length = (int)row["Length"];
                obj.Val = (string)row["Value"];
                obj.Mask_ID = (int)row["Mask_ID"];
                obj.DBType = (int)row["DBType"];
                obj.oPLC.ID = (int)row["PLC_ID"];
                obj.oPLC.Name = (string)row["Name"];

                ValuesSet.Add(obj);
            }

            return ValuesSet;
        }

        public Font loadFont(int StationID, int ID)
        {
            DataSet Data = loadData("Select distinct * from " + Settings1.Default.DBName + ".[dbo].[FontsList] where Station_ID = " + StationID + " and ID = " + ID + " order by ID asc");
            Font font = new Font();
            foreach (DataRow row in Data.Tables[0].Rows)
            {
                font.ID = (int)row["ID"];
                font.Station_ID = (int)row["Station_ID"];
                font.Size = (byte)row["Size"];
                font.Bold = (bool)row["Bold"];
                font.Italic = (bool)row["Italic"];
                font.Underline = (bool)row["Underline"];
                font.CenterAlign = (bool)row["CenterAlign"];
            }

            return font;
        }

    }
}
