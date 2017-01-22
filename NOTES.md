coreDox
---
CLI to use coreDox.  
The CLI is a basic application which dispatches the different commands to the corresponding tasks.
Everything called with the CLI is a task. Tasks can be defined by users by a config file.

coreDox provides one default task.
- **new --type [scaffold-name]** *starts a wizard to create a new coreDox project*
- **install --scaffold [scaffold-name]** *installs the given scaffold into the coreDox folder*

Plug have a Execute Method taking a File List and Returning one

SrcPlug -> Src(string path) -> takes a pattern for a folder, reads all files fitting the pattern and passes them to the next plug
WizardPlug -> Wizard(string scaffoldName)

Package(string filePattern)
 -> Plug(IPlug.Execute : Package)

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
The default writer for coreDox. Exports the parsed project to a html page.





**sharpDox** used *roslyn* to compile any given solution and to analyze the code. 
If **sharpDox** was integrated in a build process, the build server had to compile the solution twice.
Once for the build itself and a second time for **sharpDox**. This is useless overhead and **codeDox** tries to 
eliminate this by using **cecil** to analyze precompiled *.dlls, *.pdbs & *.xmls (for the code documentation).

The code documentation feature is a *plug* used by the **coreDox-build** tool. *Plugs* are custom pluggable tools
which can be used during the build process of a **coreDox** project. During the build process **coreDox** passes
the parsed files to all *plugs* registered in the **config.cs**. The *plugs* are able to do modifications on already parsed
files and to add new, on-the-fly, generated files. 


