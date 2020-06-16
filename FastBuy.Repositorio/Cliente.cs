using FastBuy.Dominio.Entidades;
using FastBuy.Repositorio.Repositorios;

namespace FastBuy.Repositorio
{
    public class Cliente
    {
        public Cliente()
        {
            var usuarioRepositorio = new UsuarioRepositorio();
            var produto = new Produto();
            var usuario = new Usuario();

            usuarioRepositorio.Adicionar(usuario);

        }
    }
}
