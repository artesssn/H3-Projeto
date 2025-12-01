public interface IMatriculaRepository
{
    Task<IEnumerable<Matricula>> GetAll();
    Task<Matricula> Add(Matricula matricula);
}