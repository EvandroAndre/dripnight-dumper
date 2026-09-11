using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UISensiSettingController : UISettingContentBase
{
	private sealed class _003CShowDefaultCDNCoroutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISensiSettingController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowDefaultCDNCoroutine_003Ed__13(int _003C_003E1__state)
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

	private UISensiSettingView m_View;

	public static SenstitivitySubType LastClickedTypeInFrontEnd;

	public static bool IsTrainingClicked;

	private CommonSettingContentData m_Data;

	private UICommonSettingContentShortController m_Ctrl;

	private SensiPresetHelper m_ResetHelper;

	private bool m_IsUGCModel1P;

	public bool IsRefreshingContent;

	public bool IsResetting;

	public override void RefreshContent(object[] param)
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ShowDefaultCDN()
	{
	}

	private IEnumerator ShowDefaultCDNCoroutine()
	{
		return null;
	}

	public void OnPopMenuSelected()
	{
	}

	public override void ResetToDefault()
	{
	}

	private void UpdateSettingsOnPresetChanged(List<float> presets)
	{
	}

	private void ResetScrollViewWidth()
	{
	}

	private void OnTrainingLandClicked()
	{
	}

	private InGameSettingItemDataSlider CreateSensitivityData()
	{
		return null;
	}

	private InGameSettingItemDataSlider CreateSensitivity1PData()
	{
		return null;
	}

	private InGameSettingItemDataSlider Createx1ScopeData()
	{
		return null;
	}

	private InGameSettingItemDataSlider Createx2ScopeData()
	{
		return null;
	}

	private InGameSettingItemDataSlider Createx4ScopeData()
	{
		return null;
	}

	private InGameSettingItemDataSlider Createx8ScopeData()
	{
		return null;
	}

	private InGameSettingItemDataSlider CreateAuxAimSensitivityData()
	{
		return null;
	}

	private void UpdateClickedSensi(SenstitivitySubType clickType)
	{
	}

	private float GetMinusValue()
	{
		return 0f;
	}

	private float GetPlusValue()
	{
		return 0f;
	}

	private void RefreshBtnsState()
	{
	}

	private void _003CCreateSensitivityData_003Eb__19_0(float value)
	{
	}

	private void _003CCreateSensitivity1PData_003Eb__20_0(float value)
	{
	}

	private void _003CCreatex1ScopeData_003Eb__21_0(float value)
	{
	}

	private void _003CCreatex2ScopeData_003Eb__22_0(float value)
	{
	}

	private void _003CCreatex4ScopeData_003Eb__23_0(float value)
	{
	}

	private void _003CCreatex8ScopeData_003Eb__24_0(float value)
	{
	}

	private void _003CCreateAuxAimSensitivityData_003Eb__25_0(float value)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent(object[] P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_ResetToDefault()
	{
	}
}
