# Code Editor Package for Qoder IDE

## [1.0.1] - 2025-08-28

### Added
- 默认情况下不在项目资源管理器中显示.meta文件，保持项目结构清晰

## [1.0.0] - 2025-08-28

### Added
- Initial release of Unity Qoder IDE integration package
- Automatic detection of Qoder IDE installations on Windows, macOS, and Linux
- Project file generation (.csproj and .sln) optimized for Qoder IDE
- Configurable command-line arguments for Qoder IDE launching
- Support for file opening with line and column positioning
- Integration with Unity's External Script Editor system
- Comprehensive multi-platform installation path detection
- GUI configuration interface in Unity Preferences
- Support for various Unity package types (Embedded, Local, Registry, Git, Built-in)
- Extensive unit tests and integration tests
- Complete documentation and usage examples

### Changed
- Migrated from Visual Studio Code to Qoder IDE integration
- Updated namespace from VSCodeEditor to QoderEditor
- Replaced VSCode-specific file detection with Qoder IDE executables
- Modified installation paths to match Qoder IDE conventions
- Updated package metadata and assembly definitions

### Technical Details
- Supports Unity 2019.2 and later
- Cross-platform compatibility (Windows, macOS, Linux)
- Automatic project synchronization on file changes
- Configurable file extension handling
- Integration with Unity's CodeEditor API

---

# Previous VSCode Package History

## [1.2.3] - 2020-10-23

Remove workaround for VSCode omnisharp (as of https://github.com/OmniSharp/omnisharp-vscode/issues/4113 we no longer need to disable the referenceoutputassemblies).


## [1.2.2] - 2020-09-04

VSC-14 - synchronize solution file when adding new assembly


## [1.2.1] - 2020-05-15

Source filtering adds support for asmref


## [1.2.0] - 2020-03-04

Do not reference projects that has not been generated (case 1211057)
Only open files that exists (case 1188394)
Add individual toggle buttons for generating csprojects for packages
Add support for Roslyn analyzers in project generation through csc.rsp and compiled assembly references
Remove Release build target from csproj and sln


## [1.1.4] - 2020-01-02

Delta project generation, only recompute the csproj files whose script modified.


## [1.1.3] - 2019-10-22

Exe version of vscode will use Normal ProcessWindowStyle while cmd will use Hidden


## [1.1.2] - 2019-08-30

Fixing OSX open command arguments


## [1.1.1] - 2019-08-19

Support for Player Project. Generates specific csproj files containing files, reference, defines,
etc. that will show how the assembly will be compiled for a target platform.


## [1.1.0] - 2019-08-07

Adds support for choosing extensions to be opened with VSCode. This can be done through the GUI in Preferences.
Avoids opening all extensions after the change in core unity.


## [1.0.7] - 2019-05-15

Fix various OSX specific issues.
Generate project on load if they are not generated.
Fix path recognition.


## [1.0.6] - 2019-04-30

Ensure asset database is refreshed when generating csproj and solution files.

## [1.0.5] - 2019-04-27

Add support for generating all csproj files.

## [1.0.4] - 2019-04-18

Fix relative package paths.
Fix opening editor on mac.
Add %LOCALAPPDATA%/Programs to the path of install paths.

## [1.0.3] - 2019-01-01

### This is the first release of *Unity Package vscode_editor*.

Using the newly created api to integrate Visual Studio Code with Unity.
