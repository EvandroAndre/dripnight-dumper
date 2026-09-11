using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudPocketReviveSelectCandidateItemController : UIBaseController
{
	private bool m_Selected;

	private UIHudPocketReviveSelectCandidateItemView m_View;

	private UIHudPocketReviveSelectCandidateItemViewData m_ViewData;

	public bool Selected => false;

	public BHGGAEEHJCO SelectedPlayer => default(BHGGAEEHJCO);

	private bool IsSingleSelection => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void AddEventDelegates()
	{
	}

	private void OnSelectBtnClick()
	{
	}

	public void SetViewData(UIHudPocketReviveSelectCandidateItemViewData viewData)
	{
	}

	public void UpdateSelectedState(bool selected)
	{
	}

	private void SetupDefaultState()
	{
	}

	private void SetSelectionMode()
	{
	}

	private void SetReviveCandidateName()
	{
	}

	private void SetColoredTeamIndex()
	{
	}

	private void UpdateSelectedStateInternal(bool selected)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
