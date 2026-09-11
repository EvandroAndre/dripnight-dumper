using GCommon;
using proto;

namespace COW;

public class UIChampionshipTeamApplyItemController : UIEasyListItemController
{
	public enum ViewType
	{
		Apply,
		Invite
	}

	private UIChampionshipTeamApplyItemView m_View;

	private UIBaseProfileInfoController m_BaseProfileUI;

	private AccountInfoBasic m_ApplicantData;

	private UIModelChampionship m_ModelChampionship;

	public ViewType m_ViewType;

	private uint m_ChampionshipType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void SetChampionshipType(uint championshipType)
	{
	}

	private void View()
	{
	}

	private void Reject()
	{
	}

	private void Accept()
	{
	}

	private void _003CAccept_003Eb__13_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
