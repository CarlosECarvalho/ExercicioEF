using Ecommerce.models;

namespace Ecommerce.Api.Repositories
{
    public interface IUsuarioRepository
    {
        List<Usuario> Get();
        Usuario GetById(int Id);
        void Add(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(int id);
    }
}
