using System;
using COW.GamePlay;
using UnityEngine;

namespace COW;

internal class BotAgentPinMarkReceiver : MonoBehaviour
{
	public delegate object GetBotAgentRuntimeData();

	private Func<string> m_GetBotAgentRuntimeData;

	private string m_ActionName;

	private FIGMILCIMAG m_Condition;

	private BoxCollider m_highlightObj;

	private bool m_isCircleHighlight;

	private string m_hintTxt;

	private bool m_ColliderOnlyOnWhenStartReceive;

	private UIHudIngameHighLightTipController m_highLight;

	private UIHudIngameHighLightTipController fetchHighlight => null;

	public static void Register(GameObject obj, string actionName, Func<string> runtimeData, bool isCircleHighlight, string hintTxt, bool colliderOnlyOnWhenStartReceive = false)
	{
	}

	public static void UnRegister(GameObject obj)
	{
	}

	public void Bind(string actionName, Func<string> getBotAgentRuntimeData, bool isCircleHighlight, string hintTxt, bool colliderOnlyOnWhenStartReceive = false)
	{
	}

	public void UnBind()
	{
	}

	private void OnChangePinMarkState(bool show)
	{
	}

	public bool IsConditionValid()
	{
		return false;
	}

	private bool IsRunTimeDataValid()
	{
		return false;
	}

	private string GetRuntimeData()
	{
		return null;
	}

	private FIGMILCIMAG GetCondition()
	{
		return null;
	}

	public void OnPinMark()
	{
	}

	public void OnPinHoverIn()
	{
	}

	public void OnPinHoverOut()
	{
	}
}
