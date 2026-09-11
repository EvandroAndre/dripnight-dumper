using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UGCResBodyPartDef : UGCResource
{
	private EBKANDDGOCK m_data;

	public EBKANDDGOCK DefData => null;

	public override bool LoadFromData(byte[] data)
	{
		return false;
	}

	public override void OnUnityObjectLoaded(bool isSucc, Object resObject)
	{
	}

	public override void ReleaseUnityResRef()
	{
	}

	public bool _003C_003EiFixBaseProxy_LoadFromData(byte[] P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUnityObjectLoaded(bool P0, Object P1)
	{
	}

	public void _003C_003EiFixBaseProxy_ReleaseUnityResRef()
	{
	}
}
