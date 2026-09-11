using System;
using System.Collections.Generic;
using LitJson;

namespace COW.Gameplay.UGC;

[Serializable]
public class UGCTutorialAtomicTaskData
{
	public string atomicTaskId;

	public string taskType;

	public List<UGCTutorialDialogueData> dialogues;

	public List<UGCTutorialGuideData> guides;

	public UGCTutorialMaskData mask;

	public UGCTutorialRestrictionData restrictions;

	public UGCTutorialCameraPoseData cameraPose;

	public JsonData param;

	private bool m_TypedParamResolved;

	private object m_CachedTypedParam;

	public string autoCompleteMode;

	public UGCTutorialContextRefData outputContext;

	public UGCTutorialContextRefData inputContext;

	public object GetTypedParam()
	{
		return null;
	}

	public UGCTutorialAutoCompleteMode GetAutoCompleteMode()
	{
		return UGCTutorialAutoCompleteMode.None;
	}
}
