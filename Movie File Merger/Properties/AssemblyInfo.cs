#region Using directives

using System;
using System.Reflection;
using System.Runtime.InteropServices;

#endregion

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Movie File Merger")]
[assembly: AssemblyDescription("Selectively Combine/Maintain Video Collections")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyCompany("Reinhold Lauer")]
[assembly: AssemblyProduct("Movie File Merger")]
[assembly: AssemblyCopyright("Copyright © 2018 Reinhold Lauer")]
[assembly: AssemblyTrademark( "Movie File Merger" )]
[assembly: AssemblyCulture("")]

// This sets the default COM visibility of types in the assembly to invisible.
// If you need to expose a type to COM, use [ComVisible(true)] on that type.
[assembly: ComVisible(false)]

// The assembly version has following format :
//
// Major.Minor.Build.Revision
//
// You can specify all the values or you can use the default the Revision and 
// Build Numbers by using the '*' as shown below:
[assembly: AssemblyVersion("0.7.0.0")]
