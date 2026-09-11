using GCommon;

namespace COW;

public class UIHudMatchResultSpecialBonusItemController : UIBaseController
{
	private UIHudMatchResultSpecialBonusItemView m_View;

	private string m_TipsDesc;

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

	public void SetViewData(uint specicalBonusType, uint matchMode, uint param = 0u, bool isNoStar = false, bool isNoReward = false)
	{
	}

	private void SetNormalStyleTip(string desc)
	{
	}

	private void OnTipsBtnClick()
	{
	}

	private void RefreshToxicLabels(bool isNoStar, bool isNoReward)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
