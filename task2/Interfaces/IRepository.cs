using task2.Model;
using System.Collections.Generic;

namespace task2.Interfaces
{
  public interface IRepository<TEntity>
    where TEntity : BaseEntity
  {
    IEnumerable<TEntity> GetAll();
    TEntity Get(int id);
    void Create(TEntity item);
  }
}
