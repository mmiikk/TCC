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


    }
}
