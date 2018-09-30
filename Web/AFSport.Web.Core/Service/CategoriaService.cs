using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFSport.Web.Core.Interface.Repository;
using AFSport.Web.Core.Interface.Service;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Service
{
    public class CategoriaService : ICategoriaService
    {
        #region Objetos
        private readonly ICategoriaRepository _categoriaRepository;
        #endregion
        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public async Task<Categoria> Alterar(int id, Categoria categoria)
        {
            try
            {
                await SelecionarId(id);
                return await _categoriaRepository.Alterar(categoria);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Categoria> Inserir(Categoria categoria)
        {
            try
            {
                return await _categoriaRepository.Inserir(categoria);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Remover(int id)
        {
            try
            {
                var categoria = await SelecionarId(id);
                await _categoriaRepository.Remover(categoria);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Categoria> SelecionarId(int id)
        {
            try
            {
                return await _categoriaRepository.SelecionarId(id) ??
                    throw new KeyNotFoundException("Categoria não encontrada");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Categoria>> SelecionarTodos()
        {
            try
            {
                return (await _categoriaRepository.SelecionarTodos())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Categoria>> SelecionarTodosAtivo()
        {
            try
            {
                return (await _categoriaRepository.SelecionarTodosAtivo())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Categoria>> SelecionarTodosInativo()
        {
            try
            {
                return (await _categoriaRepository.SelecionarTodosInativo())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> TotalRegistros()
        {
            try
            {
                return await _categoriaRepository.TotalRegistros();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}