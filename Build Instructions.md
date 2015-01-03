## :book: Build Instructions :book:

### Simple Build ###

Do following to compile MFM for the first time and set up the basic environment...

- Open the Movie File Merger solution from SharpDevelop.
- Change the build configuration to Debug.
- Run MFM and close it.
- Copy the files from Installation Folder\MFM Program in the Debug or Release folder.
- Copy the MFM Collections Folder at the same level as the Debug or Release folder.
- Run MFM again...

### Release Build ###

Do following to make a MFM release...

##### In SharpDevelop... #####

- Open the Movie File Merger solution with SharpDevelop.
- Change the build configuration to Release.
- Update the version in the About tab.
- Update the year in the About tab.
- Run MFM and close SharpDevelop.

##### Update Stuff... #####

- Update the MFM User Manual.
- Push the new version of the MFM User Manual.
- Update the MFM Wiki.

##### Build the Installer... #####

- Copy the Movie File Merger.exe from the Release folder in the Installation Folder/MFM Program folder.
- Generate the MFM Setup.exe with Inno Setup.
- Test that MFM Setup can be installed and that all the data are Ok.

Note: MFM will also create a MFM Private Folder at the same level as the Debug or Release folders, so don't run MFM in the Installation Folder.

##### GitHub Release... #####

- Update the change log.
- Attach the MFM Setup to the release.
- Finalize the release. 

##### Setup Distribution... #####

- Switch to gh-pages and paste the MFM Setup.exe under the root.
- Push gh-pages.
- Make a new release on GitHub.

- Update NoNags. 


### Release Checking... #####

- Download the PDF MFM User Manual from GitBooks.
- Download the PDF MFM User Manual from GitBooks.


- Download the MFM Setup from the MFM website.
- Install the MFM Setup.


- Download the MFM Setup from NoNags.
