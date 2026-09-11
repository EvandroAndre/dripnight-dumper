using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudHippoCrisisHighLevelItemController : UIHUDFeedbackItemBaseController
{
	private UIHudHippoCrisisHighLevelItemView m_View;

	private UIColor[] m_Color;

	private Dictionary<uint, GameObject> m_ItemLevelToVfx;

	private GameObject m_CurLevelVfx;

	private ResourceID m_VoiceRes;

	private const string VOICE_PREFIX = "SOUND_HIPPOCRISIS_CHEER";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitVoice()
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
