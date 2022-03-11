using System;
using System.Collections.Generic;
using homework.Models;

namespace homework.Views
{
    public interface IMainView
    {
        EventHandler<EventArgs> GetFuels { get; set; }
        List<Fuel> Fuels { set; }
    }
}
