using GCommon;
using proto;

namespace COW;

internal class UIPreVeteranRewardItemController : UIBaseController
{
	private UIPreVeteranRewardItemView m_View;

	private UIVeteranV3AwardItemController m_AwardItemCtrl;

	private EActivity.State m_State;

	private ClientVeteranTaskDesc m_TaskDesc;

	private AwardDesc m_AwardDesc;

	private UIModelPreVeteran m_Model;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(ClientVeteranTaskDesc taskDesc, int taskIndex)
	{
	}

	public void RefreshRewardState()
	{
	}

	private void OnClickItem()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
