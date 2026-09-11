using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudPlayerStatsController : UIBaseController
{
	private enum EHpBarIconVfx
	{
		None,
		JBEPSkill,
		Eighth_GP_InfiniteHealer
	}

	private enum ELongPressType
	{
		exp = 1,
		level,
		weaponDamageRate
	}

	private sealed class _003C_003Ec__DisplayClass127_0
	{
		public Vector3 killEffectPos;

		public Vector3 hudScale;

		public Vector3 pos;

		internal void _003CShowEclipseManExecuteFlashEffect_003Eb__0(uint uniqueID, ResourceID vfxResID, GameObject instance)
		{
		}
	}

	private sealed class _003CPlayProgressBarAnim_003Ed__121 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIProgressBar bar;

		public float endValue;

		public float duration;

		public UIHudPlayerStatsController _003C_003E4__this;

		private float _003CstartValue_003E5__2;

		private float _003CstartTime_003E5__3;

		private float _003Cpercent_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayProgressBarAnim_003Ed__121(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UIHudPlayerStatsView m_View;

	private BHGGAEEHJCO m_BindPlayer;

	private Player m_Player;

	private UIModelMatch m_ModelMatch;

	private bool m_IsPlayerDieing;

	private MutableString m_HPTextBuilder;

	public readonly float ColorPlayerStatsAlpha;

	public readonly Color ColorDisableEquipmentStat;

	private Coroutine m_MaxChangeHpBarChangeCor;

	private bool m_ShowEclipseManExecuteBar;

	private bool m_HasShowEclipseManFlashEffect;

	private int m_EclipseManExecuteValue;

	private VisualInstanceHolder m_ExecuteBarHeadVfxHolder;

	private bool m_IsShowMedKitHp;

	private int MedKitHp;

	private int m_MedKitBaseHp;

	private UGC_CommonHudSwitchController.ESwitchValue m_IsHPNodeVisibilityByUGC;

	private UGC_CommonHudSwitchController.ESwitchValue m_IsEPNodeVisibilityByUGC;

	private UGC_CommonHudSwitchController.ESwitchValue m_IsSkillsNodeVisibilityByUGC;

	private UIHudPlayerStatsSPEPType1Controller m_SPEPType1Ctrl;

	private UIHudPlayerStatsSPEPType2Controller m_SPEPType2Ctrl;

	private EHpBarIconVfx m_CurHpBarIconVfx;

	private const int SkillMaxY = 47;

	private const int SkillMiddleY = 28;

	private const int SkillLowY = 12;

	private const int SkillOffSetY_LvSysShow = 40;

	private const int SkillOffsetY_MetropolisShow = 42;

	private const int LevelSysY_EPShow = 41;

	private const int LevelSysY_EPHide = 28;

	private const float MetropolisY_EPShow = 30f;

	private const float MetropolisY_EPHide = 16f;

	private bool m_InHypeMode;

	private float HypeNodePosY_EPShow;

	private float HypeNodePosY_EPHide;

	private float m_LastEffectTime;

	private float m_EffectAnimationTime;

	private uint m_DelayCallID;

	private uint m_AddExpDelayCallID;

	private UIHudSkillKnockDownBleedController m_KnockedDownBleedCtrl;

	private bool m_LongPressed;

	private ELongPressType m_LongPressedType;

	private ELongPressType m_CurShowType;

	private UIHudFlagBattleHypeProcessBarController m_FlagBattleHypeProcessBarCtrl;

	private UIHudHypeSliderController m_HypeSliderCtrl;

	private UIHudBigHeadHypeSliderController m_BigHeadHypeSliderCtrl;

	private UIHudFourSymbolsHypeProcessBarController m_FourSymbolsHypeSliderCtrl;

	private UIHudMetropolisPlayerInfoController m_MetropolisPlayer;

	private UIHudLevelPlayerStatsController m_BattleLevelPlayerStatsCtrl;

	private UIHudBooyahBountyPlayerInfoController m_BooyahBountyPlayerCtrl;

	private VisualInstanceHolder m_HpBarIconVfxHolder;

	private VisualInstanceHolder m_HpBarVfxHolder;

	private VisualInstanceHolder m_PlayerStatsHpTitleVfxHolder;

	private VisualInstanceHolder m_HpBarVFXWithInternalHolder;

	private VisualInstanceHolder m_HpBarRecoverVFXHolder;

	private VisualInstanceHolder m_HpBarRecoverFullVFXHolder;

	private VisualInstanceHolder m_HpBarRecoverOuterVFXHolder;

	private Vector3 m_HpBarVFXWithInternalOffset;

	private VisualInstanceHolder.OnInstanceAttached m_HpBarVFXWithInternalCallback;

	private GameObject m_HpBarVFXWithInternalGo;

	private float m_HpBarVFXWithInternalLastShowTime;

	private float m_HpBarVFXWithInternalMaintainSec;

	private float m_HpBarVFXWithInternalInternalSec;

	private uint m_nDelayCallHideImmortalitySuccessKilledEffect;

	private GameObject m_goImmortalitySuccessKilledEffect;

	private float m_fBemarkIceWallStartTimer;

	private float m_fBemarkIceWallEndTimer;

	private bool m_bIsShowBeMarkIceWall;

	private Color ARMORCOLOR;

	private Color LIFECOLOR;

	private float m_LastBarShowRate;

	private Player m_LastPlayer;

	public int MedKitBaseHp => 0;

	private Transform FSHypeNode => null;

	private Transform HypeNode => null;

	private Vector3 MetropolisRootPos => default(Vector3);

	public Vector3 GetMetropolisPlayerInfoPos()
	{
		return default(Vector3);
	}

	private void OnMedkitHpChange(object[] data)
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnHandleGetOverrideMatchSetting()
	{
	}

	private void RefreshBooyahBountySetting()
	{
	}

	private void HideImmortalitySuccessKilledEffect()
	{
	}

	private void OnPlayerSkillImmortalitySuccessKilled()
	{
	}

	private void SyncBeMarkIceWall(object[] data)
	{
	}

	private void RefreshBeMarkIceWallUI()
	{
	}

	private void SyncSlowDownMarked(object[] data)
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void Update()
	{
	}

	private void ReleaseAllVfxInstances()
	{
	}

	private void UpdateCheckHpBarIconVfx()
	{
	}

	private void TryShowEighth_GP_InfiniteHealerHPBarVfx(bool show)
	{
	}

	public void OnMarkedByPetSkillCuringEnemy(object[] data)
	{
	}

	private void CancelDelayCall()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void HideCuringEnemy()
	{
	}

	private void RefreshLifeCount()
	{
	}

	private void RefreshAP()
	{
	}

	private void RefreshAPIcon()
	{
	}

	public void BindPlayer(BHGGAEEHJCO pID)
	{
	}

	private void UpdateMarkStatus(bool show)
	{
	}

	private void OnPlayerPostInit(object[] data)
	{
	}

	private void ForceInitHpDamage()
	{
	}

	private void OnHPChanged(GEvent data)
	{
	}

	private void OnSPChange(GEvent data)
	{
	}

	private void RefreshSP(Player.ACOGBMIGNPI type = Player.ACOGBMIGNPI.ESPType_None, uint newValue = 0u, uint oldValue = 0u)
	{
	}

	private void OnShowTutorialHP(object[] data)
	{
	}

	private void OnInventoryPickup(object[] param)
	{
	}

	private void OnPlayerPersonaStateChange(GEvent evt)
	{
	}

	private void OnMAXHPChanged(object[] data)
	{
	}

	private void OnEPChanged(GEvent data)
	{
	}

	public void RefreshNodeHeightByEPSP(bool currentShow, bool show)
	{
	}

	private void RefreshEP(bool directSet = false)
	{
	}

	private void RefreshMAXHP(object[] data)
	{
	}

	private void StopMaxChangeHpBarShowAnim()
	{
	}

	private IEnumerator PlayProgressBarAnim(UIProgressBar bar, float endValue, float duration = 0.5f)
	{
		return null;
	}

	private void RefreshEPEffect(object[] data)
	{
	}

	private void RefreshHP(bool isDead)
	{
	}

	private void RefreshHP(bool isDead, ushort oldValue, ushort newValue, bool hasDelta)
	{
	}

	private void OnRefreshEclipseManExecuteBar()
	{
	}

	private void RefreshExecuteBar()
	{
	}

	private void ShowEclipseManExecuteFlashEffect(Vector3 pos)
	{
	}

	private void ReplayForceUpdateUI(object[] data)
	{
	}

	private void OnAddPlayer(object[] data)
	{
	}

	private void OnObservePlayer(object[] data)
	{
	}

	private void OnRemoveMapMark(object[] data)
	{
	}

	private void OnUpdateMapMark(object[] data)
	{
	}

	private void OnKnockDownFlagChange(object[] data)
	{
	}

	private void CheckSpectatorTargetOnOpen()
	{
	}

	private void RecycleSkillTemplateCtrl(UIHudSkillTemplateController skillTemplateController)
	{
	}

	private void OnShowWeaponDamageEnhance(object[] data)
	{
	}

	private void OnWeaponDamageRateChanged(object[] data)
	{
	}

	private void OnShowAntiCloth(object[] data)
	{
	}

	public void CreateHypeModeProcessBar()
	{
	}

	private void OnHudSelectionChanged(object[] param)
	{
	}

	private void OnTrainingZoneChanged(object[] param)
	{
	}

	private void OnEnquipmentEquipStateChanged(GEvent InParams)
	{
	}

	private void RefreshStrengthenArmorUI()
	{
	}

	private void OnAndrewSkillEffectCountChange(GEvent evt)
	{
	}

	private void RefreshPlayerStrengthenArmorUI()
	{
	}

	private void UpdateFSModePosInt(int value)
	{
	}

	public void OnPinMark()
	{
	}

	private void ResetSlowDownMark()
	{
	}

	private void OnHPForceEffect(GEvent evt)
	{
	}

	public void HideHPByUGC(UGC_CommonHudSwitchController.ESwitchValue switchValue)
	{
	}

	public void HideEPByUGC(UGC_CommonHudSwitchController.ESwitchValue switchValue)
	{
	}

	public void HideSkillsByUGC(UGC_CommonHudSwitchController.ESwitchValue switchValue)
	{
	}

	public GameObject GetGameObjectByUGC(UGC_CommonHudSwitchController.EPlayerHudSwitchType hudType)
	{
		return null;
	}

	private void TryOpenBattleLevelPlayerStatsCtrl()
	{
	}

	private void OnBattleLevelLocalPlayerSelectionConfirm()
	{
	}

	private void RefreshBattleLevelVisibilityOnBind()
	{
	}

	private void TryReleasePlayerStatsHpTitleVfx()
	{
	}

	private void StartPlayerStatsHpTitleVfx(ResourceID hpTitleVfx)
	{
	}

	private void RefreshCustomVisualEffectStyleHpTitleVfxOnBind()
	{
	}

	private void OnCustomVisualEffectStyleHpTitleVfxChanged(uint playerID)
	{
	}

	private void OnShowPlayerHPBarRecoverVFX(GEvent gEvent)
	{
	}

	private void OnHidePlayerHPBarRecoverVFX()
	{
	}

	private void ReleaseHpBarRecoverVFXWithInterval()
	{
	}

	private void OnShowPlayerHPBarVFXWithInternal(GEvent gEvent)
	{
	}

	private void ShowHpBarVFXWithInterval(ResourceID resID, float internalSec, float maintainSec)
	{
	}

	private void DelegateLoadFountainModel(GameObject go)
	{
	}

	private void RefreshHpBarVFXWithInterval()
	{
	}

	private void RefreshHpBarRecoverVFX()
	{
	}

	private void ReleaseHpBarVFXWithInterval()
	{
	}

	private void OnGotInfiniteEffect()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void _003COnUIOpen_003Eb__88_0(bool press)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
