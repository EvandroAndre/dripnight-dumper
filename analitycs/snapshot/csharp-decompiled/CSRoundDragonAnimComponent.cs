using UnityEngine;

public class CSRoundDragonAnimComponent : MonoBehaviour
{
	public Animation BodyAnimation;

	public Animation AirDropAnimation;

	public AnimationClip BodyAnimation_Idle;

	public AnimationClip AirDropAnimation_Idle;

	public AnimationClip BodyAnimation_Dead;

	public AnimationClip AirDropAnimation_Dead;

	public GameObject TeleportContainer;

	public SkinnedMeshRenderer m_BodyRenderer;

	public Material m_BodyOriginalMaterial;

	public Material m_BodyDissolveMaterial;

	public GameObject FireCollider;

	public bool End;

	private bool m_KeepBody;

	private float m_ShowDelayTime;

	private float m_HideDelayTime;

	private uint m_VFXUniqueID;

	private int _DissolveAmountID;

	private int DissolveAmountID => 0;

	public void OnDragonStarted()
	{
	}

	public void OnDragonDead()
	{
	}

	private void Update()
	{
	}
}
