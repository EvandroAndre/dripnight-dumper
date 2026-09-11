using GCommon;
using proto;

namespace COW;

public class UIClanActiveWayItemController : UIBaseController, IUIModelDataChangeObserver
{
	private UIClanActiveWayItemView m_View;

	private ClanActiveWay m_ClanActiveWay;

	private UIModelClanWarV2 m_ModelClanWar;

	private UIModelClan m_ModelClan;

	private UIModelBooyahPass m_ModelBooyahPass;

	private ClanActiveShowDesc m_ClanActiveShowDesc;

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

	public void SetViewData(ClanActiveWay clanActiveWay, ClanActiveShowDesc desc)
	{
	}

	public void RefreshShowInfo()
	{
	}

	private void OnGotoBtnClick()
	{
	}

	private void RefreshPlayWithClanMemberInfo()
	{
	}

	private void RefreshDailyMissionInfo()
	{
	}

	private void RefreshClanWarInfo()
	{
	}

	private void RefreshStoreInfo()
	{
	}

	private void GotoClanWar()
	{
	}

	private void OnGotoStoreBtnClick()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
