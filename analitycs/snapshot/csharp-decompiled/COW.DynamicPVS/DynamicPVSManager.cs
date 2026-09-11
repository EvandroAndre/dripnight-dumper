using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.DynamicPVS;

public class DynamicPVSManager : MonoSingleton<DynamicPVSManager>
{
	public static uint InvalidTicket;

	private const string BINARY_VERSION = "version";

	private const string BINARY_AREA_BOUNDS = "-1";

	private Deserializer m_Deserializer;

	private Indexer m_Indexer;

	private SerializeData m_SerializeData;

	private Transform m_Target;

	private Dictionary<int, Bounds> m_AreaBounds;

	private Vector3 m_LastTargetPos;

	private int m_CurAreaID;

	private Queue<DynamicPVSEventHandler> m_HandlerPool;

	private Dictionary<uint, DynamicPVSEventHandler> m_Handlers;

	private uint m_InternalTicket;

	public static bool EnablePVS(string sceneName)
	{
		return false;
	}

	public bool InitData(string sceneName)
	{
		return false;
	}

	public void Clear()
	{
	}

	protected override void OnDestroy()
	{
	}

	private bool InitVersion()
	{
		return false;
	}

	private bool InitAreaBounds()
	{
		return false;
	}

	public void SetTarget(Transform target)
	{
	}

	public DynamicPVSEventHandler GetHandlerFromPool()
	{
		return null;
	}

	public void ReturnHandlerToPool(DynamicPVSEventHandler handler)
	{
	}

	public uint Register(Transform root, Action<bool> callBack, Vector3 size = default(Vector3), DynamicPVSType type = DynamicPVSType.DontMoveSelf, float ignoreGroundHeight = 0f, float boundsCenterOffset = 0f)
	{
		return 0u;
	}

	public void UnRegister(uint ticket)
	{
	}

	public bool IsPositionVisible(Vector3 position)
	{
		return false;
	}

	public bool IsBoundsVisible(Bounds bounds)
	{
		return false;
	}

	private bool CheakAreas()
	{
		return false;
	}

	private void OnLoadAreaDataFinish(byte[] bytes)
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
