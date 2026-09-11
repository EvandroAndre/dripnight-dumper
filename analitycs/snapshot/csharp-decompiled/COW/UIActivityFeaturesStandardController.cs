using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIActivityFeaturesStandardController : UIActivityBaseController
{
	private UIActivityStandardView m_View;

	private List<ActivityFeaturesDesc> m_Features;

	private ActivityFeaturesDesc m_SelectedFeature;

	private IUIActivityContent m_Content;

	private UIModelActivity m_ModelActivity;

	private List<StandardTabItemViewData> m_TabDataList;

	private UIStandardTabController m_TabCtrl;

	private uint m_CurrentSelectedGroupId;

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

	protected override void OnUIOpen()
	{
	}

	public void ActivityFeatureSelected(int descIndex)
	{
	}

	public override void SetData(object data)
	{
	}

	public override uint GetCurrentSelectedGroupId()
	{
		return 0u;
	}

	public override void SelectItem(uint id, bool needScroll = true)
	{
	}

	public void UpdateTabData(int tabIndex)
	{
	}

	public override void OnPanelDepthChanged()
	{
	}

	public override void Reload()
	{
	}

	public override void OnVisibilityChange(bool isVisible)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public override void OnPopUpWindowListChange(bool isCovered)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	public uint _003C_003EiFixBaseProxy_GetCurrentSelectedGroupId()
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_SelectItem(uint P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnPanelDepthChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_Reload()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChange(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopUpWindowListChange(bool P0)
	{
	}
}
