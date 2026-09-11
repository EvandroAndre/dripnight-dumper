using System;
using GCommon;

namespace COW;

public class UIHudCommonBannerNotificationViewData
{
	public string FirstLineStr;

	public string SecondLineStr;

	public bool IsOpeningNotification;

	public ResourceID PrefabRes;

	public ResourceID IconSprite;

	public Action<UIHudCommonBannerNotificationShowRefrence> OnPlayCallback;

	public Action<UIHudCommonBannerNotificationShowRefrence> OnFinishedCallback;

	public ResourceID SoundRes;

	public UIHudCommonBannerNotificationViewData(ResourceID prefabRes, string firstLineStr, string secondLineStr, bool isOpeningNotification = false, ResourceID iconSprite = default(ResourceID), Action<UIHudCommonBannerNotificationShowRefrence> onPlayCallback = null, Action<UIHudCommonBannerNotificationShowRefrence> onFinishedCallback = null, string soundRes = "")
	{
	}

	public void SetSoundResByID(ResourceID soundRes)
	{
	}
}
