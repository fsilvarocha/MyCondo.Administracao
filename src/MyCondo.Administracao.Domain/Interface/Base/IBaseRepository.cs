﻿namespace MyCondo.Administracao.Domain.Interface.Base;

public interface IBaseRepository<T> where T : class
{
    Task<T?> GetByIdTenanteAsync(T entity);
    Task<T?> GetByTenanteAsync(T entity);
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}
