using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using UnityEngine.SceneManagement;
using WorldStreamer;

public static class StreamerFacade
{
	private class VisibleFunc
	{
		public List<VisibleHandler> StaticHandler;

		public List<VisibleHandler> DynamicHandler;

		public List<VisibleHandler> StaticHandlerNeedAdd;

		public List<VisibleHandler> StaticHandlerNeedRemove;

		public List<VisibleHandler> DynamicHandlerNeedRemove;
	}

	public delegate void VisibleHandler(Vector3 min, Vector3 max);

	private sealed class _003CDispatchVisibleEnventDefaultStaticCo_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private VisibleFunc _003CstreamerHandlers_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDispatchVisibleEnventDefaultStaticCo_003Ed__39(int _003C_003E1__state)
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

	private sealed class _003CDispatchVisibleEnventLLevelObjectCo_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private VisibleFunc _003CstreamerHandlers_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDispatchVisibleEnventLLevelObjectCo_003Ed__45(int _003C_003E1__state)
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

	private static IStreamerFunc m_Impl;

	private static Dictionary<int, VisibleFunc> m_Handler;

	private static List<Streamer> m_streamerList;

	private static SimulationStreamer m_simulationStreamer;

	private static bool mIsStreamingFinished;

	private static int _003CSceneAddFailureCount_003Ek__BackingField;

	private static IEnumerator m_DefaultStaticFCO;

	private static Vector3 m_DefaultStaticMin;

	private static Vector3 m_DefaultStaticMax;

	private static List<VisibleHandler>.Enumerator m_DefaultHandlers;

	private static int m_ResetTick;

	public static FTimer m_Timer;

	private static IEnumerator m_LLevelObjectStaticFCO;

	private static Vector3 m_LLevelObjectStaticMin;

	private static Vector3 m_LLevelObjectStaticMax;

	private static List<VisibleHandler>.Enumerator m_LLevelObjectHandlers;

	public static bool IsMainStreamFinished
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static int SceneAddFailureCount
	{
		get
		{
			return _003CSceneAddFailureCount_003Ek__BackingField;
		}
		set
		{
			_003CSceneAddFailureCount_003Ek__BackingField = value;
		}
	}

	public static void SetImpl(IStreamerFunc impl)
	{
	}

	public static Transform GetTargetPlayer()
	{
		return null;
	}

	public static AsyncOperation LoadSceneAsync(string sourcePath, LoadSceneMode mode, bool forceSync = false)
	{
		return null;
	}

	public static AssetBundle GetStreamSceneAB()
	{
		return null;
	}

	public static Dictionary<int, List<CFIJFGBBLON>> GetStreamScenePatchAB()
	{
		return null;
	}

	public static byte[] GetStreamSceneABTexRefInfo()
	{
		return null;
	}

	public static void OnLoadSceneFinish(bool result, string sourcePath = null)
	{
	}

	public static void RepeatAction(float interval, Action action)
	{
	}

	public static void NotifySceneEvent(StreamerType type, string name, GameObject go, bool loaded)
	{
	}

	private static Streamer GetStreamer(StreamerType streamerType)
	{
		return null;
	}

	private static LStreamer GetLStreamer(StreamerType streamerType)
	{
		return null;
	}

	public static void RegistLEntity(StreamerType streamerType, LEntity lEntity, bool isDynamic)
	{
	}

	public static void UnRegistLEntity(StreamerType streamerType, LEntity lEntity, bool isDynamic, bool removeLater = false)
	{
	}

	public static void RegistVisibleHandler(StreamerType type, VisibleHandler handler, bool isDynamic)
	{
	}

	public static void UnRegistVisibleHandler(StreamerType type, VisibleHandler handler, bool isDynamic, bool removeLater = false)
	{
	}

	public static void DispatchVisibleEnvent(StreamerType type, bool isDynamic, Vector3 min, Vector3 max)
	{
	}

	public static void InvokeCallBack(StreamerType streamerType, VisibleHandler handler, Vector3 min, Vector3 max)
	{
	}

	public static void ResetTimer()
	{
	}

	public static void DispatchVisibleEnventDefaultStaticTimeLimit(StreamerType type, bool isDynamic, Vector3 min, Vector3 max)
	{
	}

	public static IEnumerator DispatchVisibleEnventDefaultStaticCo()
	{
		return null;
	}

	public static void DispatchVisibleEnventLLevelObjectStaticTimeLimit(StreamerType type, bool isDynamic, Vector3 min, Vector3 max)
	{
	}

	public static IEnumerator DispatchVisibleEnventLLevelObjectCo()
	{
		return null;
	}

	public static bool RegistStreamer(StreamerType type)
	{
		return false;
	}

	public static void UnRegistStreamer(StreamerType type)
	{
	}

	public static void AddStreamer(Streamer streamer)
	{
	}

	public static void StopAllStreamer()
	{
	}

	public static void ForceUpdatePositionChecker()
	{
	}

	public static bool GetStreamerRange(out Vector3 min, out Vector3 max)
	{
		min = default(Vector3);
		max = default(Vector3);
		return false;
	}
}
