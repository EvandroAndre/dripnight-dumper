using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCAnimPlayable : MonoBehaviour
{
	public Animator animator;

	private bool m_isCreated;

	public UGCAnimPlayable_Simple m_simpleAnim;

	private UGCAnimPlayableUnityWrap m_untiyWrap;

	private int m_animatorControllerDirtyCount;

	private Animator newAnimator;

	public UGCAnimPlayableUnityWrap UnityPlayableWrap => null;

	public void StopAll()
	{
	}

	private void attachAnimator()
	{
	}

	public void Init()
	{
	}

	public void RefreshOriginAnimatorController(Animator anim)
	{
	}

	public void RefreshOriginAnimatorControllerImpl(Animator anim)
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}
}
