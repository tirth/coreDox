[![Build Status](https://travis-ci.org/geaz/coreDox.svg?branch=dev)](https://travis-ci.org/geaz/coreDox)
[![MIT licensed](https://img.shields.io/badge/license-MIT-blue.svg)](https://raw.githubusercontent.com/Geaz/coreArgs/master/LICENSE)

Create .NET code documentation with ease
------------------

**coreDox** is a documentation tool to create .NET code documentation. The tool creates a model of a given solution and passes it to the registered export plugins. The plugins transform the model to a defined output. **coreDox** comes with a html export plugin which demonstrate the possibilities of the tool.

**coreDox** is a complete rewrite of [**sharpDox**](https://github.com/geaz/sharpDox) for .NET Core.

Why rewrite?
---

**sharpDox** used *roslyn* to compile a given solution and to analyze the code. 
If **sharpDox** was integrated in a build process, the build server had to compile the solution twice.
Once for the build itself and a second time for **sharpDox**. This is useless overhead and **codeDox** tries to 
eliminate this by using **cecil** to analyze precompiled *.dlls, *.pdbs & *.xmls (for the code documentation).

It would be possible to accomplish this without a complete rewrite, but **sharpDox** was started as a learning project and has grown within the last few years in such a way that I don't like the code base anymore.

The aim of **coreDox** is to create a cleaner and more maintainable solution. I hope that this will also attract some more people to contribute to **coreDox**.

Project structure
---

**coreDox**

CLI to use coreDox.  
The basic commands are:

- **new --doc [doc-folder]** *creates a new documentation project in the given path*
- **new --exporter [exporter-name] --doc [doc-folder]** *adds the given exporter to the given documentation*
- **build --doc [doc-folder]** *builds the documentation located in the given path*
- **watch --doc [doc-folder]** *watches the documentation located in the given path, starts a web server to view it, and rebuilds the documentation on changes*

**coreDox.Core**

Contains the whole model and all contracts of **coreDox**.
The project can be referenced to create custom exporters for coreDox.

This project also contains the core functionality of **coreDox**.
The functionality is structured into different services:

- **ConfigService** *Service to load, save and use documentation projects in code*
- **ContentService** *Service to load additional pages in the **pages** folder of a documentation project and for parsing the toc file*
- **ExporterService** *Service to manage registered exporters*
- **ParserService** *Service to parse the XML documentation and IL Code of a compiled .NET Project*
- **PluginDiscoveryService** *This service is responsible for the discovery of all **coreDox** plugins.*
- **ServiceLocator** *Used to get an instance of a service*

**coreDox.Parser**

This projects contains the XML Documentation Parser and IL Code parser (using Cecil).
Used by the *ParserService* in *coreDox.Core*.

**coreDox.Exporter.Html**

The default exporter for coreDox. Exports the parsed project to a html page.

Documentation Projects
---
The **new** command creates a new documentation project into the given folder.
A documentation folder is structured in the following way:

- layout *contains the themes for the built documentation - contains one folder for each exporter*
- pages *contains all additional pages integrated in the documentation - referenced in the toc.md*
- assets *all additional assets like images of icons - used in pages and layouts*
- toc.md *the table of contents for the documentation*
- config.yaml *the config for the build process of the documentation*