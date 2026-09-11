using GCommon;
using tcp;

namespace COW;

internal class UIRoomTeamInfoItemController : UILobbyV2TeamInfoItemController
{
	private RoomPlayerInfo m_Memeber;

	private UIModelCustomRoom m_ModelRoom;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void PlayAnim()
	{
	}

	public void StopAnimToEnd()
	{
	}

	public void SetRoomViewData(RoomPlayerInfo member)
	{
	}

	private ResourceID GetResIdByMember(RoomPlayerInfo member)
	{
		return default(ResourceID);
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
