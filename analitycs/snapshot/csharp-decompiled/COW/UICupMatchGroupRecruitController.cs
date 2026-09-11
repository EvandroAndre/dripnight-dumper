using System.Text;
using GCommon;

namespace COW;

public class UICupMatchGroupRecruitController : UIPopupWindowController
{
	private UIChampionshipChatRecruitView m_View;

	private UIModelChat m_ChatModel;

	private UIModelCupMatch m_ModelCupMatch;

	private StringBuilder m_Builder;

	private bool m_LastInCDState;

	private uint m_WorldDelayCallID;

	private readonly float GREY_ALPHA;

	private uint m_CupMatchType;

	private uint m_CupMatchID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void SetCupMatchInfo(uint type, uint id)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void DefaultWorldState()
	{
	}

	private void UpdateView()
	{
	}

	private void OnSendClick()
	{
	}

	private void OnChannelToggleChange()
	{
	}

	private bool CheckSendToValid()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
