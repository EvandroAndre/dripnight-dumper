using System.Collections.Generic;
using GCommon;

namespace COW;

public class TutorRecruitOptionDataManager : SingletonModule<TutorRecruitOptionDataManager>
{
	private List<TutorRecruitOptionData> m_ListData;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public List<TutorRecruitOptionData> GetTutorRecruitOptionDatas()
	{
		return null;
	}
}
