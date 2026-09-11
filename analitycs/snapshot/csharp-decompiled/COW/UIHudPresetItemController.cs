using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

internal class UIHudPresetItemController : UIBaseController
{
	private UIHudPresetItemView m_View;

	private int m_Index;

	private UIHudPresetController m_Parent;

	private List<UISprite> m_ItemViewList;

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

	private void OnItemBtnClick()
	{
	}

	public void SetUIData(int idex, List<MOHNBCEFAHC> data, UIHudPresetController parent)
	{
	}

	public UIToggleButton GetUIToggleButton()
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
