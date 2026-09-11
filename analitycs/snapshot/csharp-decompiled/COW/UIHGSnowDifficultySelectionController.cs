using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHGSnowDifficultySelectionController : UINavigationController, IUIModelDataChangeObserver, IEasyList
{
	public enum EDifficultyDataType
	{
		MaxCount = 1,
		TotalTime,
		FastestTime,
		MaxDamage
	}

	private sealed class _003CPlayBigItemsAnim_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHGSnowDifficultySelectionController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayBigItemsAnim_003Ed__35(int _003C_003E1__state)
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

	private sealed class _003CPlayClickItemsAnim_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHGSnowDifficultySelectionController _003C_003E4__this;

		private WaitForSeconds _003CitemSeconds_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayClickItemsAnim_003Ed__37(int _003C_003E1__state)
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

	private sealed class _003CPlayItemsAnim_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHGSnowDifficultySelectionController _003C_003E4__this;

		private WaitForSeconds _003CitemSeconds_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayItemsAnim_003Ed__36(int _003C_003E1__state)
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

	private sealed class _003CPlayRankBubbleAnim_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHGSnowDifficultySelectionController _003C_003E4__this;

		public List<UIModelHuntingGround.HgSnowLeaderboardBubble> bubbleAccounts;

		private WaitForSeconds _003Csecond_003E5__2;

		private List<UIModelHuntingGround.HgSnowLeaderboardBubble>.Enumerator _003C_003E7__wrap2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayRankBubbleAnim_003Ed__41(int _003C_003E1__state)
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

	private const string GUIDE_STEP1_KEY = "HgSnow_GuideStep1";

	private const string GUIDE_STEP2_KEY = "HgSnow_GuideStep2";

	private const string GUIDE_STEP3_KEY = "HgSnow_GuideStep3";

	private const string GUIDE_STEP5_KEY = "HgSnow_GuideStep5";

	private const string GUIDE_STEP6_KEY = "HgSnow_GuideStep6";

	private int m_CurGuideStep;

	private UICommonGuideController m_CommonGuideCtrl;

	private UIModelHuntingGround m_Model;

	private UIModelLeaderBoard m_ModelLeaderBoard;

	private UIHGSnowDifficultySelectionView m_View;

	private bool m_HasInitMainUI;

	private bool m_HasInitCurSeasonRankUI;

	private List<Transform> m_DifficultyItemList;

	private List<UIHGSnowDifficultySelectionItemController> m_SmallItemList;

	private List<UIHGSnowDifficultySelectionBigItemController> m_BigItemList;

	private int m_SmallItemCount;

	private UIHGSnowDifficultyRecordDetailController m_RecordDetailCtrl;

	private UIHGSnowRankResultController m_RankResultCtrl;

	private uint m_CurChapterId;

	private string m_ClickAnimName;

	private Coroutine m_ClickItemAnimCor;

	private MapModeData m_MapModeData;

	private UIModelMapOpeningInfo m_ModelMap;

	private UIModelOptionalDownload m_ModelDownload;

	private UINewDownloadInfoController m_Downloader;

	private bool m_IsCurChapterDownloadFinish;

	private bool m_IsInfiniteDownloadFinish;

	public bool IsChoosingDifficulty;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	private void InitMainUIData()
	{
	}

	private void RefreshRedTips()
	{
	}

	private IEnumerator PlayBigItemsAnim()
	{
		return null;
	}

	private IEnumerator PlayItemsAnim()
	{
		return null;
	}

	private IEnumerator PlayClickItemsAnim()
	{
		return null;
	}

	private void RefreshShopTokenNum()
	{
	}

	private void InitLastSeasonPVERankResult()
	{
	}

	private void InitCurSeasonPVERankBubble()
	{
	}

	private IEnumerator PlayRankBubbleAnim(List<UIModelHuntingGround.HgSnowLeaderboardBubble> bubbleAccounts)
	{
		return null;
	}

	public static void ShowDiffirentKeyByType(UILabel titleLabel, UILabel valLbael, string type, UIModelHuntingGround.HuntingGroundMissionData data)
	{
	}

	public void PlayItemUnlockAnim(uint difficulty, bool isUnlock)
	{
	}

	private void InitTimeLimitMissionEntrance()
	{
	}

	private void InitInfiniteMissionEntrance()
	{
	}

	private void OnSelectChapter(object[] data)
	{
	}

	private void RefreshInfiniteMissionRes()
	{
	}

	private void RefreshNormalMissionItem(bool isAutoSelected, bool isResUpdate = false)
	{
	}

	private void OnShowRecordDetail(object[] data)
	{
	}

	private void OnBtnTalentClick()
	{
	}

	private void OnBtnRankClick()
	{
	}

	private void OnBtnShopClick()
	{
	}

	private void OnBtnTokenClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void PlayGuide()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void UpdateDownloadList()
	{
	}

	protected void TryDownloadMapRes()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}
}
