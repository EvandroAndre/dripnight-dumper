using GCommon;

namespace COW;

public class UIBuildItemController : UIBaseController
{
	private UIBuildItemView m_View;

	private PlayerPlanItem m_PlanData;

	private UIModelLoadout m_ModelLoadout;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected void OnDisable()
	{
	}

	private void OnClickItem()
	{
	}

	private void OnChangePlanNameBtnClick()
	{
	}

	public void SetItemState(bool state)
	{
	}

	public void SetItemData(PlayerPlanItem data)
	{
	}

	public int GetIndex()
	{
		return 0;
	}

	public void SetItemName(string name)
	{
	}

	public void PlayLeftEffect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
