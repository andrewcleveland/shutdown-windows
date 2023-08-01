A .NET library to initiate a Windows shutdown or restart.

Essentially a *P/Invoke* wrapper for [`InitiateSystemShutdownEx()`](https://learn.microsoft.com/en-us/windows/win32/api/winreg/nf-winreg-initiatesystemshutdownexw) that also adds the required `SeShutdownPrivilege` to the process token.
See: [How to Shut Down the System](https://learn.microsoft.com/en-us/windows/win32/shutdown/how-to-shut-down-the-system).

[API Documentation](docs/ApiDocumentation.md)