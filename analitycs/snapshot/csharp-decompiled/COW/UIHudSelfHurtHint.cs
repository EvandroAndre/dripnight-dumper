using COW.GamePlay;
using UnityEngine;

namespace COW;

internal class UIHudSelfHurtHint : MonoBehaviour
{
	public UISprite HitImg;

	public UISprite IconImg;

	private Transform m_HightPosHint;

	private UILabel m_HightPosHintTxt;

	private TweenAlpha hitImgTween;

	private TweenAlpha iconImgTween;

	private Transform CachedTransform;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	public void SetHitColor(Color color)
	{
	}

	public void SetLocalRotation(Quaternion quaternion)
	{
	}

	public void ResetToPlay(Vector3 scale)
	{
	}

	public void ShowHighPosHint(AttackableEntity enemy)
	{
	}

	private void KeepHighPosHintRotation()
	{
	}
}
