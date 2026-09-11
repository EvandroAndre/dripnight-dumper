using System.Collections.Generic;
using UnityEngine;

public class SceneExtensionInfoExtData : MonoBehaviour
{
	public bool version2018;

	public int lightmapNum;

	public List<LightmapAreaInfo> areaLightmaps;

	public string replaceLabel;

	public int lightMapOffset;

	public int lightMapLength;

	public int lightMapTotal;

	private bool init;

	private bool skipFile;

	private const float shadowOnlyScale = 0.01f;

	private void Start()
	{
	}

	public void RefreshLightmapNum()
	{
	}

	public void MergeToMainScene(bool forceUpdate = false)
	{
	}

	public void RemoveFromMainScene(bool forceUpdate = false)
	{
	}

	private void initReplaceSceneLightMapInfo()
	{
	}

	private void initReplaceSceneLightMapNoInStreamerTexture()
	{
	}

	private void initLMSettingForOverlay()
	{
	}
}
