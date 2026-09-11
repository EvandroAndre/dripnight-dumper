using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLobbySocialAreaDancePanelController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<SocialLobbyDancingTemplate> _003C_003E9__11_0;

		internal int _003CInitDanceItems_003Eb__11_0(SocialLobbyDancingTemplate a, SocialLobbyDancingTemplate b)
		{
			return 0;
		}
	}

	private UIHudLobbySocialAreaDancePanelView m_View;

	private List<UIHudLobbySocialAreaDanceItemController> m_DanceItemControllerList;

	private UIHudLobbySocialAreaDanceItemController m_CurPlayingItem;

	private bool m_IsListVisible;

	private UIClickMask m_ClickMask;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public Vector2 GetBgSize()
	{
		return default(Vector2);
	}

	private void ClearClickMask()
	{
	}

	public void RefreshPlayingState()
	{
	}

	private void InitDanceItems()
	{
	}

	public void OnDanceItemSelected(UIHudLobbySocialAreaDanceItemController item)
	{
	}

	private void StopCurrentDance()
	{
	}

	private void OnBtnCloseClick()
	{
	}

	private void OnBtnDanceClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
