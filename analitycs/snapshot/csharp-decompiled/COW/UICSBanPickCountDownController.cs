using GCommon;

namespace COW;

public class UICSBanPickCountDownController : UIPopupWindowController
{
	private UICustomRoomCountDownWindowView m_View;

	private UIModelBanPick m_Model;

	private ulong m_CountDownTimeStampMS;

	private uint m_CountDownTime;

	private uint m_CurrentCountDownTime;

	private uint m_LastCountDownTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
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

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
