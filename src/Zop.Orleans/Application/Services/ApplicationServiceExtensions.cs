﻿using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using Zop.Domain.Entities;

namespace Zop.Application.Services
{
    /// <summary>
    /// 应用服务扩展类
    /// </summary>
    public static class ApplicationServiceExtensions
    {
        /// <summary>
        /// 获取有状态的Grain
        /// </summary>
        /// <typeparam name="TState">状态类型</typeparam>
        /// <param name="grainFactory"><see cref="IGrainFactory"/></param>
        /// <param name="primaryKey">Grain primaryKey</param>
        /// <returns></returns>
        public static IApplicationService<TState> GetStateGrain<TState>(this IGrainFactory grainFactory, long primaryKey) where TState : class, IEntity, new()
        {
            return grainFactory.GetGrain<IApplicationServiceGrain<TState>>(primaryKey);
        }
        /// <summary>
        /// 获取有状态的Grain
        /// </summary>
        /// <typeparam name="TState">状态类型</typeparam>
        /// <param name="grainFactory"><see cref="IGrainFactory"/></param>
        /// <param name="primaryKey">Grain primaryKey</param>
        /// <returns></returns>
        public static IApplicationService<TState> GetStateGrain<TState>(this IGrainFactory grainFactory, Guid primaryKey) where TState : class,IEntity, new()
        {
            return grainFactory.GetGrain<IApplicationServiceGrain<TState>>(primaryKey);
        }
        /// <summary>
        /// 获取有状态的Grain
        /// </summary>
        /// <typeparam name="TState">状态类型</typeparam>
        /// <param name="grainFactory"><see cref="IGrainFactory"/></param>
        /// <param name="primaryKey">Grain primaryKey</param>
        /// <returns></returns>
        public static IApplicationService<TState> GetStateGrain<TState>(this IGrainFactory grainFactory, string primaryKey) where TState : class, IEntity, new()
        {
            return grainFactory.GetGrain<IApplicationServiceGrain<TState>>(primaryKey);
        }
        /// <summary>
        /// 获取有状态的Grain 默认使用Guid
        /// </summary>
        /// <typeparam name="TState">状态类型</typeparam>
        /// <param name="grainFactory"><see cref="IGrainFactory"/></param>
        /// <returns></returns>
        public static IApplicationService GetStateGrain<TState>(this IGrainFactory grainFactory) where TState : class, IEntity, new()
        {
            return grainFactory.GetStateGrain<TState>(Guid.NewGuid());
        }

        /// <summary>
        /// 获取有状态的Grain
        /// </summary>
        /// <typeparam name="TState">状态类型</typeparam>
        /// <param name="grainFactory"><see cref="IGrainFactory"/></param>
        /// <param name="primaryKey">Grain primaryKey</param>
        /// <returns></returns>
        public static IMemoryCacheService GetCacheGrain(this IGrainFactory grainFactory)
        {
            return grainFactory.GetGrain<IMemoryCacheService>(Guid.NewGuid());
        }
       

    }
}
