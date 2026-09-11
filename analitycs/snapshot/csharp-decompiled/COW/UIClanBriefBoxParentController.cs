using GCommon;
using UnityEngine;

namespace COW;

public class UIClanBriefBoxParentController : UIPopupWindowController
{
	public enum EClanBriefBoxType
	{
		ClanInfo,
		PopupBox
	}

	public enum EClanBriefBoxParentType
	{
		None,
		LeaderBoard,
		PersonalProfile,
		QRCode,
		ClanWarChampionship
	}

	private UIClanBriefBoxParentView m_View;

	private UIClanBriefBoxController m_ClanBriefBoxCtrl;

	private UIClickMask m_ClickMask;

	private Vector3 m_CheckWindowLeftOrRightPos;

	private Vector3 m_WindowPos;

	private Vector3 m_FromPos;

	private Vector3 m_CenterPos;

	private Vector3 m_ContainerPos;

	private ClanInfo m_ClanInfo;

	private ulong m_accountId;

	private bool m_ShowSwitchButton;

	private bool m_ShowTween;

	private bool m_HasCreatedBriefBox;

	private bool m_IsPengdingDestroy;

	private bool m_HasRequestAccountInfo;

	private EClanBriefBoxParentType m_ParentType;

	private const float m_OverBoundAdjustOffset = 20f;

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

	private void InitEvent()
	{
	}

	public void UpdateMenuData(ClanInfo clanInfo, Vector3 checkWindowLeftOrRightPos, ulong accountId = 0uL, bool showSwitchButton = true, bool showTween = true, EClanBriefBoxType type = EClanBriefBoxType.PopupBox, Vector3 windowPos = default(Vector3), Vector3 centerPos = default(Vector3), Vector3 containerPos = default(Vector3), EClanBriefBoxParentType parentType = EClanBriefBoxParentType.None)
	{
	}

	public void InitMask()
	{
	}

	public void ChangeMaskShort()
	{
	}

	public void AddMaskRegion(object[] param)
	{
	}

	public void DelMaskRegion(object[] param)
	{
	}

	private void RefreshContainer()
	{
	}

	private void RefreshContainerByWindowPos()
	{
	}

	private void RefreshViewData(EClanBriefBoxType type, EClanBriefBoxParentType parentType = EClanBriefBoxParentType.None)
	{
	}

	private void CheckIsOverBound()
	{
	}

	private void OnSwitchBtnClick()
	{
	}

	private void OnRequestAccountInfoFinish(object[] data)
	{
	}

	private void UpdateBriefBoxState(object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
