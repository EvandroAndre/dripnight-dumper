using GCommon;

namespace COW;

public class UIHippoCrisisLobbyDifficultyPanelController : UIBaseController, IUIModelDataChangeObserver
{
	private UIHippoCrisisLobbyDifficultyPanelView m_View;

	private UIModelMapOpeningInfo m_ModelMap;

	private UIGameModeOpenDetailsController m_DetailController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void InitModeSelectedUI()
	{
	}

	private void OnHardBtnClick()
	{
	}

	private void OnEasyBtnClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void ShowHardNotOpenTips()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
