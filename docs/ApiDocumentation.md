<a name='assembly'></a>
# Cattv.ShutdownWindows

## Contents

- [ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException')
- [ShutdownReason](#T-Cattv-ShutdownWindows-ShutdownReason 'Cattv.ShutdownWindows.ShutdownReason')
  - [ApplicationInstallationPlanned](#F-Cattv-ShutdownWindows-ShutdownReason-ApplicationInstallationPlanned 'Cattv.ShutdownWindows.ShutdownReason.ApplicationInstallationPlanned')
  - [ApplicationMaintenancePlanned](#F-Cattv-ShutdownWindows-ShutdownReason-ApplicationMaintenancePlanned 'Cattv.ShutdownWindows.ShutdownReason.ApplicationMaintenancePlanned')
  - [ApplicationMaintenanceUnplanned](#F-Cattv-ShutdownWindows-ShutdownReason-ApplicationMaintenanceUnplanned 'Cattv.ShutdownWindows.ShutdownReason.ApplicationMaintenanceUnplanned')
  - [ApplicationUnresponsive](#F-Cattv-ShutdownWindows-ShutdownReason-ApplicationUnresponsive 'Cattv.ShutdownWindows.ShutdownReason.ApplicationUnresponsive')
  - [ApplicationUnstable](#F-Cattv-ShutdownWindows-ShutdownReason-ApplicationUnstable 'Cattv.ShutdownWindows.ShutdownReason.ApplicationUnstable')
  - [FlagPlanned](#F-Cattv-ShutdownWindows-ShutdownReason-FlagPlanned 'Cattv.ShutdownWindows.ShutdownReason.FlagPlanned')
  - [FlagUserDefined](#F-Cattv-ShutdownWindows-ShutdownReason-FlagUserDefined 'Cattv.ShutdownWindows.ShutdownReason.FlagUserDefined')
  - [HardwareInstallationPlanned](#F-Cattv-ShutdownWindows-ShutdownReason-HardwareInstallationPlanned 'Cattv.ShutdownWindows.ShutdownReason.HardwareInstallationPlanned')
  - [HardwareInstallationUnplanned](#F-Cattv-ShutdownWindows-ShutdownReason-HardwareInstallationUnplanned 'Cattv.ShutdownWindows.ShutdownReason.HardwareInstallationUnplanned')
  - [HardwareMaintenancePlanned](#F-Cattv-ShutdownWindows-ShutdownReason-HardwareMaintenancePlanned 'Cattv.ShutdownWindows.ShutdownReason.HardwareMaintenancePlanned')
  - [HardwareMaintenanceUnplanned](#F-Cattv-ShutdownWindows-ShutdownReason-HardwareMaintenanceUnplanned 'Cattv.ShutdownWindows.ShutdownReason.HardwareMaintenanceUnplanned')
  - [LossOfNetworkConnectivityUnplanned](#F-Cattv-ShutdownWindows-ShutdownReason-LossOfNetworkConnectivityUnplanned 'Cattv.ShutdownWindows.ShutdownReason.LossOfNetworkConnectivityUnplanned')
  - [MajorApplication](#F-Cattv-ShutdownWindows-ShutdownReason-MajorApplication 'Cattv.ShutdownWindows.ShutdownReason.MajorApplication')
  - [MajorHardware](#F-Cattv-ShutdownWindows-ShutdownReason-MajorHardware 'Cattv.ShutdownWindows.ShutdownReason.MajorHardware')
  - [MajorLegacyApi](#F-Cattv-ShutdownWindows-ShutdownReason-MajorLegacyApi 'Cattv.ShutdownWindows.ShutdownReason.MajorLegacyApi')
  - [MajorOperatingSystem](#F-Cattv-ShutdownWindows-ShutdownReason-MajorOperatingSystem 'Cattv.ShutdownWindows.ShutdownReason.MajorOperatingSystem')
  - [MajorOther](#F-Cattv-ShutdownWindows-ShutdownReason-MajorOther 'Cattv.ShutdownWindows.ShutdownReason.MajorOther')
  - [MajorPower](#F-Cattv-ShutdownWindows-ShutdownReason-MajorPower 'Cattv.ShutdownWindows.ShutdownReason.MajorPower')
  - [MajorSoftware](#F-Cattv-ShutdownWindows-ShutdownReason-MajorSoftware 'Cattv.ShutdownWindows.ShutdownReason.MajorSoftware')
  - [MajorSystem](#F-Cattv-ShutdownWindows-ShutdownReason-MajorSystem 'Cattv.ShutdownWindows.ShutdownReason.MajorSystem')
  - [MinorBlueScreen](#F-Cattv-ShutdownWindows-ShutdownReason-MinorBlueScreen 'Cattv.ShutdownWindows.ShutdownReason.MinorBlueScreen')
  - [MinorCordUnplugged](#F-Cattv-ShutdownWindows-ShutdownReason-MinorCordUnplugged 'Cattv.ShutdownWindows.ShutdownReason.MinorCordUnplugged')
  - [MinorDisk](#F-Cattv-ShutdownWindows-ShutdownReason-MinorDisk 'Cattv.ShutdownWindows.ShutdownReason.MinorDisk')
  - [MinorEnvironment](#F-Cattv-ShutdownWindows-ShutdownReason-MinorEnvironment 'Cattv.ShutdownWindows.ShutdownReason.MinorEnvironment')
  - [MinorHardwareDriver](#F-Cattv-ShutdownWindows-ShutdownReason-MinorHardwareDriver 'Cattv.ShutdownWindows.ShutdownReason.MinorHardwareDriver')
  - [MinorHotfix](#F-Cattv-ShutdownWindows-ShutdownReason-MinorHotfix 'Cattv.ShutdownWindows.ShutdownReason.MinorHotfix')
  - [MinorHotfixUninstall](#F-Cattv-ShutdownWindows-ShutdownReason-MinorHotfixUninstall 'Cattv.ShutdownWindows.ShutdownReason.MinorHotfixUninstall')
  - [MinorHung](#F-Cattv-ShutdownWindows-ShutdownReason-MinorHung 'Cattv.ShutdownWindows.ShutdownReason.MinorHung')
  - [MinorInstallation](#F-Cattv-ShutdownWindows-ShutdownReason-MinorInstallation 'Cattv.ShutdownWindows.ShutdownReason.MinorInstallation')
  - [MinorMaintenance](#F-Cattv-ShutdownWindows-ShutdownReason-MinorMaintenance 'Cattv.ShutdownWindows.ShutdownReason.MinorMaintenance')
  - [MinorMmc](#F-Cattv-ShutdownWindows-ShutdownReason-MinorMmc 'Cattv.ShutdownWindows.ShutdownReason.MinorMmc')
  - [MinorNetworkCard](#F-Cattv-ShutdownWindows-ShutdownReason-MinorNetworkCard 'Cattv.ShutdownWindows.ShutdownReason.MinorNetworkCard')
  - [MinorNetworkConnectivity](#F-Cattv-ShutdownWindows-ShutdownReason-MinorNetworkConnectivity 'Cattv.ShutdownWindows.ShutdownReason.MinorNetworkConnectivity')
  - [MinorOther](#F-Cattv-ShutdownWindows-ShutdownReason-MinorOther 'Cattv.ShutdownWindows.ShutdownReason.MinorOther')
  - [MinorOtherDriver](#F-Cattv-ShutdownWindows-ShutdownReason-MinorOtherDriver 'Cattv.ShutdownWindows.ShutdownReason.MinorOtherDriver')
  - [MinorPowerSupply](#F-Cattv-ShutdownWindows-ShutdownReason-MinorPowerSupply 'Cattv.ShutdownWindows.ShutdownReason.MinorPowerSupply')
  - [MinorProcessor](#F-Cattv-ShutdownWindows-ShutdownReason-MinorProcessor 'Cattv.ShutdownWindows.ShutdownReason.MinorProcessor')
  - [MinorReconfig](#F-Cattv-ShutdownWindows-ShutdownReason-MinorReconfig 'Cattv.ShutdownWindows.ShutdownReason.MinorReconfig')
  - [MinorSecurity](#F-Cattv-ShutdownWindows-ShutdownReason-MinorSecurity 'Cattv.ShutdownWindows.ShutdownReason.MinorSecurity')
  - [MinorSecurityFix](#F-Cattv-ShutdownWindows-ShutdownReason-MinorSecurityFix 'Cattv.ShutdownWindows.ShutdownReason.MinorSecurityFix')
  - [MinorSecurityFixUninstall](#F-Cattv-ShutdownWindows-ShutdownReason-MinorSecurityFixUninstall 'Cattv.ShutdownWindows.ShutdownReason.MinorSecurityFixUninstall')
  - [MinorServicePack](#F-Cattv-ShutdownWindows-ShutdownReason-MinorServicePack 'Cattv.ShutdownWindows.ShutdownReason.MinorServicePack')
  - [MinorServicePackUninstall](#F-Cattv-ShutdownWindows-ShutdownReason-MinorServicePackUninstall 'Cattv.ShutdownWindows.ShutdownReason.MinorServicePackUninstall')
  - [MinorTerminalServices](#F-Cattv-ShutdownWindows-ShutdownReason-MinorTerminalServices 'Cattv.ShutdownWindows.ShutdownReason.MinorTerminalServices')
  - [MinorUnstable](#F-Cattv-ShutdownWindows-ShutdownReason-MinorUnstable 'Cattv.ShutdownWindows.ShutdownReason.MinorUnstable')
  - [MinorUpgrade](#F-Cattv-ShutdownWindows-ShutdownReason-MinorUpgrade 'Cattv.ShutdownWindows.ShutdownReason.MinorUpgrade')
  - [MinorWmi](#F-Cattv-ShutdownWindows-ShutdownReason-MinorWmi 'Cattv.ShutdownWindows.ShutdownReason.MinorWmi')
  - [OperatingSystemHotFixPlanned](#F-Cattv-ShutdownWindows-ShutdownReason-OperatingSystemHotFixPlanned 'Cattv.ShutdownWindows.ShutdownReason.OperatingSystemHotFixPlanned')
  - [OperatingSystemHotFixUnplanned](#F-Cattv-ShutdownWindows-ShutdownReason-OperatingSystemHotFixUnplanned 'Cattv.ShutdownWindows.ShutdownReason.OperatingSystemHotFixUnplanned')
  - [OperatingSystemReconfigurationPlanned](#F-Cattv-ShutdownWindows-ShutdownReason-OperatingSystemReconfigurationPlanned 'Cattv.ShutdownWindows.ShutdownReason.OperatingSystemReconfigurationPlanned')
  - [OperatingSystemReconfigurationUnplanned](#F-Cattv-ShutdownWindows-ShutdownReason-OperatingSystemReconfigurationUnplanned 'Cattv.ShutdownWindows.ShutdownReason.OperatingSystemReconfigurationUnplanned')
  - [OperatingSystemSecurityFixPlanned](#F-Cattv-ShutdownWindows-ShutdownReason-OperatingSystemSecurityFixPlanned 'Cattv.ShutdownWindows.ShutdownReason.OperatingSystemSecurityFixPlanned')
  - [OperatingSystemSecurityFixUnplanned](#F-Cattv-ShutdownWindows-ShutdownReason-OperatingSystemSecurityFixUnplanned 'Cattv.ShutdownWindows.ShutdownReason.OperatingSystemSecurityFixUnplanned')
  - [OperatingSystemServicePackPlanned](#F-Cattv-ShutdownWindows-ShutdownReason-OperatingSystemServicePackPlanned 'Cattv.ShutdownWindows.ShutdownReason.OperatingSystemServicePackPlanned')
  - [OperatingSystemUpgradePlanned](#F-Cattv-ShutdownWindows-ShutdownReason-OperatingSystemUpgradePlanned 'Cattv.ShutdownWindows.ShutdownReason.OperatingSystemUpgradePlanned')
  - [OtherFailureSystemUnresponsive](#F-Cattv-ShutdownWindows-ShutdownReason-OtherFailureSystemUnresponsive 'Cattv.ShutdownWindows.ShutdownReason.OtherFailureSystemUnresponsive')
  - [OtherPlanned](#F-Cattv-ShutdownWindows-ShutdownReason-OtherPlanned 'Cattv.ShutdownWindows.ShutdownReason.OtherPlanned')
  - [OtherUnplanned](#F-Cattv-ShutdownWindows-ShutdownReason-OtherUnplanned 'Cattv.ShutdownWindows.ShutdownReason.OtherUnplanned')
  - [PowerFailureCordUnplugged](#F-Cattv-ShutdownWindows-ShutdownReason-PowerFailureCordUnplugged 'Cattv.ShutdownWindows.ShutdownReason.PowerFailureCordUnplugged')
  - [PowerFailureEnvironment](#F-Cattv-ShutdownWindows-ShutdownReason-PowerFailureEnvironment 'Cattv.ShutdownWindows.ShutdownReason.PowerFailureEnvironment')
  - [SecurityIssue](#F-Cattv-ShutdownWindows-ShutdownReason-SecurityIssue 'Cattv.ShutdownWindows.ShutdownReason.SecurityIssue')
  - [SystemFailureStopError](#F-Cattv-ShutdownWindows-ShutdownReason-SystemFailureStopError 'Cattv.ShutdownWindows.ShutdownReason.SystemFailureStopError')
- [ShutdownWindows](#T-Cattv-ShutdownWindows-ShutdownWindows 'Cattv.ShutdownWindows.ShutdownWindows')
  - [Abort()](#M-Cattv-ShutdownWindows-ShutdownWindows-Abort 'Cattv.ShutdownWindows.ShutdownWindows.Abort')
  - [Restart(message,delay,force,reason)](#M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-String,System-TimeSpan,System-Boolean,Cattv-ShutdownWindows-ShutdownReason- 'Cattv.ShutdownWindows.ShutdownWindows.Restart(System.String,System.TimeSpan,System.Boolean,Cattv.ShutdownWindows.ShutdownReason)')
  - [Restart(delay,force,reason)](#M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-TimeSpan,System-Boolean,Cattv-ShutdownWindows-ShutdownReason- 'Cattv.ShutdownWindows.ShutdownWindows.Restart(System.TimeSpan,System.Boolean,Cattv.ShutdownWindows.ShutdownReason)')
  - [Restart(message,force,reason)](#M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-String,System-Boolean,Cattv-ShutdownWindows-ShutdownReason- 'Cattv.ShutdownWindows.ShutdownWindows.Restart(System.String,System.Boolean,Cattv.ShutdownWindows.ShutdownReason)')
  - [Restart(message,delay,reason)](#M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-String,System-TimeSpan,Cattv-ShutdownWindows-ShutdownReason- 'Cattv.ShutdownWindows.ShutdownWindows.Restart(System.String,System.TimeSpan,Cattv.ShutdownWindows.ShutdownReason)')
  - [Restart(message,delay,force)](#M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-String,System-TimeSpan,System-Boolean- 'Cattv.ShutdownWindows.ShutdownWindows.Restart(System.String,System.TimeSpan,System.Boolean)')
  - [Restart(message,delay)](#M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-String,System-TimeSpan- 'Cattv.ShutdownWindows.ShutdownWindows.Restart(System.String,System.TimeSpan)')
  - [Restart(message,force)](#M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-String,System-Boolean- 'Cattv.ShutdownWindows.ShutdownWindows.Restart(System.String,System.Boolean)')
  - [Restart(message,reason)](#M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-String,Cattv-ShutdownWindows-ShutdownReason- 'Cattv.ShutdownWindows.ShutdownWindows.Restart(System.String,Cattv.ShutdownWindows.ShutdownReason)')
  - [Restart(delay,force)](#M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-TimeSpan,System-Boolean- 'Cattv.ShutdownWindows.ShutdownWindows.Restart(System.TimeSpan,System.Boolean)')
  - [Restart(delay,reason)](#M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-TimeSpan,Cattv-ShutdownWindows-ShutdownReason- 'Cattv.ShutdownWindows.ShutdownWindows.Restart(System.TimeSpan,Cattv.ShutdownWindows.ShutdownReason)')
  - [Restart(force,reason)](#M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-Boolean,Cattv-ShutdownWindows-ShutdownReason- 'Cattv.ShutdownWindows.ShutdownWindows.Restart(System.Boolean,Cattv.ShutdownWindows.ShutdownReason)')
  - [Restart(message)](#M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-String- 'Cattv.ShutdownWindows.ShutdownWindows.Restart(System.String)')
  - [Restart(delay)](#M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-TimeSpan- 'Cattv.ShutdownWindows.ShutdownWindows.Restart(System.TimeSpan)')
  - [Restart(force)](#M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-Boolean- 'Cattv.ShutdownWindows.ShutdownWindows.Restart(System.Boolean)')
  - [Restart(reason)](#M-Cattv-ShutdownWindows-ShutdownWindows-Restart-Cattv-ShutdownWindows-ShutdownReason- 'Cattv.ShutdownWindows.ShutdownWindows.Restart(Cattv.ShutdownWindows.ShutdownReason)')
  - [Restart()](#M-Cattv-ShutdownWindows-ShutdownWindows-Restart 'Cattv.ShutdownWindows.ShutdownWindows.Restart')
  - [Shutdown(message,delay,force,restart,reason)](#M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-String,System-TimeSpan,System-Boolean,System-Boolean,Cattv-ShutdownWindows-ShutdownReason- 'Cattv.ShutdownWindows.ShutdownWindows.Shutdown(System.String,System.TimeSpan,System.Boolean,System.Boolean,Cattv.ShutdownWindows.ShutdownReason)')
  - [Shutdown(message,delay,force,reason)](#M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-String,System-TimeSpan,System-Boolean,Cattv-ShutdownWindows-ShutdownReason- 'Cattv.ShutdownWindows.ShutdownWindows.Shutdown(System.String,System.TimeSpan,System.Boolean,Cattv.ShutdownWindows.ShutdownReason)')
  - [Shutdown(delay,force,reason)](#M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-TimeSpan,System-Boolean,Cattv-ShutdownWindows-ShutdownReason- 'Cattv.ShutdownWindows.ShutdownWindows.Shutdown(System.TimeSpan,System.Boolean,Cattv.ShutdownWindows.ShutdownReason)')
  - [Shutdown(message,force,reason)](#M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-String,System-Boolean,Cattv-ShutdownWindows-ShutdownReason- 'Cattv.ShutdownWindows.ShutdownWindows.Shutdown(System.String,System.Boolean,Cattv.ShutdownWindows.ShutdownReason)')
  - [Shutdown(message,delay,reason)](#M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-String,System-TimeSpan,Cattv-ShutdownWindows-ShutdownReason- 'Cattv.ShutdownWindows.ShutdownWindows.Shutdown(System.String,System.TimeSpan,Cattv.ShutdownWindows.ShutdownReason)')
  - [Shutdown(message,delay,force)](#M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-String,System-TimeSpan,System-Boolean- 'Cattv.ShutdownWindows.ShutdownWindows.Shutdown(System.String,System.TimeSpan,System.Boolean)')
  - [Shutdown(message,delay)](#M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-String,System-TimeSpan- 'Cattv.ShutdownWindows.ShutdownWindows.Shutdown(System.String,System.TimeSpan)')
  - [Shutdown(message,force)](#M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-String,System-Boolean- 'Cattv.ShutdownWindows.ShutdownWindows.Shutdown(System.String,System.Boolean)')
  - [Shutdown(message,reason)](#M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-String,Cattv-ShutdownWindows-ShutdownReason- 'Cattv.ShutdownWindows.ShutdownWindows.Shutdown(System.String,Cattv.ShutdownWindows.ShutdownReason)')
  - [Shutdown(delay,force)](#M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-TimeSpan,System-Boolean- 'Cattv.ShutdownWindows.ShutdownWindows.Shutdown(System.TimeSpan,System.Boolean)')
  - [Shutdown(delay,reason)](#M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-TimeSpan,Cattv-ShutdownWindows-ShutdownReason- 'Cattv.ShutdownWindows.ShutdownWindows.Shutdown(System.TimeSpan,Cattv.ShutdownWindows.ShutdownReason)')
  - [Shutdown(force,reason)](#M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-Boolean,Cattv-ShutdownWindows-ShutdownReason- 'Cattv.ShutdownWindows.ShutdownWindows.Shutdown(System.Boolean,Cattv.ShutdownWindows.ShutdownReason)')
  - [Shutdown(message)](#M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-String- 'Cattv.ShutdownWindows.ShutdownWindows.Shutdown(System.String)')
  - [Shutdown(delay)](#M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-TimeSpan- 'Cattv.ShutdownWindows.ShutdownWindows.Shutdown(System.TimeSpan)')
  - [Shutdown(force)](#M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-Boolean- 'Cattv.ShutdownWindows.ShutdownWindows.Shutdown(System.Boolean)')
  - [Shutdown(reason)](#M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-Cattv-ShutdownWindows-ShutdownReason- 'Cattv.ShutdownWindows.ShutdownWindows.Shutdown(Cattv.ShutdownWindows.ShutdownReason)')
  - [Shutdown()](#M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown 'Cattv.ShutdownWindows.ShutdownWindows.Shutdown')

<a name='T-Cattv-ShutdownWindows-ShutdownException'></a>
## ShutdownException `type`

##### Namespace

Cattv.ShutdownWindows

##### Summary

The exception thrown when a shutdown, restart or abort operation fails.

<a name='T-Cattv-ShutdownWindows-ShutdownReason'></a>
## ShutdownReason `type`

##### Namespace

Cattv.ShutdownWindows

##### Summary

Shutdown reason codes.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-ApplicationInstallationPlanned'></a>
### ApplicationInstallationPlanned `constants`

##### Summary

Application: Installation (Planned)

<a name='F-Cattv-ShutdownWindows-ShutdownReason-ApplicationMaintenancePlanned'></a>
### ApplicationMaintenancePlanned `constants`

##### Summary

Application: Maintenance (Planned)

<a name='F-Cattv-ShutdownWindows-ShutdownReason-ApplicationMaintenanceUnplanned'></a>
### ApplicationMaintenanceUnplanned `constants`

##### Summary

Application: Maintenance (Unplanned)

<a name='F-Cattv-ShutdownWindows-ShutdownReason-ApplicationUnresponsive'></a>
### ApplicationUnresponsive `constants`

##### Summary

Application: Unresponsive

<a name='F-Cattv-ShutdownWindows-ShutdownReason-ApplicationUnstable'></a>
### ApplicationUnstable `constants`

##### Summary

Application: Unstable

<a name='F-Cattv-ShutdownWindows-ShutdownReason-FlagPlanned'></a>
### FlagPlanned `constants`

##### Summary

The shutdown was planned.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-FlagUserDefined'></a>
### FlagUserDefined `constants`

##### Summary

The reason code is defined by the user.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-HardwareInstallationPlanned'></a>
### HardwareInstallationPlanned `constants`

##### Summary

Hardware: Installation (Planned)

<a name='F-Cattv-ShutdownWindows-ShutdownReason-HardwareInstallationUnplanned'></a>
### HardwareInstallationUnplanned `constants`

##### Summary

Hardware: Installation (Unplanned)

<a name='F-Cattv-ShutdownWindows-ShutdownReason-HardwareMaintenancePlanned'></a>
### HardwareMaintenancePlanned `constants`

##### Summary

Hardware: Maintenance (Planned)

<a name='F-Cattv-ShutdownWindows-ShutdownReason-HardwareMaintenanceUnplanned'></a>
### HardwareMaintenanceUnplanned `constants`

##### Summary

Hardware: Maintenance (Unplanned)

<a name='F-Cattv-ShutdownWindows-ShutdownReason-LossOfNetworkConnectivityUnplanned'></a>
### LossOfNetworkConnectivityUnplanned `constants`

##### Summary

Loss of network connectivity (Unplanned)

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MajorApplication'></a>
### MajorApplication `constants`

##### Summary

Application issue.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MajorHardware'></a>
### MajorHardware `constants`

##### Summary

Hardware issue.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MajorLegacyApi'></a>
### MajorLegacyApi `constants`

##### Summary

Legacy API shutdown

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MajorOperatingSystem'></a>
### MajorOperatingSystem `constants`

##### Summary

Operating system issue.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MajorOther'></a>
### MajorOther `constants`

##### Summary

Other issue.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MajorPower'></a>
### MajorPower `constants`

##### Summary

Power failure.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MajorSoftware'></a>
### MajorSoftware `constants`

##### Summary

Software issue.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MajorSystem'></a>
### MajorSystem `constants`

##### Summary

System failure.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorBlueScreen'></a>
### MinorBlueScreen `constants`

##### Summary

Blue screen crash event.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorCordUnplugged'></a>
### MinorCordUnplugged `constants`

##### Summary

Unplugged.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorDisk'></a>
### MinorDisk `constants`

##### Summary

Disk.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorEnvironment'></a>
### MinorEnvironment `constants`

##### Summary

Environment.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorHardwareDriver'></a>
### MinorHardwareDriver `constants`

##### Summary

Driver.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorHotfix'></a>
### MinorHotfix `constants`

##### Summary

Hot fix.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorHotfixUninstall'></a>
### MinorHotfixUninstall `constants`

##### Summary

Hot fix uninstallation.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorHung'></a>
### MinorHung `constants`

##### Summary

Unresponsive.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorInstallation'></a>
### MinorInstallation `constants`

##### Summary

Installation.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorMaintenance'></a>
### MinorMaintenance `constants`

##### Summary

Maintenance.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorMmc'></a>
### MinorMmc `constants`

##### Summary

MMC issue.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorNetworkCard'></a>
### MinorNetworkCard `constants`

##### Summary

Network card.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorNetworkConnectivity'></a>
### MinorNetworkConnectivity `constants`

##### Summary

Network connectivity.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorOther'></a>
### MinorOther `constants`

##### Summary

Other issue.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorOtherDriver'></a>
### MinorOtherDriver `constants`

##### Summary

Other driver event.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorPowerSupply'></a>
### MinorPowerSupply `constants`

##### Summary

Power supply.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorProcessor'></a>
### MinorProcessor `constants`

##### Summary

Processor.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorReconfig'></a>
### MinorReconfig `constants`

##### Summary

Reconfigure.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorSecurity'></a>
### MinorSecurity `constants`

##### Summary

Security issue.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorSecurityFix'></a>
### MinorSecurityFix `constants`

##### Summary

Security patch.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorSecurityFixUninstall'></a>
### MinorSecurityFixUninstall `constants`

##### Summary

Security patch uninstallation.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorServicePack'></a>
### MinorServicePack `constants`

##### Summary

Service pack.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorServicePackUninstall'></a>
### MinorServicePackUninstall `constants`

##### Summary

Service pack uninstallation.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorTerminalServices'></a>
### MinorTerminalServices `constants`

##### Summary

Terminal Services.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorUnstable'></a>
### MinorUnstable `constants`

##### Summary

Unstable.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorUpgrade'></a>
### MinorUpgrade `constants`

##### Summary

Upgrade.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-MinorWmi'></a>
### MinorWmi `constants`

##### Summary

WMI issue.

<a name='F-Cattv-ShutdownWindows-ShutdownReason-OperatingSystemHotFixPlanned'></a>
### OperatingSystemHotFixPlanned `constants`

##### Summary

Operating System: Hot fix (Planned)

<a name='F-Cattv-ShutdownWindows-ShutdownReason-OperatingSystemHotFixUnplanned'></a>
### OperatingSystemHotFixUnplanned `constants`

##### Summary

Operating System: Hot fix (Unplanned)

<a name='F-Cattv-ShutdownWindows-ShutdownReason-OperatingSystemReconfigurationPlanned'></a>
### OperatingSystemReconfigurationPlanned `constants`

##### Summary

Operating System: Reconfiguration (Planned)

<a name='F-Cattv-ShutdownWindows-ShutdownReason-OperatingSystemReconfigurationUnplanned'></a>
### OperatingSystemReconfigurationUnplanned `constants`

##### Summary

Operating System: Reconfiguration (Unplanned)

<a name='F-Cattv-ShutdownWindows-ShutdownReason-OperatingSystemSecurityFixPlanned'></a>
### OperatingSystemSecurityFixPlanned `constants`

##### Summary

Operating System: Security fix (Planned)

<a name='F-Cattv-ShutdownWindows-ShutdownReason-OperatingSystemSecurityFixUnplanned'></a>
### OperatingSystemSecurityFixUnplanned `constants`

##### Summary

Operating System: Security fix (Unplanned)

<a name='F-Cattv-ShutdownWindows-ShutdownReason-OperatingSystemServicePackPlanned'></a>
### OperatingSystemServicePackPlanned `constants`

##### Summary

Operating System: Service pack (Planned)

<a name='F-Cattv-ShutdownWindows-ShutdownReason-OperatingSystemUpgradePlanned'></a>
### OperatingSystemUpgradePlanned `constants`

##### Summary

Operating System: Upgrade (Planned)

<a name='F-Cattv-ShutdownWindows-ShutdownReason-OtherFailureSystemUnresponsive'></a>
### OtherFailureSystemUnresponsive `constants`

##### Summary

Other Failure: System Unresponsive

<a name='F-Cattv-ShutdownWindows-ShutdownReason-OtherPlanned'></a>
### OtherPlanned `constants`

##### Summary

Other (Planned)

<a name='F-Cattv-ShutdownWindows-ShutdownReason-OtherUnplanned'></a>
### OtherUnplanned `constants`

##### Summary

Other (Unplanned)

<a name='F-Cattv-ShutdownWindows-ShutdownReason-PowerFailureCordUnplugged'></a>
### PowerFailureCordUnplugged `constants`

##### Summary

Power Failure: Cord Unplugged

<a name='F-Cattv-ShutdownWindows-ShutdownReason-PowerFailureEnvironment'></a>
### PowerFailureEnvironment `constants`

##### Summary

Power Failure: Environment

<a name='F-Cattv-ShutdownWindows-ShutdownReason-SecurityIssue'></a>
### SecurityIssue `constants`

##### Summary

Security issue

<a name='F-Cattv-ShutdownWindows-ShutdownReason-SystemFailureStopError'></a>
### SystemFailureStopError `constants`

##### Summary

System Failure: Stop error

<a name='T-Cattv-ShutdownWindows-ShutdownWindows'></a>
## ShutdownWindows `type`

##### Namespace

Cattv.ShutdownWindows

##### Summary

Provides a set of

```
static
```

(

```
Shared
```

in Visual Basic) methods for starting or aborting a Windows shutdown or restart.

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Abort'></a>
### Abort() `method`

##### Summary

Abort a pending shutdown or reboot.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the shutdown. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-String,System-TimeSpan,System-Boolean,Cattv-ShutdownWindows-ShutdownReason-'></a>
### Restart(message,delay,force,reason) `method`

##### Summary

Initiate a restart.
If `delay` is greater than zero,
the restart can be aborted with [Abort](#M-Cattv-ShutdownWindows-ShutdownWindows-Abort 'Cattv.ShutdownWindows.ShutdownWindows.Abort').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message that will be displayed to the user. |
| delay | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second. |
| force | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Force the restart. |
| reason | [Cattv.ShutdownWindows.ShutdownReason](#T-Cattv-ShutdownWindows-ShutdownReason 'Cattv.ShutdownWindows.ShutdownReason') | The shutdown reason that will be logged. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the restart. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-TimeSpan,System-Boolean,Cattv-ShutdownWindows-ShutdownReason-'></a>
### Restart(delay,force,reason) `method`

##### Summary

Initiate a restart.
If `delay` is greater than zero,
the restart can be aborted with [Abort](#M-Cattv-ShutdownWindows-ShutdownWindows-Abort 'Cattv.ShutdownWindows.ShutdownWindows.Abort').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| delay | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second. |
| force | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Force the restart. |
| reason | [Cattv.ShutdownWindows.ShutdownReason](#T-Cattv-ShutdownWindows-ShutdownReason 'Cattv.ShutdownWindows.ShutdownReason') | The shutdown reason that will be logged. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the restart. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-String,System-Boolean,Cattv-ShutdownWindows-ShutdownReason-'></a>
### Restart(message,force,reason) `method`

##### Summary

Initiate an immediate restart.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message that will be displayed to the user. |
| force | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Force the restart. |
| reason | [Cattv.ShutdownWindows.ShutdownReason](#T-Cattv-ShutdownWindows-ShutdownReason 'Cattv.ShutdownWindows.ShutdownReason') | The shutdown reason that will be logged. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the restart. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-String,System-TimeSpan,Cattv-ShutdownWindows-ShutdownReason-'></a>
### Restart(message,delay,reason) `method`

##### Summary

Initiate a restart.
If `delay` is greater than zero,
the restart can be aborted with [Abort](#M-Cattv-ShutdownWindows-ShutdownWindows-Abort 'Cattv.ShutdownWindows.ShutdownWindows.Abort').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message that will be displayed to the user. |
| delay | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second. |
| reason | [Cattv.ShutdownWindows.ShutdownReason](#T-Cattv-ShutdownWindows-ShutdownReason 'Cattv.ShutdownWindows.ShutdownReason') | The shutdown reason that will be logged. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the restart. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-String,System-TimeSpan,System-Boolean-'></a>
### Restart(message,delay,force) `method`

##### Summary

Initiate a restart.
If `delay` is greater than zero,
the restart can be aborted with [Abort](#M-Cattv-ShutdownWindows-ShutdownWindows-Abort 'Cattv.ShutdownWindows.ShutdownWindows.Abort').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message that will be displayed to the user. |
| delay | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second. |
| force | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Force the restart. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the restart. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-String,System-TimeSpan-'></a>
### Restart(message,delay) `method`

##### Summary

Initiate a restart.
If `delay` is greater than zero,
the restart can be aborted with [Abort](#M-Cattv-ShutdownWindows-ShutdownWindows-Abort 'Cattv.ShutdownWindows.ShutdownWindows.Abort').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message that will be displayed to the user. |
| delay | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the restart. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-String,System-Boolean-'></a>
### Restart(message,force) `method`

##### Summary

Initiate an immediate restart.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message that will be displayed to the user. |
| force | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Force the restart. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the restart. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-String,Cattv-ShutdownWindows-ShutdownReason-'></a>
### Restart(message,reason) `method`

##### Summary

Initiate an immediate restart.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message that will be displayed to the user. |
| reason | [Cattv.ShutdownWindows.ShutdownReason](#T-Cattv-ShutdownWindows-ShutdownReason 'Cattv.ShutdownWindows.ShutdownReason') | The shutdown reason that will be logged. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the restart. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-TimeSpan,System-Boolean-'></a>
### Restart(delay,force) `method`

##### Summary

Initiate a restart.
If `delay` is greater than zero,
the restart can be aborted with [Abort](#M-Cattv-ShutdownWindows-ShutdownWindows-Abort 'Cattv.ShutdownWindows.ShutdownWindows.Abort').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| delay | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second. |
| force | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Force the restart. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the restart. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-TimeSpan,Cattv-ShutdownWindows-ShutdownReason-'></a>
### Restart(delay,reason) `method`

##### Summary

Initiate a restart.
If `delay` is greater than zero,
the restart can be aborted with [Abort](#M-Cattv-ShutdownWindows-ShutdownWindows-Abort 'Cattv.ShutdownWindows.ShutdownWindows.Abort').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| delay | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second. |
| reason | [Cattv.ShutdownWindows.ShutdownReason](#T-Cattv-ShutdownWindows-ShutdownReason 'Cattv.ShutdownWindows.ShutdownReason') | The shutdown reason that will be logged. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the restart. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-Boolean,Cattv-ShutdownWindows-ShutdownReason-'></a>
### Restart(force,reason) `method`

##### Summary

Initiate an immediate restart.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| force | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Force the restart. |
| reason | [Cattv.ShutdownWindows.ShutdownReason](#T-Cattv-ShutdownWindows-ShutdownReason 'Cattv.ShutdownWindows.ShutdownReason') | The shutdown reason that will be logged. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the restart. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-String-'></a>
### Restart(message) `method`

##### Summary

Initiate an immediate restart.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message that will be displayed to the user. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the restart. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-TimeSpan-'></a>
### Restart(delay) `method`

##### Summary

Initiate a restart.
If `delay` is greater than zero,
the restart can be aborted with [Abort](#M-Cattv-ShutdownWindows-ShutdownWindows-Abort 'Cattv.ShutdownWindows.ShutdownWindows.Abort').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| delay | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the restart. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Restart-System-Boolean-'></a>
### Restart(force) `method`

##### Summary

Initiate an immediate restart.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| force | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Force the restart. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the restart. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Restart-Cattv-ShutdownWindows-ShutdownReason-'></a>
### Restart(reason) `method`

##### Summary

Initiate an immediate restart.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reason | [Cattv.ShutdownWindows.ShutdownReason](#T-Cattv-ShutdownWindows-ShutdownReason 'Cattv.ShutdownWindows.ShutdownReason') | The shutdown reason that will be logged. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the restart. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Restart'></a>
### Restart() `method`

##### Summary

Initiate an immediate restart.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the restart. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-String,System-TimeSpan,System-Boolean,System-Boolean,Cattv-ShutdownWindows-ShutdownReason-'></a>
### Shutdown(message,delay,force,restart,reason) `method`

##### Summary

Initiate a shutdown or restart.
If `delay` is greater than zero,
the shutdown or restart can be aborted with [Abort](#M-Cattv-ShutdownWindows-ShutdownWindows-Abort 'Cattv.ShutdownWindows.ShutdownWindows.Abort').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message that will be displayed to the user. |
| delay | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second. |
| force | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Force the shutdown or restart. |
| restart | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Restart instead of shutting down. |
| reason | [Cattv.ShutdownWindows.ShutdownReason](#T-Cattv-ShutdownWindows-ShutdownReason 'Cattv.ShutdownWindows.ShutdownReason') | The shutdown reason that will be logged. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the shutdown. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-String,System-TimeSpan,System-Boolean,Cattv-ShutdownWindows-ShutdownReason-'></a>
### Shutdown(message,delay,force,reason) `method`

##### Summary

Initiate a shutdown.
If `delay` is greater than zero,
the shutdown can be aborted with [Abort](#M-Cattv-ShutdownWindows-ShutdownWindows-Abort 'Cattv.ShutdownWindows.ShutdownWindows.Abort').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message that will be displayed to the user. |
| delay | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second. |
| force | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Force the shutdown. |
| reason | [Cattv.ShutdownWindows.ShutdownReason](#T-Cattv-ShutdownWindows-ShutdownReason 'Cattv.ShutdownWindows.ShutdownReason') | The shutdown reason that will be logged. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the shutdown. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-TimeSpan,System-Boolean,Cattv-ShutdownWindows-ShutdownReason-'></a>
### Shutdown(delay,force,reason) `method`

##### Summary

Initiate a shutdown.
If `delay` is greater than zero,
the shutdown can be aborted with [Abort](#M-Cattv-ShutdownWindows-ShutdownWindows-Abort 'Cattv.ShutdownWindows.ShutdownWindows.Abort').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| delay | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second. |
| force | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Force the shutdown. |
| reason | [Cattv.ShutdownWindows.ShutdownReason](#T-Cattv-ShutdownWindows-ShutdownReason 'Cattv.ShutdownWindows.ShutdownReason') | The shutdown reason that will be logged. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the shutdown. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-String,System-Boolean,Cattv-ShutdownWindows-ShutdownReason-'></a>
### Shutdown(message,force,reason) `method`

##### Summary

Initiate an immediate shutdown.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message that will be displayed to the user. |
| force | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Force the shutdown. |
| reason | [Cattv.ShutdownWindows.ShutdownReason](#T-Cattv-ShutdownWindows-ShutdownReason 'Cattv.ShutdownWindows.ShutdownReason') | The shutdown reason that will be logged. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the shutdown. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-String,System-TimeSpan,Cattv-ShutdownWindows-ShutdownReason-'></a>
### Shutdown(message,delay,reason) `method`

##### Summary

Initiate a shutdown.
If `delay` is greater than zero,
the shutdown can be aborted with [Abort](#M-Cattv-ShutdownWindows-ShutdownWindows-Abort 'Cattv.ShutdownWindows.ShutdownWindows.Abort').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message that will be displayed to the user. |
| delay | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second. |
| reason | [Cattv.ShutdownWindows.ShutdownReason](#T-Cattv-ShutdownWindows-ShutdownReason 'Cattv.ShutdownWindows.ShutdownReason') | The shutdown reason that will be logged. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the shutdown. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-String,System-TimeSpan,System-Boolean-'></a>
### Shutdown(message,delay,force) `method`

##### Summary

Initiate a shutdown.
If `delay` is greater than zero,
the shutdown can be aborted with [Abort](#M-Cattv-ShutdownWindows-ShutdownWindows-Abort 'Cattv.ShutdownWindows.ShutdownWindows.Abort').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message that will be displayed to the user. |
| delay | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second. |
| force | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Force the shutdown. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the shutdown. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-String,System-TimeSpan-'></a>
### Shutdown(message,delay) `method`

##### Summary

Initiate a shutdown.
If `delay` is greater than zero,
the shutdown can be aborted with [Abort](#M-Cattv-ShutdownWindows-ShutdownWindows-Abort 'Cattv.ShutdownWindows.ShutdownWindows.Abort').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message that will be displayed to the user. |
| delay | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the shutdown. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-String,System-Boolean-'></a>
### Shutdown(message,force) `method`

##### Summary

Initiate an immediate shutdown.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message that will be displayed to the user. |
| force | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Force the shutdown. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the shutdown. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-String,Cattv-ShutdownWindows-ShutdownReason-'></a>
### Shutdown(message,reason) `method`

##### Summary

Initiate an immediate shutdown.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message that will be displayed to the user. |
| reason | [Cattv.ShutdownWindows.ShutdownReason](#T-Cattv-ShutdownWindows-ShutdownReason 'Cattv.ShutdownWindows.ShutdownReason') | The shutdown reason that will be logged. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the shutdown. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-TimeSpan,System-Boolean-'></a>
### Shutdown(delay,force) `method`

##### Summary

Initiate a shutdown.
If `delay` is greater than zero,
the shutdown can be aborted with [Abort](#M-Cattv-ShutdownWindows-ShutdownWindows-Abort 'Cattv.ShutdownWindows.ShutdownWindows.Abort').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| delay | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second. |
| force | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Force the shutdown. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the shutdown. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-TimeSpan,Cattv-ShutdownWindows-ShutdownReason-'></a>
### Shutdown(delay,reason) `method`

##### Summary

Initiate a shutdown.
If `delay` is greater than zero,
the shutdown can be aborted with [Abort](#M-Cattv-ShutdownWindows-ShutdownWindows-Abort 'Cattv.ShutdownWindows.ShutdownWindows.Abort').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| delay | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second. |
| reason | [Cattv.ShutdownWindows.ShutdownReason](#T-Cattv-ShutdownWindows-ShutdownReason 'Cattv.ShutdownWindows.ShutdownReason') | The shutdown reason that will be logged. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the shutdown. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-Boolean,Cattv-ShutdownWindows-ShutdownReason-'></a>
### Shutdown(force,reason) `method`

##### Summary

Initiate an immediate shutdown.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| force | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Force the shutdown. |
| reason | [Cattv.ShutdownWindows.ShutdownReason](#T-Cattv-ShutdownWindows-ShutdownReason 'Cattv.ShutdownWindows.ShutdownReason') | The shutdown reason that will be logged. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the shutdown. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-String-'></a>
### Shutdown(message) `method`

##### Summary

Initiate an immediate shutdown.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message that will be displayed to the user. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the shutdown. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-TimeSpan-'></a>
### Shutdown(delay) `method`

##### Summary

Initiate a shutdown.
If `delay` is greater than zero,
the shutdown can be aborted with [Abort](#M-Cattv-ShutdownWindows-ShutdownWindows-Abort 'Cattv.ShutdownWindows.ShutdownWindows.Abort').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| delay | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the shutdown. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-System-Boolean-'></a>
### Shutdown(force) `method`

##### Summary

Initiate an immediate shutdown.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| force | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Force the shutdown. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the shutdown. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown-Cattv-ShutdownWindows-ShutdownReason-'></a>
### Shutdown(reason) `method`

##### Summary

Initiate an immediate shutdown.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reason | [Cattv.ShutdownWindows.ShutdownReason](#T-Cattv-ShutdownWindows-ShutdownReason 'Cattv.ShutdownWindows.ShutdownReason') | The shutdown reason that will be logged. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the shutdown. |

<a name='M-Cattv-ShutdownWindows-ShutdownWindows-Shutdown'></a>
### Shutdown() `method`

##### Summary

Initiate an immediate shutdown.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Cattv.ShutdownWindows.ShutdownException](#T-Cattv-ShutdownWindows-ShutdownException 'Cattv.ShutdownWindows.ShutdownException') | An error occurred when attempting the shutdown. |
