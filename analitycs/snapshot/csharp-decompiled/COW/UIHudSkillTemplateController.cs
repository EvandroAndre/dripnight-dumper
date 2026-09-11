using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSkillTemplateController : UIBaseController
{
	private UIHudSkillTemplateView m_View;

	private UICamera m_UICamera;

	private Camera m_Camera;

	public int m_PetSkillid;

	public string m_SkillType;

	private float m_FlashEndTime;

	private bool m_IsFlashing;

	private float m_FlashDuration;

	private float m_SkillCDTime;

	private int m_SkillCDEndTime;

	private bool m_ShowCDAnim;

	private ESkillHudBrightStyle m_BrightStyle;

	private float m_BrightTime;

	private uint m_BrightEndTimeMs;

	private bool m_IsPetSkill;

	private bool m_IsOB;

	private uint m_LevelAnimDelay;

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

	private void ResetState()
	{
	}

	private void InitView(AvatarSkillData data, bool isInEffect)
	{
	}

	private void InitView(PetSkillLevelData data, ADEAKCEEEGN hudState)
	{
	}

	public void RefreshSkillData(PetSkillLevelData data, ADEAKCEEEGN HudState)
	{
	}

	public void SetIcon(ResourceID iconResID)
	{
	}

	public void RefreshSkillData(AvatarSkillData data, INIPMKCGOPE HudState, bool isInEffect, ESkillHudBrightStyle brightStyle)
	{
	}

	public void SetBright(bool isShow, ESkillHudBrightStyle brightStyle = ESkillHudBrightStyle.Default, float brightTime = 0f, uint brightEndTimeMs = 0u)
	{
	}

	private bool IsBrightStateNotChanged(bool newState)
	{
		return false;
	}

	public void PlayLevelUpAnim()
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

	private void UpdateCD()
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

	private void OnClick()
	{
	}

	private void OnChangeSilencedState(object[] param)
	{
	}

	private void _003CPlayLevelUpAnim_003Eb__29_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
