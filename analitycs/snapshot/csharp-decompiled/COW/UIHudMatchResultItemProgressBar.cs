using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class UIHudMatchResultItemProgressBar : MonoBehaviour
{
	private sealed class _003CCoProcessBar_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudMatchResultItemProgressBar _003C_003E4__this;

		private float _003Cfrom_003E5__2;

		private float _003Cto_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoProcessBar_003Ed__5(int _003C_003E1__state)
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

	public UISprite m_Bar;

	public UILabel m_LabelValue;

	public UILabel m_LabelPercent;

	private float m_TargetRatio;

	private void SetBarColor(Color color)
	{
	}

	private IEnumerator CoProcessBar()
	{
		return null;
	}

	public void UpdateInfo(int myValue, int totalValue, Color color = default(Color))
	{
	}
}
