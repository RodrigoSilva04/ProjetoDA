﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Cantina.Controllers
{
    using Cantina;
    using GereCantina.Models;

    public class FuncionárioController
    {
        //CRUD
        //Criar a parte de adicionar, remover, atualizar e listar funcionários
        //Adicionar
        public void AdicionarFuncionário(Funcionario funcionário)
        {
            using (var db = new CantinaContext())
            {
                db.Funcionarios.Add(funcionário);
                db.SaveChanges();
            }
        }
        //Remover
        public void RemoverFuncionário(Funcionario funcionario)
        {
            using (var context = new CantinaContext())
            {
                context.Entry(funcionario).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        //Atualizar
        public void AtualizarFuncionário(Funcionario funcionario)
        {
            using (var context = new CantinaContext())
            {
                context.Entry(funcionario).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        //Listar
        public List<Funcionario> ListarFuncionários()
        {
            using (var context = new CantinaContext())
            {
                return context.Funcionarios.ToList();
            }
        }

        //função para buscar funcionário por nome
        public Funcionario BuscarFuncionarioPorNome(string nome)
        {
            using (var context = new CantinaContext())
            {
                return context.Funcionarios.FirstOrDefault(f => f.Nome == nome);
            }
        }
    }
}
