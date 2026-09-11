using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public static class PermissionUtility
{
	public enum Permission
	{
		None,
		ReadExternalStorage,
		WriteExternalStorage,
		PhoneState,
		Microphone,
		BluetoothConnect,
		PostNotifications,
		Camera,
		PreciseLocation_Foreground,
		ReadCalendar,
		WriteCalendar
	}

	public delegate void OnPermissionsResult(Dictionary<int, bool> results);

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__21_0;

		internal void _003CRequestCriticalPermissions_Android_003Eb__21_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public Permission permission;

		public bool critical;

		internal void _003C_ShowPermissionRationale_Android_003Eb__0()
		{
		}

		internal void _003C_ShowPermissionRationale_Android_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public bool critical;

		internal void _003C_ShowGotoApplicationDetailsSettings_Android_003Eb__0()
		{
		}

		internal void _003C_ShowGotoApplicationDetailsSettings_Android_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public bool critical;

		internal void _003C_RequestPermission_Android_003Eb__0(PlatformUtility_Android.RequestPermissionResult result)
		{
		}
	}

	private static readonly int[] CRITICAL_PERMISSIONS_ANDROID_29_AND_BELOW;

	private static readonly int[] CRITICAL_PERMISSIONS_ANDROID_30_AND_ABOVE;

	private static readonly int[] CRITICAL_PERMISSIONS_NONE;

	public static readonly int[] Permissions_Trivial;

	private static OnPermissionsResult _OnPermissionsResultCallback;

	private static readonly Dictionary<int, string> _AndroidPermissions;

	private static readonly Dictionary<int, bool> _AndroidPermissions_AllowSilentFailures;

	private static Dictionary<int, bool> _PermissionStatus_Android;

	private static Dictionary<int, bool> _PermissionAttempt_Android;

	private static Dictionary<int, bool> _PermissionRationale_Android;

	private static int[] _RequestingTrivialPermissions;

	private const string PERMISSION_RATIONALES_ALERT_DIALOG_IDENTIFIER = "PermissionRationalesAlertDialogIdentifier";

	private const string PERMISSION_RATIONALE_ALERT_DIALOG_IDENTIFIER = "PermissionRationaleAlertDialogIdentifier";

	private const string GOTO_APPLICATION_DETAILS_SETTINGS_ALERT_DIALOG_IDENTIFIER = "GotoApplicationDetailsSettingsAlertDialogIdentifier";

	public static int[] Permissions_Critical => null;

	public static bool CheckPermissions(int[] permissions, Dictionary<int, bool> results)
	{
		return false;
	}

	public static void UpdatePermissions(int[] permissions, Action<bool> resultCallback)
	{
	}

	public static void RequestCriticalPermissions(OnPermissionsResult callback)
	{
	}

	public static void RequestTrivialPermissions(int[] permissions, OnPermissionsResult callback)
	{
	}

	private static bool CheckPermissions_Android(int[] permissions)
	{
		return false;
	}

	private static void UpdatePermissionStatus_Android()
	{
	}

	private static void DoCallback_Android()
	{
	}

	private static void RequestCriticalPermissions_Android()
	{
	}

	private static void _RequestPermissions_Android(bool critical)
	{
	}

	private static void RequestTrivialPermissions_Android(int[] permissions)
	{
	}

	private static void RequestPermission_Android(Permission permission, bool critical)
	{
	}

	private static void _ShowPermissionRationale_Android(Permission permission, bool critical)
	{
	}

	private static void _ShowGotoApplicationDetailsSettings_Android(Permission permission, bool critical)
	{
	}

	private static void _RequestPermission_Android(Permission permission, bool critical)
	{
	}
}
