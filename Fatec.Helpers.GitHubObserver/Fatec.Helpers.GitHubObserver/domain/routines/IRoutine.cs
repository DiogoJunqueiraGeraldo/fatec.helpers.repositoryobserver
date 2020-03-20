using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Fatec.Helpers.GitHubObserver.models
{
    interface IRoutine
    {
        void Execute(dynamic data);
    }
}
