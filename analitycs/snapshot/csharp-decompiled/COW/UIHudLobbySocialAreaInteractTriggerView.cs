using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLobbySocialAreaInteractTriggerView : MonoBehaviour
{
	public Transform VFXTrans;

	public UILabel ProgressLabel;

	private UIHudLobbySocialAreaEventActionController.EEventActionType m_ActionType;

	private bool m_EventRegistered;

	private VisualInstanceHolder m_VFXHolder;

	public void SetData(UIHudLobbySocialAreaEventActionController.EEventActionType actionType)
	{
	}

	public void ResetData()
	{
	}

	private void RegisterEvent()
	{
	}

	private void UnregisterEvent()
	{
	}

	private void RefreshProgressAndVFX(uint type)
	{
	}

	private void RefreshProgress(uint type)
	{
	}

	private void PlayVFX()
	{
	}

	private void ReleaseVFX()
	{
	}
}
