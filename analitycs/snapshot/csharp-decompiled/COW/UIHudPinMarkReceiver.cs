using System;
using UnityEngine;

namespace COW;

internal class UIHudPinMarkReceiver : MonoBehaviour
{
	private Action m_PinMarkReceiver;

	private BoxCollider m_highlightObj;

	private bool m_isCircleHighlight;

	private string m_hintTxt;

	private UIHudIngameHighLightTipController m_highLight;

	private bool m_colliderOnlyOnWhenStartReceive;

	private UIHudIngameHighLightTipController fetchHighlight => null;

	public static void Register(GameObject obj, Action receiver, bool isCircleHighlight, string hintTxt, bool colliderOnlyOnWhenStartReceive = false)
	{
	}

	public void Bind(Action receiver, bool isCircleHighlight, string hintTxt, bool colliderOnlyOnWhenStartReceive)
	{
	}

	private void OnChangePinMarkState(object[] data)
	{
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

	private void OnDestroy()
	{
	}
}
