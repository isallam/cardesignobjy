# cardesignobjy
example model using objy c# APIs

The project show the difference between in-memory C# classes and persistent Objectivity classes. See CarDesign.Model for the in-memory version and data/allschema.txt for the persistent version. 

The CarDesign.Model.Persistent is the generated code that access the persistent version.

The project use a GUI driven access to the in-memory classes. We didn't convert such access to the persistent version, but we did provide a similar code that construct and read objects from the persistent store in CarDesign.Test project

# Notes
1. All access to persistent data need to be done within transactions.
2. The GUI data driven code use static methods and will require injecting transactions in the middle (TBD)
3. To build the code you need access to the Objectivity/DB release.

# Setup
1. Run recreatefd.sh in the data directory to cosntruct the empty FD, create the schema and generate the persistent accessor code.
2. Run CarDesign.Test code.
1. It will initially create two car objects with all their componentsr, then dump the contents.
2. In subsequent calls it will just load the objects from the persitent store.

