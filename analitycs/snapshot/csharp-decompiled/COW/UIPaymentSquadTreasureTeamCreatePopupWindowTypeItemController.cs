using GCommon;

namespace COW;

public class UIPaymentSquadTreasureTeamCreatePopupWindowTypeItemController : UIBaseController
{
	private UIPaymentSquadTreasureTeamCreatePopupWindowTypeItemView m_View;

	private ESquadTreasureTeamState m_TeamState;

	private const string m_SelectedColorStr = "#FFBA00";

	private const string m_UnSelectedColorStr = "#959595";

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

	public void SetData(ESquadTreasureTeamState type)
	{
	}

	public ESquadTreasureTeamState GetTeamState()
	{
		return ESquadTreasureTeamState.PublicTeam;
	}

	private string GetLabelText(ESquadTreasureTeamState state)
	{
		return null;
	}

	private string GetDetailText(ESquadTreasureTeamState state)
	{
		return null;
	}

	public void SetSelected(bool isSelected)
	{
	}

	private void RefreshDetailLabelColor(bool isSelected)
	{
	}

	private void OnBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
