using System;
using BLL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IReportService
    {
        List<SPVklad> ExecuteSP(DateTime date);
    }
}
