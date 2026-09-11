using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMilestone_MissionPopupSpecSubItemController : UIBigEvent_Template_MissionItemBaseController
{
	private UIMilestone_MissionPopupSpecSubItemView m_View;

	private GameObject m_EffectGo;

	private int index;

	protected override UICommonRewardWndController.WndStyleEnum WndStyle => UICommonRewardWndController.WndStyleEnum.COMMON;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	private void InitCND()
	{
	}

	protected override EActivity.State GetActivityState(ActivityClientInfo info)
	{
		return EActivity.State.State_RECEIVED;
	}

	protected override void ShowOrHideFinishEffect(bool result)
	{
	}

	protected override bool RefreshView()
	{
		return false;
	}

	protected override Color GetMissionDescColor()
	{
		return default(Color);
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	protected override string GetMissionItemBGUrl()
	{
		return null;
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public EBigEventTemplateType _003C_003EiFixBaseProxy_GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public EActivity.State _003C_003EiFixBaseProxy_GetActivityState(ActivityClientInfo P0)
	{
		return EActivity.State.State_RECEIVED;
	}

	public void _003C_003EiFixBaseProxy_ShowOrHideFinishEffect(bool P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_RefreshView()
	{
		return false;
	}

	public Color _003C_003EiFixBaseProxy_GetMissionDescColor()
	{
		return default(Color);
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public string _003C_003EiFixBaseProxy_GetMissionItemBGUrl()
	{
		return null;
	}

	public UICommonRewardWndController.WndStyleEnum _003C_003EiFixBaseProxy_get_WndStyle()
	{
		return UICommonRewardWndController.WndStyleEnum.COMMON;
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
