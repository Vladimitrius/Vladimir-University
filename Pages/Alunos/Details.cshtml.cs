using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VladimirUniversity.Data;
using VladimirUniversity.Models;

namespace VladimirUniversity.Pages.Alunos
{
    public class DetailsModel : PageModel
    {
        private readonly VladimirUniversity.Data.UniversidadeContext _context;

        public DetailsModel(VladimirUniversity.Data.UniversidadeContext context)
        {
            _context = context;
        }

        public Aluno Aluno { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Aluno = await _context.Aluno.SingleOrDefaultAsync(m => m.Id == id);

            if (Aluno == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
