using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIElitePassChallengeController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<BundleShowData, BaseItemInfo> _003C_003E9__57_0;

		public static Converter<BundleShowData, BaseItemInfo> _003C_003E9__58_0;

		internal BaseItemInfo _003CSetTreasureBoxView_003Eb__57_0(BundleShowData temp)
		{
			return null;
		}

		internal BaseItemInfo _003CSetBpDailyChestView_003Eb__58_0(BundleShowData temp)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass67_0
	{
		public StandardTabItemViewData mainTabData;

		public UIElitePassChallengeController _003C_003E4__this;

		internal void _003CCreateTab_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass67_1
	{
		public StandardSubTabItemViewData subTabData;

		public _003C_003Ec__DisplayClass67_0 CS_0024_003C_003E8__locals1;

		internal void _003CCreateTab_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass72_0
	{
		public UITaskController taskCtrl;

		public UIElitePassChallengeController _003C_003E4__this;

		internal void _003CShowTaskGuide1_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass73_0
	{
		public UITaskController taskCtrl;

		public UIStandardTabItemRemakeController itemCtrl;

		internal void _003CShowTaskGuide2_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass84_0
	{
		public uint newChallengeID;

		internal bool _003CRefreshTaskContent_003Eb__0(EPWeeklyQuestInfo x)
		{
			return false;
		}
	}

	private sealed class _003CExpProgressChangeAni_003Ed__111 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public uint oldNum;

		public uint newNum;

		public float duration;

		public UIElitePassChallengeController _003C_003E4__this;

		private float _003ClerpValue_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CExpProgressChangeAni_003Ed__111(int _003C_003E1__state)
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

	private sealed class _003CPlayBPClaimChallengeAwardVFX_003Ed__108 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIElitePassChallengeController _003C_003E4__this;

		public uint expIncre;

		private int _003ClevelUpdateNum_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayBPClaimChallengeAwardVFX_003Ed__108(int _003C_003E1__state)
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

	private sealed class _003CPlayExpProgressUpdate_003Ed__110 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public uint oldExpValue;

		public uint newExpValue;

		public UIElitePassChallengeController _003C_003E4__this;

		public int levelUpdateNum;

		public float duration;

		private uint _003ColdGrade_003E5__2;

		private uint _003CnewPeriodExpNum_003E5__3;

		private float _003CdurationSecond_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayExpProgressUpdate_003Ed__110(int _003C_003E1__state)
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

	private UIElitePassChallengeView m_View;

	private UIModelBooyahPass m_BPModel;

	private UIModelMall m_ModelMall;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelMapOpeningInfo m_ModelMapOpeningInfo;

	private UIGuideTipsController m_GuideTipsCtrl;

	private UICountDownController m_CDController;

	private bool m_HasCreateTab;

	private bool m_NeedForceUpdateTab;

	private bool m_HasSetIgnoreSubTabRedPointBounds;

	private List<EPTaskTabData> m_EPTaskTabDatas;

	private UIStandardDrawerTabRemakeController m_TabCtrl;

	private List<StandardTabItemViewData> m_MainTabDataList;

	private List<StandardSubTabItemViewData> m_SubTabDataList;

	private List<BaseItemInfo> m_DailyProcessReward;

	private UIStandardItemMiniController m_FPDailyRewardItem;

	private UIStandardItemMAXDController m_PPDailyRewardItem;

	private EEPTaskTab m_CurrentTab;

	private EEPTaskTab m_GoposTab;

	private UICommonGuideController m_EPWeeklyTabUnlockGuideCtrl;

	private Coroutine m_BPClaimChallengeAwardCoroutine;

	private uint m_EPWeeklyGuideDelayID;

	private BaseItemInfo m_RealPreviewInfo;

	private bool m_PlayAnim;

	private Vector3 m_ScrollViewOriginPos;

	private Vector3 m_Table2OriginPos;

	private Vector3 m_ImportantLabelPos;

	private float m_TaskScrollviewHeightOri;

	private const float PPDAILY_SCROLLVIEW_OFFSET = 67f;

	private const float TASK_SCROLLVIEW_WIDTH = 660f;

	private const float TASK_SCROLLVIEW_HEIGHT_DES = 460f;

	private const float BP_FLY_VFX_TIME = 0.667f;

	private const float BP_LEVEL_UP_TIME = 1.2f;

	private const float BP_EXP_PORGRESS_INCRE_TIME = 0.5f;

	public Vector2 ElitePassTaskSize;

	public UITable2.Margin ElitePassTaskMargin;

	private uint m_NewbieGuideDelayCall;

	private ulong m_DailyProcessEndTime;

	private UITaskController m_ParentCtrl;

	private bool m_NotSetMaxRewardPreview;

	private uint m_DailyProcessNeedChallengeNum;

	public bool PlayAnim => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void GetMaxRewardProgressPos()
	{
	}

	private void InitState()
	{
	}

	private void InitLabel()
	{
	}

	private void SetBackFlowNode()
	{
	}

	private void SetTaskRefreshLabel()
	{
	}

	private void SetBooyahPassCon()
	{
	}

	private void SetBpProgressCon()
	{
	}

	private void RefreshBooyahPassCon()
	{
	}

	private void SetTreasureBoxView()
	{
	}

	private void SetBpDailyChestView()
	{
	}

	private void SetDailyProcessRewardView()
	{
	}

	private void SetBPBigRewardClaimState()
	{
	}

	private void SetBPBigRewardProgressPos(uint id)
	{
	}

	private void SetBigRewardViewBP()
	{
	}

	private void SetBigRewardNormalViewBP(BooyahPassBaseItemData previewBigRewardItemData)
	{
	}

	private void SetBigRewardPrivilegeViewBp(BooyahPassBaseItemData previewBigRewardItemData)
	{
	}

	private void InitTab()
	{
	}

	private void InitTable2Template()
	{
	}

	private void CreateTab()
	{
	}

	public void RefreshDailyTaskView()
	{
	}

	private void OnSelectTab(EEPTaskTab tab)
	{
	}

	private void CanCelEpWeeklyGuideDelayCall()
	{
	}

	private void ShowNewbieGuide()
	{
	}

	private void ShowTaskGuide1()
	{
	}

	private void ShowTaskGuide2()
	{
	}

	private void InsertLadderMatchTaskInfo(int firstOnGoingIndex, int firstClaimedIndex)
	{
	}

	private void ShowElitePassGuide()
	{
	}

	private void CancelNewbieGuideDelayCall()
	{
	}

	private void SetDailyPPScrollViewPos()
	{
	}

	private void ResetScrollViewPos()
	{
	}

	private int EPChallengeSortFunc(EPChallengeInfo x, EPChallengeInfo y)
	{
		return 0;
	}

	private void UpdateTabRedDot()
	{
	}

	private void SetSubTabIgnoreRedPointBounds()
	{
	}

	private void UpdateWeeklySubTabLockState()
	{
	}

	public void SetNewQuaityIcon(uint id)
	{
	}

	private void RefreshTaskContent(uint week, int taskIndex, uint newChallengeID)
	{
	}

	private void RefreshDailyRewardState()
	{
	}

	private void OnDailyFPRulesTipsClick()
	{
	}

	private void OnDailyPPRulesTipsClick()
	{
	}

	private void OnGotoBPBtnClick()
	{
	}

	private void OnDailyHelpBtnClick()
	{
	}

	private void OnWeeklyHelpBtnClick()
	{
	}

	private void OnTreasureBoxClaimBtnClick()
	{
	}

	private void OnBPDailyChestBtnClick()
	{
	}

	private void OnClaimAllBtnClick()
	{
	}

	private void OnBpBigRewardClaimBtnClick()
	{
	}

	private void OnPrivilegeBtnClick()
	{
	}

	private void OnBpBigRewardUnLock()
	{
	}

	private void OnBPBigRewardCheckBtnClick()
	{
	}

	private void OnEPChallengeUpdate(object[] param)
	{
	}

	private void StopNewbieGuide(object[] args)
	{
	}

	private void OnBpUnlocked(object[] param)
	{
	}

	private void HideBackFlow()
	{
	}

	private void OnUpdateTabRedDot(object[] param)
	{
	}

	private void OnBPDataReady()
	{
	}

	private void OnRefreshTask()
	{
	}

	private void SetWeeklyTabUnlockGuide(EEPTaskTab tab)
	{
	}

	private void OnBPChallengeClaimPlayUIFX(object[] param)
	{
	}

	private void SetGameObjectActive(VFXCreateHelper go, bool isActive)
	{
	}

	private IEnumerator PlayBPClaimChallengeAwardVFX(uint expIncre)
	{
		return null;
	}

	private void Update()
	{
	}

	private IEnumerator PlayExpProgressUpdate(uint oldExpValue, uint newExpValue, int levelUpdateNum, float duration)
	{
		return null;
	}

	private IEnumerator ExpProgressChangeAni(uint oldNum, uint newNum, float duration)
	{
		return null;
	}

	public void GotoTab(EEPTaskTab tab, bool force = false)
	{
	}

	private void SetMaxRewardPreviewView()
	{
	}

	private void SetMaxRewardPreviewDisplay(bool isShow, bool isFP = false, bool isDescShow = true)
	{
	}

	public void SetClaimAllBtnClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003COnUIInit_003Eb__45_0()
	{
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__66_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__66_1()
	{
		return null;
	}

	private void _003COnSelectTab_003Eb__69_0()
	{
	}

	private void _003COnSelectTab_003Eb__69_1()
	{
	}

	private void _003CSetWeeklyTabUnlockGuide_003Eb__105_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
