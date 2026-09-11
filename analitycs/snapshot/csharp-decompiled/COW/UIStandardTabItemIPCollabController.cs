using GCommon;
using UnityEngine;

namespace COW;

public class UIStandardTabItemIPCollabController : UIStandardTabItemRemakeController, IUIModelDataChangeObserver
{
	private UIModelIPCollab m_ModelIPCollab;

	private UIModelInventory m_ModelInventory;

	private static Color32 selectNumberLabelColor;

	private static Color32 selectNumberLabelColorLow;

	private static Color32 unselectNumberLabelColor;

	private static Color32 unselectNumberLabelColorLow;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override UIStandardSubTabItemController CreateSubTabItem(Transform container, bool isLastSubTab)
	{
		return null;
	}

	public override void CheckTagState()
	{
	}

	public override void CheckTipButton()
	{
	}

	private void RefreshNumberLabel(uint iPCollabID)
	{
	}

	public void SetSelectNumberLabel(string number)
	{
	}

	private void RefreshRedPoint(uint IPCollabID)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new UIStandardSubTabItemController _003C_003EiFixBaseProxy_CreateSubTabItem(Transform P0, bool P1)
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_CheckTagState()
	{
	}

	public void _003C_003EiFixBaseProxy_CheckTipButton()
	{
	}
}
