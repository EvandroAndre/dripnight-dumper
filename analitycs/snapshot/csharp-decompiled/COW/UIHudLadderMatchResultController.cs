using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;
using proto;

namespace COW;

public class UIHudLadderMatchResultController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private struct ProgressInfo
	{
		public float CurPercentage;

		public float StartProgressValue;

		public float EndProgressValue;

		public float speedValue;
	}

	private sealed class _003CPlayAndWaitingForAnimationOver_003Ed__109 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Animation animationCom;

		public string animation;

		private float _003CaniamtionTime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayAndWaitingForAnimationOver_003Ed__109(int _003C_003E1__state)
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

	private sealed class _003CPlayBigUpgradeAnimation_003Ed__104 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudLadderMatchResultController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayBigUpgradeAnimation_003Ed__104(int _003C_003E1__state)
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

	private sealed class _003CPlayProgressAnimation_003Ed__108 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProgressInfo info;

		public UIHudLadderMatchResultController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayProgressAnimation_003Ed__108(int _003C_003E1__state)
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

	private sealed class _003CPlayRatingBoardAnim_003Ed__101 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudLadderMatchResultController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayRatingBoardAnim_003Ed__101(int _003C_003E1__state)
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

	private sealed class _003CPlayScoreAnimation_003Ed__107 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudLadderMatchResultController _003C_003E4__this;

		private int _003Cnum_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayScoreAnimation_003Ed__107(int _003C_003E1__state)
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

	private sealed class _003CPlayShieldAnim_003Ed__106 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudLadderMatchResultController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayShieldAnim_003Ed__106(int _003C_003E1__state)
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

	private sealed class _003CStartLadderResultAnimation_003Ed__105 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudLadderMatchResultController _003C_003E4__this;

		private bool _003CcanNotPlayScoreAnimAtFirst_003E5__2;

		private bool _003Cupgrade_003E5__3;

		private int _003Ci_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartLadderResultAnimation_003Ed__105(int _003C_003E1__state)
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

	private UIHudLadderMatchResultView m_View;

	private const int SCORE_ADD_NUM = 1;

	private const float PROGRESS_ANIM_SPEED_1 = 2f;

	private const float PROGRESS_ANIM_SPEED_2 = 4f;

	private const uint PROGRESS_OFFSET = 30u;

	private const int RANK_SCORE_REDUCE_MAX_SCALE = 100;

	private const string ANIMATION_ENTER = "UIHudLadderMatchResult_In";

	private const string ANIMATION_RANK_UP = "UILadderMatchRankUp";

	private const string ANIMATION_RANK_DOWN = "UILadderMatchRankDown";

	private const string ANIMATION_RANK_STAR = "UILadderMatchRankStar";

	private const string ANIMATION_RANK_GREAT_UP_NEXT = "UIHudLadderMatchResult_Hide002";

	private const string ANIMATION_SHIELD = "UIFXShield3";

	private const string ANIMATION_FIRST_REACH = "UILadderMatchRankUpFirstReach";

	private const string ANIMATION_FIRST_REACH_BIG_UPGRADE = "UIHudLadderMatchResult_InFirstReach";

	private const string RATING_RANK_BUBBLE_LABEL_GOLD = "T_52_TSY_NEXT_GOLD_MEDAL_RANKUP";

	private const string RATING_RANK_BUBBLE_LABEL_SILVER = "T_52_TSY_NEXT_SILVER_MEDAL_RANKUP";

	private bool m_WaitSeasonYearData;

	private UISeasonYearMatchResultController m_SeasonYearMatchResultCtrl;

	private int DeltaPoint;

	private string DeltaStr;

	private int BeforePoint;

	private uint BeforeRank;

	private uint BeforeRankBRStar;

	private float BeforeProgressValue;

	private LadderLevelData BeforeLevelData;

	private int AfterPoint;

	private uint AfterRank;

	private uint AfterRankBRStar;

	private float AfterProgressValue;

	private LadderLevelData AfterLevelData;

	private Color m_ColorSpecialPoint;

	private Color m_ColorTeamIsolationDeduct;

	private int TimesUpgrade;

	private bool CanCloseFlag;

	private UIHudCommonlTipsController m_TokenTipCtrl;

	private UIHudMatchResultRatingBoardController m_RatingBoardCtrl;

	private bool ShowBigUpgradeAnimation;

	private GameObject[] BeforeStar;

	private GameObject[] AfterStar;

	private uint m_FirstSpecialBonusType;

	private uint m_SecondSpecialBonusType;

	private string m_WeaponPowerTipsDesc;

	private UIModelLadderMatch m_ModelLadderBR;

	private bool m_NeedShieldAnim;

	private bool m_IsFirstReach;

	private ResourceID m_FirstReachLabelRes;

	private GameObject m_FirstReachLabel;

	private UIHudCrossModeTipController m_CrossModeTipCtrl;

	private int m_BigUpGradeAnimPanelDepth;

	private bool m_CanSetFinalStateFlag;

	private bool m_IsBattlePointsRankUpgrade;

	private bool m_IsRatingMedalQuickUpgrade;

	private DLBMPCCFKKM m_MatchMode;

	private GameObject m_NormalFlagUIFX;

	private GameObject m_HippoCrisisFlagUIFX;

	private ResourceID m_NormalFlagUIFXRes;

	private ResourceID m_HippoCrisisFlagUIFXRes;

	private GameObject m_HippoCrisisFlag;

	private ResourceID m_HippoCrisisFlagRes;

	private VisualInstanceHolder m_TrailEffectHolder;

	private GameObject m_TrailEffectObj;

	private bool m_CanPlayRatingTrailAnim;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetResultData(MatchIncome incomeData, MatchStats statsData, DLBMPCCFKKM matchMode = DLBMPCCFKKM.EMATCHMODE_RANKING)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public override int GlassDelay()
	{
		return 0;
	}

	private void SendLog()
	{
	}

	private void OnClickMask()
	{
	}

	private void OnWeaponPowerTitleTip()
	{
	}

	private void OnOccupationUpdateTipClick()
	{
	}

	private void InitOccupationUpdate()
	{
	}

	private void InitGrandMasterPos()
	{
	}

	private void InitRankInfo(MatchIncome income)
	{
	}

	private void SetRankRelocationUIState()
	{
	}

	private void SetBeforeRankUIView()
	{
	}

	private void SetBeforeRankStarView(uint starNum, bool isPeakRank = false)
	{
	}

	private void SetAfterRankUIView()
	{
	}

	private void SetAfterRankStarView(uint starNum)
	{
	}

	private void SetProcessBarValue()
	{
	}

	private void SetBigUpgradeShowState()
	{
	}

	private LadderLevelData GetLevelDataByRank(int rank)
	{
		return null;
	}

	private uint GetStarNum(int rank, int rankPoint)
	{
		return 0u;
	}

	private int GetMultiScoreRadio(uint[] multiScoreType, int multiScoreRadio, uint scoreType)
	{
		return 0;
	}

	private void SetMatchModeView()
	{
	}

	private void InitScoreInfo(MatchIncome income, MatchStats stats)
	{
	}

	private void SetBRCrossModeTip()
	{
	}

	private void PlayCrossModeAnim()
	{
	}

	private void SetSpecialBonus(MatchIncome income, MatchStats stats)
	{
	}

	private void FillSpecialBounsViewParam(uint bounsType, MatchIncome income, out uint param)
	{
		param = default(uint);
	}

	private void SetSpecialBonusType(uint bounsType)
	{
	}

	private void GenareteFirstReachLabel()
	{
	}

	private void InitAntiHackProtect(MatchIncome income)
	{
	}

	private void InitWeaponPower()
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

	public void TestPopSeasonYearWindow(uint seasonYearId)
	{
	}

	private IEnumerator PlayRatingBoardAnim()
	{
		return null;
	}

	private void OnTrailEffectLoaded(GameObject obj)
	{
	}

	private void SetSettlementContentVisible(bool visible)
	{
	}

	private IEnumerator PlayBigUpgradeAnimation()
	{
		return null;
	}

	private IEnumerator StartLadderResultAnimation()
	{
		return null;
	}

	private IEnumerator PlayShieldAnim()
	{
		return null;
	}

	private IEnumerator PlayScoreAnimation()
	{
		return null;
	}

	private IEnumerator PlayProgressAnimation(ProgressInfo info)
	{
		return null;
	}

	private IEnumerator PlayAndWaitingForAnimationOver(Animation animationCom, string animation)
	{
		return null;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003COnTrailEffectLoaded_003Eb__102_0(TweenPositionArc arc)
	{
	}

	private void _003CPlayBigUpgradeAnimation_003Eb__104_0()
	{
	}

	private void _003CPlayBigUpgradeAnimation_003Eb__104_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public int _003C_003EiFixBaseProxy_GlassDelay()
	{
		return 0;
	}
}
