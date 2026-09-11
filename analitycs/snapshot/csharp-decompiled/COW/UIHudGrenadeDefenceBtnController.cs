using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudGrenadeDefenceBtnController : UIHudGrenadeBtnController
{
	private bool m_EnableSmartIceWall;

	private bool m_OnSlide;

	private bool m_IsButtonDrag;

	private float m_PressTime;

	private Camera m_Camera;

	private Vector3 m_SmartIceWallIconOriginalPos;

	private Vector3 m_SmartIceWallStartPos;

	private Vector3 m_SmartIceWallPressPos;

	private float m_BGRangeRadius;

	private float m_Multiscale;

	private string m_StrButtonAction;

	private bool m_GlobalTouchEnd;

	private float m_iceWallFillNeedTime;

	private bool m_IsPressed;

	private string m_EventLogMessage;

	private bool m_AlwaysShow;

	private uint m_DiwaliIcewallEffectHolder;

	private uint m_HideBeaconReadyDelayCallID;

	private Dictionary<ResourceID, uint> m_IceWallBtnEffectMap;

	private bool IsButtonDrag
	{
		set
		{
		}
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public new static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void InitRouletteAwake()
	{
	}

	private void OnIceWallMakerActivate(object[] data)
	{
	}

	protected override void RefreshGrenadeItemList()
	{
	}

	protected override void ShowRouletteGuide()
	{
	}

	protected override void OnSideWeaponChange(object[] param)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnCancelUseBuindingGun(object[] param)
	{
	}

	private void OnInGameSettingOpen(object[] param)
	{
	}

	private void OnSmartIceWallSettingShowChange(object[] para)
	{
	}

	private void OnLocalPlayerSlideStatusChange(object[] para)
	{
	}

	private void OnSmartIceWallSettingChange(object[] para)
	{
	}

	private void UpdateSmartIceWallEnable()
	{
	}

	private void UpdateSmartIceWallShow()
	{
	}

	protected override void OnUpdateCustomGrenadeSlot()
	{
	}

	private void SwitchStyle(bool enableSmartIceWall)
	{
	}

	protected override ButtonType FindNextType(ButtonType typeidx)
	{
		return ButtonType.None;
	}

	protected override bool NeedHideView(ButtonType tmp, ButtonType hand_type = ButtonType.None)
	{
		return false;
	}

	protected override void RefreshAddVfx(ButtonType btype)
	{
	}

	protected void OnGotGlooAirdropAward(uint num)
	{
	}

	private void OnIceWallMakerProcessChange(object[] data)
	{
	}

	protected override void OnBuildingCountChange(object[] param)
	{
	}

	private void OnShowIceWallTutorialInForceTutorialGame(object[] data)
	{
	}

	protected override void RefershPlayerGrenadeBtn(Player player)
	{
	}

	protected override bool IsDoubleSlotShow()
	{
		return false;
	}

	public void ProcessChange(int process)
	{
	}

	protected override void OnBtnUp()
	{
	}

	protected override void OnBtnDown()
	{
	}

	protected override void OnBtnClick()
	{
	}

	protected override void UpdateAxisTouchingThroughArea()
	{
	}

	protected override void Update()
	{
	}

	private bool CheckPressDrag()
	{
		return false;
	}

	private bool CheckMoveDrag()
	{
		return false;
	}

	private bool IsDragEnd(bool isDragMove)
	{
		return false;
	}

	private bool WeaponOnHandIsIceWall()
	{
		return false;
	}

	protected override string GetMappingName()
	{
		return null;
	}

	private void OnPinBtnGrenadeMark()
	{
	}

	protected override void tryClickPinMark()
	{
	}

	protected override void OnShowGrenadeTutorialInForceTutorialGame()
	{
	}

	protected override void OnStartInfiniteIceWall(GEvent data)
	{
	}

	protected override void OnAddInfiniteGlooWall()
	{
	}

	protected override bool IsInfiniteIceWall()
	{
		return false;
	}

	private void TryStartInfiniteIceWall()
	{
	}

	protected void OnShowIceWallBtnEffect(GEvent gEvent)
	{
	}

	protected void OnShowIceWallBtnEffectOneShot(GEvent gEvent)
	{
	}

	protected void RecyleAllIceWallBtnEffectMap()
	{
	}

	private void _003CRefreshAddVfx_003Eb__41_0()
	{
	}

	private void _003COnGotGlooAirdropAward_003Eb__42_0()
	{
	}

	public new bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_InitRouletteAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshGrenadeItemList()
	{
	}

	public void _003C_003EiFixBaseProxy_ShowRouletteGuide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSideWeaponChange(object[] P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdateCustomGrenadeSlot()
	{
	}

	public ButtonType _003C_003EiFixBaseProxy_FindNextType(ButtonType P0)
	{
		return ButtonType.None;
	}

	public bool _003C_003EiFixBaseProxy_NeedHideView(ButtonType P0, ButtonType P1)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_RefreshAddVfx(ButtonType P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnBuildingCountChange(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RefershPlayerGrenadeBtn(Player P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsDoubleSlotShow()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnBtnUp()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnDown()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateAxisTouchingThroughArea()
	{
	}

	public void _003C_003EiFixBaseProxy_Update()
	{
	}

	public string _003C_003EiFixBaseProxy_GetMappingName()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_tryClickPinMark()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShowGrenadeTutorialInForceTutorialGame()
	{
	}

	public void _003C_003EiFixBaseProxy_OnStartInfiniteIceWall(GEvent P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnAddInfiniteGlooWall()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsInfiniteIceWall()
	{
		return false;
	}
}
