using prjetolocal.Context;
using prjetolocal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjetolocal.Repository
{
    public class CrudProd
    {
        public void Create(Producao model)
        {
            using (var context = new ContextProd())
            {
                context.producao.Add(model);
                context.SaveChanges();
            }
        }
        public List<Producao> Read()
        {
            List<Producao> Lista = new List<Producao>();
            using (var context = new ContextProd())
            {
                Lista = context.producao.ToList();
            }
            return Lista;
        }
        public Producao Read(int id)
        {
            Producao model = new Producao();
            using (var context = new ContextProd())
            {
                model = context.producao.Find(id);
            }
            return model;
        }
        
        public void Update(Producao model)
        {
            using (var context = new ContextProd())
            {
                context.Entry<Producao>(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
           
        }
        public void Delete(int id)
        {
            using (var context = new ContextProd())
            {
                context.Entry<Producao>(this.Read(id)).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public Producao Details(int id)
        {
            Producao model = new Producao();
            using (var context = new ContextProd())
            {
                model = context.producao.Find(id);
            }
            return model;
        }
    }
}