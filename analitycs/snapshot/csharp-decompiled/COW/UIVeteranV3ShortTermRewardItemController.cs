using GCommon;
using proto;

namespace COW;

public class UIVeteranV3ShortTermRewardItemController : UIBaseController
{
	private UIVeteranV3ShortTermRewardItemView m_View;

	private UIModelVeteran m_ModelVeteran;

	private AwardDesc m_AwardDesc;

	private ClientVeteranTaskDesc m_taskDesc;

	private UIVeteranV3AwardItemController m_AwardItemCtrl;

	private int m_Index;

	private EActivity.State m_State;

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

	private void OnClickItem()
	{
	}

	public void OnSelect()
	{
	}

	public void OnCancelSelect()
	{
	}

	private void SetupDefaultStateOnInit()
	{
	}

	private void LoadStaticContent()
	{
	}

	private void RefreshDynamicContent()
	{
	}

	private void RefreshView()
	{
	}

	public void SetViewData(ClientVeteranTaskDesc taskDesc, int index)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
