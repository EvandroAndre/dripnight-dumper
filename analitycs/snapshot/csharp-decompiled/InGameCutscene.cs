using System.Collections.Generic;
using UnityEngine;

public class InGameCutscene : MonoBehaviour
{
	public delegate void OnFinished(InGameCutscene cutscene);

	public bool IsLoop;

	public float m_TotalTime;

	public Animator TimeLineAnimator;

	public bool IsUseCutsceneCamera;

	public bool m_IsHideHUD;

	public GameObject m_AnimPrefab;

	public bool m_IsFinishDestory;

	public List<GameObject> m_GameObjectKeepInScene;

	public List<BlackMaskConfig> m_BlackMaskConfig;

	public string AnimPrefebResourceID;

	public string SoundResourceID;

	public OnFinished deleg_OnFinished;

	private bool m_HasBegun;

	private float m_BeginPlayTime;

	private UICutsceneBlackMask m_BlackMaskUI;

	private int curBlackMaskIndex;

	private void Awake()
	{
	}

	public void LoadAnimPrefeb()
	{
	}

	public void PlaySound()
	{
	}

	public void UnLoadAnimPrefeb()
	{
	}

	private void OnDestroy()
	{
	}

	public void PlayCutscene()
	{
	}

	private void ReCalculateCutsceneTime()
	{
	}

	public void OnCutsceneFinish()
	{
	}

	public void StopCutscene()
	{
	}

	private void Update()
	{
	}

	private void OnCutsceneBegin()
	{
	}

	private void NotifyLocalplayerInCutscene(bool isInCutscene)
	{
	}

	public virtual void UpdateBlackMask()
	{
	}
}
