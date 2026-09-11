using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudPresetPickTeammateInfoController : UIBaseController
{
	private UIHudPresetPickTeammateInfoView m_View;

	private UIHudPresetPickSkillItemController m_SkillItemCtrl;

	private uint m_ChangingSkillVFXHolderID;

	private uint m_ChangingLoadoutVFXHolderID;

	private uint m_ChangeSuccessSkillVFXHolderID;

	private uint m_ChangeSuccessLoadoutVFXHolderID;

	private BHGGAEEHJCO m_PlayerID;

	private string m_PlayerName;

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

	protected override void OnVisibilityChanged()
	{
	}

	public void SetViewData(BHGGAEEHJCO playerID)
	{
	}

	public void RefreshPlayerActiveSkill(bool needRefreshVFX = false)
	{
	}

	public void RefreshPlayerLoadout(bool needRefreshVFX = false)
	{
	}

	private void ShowEmptyLoadoutIcon(bool show)
	{
	}

	private void RefreshChangingVFXView()
	{
	}

	public void SetIsChangingSkillVFXView(bool isChanging)
	{
	}

	public void SetIsChangingLoadoutVFXView(bool isChanging)
	{
	}

	private void PlayChangeSuccessSkillVFX()
	{
	}

	private void PlayChangeSuccessLoadoutVFX()
	{
	}

	private void RefreshPlayerName()
	{
	}

	private void ClearUIFX()
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
