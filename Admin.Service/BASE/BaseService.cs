using Admin.IService;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity:class
    {
        static ConcurrentDictionary<string, List<TEntity>> _data = new ConcurrentDictionary<string, List<TEntity>>();
        protected List<TEntity> GetData()
        {
            var key = typeof(TEntity).FullName;
            if (!_data.ContainsKey(key))
            {
                _data.TryAdd(key, new List<TEntity>());
            }
            return _data[key];
        }

        public virtual async Task<TEntity> Add(TEntity entity)
        {
            GetData().Add(entity);
            return entity;
        }

        public virtual async Task<int> Count(Expression<Func<TEntity, bool>> whereExp = null)
        {
            var q = GetData();
            if (whereExp!=null)
            {
                q = q.Where(whereExp.Compile()).ToList();
            }
            return q.Count; 
        }

        public async Task<bool> Delete(TEntity entity)
        {
            return GetData().Remove(entity);
        }

        public async Task<bool> DeleteByKey(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteByKeys(object[] ids)
        {
            throw new NotImplementedException();
        }

        public async virtual Task<TEntity> Find(object id)
        {
            throw new NotImplementedException();
        }

        public async virtual Task<TEntity> Find(Expression<Func<TEntity, bool>> whereExp)
        {
            throw new NotImplementedException();
        }

        public async virtual Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExp = null)
        {
            var q = GetData();
            if (whereExp != null)
            {
                q = q.Where(whereExp.Compile()).ToList();
            }
            return q;
        }

        public async virtual Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExp, Expression<Func<TEntity, object>> orderByExp)
        {
            var q = GetData();
            if (whereExp != null)
            {
                q = q.Where(whereExp.Compile()).ToList();
            } 
            return q;
        }

        public async virtual Task<List<TEntity>> QueryPage(Expression<Func<TEntity, bool>> whereExp, int intPageIndex = 0, int intPageSize = 20, Expression<Func<TEntity, object>> orderByExp = null)
        {
            throw new NotImplementedException();
        }

        public async virtual Task<bool> Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async virtual Task<bool> Update(TEntity entity, Expression<Func<TEntity, bool>> whereExp)
        {
            throw new NotImplementedException();
        }
    }
}
