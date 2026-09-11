using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudDynamicSkillTemplateController : UIBaseController
{
	private enum ScreenQuadrant
	{
		TopLeft,
		TopRight,
		BottomLeft,
		BottomRight
	}

	private UIHudDynamicSkillTemplateView m_View;

	private UICamera m_UICamera;

	private Camera m_Camera;

	private float dist;

	public string m_SkillType;

	private float m_NextLoopAnimTime;

	private bool m_IsLoopAnim;

	private float m_SkillCoolingTime;

	private float m_SkillCDTime;

	private int m_SkillCDEndTime;

	private bool m_ShowCDAnim;

	private ESkillHudBrightStyle m_BrightStyle;

	private const string ActiveSkillBg = "icon_ingame_KillFeast_BG";

	private bool m_HasInitActiveSkill;

	private bool m_IsActiveSkill;

	private Vector3 m_ActiveSkillDescOffset;

	private int m_DefaultTemplateWidth;

	private int m_DefaultTemplateHeight;

	private int m_DefaultSkillBGWidth;

	private int m_DefaultSkillBGHeight;

	private Vector2 m_DefaultSkillLabelPos;

	private bool m_IsPetSkill;

	private bool m_IsOB;

	private uint m_LevelAnimDelay;

	private bool m_IsEmptySkill;

	private bool m_RefreshPos;

	private float m_LabelOffsetX;

	private float m_LabelOffsetY;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnRecycle()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void OnReInit()
	{
	}

	public void RefreshSkillData(AvatarSkillData data, INIPMKCGOPE HudState, bool isInEffect, ESkillHudBrightStyle brightStyle)
	{
	}

	public void SetBright(bool isShow, ESkillHudBrightStyle brightStyle, float brightTime = 0f, uint brightEndTimeMs = 0u)
	{
	}

	private bool IsBrightStateNotChanged(bool newState)
	{
		return false;
	}

	protected void SetEnhanced(uint skillLevel)
	{
	}

	public void PlayLevelUpAnim()
	{
	}

	public void SetActiveSkillIcon(bool isDynamic)
	{
	}

	private void TryGetCameraComponent()
	{
	}

	public void SetFlash()
	{
	}

	public void PlayCoolDownAnim(float cdTime, int cdEndTime)
	{
	}

	public void ResetCoolDownAnim()
	{
	}

	private void InitFlashAnimState()
	{
	}

	private void UpdateFlashAnimState()
	{
	}

	public void PlayBrightAnim()
	{
	}

	private void PlayFlashAnim()
	{
	}

	public void ResetBrightAnim()
	{
	}

	private void Update()
	{
	}

	private void OnPress(GameObject go, bool value)
	{
	}

	private void UpdateSkillLabelPosition()
	{
	}

	private ScreenQuadrant GetScreenQuadrant(Vector3 screenPos, Vector2 screenCenter)
	{
		return ScreenQuadrant.TopLeft;
	}

	private void OnChangeSilencedState(object[] param)
	{
	}

	private void _003CPlayLevelUpAnim_003Eb__38_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
