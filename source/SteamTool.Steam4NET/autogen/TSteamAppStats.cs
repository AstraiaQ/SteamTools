// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct TSteamAppStats
	{
		public UInt32 uNumApps;
		public UInt32 uMaxNameChars;
		public UInt32 uMaxInstallDirNameChars;
		public UInt32 uMaxVersionLabelChars;
		public UInt32 uMaxLaunchOptions;
		public UInt32 uMaxLaunchOptionDescChars;
		public UInt32 uMaxLaunchOptionCmdLineChars;
		public UInt32 uMaxNumIcons;
		public UInt32 uMaxIconSize;
		public UInt32 uMaxDependencies;
	};
	
}