using System;
using System.Collections.Generic;
using UnityEngine;

public class VFXColoring : MonoBehaviour
{
	[Serializable]
	public class VFXColoringSetting
	{
		public string Name;

		public List<float> RenderersWeight;

		public Color Highlights;

		public Color Midtones;

		public Color Shadows;
	}

	public int SettingsIndex;

	public List<VFXColoringSetting> ColoringSettings;

	public List<Renderer> RenderersScanned;

	public List<Renderer> Renderers;

	public List<int> RenderersChildLayer;

	public List<bool> RenderersChildFold;

	public bool _NULL_RenderersFold;

	public bool _NULL_ColoringFold;

	private static int ColorId;

	private static int TintId;

	private static int ColorTexId;

	private static bool propIdsReady;

	private static void EnsurePropIds()
	{
	}

	public void ApplySettings(int index)
	{
	}

	public void ChangeMaterialColors()
	{
	}
}
