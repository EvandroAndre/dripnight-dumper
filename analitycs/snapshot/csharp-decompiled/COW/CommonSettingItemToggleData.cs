using System;

namespace COW;

public class CommonSettingItemToggleData
{
	public string BtnKey;

	public Action BtnClickCallBack;

	public Func<bool> IsEnable;

	public bool ShowArrow;

	public bool ShowUpArrow;
}
