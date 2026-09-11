using System;
using UnityEngine;

namespace COW.Graphics;

[Serializable]
public class UGCDrawingSettings
{
	public float pencilSize;

	public float pencilCorrection;

	public Color pencilColor;

	public Color paperColor;

	public float cornerLose;

	public Texture2D paperTex;
}
