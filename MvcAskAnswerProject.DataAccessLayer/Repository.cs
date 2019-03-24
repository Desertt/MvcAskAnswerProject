using MvcAskAnswerProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace MvcAskAnswerProject.DataAccessLayer
{
    public class Repository<T> : RepositoryBase, IData<T> where T : class
    {
        private DbSet<T> _objectSet;

        public Repository()
        {
            _objectSet = context.Set<T>();
        }

        public int Delete(T obj)
        {
            _objectSet.Remove(obj);
            return Save();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _objectSet.FirstOrDefault(where);

        }

        public int Insert(T obj)
        {
            EntityBase entity = obj as EntityBase;
            DateTime simdi = DateTime.Now;
            entity.DuzenlemeTarihi = simdi;
            entity.EklemeTarihi = simdi;
            _objectSet.Add(obj);
            return Save();
        }

        public List<T> List()
        {
            return _objectSet.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> where)
        {
            return _objectSet.Where(where).ToList();
        }

        public int Save()
        {
            return context.SaveChanges();
        }

        public int Update(T obj)
        {
            EntityBase entity = obj as EntityBase;
            DateTime simdi = DateTime.Now;
            entity.DuzenlemeTarihi = simdi;
            return Save();
        }
    }
}
