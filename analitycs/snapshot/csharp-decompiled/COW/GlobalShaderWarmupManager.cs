using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public static class GlobalShaderWarmupManager
{
	public struct ShaderWarmupState
	{
		public float Progress;

		public bool IsCompleted;

		public int WarmupedVariantCount;

		public ResourceID ResourceID;

		public Action OnComplete;

		public int WarmupStep;

		public void Clear()
		{
		}
	}

	private sealed class _003CWarmupProgressively_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShaderVariantCollection collection;

		public int maxWarmupStep;

		public int targetShaderLOD;

		public Action onComplete;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWarmupProgressively_003Ed__13(int _003C_003E1__state)
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

	private static ShaderWarmupState m_CurrentWarmupState;

	private static MonoBehaviour m_Runner;

	private static bool m_IsInitialized;

	private static bool m_IsProcessing;

	private const bool m_DebugSimulateWarmup = false;

	public static void Initialize(MonoBehaviour runner)
	{
	}

	public static void Warmup(ResourceID resourceID, Action onComplete = null, int targetShaderLOD = -1)
	{
	}

	public static void WarmupAsync(ResourceID resourceID, Action onComplete = null, int maxWarmupStep = 5, int targetShaderLOD = -1)
	{
	}

	public static float GetCurrentWarmupProgress()
	{
		return 0f;
	}

	private static bool IsValidWarmupRequest(ResourceID resourceID)
	{
		return false;
	}

	private static ShaderVariantCollection LoadShaderVariantCollection(ResourceID resourceID)
	{
		return null;
	}

	private static IEnumerator WarmupInstantly(ShaderVariantCollection collection, Action onComplete = null, int targetShaderLOD = -1)
	{
		return null;
	}

	private static IEnumerator WarmupProgressively(ShaderVariantCollection collection, Action onComplete, int maxWarmupStep, int targetShaderLOD = -1)
	{
		return null;
	}
}
