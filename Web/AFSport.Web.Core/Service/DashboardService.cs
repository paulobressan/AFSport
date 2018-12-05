using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Core.Interface.Repository;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Service
{
    public class DashboardService
    {
        #region Objetos
        private readonly IMovimentacaoRepository _movimentacaoRepository;
        #endregion

        #region Construtor
        public DashboardService(IMovimentacaoRepository movimentacaoRepository)
        {
            this._movimentacaoRepository = movimentacaoRepository;
        }
        #endregion

        public async Task<List<Dashboard>> GraficoDeMovimentacaoMensal()
        {
            try
            {
                var dataInicial = Convert.ToDateTime($"01/{DateTime.Now.Month}/{DateTime.Now.Year}");
                var movimentações await _movimentacaoRepository.SelecionarPorData(dataInicial, DateTime.Now) ??
                    throw new KeyNotFoundException("Movimentacao não encontrada");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}