using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public interface IBase
    {
        int Key { get; }
        void Salvar();
        void Excluir();
        //busca todos
        List<IBase> Todos();
        //busca todos com where usando o atirbuto q esta preenchido com chave primaria
        List<IBase> Busca();
    }
}
