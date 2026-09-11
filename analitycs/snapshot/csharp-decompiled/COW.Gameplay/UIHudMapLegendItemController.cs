using COW.GamePlay;
using GCommon;

namespace COW.Gameplay;

public class UIHudMapLegendItemController : UIBaseController
{
	private UIHudMapLegendItemView m_View;

	public DECHMOJJHKG Data;

	public bool IsToggled;

	private string m_DataKey;

	private VisualInstanceHolder m_ExtraHolder;

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

	public void SetData(string dataId, bool enableLine)
	{
	}

	public void SetToggleState(bool value)
	{
	}

	private void UpdateRelatedModulesStateOnToggleClick(bool check)
	{
	}

	private void DispatchEventsOnToggleValueChanged(bool selected)
	{
	}

	private void OnToggleClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
