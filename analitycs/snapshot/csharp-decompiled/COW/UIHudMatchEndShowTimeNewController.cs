using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudMatchEndShowTimeNewController : UIHudMatchEndShowTimeController
{
	private uint m_DelayCallFeedbackIcon;

	private bool m_ShowSkin;

	private uint[] m_GroupMedals;

	private List<string> feedbackItems;

	private UIHud2NBGPMatchEndBooyahSkinView m_CurSkinComponent;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void CreateView()
	{
	}

	protected override void OnUIInit()
	{
	}

	private void OnItemFinish()
	{
	}

	private void PlaySkinTweenAnim()
	{
	}

	private void HandleShowEasterEggTelescopeHud()
	{
	}

	private void ShowEasterEggTelescopeHud()
	{
	}

	private void OnItemShow(int index)
	{
	}

	protected override void OnProcessAnimEvt(string animEvt)
	{
	}

	protected override void PlayAnimation()
	{
	}

	protected override void ShowGroupMedals(List<byte> groupMedals)
	{
	}

	private void OnShowFeedbackEndIcon()
	{
	}

	protected override void ShowSkinBooyahView(bool win)
	{
	}

	private bool TryShowSkinBooyah(bool win)
	{
		return false;
	}

	private void GetFinalShotBooyahSkinRes(Player player, ref ResourceID uiSkinRes, ref ResourceID audioResId)
	{
	}

	private void GetAcvititySkinRes(Player player, ref ResourceID uiSkinRes, ref ResourceID audioSkinRes)
	{
	}

	private void MoveSkinBooyahView()
	{
	}

	private void RefreshUISkinChange()
	{
	}

	private void _003COnItemFinish_003Eb__5_0()
	{
	}

	public void _003C_003EiFixBaseProxy_CreateView()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnProcessAnimEvt(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_PlayAnimation()
	{
	}

	public void _003C_003EiFixBaseProxy_ShowGroupMedals(List<byte> P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowSkinBooyahView(bool P0)
	{
	}
}
