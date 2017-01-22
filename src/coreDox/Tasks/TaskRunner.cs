using System;
using System.Collections.Generic;

using coreDox.Plugs;
using coreDox.Core.Model;

namespace coreDox
{
    public class TaskRunner
    {
        private readonly Dictionary<string, Action<dynamic>> _registeredTasks = new Dictionary<string, Action<dynamic>>();

        public TaskRunner()
        {
            RegisterBuiltInTasks();
        }

        public void RunTask(string taskName, dynamic plugOptions)
        {
            var task = _registeredTasks[taskName];
            task(plugOptions);
        }

        private void RegisterBuiltInTasks()
        {
            _registeredTasks.Add("new", (opts) => {
                new Package("scaffolds", "*.nupkg")
                    .Plug(new Wizard());
            });

            _registeredTasks.Add("install", (opts) => {
                new Package()
                    .Plug(new Installer(opts.scaffold));
            });
        }
    }
}