using Fatec.Helpers.GitHubObserver.Domain.Models.Routines;
using Fatec.Helpers.GitHubObserver.Domain.Models.Routines.Email;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fatec.Helpers.GitHubObserver.Domain.Models.Factories
{
    class ObserverFactory
    {
        private static List<IRoutine> Routines = new List<IRoutine>();
        public static Observer CreateObserver()
        {
            Observer observer = new Observer();

            ObserverFactory.SetRoutines();

            ObserverFactory.Routines.ForEach(routine =>
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

            ObserverFactory.Routines = new List<IRoutine>(routines);
        }

    }
}
