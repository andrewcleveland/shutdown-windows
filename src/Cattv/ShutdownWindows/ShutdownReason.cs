using System;
using Windows.Win32.System.Shutdown;

namespace Cattv.ShutdownWindows
{
    /// <summary>
    /// Shutdown reason codes.
    /// </summary>
    [Flags]
    public enum ShutdownReason : uint
    {
        #region Other

        /// <summary>
        /// Other (Unplanned)
        /// </summary>
        OtherUnplanned = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_OTHER |
                            SHUTDOWN_REASON.SHTDN_REASON_MINOR_OTHER, // 0

        /// <summary>
        /// Other (Planned)
        /// </summary>
        OtherPlanned = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_OTHER |
                            SHUTDOWN_REASON.SHTDN_REASON_MINOR_OTHER |
                            SHUTDOWN_REASON.SHTDN_REASON_FLAG_PLANNED,

        #endregion

        #region Major reason codes

        /// <summary>
        /// Application issue.
        /// </summary>
        MajorApplication = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_APPLICATION,

        /// <summary>
        /// Hardware issue.
        /// </summary>
        MajorHardware = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_HARDWARE,

        /// <summary>
        /// Legacy API shutdown
        /// </summary>
        MajorLegacyApi = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_LEGACY_API,

        /// <summary>
        /// Operating system issue.
        /// </summary>
        MajorOperatingSystem = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_OPERATINGSYSTEM,

        /// <summary>
        /// Other issue.
        /// </summary>
        MajorOther = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_OTHER,

        /// <summary>
        /// Power failure.
        /// </summary>
        MajorPower = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_POWER,

        /// <summary>
        /// Software issue.
        /// </summary>
        MajorSoftware = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_SOFTWARE,

        /// <summary>
        /// System failure.
        /// </summary>
        MajorSystem = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_SYSTEM,

        #endregion

        #region Minor reason codes

        /// <summary>
        /// Blue screen crash event.
        /// </summary>
        MinorBlueScreen = SHUTDOWN_REASON.SHTDN_REASON_MINOR_BLUESCREEN,

        /// <summary>
        /// Unplugged.
        /// </summary>
        MinorCordUnplugged = SHUTDOWN_REASON.SHTDN_REASON_MINOR_CORDUNPLUGGED,

        /// <summary>
        /// Disk.
        /// </summary>
        MinorDisk = SHUTDOWN_REASON.SHTDN_REASON_MINOR_DISK,

        /// <summary>
        /// Environment.
        /// </summary>
        MinorEnvironment = SHUTDOWN_REASON.SHTDN_REASON_MINOR_ENVIRONMENT,

        /// <summary>
        /// Driver.
        /// </summary>
        MinorHardwareDriver = SHUTDOWN_REASON.SHTDN_REASON_MINOR_HARDWARE_DRIVER,

        /// <summary>
        /// Hot fix.
        /// </summary>
        MinorHotfix = SHUTDOWN_REASON.SHTDN_REASON_MINOR_HOTFIX,

        /// <summary>
        /// Hot fix uninstallation.
        /// </summary>
        MinorHotfixUninstall = SHUTDOWN_REASON.SHTDN_REASON_MINOR_HOTFIX_UNINSTALL,

        /// <summary>
        /// Unresponsive.
        /// </summary>
        MinorHung = SHUTDOWN_REASON.SHTDN_REASON_MINOR_HUNG,

        /// <summary>
        /// Installation.
        /// </summary>
        MinorInstallation = SHUTDOWN_REASON.SHTDN_REASON_MINOR_INSTALLATION,

        /// <summary>
        /// Maintenance.
        /// </summary>
        MinorMaintenance = SHUTDOWN_REASON.SHTDN_REASON_MINOR_MAINTENANCE,

        /// <summary>
        /// MMC issue.
        /// </summary>
        MinorMmc = SHUTDOWN_REASON.SHTDN_REASON_MINOR_MMC,

        /// <summary>
        /// Network connectivity.
        /// </summary>
        MinorNetworkConnectivity = SHUTDOWN_REASON.SHTDN_REASON_MINOR_NETWORK_CONNECTIVITY,

