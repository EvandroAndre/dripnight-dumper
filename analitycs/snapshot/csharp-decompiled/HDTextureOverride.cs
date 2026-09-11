using UnityEngine;

public class HDTextureOverride : MonoBehaviour
{
	public string[] textureNames;

	public string[] texturePaths;

	private Texture2D[] originalTextures;

	private MeshRenderer renderer;

	private void Awake()
	{
	}

	public void SetOverrideTextures()
	{
	}

	public void ResetTextures()
	{
	}
}
