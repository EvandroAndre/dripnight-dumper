using System;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class SpawnPool
{
	private class AsyncRequest
	{
		public bool Completed;

		public bool Successed;

		public UnityEngine.Object ResObj;

		public uint Ticket;

		public Transform Parent;

		public int Count;

		public bool IsForInit;

		public UnityEngine.Object CachedObject;

		public Action<uint, bool, UnityEngine.Object> Callback;

		public bool IsInPool;
	}

	private Queue<UnityEngine.Object> m_FreeList;

	private GameObject m_Parent;

	private ResourceID m_resID;

	private Vector3 m_ResourceOrgScale;

	private List<UnityEngine.Object> m_ActiveList;

	private uint m_LimitMaxPoolSize;

	private uint m_LimitRecyleSize;

	private bool m_RestartEffect;

	private Action<uint, bool, UnityEngine.Object> m_CachedHandleNewObject;

	public const uint InvalidTicket = 0u;

	private static uint ticketGen;

	public static bool OptAsyncGc;

	private Dictionary<uint, AsyncRequest> mAsyncPreloadRequestDict;

	private List<AsyncRequest> mAsyncPreloadRequestDictToRemove;

	private Dictionary<uint, AsyncRequest> mAsyncRequestDict;

	private Dictionary<uint, AsyncRequest> mAsyncRequestDictCached;

	private Dictionary<uint, AsyncRequest> mAsyncRequestDictCachedToRemove;

	private uint mCurAsyncResLoadTicket;

	private ResourceManager.LoadPriority mLoadPriority;

	private static readonly List<AsyncRequest> s_AsyncRequestPool;

	private static readonly List<Dictionary<uint, AsyncRequest>> s_AsyncDicPool;

	public static uint NewTicket => 0u;

	public SpawnPool(GameObject parent, ResourceID id)
	{
	}

	public void InitPool(int num, uint maxSize = 0u, uint recyleSize = 0u)
	{
	}

	public UnityEngine.Object GetRes(Transform parentTrans, bool enableHighResFallback = false)
	{
		return null;
	}

	private void HandleObject(bool isNew, UnityEngine.Object obj, Transform parentTrans)
	{
	}

	public static void ResetTicketGen()
	{
	}

	public static void ClearStatics()
	{
	}

	private static void RecycleRequest(AsyncRequest request)
	{
	}

	private static AsyncRequest GetAsyncRequest()
	{
		return null;
	}

	private static Dictionary<uint, AsyncRequest> GetAsyncDic()
	{
		return null;
	}

	private static void RecycleAsyncDic(ref Dictionary<uint, AsyncRequest> dic)
	{
	}

	public bool InitPoolAsync(int num, uint maxSize = 0u, uint recyleSize = 0u, bool isPreload = false, ResourceManager.LoadPriority loadPriority = ResourceManager.LoadPriority.Low)
	{
		return false;
	}

	public void SetLimitMaxPoolSize(uint maxSize, bool restart = true)
	{
	}

	private bool UseActiveList()
	{
		return false;
	}

	public uint GetResAsync(Action<uint, bool, UnityEngine.Object> callback, Transform parentTrans, ResourceManager.LoadPriority loadPriority = ResourceManager.LoadPriority.Normal, bool enableHighResFallback = false)
	{
		return 0u;
	}

	public void UpdateCachedAsyncRequests(FTimer m_FrameTimer)
	{
	}

	public void CancelResAsyncLoading(uint ticket)
	{
	}

	public void CancelAllResAsyncLoading()
	{
	}

	private void ProcessReq(AsyncRequest req, FTimer frameTimer)
	{
	}

	private void HandleNewObject(uint ticket, bool succeeded, UnityEngine.Object resObj)
	{
	}

	public void RecycleRes(UnityEngine.Object obj, bool worldPositionStays = true)
	{
	}

	public void RemoveActiveAndDestroy(UnityEngine.Object obj)
	{
	}

	public void HandleResEnqueue(UnityEngine.Object obj)
	{
	}

	public void Clear()
	{
	}

	public void Destroy()
	{
	}
}
