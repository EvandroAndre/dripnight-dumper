using GCommon;
using UnityEngine;

public class PlayerSoundAndEffectTrigger : MonoBehaviour
{
	public string SoundResID;

	public string EffectResID;

	public bool OnlyLocalPlayer;

	private ResourceID m_SoundResID;

	private ResourceID m_EffectResID;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
