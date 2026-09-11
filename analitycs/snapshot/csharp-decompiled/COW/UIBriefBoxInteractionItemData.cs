using System;

namespace COW;

public class UIBriefBoxInteractionItemData
{
	public string IconRes;

	public string Text;

	public Action<object> Callback;

	public object Ext;

	public bool Enabled;

	public bool IsWishList;

	public InteractionPopUtil.UIInteractionPoptype PopType;

	public static implicit operator UIBriefBoxInteractionItemData(CommonPopMenuData popMenuData)
	{
		return null;
	}
}
