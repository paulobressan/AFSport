using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AFSport.Web.Core.Base;
using AFSport.Web.Core.Interface.Repository;
using AFSport.Web.Core.Model;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace AFSport.Web.Core.Repository
{
    public class DashboardRepository : BaseRepository, IDashboardRepository
    {
        public DashboardRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<IEnumerable<Dashboard>> GraficoMovimentacaoMensal()
        {
            var dataInicial = Convert.ToDateTime($"01/{DateTime.Now.Month}/{DateTime.Now.Year}");
            var dataFinal = DateTime.Now;

            return await _context.QueryAsync<Dashboard>(@"select m.data, (select sum(valor) from movimentacao where data = m.data) as valor
                from movimentacao m
                inner join usuario u on m.idUsuario = u.idUsuario
                inner join operacao o on m.idOperacao = o.idOperacao
                where m.data between @dataInicial and @dataFinal group by m.data;", new { dataInicial, dataFinal });
        }
    }
}