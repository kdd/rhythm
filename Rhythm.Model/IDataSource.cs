using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rhythm.Model
{
    public interface IDataSource
    {
        IEnumerable<HeartRate> GetHeartRate();
        IEnumerable<BreathingRate> GetBreathingRate();
    }
}
