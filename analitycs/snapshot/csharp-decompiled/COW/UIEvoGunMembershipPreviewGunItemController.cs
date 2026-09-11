using GCommon;

namespace COW;

public class UIEvoGunMembershipPreviewGunItemController : UIBaseController, IUIModelDataChangeObserver
{
	private UIEvoGunMembershipPreviewGunItemView m_View;

	private UIFullScreenPreviewEvoGunMemberShipController m_Parent;

	private uint m_Id;

	private int m_Index;

	private bool iconIsReady;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void OnClick()
	{
	}

	public void SetData(uint id, int index)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
