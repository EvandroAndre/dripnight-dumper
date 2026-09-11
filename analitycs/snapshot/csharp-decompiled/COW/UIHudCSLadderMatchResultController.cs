using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;
using proto;

namespace COW;

public class UIHudCSLadderMatchResultController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private sealed class _003CPlayAndWaitingForAnimationOver_003Ed__131 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Animation animationCom;

		public string animation;

		private float _003CaniamtionTime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayAndWaitingForAnimationOver_003Ed__131(int _003C_003E1__state)
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

	private sealed class _003CPlayBigUpgradeAnimation_003Ed__125 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudCSLadderMatchResultController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayBigUpgradeAnimation_003Ed__125(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CPlayLoseStarAnim_003Ed__119 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LadderMatchStarGroup currentStarGroup;

		public UIHudCSLadderMatchResultController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayLoseStarAnim_003Ed__119(int _003C_003E1__state)
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

	private sealed class _003CPlayProtectPointExtraStarAnim_003Ed__120 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudCSLadderMatchResultController _003C_003E4__this;

		public Vector3 endPos;

		private float _003CdeltaTime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayProtectPointExtraStarAnim_003Ed__120(int _003C_003E1__state)
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

	private sealed class _003CPlayShieldAnim_003Ed__123 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudCSLadderMatchResultController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayShieldAnim_003Ed__123(int _003C_003E1__state)
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

	private sealed class _003CPlayUpStarAnim_003Ed__118 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LadderMatchStarGroup currentStarGroup;

		public bool needExtraAnim;

		public UIHudCSLadderMatchResultController _003C_003E4__this;

		private LadderMatchStar _003CstarNeedGain_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayUpStarAnim_003Ed__118(int _003C_003E1__state)
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

	private sealed class _003CStartLadderResultAnimation_003Ed__121 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudCSLadderMatchResultController _003C_003E4__this;

		private int _003CpointsDelta_003E5__2;

		private int _003CstarNeedPlayExtraAnim_003E5__3;

		private bool _003CisUpStar_003E5__4;

		private bool _003CisLevelChange_003E5__5;

		private LadderMatchStarGroup _003CcurrentStarGroup_003E5__6;

		private int _003Cstar_003E5__7;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartLadderResultAnimation_003Ed__121(int _003C_003E1__state)
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

	private UIHudCSLadderMatchResultView m_View;

	private const string ANIMATION_ENTER = "UIHudCSLadderMatchResult_In";

	private const string ANIMATION_RANK_UP = "UILadderCSMatchRankUp";

	private const string ANIMATION_RANK_DOWN = "UILadderCSMatchRankDown";

	private const string ANIMATION_RANK_GREAT_UP_NEXT = "UIHudCSLadderMatchResult_Hide002";

	private const string ANIMATION_SHIELD = "UIFXShield3";

	private const string ANIMATION_FIRST_REACH = "UILadderCSMatchRankUpFirstReach";

	private const string ANIMATION_FIRST_REACH_BIG_UPGRADE = "UIHudCSLadderMatchResult_InFirstReach";

	private const float RANK_UPDATE_WAIT_TIME = 0.1f;

	private const float PROTECT_FLY_STAR_ANIM_TIME = 0.5f;

	private DLBMPCCFKKM m_MatchMode;

	private uint m_GameMode;

	private ResourceID m_FirstReachLabelRes;

	private GameObject m_FirstReachLabel;

	private bool IsWin;

	private int RankBefore;

	private int RankAfter;

	private int PointsBefore;

	private int PointsAfter;

	private int PointsVeteran;

	private uint PreProtect;

	private uint CurProtect;

	private uint ProtectBeforeMultiMapBonus;

	private bool MultiMapBonus;

	private float CsMultiMapBonusRadio;

	private CSRankData CurrentLevelData;

	private CSRankData OldLevelData;

	private LadderMatchStarGroup StarGroupBefore;

	private LadderMatchStarGroup StarGroupAfter;

	private bool IsInProtect;

	private bool IsInAntiHackProtect;

	private bool m_IsSpecialModeProtect;

	private uint m_NoDeductCardId;

	private bool ShowBigUpgradeAnimation;

	private uint m_RankDValuePoints;

	private uint m_AchieveProtectionScore;

	private uint m_BadBehaviorCompensation;

	private uint m_DaliyFirstWin;

	private int m_AFKPunish;

	private int m_NegativePoint;

	private uint m_BattlePoints;

	private int m_BaseProtectPoints;

	private uint m_MVPPoints;

	private uint m_ReviveAndHealPoints;

	private uint m_StreakWinPoints;

	private uint m_CSDailyTaskPoints;

	private uint m_CSSpecialTaskProtectPoints;

	private uint m_KingScore;

	private uint m_ProtectionBattlePoints;

	private uint m_HackerProtectionPoints;

	private uint m_LongGameProtectPoints;

	private uint m_MedalProtectPoints;

	private Color m_ColorDeductPoint;

	private Color m_ColorTeamIsolationDeduct;

	private Color m_ColorSpecialPoint;

	private uint m_ProtectPointsAddStars;

	private bool m_IsUseDoubleBonusCard;

	private bool m_IsCsLoserProtectStar;

	private bool m_IsCsLoserAddStar;

	private bool m_IsNewMapProtect;

	private bool m_HasFinishMapTask;

	private uint m_FirstSpecialBonusType;

	private uint m_SecondSpecialBonusType;

	private uint m_StreakWins;

	private uint m_MultiMapPoints;

	private uint m_CrossModeBounsPoints;

	private int m_ClanBonusCardPoints;

	private uint m_ClanBonusCardId;

	private string m_ProtectTitleTipDesc;

	private string m_WeaponPowerTipDesc;

	private UIProtectionPointCircleController m_ProtectCircleCtr;

	private bool m_NeedBigUpgradeAnim;

	private uint m_ProtectPointBefAnim;

	private uint m_RankBeforeBaseScore;

	private UIModelPeriodicLadderMatch m_ModelLadderPeriodic;

	private UIModelCSLadderMatch m_ModelLadderCS;

	private uint m_SkipedExtraStarNum;

	private bool m_IsWinNoStar;

	private bool m_IsTeamingStarSuppressed;

	private UIHudMatchResultPointsItemController m_AchieveScoreCtr;

	private UIHudMatchResultSpecialBonusItemController m_ExtraStarBounsCtr;

	private bool m_CanCloseFlag;

	private bool m_CanSetFinalStateFlag;

	private uint m_GroupBeforeStarCnt;

	private uint m_GroupAfterStarCnt;

	private bool m_IsVeteranCallBackBuffEffected;

	private bool m_IsBattlePointsRankUpgrade;

	private bool m_NeedShieldAnim;

	private int m_BigUpGradeAnimPanelDepth;

	private CSRankData m_CSMinHeriocRankData;

	private bool m_WaitSeasonYearData;

	private UISeasonYearMatchResultController m_SeasonYearMatchResultCtrl;

	private UICSPeakTournamentMatchResultController m_CSPeakTournamentMatchResultCtrl;

	private bool m_IsFirstReach;

	private uint m_EighthTrainRoundProtectPoint;

	private MatchIncome m_MatchIncome;

	private MatchStats m_MatchStats;

	private bool m_BehaviorBanDrop;

	private uint m_CsSpecialModeProtectionPoints;

	private UIHudCrossModeTipController m_CrossModeTipCtrl;

	private int m_RateBySummaryLV;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetResultData(MatchIncome incomeData, MatchStats statsData, DLBMPCCFKKM matchMode = DLBMPCCFKKM.EMATCHNODE_CSRANKING)
	{
	}

	private void SetCSHeroicStarMaxLabel()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private bool IsCSRanking()
	{
		return false;
	}

	private bool isReachHeroic(CSRankData data)
	{
		return false;
	}

	private void OnProtectTitleTipClick()
	{
	}

	private void OnWeaponPowerTitleTip()
	{
	}

	private void OnOccupationUpdateTipClick()
	{
	}

	private void OnLargeRankGapNoStarTipClick()
	{
	}

	private void SetOccupationUpdate()
	{
	}

	private CSRankData GetRankDataByRank(int rank)
	{
		return null;
	}

	private void OnMaskClick()
	{
	}

	private void GenareteFirstReachLabel()
	{
	}

	private IEnumerator PlayUpStarAnim(LadderMatchStarGroup currentStarGroup, bool needExtraAnim)
	{
		return null;
	}

	private IEnumerator PlayLoseStarAnim(LadderMatchStarGroup currentStarGroup)
	{
		return null;
	}

	private IEnumerator PlayProtectPointExtraStarAnim(Vector3 endPos)
	{
		return null;
	}

	private IEnumerator StartLadderResultAnimation()
	{
		return null;
	}

	private void PlayCircleAnimAfterStarAnim()
	{
	}

	private IEnumerator PlayShieldAnim()
	{
		return null;
	}

	private void SetSettlementContentVisible(bool visible)
	{
	}

	private IEnumerator PlayBigUpgradeAnimation()
	{
		return null;
	}

	private void SetCSCrossModeTip()
	{
	}

	private void PlayCrossModeAnim()
	{
	}

	private void InitGrandMasterPos()
	{
	}

	private void SetOldRankUIGroup()
	{
	}

	private void SetCurrentRankUIGroup()
	{
	}

	private IEnumerator PlayAndWaitingForAnimationOver(Animation animationCom, string animation)
	{
		return null;
	}

	private void SetSpecialTips()
	{
	}

	private bool IsInvalidMatch()
	{
		return false;
	}

	private void SetNotifyInfo()
	{
	}

	private void SetScoreInfoPanel()
	{
	}

	private void SetProtectionPointsCircle()
	{
	}

	private void GetRankBeforeBaseScore()
	{
	}

	private void SetProtectionPoints()
	{
	}

	private void SetSpecialBonus()
	{
	}

	private void SetRankRelocationUIState()
	{
	}

	private void SetSpecialBonusItemViewData(uint bounsType, UIHudMatchResultSpecialBonusItemController ItemCtr)
	{
	}

	private void SetSpecialBonusType(uint bounsType)
	{
	}

	private void SetBigUpgradeRankState()
	{
	}

	private void SetWeaponPower()
	{
	}

	private void SetToFinalState()
	{
	}

	private void CheckAndPopSeasonYearWindow()
	{
	}

	private void PopSeasonYearWindow(uint seasonYearId)
	{
	}

	private void CheckAndPopCSPeakWindow()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CPlayBigUpgradeAnimation_003Eb__125_0()
	{
	}

	private void _003CPlayBigUpgradeAnimation_003Eb__125_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
