using Ecommerce.Api.Database;
using Ecommerce.models;

namespace Ecommerce.Api.Repositories
{
    /*Controller> UsuarioRepository
     *Controller> IUsuarioRepository(abstrai) > UsuarioRepository (impelementa IUsuarioRepository)
     *Controller> IUsuarioRepository> UsuarioEFRepository (EF Core)
     *Controller> IUsuarioRepository > UsuarioMockRepository (Testes)
     */
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly EcommerceContext _db;
        public UsuarioRepository(EcommerceContext db)
        {
          _db = db;
        }
        //public static List<Usuario> _db = new List<Usuario>();
        //mudança de parâmetro de lista para contexto, aplicando ao BD

        public void Add(Usuario usuario)
        {
            //repasso o usuário para o banco de dados e salvo
            _db.Usuarios.Add(usuario);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            _db.Usuarios.Remove(GetById(id));
            _db.SaveChanges();
        }

        public List<Usuario> Get()
        {
            return _db.Usuarios.OrderBy( a => a.Id).ToList();
        }

        public Usuario GetById(int Id)
        {
            return _db.Usuarios.Find(Id)!;
        }

        public void Update(Usuario usuario)
        {
            _db.Usuarios.Update(usuario);
            _db.SaveChanges();
        }
    }
}
