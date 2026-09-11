using System.Collections.Generic;
using GCommon;

namespace COW;

public class LongDigitSeparationDataManager : SingletonModule<LongDigitSeparationDataManager>
{
	public const string DEFAULT_LANGUAGE_SPLIT = "default";

	public string CurrentCultureCode;

	private List<FormatCultureInfoData> m_FormateCultureInfoData;

	public List<LongDigitSeparationData> m_LongDigitSeparationDataList;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}
}
