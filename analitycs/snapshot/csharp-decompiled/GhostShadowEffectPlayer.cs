using System.Collections.Generic;
using UnityEngine;

public class GhostShadowEffectPlayer : MonoBehaviour
{
	public float m_GhostTime;

	public float m_GhostDelta;

	public Shader ghostShader;

	public Color ghostColor;

	public float UseLerpDeltaDistance;

	public float StopLerpDeltaDistance;

	private bool bUseRuntimeDate;

	private float m_RuntimeGhostTime;

	private float m_RuntIMEGhostDelta;

	private List<Renderer> RenderList;

	private List<GhostShadowRoot> myGhostRootList;

	private bool isPlaying;

	private float lastTime;

	private Vector3 LastPostion;

	private Vector3 CurPlayPostion;

	private bool bUsingLerpPostion;

	private int m_SpawnedGhostNum;

	private int m_CurActivedGhostNum;

	private float CurGhostTime => 0f;

	private float CurGhostDelta => 0f;

	public void InitRenderList()
	{
	}

	public void PlayEffect()
	{
	}

	public void StopEffect()
	{
	}

	public void PlayEffectByDate(float ghostTime, float ghostDelta)
	{
	}

	private void PlayInit()
	{
	}

	private void Update()
	{
	}

	private void OnOneRootFinishEffect()
	{
	}

	private void SpawnGhost()
	{
	}

	private void ActiveLastGhost()
	{
	}

	public void DisActiveAllEffect()
	{
	}

	public static int Compare(GhostShadowRoot r1, GhostShadowRoot r2)
	{
		return 0;
	}

	public void OnDestroy()
	{
	}

	public void ClearEffect()
	{
	}
}
