using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace COW.Location;

public class GPSManager : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public Action<bool> callback;

		internal void _003CUpdateGPSPermissions_003Eb__0(bool hasPermission)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public Action<bool> callback;

		internal void _003CRequestGPSPermission_003Eb__0(Dictionary<int, bool> results)
		{
		}
	}

	private sealed class _003CStartLocationCoroutine_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GPSManager _003C_003E4__this;

		private float _003CstartTime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartLocationCoroutine_003Ed__15(int _003C_003E1__state)
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

	private static GPSManager _instance;

	private static readonly int[] _GPSPermissions;

	private bool m_IsLocating;

	private List<Action<GPSLocationData>> m_SuccessCallbacks;

	private List<Action<string>> m_ErrorCallbacks;

	private Coroutine m_LocationCoroutine;

	private const float TOTAL_LOCATION_TIMEOUT = 30f;

	public static GPSManager Instance => null;

	private void Awake()
	{
	}

	public bool HasGPSPermission()
	{
		return false;
	}

	public void UpdateGPSPermissions(Action<bool> callback)
	{
	}

	public void RequestGPSPermission(Action<bool> callback)
	{
	}

	public void RequestSingleLocation(Action<GPSLocationData> onSuccess, Action<string> onError)
	{
	}

	public void StopLocation()
	{
	}

	private IEnumerator StartLocationCoroutine()
	{
		return null;
	}

	private void NotifyAllCallbacks(GPSLocationData data, string error)
	{
	}

	private void OnDestroy()
	{
	}
}
