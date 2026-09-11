using COW.GamePlay;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIHudBattleStyleScoreBoardBuildIconController : UIHUDCSScoreBoardBuildIconController
{
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public uint loadoutId;

		internal bool _003CShowLoadout_003Eb__0(Item x)
		{
			return false;
		}
	}

	private bool m_BuildIconReady;

	private BHGGAEEHJCO m_BindPlayerID;

	private UIHudBattleStyleScoreBoardBuildIconView m_View;

	private UIModelLoadout m_ModelLoadout;

	private GKNHKOFFCPG m_BindPlayerModule;

	private string ExtraSkillDesc;

	private bool m_IsPresetPickHide;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void LoadBuildIcon()
	{
	}

	private void RefreshLevelProperties()
	{
	}

	protected override void OnBtnClick(GameObject go)
	{
	}

	public override void RefreshContent()
	{
	}

	public override void BindPlayer(BHGGAEEHJCO playerID)
	{
	}

	private void BindPlayerModule()
	{
	}

	private void ShowLoadout()
	{
	}

	private void SetEmptyState()
	{
	}

	private void OnPlayerLoadoutChanged(object[] data)
	{
	}

	public override void SetPresetPickHideView(bool isPresetPickHide)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnClick(GameObject P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}

	public void _003C_003EiFixBaseProxy_BindPlayer(BHGGAEEHJCO P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetPresetPickHideView(bool P0)
	{
	}
}
