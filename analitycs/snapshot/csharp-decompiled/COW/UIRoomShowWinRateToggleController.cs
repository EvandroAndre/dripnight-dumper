using GCommon;

namespace COW;

public class UIRoomShowWinRateToggleController : UIBaseController
{
	private const string ShowWinRateTipsKey = "T_54_D_SHOWWINRATE_SWITCHINFO";

	private UIRoomShowWinRateToggleView m_View;

	private UIModelCustomRoom m_CustomRoomModel;

	private bool m_IgnoreToggleChange;

	private bool m_SaveShowWinSelectedPlayerPref;

	private uint m_CurrentGameMode;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void Init()
	{
	}

	public void SetToggleState(bool isOn)
	{
	}

	public void RefreshByGameMode(uint gameMode, bool forceRefresh = false)
	{
	}

	public bool IsOn()
	{
		return false;
	}

	private void RefreshStats(RoomWinRateModeData data)
	{
	}

	private void RefreshEmptyStats()
	{
	}

	private void RefreshNewTag()
	{
	}

	private void RefreshCheckView(bool isOn)
	{
	}

	private void OnCheckBtnChanged()
	{
	}

	private void OnHelpBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
