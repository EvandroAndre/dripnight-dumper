using System.Collections.Generic;
using System.Text;

namespace GCommon;

public class StringCacheManager : SingletonModule<StringCacheManager>
{
	private List<string> m_CachedStringList;

	private List<string> m_CachedPercentStringList;

	private StringBuilder m_stringbuilder;

	protected override void OnInit()
	{
	}

	private int GetInitCachedStringCount()
	{
		return 0;
	}

	protected override void OnCleanup()
	{
	}

	public string GetNumberString(uint num)
	{
		return null;
	}

	public string GetNumberString(int num)
	{
		return null;
	}

	public string GetNumberPercentString(uint num)
	{
		return null;
	}

	public string GetNumberPercentString(int num)
	{
		return null;
	}
}
