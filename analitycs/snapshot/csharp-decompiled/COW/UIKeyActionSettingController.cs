using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIKeyActionSettingController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public UIKeyActionItemController itemCtrl;

		public UIKeyActionSettingController _003C_003E4__this;

		internal void _003CInit_003Eb__0()
		{
		}
	}

	private sealed class _003CSetKey_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIKeyActionSettingController _003C_003E4__this;

		public string keyName;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetKey_003Ed__13(int _003C_003E1__state)
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

	private sealed class _003CWaitForKey_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIKeyActionSettingController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitForKey_003Ed__14(int _003C_003E1__state)
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

	private UIKeyActionSettingView m_View;

	private Dictionary<string, UIKeyActionItemController> m_ItemDic;

	private Dictionary<string, KeyActionSettingData> m_KeyCodeMap;

	private UIKeyActionItemController m_CurItem;

	private Event keyEvent;

	private KeyCode newKeyCode;

	private bool waittingForKey;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Init()
	{
	}

	private void OnItemClick(UIKeyActionItemController ctrl)
	{
	}

	private void OnGUI()
	{
	}

	private void AssignKey(string keyName)
	{
	}

	private IEnumerator SetKey(string keyName)
	{
		return null;
	}

	private IEnumerator WaitForKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
