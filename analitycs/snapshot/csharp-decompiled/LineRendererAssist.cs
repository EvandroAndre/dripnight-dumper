using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererAssist : MonoBehaviour
{
	private sealed class _003CIECalculateLineRendererWidthMultiplier_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LineRendererAssist _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CIECalculateLineRendererWidthMultiplier_003Ed__10(int _003C_003E1__state)
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

	public int BaseScale;

	public LineRenderer LineRenderer;

	public TrailRenderer TrailRenderer;

	private float m_LineScaleMultiplyer;

	private float m_TrailScaleMultiplyer;

	private float m_CurrentScale;

	private bool Inited;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private IEnumerator IECalculateLineRendererWidthMultiplier()
	{
		return null;
	}

	private void CalculateLineRendererWidthMultiplier()
	{
	}
}
