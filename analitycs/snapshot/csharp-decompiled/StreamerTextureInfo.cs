using UnityEngine;

public class StreamerTextureInfo : StreamerObjectRefInfo
{
	public uint TextureIndex;

	public Texture OwnedTexture;

	public override void UnLoadAsset(SceneStreamerInfoHelper helper)
	{
	}
}
