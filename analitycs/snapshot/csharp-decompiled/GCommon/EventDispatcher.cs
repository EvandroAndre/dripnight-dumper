using System;
using System.Collections.Generic;
using COW;

namespace GCommon;

public class EventDispatcher
{
	public delegate void EventHandler(object[] data);

	public delegate void VEventHandler();

	public delegate void BEventHandler(bool data);

	public delegate void UEventHandler(uint data);

	public delegate void UlEventHandler(ulong data);

	public delegate void FEventHandler(float data);

	public delegate void UUEventHandler(uint data0, uint data1);

	public delegate void IEventHandler(int data);

	public delegate void IIEventHandler(int data0, int data1);

	public delegate void GEventHandler(GEvent data);

	private Dictionary<int, EventHandler> m_EventDict;

	private Dictionary<int, VEventHandler> m_VEventDict;

	private Dictionary<int, BEventHandler> m_BEventDict;

	private Dictionary<int, UEventHandler> m_UEventDict;

	private Dictionary<int, UlEventHandler> m_UlEventDict;

	private Dictionary<int, FEventHandler> m_FEventDict;

	private Dictionary<int, UUEventHandler> m_UUEventDict;

	private Dictionary<int, IEventHandler> m_IEventDict;

	private Dictionary<int, IIEventHandler> m_IIEventDict;

	private Dictionary<int, GEventHandler> m_GEventDict;

	private static object[] commonParam;

	public virtual void ClearTargetTypeEventHandler<T>()
	{
	}

	private void ClearTargetTypeHandler<T, Target>(Dictionary<int, T> handlerListDict, Action<int, Delegate> doRmove = null)
	{
	}

	public virtual void DispatchEventFraming(EventID eventID, object[] data)
	{
	}

	public virtual void DispatchEvent(EventID eventID, object[] data)
	{
	}

	public virtual void DispatchEventSample(EventID eventID, object[] data)
	{
	}

	public virtual void DispatchVEvent(EventID eventID)
	{
	}

	public virtual void DispatchFEvent(EventID eventID, float data)
	{
	}

	public virtual void DispatchGEvent(EventID eventID, GEvent data)
	{
	}

	public virtual void DispatchBEvent(EventID eventID, bool data)
	{
	}

	public virtual void DispatchUEvent(EventID eventID, uint data)
	{
	}

	public virtual void DispatchUlEvent(EventID eventId, ulong data)
	{
	}

	public virtual void DispatchUEvent(EventID eventID, uint data0, uint data1)
	{
	}

	public virtual void DispatchIEvent(EventID eventID, int data)
	{
	}

	public virtual void DispatchIIEvent(EventID eventID, int data0, int data1)
	{
	}

	public virtual void RegisterEvent(EventID eventID, EventHandler eventHandler)
	{
	}

	public virtual void RegisterVEvent(EventID eventID, VEventHandler eventHandler)
	{
	}

	public virtual void RegisterFEvent(EventID eventID, FEventHandler eventHandler)
	{
	}

	public virtual void RegisterEvent(EventID eventID, BEventHandler eventHandler)
	{
	}

	public virtual void RegisterEvent(EventID eventID, GEventHandler eventHandler)
	{
	}

	public virtual void RegisterEvent(EventID eventID, UEventHandler eventHandler)
	{
	}

	public virtual void RegisterEvent(EventID eventID, UlEventHandler eventHandler)
	{
	}

	public virtual void RegisterEvent(EventID eventID, UUEventHandler eventHandler)
	{
	}

	public virtual void RegisterEvent(EventID eventID, IEventHandler eventHandler)
	{
	}

	public virtual void RegisterEvent(EventID eventID, IIEventHandler eventHandler)
	{
	}

	public virtual void UnRegisterEvent(EventID eventID, EventHandler eventHandler)
	{
	}

	public virtual void UnRegisterFEvent(EventID eventID, FEventHandler eventHandler)
	{
	}

	public virtual void UnRegisterVEvent(EventID eventID, VEventHandler eventHandler)
	{
	}

	public virtual void UnRegisterEvent(EventID eventID, BEventHandler eventHandler)
	{
	}

	public virtual void UnRegisterEvent(EventID eventID, UEventHandler eventHandler)
	{
	}

	public virtual void UnRegisterEvent(EventID eventID, UlEventHandler eventHandler)
	{
	}

	public virtual void UnRegisterEvent(EventID eventID, UUEventHandler eventHandler)
	{
	}

	public virtual void UnRegisterEvent(EventID eventID, IEventHandler eventHandler)
	{
	}

	public virtual void UnRegisterEvent(EventID eventID, IIEventHandler eventHandler)
	{
	}

	public virtual void UnRegisterEvent(EventID eventID, GEventHandler eventHandler)
	{
	}

	public virtual void UnRegisterGEvent(EventID eventID, GEventHandler eventHandler)
	{
	}

	private void _003CClearTargetTypeEventHandler_003Eb__22_0<T>(int id, Delegate handler)
	{
	}

	private void _003CClearTargetTypeEventHandler_003Eb__22_1<T>(int id, Delegate handler)
	{
	}

	private void _003CClearTargetTypeEventHandler_003Eb__22_2<T>(int id, Delegate handler)
	{
	}

	private void _003CClearTargetTypeEventHandler_003Eb__22_3<T>(int id, Delegate handler)
	{
	}

	private void _003CClearTargetTypeEventHandler_003Eb__22_4<T>(int id, Delegate handler)
	{
	}

	private void _003CClearTargetTypeEventHandler_003Eb__22_5<T>(int id, Delegate handler)
	{
	}

	private void _003CClearTargetTypeEventHandler_003Eb__22_6<T>(int id, Delegate handler)
	{
	}

	private void _003CClearTargetTypeEventHandler_003Eb__22_7<T>(int id, Delegate handler)
	{
	}

	private void _003CClearTargetTypeEventHandler_003Eb__22_8<T>(int id, Delegate handler)
	{
	}

	private void _003CClearTargetTypeEventHandler_003Eb__22_9<T>(int id, Delegate handler)
	{
	}
}
