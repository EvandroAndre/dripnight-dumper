using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudPreviewSettingController : UISettingContentBase, IUIModelDataChangeObserver
{
	private sealed class _003CCreateFastPreviewsCoroutine_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudPreviewSettingController _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCreateFastPreviewsCoroutine_003Ed__20(int _003C_003E1__state)
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

	private sealed class _003CRefreshScroll_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudPreviewSettingController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshScroll_003Ed__13(int _003C_003E1__state)
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

	private UIHudPreviewSettingView m_View;

	private List<UIHudFastPreviewController> m_FastPreviewList;

	public float ToggleBGLength;

	private const int FastPreviewCount = 4;

	private Coroutine m_CreateFastPreviewCoroutine;

	private UIModelKolHud m_ModelKolHud;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnShareCodeUseClick()
	{
	}

	private void OnMoreHudBtnClick()
	{
	}

	private void OnKOLUpLoadClick()
	{
	}

	public void OnHudShareCodeUsed(int presetIndex, Dictionary<string, HudConfigItem> BackendShareCodeConfigs, int BackendGarenadeDir, int BackendGarenadeDir2)
	{
	}

	public override void RefreshContent(object[] param)
	{
	}

	private IEnumerator RefreshScroll()
	{
		return null;
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

	public void RefreshFastPreviewsChosen()
	{
	}

	public void CreateFastPreviewsAsync()
	{
	}

	private void ClearFastPreviews()
	{
	}

	private IEnumerator CreateFastPreviewsCoroutine()
	{
		return null;
	}

	private void ModifyScrollViewSize()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent(object[] P0)
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
