using UnityEngine;

namespace GCommon;

public class NetworkMaterialInfo
{
	public Vector2 TextureSize;

	public Material TargetMaterial;

	public NetworkMaterialInfo(Material mat, Vector2 size)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
