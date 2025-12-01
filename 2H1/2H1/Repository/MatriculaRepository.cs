using Microsoft.EntityFrameworkCore;

public class MatriculaRepository : IMatriculaRepository
{
    private readonly AppDbContext _context;

    public MatriculaRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Matricula>> GetAll()
    {
        return await _context.Matriculas
            .Include(m => m.Curso)
            .ToListAsync();
    }

    public async Task<Matricula> Add(Matricula matricula)
    {
        _context.Matriculas.Add(matricula);
        await _context.SaveChangesAsync();
        return matricula;
    }
}