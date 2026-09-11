using GCommon;

namespace COW;

internal class UIHudBombController : UIHudButtonBaseController
{
	private UIHudBombView m_View;

	private string PlantBombIcon;

	private string RemoveBombIcon;

	private string PlantBombHintLocTxt;

	private string RemoveBombHintLocTxt;

	private bool m_NeedShow;

	private bool m_MustHide;

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

	protected override string GetMappingName()
	{
		return null;
	}

	public void SetBombButtonStatus(bool isAttackSide)
	{
	}

	public void OnEnterBombArea(object[] param)
	{
	}

	public void OnEnterBombLevelObject(object[] param)
	{
	}

	public void OnPreparationStart(object[] data)
	{
	}

	public void OnPreparationCancel(object[] data)
	{
	}

	public void OnPreparationEnd(object[] data)
	{
	}

	public void OnPlayerInvBombCountChange(object[] data)
	{
	}

	public void OnRoundChange(object[] data)
	{
	}

	public void OnMustHideBombButton(object[] data)
	{
	}

	public void OnPlayerDead(object[] data)
	{
	}

	public void OnStartNewPhase(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
