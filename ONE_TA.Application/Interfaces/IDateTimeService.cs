using System;
using System.Collections.Generic;
using System.Text;

namespace ONE_TA.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
