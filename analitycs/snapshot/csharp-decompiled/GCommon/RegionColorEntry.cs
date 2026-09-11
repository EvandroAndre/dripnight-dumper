using System;
using UnityEngine;

namespace GCommon;

[Serializable]
public struct RegionColorEntry(Color32 color, byte id)
{
	public byte r = 0;

	public byte g = 0;

	public byte b = 0;

	public byte regionID = 0;

	public Color32 ToColor32()
	{
		return default(Color32);
	}
}
