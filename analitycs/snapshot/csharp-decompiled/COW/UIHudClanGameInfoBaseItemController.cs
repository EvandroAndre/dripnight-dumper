using GCommon;

namespace COW;

public class UIHudClanGameInfoBaseItemController : UIBaseController, IUIModelDataChangeObserver
{
	private UIHudClanGameInfoBaseItemView m_View;

	private ClanWarInGameItemInfo m_Info;

	private UIModelClanWarV2 m_ModelClanWarV2;

	private UIModelLeaderBoard m_ModelLeaderBoard;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected void RefreshClanBg()
	{
	}

	protected void RefreshRankList()
	{
	}

	public virtual void RefreshView(object data, int index)
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
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

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
