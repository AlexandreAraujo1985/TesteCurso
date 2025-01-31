﻿using System.Collections.Generic;

namespace CursosResource.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TClass> where TClass : class
    {
        IEnumerable<TClass> PesquisarTodos();
        TClass Pesquisar(int id);
        void Incluir(TClass obj);
        void Alterar(TClass obj);
        void Deletar(TClass obj);
    }
}
