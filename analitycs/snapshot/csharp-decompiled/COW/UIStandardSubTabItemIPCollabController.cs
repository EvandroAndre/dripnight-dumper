using GCommon;

namespace COW;

public class UIStandardSubTabItemIPCollabController : UIStandardSubTabItemRemakeController, IUIModelDataChangeObserver
{
	private UIModelIPCollab m_ModelIPCollab;

	private UIModelInventory m_ModelInventory;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
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

	protected override void OnUIDestory()
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

	public new void _003C_003EiFixBaseProxy_CheckTagState()
	{
	}

	public void _003C_003EiFixBaseProxy_CheckTipButton()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
