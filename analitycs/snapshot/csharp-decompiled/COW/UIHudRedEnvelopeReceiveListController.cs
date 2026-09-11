using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudRedEnvelopeReceiveListController : UIPopupWindowController
{
	private UIHudRedEnvelopeReceiveListView m_View;

	private List<RedEnvelopeAwardItemView> m_ItemViewList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private int GetSortOrder(RedEnvelopeAwardDisplayInfo award)
	{
		return 0;
	}

	public void SetReceiveData(List<RedEnvelopeAwardDisplayInfo> itemList, string ownerName)
	{
	}

	private void OnEventClose()
	{
	}

	private int _003CSetReceiveData_003Eb__6_0(RedEnvelopeAwardDisplayInfo a, RedEnvelopeAwardDisplayInfo b)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
