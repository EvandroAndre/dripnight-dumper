using UnityEngine;

namespace COW.Gameplay;

public class LevelObjectIceSculptureTransitionModel : MonoBehaviour
{
	public GameObject CanUseLoopVFX;

	public GameObject TransitionVFX;

	public Renderer TransitionRenderer;

	public float TransitionMaterialOffsetYBegin;

	public float TransitionMaterialOffsetYEnd;

	public string TransitionOffsetProperty;

	private int TransitionOffsetPropertyID;

	private bool TestDebug;

	private float m_lastProgress;

	public void Awake()
	{
	}

	public void UpdateProgress(float progress)
	{
	}

	private void SetProgress(float progress)
	{
	}
}
