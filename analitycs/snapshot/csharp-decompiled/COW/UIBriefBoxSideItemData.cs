using System;

namespace COW;

public class UIBriefBoxSideItemData
{
	public string NewResIcon;

	public Action<object> Callback;

	public object Ext;

	public InteractionPopUtil.UIInteractionPoptype PopType;

	public static implicit operator UIBriefBoxSideItemData(CommonPopMenuData popMenuData)
	{
		return null;
	}
}
