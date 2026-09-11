using GCommon;
using UnityEngine;

namespace COW;

internal class CommonMeshEffect : ReusableObject, IPausable, IInGameReloadSelfControlledEntity
{
	public float DelayDestoryTime;

	private bool m_Paused;

	private float m_GivenDelayDestoryTime;

	private float m_StartTime;

	private float m_UpdateTime;

	private Animation[] m_Animations;

	private Animator[] m_Animators;

	private void Start()
	{
	}

	public override void Prepare()
	{
	}

	public void SetDelayDestoryTime(float t)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	protected override void DoRecycle()
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public void OnUnInitInGameReload()
	{
	}

	public void _003C_003EiFixBaseProxy_Prepare()
	{
	}

	public void _003C_003EiFixBaseProxy_DoRecycle()
	{
	}
}
