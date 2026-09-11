using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCEventBus
{
	private UGCRuntime ugcRuntime;

	private EntityIndex entityIndex;

	private Dictionary<long, List<UGCEventVariadicHandle>> registerHandlers;

	private Dictionary<long, int> dispatchEventCountPerFrame;

	private int dispatchEventMaxCountPerFrame;

	private int distpatchCnt;

	private Dictionary<long, List<UGCEventVariadicHandle>> removedHandlers;

	public UGCEventBus Create(UGCRuntime ugcRuntime, EntityIndex entityIndex)
	{
		return null;
	}

	public void OnTick()
	{
	}

	public void RegisterHandler(long eventType, UGCEventVariadicHandle handler)
	{
	}

	private void DispatchHandler(long eventType, List<UGCSimpleValue> args, bool back2Pool)
	{
	}

	private void ClearUpRemovedEvent()
	{
	}

	public bool Dispatch2Server(long eventType, object[] args)
	{
		return false;
	}

	public void UnRegisterHandler(long eventType, UGCEventVariadicHandle handler)
	{
	}

	private void RemoveHandler(long eventType, UGCEventVariadicHandle handler)
	{
	}

	public void DispatchHandler(long eventType, UGCLogicEntity entity, Vector2 delta)
	{
	}

	public void DispatchHandler(long eventType, long propID, UGCSimpleValue propValue)
	{
	}

	public void DispatchHandler(long eventType, UGCLogicEntity entity, Vector2 position, Vector2 delta)
	{
	}

	public void DispatchHandler(long eventType, object[] args = null)
	{
	}

	internal void DispatchHandler(long eventType, List<AJFJEGOPEPP> paramsList)
	{
	}

	public void DispatchHandler(long eventType, List<UGCSimpleValue> args)
	{
	}
}
