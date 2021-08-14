using prjetolocal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace prjetolocal.Context
{
    public class ContextProd : DbContext
    {
        public DbSet<Producao> producao { get; set; }
        public ContextProd():base("BancoProd")
        {

        }
    }
}