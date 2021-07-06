using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel.DataAcces.Repository
{
    //repository implémente les méthodes CRUD (Create / Read / Update/Delete)
    public class Repository
    {
        static object lockobj = new object();

        //methode Create du CRUD
        public void Insert<T>(T entity) where T : class
        {
            lock (lockobj)
            {
                using (var dbctx = new MediathequeDbContext())
                {
                    dbctx.Set<T>().Add(entity);
                    dbctx.SaveChanges();
                }
            }
        }

        public void InsertRange<T>(IEnumerable<T> entity) where T : class
        {
            lock (lockobj)
            {
                using var _dbctx = new MediathequeDbContext();
                _dbctx.Set<T>().AddRange(entity);
                _dbctx.SaveChanges();
            }
        }

        //methode d'update du CRUD
        public void Update<T>(T entity) where T : class
        {
            lock (lockobj)
            {
                using var _dbctx = new MediathequeDbContext();
                _dbctx.Set<T>().Update(entity);
                _dbctx.SaveChanges();
            }
        }

        public void UpdateRange<T>(T[] entities) where T : class
        {
            lock (lockobj)
            {
                using var _dbctx = new MediathequeDbContext();
                _dbctx.Set<T>().UpdateRange(entities);
                _dbctx.SaveChanges();
            }
        }

        //methode de delete du CRUD
        public void Delete<T>(T entity) where T : class
        {
            lock (lockobj)
            {
                using var _dbctx = new MediathequeDbContext();
                _dbctx.Set<T>().Remove(entity);
                _dbctx.SaveChanges();
            }
        }

        public void DeleteRange<T>(T[] entities) where T : class
        {
            lock (lockobj)
            {
                using var _dbctx = new MediathequeDbContext();
                _dbctx.Set<T>().RemoveRange(entities);
                _dbctx.SaveChanges();
            }
        }

        //methode de read du CRUD
        public List<T> GetAll<T>() where T : class
        {
            lock (lockobj)
            {
                using var _dbctx = new MediathequeDbContext();
                return _dbctx.Set<T>().ToList();
            }
        }

        public T GetById<T>(int id) where T : class
        {
            lock (lockobj)
            {
                using var _dbctx = new MediathequeDbContext();
                return _dbctx.Set<T>().Find(id);
            }
        }
    }
}
