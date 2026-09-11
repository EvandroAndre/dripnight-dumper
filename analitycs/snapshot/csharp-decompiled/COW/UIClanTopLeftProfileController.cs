using GCommon;

namespace COW;

internal class UIClanTopLeftProfileController : UIBaseController, IUIModelDataChangeObserver
{
	private UIClanTopLeftProfileView m_View;

	private UIModelClan m_ModelClan;

	private UIModelClanWarV2 m_ModelClanWarV2;

	private UIModelLeaderBoardTitle m_ModelLeaderBoardTitle;

	private UILeaderBoardTitleIconController m_LeaderBoardTitleIcon;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Refresh()
	{
	}

	private void OnBtnClick()
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
