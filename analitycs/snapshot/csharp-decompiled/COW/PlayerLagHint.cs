using COW.GamePlay;
using COW.Graphics;
using GCommon;
using UnityEngine;

namespace COW;

public class PlayerLagHint : MonoBehaviour
{
	public GameObject HintObj;

	public MultiBillboard MultiBillboard;

	public float MaxScale;

	public float KeepScaleDistance;

	public float MaxScaleDistance;

	public float MaxShowDistance;

	public float Radius;

	private Player m_BindPlayer;

	private bool m_ShowEffect;

	private float m_ShowEffectTime;

	private Vector3 m_HintCacheScale;

	private GameObject m_Target;

	private bool m_KeepEffectWaitLagStateChange;

	private BitArrayBoolean m_HintObjIsVisible;

	private const uint ISVISIBLE_BINDPLAYERVISIBLE = 1u;

	private const uint ISVISIBLE_BINDPLAYERISLAG = 2u;

	private void Start()
	{
	}

	public void BindPlayer(BHGGAEEHJCO playerID)
	{
	}

	public void BindPlayerVisibleChange(bool visible)
	{
	}

	public void PlayerLagStateChange(bool isLag)
	{
	}

	private void Update()
	{
	}

	private void RefreshHintObjVisible()
	{
	}

	private void BetweenTwoTarget()
	{
	}

	private void KeepScale()
	{
	}
}
