using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class CompatibleLoginCountDown : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__3_0;

		internal void _003CCheck_003Eb__3_0()
		{
		}
	}

	private uint m_DelayCall;

	private List<uint> m_PreCloseTimes;

	private void Start()
	{
	}

	private void Check()
	{
	}

	private void OnDestroy()
	{
	}
}
