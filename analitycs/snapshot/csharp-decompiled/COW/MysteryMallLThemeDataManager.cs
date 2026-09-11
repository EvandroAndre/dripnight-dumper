using System.Collections.Generic;
using GCommon;

namespace COW;

public class MysteryMallLThemeDataManager : SingletonModule<MysteryMallLThemeDataManager>
{
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public int themeType;

		internal bool _003CGetThemeData_003Eb__0(MysteryMallLuckyDrawThemeData value)
		{
			return false;
		}
	}

	private List<MysteryMallLuckyDrawThemeData> m_ThemeDataList;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public MysteryMallLuckyDrawThemeData GetThemeData(int themeType)
	{
		return null;
	}
}
