Overview
This project provides a solution for running .NET Framework 4.7.2 applications (especially those relying on system-registered DLLs) as Windows Services, bypassing compatibility issues with IIS and .NET Core.

It is particularly useful for legacy systems that depend on libraries requiring Windows system file registration (e.g., DLLs for biometric attendance/presence devices) but fail to work properly under modern hosting environments.

Why Use This Solution?
✅ Compatibility: Works with libraries that must be registered in Windows (e.g., via regsvr32) but are incompatible with IIS or .NET Core.
✅ Stability: Runs as a Windows Service, ensuring background execution without user interaction.
✅ Legacy Support: Designed for .NET Framework 4.7.2, supporting older dependencies that cannot be migrated to newer frameworks.

Supported Scenarios
Biometric/Attendance Device Integration (DLLs that require system registration).

Legacy COM/ActiveX components needing Windows registry access.

Background Services that should run continuously without a user session.

Prerequisites
.NET Framework 4.7.2 (Developer Pack for compilation).

Windows Server/Windows 10/11 (with admin rights for service installation).

Administrator Access (required for registering system DLLs).

Installation & Setup
1. Build the Project
Clone or download the repository.

Open the solution in Visual Studio (2019 or later).

Build the project (Release mode recommended).

2. Install as a Windows Service
Open Command Prompt as Administrator.

Navigate to the build output folder (\bin\Release).

Run the following command:

Use InstallUtil Command


3. Register Required DLLs (If Needed)
If your project depends on COM or system-registered DLLs (e.g., biometric device libraries), ensure they are properly registered:

sh
regsvr32 "YourDependency.dll"
Configuration
Modify App.config for custom settings (e.g., file paths, API endpoints).

Logs are stored in Event Viewer under Windows Logs > Application.

Troubleshooting
❌ Service Fails to Start?

Check Event Viewer for errors.

Ensure all dependencies (DLLs) are correctly registered.

Verify the service account has sufficient permissions.

❌ DLL Not Registered?

Run regsvr32 as Administrator.

Ensure the DLL is compatible with x86/x64 (match your build target).

License
This project is open-source under the MIT License.

Contributing
Feel free to submit issues or pull requests for improvements.

Need Help?
Contact the maintainers or open a GitHub issue.
