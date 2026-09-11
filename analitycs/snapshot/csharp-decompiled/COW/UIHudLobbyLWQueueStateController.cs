using GCommon;

namespace COW;

public class UIHudLobbyLWQueueStateController : UIBaseController
{
	private UIHudLobbyLWQueueStateView m_View;

	private byte m_ZoneIndex;

	private ELobbyLWQueueState m_State;

	public ELobbyLWQueueState State => ELobbyLWQueueState.None;

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

	public void RefreshQueueState(byte zoneIndex, int queuePosition, bool isDefender)
	{
	}

	public void SetTeleportingState(byte zoneIndex)
	{
	}

	private void SetState(ELobbyLWQueueState state, int queuePosition)
	{
	}

	private void RefreshStatus()
	{
	}

	private void RefreshQueueNumber(int queuePosition)
	{
	}

	private void OnBtnLeaveClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
