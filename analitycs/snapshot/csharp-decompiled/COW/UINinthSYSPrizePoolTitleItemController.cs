using GCommon;
using UnityEngine;

namespace COW;

public class UINinthSYSPrizePoolTitleItemController : UIBaseController, UITable2.IUITable2Item
{
	private UINinthSYSPrizePoolTitleItemView m_View;

	private UIModelNinthSYS.TitleAwardDesc m_TitleAwardDesc;

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

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	private string GetLevelSpriteName(bool isHigh)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
