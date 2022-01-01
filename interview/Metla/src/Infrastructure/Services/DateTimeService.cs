using Metla.Application.Common.Interfaces;
using System;

namespace Metla.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
