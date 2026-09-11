using System;

namespace COW;

public class CommonSettingItemDataBase
{
	public Type ctrlType;

	public string LeftLabelKey;

	public Action TipBtnClickCallBack;

	public bool ShowTipBtn;

	public bool ShowItem;

	public bool ShowRedTips;

	public ETipsType tipsType;

	public string tipsKey;

	public bool EnableInSetting;

	public bool interactable;

	public int Type;

	public bool IsChildItem;

	public string NewLabelPrefKey;

	public Action OnCommonToggleChanged;

	public uint RedTipId;
}
