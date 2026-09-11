using GCommon;
using UnityEngine;

namespace COW;

public class NewSightHelper : MonoBehaviour
{
	public UISprite m_SightSpriteUp;

	public UISprite m_SightSpriteDown;

	public UISprite m_SightSpriteLeft;

	public UISprite m_SightSpriteRight;

	private float m_BaseDiffusionDistance;

	private Vector3 m_SightSpriteUpOriginalPos;

	private Vector3 m_SightSpriteDownOriginalPos;

	private Vector3 m_SightSpriteLeftOriginalPos;

	private Vector3 m_SightSpriteRightOriginalPos;

	private void Awake()
	{
	}

	public void SetSightBaseDiffusionDistance(float baseDiffusionDistance)
	{
	}

	public void SetSightDiffusionIcon(ResourceID depressIcon)
	{
	}

	public void SetSightDiffusionRate(float diffusionRate)
	{
	}
}