        /// <summary>
        /// Network card.
        /// </summary>
        MinorNetworkCard = SHUTDOWN_REASON.SHTDN_REASON_MINOR_NETWORKCARD,

        /// <summary>
        /// Other issue.
        /// </summary>
        MinorOther = SHUTDOWN_REASON.SHTDN_REASON_MINOR_OTHER,

        /// <summary>
        /// Other driver event.
        /// </summary>
        MinorOtherDriver = SHUTDOWN_REASON.SHTDN_REASON_MINOR_OTHERDRIVER,

        /// <summary>
        /// Power supply.
        /// </summary>
        MinorPowerSupply = SHUTDOWN_REASON.SHTDN_REASON_MINOR_POWER_SUPPLY,

        /// <summary>
        /// Processor.
        /// </summary>
        MinorProcessor = SHUTDOWN_REASON.SHTDN_REASON_MINOR_PROCESSOR,

        /// <summary>
        /// Reconfigure.
        /// </summary>
        MinorReconfig = SHUTDOWN_REASON.SHTDN_REASON_MINOR_RECONFIG,

        /// <summary>
        /// Security issue.
        /// </summary>
        MinorSecurity = SHUTDOWN_REASON.SHTDN_REASON_MINOR_SECURITY,

        /// <summary>
        /// Security patch.
        /// </summary>
        MinorSecurityFix = SHUTDOWN_REASON.SHTDN_REASON_MINOR_SECURITYFIX,

        /// <summary>
        /// Security patch uninstallation.
        /// </summary>
        MinorSecurityFixUninstall = SHUTDOWN_REASON.SHTDN_REASON_MINOR_SECURITYFIX_UNINSTALL,

        /// <summary>
        /// Service pack.
        /// </summary>
        MinorServicePack = SHUTDOWN_REASON.SHTDN_REASON_MINOR_SERVICEPACK,

        /// <summary>
        /// Service pack uninstallation.
        /// </summary>
        MinorServicePackUninstall = SHUTDOWN_REASON.SHTDN_REASON_MINOR_SERVICEPACK_UNINSTALL,

        /// <summary>
        /// Terminal Services.
        /// </summary>
        MinorTerminalServices = SHUTDOWN_REASON.SHTDN_REASON_MINOR_TERMSRV,

        /// <summary>
        /// Unstable.
        /// </summary>
        MinorUnstable = SHUTDOWN_REASON.SHTDN_REASON_MINOR_UNSTABLE,

        /// <summary>
        /// Upgrade.
        /// </summary>
        MinorUpgrade = SHUTDOWN_REASON.SHTDN_REASON_MINOR_UPGRADE,

        /// <summary>
        /// WMI issue.
        /// </summary>
        MinorWmi = SHUTDOWN_REASON.SHTDN_REASON_MINOR_WMI,

        #endregion

        #region Flags

        /// <summary>
        /// The reason code is defined by the user.
        /// </summary>
        FlagUserDefined = SHUTDOWN_REASON.SHTDN_REASON_FLAG_USER_DEFINED,

        /// <summary>
        /// The shutdown was planned.
        /// </summary>
        FlagPlanned = SHUTDOWN_REASON.SHTDN_REASON_FLAG_PLANNED,

        #endregion

        #region Combinations

        /// <summary>
        /// Application: Unresponsive
        /// </summary>
        ApplicationUnresponsive = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_APPLICATION |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_HUNG,

        /// <summary>
        /// Application: Installation (Planned)
        /// </summary>
        ApplicationInstallationPlanned = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_APPLICATION |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_INSTALLATION |
                                                    SHUTDOWN_REASON.SHTDN_REASON_FLAG_PLANNED,

        /// <summary>
        /// Application: Maintenance (Unplanned)
        /// </summary>
        ApplicationMaintenanceUnplanned = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_APPLICATION |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_MAINTENANCE,

        /// <summary>
        /// Application: Maintenance (Planned)
        /// </summary>
        ApplicationMaintenancePlanned = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_APPLICATION |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_MAINTENANCE |
                                                    SHUTDOWN_REASON.SHTDN_REASON_FLAG_PLANNED,

        /// <summary>
        /// Application: Unstable
        /// </summary>
        ApplicationUnstable = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_APPLICATION |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_UNSTABLE,


