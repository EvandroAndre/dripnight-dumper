using UnityEngine;

namespace COW;

public class InGameHPDamageEffect : MonoBehaviour
{
	public UISprite m_HpDamage;

	private float m_StartFillAmout;

	private float m_EndFillAmount;

	public float ShrinkTime;

	private bool m_IsShrinking;

	private float m_ShrinkLeftTime;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	public void OnTakeDamage(float startFillAmount, float endFillAmount)
	{
	}

	private void ShrinkHPDamage()
	{
	}

	private void StopShrink()
	{
	}
}
