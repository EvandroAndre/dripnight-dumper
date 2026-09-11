using GCommon;

namespace COW;

public class UIHudDriftBottleAddFriendController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public UIHudDriftBottleAddFriendController _003C_003E4__this;

		public float closeTime;

		internal void _003CShowMessage_003Eb__0()
		{
		}

		internal void _003CShowMessage_003Eb__1()
		{
		}
	}

	private UIHudDriftBottleAddFriendView m_View;

	private UIModelFriends m_Model;

	private uint m_CloseDelayCallID;

	private uint m_TimeDelayCallID;

	private ulong m_BindUserID;

	private string m_LockRegion;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ShowMessage(ulong userID, string userName, string lockRegion)
	{
	}

	private void OnOkBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
