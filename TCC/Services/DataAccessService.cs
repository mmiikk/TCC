using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Helper;
using TCC.Model;

namespace TCC.Services
{
    interface IDataAccessService
    {
        ObservableCollection<Element> GetAllElements(int StationID);
        ObservableCollection<Value> GetAllValues(int ElementID, int StationID);
        ObservableCollection<Mask> GetMasks(int StationID, int MaskID);
        ObservableCollection<PLC> GetAllPLCs();
        Font GetFont(int StationID, int ElementID);
    }
    class DataAccessService : IDataAccessService
    {
        sqlWorker sql;
        Element context;
        
        private static DataAccessService instance;

        private DataAccessService() {
            context = new Element();
            sql = new sqlWorker();
        }

        public static DataAccessService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataAccessService();
                }
                return instance;
            }
        }

        public ObservableCollection<Element> GetAllElements(int StationID)
        {
            ObservableCollection<Element> Elements = new ObservableCollection<Element>();
            try
            {
                Elements = sql.loadDataAsObservableCollection(StationID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Elements;
        }

        public ObservableCollection<Value> GetAllValues(int StationID, int ElementID)
        {
            ObservableCollection<Value> Values = new ObservableCollection<Value>();
            try
            {
                Values = sql.loadValuesAsObservableCollection(StationID, ElementID);
                Value val = new Value();
                val.ID = ElementID;
                val.Type = "Static";
                val.DB = 0;
                val.StartByte = 0;
                val.Length = 0;
                val.Val = "";
                val.Mask_ID = 0;
                val.DBType = 2;
                val.oPLC.ID = 1;
                if (!Values.Any(p => p.ID == ElementID))
                    Values.Add(val);

                val.ID = ElementID + 1000;
                val.Val = "0";
                if ((!Values.Any(p => p.ID == (ElementID + 1000))) || (!Values.Any(p => p.ID == (ElementID + 3000))))
                    Values.Add(val);

                val.ID = ElementID + 2000;
                val.Val = "65280";
                if (!Values.Any(p => p.ID == (ElementID + 2000)))
                    Values.Add(val);

                val.ID = ElementID + 4000;
                val.Val = "0";
                val.Type = "";
                if (!Values.Any(p => p.ID == (ElementID + 4000)))
                    Values.Add(val);

                val.ID = ElementID + 5000;
                val.Val = "1";
                val.Type = "Static";
                if (!Values.Any(p => p.ID == (ElementID + 5000)))
                    Values.Add(val);

                Values.OrderBy(p => p.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Values;
        }

        public Font GetFont(int StationID, int ElementID)
        {
            Font font = new Font();
            try
            {
                font = sql.loadFont(StationID, ElementID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return font;
        }

        public ObservableCollection<PLC> GetAllPLCs()
        {
            ObservableCollection<PLC> plcs = new ObservableCollection<PLC>();
            try
            {
                plcs = sql.loadPLCs();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return plcs;
        }

        public ObservableCollection<Mask> GetMasks(int StationID, int MaskID)
        {
            ObservableCollection<Mask> masks = new ObservableCollection<Mask>();
            try
            {
                masks = sql.loadMasks(StationID, MaskID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return masks;
        }

    }
}
