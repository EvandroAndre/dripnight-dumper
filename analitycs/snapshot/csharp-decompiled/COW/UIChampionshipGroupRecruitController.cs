using System.Text;
using GCommon;

namespace COW;

public class UIChampionshipGroupRecruitController : UIPopupWindowController
{
	private UIChampionshipChatRecruitView m_View;

	private UIModelChat m_ChatModel;

	private UIModelChampionship m_ModelChampionship;

	private StringBuilder m_Builder;

	private bool m_LastInCDState;

	private uint m_WorldDelayCallID;

	private readonly float GREY_ALPHA;

	private uint m_ChampionshipType;

	private uint m_ChampionshipID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetChampionshipInfo(uint type, uint id)
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
