using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class VehicleResetPointManager : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<VehicleResetPos> _003C_003E9__5_0;

		internal int _003COnLocalPlayerAdd_003Eb__5_0(VehicleResetPos x, VehicleResetPos y)
		{
			return 0;
		}
	}

	public List<VehicleResetPos> VehicleResetPos;

	public GameObject NextEffectGo;

	public GameObject ArrowGo;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnLocalPlayerAdd(object[] data)
	{
	}

	private void OnMiniGameClose(object[] data)
	{
	}

	private void OnMiniGameStart(object[] data)
	{
	}

	private void OnVehicleReachPoint(object[] data)
	{
	}
}
