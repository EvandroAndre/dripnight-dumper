using GCommon;

namespace COW;

public class UIHippoRepairWndController : UIPopupWindowController
{
	private UIHippoRepairWndView m_View;

	private IHippoCrisisEquipmentBackpackData m_Data;

	private UIModelHippoCrisis ModelHippoCrisis;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(IHippoCrisisEquipmentBackpackData data)
	{
	}

	private void OnRepairBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
