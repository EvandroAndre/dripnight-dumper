using GCommon;

namespace COW;

public class UILobbyV2LobbySwitchBtnController : UIBaseController, IUIModelDataChangeObserver
{
	private enum EGuideType3D
	{
		Banner = 1,
		ReturnTo2DLobby = 2,
		Click = 4
	}

	private enum EGuideType2D
	{
		ReturnTo3DLobby = 1,
		Click
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public UILobbyV2LobbySwitchBtnController _003C_003E4__this;

		public UIModelMatch matchModel;

		internal void _003COnSwitchBtnClick_003Eb__0()
		{
		}
	}

	private UILobbyV2LobbySwitchBtnView m_View;

	private static ulong s_LastSwitchTime;

	private static string IsDefault3DLobbyKey;

	private UIModelOptionalDownload m_ModelDownload;

	private UINewDownloadInfoController m_DownloadCtrl;

	private float m_NextCheckTime;

	private readonly float GuideDuraionFor3D;

	private readonly float GuideDuraionFor2D;

	private uint m_Guide2DDelayCallKey;

	private uint m_Guide3DDelayCallKey;

	public static bool IsLobbySocialAreaSwitchInCD()
	{
		return false;
	}

	public static void UpdateLobbySocialAreaSwitchTime()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public static bool CanShowSocialHall3DEntrance()
	{
		return false;
	}

	public static bool IsDefault3DLobby()
	{
		return false;
	}

	public static bool IsSettedDefault3DLobby()
	{
		return false;
	}

	public static void SetDefault3DLobby(bool isDefault3DLobby)
	{
	}

	private void FixedUpdate()
	{
	}

	private void RefreshDownloadState()
	{
	}

	private void OnDownloadStateChangeCallback()
	{
	}

	private void SetDownloadContainerVisable(bool isShow)
	{
	}

	private bool IsNinthResDownloadReady()
	{
		return false;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void LogClick(string posfix)
	{
	}

	private void OnSwitchBtnClick()
	{
	}

	private void RevertGuide()
	{
	}

	private void ClearDelayCall()
	{
	}

	private void CheckGuide()
	{
	}

	private void OnLobbyEntranceBannerAnimationFinished()
	{
	}

	private void Check3DGuide()
	{
	}

	private void OnNinthStatueToSocialArea()
	{
	}

	private void Check2DGuide()
	{
	}

	private void _003COnLobbyEntranceBannerAnimationFinished_003Eb__35_0()
	{
	}

	private void _003CCheck3DGuide_003Eb__36_0()
	{
	}

	private void _003CCheck2DGuide_003Eb__38_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
