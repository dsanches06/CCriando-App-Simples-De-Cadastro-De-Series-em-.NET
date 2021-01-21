using DIO.Series.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Series.Model
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSeriie = new List<Serie>();

        public List<Serie> Listar()
        {
            return null;
        }

        public Serie RetornaPorId(int id)
        {
            return null;
        }

        public void inserir(Serie entidade)
        {

        }

        public void Excluir(int id)
        {

        }

        public void Atualizar(int id, Serie entidade)
        {
        }

        public int ProximoId()
        {
            return 0;
        }
    }
}
