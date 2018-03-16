﻿using Kajal.DB;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kajal.Service
{
    public class BaseService<T> : IBaseService<T> where T : class, IBaseEntity<T>
    {
        public T GetById(int Id)
        {
            using (Context c = new Context())
            {
                return c.GetTable<T>().Where(m => m.Id == Id).FirstOrDefault();
            }
        }

        public IEnumerable<T> GetAll()
        {
            using (Context c = new Context())
            {
                return c.GetTable<T>().OrderBy(s => s.Id).ToList();
            }
        }

        public IEnumerable<T> GetAllActive()
        {
            using (Context c = new Context())
            {
                return c.GetTable<T>().Where(m => m.IsDeleted == false && m.IsActive == true).OrderBy(s => s.Id).ToList();
            }
        }

        public int Save(T entity, bool IsActive = true)
        {
            using (Context c = new Context())
            {
                if (entity.Id == 0)
                {
                    entity.CreateDate = DateTime.Now;
                    entity.IsActive = IsActive;
                    entity.IsDeleted = false;
                    c.GetTable<T>().Add(entity);
                }
                else
                {
                    c.Entry<T>(entity).State = System.Data.Entity.EntityState.Modified;
                }
                return c.SaveChanges();
            }
        }

        public int SaveAsNotActive(T entity)
        {
            return Save(entity, false);
        }

        public void DeleteById(int Id)
        {
            using (Context c = new Context())
            {
                var entity = GetById(Id);
                if (entity != null && entity.Id > 0)
                {
                    entity.IsDeleted = true;
                    ChangeEntityState(entity, System.Data.Entity.EntityState.Modified);
                    Save(c);
                }
            }
        }

        private void ChangeEntityState(T entity, System.Data.Entity.EntityState State)
        {
            Context c = new Context();
            var set = c.Set<T>();
            T attachedEntity = set.Find(entity.Id);

            if (attachedEntity != null)
            {
                var attachedEntry = c.Entry(attachedEntity);
                attachedEntry.CurrentValues.SetValues(entity);
                attachedEntry.State = State;
            }
            else
            {
                c.Entry<T>(entity).State = State;
            }
        }

        private int Save(Context c)
        {
            try
            {
                return c.SaveChanges();
            }
            catch { return -1; }
        }

        public T ParseJsonObject<T>(string json) where T : class, new()
        {
            JObject jObject = JObject.Parse(json);
            return JsonConvert.DeserializeObject<T>(jObject.ToString());
        }
    }
}