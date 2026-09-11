using GCommon;

namespace COW;

internal class UIClanMemberTabItemController : UIStandardTabItemRemakeController, IUIModelDataChangeObserver
{
	private uint m_OnlineNum;

	private UIClanMemberTabItemViewExt m_ViewExt;

	private UIModelClan m_ModelClan;

	protected override void OnUIInit()
	{
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void RefreshData()
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
}
