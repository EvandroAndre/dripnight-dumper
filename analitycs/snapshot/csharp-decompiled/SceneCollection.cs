using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SceneCollection : MonoBehaviour
{
	public string prefixName;

	public string prefixScene;

	public string path;

	public string[] names;

	public bool xSplitIs;

	public bool ySplitIs;

	public bool zSplitIs;

	public int xSize;

	public int ySize;

	public int zSize;

	public int xLimitsx;

	public int xLimitsy;

	public int yLimitsx;

	public int yLimitsy;

	public int zLimitsx;

	public int zLimitsy;

	public bool collapsed;

	public int layerNumber;

	public Color color;

	public List<string> replaceLabels;
}
