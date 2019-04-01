using DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DbDataOperation
    {
        private VkladDb db;
        public DbDataOperation()
        {
            db = new VkladDb();
            db.Vklads.Load();
        }

        public ObservableCollection<Vklad> GetAllVklads()
        {
            return db.Vklads.Local;
        }

        public ObservableCollection<Prog> GetAllProgs()
        {
            db.Progs.Load();
            return db.Progs.Local;
        }

        public Vklad GetVklad(int Id)
        {
            return db.Vklads.Find(Id);
        }

        public Prog GetProg(int Id)
        {
            return db.Progs.Where(i=>i.Id==Id).FirstOrDefault();
        }

        public bool CreateVklad(Vklad p)
        {
            db.Vklads.Add(p);
            return Save();            
        }

        public void UpdateVklad(Vklad p)
        {
            db.Entry(p).State = EntityState.Modified;
        }

        public void CreateProg (Prog prog)
        {
            db.Progs.Add(prog);
            Save();
        }

        public void UpdateProg(Prog o)
        {
            db.Entry(o).State = EntityState.Modified;
        }

        public void DeleteVklad(int id)
        {
            Vklad p = db.Vklads.Find(id);
            if (p != null)
            {
                db.Vklads.Remove(p);
                Save();
            }
        }

        public void DeleteProg(int id)
        {
            Prog o = db.Progs.Find(id);
            if (o != null)
                db.Progs.Remove(o);
        }

        public bool Save()
        {
            if (db.SaveChanges() > 0) return true;
            return false;
        }

       

    }
}
