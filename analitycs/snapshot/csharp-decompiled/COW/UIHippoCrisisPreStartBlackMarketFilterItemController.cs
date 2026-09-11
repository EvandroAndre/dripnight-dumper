using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisPreStartBlackMarketFilterItemController : UIBaseController, UITable2.IUITable2Item
{
	private UIHippoCrisisPreStartBlackMarketFilterItemView m_View;

	private UIPopMenuSmallControler m_MarketPopMenuCtrl;

	private uint m_CurrentQualityFilter;

	private Dictionary<uint, string> m_PopMenuToKey;

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

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	private void GeneratePopMenuData()
	{
	}

	private void OnPopMenuSelect(object data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
