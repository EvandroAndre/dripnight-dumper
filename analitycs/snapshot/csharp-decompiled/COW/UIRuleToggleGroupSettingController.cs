using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIRuleToggleGroupSettingController : UIBaseController, IUIRuleBindVar
{
	private sealed class _003CUpdateTipsAnchor_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIRuleToggleGroupSettingController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CUpdateTipsAnchor_003Ed__9(int _003C_003E1__state)
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

	private UIRuleToggleSettingV2View m_View;

	public CToggleGroupData Data;

	public UIModeEditGeneralComponentHelper GeneralHelper;

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

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(CToggleGroupData data, float width, UIModeEditGeneralComponentHelper parentGeneralHelper)
	{
	}

	private IEnumerator UpdateTipsAnchor()
	{
		return null;
	}

	private void OnToggle(UIToggleButton btn)
	{
	}

	private void SetValue(int newValue)
	{
	}

	public int GetModeVariableID()
	{
		return 0;
	}

	public UIWidget GetBindWidget()
	{
		return null;
	}

	private void OnValueChanged()
	{
	}

	private void _003CSetViewData_003Eb__8_0()
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

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
