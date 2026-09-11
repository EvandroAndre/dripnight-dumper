using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIUGCHudWidgetAttributeTextAreaController : UIUGCHudWidgetAttributeController<string>
{
	private sealed class _003CResetText_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCHudWidgetAttributeTextAreaController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CResetText_003Ed__9(int _003C_003E1__state)
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

	private UIUGCHudWidgetAttributeTextAreaView m_View;

	private int m_CharLimit;

	public override string AttributeData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override UIUGCHudWidgetAttributeEnum GetAttributeEnum()
	{
		return UIUGCHudWidgetAttributeEnum.Color;
	}

	protected override void OnUIInit()
	{
	}

	public override void InitAttribute(string data)
	{
	}

	private IEnumerator ResetText()
	{
		return null;
	}

	public void SetViewData(string title, int charLimit, string defaultValue = "")
	{
	}

	private void OnInputChanged()
	{
	}

	private void OnInputLostFocus()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
