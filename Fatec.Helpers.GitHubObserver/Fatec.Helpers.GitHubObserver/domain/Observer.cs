using System;
using System.Collections.Generic;
using System.Text;

namespace Fatec.Helpers.GitHubObserver.models
{
    class Observer
    {
        public List<IRoutine> Routines { get; set; }

        public Observer()
        {
            this.Routines = new List<IRoutine>();
        }
        public void Register(IRoutine routine)
        {
            this.Routines.Add(routine);
        }

        public void NotifyAll(dynamic data)
        {
            this.Routines.ForEach(routine =>
            {
                routine.Execute(data);
            });
        }
    }
}
