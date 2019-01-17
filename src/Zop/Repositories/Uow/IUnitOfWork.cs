﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Zop.Repositories.Uow
{
    /// <summary>
    /// 表示所有集成于该接口的类型都是Unit Of Work的一种实现。
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// 事务对象
        /// </summary>
        IDbTransaction Transaction { get; }
        /// <summary>
        /// 开始Unit Of Work事务
        /// </summary>
        IDbTransaction Begin();
        /// <summary>
        /// 获得一个<see cref="System.Boolean"/>值，该值表述了当前的Unit Of Work事务是否已被提交。
        /// </summary>
        bool Committed { get; }
        /// <summary>
        /// 提交当前的Unit Of Work事务。
        /// </summary>
        bool Commit();
   
    }
}
