using System;
using UnityEngine;

[Serializable]
public class EnvSkybox
{
	public Color tint;

	public float rotation;

	public Texture frontTex;

	public Texture backTex;

	public Texture leftTex;

	public Texture rightTex;

	public Texture upTex;

	public Texture downTex;

	public bool nightMode;

	public void CopyTo(EnvSkybox to)
	{
	}
}
