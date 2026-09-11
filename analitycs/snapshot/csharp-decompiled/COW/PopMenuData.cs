using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class PopMenuData
{
	public string Text;

	public Action<object> Callback;

	public object Data;

	public bool Selected;

	public bool CanSelect;

	public ResourceID spriteRes;

	public string spritename;

	public string SelectTip;

	public EEventTag TagType;

	public List<PopMenuData> SubMenuData;

	public bool IsDownLoadIconActive;

	public bool IsBadgeIcon;

	public bool IsShowTypeIcon;

	public int TitleLeftAnchor;

	public Color TypeIconColor;

	public bool IsRoleIcon;
}
