using GCommon;

namespace COW;

public class UIClanListItemController : UIEasyListItemController
{
	private UIClanListItemView m_View;

	private UIModelClan m_ModelClan;

	private ClanInfo m_ClanInfo;

	private EClanSearchLabelType m_SearchLabelType;

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

	public override void OnItemBtnClick()
	{
	}

	public void UpdateRank(int rank)
	{
	}

	public void UpdateCSRank(int rank)
	{
	}

	private void UpdateLocalClan()
	{
	}

	private void UpdateClanIcon()
	{
	}

	private void UpdateMembersContainer()
	{
	}

	private void UpdateApprovalContainer()
	{
	}

	private void OnClanItemStateChanged(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}
}
