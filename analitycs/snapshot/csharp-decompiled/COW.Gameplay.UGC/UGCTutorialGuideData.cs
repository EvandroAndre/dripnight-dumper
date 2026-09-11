using System;
using System.Collections.Generic;
using LitJson;

namespace COW.Gameplay.UGC;

[Serializable]
public class UGCTutorialGuideData
{
	public string guideType;

	public string guideId;

	public List<UGCTutorialDialogueData> dialogues;

	public JsonData param;

	private bool m_TypedParamResolved;

	private object m_CachedTypedParam;

	public object GetTypedParam()
	{
		return null;
	}

	public bool GetBoolParam(string fieldValue, bool defaultValue)
	{
		return false;
	}

	public float GetFloatParam(string fieldValue, float defaultValue)
	{
		return 0f;
	}
}
