; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{C5C730EB-3765-4B4D-B5B1-DE8F1564205A}
AppName=Movie File Merger
AppVersion=0.7.0
;AppVerName=Movie File Merger 0.7.0
AppPublisher=Reinhold Lauer
AppPublisherURL=http://Movie-File-Merger.org/
AppSupportURL=http://Movie-File-Merger.org/
AppUpdatesURL=http://Movie-File-Merger.org/
DefaultDirName=D:\Movie File Merger
DefaultGroupName=Movie File Merger
LicenseFile=C:\Users\Modi\Dropbox\GitHub\Movie-File-Merger\Installer License.rtf
OutputDir=C:\Users\Modi\Dropbox\GitHub\Movie-File-Merger\Movie File Merger\bin\Release
OutputBaseFilename=MFMSetup
SetupIconFile=C:\Users\Modi\Dropbox\GitHub\Movie-File-Merger\Movie File Merger\Icons\MFM.ico
Compression=lzma
SolidCompression=yes
WizardImageFile=C:\Users\Modi\Dropbox\GitHub\Movie-File-Merger\Movie File Merger\Icons\MFMHigh.bmp
WizardSmallImageFile=C:\Users\Modi\Dropbox\GitHub\Movie-File-Merger\Movie File Merger\Icons\MFM64.bmp
ShowLanguageDialog=no
CloseApplications=True
RestartApplications=True
RestartIfNeededByRun=False
UninstallDisplayIcon={uninstallexe}
AppCopyright=(c) 2018 Reinhold Lauer
UsePreviousSetupType=False
UsePreviousTasks=False
UsePreviousLanguage=False
AppContact=reinhold.lauer@gmail.com
VersionInfoVersion=0.7.0
VersionInfoCompany=Reinhold Lauer
VersionInfoDescription=Selectively Merge/Maintain Video Collections
VersionInfoCopyright=(c) 2018 Reinhold Lauer
VersionInfoProductName=Movie File Merger
VersionInfoProductVersion=0.7.0
PrivilegesRequired=lowest
InfoBeforeFile="MFM Setup Info Before.rtf"
AllowRootDirectory=True

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: checkedonce
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "C:\Users\Modi\Dropbox\GitHub\Movie-File-Merger\Installation Folder\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\Movie File Merger"; Filename: "{app}\MFM Program\Movie File Merger.exe"
Name: "{group}\{cm:ProgramOnTheWeb,Movie File Merger}"; Filename: "http://Movie-File-Merger.org/"
Name: "{group}\{cm:UninstallProgram,Movie File Merger}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\Movie File Merger"; Filename: "{app}\MFM Program\Movie File Merger.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\Movie File Merger"; Filename: "{app}\MFM Program\Movie File Merger.exe"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\MFM Program\Movie File Merger.exe"; WorkingDir: "{app}\MFM Program\"; Flags: nowait postinstall skipifsilent; Description: "{cm:LaunchProgram,Movie File Merger}"

