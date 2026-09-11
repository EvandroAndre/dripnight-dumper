using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.Graphics;

public class TextureOverride : MonoBehaviour
{
	public enum TextureOverrideType
	{
		Type_Snow,
		Type_RTShadow,
		Type_HD,
		Type_RegionActivity,
		Type_Count
	}

	[Serializable]
	public class OverrideMode
	{
		public TextureOverrideType type;

		public string sub_type;

		public string[] textureOverridePaths;
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public Dictionary<int, int> type_index_map;

		internal int _003CAwake_003Eb__0(OverrideMode mode_a, OverrideMode mode_b)
		{
			return 0;
		}
	}

	public int materialIndex;

	public string[] textureNames;

	public string[] texturePaths;

	public List<OverrideMode> overrideModeList;

	private MeshRenderer renderer;

	private bool needRegistActivityChanged;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	protected void OnDestroy()
	{
	}

	public bool NeedRegistToSceneGraphics()
	{
		return false;
	}

	public Material GetMaterial()
	{
		return null;
	}

	private void OnActivityChanged()
	{
	}

	public Material ApplyOverrideTextures()
	{
		return null;
	}

	private Material SetOverrideTextures(string[] overrideTexPaths)
	{
		return null;
	}
}
