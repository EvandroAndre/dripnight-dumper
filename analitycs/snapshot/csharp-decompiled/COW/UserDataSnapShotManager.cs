using GCommon;

namespace COW;

public class UserDataSnapShotManager : SingletonModule<UserDataSnapShotManager>
{
	private byte m_ReadyFlag;

	private const byte ALL_STEP_READY = 3;

	private EventLogger.EventTypeLoginSummary m_UserDataSnapShotData;

	private byte ReadyFlag
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private bool IsAllReady => false;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	private void SendLog()
	{
	}

	public void NotifySnapShotDataReady(UserDataSnapShotType type, string nameField, object data)
	{
	}

	public void SetValue(string nameField, object data)
	{
	}
}
