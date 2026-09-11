using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudActiveSkillController : UIHudButtonBaseController, INotifyHudConfigChanged
{
	public enum EInvalidUseReason
	{
		InCD = 1,
		RetriggerTimesLimit
	}

	private enum EBtnDownFailReason
	{
		None,
		InUse,
		InCD,
		Ban,
		CannotCharge
	}

	public const uint VISIBILITY_STATE_EighthLand = 1073741824u;

	public const uint VISIBILITY_STATE_IIVFloatingLand = 536870912u;

	public const uint VISIBILITY_STATE_GB_GPGulag = 268435456u;

	private const string EXTRA_BG_SPRITE_POWER_UP = "FF_UI_ingame_Ninth_GP_SkillMighty_Upgrade_SkillBtn_glow_bg";

	private const string POWER_UP_GLOW_BG_NAME = "PowerUpGlowBg";

	private UIHudActiveSkillView m_View;

	private int m_Index;

	private HBLKLJHFJDK m_ActiveSkill;

	private NetworkPet m_LocalPet;

	private float m_BanSkillStartTime;

	private float m_BanSkillEndTime;

	private float m_BanSkillDuration;

	private bool m_IsBanTipsShowed;

	private string m_StrButtonAction;

	private float multiscale;

	private float m_BGRangeRadius;

	private Vector3 m_DefaultPos;

	private bool m_IsDragBtn;

	private bool m_IsChargeBtn;

	private float m_ChargeTime;

	private bool m_IsThrowSkillLineOn;

	private bool m_IsEffectTipsShowed;

	private bool m_IsCDTipsShowed;

	private BitArray m_InvalidUseState;

	private AudioResource m_DragSkillSound;

	private uint m_DragSkillSoundDelayCall;

	private uint m_ReduceCDEffectId;

	private bool m_isTechDeviceSkillHud;

	private int m_TouchKey;

	private EntityVisualEffectManager m_VfxMgr;

	private Dictionary<uint, uint> m_OneShotVfxIds;

	private UIHudSkillMightyEnergyController m_SkillMightyEnergyCtrl;

	private UISprite m_PowerUpGlowBgSprite;

	private List<GameObject> m_PetSkillAnimationGameObject;

	private VisualInstanceHolder m_UIFXCanUseHolder;

	private VisualInstanceHolder m_UIFXCopiedSkillHolder;

	private GameObject m_playerSkillBloodPoolHighLightVfx;

	private ResourceID m_playerSkillBloodPoolHighLightVfxResId;

	private static readonly Color IconDefaultColor;

	private static readonly Color IconInvalidColor;

	private uint m_LastCanRetriggerCnt;

	private int m_lastCanUsePhaseCount;

	private uint m_SkillCdReducedVfxHolder;

	private ResourceID m_CurrentSkillCdVfxResId;

	private bool m_IsDraging;

	private float m_BtnDownTime;

	private readonly ResourceID m_ElectricGirlBigHealAlertVfxRes;

	private VisualInstanceHolder m_ElectricGirlBigHealAlertVfx;

	private readonly ResourceID m_ElectricGirlBindTargetVfxRes;

	private VisualInstanceHolder m_ElectricGirlBindTargetVfx;

	private readonly ResourceID m_ElectricGirlCanBindVfxRes;

	private VisualInstanceHolder m_ElectricGirlCanBindVfx;

	private bool m_HasShowHomerGuide;

	private bool m_IsHomerActiveSkill;

	private bool m_HasShowHomerNotFindGuide;

	private uint m_DelayCallId;

	private UITutorialWithCharacterForGlobalMissionController m_TutController;

	private uint m_WaitingToPerksVfxHolder;

	private EntityVisualEffectManager VfxMgr => null;

	public void SetAsTechDeviceSkillHud()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	private void InitIsNewUI()
	{
	}

	private void ChangeSkillBG()
	{
	}

	private void RefreshPowerUpGlowBg()
	{
	}

	private uint GetCurrentActiveSkillId()
	{
		return 0u;
	}

	private bool ShouldShowPowerUpGlowBg(uint skillId)
	{
		return false;
	}

	private UISprite GetPowerUpGlowBgSprite(bool createIfMissing)
	{
		return null;
	}

	private void HidePowerUpGlowBg()
	{
	}

	public override void OnUIReInit()
	{
	}

	private void OnSkillHoldingChange(uint skillID)
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	private string OnBotAgentGetRunTimeData()
	{
		return null;
	}

	protected override void RefreshVisibility(bool move = false)
	{
	}

	private void OnSkillConditionChanged(uint skillID)
	{
	}

	public bool IsCopiedSkill()
	{
		return false;
	}

	private void RefreshUseState()
	{
	}

	private void TryShowUIFXCopiedSkill()
	{
	}

	private void OnEPChanged(GEvent data)
	{
	}

	private void OnSkillSkinChange()
	{
	}

	private void UpdateBloodPoolEffect()
	{
	}

	protected override void OnUIActiveGroupSwitch(UInt128 activeGroup)
	{
	}

	private void RefreshVisibilityWithSkillType(UInt128 activeGroup)
	{
	}

	public void OnAddLocalPlayer(object[] param)
	{
	}

	public void SetActiveSkill(object[] param)
	{
	}

	private void HideActiveSkill(object[] param)
	{
	}

	public void SetIndex(int index)
	{
	}

	public int GetIndex()
	{
		return 0;
	}

	public void OnActiveSkillAdded(uint index)
	{
	}

	public void PlaySkillPowerUpSelectedEffectIfTakingEffect()
	{
	}

	private void SetCanRetriggerCnt()
	{
	}

	public bool IsSkillTakingEffect()
	{
		return false;
	}

	public void ShowActiveSkill()
	{
	}

	private void OnSpectatorShowTargetHud(object[] param)
	{
	}

	private void OnShowForceTutorialGuide(object[] data)
	{
	}

	private void OnObTargetChanged(object[] param)
	{
	}

	private void OnObTargetSkillChanged(object[] param)
	{
	}

	private void SetEnhanced(uint skillLevel)
	{
	}

	private void OnAddLocalPet(object[] param)
	{
	}

	private void OnChangActiveSkillState(object[] param)
	{
	}

	private void ResetBanState()
	{
	}

	public float BanSkillProgress()
	{
		return 0f;
	}

	private void OnUpdateSkillIcon(object[] param)
	{
	}

	public void UpdateIcon()
	{
	}

	private void RefreshTutorialLabel()
	{
	}

	private void PlayReadyAgainEffect()
	{
	}

	private void SetInvalidUseState(uint flag, bool isInvalid)
	{
	}

	protected void Update()
	{
	}

	private void OnActionCancelPressed()
	{
	}

	private void OnChangeCancelHudTarget(int newTarget)
	{
	}

	private void OnMiniPhaseChanged(object[] data)
	{
	}

	private void ShowPetSkillAnim(bool show)
	{
	}

	private void OnMiniGameStart(object[] data)
	{
	}

	private void OnMiniGameClose(object[] data)
	{
	}

	private void OnSecondSkillTutorialShow()
	{
	}

	private void TryResetDragBtn()
	{
	}

	private void ResetDragBtn()
	{
	}

	public void OnPinMark()
	{
	}

	protected override void OnBtnDown()
	{
	}

	private EBtnDownFailReason CanBtnDown()
	{
		return EBtnDownFailReason.None;
	}

	protected override void OnBtnUp()
	{
	}

	private void OnElectricGirlAimeTarget()
	{
	}

	private void TryShowElectricGirlCancelBtn()
	{
	}

	private void OnElectricGirlBigHealAlert(uint skillId, uint _alertBigHeal)
	{
	}

	private void ShowElectricGirlBigHealAlert(bool show)
	{
	}

	private void ShowElectricGirlBindVfx(bool show)
	{
	}

	private void OnElectricSkillStatusChange(uint skillId, uint _newState)
	{
	}

	private void OnSkillCancelBtnClick()
	{
	}

	private void ClearDragSound()
	{
	}

	private void ResetGuideFlag()
	{
	}

	private void OnEquipGunShowHomerGuide(object[] param)
	{
	}

	private void DelayShowHomerSkillHint()
	{
	}

	private void OnHomerNotFindEnemy()
	{
	}

	private void CloseNotFindEnemyGuide()
	{
	}

	private void RepeatShowHomerGuide()
	{
	}

	private void SetBuildGuideClickHint(uint guideType)
	{
	}

	private void UpdateAxisTouchingThroughArea()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void TryEnableTouchThroughArea()
	{
	}

	private string GetActiveSkillBanKey()
	{
		return null;
	}

	private void UpdateShowNextCanPressTimeTxt()
	{
	}

	public UIButton GetBtn()
	{
		return null;
	}

	private void ShowRefreshCdView()
	{
	}

	private void RefreshEffectingPauseView()
	{
	}

	private void OnSkillPerksStatusChangeEvent(uint skillId)
	{
	}

	private void RefreshSkillPerksBtn()
	{
	}

	private void ShowSkillPerksVfx(GAEMEPAJJHF skillPerksStatus)
	{
	}

	private void OnSkillPerksBtnClick()
	{
	}

	private void EventPlayVfxWithDuration(uint skillId, uint _resIdUint)
	{
	}

	private void PlayOneShotVfx(ResourceID resId, Transform trans, float duration = 3f)
	{
	}

	private void DetachAllOneShotVfx()
	{
	}

	private void ShowReduceCDEffect()
	{
	}

	private void OnShowEclipseManSkillRefreshEffect()
	{
	}

	private void InitSkillMightyEnergy()
	{
	}

	private void OnSkillMightyEnergyEvent(object[] param)
	{
	}

	private void TryOpenSkillMightyEnergyCtrl()
	{
	}

	private void TryOpenSkillMightyEnergyCtrl(uint currentValue)
	{
	}

	private bool IsSkillMightyEnergyFeatureAvailable(Player player)
	{
		return false;
	}

	public void NotifyHudConfigChanged(HudConfigItem config)
	{
	}

	public bool TryGetSkillMightyEnergyFillSpriteWorldPosition(out Vector3 worldPosition)
	{
		worldPosition = default(Vector3);
		return false;
	}

	private void UpdateSkillMightyEnergySide()
	{
	}

	private void _003COnBtnDown_003Eb__112_0()
	{
	}

	private void _003CShowSkillPerksVfx_003Eb__152_0()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshVisibility(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIActiveGroupSwitch(UInt128 P0)
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
