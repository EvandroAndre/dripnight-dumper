using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UISeasonReplayOverviewHighlightButtonController : UIBaseController
{
	private sealed class _003CCoCenterOnChild_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISeasonReplayOverviewHighlightButtonController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoCenterOnChild_003Ed__21(int _003C_003E1__state)
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

	private uint m_SeasonID;

	private bool m_IsBR;

	private int m_LastSelectedIndex;

	private float _003CRatio_003Ek__BackingField;

	private UISeasonReplayOverviewHighlightButtonView m_View;

	private UIModelSeasonReplay m_ModelReplay;

	private List<RankingSeasonReplayEvent> m_DataList;

	private List<UISeasonReplayOverviewHighlightButtonItem> m_ItemList;

	private float m_Timer;

	private const float Interval = 2.5f;

	public float Ratio
	{
		get
		{
			return _003CRatio_003Ek__BackingField;
		}
		private set
		{
			_003CRatio_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(List<RankingSeasonReplayEvent> dataList, float ratio, uint seasonID, bool isBR)
	{
	}

	public void ShowOriginal()
	{
	}

	public void ShowSimplified()
	{
	}

	private void OnCenter(GameObject centerGo)
	{
	}

	public void CarouselImmediately()
	{
	}

	private void CenterOnChild()
	{
	}

	private IEnumerator CoCenterOnChild()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
