using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UIMailReportReasonItemController : UIBaseController
{
	private UIMailReportReasonItemView m_View;

	private List<UILabel> m_LabelList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(List<PunishRecord> punishRecords)
	{
	}

	private string FixRichTextToBlack(string str)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
