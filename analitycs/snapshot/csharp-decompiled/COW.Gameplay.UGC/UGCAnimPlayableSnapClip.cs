using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCAnimPlayableSnapClip
{
	public string m_name;

	public float m_time;

	public float m_duration;

	public float m_freezeAfterTime;

	public float m_freezeAnimationTime;

	public float m_weight;

	public WrapMode m_wrapMode;

	public UGCAnimPlayable_State.EFadeStatus m_fadeStatus;

	public float m_fadeSpeed;
}
