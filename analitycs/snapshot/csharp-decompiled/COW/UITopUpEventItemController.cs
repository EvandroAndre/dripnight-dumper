using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UITopUpEventItemController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public AwardDesc awardDesc;

		public UIStandardItemMiniController standardItem;

		internal void _003CSetViewData_003Eb__0()
		{
		}
	}

	private ClientActivityDesc m_Desc;

	private UITopUpEventItemView m_View;

	private UIModelActivity m_Model;

	private List<UIStandardItemMiniController> m_ItemList;

	private UITopUpEventController.TopUpEventPageType m_TopUpEventPageType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(ClientActivityDesc desc)
	{
	}

	protected void OnTopUpClick()
	{
	}

	public void ResetSelected()
	{
	}

	protected void OnCliamClick()
	{
	}

	public void SetPageType(UITopUpEventController.TopUpEventPageType type)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
