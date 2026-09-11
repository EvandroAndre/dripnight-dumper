using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class UIHUDUGC_IconFlyController
{
	private Queue<UIHUDUGC_IconFlyCell> m_CacheFlyObjectPool;

	private List<UIHUDUGC_IconFlyCell> m_RunFlyObject;

	private List<UIHUDUGC_IconFlyCell> m_WaitCacheFlyObject;

	private Transform mParent;

	private uint mRunTimeKey;

	private uint mCacheTimeKey;

	private const int CacheMax = 10;

	public void Init(Transform parent)
	{
	}

	private void Update()
	{
	}

	public void PlayFly(string icon, Color color, Vector3 scale, Vector3 startPos, Vector3 endPos, float flySpeed = 1f)
	{
	}

	private void OnFlyObjEnd(UIHUDUGC_IconFlyCell flyObj)
	{
	}

	private void CheckExcessCache()
	{
	}

	public void Destory()
	{
	}
}
