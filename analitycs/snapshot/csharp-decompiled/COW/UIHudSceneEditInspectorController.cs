using System;
using System.Collections.Generic;
using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using ECAPackage;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditInspectorController : UIBaseController
{
	private class ComponentSortInfo
	{
		private long _003CID_003Ek__BackingField;

		private int _003CGroupOrder_003Ek__BackingField;

		public long ID
		{
			get
			{
				return _003CID_003Ek__BackingField;
			}
			set
			{
				_003CID_003Ek__BackingField = value;
			}
		}

		public int GroupOrder
		{
			get
			{
				return _003CGroupOrder_003Ek__BackingField;
			}
			set
			{
				_003CGroupOrder_003Ek__BackingField = value;
			}
		}

		public ComponentSortInfo(long id, int groupOrder)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ComponentSortInfo> _003C_003E9__43_0;

		public static Func<ComponentSortInfo, long> _003C_003E9__43_1;

		public static Func<long, ECAVarTypeDefine> _003C_003E9__45_0;

		public static Func<ECAVarTypeDefine, bool> _003C_003E9__45_1;

		public static Func<ECAVarTypeDefine, string> _003C_003E9__45_2;

		internal int _003CSortComponentIDsByGroupOrder_003Eb__43_0(ComponentSortInfo a, ComponentSortInfo b)
		{
			return 0;
		}

		internal long _003CSortComponentIDsByGroupOrder_003Eb__43_1(ComponentSortInfo item)
		{
			return 0L;
		}

		internal ECAVarTypeDefine _003CCheckAndSetComponentConflicts_003Eb__45_0(long id)
		{
			return null;
		}

		internal bool _003CCheckAndSetComponentConflicts_003Eb__45_1(ECAVarTypeDefine typeDefine)
		{
			return false;
		}

		internal string _003CCheckAndSetComponentConflicts_003Eb__45_2(ECAVarTypeDefine typeDefine)
		{
			return null;
		}
	}

	private UIHudSceneEditInspectorView m_View;

	public SceneEditObjectBase TargetObj;

	private bool m_IsGraphEnabled;

	private Dictionary<long, UIHudSceneEditInspectorCompController> m_InspectorCompCtrls;

	private Dictionary<long, UIHudSceneEditInspectorAddableCompItemController> m_AddableCompItemCtrls;

	private Action m_CloseBtnCallback;

	private bool m_IsBasic;

	private bool m_BasicResetPositionNeeded;

	private bool m_AdvancedResetPositionNeeded;

	private SceneEditAgent m_Agent;

	protected SceneEditAgent Agent => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	private void OnInspectorReposition(object[] data)
	{
	}

	private void OnBasicReposition()
	{
	}

	private void OnAdvancedReposition()
	{
	}

	private void OnAddableCompRefresh(object[] data)
	{
	}

	private void BuildAddableCompUI()
	{
	}

	private void OnAdjustTypeChange()
	{
	}

	private void OnSelectedObjChanged()
	{
	}

	public void RefreshItemInfo()
	{
	}

	public long[] GetComponentIDs()
	{
		return null;
	}

	private void BuildComponentUI(long id, bool isRemovable = false)
	{
	}

	private UIHudSceneEditInspectorCompController BuildDefaultComponentUI(long id, bool isRemovable, InspectorCraftlandConfig_Default data, Transform root, UGCTypeMap typeMap)
	{
		return null;
	}

	private void SetComponentExpandState(UIHudSceneEditInspectorCompController ctrl, bool expand)
	{
	}

	public void OnOpenGraphButtonClick()
	{
	}

	public void SetCloseBtnCallback(Action closeBtnCallback)
	{
	}

	private void OnCloseButtonClick()
	{
	}

	public UIWidget GetTutorialCloseButtonWidget()
	{
		return null;
	}

	private void OnToggleSetUp(UIToggleButton selectBtn)
	{
	}

	private void PlayToggleAudio()
	{
	}

	private void OnEditNameClick()
	{
	}

	private void OnAddableCompItemClick()
	{
	}

	private void OnAddableCompItemClose()
	{
	}

	private void OnAddableComponentsDetailsClick()
	{
	}

	private void OnNameReset()
	{
	}

	private void OnNameSubmit()
	{
	}

	public void RefreshSingleUIByConfig(ItemEditAttributeUIData_V2 uiData)
	{
	}

	public void ReplaceUIByConfig(string entityType, int startIndex, List<ItemEditAttributeUIData_V2> uidataList, List<EJAOBJCGLKD.JNHDMBBECJP> secondLevelUIDataList)
	{
	}

	private List<long> SortComponentIDsByGroupOrder(IEnumerable<long> componentIDs)
	{
		return null;
	}

	private void ReorderUIControllersByGroupOrder(IEnumerable<long> componentIDs, bool isBasicTab = true)
	{
	}

	private void CheckAndSetComponentConflicts()
	{
	}

	private void RefreshEmptyTips()
	{
	}

	private void SetComponentConflictTip(UIHudSceneEditInspectorCompController ctrl, bool hasConflict, string conflictInfo)
	{
	}

	private HashSet<long> GetAllCurrentComponentIDs()
	{
		return null;
	}

	private bool _003COnAddableCompRefresh_003Eb__19_0(long id)
	{
		return false;
	}

	private bool _003COnAddableCompRefresh_003Eb__19_1(long id)
	{
		return false;
	}

	private bool _003CRefreshEmptyTips_003Eb__46_0(KeyValuePair<long, UIHudSceneEditInspectorCompController> kvp)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
