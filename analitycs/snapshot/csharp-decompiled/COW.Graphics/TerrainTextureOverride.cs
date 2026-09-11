using UnityEngine;

namespace COW.Graphics;

public class TerrainTextureOverride : MonoBehaviour
{
	public string[] textureNames;

	public string[] texturePaths;

	public string[] textureHDPaths;

	public string[] textureSnowPaths;

	private Material sharedMat;

	private MeshRenderer renderer;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void ApplyOverrideHDTextures()
	{
	}

	private void ApplyOverrideSnowTextures()
	{
	}

	public void ApplyOverrideHDSnowTextures()
	{
	}

	private void ApplyOriginalTextures()
	{
	}

	private void SetOverrideTextures(string[] overrideTexPaths)
	{
	}
}
