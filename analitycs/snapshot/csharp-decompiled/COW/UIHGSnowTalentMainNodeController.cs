using GCommon;

namespace COW;

internal class UIHGSnowTalentMainNodeController : UIBaseController, IUIModelDataChangeObserver
{
	private uint m_TalentId;

	private UIModelHuntingGround m_Model;

	private UIHGSnowTalentMainNodeView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnBtnDetailClick()
	{
	}

	private void OnShowDetail(object[] data)
	{
	}

	public void SetData(uint talentId)
	{
	}

	private void RefreshRedTips()
	{
	}

	private void UnlockTalent()
	{
	}

	public UIWidget GetGuideWidget()
	{
		return null;
	}

	public UIButton GetGuideBtn()
	{
		return null;
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
