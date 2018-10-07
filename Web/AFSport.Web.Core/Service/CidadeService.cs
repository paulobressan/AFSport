using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFSport.Web.Core.Interface.Repository;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Service
{
    public class CidadeService : ICidadeService
    {
        #region Objetos
        private readonly ICidadeRepository _cidadeRepository;
        #endregion

        #region Construtor
        public CidadeService(ICidadeRepository cidadeRepository)
        {
            this._cidadeRepository = cidadeRepository;
        }
        #endregion
        public Task<Cidade> Alterar(int idCategoria, Cidade cidade)
        {
            throw new System.NotImplementedException();
        }

        public Task<Cidade> Inserir(Cidade cidade)
        {
            throw new System.NotImplementedException();
        }

        public Task Remover(int idCidade)
        {
            throw new System.NotImplementedException();
        }

        public Task<Cidade> SelecionarId(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IList<Cidade>> SelecionarTodos()
        {
            try
            {
                return (await _cidadeRepository.SelecionarTodos())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<IList<Cidade>> SelecionarTodosAtivos()
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Cidade>> SelecionarTodosInativos()
        {
            throw new System.NotImplementedException();
        }

        public Task<int> TotalRegistros()
        {
            throw new System.NotImplementedException();
        }
    }
}