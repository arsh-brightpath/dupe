using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace project56.EntityFramework.Repositories
{
    /// <summary>
    /// Base class for custom repositories of the application.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class project56RepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<project56DbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected project56RepositoryBase(IDbContextProvider<project56DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add your common methods for all repositories
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="project56RepositoryBase{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class project56RepositoryBase<TEntity> : project56RepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected project56RepositoryBase(IDbContextProvider<project56DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)!!!
    }
}
