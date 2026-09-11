using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileOccupationItemController : UIBaseController
{
	private UIProfileOccupationItemView m_View;

	private OccupationItemViewData m_ViewData;

	private UIModelProfile m_Model;

	private UICommonGuideController m_GuideCtrl;

	private GameObject m_Upgrade;

	private GameObject m_EliteVFX;

	private uint m_DelayCall;

	public uint OccupationId => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(OccupationItemViewData viewData, bool isSelf)
	{
	}

	protected override void OnUIClose()
	{
	}

	private void OnItemCliked()
	{
	}

	public void UpdateClickedStates(uint id)
	{
	}

	public void UpdateDisplayStatesByID(uint id)
	{
	}

	private void _003CSetViewData_003Eb__11_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
