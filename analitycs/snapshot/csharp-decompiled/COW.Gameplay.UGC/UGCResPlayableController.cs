using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UGCResPlayableController : UGCResource
{
	private AKMBJHOJJGI m_ResData;

	public AKMBJHOJJGI ResData => null;

	public override bool LoadFromData(byte[] data)
	{
		return false;
	}

	public override void OnUnityObjectLoaded(bool isSucc, Object resObject)
	{
	}

	public bool _003C_003EiFixBaseProxy_LoadFromData(byte[] P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUnityObjectLoaded(bool P0, Object P1)
	{
	}
}
