namespace ListaDeTarefas.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ListaDeTarefas.Models.TarefasDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ListaDeTarefas.Models.TarefasDb";
        }

        protected override void Seed(ListaDeTarefas.Models.TarefasDb context)
        {
            context.Tarefas.AddOrUpdate(tare => tare.Nome,
                new Models.Tarefas { Nome = "Acordar Cedo", DescricaoTarefa = "Acordar Cedo para Trabalhar", Status = "Feito" },
                new Models.Tarefas { Nome = "Acordar Tarde", DescricaoTarefa = "Acordar Tarde para Trabalhar", Status = "Pendente" },
                new Models.Tarefas { Nome = "Acordar Noite", DescricaoTarefa = "Acordar Noite para Trabalhar", Status = "A Fazer" });

        }
    }
}
