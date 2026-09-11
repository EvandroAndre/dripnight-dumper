using GCommon;

namespace COW;

public class UICustomRoomCountDownWindowController : UIPopupWindowController
{
	private UICustomRoomCountDownWindowView m_View;

	private UIModelCustomRoom m_Model;

	private ulong m_CountDownTimeStampMS;

	private uint m_CountDownTime;

	private uint m_CurrentCountDownTime;

	private uint m_LastCountDownTime;

	private bool m_IsRoomOwner;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	private void FixedUpdate()
	{
	}

	public void SetCountDownTime(uint time)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
