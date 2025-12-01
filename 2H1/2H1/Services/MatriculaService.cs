public class MatriculaService : IMatriculaService
{
    private readonly IMatriculaRepository _repo;

    public MatriculaService(IMatriculaRepository repo)
    {
        _repo = repo;
    }

    public Task<IEnumerable<Matricula>> GetAll()
        => _repo.GetAll();

    public async Task<Matricula> Add(MatriculaDTO dto)
    {
        var matricula = new Matricula
        {
            IdCurso = dto.IdCurso,
            NomeAluno = dto.NomeAluno
        };

        return await _repo.Add(matricula);
    }
}