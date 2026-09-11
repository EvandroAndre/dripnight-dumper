using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIMilestone_MissionPopupWndController : UIBigEvent_Template_MissionPopupWndBaseController
{
	private UIMilestone_MissionPopupWndView m_View;

	private List<MilestoneMissionData> m_ListMissionDatas;

	private List<UIBaseController> m_ListControllers;

	protected override UICommonRewardWndController.WndStyleEnum WndStyle => UICommonRewardWndController.WndStyleEnum.COMMON;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	private void OnClickBtnMaskClose()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	protected override void OnSetNavigationController()
	{
	}

	private void InitCloseBtnShowState()
	{
	}

	protected override void ReloadMissionList()
	{
	}

	private MilestoneMissionData GetMilestoneMissionData(int index)
	{
		return null;
	}

	protected override void OnClickAllClaimedBtn()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public EBigEventTemplateType _003C_003EiFixBaseProxy_GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public UICommonRewardWndController.WndStyleEnum _003C_003EiFixBaseProxy_get_WndStyle()
	{
		return UICommonRewardWndController.WndStyleEnum.COMMON;
	}

	public new void _003C_003EiFixBaseProxy_OnSetNavigationController()
	{
	}

	public void _003C_003EiFixBaseProxy_ReloadMissionList()
	{
	}

	public void _003C_003EiFixBaseProxy_OnClickAllClaimedBtn()
	{
	}
}
