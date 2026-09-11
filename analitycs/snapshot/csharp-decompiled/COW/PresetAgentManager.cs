using System;
using GCommon;
using UnityEngine;

namespace COW;

public class PresetAgentManager : SingletonModule<PresetAgentManager>
{
	public bool TriggerAutoPrompt;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override bool NeedResetCleanup()
	{
		return false;
	}

	public void RegisterPresetAgentPinReceiver(GameObject obj, EPresetDragInteractableItemType itemType, Func<object> runtimeData, Action onPinHoverInAction = null, Action onPinHoverOutAction = null)
	{
	}

	public void UnRegisterPresetAgentPinReceiver(GameObject obj)
	{
	}

	public void RegisterPresetAgentUIHighLightReceiver(GameObject obj, EPresetAgentUIHighLightType itemType, UIWidget widget, Func<object> runtimeData)
	{
	}

	public void UnRegisterPresetAgentUIHighLightReceiver(GameObject obj)
	{
	}

	public int GetPresetAgentPinReceiverPriority(PresetAgentPinMarkReceiver receiver)
	{
		return 0;
	}

	public bool CheckIsScrollRegion(PresetAgentPinMarkReceiver receiver)
	{
		return false;
	}

	public bool CheckIsScrollRegion(EPresetDragInteractableItemType itemType)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedResetCleanup()
	{
		return false;
	}
}
