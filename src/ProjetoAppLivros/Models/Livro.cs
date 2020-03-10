using System;

namespace ProjetoAppLivros.Models
{
    /// <summary>
    /// Classe responsável por representar a entidade de modelo Livro.
    /// </summary>
    public class Livro
    {
        /// <value>Propriedade responsável por representar o id.</value>
        public int Id { get; set; }

        /// <value>Propriedade responsável por atribuir o título.</value>
        public string Titulo { get; set; }

        /// <value>Propriedade responsável por informar o gênero.</value>
        public string Genero { get; set; }

        /// <value>Propriedade responsável por atribuir a data de lançamento.</value>
        public DateTime Lancamento { get; set; }

        /// <value>Propriedade responsável por informar o gênero do livro</value>
        public string Editora { get; set; }
    }
}