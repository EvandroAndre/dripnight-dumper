using GCommon;

namespace COW;

public class UICreateRoomCoolDownContoller : UIPopupWindowController
{
	private UISecondConfirmSmallView m_View;

	private float m_NextUpdateTime;

	private int m_RestTime;

	private string m_BaseString;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnConfirmClick()
	{
	}

	private void Update()
	{
	}

	public void SetCoolDownTime(ulong endTime)
	{
	}

	public override void EnterByReturn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_EnterByReturn()
	{
	}
}
