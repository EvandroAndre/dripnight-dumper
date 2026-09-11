using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UIReserveGroupMemberInfoController : UIBaseController, IUIModelDataChangeObserver
{
	private static readonly float[] m_FakeMemberScale;

	private static readonly float[] m_PentaFakeMemberScale;

	private UIReserveGroupMemberInfoView m_View;

	private GroupReservationShowInfo m_Info;

	private GameObject m_FakeMemberObj;

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

	public void RefreshView(GroupReservationShowInfo info, int idx, Vector3 fakeMemberTrans)
	{
	}

	private void RefreshTimeAndGameMode()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private bool _003CRefreshTimeAndGameMode_003Eb__9_0(FriendAccountInfo x)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
