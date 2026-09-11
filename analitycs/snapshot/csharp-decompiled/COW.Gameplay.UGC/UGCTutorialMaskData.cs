using System;
using LitJson;

namespace COW.Gameplay.UGC;

[Serializable]
public class UGCTutorialMaskData
{
	public JsonData param;

	private bool m_TypedParamResolved;

	private object m_CachedTypedParam;

	public object GetTypedParam()
	{
		return null;
	}
}
