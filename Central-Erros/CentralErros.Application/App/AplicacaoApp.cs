using System.Collections.Generic;
using AutoMapper;
using CentralErros.Application.Interface;
using CentralErros.Application.ViewModel;
using CentralErros.Domain.Interfaces;
using CentralErros.Domain.Models;

namespace CentralErros.Application
{
    public class AplicacaoApp : IAplicacaoApp
    {
        private readonly IAplicacaoRepositorio _repo;
        private readonly IMapper _mapper;

        public AplicacaoApp(IAplicacaoRepositorio repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Alterar(AplicacaoViewModel entity)
        {
            _repo.Alterar(_mapper.Map<Aplicacao>(entity));
        }

        public void Deletar(int id)
        {
            _repo.Deletar(id);
        }

        public void Incluir(AplicacaoViewModel entity)
        {
            _repo.Incluir(_mapper.Map<Aplicacao>(entity));
        }

        public IEnumerable<AplicacaoViewModel> ListarTodos()
        {
            return _mapper.Map<IEnumerable<AplicacaoViewModel>>(_repo.ListarTodos());
        }

        public AplicacaoViewModel Selecionar(int id)
        {
            return _mapper.Map<AplicacaoViewModel>(_repo.Selecionar(id));
        }
    }
}