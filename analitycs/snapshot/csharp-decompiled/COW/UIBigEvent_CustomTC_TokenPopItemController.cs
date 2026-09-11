using GCommon;

namespace COW;

public class UIBigEvent_CustomTC_TokenPopItemController : UIEasyListItemController
{
	private UIBigEvent_CustomTC_TokenPopItemView m_View;

	private uint m_GoPos;

	private string m_SubGoPos;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnAccessWayBtnClick()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void SetWayLabelByTokenType(uint useType, uint gameMode, string wayStr)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
