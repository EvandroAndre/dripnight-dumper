using UnityEngine;

namespace COW;

public class UISparkPetSocialAreaLightAdjuster : MonoBehaviour
{
	private const string CHARA_LIGHT_INTENSITY_PROP = "_CharaLightIntensity";

	public Light m_TargetLight;

	public float m_MinSceneGraphicFactor;

	private bool m_HasCachedOriginal;

	private float m_OriginalIntensity;

	public void ApplyForSocialArea()
	{
	}

	public void RestoreOriginal()
	{
	}

	private float GetSceneGraphicFactor()
	{
		return 0f;
	}
}
