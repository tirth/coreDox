coreDox
---
CLI to use coreDox.  
The basic commands are:

- **new --doc [doc-folder]** *creates a new documentation project in the given path*
- **new --exporter [exporter-name] --doc [doc-folder]** *adds the given exporter to the given documentation*
- **build --doc [doc-folder]** *builds the documentation located in the given path*
- **watch --doc [doc-folder]** *watches the documentation located in the given path, starts a web server to view it, and rebuilds the documentation on changes*

Documentation Projects
---
The **new** command creates a new documentation project into the given folder.
A documentation folder is structured in the following way:

- layout *contains the themes for the built documentation - consists one folder for each exporter*
- pages *contains all additional pages integrated in the documentation - referenced in the toc.md*
- assets *all additional assets like images of icons - used in pages and layouts*
- toc.md *the table of contents for the documentation*
- config.yaml *the config for the build process of the documentation*

coreDox.Core
---
Contains the whole model and all contracts of **coreDox**.
The project can be referenced to create custom exporters for coreDox.

Root Object of the parsed Project: DoxProject.cs

coreDox.Exporter.Html
---
The default exporter for coreDox. Exports the parsed project to a html page.