using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Fatec.Helpers.GitHubObserver.Domain.Models.Routines
{
    interface IRoutine
    {
        void Execute(dynamic data);
    }
}
