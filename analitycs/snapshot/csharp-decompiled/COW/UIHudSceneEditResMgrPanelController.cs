using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditResMgrPanelController : UIBaseController, IEasyList
{
	public enum EViewState
	{
		Normal,
		MultiSelect
	}

	private enum EScriptFliterType
	{
		All,
		Scripted
	}

	private enum ESortFliterType
	{
		None,
		Letter,
		Date,
		ItemType
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<SceneEditObjectBase> _003C_003E9__72_0;

		internal int _003CCollectAllSceneEditObjects_003Eb__72_0(SceneEditObjectBase a, SceneEditObjectBase b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass51_0
	{
		public int id;

		internal bool _003CSelectObject_003Eb__0(UIHudSceneEditResRowData r)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass70_0
	{
		public UIHudSceneEditResMgrPanelController _003C_003E4__this;

		public int direction;

		internal int _003CSortObjectList_003Eb__0(SceneEditObjectBase a, SceneEditObjectBase b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass70_1
	{
		public int direction;

		internal int _003CSortObjectList_003Eb__1(SceneEditObjectBase a, SceneEditObjectBase b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass70_2
	{
		public int direction;

		internal int _003CSortObjectList_003Eb__2(SceneEditObjectBase a, SceneEditObjectBase b)
		{
			return 0;
		}
	}

	private sealed class _003CDeferredRebuild_003Ed__98 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudSceneEditResMgrPanelController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDeferredRebuild_003Ed__98(int _003C_003E1__state)
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

	private UIHudSceneEditResMgrPanelView m_View;

	private EViewState m_CurrentViewState;

	private UIUGCFliterSelectPanelController m_FliterPanelCtrl;

	private UIHudSceneDropdownListWithIconController m_SceneObjSortCtrl;

	private List<UGCFliterSelectTypeData> m_TypeFliterDataList;

	private List<UIHudSceneDropDownItemWithIconData> m_SceneObjSortFliterDataList;

	private List<SceneEditObjectBase> m_ObjList;

	private List<UIHudSceneEditResRowData> m_RowList;

	private HashSet<int> m_CollapsedSet;

	private const float EASYLIST_ITEM_WIDTH = 464f;

	private const float EASYLIST_ITEM_HEIGHT = 54f;

	private float m_ListScrollViewInitX;

	private float m_ListClipOffsetInitX;

	private UIModelSceneEdit m_Model;

	private ulong m_OpenTime;

	private const string m_AllTypeKey = "T_32_XH_REPLAY_ALL";

	private const string m_ScriptEditedKey = "T_34_M_WS_CARRYSCRIPT";

	private const string DEFAULT_TYPE_KEY = "T_38_WZY_WS_SORTBY";

	private const string LETTER_TYPE_KEY = "T_38_WZY_WS_FLETTER";

	private const string CREATE_TIME_TYPE_KEY = "T_38_WZY_WS_CREATTIME";

	private const string CREATE_OBJECT_TYPE_KEY = "T_38_WZY_WS_OBJECTTYPE";

	private const string GROUP_INDEX_TYPE_KEY = "T_38_WZY_WS_GROUPSORT";

	private uint m_CurrentSelctedTypeFliter;

	private uint m_CurrentSelctedScriptedFliter;

	private int m_CurrentSelectdSortFliter;

	private string m_CurrentSearchText;

	private bool m_IsFolded;

	private EditorEntityData m_EntityData;

	private bool m_RebuildDirty;

	private bool m_IsRebuilding;

	private Coroutine m_RebuildCoroutine;

	private bool m_SelectAllToggle;

	private bool m_OpenFliterPanel;

	private HNDHJGJILHC m_Game;

	private SceneEditAgent m_Agent;

	public SceneEditAgent Agent => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIInit()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnSceneEditNameChange(object[] data)
	{
	}

	private void OnOpenPaintModePanel()
	{
	}

	private void OnItemPanelChanged(object[] data)
	{
	}

	private void OnHandleSceneEditChange(object[] data)
	{
	}

	private void OnSceneEditRevoke(object[] data)
	{
	}

	private void OnWorkShopSceneRefresh(object[] data)
	{
	}

	private void SelectObject(object[] data)
	{
	}

	private void ShowPanel(object[] data)
	{
	}

	private void HidePanel(object[] data)
	{
	}

	private void PanelToggleShow()
	{
	}

	private void PanelToggleHide()
	{
	}

	private void ShowPanel(bool notifyshowActionListPanel)
	{
	}

	private void OnBtnCloseClick()
	{
	}

	private void OnToggleBtnClick()
	{
	}

	private void OnToggleBtnReverseClick()
	{
	}

	private void OnTweenFinished()
	{
	}

	private void OnSortBtnClick()
	{
	}

	private void RefreshObjGridList()
	{
	}

	private void BuildRowList()
	{
	}

	private void AppendRow(SceneEditObjectBase obj, int depth)
	{
	}

	private void RefreshEasyList(bool resetScroll)
	{
	}

	private void RestoreListHorizontalPos()
	{
	}

	private int FindRowIndex(SceneEditObjectBase obj)
	{
		return 0;
	}

	private bool CheckFilter(SceneEditObjectBase obj)
	{
		return false;
	}

	private void RefreshSortSprite()
	{
	}

	private void SortObjectList(List<SceneEditObjectBase> objectList)
	{
	}

	private string GetEditObjectName(SceneEditObjectBase data)
	{
		return null;
	}

	private List<SceneEditObjectBase> CollectAllSceneEditObjects(HNDHJGJILHC game)
	{
		return null;
	}

	private void InitPopMenus()
	{
	}

	private void GenerateSortFliterMenuData()
	{
	}

	private void InitFliterPanel()
	{
	}

	private void OnFliterMaskClick()
	{
	}

	private void OnFliterConfirmClick()
	{
	}

	private void OnFliterToggleClick()
	{
	}

	private void OnMultiSelectToggleClick()
	{
	}

	private void SetMultiSelectToggle(bool selected)
	{
	}

	private UGCFliterSelectTypeData GenerateScriptFliterTypeData()
	{
		return null;
	}

	private UGCFliterSelectTypeData GenerateTypeFliterTypeData()
	{
		return null;
	}

	private void OnSortFliterSelected(object value)
	{
	}

	private void OnBtnClearClick()
	{
	}

	private void OnMultiSelectBtnClick()
	{
	}

	private void OnBtnSearchClick()
	{
	}

	private void RefreshClearSearchBtn()
	{
	}

	private void OnResMgrModeChanged(object[] data)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnClickItemCallback(UIHudSceneEditResNodeItemController item)
	{
	}

	private void OnExpandItemCallback(UIHudSceneEditResNodeItemController item)
	{
	}

	private void OnItemVisibleChanged()
	{
	}

	private void SetViewState(EViewState state)
	{
	}

	private void RefreshViewState()
	{
	}

	private void RefreshMultiSelectBtnTxt()
	{
	}

	private void RefreshPanel(bool needRebuild)
	{
	}

	private void MarkRebuildDirty()
	{
	}

	private IEnumerator DeferredRebuild()
	{
		return null;
	}

	private void StopRebuildCoroutine()
	{
	}

	private void RebuildPanelImmediate()
	{
	}

	private void RefreshSelectionState()
	{
	}

	private void OnSelectionChanged()
	{
	}

	private void OnSelectionModeChanged()
	{
	}

	private void OnHierarchyChanged(bool needRebuild)
	{
	}

	private void OnGroupChanged()
	{
	}

	private void OnAddObject()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
