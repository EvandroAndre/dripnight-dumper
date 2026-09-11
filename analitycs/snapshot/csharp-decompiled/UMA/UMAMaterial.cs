using System;
using UnityEngine;

namespace UMA;

public class UMAMaterial : ScriptableObject
{
	public enum MaskType
	{
		None,
		UseSkin,
		ColorMask
	}

	public enum MaterialType
	{
		Atlas = 1,
		NoAtlas
	}

	public enum ChannelType
	{
		Texture,
		NormalMap,
		MaterialColor,
		TintedTexture,
		DiffuseTexture
	}

	[Serializable]
	public class MaterialChannel
	{
		public ChannelType channelType;

		public RenderTextureFormat textureFormat;

		public string materialPropertyName;

		[NonSerialized]
		private int _materialPropertyID;

		public int materialPropertyID => 0;
	}

	public Material material;

	public MaterialType materialType;

	public bool useSkin;

	public MaskType maskType;

	public MaterialChannel[] channels;

	[NonSerialized]
	private bool validated;

	private void OnEnable()
	{
	}

	public bool Equals(UMAMaterial material)
	{
		return false;
	}

	public bool ValidateChannels()
	{
		return false;
	}

	private bool DoValidateChannels()
	{
		return false;
	}
}
