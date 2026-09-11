using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCHudPrefabRoot : UGCUIWidget
{
	private int m_ScreenWidth;

	private int m_ScreenHeight;

	private uint m_MaxWidgetID;

	private const int START_DEPTH = 7;

	private int m_StartDepth;

	private List<UGCHudWidget> m_WidgetList;

	public int ScreenWidth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ScreenHeight
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public uint MaxWidgetID => 0u;

	public int StartDepth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static UGCHudPrefabRoot GetOrAdd(GameObject go)
	{
		return null;
	}

	public void SetScreenSize(int width, int height)
	{
	}

	public void UpdateChildrenAlignment()
	{
	}

	public void UpdateHierarchy()
	{
	}

	public int GetWidgetCount()
	{
		return 0;
	}

	protected internal void Init()
	{
	}
}
