using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelLab : UIBaseModel
{
	public enum LabEntranceState
	{
		Unknown,
		NotFound,
		BeforePre,
		Pre,
		Open,
		Closed
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public UIModelLab _003C_003E4__this;

		public HttpManager.EHttpChannel channel;

		internal void _003CRequestLabSetting_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private List<LabDesc> m_LabSystemDesc;

	public const uint PropID_LabReady = 1u;

	public const string PlayerPresKey_LabLobbyEntrance_Time = "LabLobbyEntranceTime_{0}";

	public const string PlayerPresKey_LabLobbyEntrance_NewTips = "LabLobbyEntranceNewTips_{0}";

	public const string PlayerPresKey_LabLobbyEntrance_LengenCloth = "LabLobbyEntrance_LengenCloth_{0}";

	public const string PlayerPresKey_LabLobbyEntrance_HyperBook = "LabLobbyEntrance_HyperBook_{0}";

	public const string PlayerPresKey_LabLobbyEntrance_VirtualBrand = "LabLobbyEntrance_VirtualBrand_{0}";

	private bool IsReady => false;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void RequestLabSetting(bool silence, LoadingType loadingType = LoadingType.CircleLoading, bool isLogin = false, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	private void OnRequestLabSettingFinished(HttpErrorCode errorCode, object result)
	{
	}

	private void OnRequestLabSettingFinishedForLogin(HttpErrorCode errorCode, object result, HttpManager.EHttpChannel channel)
	{
	}

	public bool ResendRequestIfPreviousFailed()
	{
		return false;
	}

	private static LabEntranceState GetLabEntranceStateInternal(LabDesc desc)
	{
		return LabEntranceState.Unknown;
	}

	private static bool IsLabEntranceStateVisibleInternal(LabEntranceState state)
	{
		return false;
	}

	public bool IsSystemAvailable()
	{
		return false;
	}

	public int GetVisibleLabEntranceCount()
	{
		return 0;
	}

	public LabEntranceState GetLabEntranceStateByID(uint systemID)
	{
		return LabEntranceState.Unknown;
	}

	public uint GetLabEntranceSortID(uint systemID)
	{
		return 0u;
	}

	public long GetLabEntranceOpenTime(uint systemID)
	{
		return 0L;
	}

	public LabDesc GetCollabIPDesc(uint systemID)
	{
		return null;
	}

	public void UpdateLabRedTips()
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
