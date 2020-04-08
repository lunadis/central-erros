using CentralErros.Domain.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace CentralErros.Domain.Repositorio
{
    public class UsuarioRepositorio
    {
        //private readonly Contexto _contexto;
        public UsuarioRepositorio()
        {
            //_contexto = new Contexto();
        }

        public void Incluir(Usuario usuario)
        {
            //_contexto.Usuario.Add(usuario);
            //_contexto.SaveChanges();
        }

        public void Alterar(Usuario usuario)
        {
            //_contexto.Usuario.Update(usuario);
            //_contexto.SaveChanges();
        }

        public Usuario SelecionarPorId(int id)
        {
            //return _contexto.Usuario.FirstOrDefault(x => x.Id == id);
        }

        public List<Usuario> SelecionarTodos()
        {
            //return _contexto.Usuario.ToList();
        }

        public void Excluir(int id)
        {
            var usuario = SelecionarPorId(id);
            //_contexto.Usuario.Remove(usuario);
            //_contexto.SaveChanges();
        }
    }
}
