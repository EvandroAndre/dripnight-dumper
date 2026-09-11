using System.Collections.Generic;

namespace COW;

public class UGCHudWidgetAttributeConfig
{
	protected Dictionary<int, List<int>> m_AttributesConfig;

	private List<int> m_HeadAttributes;

	private List<int> m_TransformAttributes;

	public Dictionary<int, List<int>> AttributesConfig => null;

	protected virtual void AddAttributesConfig()
	{
	}
}
