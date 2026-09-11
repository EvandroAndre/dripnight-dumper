using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ABSceneLightMapInfo
{
	public static readonly List<ABSceneLightMapInfo> EmptyList;

	public int m_id;

	public Vector4 m_offset;

	public ABSceneLightMapInfo(int id, Vector4 offset)
	{
	}
}
