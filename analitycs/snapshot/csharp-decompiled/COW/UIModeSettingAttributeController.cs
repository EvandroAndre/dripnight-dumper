using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIModeSettingAttributeController : UIPopupWindowController, IEasyList
{
	private enum EEntityTypeTab
	{
		Global,
		Team,
		Player,
		Count
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public UIModeSettingAttributeController _003C_003E4__this;

		public int i;
	}

	private sealed class _003C_003Ec__DisplayClass23_1
	{
		public string name;

		public _003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals1;

		internal bool _003CCheckVaild_003Eb__0(IBILCDHHNHM data)
		{
			return false;
		}
	}

	private sealed class _003CWaitOneFrameUpdateAnchors_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIModeSettingAttributeController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitOneFrameUpdateAnchors_003Ed__30(int _003C_003E1__state)
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

	private UIModeSettingAttributeView m_View;

	private AOKBGKNKKLJ m_CurrentEntityAttributeData;

	private AOKBGKNKKLJ[] m_EntityAttributeData;

	private Transform[] m_TabTransRoot;

	private string[] m_EntityEditorKey;

	private bool mItemChildrenInit;

	private EEntityTypeTab m_CurrentTab;

	private int m_MaxAttributeCount => 0;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void TutorialEditHandler()
	{
	}

	private void UpdateEditBtnLabel()
	{
	}

	private void UpdateAdvancedEditModeView()
	{
	}

	private void OnBtnBlockEdit()
	{
	}

	private void OnClickGlobalTab()
	{
	}

	private void OnClickTeamTab()
	{
	}

	private void OnPlayerTab()
	{
	}

	private void RefreshTabView(EEntityTypeTab tab)
	{
	}

	private void OnAddBtnClick()
	{
	}

	private void OnConfirmClick()
	{
	}

	private bool CheckVaild(out string reason)
	{
		reason = null;
		return false;
	}

	private string GetLogicEntityTypeByTab(EEntityTypeTab tab)
	{
		return null;
	}

	private void SetEntityAttributeDate()
	{
	}

	private void RefreshAttributeListView()
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private IEnumerator WaitOneFrameUpdateAnchors()
	{
		return null;
	}

	private void DeleteAttribute(object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
