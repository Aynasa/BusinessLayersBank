using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ReportServices : IReportService
    {
        private CasinoContext db;



        public List<SPResult> ExecuteSP(DateTime date)
        {
            System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@data", date.Date);

            db = new CasinoContext();
            var result = db.Database.SqlQuery<SPResult>("pr_report @data", new object[] { param }).ToList();

            return result;
        }


    }
}
