using Fatec.Helpers.GitHubObserver.domain.routines;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fatec.Helpers.GitHubObserver.models
{
    class ObserverFactory
    {
        private static List<IRoutine> routines = new List<IRoutine>();
        public static Observer CreateObserver()
        {
            Observer observer = new Observer();

            ObserverFactory.SetRoutines();

            ObserverFactory.routines.ForEach(routine =>
            {
                observer.Register(routine);
            });

            return observer;
        }

        private static void SetRoutines()
        {
            IRoutine[] routines = {
                new SendEmail()
            };

            ObserverFactory.routines = new List<IRoutine>(routines);
        }

    }
}
