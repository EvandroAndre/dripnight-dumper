using UnityEngine;

namespace COW.Graphics;

public class MaterialOverride : MonoBehaviour
{
	public enum MaterialOverrideType
	{
		Type_Snow,
		Type_Sand,
		Type_None
	}

	public MaterialOverrideType type;

	public bool useMultiMaterials;

	public string materialPath;

	public string materialOverridePath;

	public string[] materialPaths;

	public string[] materialOverridePaths;

	private MeshRenderer renderer;

	private void Start()
	{
	}

	public Material ApplyOverrideMaterial()
	{
		return null;
	}

	private Material SetOverrideMaterial(string overrideMatPath)
	{
		return null;
	}

	public Material[] ApplyOverrideMaterials()
	{
		return null;
	}

	private Material[] SetOverrideMaterial(string[] overrideMatPaths)
	{
		return null;
	}
}
