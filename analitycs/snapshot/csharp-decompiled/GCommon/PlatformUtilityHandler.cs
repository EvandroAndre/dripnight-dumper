using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

internal class PlatformUtilityHandler : MonoBehaviour
{
	private const string PLATFORM_UTILITY_HANDLER = "PlatformUtilityHandler";

	private static PlatformUtilityHandler _I;

	private HashSet<string> _ScreenshotClues;

	public static void Init()
	{
	}

	public void OnBatteryChargingChanged(string message)
	{
	}

	public void OnBatteryLevelChanged(string message)
	{
	}

	public void OnSelectedImageFromAlbum(string path)
	{
	}

	public void OnSelectedVideoFromAlbum(string path)
	{
	}

	public void OnSentIntent(string empty)
	{
	}

	public void onRequestPermissionsResult(string result)
	{
	}

	public void onAlertDialogPositiveButtonClick(string identifier)
	{
	}

	public void onAlertDialogNegativeButtonClick(string identifier)
	{
	}

	public void onAlertDialogNeutralButtonClick(string identifier)
	{
	}

	public void onGetAdvertisingId(string result)
	{
	}

	public void onMainActivityConfigurationChanged(string data)
	{
	}

	public void onMainActivityDisplayChanged(string data)
	{
	}

	public void onInAppReviewCallback(string result)
	{
	}

	public void onTakenScreenshot(string clue)
	{
	}

	public void OnDataConnectionStateChanged(string data)
	{
	}

	public void OnNetworkCallbackLegacy(string data)
	{
	}

	public void OnNetworkCallback(string data)
	{
	}

	public void OnGenericMotionEvent(string data)
	{
	}

	public void OnCapturedPointer(string data)
	{
	}
}
