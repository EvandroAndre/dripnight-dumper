using GCommon;

namespace COW;

public class UIChatSquadItemController : UIEasyListItemController, ITipsDelegate
{
	private UIChatSquadItemView m_View;

	private ChatChannelInfo m_Data;

	private UIModelCupMatch m_ModelCupMatch;

	private UIModelChampionship m_ModelChampionship;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	void ITipsDelegate.OnTipsDataChange(ETipsType type, int num)
	{
	}

	private void RefreshUnreadTips()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
