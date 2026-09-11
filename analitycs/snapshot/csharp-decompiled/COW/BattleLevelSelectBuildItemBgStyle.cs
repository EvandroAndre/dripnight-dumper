using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class BattleLevelSelectBuildItemBgStyle : MonoBehaviour
{
	private sealed class _003CPlayCustomTweenForward_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BattleLevelSelectBuildItemBgStyle _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayCustomTweenForward_003Ed__12(int _003C_003E1__state)
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

	private sealed class _003CPlayCustomTweenReverse_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BattleLevelSelectBuildItemBgStyle _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayCustomTweenReverse_003Ed__13(int _003C_003E1__state)
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

	public UISprite TopBg;

	public UISprite TextureTopBg;

	public AnimationCurve TopBgHeightCurve;

	public AnimationCurve TextureTopBgPositionYCurve;

	public AnimationCurve TextureTopBgFillAmountCurve;

	private bool m_ComponentBind;

	private bool m_AllCurvesReady;

	private float m_Value;

	private float m_Duration;

	private Coroutine m_CustomTweenCoroutine;

	private void Awake()
	{
	}

	private void CalculateCurveLength()
	{
	}

	private IEnumerator PlayCustomTweenForward()
	{
		return null;
	}

	private IEnumerator PlayCustomTweenReverse()
	{
		return null;
	}

	private void TryStopCustomTweenCoroutine()
	{
	}

	public void Play(bool forward)
	{
	}

	public void SetToBeginning()
	{
	}

	public void SetToEnd()
	{
	}

	public void SetTo(bool forward)
	{
	}
}
