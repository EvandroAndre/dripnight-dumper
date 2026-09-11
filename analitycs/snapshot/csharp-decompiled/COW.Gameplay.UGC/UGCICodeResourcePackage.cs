using System;

namespace COW.Gameplay.UGC;

public class UGCICodeResourcePackage
{
	public virtual bool IsHaveResource(string uuid)
	{
		return false;
	}

	public virtual bool LoadToUGCResourceByUUID(string uuid, UGCResource ugcResource, Action<bool, UGCResource> callback)
	{
		return false;
	}
}
