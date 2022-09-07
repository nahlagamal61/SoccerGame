namespace BaseLibrary.UnitOfWorks
{
    using BaseLibrary.BaseEntities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;

    public interface IBaseUnitOfWork<T> where T : BaseEntity
    {
        Task<List<T>> ReadAsync();
        Task<T> ReadByIdAsync(Guid Id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(Guid id);
    }
}
