using System;
using COW.Location;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelLocalization : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<HttpErrorCode, object> _003C_003E9__20_0;

		internal void _003CClearLocationRequest_003Eb__20_0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public UIModelLocalization _003C_003E4__this;

		public Action onSuccess;

		public Action onError;

		internal void _003CUpdateLocation_003Eb__0(GPSLocationData data)
		{
		}

		internal void _003CUpdateLocation_003Eb__1(string error)
		{
		}
	}

	public const uint PropID_LocationUpdate = 2u;

	public const uint PropID_LocationUpload = 4u;

	public const uint PropID_LBSBanInfoUpdate = 8u;

	private double m_MyLatitude;

	private double m_MyLongitude;

	private bool m_HasValidLocation;

	private float m_LastUpdateTime;

	private float m_LastUploadTime;

	private bool m_LastPermissionState;

	private long m_LBSBanUntilTimestamp;

	public bool IsLBSFeatureBanned => false;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public override void Login(object[] data)
	{
	}

	protected override void OnCleanup()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void UpdateLocation(Action onSuccess = null, Action onError = null, bool forceUpdate = false)
	{
	}

	public void UploadLocationRequest(bool forceUpload = false)
	{
	}

	private void ResetLocationData()
	{
	}

	public void ClearLocationRequest()
	{
	}

	public bool HasValidLocation()
	{
		return false;
	}

	public bool TryGetLocation(out double latitude, out double longitude)
	{
		latitude = default(double);
		longitude = default(double);
		return false;
	}

	public bool IsLBSEnable()
	{
		return false;
	}

	public bool IsLBSFeatureAvailable()
	{
		return false;
	}

	public void SetLBSFeatureBanned(bool isBanned, long banUntilTimestamp = 0L)
	{
	}

	public void OnApplicationPause(bool paused)
	{
	}

	public void OnLocPermissionChanged()
	{
	}

	public void ForceSetLocation(double latitude, double longitude)
	{
	}

	public void RequestLbsInfo()
	{
	}

	public void OnUpdateLbsBanInfo(UpdateLbsBanInfoNtf ntf)
	{
	}

	private void UpdateLbsBanStatus(LbsBanInfo banInfo)
	{
	}

	private void _003CUploadLocationRequest_003Eb__18_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003COnApplicationPause_003Eb__26_0(bool hasPermission)
	{
	}

	private void _003COnLocPermissionChanged_003Eb__27_0()
	{
	}

	private void _003CRequestLbsInfo_003Eb__29_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
