using GCommon;

namespace COW;

public class UIBigEventTokenTipsBaseItemController : UIEasyListItemController
{
	protected UILabel AccessWayLabel;

	protected UIButton AccessWayBtn;

	private uint m_DetailId;

	private uint m_GoPos;

	private string m_SubGoPos;

	private uint m_TokenId;

	private UIModelBigEvent.TokenGoposTipWayType m_wayType;

	private uint m_dataSource;

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

	public virtual void SetWayLabelByParamType(string wayStr)
	{
	}

	private void OnClickAccessWayBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
