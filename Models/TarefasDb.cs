using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ListaDeTarefas.Models
{
    public class TarefasDb : DbContext
    {
        public DbSet<Tarefas> Tarefas { get; set; }
    }
}