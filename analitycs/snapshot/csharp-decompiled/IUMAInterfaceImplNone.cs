using System;
using UnityEngine;

public class IUMAInterfaceImplNone : IUMAInterface
{
	public GameObject GetAssetIndexResource()
	{
		return null;
	}

	public Type GetDynamicAssetLoaderType()
	{
		return null;
	}
}
