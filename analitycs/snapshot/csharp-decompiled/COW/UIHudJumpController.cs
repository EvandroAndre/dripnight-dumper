using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudJumpController : UIHudButtonBaseController
{
	private enum State
	{
		Jump,
		Climb,
		SnowSlide,
		MountableAnimal
	}

	private State m_curState;

	private UIHudJumpView m_View;

	public const uint VISIBILITY_STATE_CARRY = 134217728u;

	private const string m_JumpIcon = "UI_icon_jump";

	private const string m_JumpChooseIcon = "UI_icon_jump_choose";

	private const string m_JumpShoeIcon = "UI_icon_doublejump";

	private const string m_HumanTireJumpIcon = "UI_icon_humantire";

	private const string m_ClimbIcon = "UI_icon_climb";

	private const string m_SnowSlideJumpIcon = "UI_icon_hoverboard_jump";

	private const string m_SnowSlideGrabIcon = "FF_ingame_hud_GrabBoard";

	private const string m_SnowSlideGrabChooseIcon = "FF_ingame_hud_GrabBoard_choose";

	private bool m_Isfalling;

	private bool m_IsInSnowSlideRotatePlayer;

	private bool m_IsSnowSlideGrabbing;

	private bool m_IsEquipJumpShoes;

	private bool m_IsDoubleJumpEnergyFull;

	private Vector3 defatultpos;

	private Vector3 climbpos;

	private VisualInstanceHolder m_SnowSlideGrabNoticeVfx;

	private VisualInstanceHolder m_SnowSlideGrabRotateVfx;

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

	private void InitIsNewUI()
	{
	}

	private void OnLobbySocialHudStateChanged(bool visible)
	{
	}

	private void OnSnowSlideStateChanged()
	{
	}

	private void OnLocalSnowSlideCanGrabChanged(object[] data)
	{
	}

	private void OnLocalSnowSlideGrabRotateChanged(object[] data)
	{
	}

	private void UpdateGrabNoticeEffect(bool show)
	{
	}

	private void UpdateGrabRotateEffect(bool show)
	{
	}

	private void OnReadyToClimb(object[] data)
	{
	}

	private void RefreshIconState(State state)
	{
	}

	private void RefreshIconState(State state, bool allowFoldWingOverride)
	{
	}

	private void ResetIconPos()
	{
	}

	private void OnReadyToGlide(int data)
	{
	}

	private void OnEquipJumpShoes(object[] data)
	{
	}

	private void OnUnEquipJumpShoes(object[] data)
	{
	}

	private void OnEnergyChange(object[] data)
	{
	}

	private void OnHumanTireJumpStateChange(object[] data)
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	private void Update()
	{
	}

	private void OnCarryStateChanged()
	{
	}

	private void SetHightlight(bool flag)
	{
	}

	private void ApplyJumpVisual()
	{
	}

	private void CheckSnowSlideRotateState(Player player)
	{
	}

	private void SetBtnSpriteView(string spriteName, bool isHighlight)
	{
	}

	private void OnLocalPlayerAdd(object[] data)
	{
	}

	public void ProcessUGCJumpStatus(Player.AALGCBFJHJM status)
	{
	}

	private void OnHudSwimmingSurfVisibilityChanged(object[] data)
	{
	}

	protected override void OnBtnDown()
	{
	}

	protected override void OnBtnUp()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnVerticalCameraModeChanged(bool isVertical)
	{
	}

	private void OnShowGetOffSlideGuide()
	{
	}

	private void OnCloseGetOffSlideGuide()
	{
	}

	private void OnPlayerGetOnVehicle(object[] data)
	{
	}

	private void OnPlayerGetOffVehicle(object[] ps)
	{
	}

	private string ResolveJumpSpriteName(bool isHighlight)
	{
		return null;
	}

	private bool IsJumpFamilySprite(string spriteName)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnDown()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnUp()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
