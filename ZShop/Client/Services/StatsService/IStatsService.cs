using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZShop.Client.Services.StatsService
{
    public interface IStatsService
    {
        Task GetVisits();
        Task IncrementVisits();
    }
}
