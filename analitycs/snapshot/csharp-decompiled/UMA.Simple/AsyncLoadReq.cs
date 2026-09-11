using System;
using UnityEngine;

namespace UMA.Simple;

public class AsyncLoadReq : IGetSetIndex
{
	private int _003CIndex_003Ek__BackingField;

	public bool IsSlot;

	public int Hash;

	public int Param;

	public uint Ticket;

	public bool Cache;

	public Action<uint, UnityEngine.Object, AsyncLoadReq> Callback;

	public Action<UnityEngine.Object, uint> CallbackAssetTicket;

	public Action<UnityEngine.Object, uint, int> CallbackAssetTicketParam;

	public int Index
	{
		get
		{
			return _003CIndex_003Ek__BackingField;
		}
		set
		{
			_003CIndex_003Ek__BackingField = value;
		}
	}

	public void OnAsyncCallback(uint ticket, bool success, UnityEngine.Object asset)
	{
	}

	public void InvokeCallback(UnityEngine.Object t)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
