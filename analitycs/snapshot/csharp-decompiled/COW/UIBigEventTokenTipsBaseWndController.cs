using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEventTokenTipsBaseWndController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
{
	private UIModelBigEvent m_ModelBigEvent;

	protected UIEasyList TokenItemContainer;

	protected UILabel Desc;

	protected uint m_TempTokenId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetToken(uint token_id, string token_desc = "")
	{
	}

	private void OnClickTokenLinkCallback(object[] data)
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public virtual UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected void OnShowTipsTokenInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
