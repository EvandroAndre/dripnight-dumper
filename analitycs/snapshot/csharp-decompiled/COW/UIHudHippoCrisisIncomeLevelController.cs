using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudHippoCrisisIncomeLevelController : UIHUDFeedbackItemBaseController
{
	private UIHudHippoCrisisIncomeLevelView m_View;

	private UIColor[] m_Color;

	private Dictionary<uint, Transform> m_ScoreLevelToEffect;

	private Transform m_CurScoreLevelEffect;

	private Dictionary<uint, ResourceID> m_ScoreLevelToAudioSource;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(NotificationData data)
	{
	}

	public override void ShowIcon(NotificationData data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
