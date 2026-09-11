using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIActivityNewOverviewController : UIActivityContentController
{
	private sealed class _003CResetScrollView_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIActivityNewOverviewController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CResetScrollView_003Ed__10(int _003C_003E1__state)
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

	private UIActivityNewOverviewView m_View;

	private UIModelActivity m_ModelActivity;

	private List<IOverViewController> m_ItemControllers;

	private List<ClientActivityDesc> m_ActivityList;

	private string m_CategoryTitle;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetCategoryTitle(string title)
	{
	}

	public override void SetData(object data)
	{
	}

	private int OverviewSort(ClientActivityDesc x, ClientActivityDesc y)
	{
		return 0;
	}

	private IEnumerator ResetScrollView()
	{
		return null;
	}

	public override void OnVisibilityChange(bool isVisible, bool needRefresh)
	{
	}

	public override void Reload()
	{
	}

	private UIActivityPopWindowBase GetParentPopWindow()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChange(bool P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_Reload()
	{
	}
}
