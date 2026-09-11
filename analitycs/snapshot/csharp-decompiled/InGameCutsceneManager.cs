using System;
using System.Collections.Generic;
using UnityEngine;

public class InGameCutsceneManager : MonoBehaviour
{
	public List<InGameCutscene> m_CutsceneList;

	private Transform KeepInSceneRoot;

	public Action m_CurFinishCallBack;

	public int m_CurCutsceneIndex;

	protected void Awake()
	{
	}

	public void Start()
	{
	}

	private void RegisterToMatchGame()
	{
	}

	public virtual bool PlayCutscene(int index, Action OnCutsceneFinished = null)
	{
		return false;
	}

	public bool PlayCutscene(int index, Vector3 pos, Quaternion rot, Action OnCutsceneFinished = null)
	{
		return false;
	}

	public void StopCutscene(bool isCallFinishCallback = true)
	{
	}

	public virtual void ProcessCustsceneFinishOrStoped(InGameCutscene FinishedCutscene)
	{
	}

	public virtual void OnCutsceneFinish(InGameCutscene FinishedCutscene)
	{
	}

	public InGameCutscene LoadCutsceneAnimPrfeb(int beginIndex, int endIndex)
	{
		return null;
	}

	public void PlayCutsceneSound(int beginIndex, int endIndex)
	{
	}
}
