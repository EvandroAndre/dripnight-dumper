using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIAvatarInfoLeftController : UIBaseController, IEasyList, IUIModelDataChangeObserver
{
	private enum SkillProperty
	{
		All,
		Active,
		Inactive
	}

	private enum SortOrder
	{
		BigAvatarId,
		BigSortId,
		GuideAvatar,
		NotOwned,
		TimeLimitOwned,
		Owned,
		StarMarked,
		NewAvatar,
		Equiped
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<AvatarSuit> _003C_003E9__60_0;

		internal bool _003CRefreshOnlyAvatar_003Eb__60_0(AvatarSuit x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass61_0
	{
		public UIAvatarInfoLeftController _003C_003E4__this;

		public List<ResourceID> res_list;

		public CSSharedItemData item_data;

		internal void _003CRefreshDownLoadInfo_003Eb__0()
		{
		}
	}

	private sealed class _003CAutoScrollCo_003Ed__109 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAvatarInfoLeftController _003C_003E4__this;

		public int value;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAutoScrollCo_003Ed__109(int _003C_003E1__state)
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

	private bool m_HasExtend;

	private bool m_IsExtend;

	private bool _003CIsFolderBtnClick_003Ek__BackingField;

	private int[] m_LastChosenFilterExtend;

	private int[] m_LastChosenFilterShrink;

	private bool m_RefreshListByIconGridUpdate;

	private UIAvatarInfoLeftView m_View;

	private UINewDownloadInfoController m_DownloadCtrl;

	private List<PopMenuData> m_PopMenuList;

	private UIPopMenuSmallControler m_SkillTagPopCtrl;

	private List<string> m_SkillTagStr;

	private UIPopMenuSmallControler m_SkillPropertyPopCtrl;

	private List<string> m_SkillPropertyStr;

	private List<uint> m_SkillTypeEnum;

	private int m_SkillTagChoose;

	private int m_SkillPropertyChoose;

	private Vector3 ExtendPos;

	private Vector3 ShrinkPos;

	private Vector3 NewCharacterGuidePos;

	private const int LeftExtendInfoWidth = 540;

	private const int LeftShrinkInfoWidth = 330;

	private const int RightInfoWidth = 380;

	private const int DownloadPosGapWithLeft = 80;

	private const int DownloadOriginalPos = 270;

	private const int FilterWidth = 260;

	private const int SearchEntrenceBtnWidth = 50;

	private int m_ScreenWidth;

	private List<AvatarProfile> m_AvatarList;

	private List<AvatarProfile> m_FilteredAvatarList;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private UIModelLoadout m_ModelLoadout;

	private UIModelGroup m_ModelGroup;

	private UIInput m_CurrentInput;

	private bool m_IsSearching;

	private bool m_OpenSearchInput;

	private bool m_ChangeSearchState;

	private string m_SearchContent;

	private int PropertyPopMenuWidth;

	private int TagPopMenuWidth;

	private uint m_NewCharacterGuideAvatarID;

	private UIAvatarNewCharacterGuideController m_NewCharacterGuideCtrl;

	private bool m_HasPendingAvatarRefresh;

	private uint m_PendingRefreshAvatarId;

	private Coroutine m_AutoScrollCo;

	private const float DragScrollDelta = 20f;

	public uint CurrentShowAvatar => 0u;

	public uint EquipedAvatar => 0u;

	public bool IsExtend => false;

	public bool IsFolderBtnClick
	{
		get
		{
			return _003CIsFolderBtnClick_003Ek__BackingField;
		}
		private set
		{
			_003CIsFolderBtnClick_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void CaculateDownloadCtrlPos(bool extend)
	{
	}

	private void SetRefreshFlag(object[] values)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	private void InitView()
	{
	}

	private void RefreshOnlyAvatar(uint avatarId)
	{
	}

	public void RefreshDownLoadInfo()
	{
	}

	public void RefreshExtendLayout()
	{
	}

	public void RefreshAvatarList(bool forceRefresh = false, bool skipSort = false)
	{
	}

	private void RefreshNewCharacterGuide()
	{
	}

	public void SelectCurrentShowAvatar()
	{
	}

	private void RefreshListView(bool forceRefresh = false)
	{
	}

	private int GetExtendIndex()
	{
		return 0;
	}

	private int GetShrinkIndex()
	{
		return 0;
	}

	private void RefreshSetShareLock()
	{
	}

	private void OnRelseaseLockClick()
	{
	}

	private bool IsFilterChangedInDifferentExtendState()
	{
		return false;
	}

	private void RefreshVisableItemGrid()
	{
	}

	private void OnFolderBtnClick()
	{
	}

	private void RefreshFilter()
	{
	}

	private void OnKeyartBtnClick()
	{
	}

	private void OnSearchEntrenceBtnClick()
	{
	}

	private void OnClearBtnClick()
	{
	}

	private void OnSearchBtnClick()
	{
	}

	private void OnSearchQuitBtnClick()
	{
	}

	private void OnInputChanged()
	{
	}

	private void RefreshFilteredAvatarList()
	{
	}

	private void RefreshSearchNoResultContainer()
	{
	}

	private void ModifySkillPropertyAvatarList()
	{
	}

	private void ModifySkillTagAvatarList()
	{
	}

	private bool IsFilterChosen()
	{
		return false;
	}

	private void InitFilterPopMenu()
	{
	}

	private void InitFilterPopMenu2()
	{
	}

	private void ResetPopMenu()
	{
	}

	private void GenerateSkillPropertyPopMenuData()
	{
	}

	private void OnSkillPropertySelected(object obj)
	{
	}

	private void GenerateSkillTagPopMenuData()
	{
	}

	private void OnSkillTagSelected(object index)
	{
	}

	private int GetSortScore(AvatarProfile avatarProfile, AvatarProfile avatarCompare)
	{
		return 0;
	}

	private int SortAvatarList(AvatarProfile source, AvatarProfile target)
	{
		return 0;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private bool IsGachaFeaturePopupActive()
	{
		return false;
	}

	private void TryRefreshAvatarOrDeferByGachaFeature(uint avatarId)
	{
	}

	private void OnGachaFeatureShowChanged(bool show)
	{
	}

	private void onUpdateNewCharacterGuide()
	{
	}

	private bool CheckIsAvatarShowing(uint avatarID)
	{
		return false;
	}

	private int GetAvatarIndexInAvatarList(uint avatarID)
	{
		return 0;
	}

	public void ScrollToIndexByAvatarID(uint avatarID)
	{
	}

	private void OnPresetAgentPinStateChanged(object[] data)
	{
	}

	private IEnumerator AutoScrollCo(int value)
	{
		return null;
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
