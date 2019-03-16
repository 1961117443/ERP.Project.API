using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Admin.IService
{
    /// <summary>
    /// 服务层基类
    /// 实现一些基本的增删改查
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IBaseService<TEntity> where TEntity:class
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TEntity> Add(TEntity entity);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        Task<bool> Update(TEntity entity);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="whereExp">过滤条件</param>
        /// <returns></returns>
        Task<bool> Update(TEntity entity, Expression<Func<TEntity, bool>> whereExp);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        Task<bool> Delete(TEntity entity);
        /// <summary>
        /// 根据主键删除数据
        /// </summary>
        /// <param name="id">主键值</param>
        /// <returns></returns>
        Task<bool> DeleteByKey(object id);
        /// <summary>
        /// 根据一组主键，删除数据
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<bool> DeleteByKeys(object[] ids);
        /// <summary>
        /// 获取记录数
        /// </summary>
        /// <param name="whereExp">过滤条件</param>
        /// <returns></returns>
        Task<int> Count(Expression<Func<TEntity, bool>> whereExp = null);
        /// <summary>
        /// 获取单个实体对象
        /// </summary>
        /// <param name="id">主键值</param>
        /// <returns></returns>
        Task<TEntity> Find(object id);
        /// <summary>
        /// 获取单个实体对象
        /// </summary>
        /// <param name="whereExp">过滤条件</param>
        /// <returns></returns>
        Task<TEntity> Find(Expression<Func<TEntity, bool>> whereExp);
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="whereExp">过滤条件</param>
        /// <returns></returns>
        Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExp=null);
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="whereExp">过滤条件</param>
        /// <param name="orderByExp">排序字段</param>
        /// <returns></returns>
        Task<List<TEntity>> Query(Expression<Func<TEntity, bool>> whereExp, Expression<Func<TEntity, object>> orderByExp);
        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="whereExp">过滤条件</param>
        /// <param name="intPageIndex">页码</param>
        /// <param name="intPageSize">页大小</param>
        /// <param name="orderByExp">排序条件</param>
        /// <returns></returns>
        Task<List<TEntity>> QueryPage(Expression<Func<TEntity, bool>> whereExp, int intPageIndex = 0, int intPageSize = 20, Expression<Func<TEntity, object>> orderByExp = null);

    }
}
