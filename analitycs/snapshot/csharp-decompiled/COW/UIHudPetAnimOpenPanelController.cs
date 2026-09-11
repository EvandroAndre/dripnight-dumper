using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPetAnimOpenPanelController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public UIHudPetAnimOpenPanelController _003C_003E4__this;

		public PetActionData d;

		public int slotId;

		internal void _003CInitBtn_003Eb__0()
		{
		}
	}

	private const string m_PetAnimPanelClickLogLabel = "MatchPetEmoteClick";

	private UIHudPetAnimOpenPanelView m_View;

	private static readonly int PetPanelTotalCount;

	private GameObject[] m_Desgars;

	private NetworkPet m_Pet;

	private bool m_NeedDownload;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitBtns(List<PetActionData> anims)
	{
	}

	private void InitBtn(UIButton btn, UISprite sprite, PetActionData d, int slotId)
	{
	}

	private void UpdateCenterIcons(bool isHidden)
	{
	}

	private void OnClickAnim(PetActionData d, int slotId)
	{
	}

	private void OnClickCenterBtn()
	{
	}

	private void HidePanel()
	{
	}

	private void ShowKey(string key)
	{
	}

	private static bool IsPetHiddenByLocalPlayer()
	{
		return false;
	}

	private static void SetPetHiddenByLocalPlayer(bool value)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
