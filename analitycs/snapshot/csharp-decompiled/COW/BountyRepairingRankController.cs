using GCommon;

namespace COW;

public class BountyRepairingRankController : UIBaseController, IUIModelDataChangeObserver
{
	private UIHUDBountyRepairRankView m_View;

	private uint localPlayerPoint;

	private UIModelMatch m_MatchModel;

	private bool m_IsLockRepair;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitItemContent(BountyRepairingItem item)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnRepairRankChange(object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void LockTeleportMachine()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
