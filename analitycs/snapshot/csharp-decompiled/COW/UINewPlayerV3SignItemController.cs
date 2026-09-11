using GCommon;
using proto;

namespace COW;

internal class UINewPlayerV3SignItemController : UIBaseController
{
	public enum EAttendanceStatus
	{
		UnStarted,
		Award,
		Claimed
	}

	public enum EAwardType
	{
		None,
		SignAward,
		DailyBigReward
	}

	private UINewPlayerV3SignItemView m_View;

	private int m_Day;

	private UINewPlayerV3SignAwardItemController m_SignAwardItemCtrl;

	private UINewPlayerV3SignAwardItemController m_DailyBigAwardItemCtrl;

	private UIModelNewPlayerV3 m_ModelNewPlayer;

	public EAttendanceStatus StateSign => EAttendanceStatus.UnStarted;

	public EActivity.State StateDailyBigReward => EActivity.State.State_RECEIVED;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(int day)
	{
	}

	private void RefreshView()
	{
	}

	private void LoadStaticContent()
	{
	}

	private void RefreshDynamicContent()
	{
	}

	private void RefreshSignDynamicContent()
	{
	}

	private void RefreshDailyBigRewardDynamicContent()
	{
	}

	private BaseItemInfo GetBaseItemInfo(EAwardType type)
	{
		return null;
	}

	private void OnClaimSignAwardBtnClick()
	{
	}

	private void OnClaimDailyBigRewardBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
