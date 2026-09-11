using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIOBPlayerNamePlateBaseController : UIBaseController
{
	protected Dictionary<int, OBPlayerState_Base> m_OBStateCache;

	protected UIOBPlayerNamePlateView m_View;

	protected UIOBPlayerNamePlateCSView m_CSView;

	protected OBPlayerState_Base m_CurState;

	protected PlayerData m_PlayerData;

	protected bool m_EnableGoto;

	protected UIMapUtil.MapOffsetContext m_MapOffsetContext;

	protected uint m_FiringRayDelayCall;

	protected const int MAXDEPTH = 500;

	private uint m_HurtDelayCallID;

	protected UIWidget Widget;

	protected Transform ArrowContainer;

	protected UISprite playerArrowPeek;

	protected UISprite SelectedDirection;

	protected UISprite PlayerArrow;

	protected UISprite FireIcon;

	protected UISprite OutLight;

	protected GameObject IndexLabelRot;

	protected UISprite KnockDownIcon;

	protected UISprite DeadIcon;

	protected UISprite HurtWave;

	protected UILabel IndexLabel;

	protected UISprite HurtIcon;

	protected UIWidget KokGo;

	protected UIWidget TeamIconGo;

	protected UIEffectSprite TeamIcon;

	protected UISprite TeamFakeIcon;

	protected GameObject NamePlateRot;

	protected UISprite NamePlateBG;

	protected UILabel NameLabel;

	protected UISprite FiringRay;

	protected UIButton GotoBtn;

	protected UISprite PlayerSkillIcon;

	protected UISprite Hunt;

	protected string m_default_skill_icon_name;

	protected Color m_CSLeftTeamColor;

	protected Color m_CSRightTeamColor;

	protected const string DEFAULT_HUNT_ICON_NAME = "FF_UI_PC_Icon_Hunt";

	protected const string DEFAULT_DEFEND_ICON_NAME = "FF_UI_PC_Icon_Guard";

	protected uint m_MissionID;

	public void SetMapOffsetContext(UIMapUtil.MapOffsetContext ctx)
	{
	}

	public EOBPlayerStateType CurrentStateType()
	{
		return EOBPlayerStateType.eNone;
	}

	protected override void OnUIInit()
	{
	}

	protected virtual void OnLoadView()
	{
	}

	public void InitDepth(int name_plate_depth)
	{
	}

	protected virtual void SetDepth(int name_plate_depth)
	{
	}

	public void BindPlayerData(PlayerData data, bool EnableGoto)
	{
	}

	public virtual void UpdatePlayerInfo(bool needName = true)
	{
	}

	public void PlayHurtEffect()
	{
	}

	public void FireEffectVisibleChange(bool isVisible)
	{
	}

	public void DrawFiringRay(float scale)
	{
	}

	public void SwithPlayerState(EOBPlayerStateType next_state_type)
	{
	}

	public virtual void UpdatePlayerRotation()
	{
	}

	public void UpdateNamePlateRotaion(float angle)
	{
	}

	public void UpdatePlayerPosition()
	{
	}

	public void ToggleNameplateName(bool visible)
	{
	}

	protected void OnGotoBtnClcik()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected void OnToggleShowTeamIcon(object[] data)
	{
	}

	protected void OnShowKok(object[] data)
	{
	}

	protected void ShowTeamIcon(bool show)
	{
	}

	private void _003CPlayHurtEffect_003Eb__48_0()
	{
	}

	private void _003CDrawFiringRay_003Eb__50_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
