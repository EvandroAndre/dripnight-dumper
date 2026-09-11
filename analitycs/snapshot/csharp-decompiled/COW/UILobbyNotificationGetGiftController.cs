using GCommon;
using proto;

namespace COW;

public class UILobbyNotificationGetGiftController : UILobbyNotificationPopUpContentBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public UILobbyNotificationGetGiftController _003C_003E4__this;

		public MailInfo mail;

		internal void _003COnInteractionBtnClick_003Eb__0()
		{
		}
	}

	private UILobbyNotificationGetGiftView m_View;

	private UIModelMail m_ModelMail;

	private FriendInfo m_SenderInfo;

	private UIMallV2IntimacyProfileInfoController m_CallsignCtrl;

	private bool m_IsIgnore;

	private bool m_IsInfoReady;

	private bool m_IsMailReady;

	private bool m_IsRequestingAccountInfo;

	private bool m_IsRequestingMailList;

	private bool m_IsMailNtfRegistered;

	private ulong m_SenderAccountID;

	private uint m_ItemID;

	private uint m_ItemCnt;

	private ulong m_MailID;

	private MailInfo m_GiftMail;

	private bool IsMailNtfRegistered
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected override ENotificationPopUpType NotificationType => ENotificationPopUpType.None;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitView()
	{
	}

	protected override UIButton InitInteractionButton()
	{
		return null;
	}

	protected override void OnSetViewData(object data)
	{
	}

	protected override void OnInteractionBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void AddAssistReceiveGiftInfo()
	{
	}

	protected override void OnReset()
	{
	}

	private void RefreshFrameView(bool isPrime)
	{
	}

	private void RefreshCallsignView()
	{
	}

	private void OnRequestAccountInfoFinish(object[] data)
	{
	}

	private void GetGiftMail()
	{
	}

	private void OnGetMailNtf(object[] data)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInteractionBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
