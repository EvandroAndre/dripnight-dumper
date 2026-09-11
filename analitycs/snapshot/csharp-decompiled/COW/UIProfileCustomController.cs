using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomController : UINavigationController, IUIModelDataChangeObserver
{
	private enum UIFXLength
	{
		One = 1,
		Two = 2,
		Three = 3,
		Four = 4,
		Six = 6
	}

	private sealed class _003CDelayOpenChild_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIProfileCustomController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayOpenChild_003Ed__50(int _003C_003E1__state)
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

	public const string NAVI_NAME = "T_46_ZZ_PROFILE_PAGENAME";

	public const string LEADERBOARDTITLE_TIP_TITLE = "T_46_ZZ_PROFILE_RANKTITLENAME";

	public const string LEADERBOARDTITLE_TIP_DESC = "T_46_ZZ_PROFILE_RANKTITLEDESC";

	public const string TIP_ONLY_ONE = "T_46_ZZ_PROFILE_MODULEONE";

	public const string TIP_ONLY_FIVE_ACHIEVEMENT = "T_46_ZZ_PROFILE_MODULEFIVE";

	public const string TIP_ONLY_FIVE_PRIVILEGEICON = "T_49_ZZ_PROFILE_KOLICONFIVE";

	public const string DELETE_CONFIRM_TITLE = "T_46_ZZ_PROFILE_RESETNAME";

	public const string DELETE_CONFIRM_DESC = "T_46_ZZ_PROFILE_RESETDESC";

	public const string SAVE_CONFIRM_TITLE = "T_46_ZZ_PROFILE_SAVENAME";

	public const string SAVE_CONFIRM_DESC = "T_46_ZZ_PROFILE_SAVEDESC";

	public const string SAVE_CONFIRM_YES = "T_46_ZZ_PROFILE_SAVECONFIRM";

	public const string SAVE_CONFIRM_NO = "T_46_ZZ_PROFILE_SAVEUNCONFIRM";

	private UIProfileCustomView m_View;

	private UIModelProfileCustom m_ModelCustom;

	private UIModelAchievement m_ModelAchievement;

	private ulong m_SelfAccountID;

	private UIProfilePersonProfileInfoController m_PersonInfoCtrl;

	private UIProfileCustomCollectionController m_LeftCollectionCtrl;

	private UIProfileCustomCellGridController m_LeftGridCtrl;

	private UIProfileCustomCellGridController m_RightGridCtrl;

	private List<ProfileCustomModuleData> m_LeftGridDataList;

	private List<ProfileCustomModuleData> m_RightGridDataList;

	private bool m_NeedCalculBoundsCache;

	private bool m_DuringDrag;

	private ProfileCustomDragTemplate m_ClonedDragTemplate;

	protected ProfileCustomModuleData m_ClickData;

	private UIModelProfileCustom.EDataSource m_LastVibrateDataSource;

	private int m_LastVibrateCellID;

	private bool m_DelayOpenChild_Success;

	private bool m_LeftReady;

	private bool m_RightReady;

	private bool m_Modified;

	private bool m_Modified_ForRevoke;

	private List<ProfileCustomModuleData> m_LeftRevoke;

	private List<ProfileCustomModuleData> m_RightRevoke;

	private bool m_LogClick;

	private bool m_LogDrag;

	private List<GameObject> m_CacheUIFX_One;

	private List<GameObject> m_CacheUIFX_Two;

	private List<GameObject> m_CacheUIFX_Three;

	private List<GameObject> m_CacheUIFX_Four;

	private List<GameObject> m_CacheUIFX_Six;

	private bool m_CanRevoke => false;

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void Update()
	{
	}

	private IEnumerator DelayOpenChild()
	{
		return null;
	}

	private void TryRefreshCellCtrlByModelData()
	{
	}

	private void CalculCachedBounds()
	{
	}

	private void TryVibrate(UIModelProfileCustom.EDataSource source = UIModelProfileCustom.EDataSource.None, int cellID = -1, bool forceVib = false)
	{
	}

	private void OnDragStart(object[] data)
	{
	}

	private void OnDragEnd()
	{
	}

	public bool HasCurrentClick()
	{
		return false;
	}

	public bool SameWithCurrentClickData(ProfileCustomModuleData data)
	{
		return false;
	}

	private void OnItemClick(object[] args)
	{
	}

	private void OnCellClick(int dataSource, int index)
	{
	}

	private void ProcessClick(ProfileCustomModuleData oldData, UIModelProfileCustom.EDataSource targetGridType, int clickIndex)
	{
	}

	private void Atom_DeleteByDrag(int moduleID, UIModelProfileCustom.EDataSource dataSource)
	{
	}

	private void Atom_DeleteByClick(object[] args)
	{
	}

	private void Atom_RemoveThenAdd(ProfileCustomModuleData sourceData, List<ProfileCustomModuleData> targetList, UIProfileCustomCellGridController targetGridCtrl)
	{
	}

	private void Atom_DeleteAllModule()
	{
	}

	private void Atom_AutoFill()
	{
	}

	private void ShowAutoFillTips()
	{
	}

	private bool NeedCheckCount(ProfileCustomModuleData sourceData, out int limit)
	{
		limit = default(int);
		return false;
	}

	private void RemoveByModuleIDs(IEnumerable<int> moduleIDs, UIModelProfileCustom.EDataSource source, bool refreshCellUI = false)
	{
	}

	public void ShowDeleteAllConfirmWnd()
	{
	}

	private List<ProfileCustomModuleData> ShallowCopy(List<ProfileCustomModuleData> source)
	{
		return null;
	}

	private void RecordForRevoke()
	{
	}

	private void DoRevoke()
	{
	}

	private void RefreshRevokeBtn()
	{
	}

	public void OnClickNewTab()
	{
	}

	private void OnSaveBtn()
	{
	}

	private void ConfirmExit()
	{
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	private void PopThisNavi(bool save)
	{
	}

	public ProfileCustomDragTemplate GetDragTemplate()
	{
		return null;
	}

	private void RefreshTips(ProfileCustomModuleData data)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void ShowItemUIFX(ProfileCustomModuleData newItemData, Transform transform)
	{
	}

	private void PlayUIFXByPosition(Transform root, UIFXLength style, Vector3[] posArray, bool[] vertical)
	{
	}

	private GameObject CreateUIFXObj(Transform root, UIFXLength style, Vector3 locPos, bool vertical)
	{
		return null;
	}

	private void ClearUIFX()
	{
	}

	private void ClearUIFXList(List<GameObject> list)
	{
	}

	private void SendEventLog()
	{
	}

	private void _003CConfirmExit_003Eb__76_0()
	{
	}

	private void _003CConfirmExit_003Eb__76_1()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}
}
