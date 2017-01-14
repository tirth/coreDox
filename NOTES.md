coreDox
---
CLI to use coreDox.  
Uses *CommandLineParser* to parse the commandline arguments and to provide the usage 
of verbs.

Available core verbs:
- **new** *starts a wizard to create a new coreDox project*
- **build** *builds a coreDox project in the current path or a given one*
- **watch** *builds a coreDox project in the current path or a given one and autmatically refreshes the output on change of a project file*

coreDox.Model
---
Contains the whole model of coreDox. This includes the parsed tree objects.

coreDox.Contracts
---
This project contains all interfaces used within coreDox.  
The project can easily be referenced to create custom directives or verb for coreDox.

coreDox.Verb.New
---
This project contains the logic of the **new** verb.
If the **new** verb is used, the **coreDox.Verb.New.Wizard** is called.

coreDox.Verb.Build
---
This project contains the builder logic of coreDox.  
In case of a documentation build the **coreDox.Builder.BuildController** is called.

coreDox.Verb.Watch
---
This project contains the logic of the **watch** verb.
If the **watch** verb is used, the **coreDox.Verb.Watch.Watcher** is called.

coreDox.Writer.Html
---
The default writer for coreDox. Exports the parsed project to a static html page.



