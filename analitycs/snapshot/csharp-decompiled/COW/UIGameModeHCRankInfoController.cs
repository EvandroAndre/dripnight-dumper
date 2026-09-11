using GCommon;

namespace COW;

public class UIGameModeHCRankInfoController : UIBaseController, IUIModelDataChangeObserver
{
	private UIGameModeHCRankInfoView m_View;

	private UIHippoCrisisRankIconController m_RankCtrl;

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

	private void RefreshRankInfo()
	{
	}

	private void ClickRankBtn()
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
