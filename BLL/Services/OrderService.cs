using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class VkladService
    {

        private DbDataOperation db;
        public VkladService(DbDataOperation db)
        {
            this.db = db;
        }
        Vklad vklad;
        public bool MakeOrder(Vklad vkladDto)
        {
            

            if (vkladDto.Id > 0)
            {
                Vklad vklad = db.GetVklad(vkladDto.Id);
                vklad.DateOpen = DateTime.Now;
                vklad.Balance = 0;
              
                vklad.Client_code = vkladDto.Client_code;
                vklad.Prog_code = vkladDto.Prog_code;
                db.UpdateVklad(vklad);
            }
            else
            {
                vklad = new Vklad
                {
                    Balance = 0,
                    DateOpen = DateTime.Now,                   
                    Client_code = vkladDto.Client_code,
                    Prog_code = vkladDto.Prog_code
                };
                db.CreateVklad(vklad);
            }
            return db.CreateVklad(vklad);

           
       
        }

 


    }
}
