using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UIHudSceneEditCustomAttributeEditController : UIPopupWindowController, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static EventDelegate.Callback _003C_003E9__29_0;

		public static Action<UIHudSceneEditCustomAttributeMainTab> _003C_003E9__64_0;

		public static Action<UIHudSceneEditCustomAttributeMainTab> _003C_003E9__68_0;

		internal void _003CInitializeEventHandlers_003Eb__29_0()
		{
		}

		internal void _003CUpdateSearchList_003Eb__64_0(UIHudSceneEditCustomAttributeMainTab tab)
		{
		}

		internal void _003CRevertPrevSelect_003Eb__68_0(UIHudSceneEditCustomAttributeMainTab tab)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public string name;

		internal bool _003CIsAttributeNameExists_003Eb__0(IBILCDHHNHM item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass61_0
	{
		public UIHudSceneEditCustomAttributeEditController _003C_003E4__this;

		public int i;
	}

	private sealed class _003C_003Ec__DisplayClass61_1
	{
		public string name;

		public _003C_003Ec__DisplayClass61_0 CS_0024_003C_003E8__locals1;

		internal bool _003CCheckVaild_003Eb__0(IBILCDHHNHM data)
		{
			return false;
		}
	}

	private sealed class _003CScrollToTabCoroutine_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudSceneEditCustomAttributeEditController _003C_003E4__this;

		public MonoBehaviour tab;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CScrollToTabCoroutine_003Ed__80(int _003C_003E1__state)
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

	private sealed class _003CWaitOneFrameUpdateAnchors_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudSceneEditCustomAttributeEditController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitOneFrameUpdateAnchors_003Ed__74(int _003C_003E1__state)
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

	private static readonly long[] RULE_TAB_TYPES;

	private Dictionary<long, string> m_EntityEditorKey;

	private static readonly int CUSTOM_TYPE_TAB_ID;

	private UIHudSceneEditCustomAttributeEditView m_View;

	private readonly Dictionary<int, UIHudSceneEditCustomAttributeMainTab> m_MainTabDictionary;

	private readonly Dictionary<long, UIHudSceneEditCustomAttributeSubTab> m_SubTabDictionary;

	private readonly List<UIHudSceneEditCustomAttributeMainTab> m_MainTabList;

	private readonly List<UIHudSceneEditCustomAttributeMainTab> m_SearchTabList;

	private UIHudSceneEditCustomAttributeMainTab m_SearchMainTab;

	private readonly Dictionary<long, UIHudSceneEditCustomAttributeSubTab> m_SearchSubTabDictionary;

	private UIHudSceneEditCustomAttributeSubTab m_CurrentSelection;

	private AOKBGKNKKLJ m_CurrentEntityAttributeData;

	private bool m_Redefined;

	private bool m_IsSearchTab;

	private string m_LastInput;

	private long m_RevertSelectTab;

	private const int SHOWTYPE_HEIGHT = 65;

	private bool m_NeedRefreshShowType;

	private UIHudSceneEditCustomAttributeMainTab m_CurrentShowTypeItem;

	private List<long> m_SearchResult;

	private bool m_ItemChildrenInit;

	private int m_MaxAttributeCount => 0;

	private List<long> SearchResult => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override void OnUIClose()
	{
	}

	private void InitializeView()
	{
	}

	private void InitializeEventHandlers()
	{
	}

	private void SetRefreshShowTypeFlag(bool flag)
	{
	}

	private void Update()
	{
	}

	private void OnShowTypeBtnClick()
	{
	}

	public void RefreshShowType()
	{
	}

	private void RefreshShowType(UIHudSceneEditCustomAttributeMainTab typeController)
	{
	}

	private void InitializeTabs()
	{
	}

	private void InitializeMainTabs()
	{
	}

	private UIHudSceneEditCustomAttributeMainTab CreateMainTab()
	{
		return null;
	}

	private void InitializeSubTabs()
	{
	}

	private void CreateAndConfigureSubTab(long key, Transform parent, UIHudSceneEditCustomAttributeMainTab mainTab, string labelName)
	{
	}

	private UIHudSceneEditCustomAttributeSubTab CreateSubTab(Transform parent)
	{
		return null;
	}

	private void RefreshTabLayout()
	{
	}

	private UIHudSceneEditCustomAttributeMainTab GetMainTab(int tabType)
	{
		return null;
	}

	private void DeleteAttribute(object[] param)
	{
	}

	private void OnInputGetFocus()
	{
	}

	private void OnInputLostFocus()
	{
	}

	public void OnItemSelect(UIHudSceneEditCustomAttributeSubTab item)
	{
	}

	private void PerformTabSwitch(UIHudSceneEditCustomAttributeSubTab item)
	{
	}

	private void SetEntityAttributeDate()
	{
	}

	private void RefreshAttributeListView()
	{
	}

	private void UpdateEditBtnState()
	{
	}

	private void UpdatePlayerOnlyControlsVisibility()
	{
	}

	public void OnMainTabSelect(UIHudSceneEditCustomAttributeMainTab tab)
	{
	}

	private void OnBtnClose()
	{
	}

	private void OnBtnBlockEdit()
	{
	}

	private void OnAddBtnClick()
	{
	}

	private void OnHelpBtnClick()
	{
	}

	private void OnDatabaseBtnClick()
	{
	}

	private string GenerateUniqueAttributeName()
	{
		return null;
	}

	private bool IsAttributeNameExists(string name)
	{
		return false;
	}

	private void AutoSave()
	{
	}

	private bool CheckVaild(out string reason)
	{
		reason = null;
		return false;
	}

	private void OnSearchBtnClick(bool fromInput)
	{
	}

	private void SearchItem(string inputName)
	{
	}

	private void UpdateSearchList()
	{
	}

	private void CreateOrReuseSearchSubTab(long resultId)
	{
	}

	private void CleanupSearchTabs()
	{
	}

	private void SaveCurrentSelect()
	{
	}

	private void RevertPrevSelect()
	{
	}

	private void ClearCurrentSelection()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	private void ConfigureItemController(UIModeSettingAttributeItemController item)
	{
	}

	private void OnEnable()
	{
	}

	private IEnumerator WaitOneFrameUpdateAnchors()
	{
		return null;
	}

	private void OnRedefineItem(int index)
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void SetCurrentEntityAttributeData(AOKBGKNKKLJ data)
	{
	}

	public void SetViewData(string entityType)
	{
	}

	private void ScrollToTab(MonoBehaviour subTab)
	{
	}

	private IEnumerator ScrollToTabCoroutine(MonoBehaviour tab)
	{
		return null;
	}

	private UIScrollView GetTabContainerScrollView()
	{
		return null;
	}

	private void _003CInitializeEventHandlers_003Eb__29_1()
	{
	}

	private void _003CInitializeEventHandlers_003Eb__29_2()
	{
	}

	private void _003CInitializeEventHandlers_003Eb__29_3()
	{
	}

	private void _003CInitializeEventHandlers_003Eb__29_4()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
