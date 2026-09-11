using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIVeteranV3MainController : UIPreviewNavigationController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public UIVeteranV3MainController _003C_003E4__this;

		public BaseItemInfo info;

		internal void _003CRefreshDailyReward_003Eb__0()
		{
		}
	}

	private sealed class _003CDelayRefreshView_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIVeteranV3MainController _003C_003E4__this;

		private int _003CselectedRewardIndex_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayRefreshView_003Ed__54(int _003C_003E1__state)
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

	private sealed class _003CPlayMissionToProgressAnimation_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIVeteranV3MainController _003C_003E4__this;

		public int index;

		public uint incrementActiveness;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayMissionToProgressAnimation_003Ed__77(int _003C_003E1__state)
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

	private sealed class _003CPlayProgressUpAnimation_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public uint oldActiveness;

		public uint curActiveness;

		public UIVeteranV3MainController _003C_003E4__this;

		private float _003ClerpValue_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayProgressUpAnimation_003Ed__79(int _003C_003E1__state)
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

	private sealed class _003CShowNextDayTipsBubble_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIVeteranV3MainController _003C_003E4__this;

		public float delayTime;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowNextDayTipsBubble_003Ed__59(int _003C_003E1__state)
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

	private uint m_pro;

	private UIVeteranV3MainView m_View;

	private UIModelVeteran m_ModelVeteran;

	private ulong m_AccoutntID;

	private int m_AwardCurIndex;

	private bool m_IsDailyRewardClaimBtnClicked;

	private Coroutine m_ProgressCoroutine;

	private Coroutine m_MissionToProgressCoroutine;

	private uint m_DailyRewardDelayCall;

	private uint m_DelayCallClose;

	private uint m_DelayCallHidePreview;

	private UIVeteranV3AwardItemController m_DailyRewardCtrl;

	private List<Transform> m_ListProgressAwardItemPos;

	private List<Transform> m_ListMissionItemPos;

	private readonly List<UIVeteranV3ProgressItemController> m_ProgressAwardCtrlList;

	private readonly List<UIVeteranV3DailyMissionItemController> m_MissionItemCtrlList;

	private UIVeteranV3AllTaskDoneController m_UIVeteranV3IAPAllTaskDoneController;

	private UIVeteranV3PurchasePopupWndController m_UIVeteranV3PurchasePopupWndController;

	private UIVeteranV3DiscountStoreController m_UIVeteranV3DiscountStoreController;

	private GameObject m_ProgressLineVFX;

	private GameObject m_AdvancedProgressLineVFX;

	private GameObject m_ProgressShiningVFX;

	private GameObject m_TaskTrailVFX;

	private GameObject m_PrivilegeIconVFX;

	private Coroutine m_DelayRefreshView;

	private bool m_IsUICtrlInit;

	private readonly Vector3[] MISSION_TO_PROGRESS_TRAIL_POS_FROM_ARRAY;

	private readonly Vector3 MISSION_TO_PROGRESS_TRAIL_POS_TO;

	private const string VETERAN_PLAYERPREFS_PRIVILEGE = "VeteranPrivilege_{0}";

	private const string VETERAN_PLAYERPREFS_PRIVILEGE_BIGEVENT = "VeteranPrivilegeBigEvent_{0}";

	private const uint MISSION_REWARD_NUM = 3u;

	private const uint MAX_PROGRESS_RAWARD_NUM = 8u;

	private const uint NORMAL_PROGRESS_RAWARD_NUM = 4u;

	private const int DAILY_RAWARD_PREVIEW_INDEX = -1;

	private const float PROGRESS_UP_DURATION = 1f;

	private const float HIDEPREVIEW_DURATION = 0.1f;

	private const float TASKTRAIL_DURATION = 0.43f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	protected override void OnUIDestroy()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void OnPrivilegeClick()
	{
	}

	private void OnDailyRewardDetailInfoClick()
	{
	}

	private void OnRuleBtnClick()
	{
	}

	private void OnDailyRewardClaimed(object[] data)
	{
	}

	private void DailyRewardClickCallBack()
	{
	}

	private void OnClickDiamondPurchaseClick()
	{
	}

	private void HideUI()
	{
	}

	private void ShowUI()
	{
	}

	private void SetupDefaultStateOnInit()
	{
	}

	private void PrepareCtrl()
	{
	}

	private void RefreshView()
	{
	}

	private IEnumerator DelayRefreshView()
	{
		return null;
	}

	private void AutoOpenDailyRewardPopWnd()
	{
	}

	private void RefreshCountTime()
	{
	}

	private void RefreshBubble()
	{
	}

	private void RefreshDailyReward(bool isPlayAni = false)
	{
	}

	private IEnumerator ShowNextDayTipsBubble(float delayTime)
	{
		return null;
	}

	private void RefreshProgressCon()
	{
	}

	private void RefreshActivenessValue()
	{
	}

	private void RefreshProgressAward()
	{
	}

	private void RefreshMissionReward()
	{
	}

	private void RefreshRewardItemSelectState(int index)
	{
	}

	private void RefreshSpecialAwardPurchaseBtnState()
	{
	}

	private void RefreshVeteransDiscountStore()
	{
	}

	private void SetGameObjectActive(VFXCreateHelper go, bool isActive)
	{
	}

	private void AddEventDelegate()
	{
	}

	private void SetDailyRewardCheckInBtnState(bool isTodayClaimed, bool isAllClaim)
	{
	}

	private void SetPreviewItem()
	{
	}

	private void SetLineState(int index)
	{
	}

	private void SetLineVfxState(ref GameObject showGameObject, Transform showTransform, ref GameObject hideGameObject)
	{
	}

	private void OnClose()
	{
	}

	private void CloseNavigation()
	{
	}

	public void NotifyProgressItemSelected(int levelID)
	{
	}

	private void OnTaskRewardClaimed(object[] data)
	{
	}

	private IEnumerator PlayMissionToProgressAnimation(int index, uint incrementActiveness)
	{
		return null;
	}

	private void PlayProgressShiningVFX(uint incrementActiveness)
	{
	}

	private IEnumerator PlayProgressUpAnimation(uint oldActiveness, uint curActiveness, float duration)
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override bool NeedRecoverPreviewOnNavigationShowed()
	{
		return false;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CRefreshMissionReward_003Eb__63_0()
	{
	}

	private void _003COnClose_003Eb__73_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedRecoverPreviewOnNavigationShowed()
	{
		return false;
	}
}
