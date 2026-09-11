using GCommon;
using proto;

namespace COW;

public class UIProfileReportItemController : UIEasyListItemController
{
	private UIProfileReportItemView m_View;

	private UIModelCredit m_CreditModel;

	private CreditReportInfo DataInfo;

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

	private void OnReportNameBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
