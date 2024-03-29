﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using (var context = new RecipeContext())
            {
                context.Remove(t);
                context.SaveChanges();
            }
        }

        public T GetById(int id)
        {
            using (var context = new RecipeContext())
            {
                return context.Set<T>().Find(id);
            }
        }

        public List<T> GetList()
        {
            using (var context = new RecipeContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public void Insert(T t)
        {
            using (var context = new RecipeContext())
            {
                context.Add(t);
                context.SaveChanges();
            }
        }

        public void Update(T t)
        {
            using (var context = new RecipeContext())
            {
                context.Update(t);
                context.SaveChanges();
            }
        }
    }
}
