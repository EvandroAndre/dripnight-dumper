using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudAvatarAttributeBoxController : UIBaseController
{
	private UIHudAvatarAttributeBoxView m_View;

	private UIHudAvatarAttributeBagTipsController m_TipCtrl;

	private List<UIAvatarAttributeBoxItemController> m_CachItemCtrList;

	private AvatarAttributesInfoConfigManager m_ConfigMgr;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetShowData(List<uint> ownAttributes, uint mapID, uint gamemodeID, uint difficulty)
	{
	}

	private void TryGetOrCreateBoxItem(uint attributeId, int itemIndex, AvatarAttributesInfoConfigManager configDataManager, uint difficulty)
	{
	}

	private void HideNoUsedItemController(int beginIndex)
	{
	}

	private UIAvatarAttributeBoxItemController GetItemController(int index)
	{
		return null;
	}

	private void OnItemSelect(object[] data)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void CloseUI()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
