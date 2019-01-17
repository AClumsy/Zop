﻿using Orleans;
using Orleans.Runtime;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Zop.Domain.Entities;

namespace Zop.Application.Services
{

    /// <summary>
    /// 这个类可以用作应用程序服务的基类
    /// </summary>
    public class ApplicationService : Grain, IApplicationService
    {

    }

    /// <summary>
    /// 这个类可以用作应用程序服务的基类
    /// </summary>
    public class ApplicationService<TState> : Grain<TState>, IApplicationServiceGrain<TState> where TState : class, IEntity, new()
    {
        ///<inheritdoc/>
        public Task<TState> ReadAsync()
        {
            return Task.FromResult(base.State);
        }
        ///<inheritdoc/>
        public Task ClearAsync()
        {
            base.ClearStateAsync();
            return Task.CompletedTask;
        }
        ///<inheritdoc/>
        public Task WriteAsync(TState state)
        {
            base.State = state;
            return base.WriteStateAsync();
        }
    }

}
