using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UINewKeyActionSettingController : UISettingContentBase
{
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public UINewKeyActionItemController itemCtr;

		public UINewKeyActionSettingController _003C_003E4__this;

		internal void _003CGenerateKeyActionItem_003Eb__0()
		{
		}
	}

	private sealed class _003CRefreshScroll_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UINewKeyActionSettingController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshScroll_003Ed__14(int _003C_003E1__state)
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

	private UINewKeyActionSettingView m_View;

	private Dictionary<int, UINewKeyActionContentController> m_DictContentCtr;

	private Dictionary<string, KeyActionSettingData> m_KeyCodeMapping;

	private Dictionary<string, UINewKeyActionItemController> m_NewKeyActionItemCantRepeat;

	private List<KeyActionSettingData> m_TypeNoneKeyActionCantRepeat;

	private Dictionary<string, KeyCode> m_ChangedKeyActionMapCache;

	private UserKeyActionManager m_UserKeyActionInstance;

	private UINewKeyActionItemController m_CurItemCtr;

	private bool m_WaitingForKey;

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

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private IEnumerator RefreshScroll()
	{
		return null;
	}

	private void GenerateKeyActionContent()
	{
	}

	private void GenerateKeyActionItem()
	{
	}

	private void OnItemClick(UINewKeyActionItemController ctrl)
	{
	}

	private void OnGUI()
	{
	}

	private bool ExistConflictKeyCode(KeyCode keyCode, string actionName, ref string conflictName)
	{
		return false;
	}

	private void UncheckCurKeyItem()
	{
	}

	private void OnResetButtonClick()
	{
	}

	private void OnSaveButtonClick()
	{
	}

	private void _003COnResetButtonClick_003Eb__21_0()
	{
	}

	private void _003COnSaveButtonClick_003Eb__22_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
