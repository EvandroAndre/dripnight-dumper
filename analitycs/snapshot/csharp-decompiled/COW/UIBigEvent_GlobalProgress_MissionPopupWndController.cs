using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_GlobalProgress_MissionPopupWndController : UIBigEvent_Template_MissionPopupWndBaseController
{
	private UIBigEvent_GlobalProgress_MissionPopupWndView m_View;

	protected UIModelActivity m_UIModelModelActivity;

	private List<UIBaseController> m_ListControllers;

	private List<UIBigEvent_GlobalProgress_Mission2Data> m_MissionDescList;

	private uint m_CloseDelayCallID;

	private int m_UseAsyncCnt;

	private bool waitCreateMission;

	private Queue<UIBigEvent_GlobalProgress_Mission2Data> m_CreateMissionDescList;

	protected override UICommonRewardWndController.WndStyleEnum WndStyle => UICommonRewardWndController.WndStyleEnum.COMMON;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	protected void OnClickCloseBtn()
	{
	}

	protected override void OnClickAllClaimedBtn()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnSetNavigationController()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void SetWndImageStyle()
	{
	}

	protected override UIBigEvent_Template_MissionItemBaseController GenerateMissionItemController(Transform parent)
	{
		return null;
	}

	public override EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	protected override void ReloadMissionList()
	{
	}

	private int Mission2CompareTo(UIBigEvent_GlobalProgress_Mission2Data x, UIBigEvent_GlobalProgress_Mission2Data y)
	{
		return 0;
	}

	private void Update()
	{
	}

	private void _003COnClickCloseBtn_003Eb__8_0()
	{
	}

	private void _003CSetWndImageStyle_003Eb__13_0()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnClickAllClaimedBtn()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnSetNavigationController()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public UIBigEvent_Template_MissionItemBaseController _003C_003EiFixBaseProxy_GenerateMissionItemController(Transform P0)
	{
		return null;
	}

	public UICommonRewardWndController.WndStyleEnum _003C_003EiFixBaseProxy_get_WndStyle()
	{
		return UICommonRewardWndController.WndStyleEnum.COMMON;
	}

	public EBigEventTemplateType _003C_003EiFixBaseProxy_GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void _003C_003EiFixBaseProxy_ReloadMissionList()
	{
	}
}
