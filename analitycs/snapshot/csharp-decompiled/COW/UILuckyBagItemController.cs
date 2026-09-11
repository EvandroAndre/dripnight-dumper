using GCommon;
using proto;

namespace COW;

public class UILuckyBagItemController : UIEasyListItemController
{
	private UILuckyBagItemView m_View;

	private ClanLuckyBag m_Data;

	private UIModelClan.LuckyBagState m_LuckyBagState;

	private UIModelClan m_ModelClan;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshDrawBtnByState()
	{
	}

	private void RefreshDrawTimes()
	{
	}

	private void RefreshCountDownLabel()
	{
	}

	private void OnCountDownFinish()
	{
	}

	private void RefreshLuckyBagMessage()
	{
	}

	private void RefreshLuckyBagSprite()
	{
	}

	private void OnDrawBtnClick()
	{
	}

	private void OnLuckyBagBtnClick()
	{
	}

	private void OnLuckyBagMessageClick()
	{
	}

	private string GetLuckyBagDescriptionByLevel(uint level)
	{
		return null;
	}

	public void EnbaleAnimation(bool v)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
