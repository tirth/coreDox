coreDox
---
CLI to use coreDox.  
The CLI is a basic application which dispatches the different verbs to the corresponding applications.
Each verb is a own application. The CLI implements a basic command line arguments parser to identify the
verb to run and passes the remaining arguments to the verb application.

The individual verbs should use **CommandLineParser** to parse the handed arguments.

Available core verbs:
- **new** *starts a wizard to create a new coreDox project*
- **build** *builds a coreDox project in the current path or a given one*
- **watch** *builds a coreDox project in the current path or a given one and autmatically refreshes the output on change of a project file*

coreDox.Model
---
Contains the whole model of coreDox. This includes the parsed tree objects.

Root Object of the parsed Project: DoxProject.cs

## Overview

.. codeTOC:: API\coreDox.md
* [My Awesome API](README.md)

## Methods

* [Defining Methods](methods.md)


coreDox.Contracts
---
This project contains all interfaces used within coreDox.  
The project can easily be referenced to create custom directives or writers for coreDox.

coreDox.Verb.New
---
This project contains the logic of the **new** verb.
If the **new** verb is used, the **coreDox.Verb.New.Wizard** is called.

- layout
- pages
- assets 
- toc.md
- config.cs/json ???

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



