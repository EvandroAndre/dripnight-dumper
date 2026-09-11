using GCommon;
using proto;

namespace COW;

public class UIActivityOverviewItemController : UIBaseController
{
	public enum EActivityState
	{
		Coming,
		Normal,
		Expired
	}

	private UIActivityOverviewItemView m_View;

	private UIModelActivity m_ModelActivity;

	private AdvertDesc m_Data;

	private ClientActivityDesc m_OverViewDesc;

	private const string COMING_STRING = "TXT_OB8_GXQ_EVENT_NOTSTARTED";

	private const string ACTIVE_STRING = "TXT_LOBBY_EVENT_GOTO";

	private const string EXPIRED_STRING = "TXT_OB9_GXQ_GIFTMALL_TIMEOUT";

	private EActivityState m_ActivityState;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(AdvertDesc data)
	{
	}

	private void UpdateView()
	{
	}

	private void OnGoToClick()
	{
	}

	private void SendBannerClickLog(uint id)
	{
	}

	public void Reload()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
