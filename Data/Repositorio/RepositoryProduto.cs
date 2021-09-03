using Data.Entidades;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositorio
{
    public class RepositoryProduto : RepositoryGenerics<Produto>, IProduto
    {
    }
}
