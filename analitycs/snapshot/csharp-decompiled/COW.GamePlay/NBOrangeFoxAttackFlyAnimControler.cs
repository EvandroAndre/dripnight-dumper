using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay;

public class NBOrangeFoxAttackFlyAnimControler : MonoBehaviour
{
	private sealed class IEMEOFIBABJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public float CNKMEPFCJOM;

		public Action NLDEEGJIHEF;

		private float KGLMCHANEJB;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public IEMEOFIBABJ(int CBPPJACCGOH)
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

	private sealed class HNLIDBAAFMA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public float CNKMEPFCJOM;

		public NBOrangeFoxAttackFlyAnimControler KOKNHFGCGLN;

		public Action NLDEEGJIHEF;

		private float KGLMCHANEJB;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public HNLIDBAAFMA(int CBPPJACCGOH)
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

	public AnimationCurve posXCurve;

	public AnimationCurve posYCurve;

	public AnimationCurve posZCurve;

	public Vector3 startPos;

	public Vector3 endPos;

	public void Evaluate(float ANKHOIOEFKM)
	{
	}

	public Vector3 GetEvaluateValue(float ANKHOIOEFKM)
	{
		return default(Vector3);
	}

	public void StartAnim(Vector3 OCLFLNINDAP, Vector3 BMEBLGLGMNK, float CNKMEPFCJOM, Action NLDEEGJIHEF)
	{
	}

	private IEnumerator HPCFIDNPHON(float CNKMEPFCJOM, Action NLDEEGJIHEF)
	{
		return null;
	}

	public void StartMissAnim(float CNKMEPFCJOM, Action NLDEEGJIHEF)
	{
	}

	private IEnumerator FDFPNCMBJOD(float CNKMEPFCJOM, Action NLDEEGJIHEF)
	{
		return null;
	}
}
