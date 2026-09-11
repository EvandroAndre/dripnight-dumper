using System;
using UnityEngine;

namespace GCommon;

public class UIMenuItemData
{
	public string id;

	public string title;

	public Action selectedCallback;

	public Action unSelectedCallback;

	public Action<GameObject[]> externInitCallback;
}
