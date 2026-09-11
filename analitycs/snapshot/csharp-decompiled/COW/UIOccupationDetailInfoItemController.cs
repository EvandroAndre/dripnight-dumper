using GCommon;
using UnityEngine;

namespace COW;

public class UIOccupationDetailInfoItemController : UIBaseController
{
	private UIOccupationDetailInfoItemView m_View;

	private OccupationItemViewData m_OccupationItemViewData;

	private UIModelProfile m_ModelProfile;

	private uint m_CSSelectedId;

	private uint m_BRSelectedId;

	private uint m_CSPeakSelectedId;

	private UICommonGuideController m_GuideCtrl;

	private GameObject m_EliteVFX;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetViewData(OccupationItemViewData viewData)
	{
	}

	private void InitEliteOccupationView()
	{
	}

	private void OnEliteTipClick()
	{
	}

	private void OnElitePreviewMaskClick()
	{
	}

	public void OnMaskClick()
	{
	}

	private void OnShowBtnClick()
	{
	}

	private uint GetSelectedId(uint matchMode)
	{
		return 0u;
	}

	private void RefreshOccupationSelectBG()
	{
	}

	private void ShowOccupationSelectTips(uint id, bool isLoad)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnMoreInfoBtnClick()
	{
	}

	private void OnRecommendBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
