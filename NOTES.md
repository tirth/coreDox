coreDox
---
CLI to use coreDox.  
The basic commands are:

- **new --dist [dist-folder]** *creates a new documentation project in the given path*
- **build --doc [doc-folder]** *builds the documentation located in the given path*
- **watch --doc [doc-folder]** *watches the documentation located in the given path, starts a web server to view it, and rebuilds the documentation on changes*

coreDox.Core
---
Contains the whole model and all contracts of **coreDox**.
The project can be referenced to create custom exporters for coreDox.

Root Object of the parsed Project: DoxProject.cs

- layout
- pages
- assets 
- toc.md
- config.cs/json ???

coreDox.Exporter.Html
---
The default exporter for coreDox. Exports the parsed project to a html page.