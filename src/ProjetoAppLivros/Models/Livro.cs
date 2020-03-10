using System;
using System.ComponentModel.DataAnnotations;

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
        [Display(Name = "Título")]
        [Required]
        public string Titulo { get; set; }
        
        /// <value>Propriedade responsável por informar o autor.</value>
        [Display(Name = "Autor")]
        [Required]
        public string Autor { get; set; }
        
        /// <value>Propriedade responsável por informar o gênero.</value>
        [Display(Name = "Gênero")]
        [Required]
        public string Genero { get; set; }

        /// <value>Propriedade responsável por atribuir a data de lançamento.</value>
        [Display(Name = "Ano de Lançamento")]
        [Required]
        public DateTime Lancamento { get; set; }

        /// <value>Propriedade responsável por informar o gênero do livro</value>
        [Display(Name = "Editora")]
        [Required]
        public string Editora { get; set; }
    }
}