public interface ICursoRepository
{
    Task<IEnumerable<Curso>> GetAll();
    Task<Curso> GetById(int id);
    Task<Curso> Add(Curso curso);
    Task<Curso> Update(Curso curso);
    Task<bool> Delete(int id);
}