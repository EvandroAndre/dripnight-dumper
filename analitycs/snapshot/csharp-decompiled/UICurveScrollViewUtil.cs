using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICurveScrollViewUtil : MonoBehaviour
{
	private sealed class _003CClockwiseRollingCor_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UICurveScrollViewUtil _003C_003E4__this;

		public bool clockWise;

		public Action onFinish;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CClockwiseRollingCor_003Ed__9(int _003C_003E1__state)
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

	public Transform CircleCenter;

	public bool IsClockwise;

	public float ItemAngle;

	public float RoationTime;

	public List<Transform> RollingItems;

	public bool IsRolling;

	private float timer;

	private void Awake()
	{
	}

	public void StartRolling(bool isClockWise, Action onFinish = null)
	{
	}

	private IEnumerator ClockwiseRollingCor(bool clockWise, Action onFinish)
	{
		return null;
	}

	public void ResetPosition()
	{
	}

	public void AddRollingItems(Transform transform)
	{
	}

	public void ClearRollingItems()
	{
	}

	public Transform GetRollingItem(int index)
	{
		return null;
	}

	private Vector3 CalcRotation(Vector3 beMovedItem, bool isClockWise, float angle)
	{
		return default(Vector3);
	}
}
