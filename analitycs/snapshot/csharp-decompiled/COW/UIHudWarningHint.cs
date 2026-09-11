using COW.GamePlay;
using UnityEngine;

namespace COW;

internal class UIHudWarningHint : MonoBehaviour
{
	public UISprite m_NearArc;

	public UISprite m_NearIcon;

	public UISprite m_FarArc;

	public UISprite m_FarIcon;

	private BHGGAEEHJCO m_TargetPlayer;

	private WarningHintData m_hintData;

	private float m_distance;

	private float m_ExpireTime;

	private bool m_LongLast;

	private bool m_PosFixed;

	private bool m_NeedCalDelta;

	private bool m_IsFireAndNoBlood;

	private bool m_IconFixRotation;

	public bool PosFixed => false;

	public float ExpireTime => 0f;

	public int Priority => 0;

	public int HintType => 0;

	public BHGGAEEHJCO TargePlayer => default(BHGGAEEHJCO);

	public bool LongLast => false;

	public bool IconFixRotation => false;

	public void SetInfo(BHGGAEEHJCO player, WarningHintData hinData, float distance, bool longLast, bool posFixed = false, bool needCalDelta = false, bool isFireAndNoBlood = false, bool iconFixRotation = false)
	{
	}

	public void ResetExpireTime()
	{
	}

	public void UpdateStatus(float distance)
	{
	}

	public void SetLocalRotation(Quaternion quaternion)
	{
	}
}
