using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

namespace COW.Gameplay.UGC;

public static class UGCUITools
{
	private static List<UIWidget> s_WidgetList;

	private static readonly Regex INVALID_CHAR_REG;

	public static string RGBToHEX(Color32 c)
	{
		return null;
	}

	public static void ResizeWidget(UIWidget w, UIWidget.Pivot pivot, float x, float y, bool keepAspectRatio = false, int minWidth = 2, int minHeight = 2, int maxWidth = 100000, int maxHeight = 100000)
	{
	}

	public static void AdjustDepthByHierarchy(GameObject go)
	{
	}

	public static void UpdateWidgetHorizontalAlignment(UGCHudWidget widget, int parentWidth)
	{
	}

	public static void UpdateWidgetVerticalAlignment(UGCHudWidget widget, int parentHeight)
	{
	}

	public static void UpdateWidgetAlignment(UGCHudWidget widget)
	{
	}

	public static Transform GetHudPrefabRoot(GameObject go)
	{
		return null;
	}

	public static uint GetHudMaxUniqueID(GameObject go)
	{
		return 0u;
	}

	public static GameObject CreateHudWidget(UGCHudWidgetType widgetType, Transform parent)
	{
		return null;
	}

	public static string GetHudWidgetIcon(UGCHudWidgetType widgetType)
	{
		return null;
	}

	public static string GetHudWidgetName(UGCHudWidgetType widgetType, uint uniqueId)
	{
		return null;
	}

	public static bool IsHudWidget(GameObject go)
	{
		return false;
	}

	public static bool IsHudWidget(Transform transform)
	{
		return false;
	}

	public static string GetHudID(uint hudId)
	{
		return null;
	}

	public static uint GetHudID(string hudId)
	{
		return 0u;
	}

	public static string GetHudWidgetID(uint hudId, uint widgetId)
	{
		return null;
	}

	public static string GetHudWidgetID(string hudID, uint widgetId)
	{
		return null;
	}

	public static string GetWidgetUGCTypeName(UGCHudWidgetType widgetType)
	{
		return null;
	}

	public static bool CheckNameValidation(string name)
	{
		return false;
	}

	public static string RemoveEmoji(string text)
	{
		return null;
	}

	private static bool IsBmpEmoji(char c)
	{
		return false;
	}
}
