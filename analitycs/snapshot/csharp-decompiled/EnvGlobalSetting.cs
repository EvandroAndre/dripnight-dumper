using System;
using UnityEngine;

[Serializable]
public class EnvGlobalSetting
{
	public Vector3 eulerAngles;

	public Color lightColor;

	public float lightIntensity;

	public float darkness;

	public float shadowStrength;

	public float terrainWetness;

	public float lensFlare;

	public float emissiveStrength;

	public int fogStartDistance;

	public int fogEndDistance;

	public bool enableUGCFogFeature;

	public bool fogEnable;

	public FogMode fogMode;

	public float fogDensity;

	public bool enableUGCLightRotateFeature;

	public Quaternion mainLightRotate;

	public Color fogColor;

	public Color waterFogColor;

	public Color ambientColor;

	public bool nightMode;

	public Cubemap skyCubemap;

	public bool controlCloud;

	public bool cloudFadeIn;

	public void CopyTo(EnvGlobalSetting to)
	{
	}
}