        /// <summary>
        /// Hardware: Installation (Unplanned)
        /// </summary>
        HardwareInstallationUnplanned = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_HARDWARE |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_INSTALLATION,

        /// <summary>
        /// Hardware: Installation (Planned)
        /// </summary>
        HardwareInstallationPlanned = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_HARDWARE |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_INSTALLATION |
                                                    SHUTDOWN_REASON.SHTDN_REASON_FLAG_PLANNED,

        /// <summary>
        /// Hardware: Maintenance (Unplanned)
        /// </summary>
        HardwareMaintenanceUnplanned = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_HARDWARE |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_MAINTENANCE,

        /// <summary>
        /// Hardware: Maintenance (Planned)
        /// </summary>
        HardwareMaintenancePlanned = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_HARDWARE |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_MAINTENANCE |
                                                    SHUTDOWN_REASON.SHTDN_REASON_FLAG_PLANNED,

        /// <summary>
        /// Operating System: Hot fix (Unplanned)
        /// </summary>
        OperatingSystemHotFixUnplanned = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_OPERATINGSYSTEM |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_HOTFIX,

        /// <summary>
        /// Operating System: Hot fix (Planned)
        /// </summary>
        OperatingSystemHotFixPlanned = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_OPERATINGSYSTEM |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_HOTFIX |
                                                    SHUTDOWN_REASON.SHTDN_REASON_FLAG_PLANNED,

        /// <summary>
        /// Operating System: Reconfiguration (Unplanned)
        /// </summary>
        OperatingSystemReconfigurationUnplanned = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_OPERATINGSYSTEM |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_RECONFIG,

        /// <summary>
        /// Operating System: Reconfiguration (Planned)
        /// </summary>
        OperatingSystemReconfigurationPlanned = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_OPERATINGSYSTEM |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_RECONFIG |
                                                    SHUTDOWN_REASON.SHTDN_REASON_FLAG_PLANNED,

        /// <summary>
        /// Operating System: Security fix (Unplanned)
        /// </summary>
        OperatingSystemSecurityFixUnplanned = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_OPERATINGSYSTEM |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_SECURITYFIX,

        /// <summary>
        /// Operating System: Security fix (Planned)
        /// </summary>
        OperatingSystemSecurityFixPlanned = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_OPERATINGSYSTEM |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_SECURITYFIX |
                                                    SHUTDOWN_REASON.SHTDN_REASON_FLAG_PLANNED,

        /// <summary>
        /// Operating System: Service pack (Planned)
        /// </summary>
        OperatingSystemServicePackPlanned = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_OPERATINGSYSTEM |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_SERVICEPACK |
                                                    SHUTDOWN_REASON.SHTDN_REASON_FLAG_PLANNED,

        /// <summary>
        /// Operating System: Upgrade (Planned)
        /// </summary>
        OperatingSystemUpgradePlanned = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_OPERATINGSYSTEM |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_UPGRADE |
                                                    SHUTDOWN_REASON.SHTDN_REASON_FLAG_PLANNED,

        /// <summary>
        /// Other Failure: System Unresponsive
        /// </summary>
        OtherFailureSystemUnresponsive = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_OTHER |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_HUNG,

        /// <summary>
        /// Power Failure: Cord Unplugged
        /// </summary>
        PowerFailureCordUnplugged = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_POWER |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_CORDUNPLUGGED,

        /// <summary>
        /// Power Failure: Environment
        /// </summary>
        PowerFailureEnvironment = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_POWER |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_ENVIRONMENT,

        /// <summary>
        /// System Failure: Stop error
        /// </summary>
        SystemFailureStopError = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_SYSTEM |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_BLUESCREEN,

        /// <summary>
        /// Loss of network connectivity (Unplanned)
        /// </summary>
        LossOfNetworkConnectivityUnplanned = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_SYSTEM |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_NETWORK_CONNECTIVITY,

        /// <summary>
        /// Security issue
        /// </summary>
        SecurityIssue = SHUTDOWN_REASON.SHTDN_REASON_MAJOR_SYSTEM |
                                                    SHUTDOWN_REASON.SHTDN_REASON_MINOR_SECURITY

        #endregion
    }
}
