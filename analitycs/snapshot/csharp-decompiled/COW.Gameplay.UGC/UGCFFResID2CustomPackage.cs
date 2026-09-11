using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCFFResID2CustomPackage : UGCICodeResourcePackage
{
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public UGCResource ugcResource;

		public Action<bool, UGCResource> callback;

		internal void _003CLoadToUGCResourceByUUID_003Eb__0(uint tid, bool ret, UnityEngine.Object ffRes)
		{
		}
	}

	protected Dictionary<string, ResourceID> m_resUUID2ResourceID;

	public override bool IsHaveResource(string uuid)
	{
		return false;
	}

	public override bool LoadToUGCResourceByUUID(string uuid, UGCResource ugcResource, Action<bool, UGCResource> callback)
	{
		return false;
	}

	protected void add(UGCResourcePackage pck, string resUUID, ResourceID resID)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsHaveResource(string P0)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_LoadToUGCResourceByUUID(string P0, UGCResource P1, Action<bool, UGCResource> P2)
	{
		return false;
	}
}
