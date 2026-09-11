using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIColorPaletteController : UIBaseController
{
	private sealed class _003CMovePanelShowColor_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIColorPaletteController _003C_003E4__this;

		public int posY;

		private int _003CmoveSpeed_003E5__2;

		private UIPanel _003Cpanel_003E5__3;

		private int _003Cadd_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CMovePanelShowColor_003Ed__21(int _003C_003E1__state)
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

	private UIColorPaletteView m_View;

	private List<UIColorPaletteItemController> m_Colors;

	private AvatarWardrobeData m_Cloth;

	private uint m_SeriesId;

	private bool m_IsColorPanelShow;

	private Coroutine m_CoroutineMovePanelShowColor;

	private static Vector3 m_ScrollPosition;

	private const int SCROLL_LIMIT = 4;

	private int m_DestScrollDistance;

	private const int SCROLL_OFFSET = 50;

	private bool m_IsSameSeries;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshView(InventoryClothSeriesInfo seriesInfo)
	{
	}

	private void RefreshColorItem(AvatarWardrobeData cloth, uint seriesId)
	{
	}

	public void AutoShowPanel()
	{
	}

	private void ResetPanel()
	{
	}

	public uint GetTailorId()
	{
		return 0u;
	}

	private void OnBtnSwitchClick()
	{
	}

	private void ScrollColorPanel()
	{
	}

	private void SetPanelColorShow(int posY)
	{
	}

	private IEnumerator MovePanelShowColor(int posY)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
