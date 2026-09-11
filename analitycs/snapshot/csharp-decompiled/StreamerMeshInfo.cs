using UnityEngine;

public class StreamerMeshInfo : StreamerObjectRefInfo
{
	public uint MeshIndex;

	public Mesh OwnedMesh;

	public override void UnLoadAsset(SceneStreamerInfoHelper helper)
	{
	}
}
