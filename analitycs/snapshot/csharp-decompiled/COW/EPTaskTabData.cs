using System;
using System.Collections.Generic;

namespace COW;

public class EPTaskTabData
{
	public EEPTaskTab m_Tab;

	public string m_TabKey;

	public ETipsType m_RedDot;

	public Action m_OnSelectTab;

	public List<int> m_SubTabs;
}
