using System;
using GCommon;

namespace COW;

public class CommonPopMenuData
{
	public string Text;

	public string NewResIcon;

	public string SpecialResIcon;

	public ResourceID ResIcon;

	public Action<object> Callback;

	public Action<object> SecondCallback;

	public object Ext;

	public bool Enabled;

	public UINavigationUtil.UINavigationPageType State;

	public bool IsWishList;

	public InteractionPopUtil.UIInteractionPoptype PopType;

	public CommonPopMenuData(string text = "", Action<object> callback = null, object ext = null, bool enable = true, Action<object> secondCallback = null, UINavigationUtil.UINavigationPageType state = UINavigationUtil.UINavigationPageType.None)
	{
	}
}
