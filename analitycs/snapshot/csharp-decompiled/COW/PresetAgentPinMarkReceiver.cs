using System;
using UnityEngine;

namespace COW;

public class PresetAgentPinMarkReceiver : MonoBehaviour
{
	private EPresetDragInteractableItemType m_DragInteractableItemType;

	private Func<object> m_GetRuntimeData;

	private Action m_OnPinHoverInAction;

	private Action m_OnPinHoverOutAction;

	public EPresetDragInteractableItemType DragInteractableItemType => EPresetDragInteractableItemType.None;

	public static void Register(GameObject obj, EPresetDragInteractableItemType itemType, Func<object> runtimeData, Action onPinHoverInAction, Action onPinHoverOutAction)
	{
	}

	public static void UnRegister(GameObject obj)
	{
	}

	private void Bind(EPresetDragInteractableItemType itemType, Func<object> runtimeData, Action onPinHoverInAction, Action onPinHoverOutAction)
	{
	}

	private void UnBind()
	{
	}

	public void OnPinMark()
	{
	}

	public object GetRuntimeData()
	{
		return null;
	}

	public uint GetRuntimeDataToUint()
	{
		return 0u;
	}

	public void OnPinHoverIn()
	{
	}

	public void OnPinHoverOut()
	{
	}
}
