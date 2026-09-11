using System.Text;
using GCommon;

namespace COW;

public class UICustomRoomRecruitController : UIPopupWindowController
{
	private UICustomRoomRecruitView m_View;

	private UIModelRecruit m_ModelRecruit;

	private UIModelChat m_ModelChat;

	private UIModelGroup m_ModelGroup;

	private UIModelMapOpeningInfo m_ModelMap;

	private UIModelCustomRoom m_ModelCustomRoom;

	private uint m_WorldDelayCallID;

	private bool m_HasWorldToggleInit;

	private bool m_LastInCDState;

	private StringBuilder m_Builder;

	private const float GREY_ALPHA = 0.4f;

	private bool m_FirstRecruit;

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

	private void InitRoomRecruitView()
	{
	}

	private void InitSendToView()
	{
	}

	private void OnRecruitBtnClick()
	{
	}

	private void OnStopRecruitBtnClick()
	{
	}

	private void OnChannelWorldToggleChange()
	{
	}

	private void OnChannelWorldToggleChangeWithTips(bool needTips = true)
	{
	}

	private void OnChannelClanToggleChange()
	{
	}

	private void UpdateSendChannelView()
	{
	}

	private void DefaultWorldState()
	{
	}

	private void OnGetRecruitInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
