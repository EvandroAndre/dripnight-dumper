using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay.UGC;
using GCommon;
using ReactUI;
using UnityEngine;
using proto;

namespace COW;

public class UIUGCDebuggerConsole : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
{
	private enum ELogSource
	{
		All,
		System,
		Log
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__33_1;

		public static Converter<CustomString, WorkshopWordFilter> _003C_003E9__35_1;

		internal void _003COnClearLog_003Eb__33_1()
		{
		}

		internal WorkshopWordFilter _003COnCheckClick_003Eb__35_1(CustomString input)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public UIUGCDebuggerConsole _003C_003E4__this;

		public HNDHJGJILHC editGame;

		internal void _003COnCheckClick_003Eb__0(bool result)
		{
		}
	}

	private sealed class _003CCor_ShowNotifyDown_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCDebuggerConsole _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCor_ShowNotifyDown_003Ed__41(int _003C_003E1__state)
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

	private UIUGCDebuggerConsoleView m_View;

	private UIModelUGCDebugger m_Debugger;

	private List<UIModelUGCDebugger.LogData> m_showingLogData;

	private List<WorkshopWordFilter> m_DirtyWordList;

	private bool m_isScrollToEnd;

	private UIModelSceneEdit m_ModelSceneEdit;

	private float m_CheckCountDownTime;

	private uint m_LogErrorCount;

	private uint m_LogWarningCount;

	private uint m_LogInfoCount;

	private bool m_exportingData;

	private List<string> m_LogSourceOptions;

	private int m_contentItemCount;

	private Coroutine m_delay_Cor;

	private int ShowingMaxIndex;

	private List<UIEasyListItemController> m_allItems;

	private UIVariable var_HalfContentHeight;

	private UIVariable var_HalfLogItemUIHeight;

	private bool IsToggleInfo
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool IsToggleWarnning
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool IsToggleError
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private ELogSource CurrentLogSource
	{
		get
		{
			return ELogSource.All;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnInitDepth()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void SaveToggleUserInfo()
	{
	}

	private void LoadToggleUserInfo()
	{
	}

	private void OnTestAddLog()
	{
	}

	private void OnClearLog()
	{
	}

	public void Update()
	{
	}

	private void OnCheckClick()
	{
	}

	private void OnLogAdded(object[] data)
	{
	}

	private void OnLogShowChanged(object[] data)
	{
	}

	private void OnErrorRefresh(object[] data)
	{
	}

	private void Delay_ShowNotifyDown()
	{
	}

	private IEnumerator Cor_ShowNotifyDown()
	{
		return null;
	}

	private void RefreshShowingMaxIndex()
	{
	}

	private void OnToggleInfo()
	{
	}

	private void OnToggleWarnning()
	{
	}

	private void OnToggleError()
	{
	}

	private void OnDropdownValueChanged(int value)
	{
	}

	private void RefreshAllLog()
	{
	}

	private bool TryChangeToggleState(UIModelUGCDebugger.LogDataType logType)
	{
		return false;
	}

	private bool CheckLogSource(UIModelUGCDebugger.LogData d)
	{
		return false;
	}

	private bool CheckLogType(UIModelUGCDebugger.LogData d)
	{
		return false;
	}

	private void CountLogType(UIModelUGCDebugger.LogData d)
	{
	}

	private void AddShowingLog(UIModelUGCDebugger.LogData d)
	{
	}

	private void OnSelectItem(int index)
	{
	}

	public void ShowDetailLog(UIUGCDebuggerConsoleItemController item, UIModelUGCDebugger.LogData logData)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnLongPressItem(int index, Vector3 position)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void event_OnCloseDetail(object[] args)
	{
	}

	private void _003COnClearLog_003Eb__33_0()
	{
	}

	private void _003CRefreshAllLog_003Eb__48_0(string index)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInitDepth()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
