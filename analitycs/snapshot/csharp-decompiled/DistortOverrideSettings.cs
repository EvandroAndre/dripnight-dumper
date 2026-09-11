using System;
using COW.Graphics;

[Serializable]
public class DistortOverrideSettings
{
	public BoolParameter DistortEnable;

	public FloatParameter distortX;

	public FloatParameter distortY;

	public Vector2Parameter distortPanner;

	public TextureParameter distortTexture;

	public void DisableAllOverride()
	{
	}
}
