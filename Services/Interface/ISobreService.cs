using Dominio;
using Services.Models;
using System.Collections.Generic;

namespace Services.Interface
{
    public interface ISobreService
    {
        Sobre ConverterSobreViewModelParaSobre(SobreViewModel sobre);
        void Criar(SobreViewModel viewModel);
        ListarSobresViewModel ListarTodos();
        SobreViewModel ProcurarPorId(int id);
        SobreViewModel ConverterParaViewModel(Sobre sobre);
        void Remover(SobreViewModel viewModel);
        SobreViewModel ProcurarPorStatus(char status);

        void Editar(SobreViewModel viewModel);
    }
}
