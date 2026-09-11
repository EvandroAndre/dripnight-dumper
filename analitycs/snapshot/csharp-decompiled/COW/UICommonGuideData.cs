using System;
using System.Collections.Generic;

namespace COW;

public class UICommonGuideData
{
	public string PlayerPrefKey;

	public CommonGuideSetting GuideSetting;

	public UIButton FinishGuideBtn;

	public UIWidget GuidingWidget;

	public UIAnchor.Side Side;

	public Action OnCloseAction;

	public bool FollowTarget;

	public List<EventDelegate> GuideMaskAction;

	public bool NeedClickClose;
}
