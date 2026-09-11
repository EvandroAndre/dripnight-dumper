using System.Collections.Generic;
using GCommon;

namespace COW;

internal class NewbiePathGuideManager : SingletonModule<NewbiePathGuideManager>
{
	private int _003CGuideProgress_003Ek__BackingField;

	private ENewbieGuideType _003CCurNewbieGuideType_003Ek__BackingField;

	private Dictionary<int, string[]> m_GuideTips;

	public bool InGuideProgress => false;

	public int GuideProgress
	{
		get
		{
			return _003CGuideProgress_003Ek__BackingField;
		}
		private set
		{
			_003CGuideProgress_003Ek__BackingField = value;
		}
	}

	public ENewbieGuideType CurNewbieGuideType
	{
		get
		{
			return _003CCurNewbieGuideType_003Ek__BackingField;
		}
		private set
		{
			_003CCurNewbieGuideType_003Ek__BackingField = value;
		}
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public int GetTotalGuideSteps(ENewbieGuideType type)
	{
		return 0;
	}

	public string GetCurGuideTips()
	{
		return null;
	}

	public void StartGuide(object[] param)
	{
	}

	public void BoostCurGuideProgress()
	{
	}

	public void ForceStopAllGuide()
	{
	}

	public void SetGuideProgress(ENewbieGuideType type, int value, int ctdvalue = -1)
	{
	}

	private void StopOldGuide()
	{
	}
}
