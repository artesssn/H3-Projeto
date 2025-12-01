public class CursoService : ICursoService
{
    private readonly ICursoRepository _repo;

    public CursoService(ICursoRepository repo)
    {
        _repo = repo;
    }

    public Task<IEnumerable<Curso>> GetAll()
        => _repo.GetAll();

    public Task<Curso> GetById(int id)
        => _repo.GetById(id);

    public async Task<Curso> Add(CursoDTO dto)
    {
        var curso = new Curso
        {
            Nome = dto.Nome,
            CargaHoraria = dto.CargaHoraria
        };

        return await _repo.Add(curso);
    }

    public async Task<Curso> Update(int id, CursoDTO dto)
    {
        var curso = await _repo.GetById(id);
        if (curso == null) return null;

        curso.Nome = dto.Nome;
        curso.CargaHoraria = dto.CargaHoraria;

        return await _repo.Update(curso);
    }

    public Task<bool> Delete(int id)
        => _repo.Delete(id);
}