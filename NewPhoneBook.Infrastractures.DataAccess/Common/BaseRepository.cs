﻿using NewPhoneBook.Core.Contracts.Common;
using PhoneBook.Domain.Core;
using PhoneBook.Infrastructures.DataLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewPhoneBook.Infrastractures.DataAccess.Common
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
 where TEntity : BaseEntity, new()
    {
        private readonly PhoneBookContext dbContext;

    

        protected BaseRepository(PhoneBookContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public TEntity Add(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity);
            dbContext.SaveChanges();

            return entity;
        }

        public void Delete(int id)
        {
            TEntity entity = new TEntity
            {
                Id = id
            };
            dbContext.Remove(entity);
            dbContext.SaveChanges();
        }

        public TEntity Get(int id)
        {
            return dbContext.Set<TEntity>().Find(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return dbContext.Set<TEntity>().AsQueryable();

        }
    }
}
