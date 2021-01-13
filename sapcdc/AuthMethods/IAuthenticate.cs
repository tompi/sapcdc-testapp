using System.Threading.Tasks;

namespace sapcdc.AuthMethods
{
    public interface IAuthenticate
    {
        Task<string> GetToken();
    }
}