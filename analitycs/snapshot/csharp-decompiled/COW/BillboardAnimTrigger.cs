using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class BillboardAnimTrigger : MonoBehaviour
{
	public Transform[] SpawnAnimPrefabPos;

	private bool HadTrigger;

	private List<GameObject> m_CacheGo;

	private ResourceID m_ResId;

	public void OnLocalPlayerEnter()
	{
	}

	private void DelayDestroy()
	{
	}

	private void _003CDelayDestroy_003Eb__5_0()
	{
	}
}
