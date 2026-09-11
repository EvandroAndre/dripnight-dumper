using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIUGCFliterSelectTypeController : UIBaseController
{
	private sealed class _003CResetPosition_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCFliterSelectTypeController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CResetPosition_003Ed__9(int _003C_003E1__state)
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

	private UIUGCFliterSelectTypeView m_View;

	private UGCFliterSelectTypeData m_Data;

	private int m_RowNumber;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(UGCFliterSelectTypeData data)
	{
	}

	public uint GetSelectItemID()
	{
		return 0u;
	}

	public void RefreshSelectItemByID(uint id)
	{
	}

	public void RefreshView()
	{
	}

	private IEnumerator ResetPosition()
	{
		return null;
	}

	public int GetWidgetHeight()
	{
		return 0;
	}

	public void SetPanelDepth(int depth)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
