using System;
using GCommon;

namespace COW;

public class UIHudSceneDropDownItemWithIconData
{
	public ResourceID Icon;

	public string Text;

	public ResourceID SelectedIcon;

	public string SelectedText;

	public Action<object> Callback;

	public bool Selected;

	public object Data;
}
