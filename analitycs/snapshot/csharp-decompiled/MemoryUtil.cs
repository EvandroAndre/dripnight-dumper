using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryUtil
{
	public enum UnloadLevel
	{
		Normal,
		Emergency,
		Force
	}

	public enum GCCollectLevel
	{
		Normal,
		Emergency,
		Force,
		ForceNoInterval,
		MapAndCS
	}

	private sealed class _003CEmergencyFCoroutine_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CEmergencyFCoroutine_003Ed__26(int _003C_003E1__state)
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

	private static float m_UnloadLastTime;

	private static double m_GCCollectLastTime;

	private static double m_GCCollectNormalInterval;

	private static double m_GCMapCSInterval;

	public static int m_UnloadNormalCount;

	public static int m_UnloadEmergencyCount;

	public static int m_UnloadForceCount;

	public static int m_UnloadCount;

	public static int m_UnloadFrameTickCount;

	public static int m_OnLowMemoryCount;

	public static long m_EnterGameMonoUsedSize;

	public static long m_EnterGameMonoHeapSize;

	public static long m_EnterTotalUnusedReservedMemory;

	public static long m_EnterGameTotalAllocatedMemory;

	public static long m_EnterTotalReservedMemory;

	private static double GCForceInterval;

	private static IEnumerator EmergencyCoroutine;

	public static void RecordEnterGameMemroy()
	{
	}

	public static void RecordMemroy()
	{
	}

	public static void ClearUnloadCounts()
	{
	}

	public static AsyncOperation UnloadUnusedAssets(UnloadLevel unloadLevel)
	{
		return null;
	}

	private static void ClearLoadedResourceRefsAndPool()
	{
	}

	private static AsyncOperation UnloadUnusedAssetsInternal()
	{
		return null;
	}

	private static void EmergencyGC()
	{
	}

	private static IEnumerator EmergencyFCoroutine()
	{
		return null;
	}

	public static void GCCollect(GCCollectLevel gcCollectLevel)
	{
	}

	private static void ReleaseMonoRefs(bool emergency)
	{
	}

	private static bool NeedClearPreloadWhenEmergency()
	{
		return false;
	}
}
