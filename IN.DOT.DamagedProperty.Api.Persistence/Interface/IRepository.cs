using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using IN.DOT.DamagedProperty.Api.Domain.Model;

namespace IN.DOT.DamagedProperty.Api.Persistence.Interface
{
    public interface IRepository<T>
    {

        #region CRUD Operations
        
        // CRUD Operations
        void Save(T p);

        void SaveNoCommit(T p);

        void Delete(T p);

        void DeleteNoCommit(T p);

        void Commit();
        T GetById(object id);

        #endregion

        #region " Methods "


        T Create(T entity);

        void Delete(int id);

        IList<T> Get();

        IList<T> Get(Func<T, bool> predicate);

        T Update(int id, T entity);

        #endregion


        #region Search Operations

        IQueryable<T> GetWhere(Expression<Func<T, bool>> exp);
        IQueryable<TT> GetWhere<TT>(Expression<Func<TT, bool>> exp);
        T Get(object id);


        #endregion


    }
}