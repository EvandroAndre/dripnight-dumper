using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIAchievementMainController : UINavigationController, IUIModelDataChangeObserver, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<uint> _003C_003E9__38_0;

		public static Comparison<uint> _003C_003E9__45_0;

		internal int _003CInitSeasonTab_003Eb__38_0(uint a, uint b)
		{
			return 0;
		}

		internal int _003CGenerateSeasonYearMenuData_003Eb__45_0(uint a, uint b)
		{
			return 0;
		}
	}

	private sealed class _003CPlayItemsAnim_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAchievementMainController _003C_003E4__this;

		private WaitForSeconds _003Cseconds_003E5__2;

		private UIEasyListItemController[] _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayItemsAnim_003Ed__69(int _003C_003E1__state)
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

	private UIAchievementMainView m_View;

	private UIAchievementDetailController m_DetailCtrl;

	private UIPopMenuSmallControler m_StatePopMenuCtrl;

	private UIPopMenuSmallControler m_SeasonYearStatePopMenuCtrl;

	private UIPopMenuSmallControler m_BigEventPopMenuCtrl;

	private UIModelAchievement m_Model;

	private bool m_IsShowDetail;

	private UIModelAchievement.EAchievementState m_CurState;

	private UIModelAchievement.EAchievementState m_CurEventState;

	private EAchievement.Type m_CurType;

	private UIModelAchievement.EAchievementSeasonYearState m_CurSeasonYearState;

	private uint m_CurSeasonYear;

	private uint m_CurAchievementId;

	private uint m_CurCategoryId;

	private uint m_CurBigEventSubTypeId;

	private readonly Dictionary<uint, string> m_AchievementStateKeyDict;

	public static readonly Dictionary<uint, string> AchievementTypeKeyDict;

	public const uint SHARE_NUM = 8u;

	private GameObject m_CupEffect;

	private Coroutine m_ItemsAnimCor;

	private List<uint> m_SortedIds;

	private bool m_IsInfoUpdated;

	private UIAchievementMainAchievementNumController m_AchievementNumCtrl;

	private UIAchievementMainBigEventShareWndController m_AchievementBigEventShareCtrl;

	private bool m_SeasonYearTabInit;

	private bool m_BigEventTabInit;

	private bool m_BigEventCheckBoxInit;

	private bool m_IsBigEventCompletedChecked;

	private uint m_CompletedNum;

	private Vector2 m_ShareOffset;

	public bool IsShowDetail => false;

	public EAchievement.Type CurType => EAchievement.Type.Type_NONE;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InitTab()
	{
	}

	private void InitSeasonTab()
	{
	}

	private void InitBigEventTab()
	{
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	private void GenerateStateMenuData()
	{
	}

	private void GenerateSeasonYearMenuData()
	{
	}

	private void GenerateBigEventMenuData()
	{
	}

	private void SelectAchievementTypeAndState(EAchievement.Type type, UIModelAchievement.EAchievementState state, UIModelAchievement.EAchievementSeasonYearState seasonYearState, uint seasonYear, uint bigEventSubTypeId, UIModelAchievement.EAchievementState eventState)
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public void RefreshMainUI()
	{
	}

	private void InitAchievementMainView()
	{
	}

	private void RefreshAchievementInfo()
	{
	}

	private void RefreshBigEventAchievementInfo()
	{
	}

	private void RefreshAchievementContainer(bool isCommon)
	{
	}

	private void RefreshAchievementEasyList()
	{
	}

	private void RefreshBigEventEasyList()
	{
	}

	private void RefreshAchievementView()
	{
	}

	private void RefreshSeasonYearView()
	{
	}

	private void RefreshBigEventView()
	{
	}

	private void RefreshBigEventCheckBox()
	{
	}

	private void RefreshCurType()
	{
	}

	private void RefreshAwardTips()
	{
	}

	private void SetScreenshotObjActive(bool isBefore)
	{
	}

	private void SetDetailObjActive()
	{
	}

	private List<AchievementEntryInfo> GetShareAchievementEntryInfos()
	{
		return null;
	}

	private void ShowSelectedAchievementDetail()
	{
	}

	private void ShowSelectedCategoryDetail()
	{
	}

	private void GetCanClaimRewardInfo()
	{
	}

	private IEnumerator PlayItemsAnim()
	{
		return null;
	}

	private void SkipItemsAnim()
	{
	}

	private void PreLoadShareCDN()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private UIModelAchievement.EAchievementState GetAchievementStateForBigEvent()
	{
		return UIModelAchievement.EAchievementState.All;
	}

	public void OnShareHelpBtnClick(Vector2 pos)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnTypeSelected(EAchievement.Type curType)
	{
	}

	private void OnStateSelect(object obj)
	{
	}

	private void OnSeasonYearSelect(object obj)
	{
	}

	private void OnBigEventSelect(object obj)
	{
	}

	private void OnBtnShareClick()
	{
	}

	private void OnBigEventShareReady()
	{
	}

	private void OnBtnAwardClick()
	{
	}

	private void OnAchievementMainItemClick(object[] data)
	{
	}

	private void OnGoToBtnClick()
	{
	}

	private void OnSeasonYearTabToggleSelect(UIToggleButton button)
	{
	}

	private void OnBigEventCompletedCheckBoxClick()
	{
	}

	private void RefreshPopMenuCtrlVisible()
	{
	}

	private void OnAllBtnClick()
	{
	}

	private void OnBattleBtnClick()
	{
	}

	private void OnCollectionBtnClick()
	{
	}

	private void OnCareerBtnClick()
	{
	}

	private void OnYearBtnClick()
	{
	}

	private void OnEventBtnClick()
	{
	}

	private void RefreshTopButtonView(EAchievement.Type type)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
