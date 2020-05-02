using System.Collections.Generic;
using AutoMapper;
using CentralErros.Application.Interface;
using CentralErros.Application.ViewModel;
using CentralErros.Domain.Interfaces;
using CentralErros.Domain.Models;

namespace CentralErros.Application.App
{
    public class TipoLogApp : ITipoLogApp
    {

        private readonly ITipoLogRepositorio _repo;
        private readonly IMapper _mapper;

        public TipoLogApp(ITipoLogRepositorio repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Alterar(TipoLogViewModel entity)
        {
            _repo.Alterar(_mapper.Map<TipoLog>(entity));
        }

        public void Deletar(int id)
        {
            _repo.Deletar(id);
        }

        public void Incluir(TipoLogViewModel entity)
        {
            _repo.Incluir(_mapper.Map<TipoLog>(entity));
        }

        public IEnumerable<TipoLogViewModel> ListarTodos()
        {
            return _mapper.Map<IEnumerable<TipoLogViewModel>>(_repo.ListarTodos());
        }

        public TipoLogViewModel Selecionar(int id)
        {
            return _mapper.Map<TipoLogViewModel>(_repo.Selecionar(id));
        }
    }
}
