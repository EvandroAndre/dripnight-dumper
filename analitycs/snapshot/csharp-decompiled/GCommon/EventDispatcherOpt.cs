using System;
using System.Collections;
using System.Collections.Generic;
using COW;

namespace GCommon;

public class EventDispatcherOpt : EventDispatcher
{
	private class PendingHandler<T>
	{
		public T handler;

		public bool isPending;
	}

	private class EventHandlerContainers<T>
	{
		public List<T> handlers;

		public List<PendingHandler<T>> pendings;

		private bool isProcessing;

		private bool isFrameProcessing;

		private void Pending(T handler, bool isPending)
		{
		}

		public void Add(T handler)
		{
		}

		public void Remove(T handler)
		{
		}

		public void PreProcess()
		{
		}

		public void FramingPreProcess()
		{
		}

		public void FramingPostProcess()
		{
		}

		public void PostProcess()
		{
		}
	}

	private class EventFraming
	{
		public FTimer m_Timer;

		public IEnumerator m_FCoroutine;

		public object[] m_Data;

		public EventHandlerContainers<EventHandler> containers;
	}

	private sealed class _003CDispatchEventFCoroutine_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EventHandlerContainers<EventHandler> containers;

		public object[] data;

		public FTimer timer;

		private List<EventHandler>.Enumerator _003C_003E7__wrap1;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDispatchEventFCoroutine_003Ed__28(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private Dictionary<int, EventHandlerContainers<EventHandler>> m_EventDict;

	private Dictionary<int, EventHandlerContainers<VEventHandler>> m_VEventDict;

	private Dictionary<int, EventHandlerContainers<BEventHandler>> m_BEventDict;

	private Dictionary<int, EventHandlerContainers<UEventHandler>> m_UEventDict;

	private Dictionary<int, EventHandlerContainers<UlEventHandler>> m_UlEventDict;

	private Dictionary<int, EventHandlerContainers<FEventHandler>> m_FEventDict;

	private Dictionary<int, EventHandlerContainers<UUEventHandler>> m_UUEventDict;

	private Dictionary<int, EventHandlerContainers<IEventHandler>> m_IEventDict;

	private Dictionary<int, EventHandlerContainers<IIEventHandler>> m_IIEventDict;

	private Dictionary<int, EventHandlerContainers<GEventHandler>> m_GEventDict;

	private static object[] commonParam;

	private static Stack<object[]> m_OneArgPool;

	private static Stack<object[]> m_TwoArgPool;

	private Dictionary<int, EventFraming> m_EventFCoroutineDict;

	private object[] PopOneArgArray(object arg)
	{
		return null;
	}

	private void PushOneArgArray(object[] arr)
	{
	}

	private object[] PopTwoArgArray(object arg0, object arg1)
	{
		return null;
	}

	private void PushTwoArgArray(object[] arr)
	{
	}

	private void DispatchEventWithOneArg(EventID eventID, object arg)
	{
	}

	private void DispatchEventWithTwoArgs(EventID eventID, object arg0, object arg1)
	{
	}

	public override void ClearTargetTypeEventHandler<T>()
	{
	}

	private void ClearTargetTypeHandler<T, Target>(Dictionary<int, EventHandlerContainers<T>> handlerDontainersDic)
	{
	}

	private EventHandlerContainers<T> GetHandlerContainerInternal<T>(Dictionary<int, EventHandlerContainers<T>> dic, EventID eventID)
	{
		return null;
	}

	private void DispatchEventFCoroutine(EventID eventID, object[] data)
	{
	}

	private IEnumerator DispatchEventFCoroutine(EventHandlerContainers<EventHandler> containers, FTimer timer, object[] data)
	{
		return null;
	}

	public override void DispatchEventFraming(EventID eventID, object[] data)
	{
	}

	public override void DispatchEvent(EventID eventID, object[] data)
	{
	}

	public override void DispatchEventSample(EventID eventID, object[] data)
	{
	}

	public override void DispatchVEvent(EventID eventID)
	{
	}

	public override void DispatchGEvent(EventID eventID, GEvent data)
	{
	}

	public override void DispatchFEvent(EventID eventID, float data)
	{
	}

	public override void DispatchBEvent(EventID eventID, bool data)
	{
	}

	public override void DispatchUEvent(EventID eventID, uint data)
	{
	}

	public override void DispatchUlEvent(EventID eventID, ulong data)
	{
	}

	public override void DispatchUEvent(EventID eventID, uint data0, uint data1)
	{
	}

	public override void DispatchIEvent(EventID eventID, int data)
	{
	}

	public override void DispatchIIEvent(EventID eventID, int data0, int data1)
	{
	}

	private void RegisterInternal<T>(Dictionary<int, EventHandlerContainers<T>> dic, EventID eventID, T eventHandler)
	{
	}

	public override void RegisterFEvent(EventID eventID, FEventHandler eventHandler)
	{
	}

	public override void RegisterEvent(EventID eventID, EventHandler eventHandler)
	{
	}

	public override void RegisterVEvent(EventID eventID, VEventHandler eventHandler)
	{
	}

	public override void RegisterEvent(EventID eventID, BEventHandler eventHandler)
	{
	}

	public override void RegisterEvent(EventID eventID, GEventHandler eventHandler)
	{
	}

	public override void RegisterEvent(EventID eventID, UEventHandler eventHandler)
	{
	}

	public override void RegisterEvent(EventID eventID, UUEventHandler eventHandler)
	{
	}

	public override void RegisterEvent(EventID eventID, IEventHandler eventHandler)
	{
	}

	public override void RegisterEvent(EventID eventID, IIEventHandler eventHandler)
	{
	}

	public override void RegisterEvent(EventID eventID, UlEventHandler eventHandler)
	{
	}

	private void UnRegisterInternal<T>(Dictionary<int, EventHandlerContainers<T>> dic, EventID eventID, T eventHandler)
	{
	}

	public override void UnRegisterEvent(EventID eventID, EventHandler eventHandler)
	{
	}

	public override void UnRegisterFEvent(EventID eventID, FEventHandler eventHandler)
	{
	}

	public override void UnRegisterVEvent(EventID eventID, VEventHandler eventHandler)
	{
	}

	public override void UnRegisterEvent(EventID eventID, BEventHandler eventHandler)
	{
	}

	public override void UnRegisterEvent(EventID eventID, UEventHandler eventHandler)
	{
	}

	public override void UnRegisterEvent(EventID eventID, UUEventHandler eventHandler)
	{
	}

	public override void UnRegisterEvent(EventID eventID, IEventHandler eventHandler)
	{
	}

	public override void UnRegisterEvent(EventID eventID, IIEventHandler eventHandler)
	{
	}

	public override void UnRegisterEvent(EventID eventID, GEventHandler eventHandler)
	{
	}

	public override void UnRegisterGEvent(EventID eventID, GEventHandler eventHandler)
	{
	}

	public override void UnRegisterEvent(EventID eventID, UlEventHandler eventHandler)
	{
	}
}
