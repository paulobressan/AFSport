using System.Threading.Tasks;
using AFSport.Web.Core.Model;

namespace AFSport.Web.Core.Interface.Service
{
    public interface IAuthService
    {
        /// <summary>
        /// Autentição do usuário
        /// </summary>
        /// <returns></returns>
        Task<string> Auth(Usuario usuario);
    }
}