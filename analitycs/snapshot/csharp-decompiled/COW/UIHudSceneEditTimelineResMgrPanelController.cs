using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditTimelineResMgrPanelController : UIBaseController
{
	public class Operation
	{
		public string selectedEntityID;

		public string[] TypeNameFilters;

		public ulong ignoreTrackTypeMask;

		public Action<SceneEditObjectBase> callBack;

		public bool unSelectAgent;
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

		public static Comparison<SceneEditObjectBase> _003C_003E9__46_0;

		internal int _003CCollectAllSceneEditObjects_003Eb__46_0(SceneEditObjectBase a, SceneEditObjectBase b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass44_0
	{
		public UIHudSceneEditTimelineResMgrPanelController _003C_003E4__this;

		public int direction;

		internal int _003CSortObjectList_003Eb__0(SceneEditObjectBase a, SceneEditObjectBase b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass44_1
	{
		public int direction;

		internal int _003CSortObjectList_003Eb__1(SceneEditObjectBase a, SceneEditObjectBase b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass44_2
	{
		public int direction;

		internal int _003CSortObjectList_003Eb__2(SceneEditObjectBase a, SceneEditObjectBase b)
		{
			return 0;
		}
	}

	private sealed class _003CScrollTo_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudSceneEditTimelineResNodeItemController nodeItem;

		public UIHudSceneEditTimelineResMgrPanelController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CScrollTo_003Ed__63(int _003C_003E1__state)
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

	private UIHudSceneEditTimelineResMgrPanelView m_View;

	private List<UIHudSceneEditTimelineResNodeItemController> m_NodeItemList;

	private UIUGCFliterSelectPanelController m_FliterPanelCtrl;

	private UIPopMenuSmallControler m_SceneObjSortFliterPopMenuSmallCtrl;

	private List<UGCFliterSelectTypeData> m_TypeFliterDataList;

	private List<PopMenuData> m_SceneObjSortFliterDataList;

	private List<SceneEditObjectBase> m_ObjList;

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

	private Coroutine m_ScrollToCoroutine;

	private SceneEditObjectBase m_currSelectedObj;

	private bool m_OpenFliterPanel;

	private HNDHJGJILHC m_SceneEditGame;

	private SceneEditAgent agent;

	private string[] m_typeNameFilter;

	private bool m_unAgentSelect;

	private ulong m_trackTypeMask;

	private Action<SceneEditObjectBase> m_selectedCallback;

	private SceneEditAgent mAgent => null;

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

	public void InitShowData(string selectedEntityID, ulong trackTypeMask, string[] typeName, bool unSelected, Action<SceneEditObjectBase> selectedCallback)
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetDepth(int depth)
	{
	}

	private void OnBtnCloseClick()
	{
	}

	private void OnTweenFinished()
	{
	}

	private void RefreshObjGridList()
	{
	}

	private bool CheckFilter(SceneEditObjectBase obj)
	{
		return false;
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

	private void RefreshFliterMenuState()
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

	private void OnClickHintButton()
	{
	}

	private void OnBtnConfirmClick()
	{
	}

	private void OnBtnClearClick()
	{
	}

	private void OnBtnSearchClick()
	{
	}

	private void RefreshClearSearchBtn()
	{
	}

	private void OnRefreshNodeSelectState(SceneEditObjectBase selected, bool lookAt, bool scrollto, bool refresh)
	{
	}

	private IEnumerator ScrollTo(UIHudSceneEditTimelineResNodeItemController nodeItem)
	{
		return null;
	}

	protected override void OnUIDestory()
	{
	}

	private void CreateNodeItem(SceneEditObjectBase item, UIHudSceneEditTimelineResNodeItemController parent, bool syncNode)
	{
	}

	private UIHudSceneEditTimelineResNodeItemController GetNodeItem()
	{
		return null;
	}

	private void OnClickItemCallback(UIHudSceneEditTimelineResNodeItemController item)
	{
	}

	private void OnExpandItemCallback()
	{
	}

	private void DeleteNode(UIHudSceneEditTimelineResNodeItemController node, bool includeChildren, bool syncNode)
	{
	}

	public Vector3 GetItemRelativePositon(Vector3 position)
	{
		return default(Vector3);
	}

	public void AddNodeToRoot(UIHudSceneEditTimelineResNodeItemController node)
	{
	}

	public void Reset()
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
