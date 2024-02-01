using Ecommerce.models;

namespace Ecommerce.Api.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public static List<Usuario> _db = new List<Usuario>();

        public void Add(Usuario usuario)
        {
            _db.Add(usuario);
        }

        public void Delete(int id)
        {
            _db.Remove(GetById(id));
        }

        public List<Usuario> Get()
        {
            return _db;
        }

        public Usuario GetById(int Id)
        {
            return _db.Find(x => x.Id == Id)!;
        }

        public void Update(Usuario usuario)
        {
            _db.Remove(GetById(usuario.Id));
            _db.Add(usuario);
        }
    }
}
