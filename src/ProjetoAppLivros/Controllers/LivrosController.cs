using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoAppLivros.Context;
using ProjetoAppLivros.Models;

namespace ProjetoAppLivros.Controllers
{
    /// <summary>
    /// Controlador responsável pelas actions referentes a entidade Livro.
    /// </summary>
    public class LivrosController : Controller
    {
        /// <value>Propriedade de referência para o DbContext.</value>
        private readonly ProjetoAppLivrosDbContext _context;

        /// <summary>
        /// Construtor sobrescrito para a inicialização do DbContext.
        /// </summary>
        /// <param name="context">Parâmtro referente ao DbContex.</param>
        public LivrosController(ProjetoAppLivrosDbContext context)
        {
            _context = context;
        }

        
        /// <summary>
        /// Action responsável pela listagem dos livros cadastrados.
        /// </summary>
        /// <returns>View com lista de livros inseridos.</returns>
        public async Task<IActionResult> Index(string titulo)
        {
            var livros = from l in _context.Livros select l;

            if(!String.IsNullOrEmpty(titulo))
            {
                livros = livros.Where(l => l.Titulo.Contains(titulo));
            }

            return View(await livros.ToListAsync());
        }

        /// <summary>
        /// Action responsável pela exibição dos detalhes de um livro.
        /// </summary>
        /// <param name="id">Identifica o registro a ser detalhado.</param>
        /// <returns>View com com detalhes de livro.</returns>
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = await _context.Livros
                .FirstOrDefaultAsync(m => m.Id == id);
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        /// <summary>
        /// Action responsável por direcionar registro do livro inserido.
        /// </summary>
        /// <returns>View com lista de livros.</returns>
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Action responsável pela criação de novos registros dos livros.
        /// </summary>
        /// <returns>View com novo registro criado na lista de livros.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,Autor,Genero,Lancamento,Editora")] Livro livro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(livro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(livro);
        }

        /// <summary>
        /// Action responsável por direcionar registro do livro editado.
        /// </summary>
        /// <param name="id">Identifica o registro a ser editado.</param>
        /// <returns>View atualizada com lista de livros.</returns>
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = await _context.Livros.FindAsync(id);
            if (livro == null)
            {
                return NotFound();
            }
            return View(livro);
        }

        /// <summary>
        /// Action responsável pela edição de registro do livro.
        /// </summary>
        /// <param name="id">Usado para referenciar a entidade Livro.</param>
        /// <returns>View com registro editado na lista de livros.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Autor,Genero,Lancamento,Editora")] Livro livro)
        {
            if (id != livro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(livro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LivroExists(livro.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(livro);
        }

        /// <summary>
        /// Action responsável pela exclusão de livro.
        /// </summary>
        /// <param name="id">Identifica o registro a ser excluído.</param>
        /// <returns>View com registro da lista de livros.</returns>
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = await _context.Livros
                .FirstOrDefaultAsync(m => m.Id == id);
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        /// <summary>
        /// Action responsável pela confirmação da exclusão de livro.
        /// </summary>
        /// <param name="id">Identifica o registro a ser confirmada a exclusão.</param>
        /// <returns>View atualizada com lista de livros após a exclusão.</returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var livro = await _context.Livros.FindAsync(id);
            _context.Livros.Remove(livro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Action responsável verificar se registro de livro existe.
        /// </summary>
        /// <param name="id">Parâmetro de pesquisa do livro.</param>
        /// <returns>Registro do livro.</returns>
        private bool LivroExists(int id)
        {
            return _context.Livros.Any(e => e.Id == id);
        }
    }
}
