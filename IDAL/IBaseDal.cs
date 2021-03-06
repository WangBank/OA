﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public  interface IBaseDal<T> where T:class,new ()
    {
        IQueryable<T> GetEntities(Expression<Func<T, bool>> whereLambda);
        /// <summary>
        /// 分页的方法
        /// </summary>
        /// <typeparam name="S"></typeparam>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="total"></param>
        /// <param name="whereLambda"></param>
        /// <param name="orderLambda"></param>
        /// <param name="isAsc"></param>
        /// <returns></returns>
        IQueryable<T> GetPageEntities<S>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> orderLambda, bool isAsc);

        T Add(T u);

        T Edit(T u);

        bool Delete(T u);

        /// <summary>
        /// 加一个约束
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);

        int DeleteListByLogical(List<int> ids);
    }
}
