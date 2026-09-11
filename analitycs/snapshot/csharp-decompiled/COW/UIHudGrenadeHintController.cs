using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudGrenadeHintController : UIBaseController
{
	public enum HintType
	{
		GrenaeHint,
		LandmineHint,
		FlashHint,
		FireKunai,
		ThunderKunai,
		WindKunai,
		NanBombPaper,
		HiraishenKunai,
		Dart,
		IIVPurpleBall,
		IIVFiles
	}

	public class GrenadeLocationData
	{
		public Vector3 location;

		public HintType hint;
	}

	private UIHudGrenadeHintView m_View;

	private List<GrenadeLocationData> m_GrenadeLocationData;

	private List<Vector3> m_GrenadeLocation;

	private static readonly float WARNING_RATIO;

	private List<UIHudGrenadeSubHintController> m_hintlist;

	private Dictionary<uint, UIHud3DHint> m_HintGrenadeDict;

	private Dictionary<BHGGAEEHJCO, UIHud3DHint> m_HintPlayerDict;

	private static readonly int POOLCOUNT;

	private List<BHGGAEEHJCO> m_TriggerGrenadedPlayers;

	protected BitArray m_NeedFilter;

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

	private void OnOtherTrigger(object[] param)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void ClearAllHints()
	{
	}

	private void RefreshGrenadeLocations()
	{
	}

	private bool ShouldShowCombineHint(LLGMLLNGIMI combine, Player localPlayer)
	{
		return false;
	}

	private bool IsInLandmineRange(LevelLandmine landmine)
	{
		return false;
	}

	private bool ShouldShowHint(Player val)
	{
		return false;
	}

	private bool ShouldShowHint(BaseLevelObject val)
	{
		return false;
	}

	private bool ShouldShowKunaiHint(LevelKunai kunai)
	{
		return false;
	}

	private void RefreshHintInterfaceObj()
	{
	}

	private void LateUpdate()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
