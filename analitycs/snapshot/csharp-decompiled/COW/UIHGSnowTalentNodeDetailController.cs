using GCommon;

namespace COW;

internal class UIHGSnowTalentNodeDetailController : UIBaseController, IUIModelDataChangeObserver
{
	private UIHGSnowTalentNodeDetailView m_View;

	private UIModelHuntingGround m_Model;

	private uint m_TalentId;

	private bool m_EnoughToken;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(uint talentId)
	{
	}

	public int GetWidth()
	{
		return 0;
	}

	public int GetHeight()
	{
		return 0;
	}

	private void OnBtnActivateClick()
	{
	}

	private void OnBtnHideClick()
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
}
