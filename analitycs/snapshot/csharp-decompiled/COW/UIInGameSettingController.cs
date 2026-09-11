using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIInGameSettingController : UISettingContentBase
{
	private sealed class _003CShowDefaultHUDPreview_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIInGameSettingController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowDefaultHUDPreview_003Ed__24(int _003C_003E1__state)
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

	private sealed class _003CShowDefaultSensi_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIInGameSettingController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowDefaultSensi_003Ed__25(int _003C_003E1__state)
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

	private sealed class _003CShowSetting_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIInGameSettingController _003C_003E4__this;

		public SettingMainType settingType;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowSetting_003Ed__34(int _003C_003E1__state)
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

	private UIInGameSettingView m_View;

	private List<UIInGameSettingTopTabController> m_Toggles;

	private UINewAutoPickUpSettingController m_PickUpCtrl;

	private UIOperationSettingController m_OperationCtrl;

	private UIVibrateNewSettingController m_VibrateCtrl;

	private UISensiSettingController m_SensiCtrl;

	private UIInformationSettingController m_InfoCtrl;

	private UIHudPreviewSettingController m_HudPreviewCtrl;

	private UIPopMenuSmallControler m_SensiPopMenuCtrl;

	private Dictionary<int, string> m_SensiPopStr;

	private UISettingContentBase m_ShowingContent;

	private SettingMainType m_ShowingType;

	private int m_TopToggleWidth;

	private Coroutine m_ShowSettingCoroutine;

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

	public void SetViewData()
	{
	}

	private void OnTipsClick()
	{
	}

	private void OnResetClick()
	{
	}

	private void GenerateToggleData()
	{
	}

	private bool TryGetTargetToggle(SettingMainType settingType, out UIInGameSettingTopTabController toggle)
	{
		toggle = null;
		return false;
	}

	private IEnumerator ShowDefaultHUDPreview()
	{
		return null;
	}

	private IEnumerator ShowDefaultSensi()
	{
		return null;
	}

	private void InitToggleLength()
	{
	}

	private UIInGameSettingTopTabController CreateControlsToggle()
	{
		return null;
	}

	private UIInGameSettingTopTabController CreateInformationToggle()
	{
		return null;
	}

	private UIInGameSettingTopTabController CreatesSensitivtyToggle()
	{
		return null;
	}

	private UIInGameSettingTopTabController CreateAutoPickupToggle()
	{
		return null;
	}

	private UIInGameSettingTopTabController CreateVibrationToggle()
	{
		return null;
	}

	private UIInGameSettingTopTabController CreateHudPreviewToggle()
	{
		return null;
	}

	public void SetShownSetting(SettingMainType settingType)
	{
	}

	private IEnumerator ShowSetting(SettingMainType settingType)
	{
		return null;
	}

	private void OnToggleClick(SettingMainType settingType)
	{
	}

	private void DisplayCDN()
	{
	}

	public override void RefreshContent(object[] param)
	{
	}

	private void UpdatePanels(UIBaseController ctrl)
	{
	}

	private void HideAllSetting()
	{
	}

	private void OnHudSettingChanged(object[] param)
	{
	}

	private void CloseSpecificSetting(SettingMainType settingType)
	{
	}

	private void RefreshSensiPop()
	{
	}

	private void GenerateSensiPopMenuData()
	{
	}

	private void OnPopMenuSelected(object obj)
	{
	}

	private void OnInGameItemClicked(object[] objects)
	{
	}

	private void RefreshCDNContent(SettingPic settingPic)
	{
	}

	private void _003CCreateControlsToggle_003Eb__27_0()
	{
	}

	private void _003CCreateInformationToggle_003Eb__28_0()
	{
	}

	private void _003CCreatesSensitivtyToggle_003Eb__29_0()
	{
	}

	private void _003CCreateAutoPickupToggle_003Eb__30_0()
	{
	}

	private void _003CCreateVibrationToggle_003Eb__31_0()
	{
	}

	private void _003CCreateHudPreviewToggle_003Eb__32_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
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

	public void _003C_003EiFixBaseProxy_RefreshContent(object[] P0)
	{
	}
}
