using AutoMapper;
using CentralErros.Application.Interface;
using CentralErros.Application.ViewModel;
using CentralErros.Domain.Interfaces;
using CentralErros.Domain.Models;
using System.Collections.Generic;

namespace CentralErros.Application.App
{
    public class UsuarioApp : IUsuarioApp
    {
        private readonly IUsuarioRepositorio _repo;
        private readonly IMapper _mapper;

        public UsuarioApp(IUsuarioRepositorio repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Alterar(UsuarioViewModel entity)
        {
            _repo.Alterar(_mapper.Map<Usuario>(entity));
        }

        public void Deletar(int id)
        {
            _repo.Deletar(id);
        }

        public void Incluir(UsuarioViewModel entity)
        {
            _repo.Incluir(_mapper.Map<Usuario>(entity));
        }

        public IEnumerable<UsuarioViewModel> ListarTodos()
        {
            return _mapper.Map<IEnumerable<UsuarioViewModel>>(_repo.ListarTodos());
        }

        public UsuarioViewModel Selecionar(int id)
        {
            return _mapper.Map<UsuarioViewModel>(_repo.Selecionar(id));
        }
    }
}