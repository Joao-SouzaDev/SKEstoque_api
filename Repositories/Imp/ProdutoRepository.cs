using Microsoft.EntityFrameworkCore;
using SKEstoqueAPI.Data;
using SKEstoqueAPI.Data.Models;
using SKEstoqueAPI.Repositories.Interfaces;

namespace SKEstoqueAPI.Repositories.Imp
{
    public class ProdutoRepository : IProdutoRepository
    {
        private SKEstoqueContext _context;
        public ProdutoRepository(SKEstoqueContext sKEstoqueContext)
        {
            _context = sKEstoqueContext;
        }

        public async Task AddAsync(Produto produto)
        {
            await _context.AddAsync(produto);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            await _context.Produtos.Where(p => p.Id == id).ExecuteDeleteAsync();
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Produto>> GetAllAsync()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<Produto?> GetByIdAsync(int id)
        {
           return await _context.Produtos.FindAsync(id);
        }

        public async Task UpdateAsync(Produto produto)
        {
            _context.Produtos.Update(produto);
            await _context.SaveChangesAsync();
        }
    }
}
