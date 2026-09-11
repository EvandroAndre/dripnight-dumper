using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIFlyObjectUtil : SingletonModule<UIFlyObjectUtil>
{
	private Dictionary<string, Type> m_stringTypeMap;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void PreGetTypeAndPreloadUI()
	{
	}

	public void PreloadForNinthWeaponAwake()
	{
	}

	public Type GetTypeByName(string name)
	{
		return null;
	}
}
