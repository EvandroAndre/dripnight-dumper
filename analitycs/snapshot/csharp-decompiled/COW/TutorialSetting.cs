using System.Collections.Generic;

namespace COW;

public class TutorialSetting
{
	public TutorialEventEnum EventType;

	public TutorialUIType DisplayType;

	public float HideDelay;

	public string HintText;

	public string ParamText;

	public bool FinishWhenUserInteract;

	public bool OpenToNewBie;

	public List<uint> ShowToNewbieChoice;

	public bool ShowInWaitingRoom;

	public bool ShowEveryLauncher;

	public List<uint> MatchMode;

	public List<uint> GameMode;

	public List<uint> GroupMode;

	public bool AboveBigMap;

	public bool AbovePopup;

	public float ShrinkInterval;

	public bool TapOnEmptyClose;

	public TutorialDepthType DepthType;

	public int DepthOffset;

	public bool IsOpen;

	public int DisplaySubType;

	public TutorialSetting(TutorialEventEnum eType, TutorialUIType dType, string hint, bool openToNewBie, List<uint> showToNewbieChoice, bool inWaitingRoom, List<uint> eMatchMode, List<uint> eGameMode, List<uint> eGroupMode, bool showLauncher, bool aboveBigMap, bool abovePopup, float delay, float shrinkInterval, bool tapOnEmptyClose, int depthType, bool isOpen, int displaySubType, int depthOffset = 1)
	{
	}
}
