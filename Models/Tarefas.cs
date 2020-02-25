using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListaDeTarefas.Models
{
    public class Tarefas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }
        public string DescricaoTarefa { get; set; }
    }
}