using System;
using UnityEngine;

namespace COW;

public class PresetAgentUIHighLightReceiver : MonoBehaviour
{
	private EPresetAgentUIHighLightType m_ItemType;

	private UIWidget m_Widget;

	private Func<object> m_RuntimeData;

	private UIPresetAgentUIHighLightController m_HighLight;

	private UIPresetAgentUIHighLightController FetchHightLight => null;

	public static void Register(GameObject obj, EPresetAgentUIHighLightType type, UIWidget widget, Func<object> runtimeData)
	{
	}

	public static void UnRegister(GameObject obj)
	{
	}

	private void Bind(EPresetAgentUIHighLightType itemType, UIWidget widget, Func<object> runtimeData)
	{
	}

	private void UnBind()
	{
	}

	private void OnPresetAgentUIHighLightStateChanged(object[] data)
	{
	}

	private void OnPresetAgentPinMark(object[] data)
	{
	}

	private bool CheckPinMarkValid(EPresetDragInteractableItemType itemType)
	{
		return false;
	}

	private bool CheckPinMarkDataValid(uint itemData)
	{
		return false;
	}

	private object GetRuntimeData()
	{
		return null;
	}

	private uint GetRuntimeDataToUint()
	{
		return 0u;
	}
}
