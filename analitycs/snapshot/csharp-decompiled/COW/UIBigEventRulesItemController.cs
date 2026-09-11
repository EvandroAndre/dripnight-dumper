using GCommon;
using proto;

namespace COW;

public class UIBigEventRulesItemController : UIBaseController
{
	protected UIBigEventRulesItemView m_View;

	protected const string DEFAULT_LAN = "default";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public virtual ELimitedEvent.EventID GetEventID()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public virtual UIModelBigEvent.EBigEventEntranceID GetEntranceID()
	{
		return UIModelBigEvent.EBigEventEntranceID.Main;
	}

	protected override void OnUIInit()
	{
	}

	private void OnGotoTutorialBtn()
	{
	}

	public string GetGetBigEventParamStrByLangeFormat(string paramStr)
	{
		return null;
	}

	public void FreshUIData(object data)
	{
	}

	protected bool CheckEntranceState(UIModelBigEvent.EBigEventEntranceID entranceID)
	{
		return false;
	}

	private void _003CFreshUIData_003Eb__8_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
