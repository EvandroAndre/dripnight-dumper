using System.Collections.Generic;

namespace COW;

public class UGCHudEmptyAttributeConfig : UGCHudWidgetAttributeConfig
{
	public static UGCHudEmptyAttributeConfig Instance;

	private List<int> m_EmptyAttributes;

	protected override void AddAttributesConfig()
	{
	}

	public void _003C_003EiFixBaseProxy_AddAttributesConfig()
	{
	}
}
