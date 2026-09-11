using GCommon;

namespace COW;

public class UIBuildLoadoutController : UIBaseLoadoutItemController
{
	private UIBuildLoadoutView m_View;

	private UIModelUser m_ModelUser;

	private UILockController m_LockCtrl;

	private uint m_CurrentLoadout;

	private UICommonGuideController m_TutorialGuideCtrl;

	public UIWidget GuideWidget => null;

	public UIButton GuideButton => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void InitView()
	{
	}

	public override void SetData(uint loadoutId = uint.MaxValue, bool isV2Open = false, uint loadoutV2Id = 0u)
	{
	}

	private void OnLoadoutBtnClick()
	{
	}

	private void OnMaskBtnClick()
	{
	}

	public void SetSelectHighLight(bool state)
	{
	}

	public bool LoadoutEquiped()
	{
		return false;
	}

	public void ShowLoadoutTutorial()
	{
	}

	public void HideLoadoutTutorial()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_InitView()
	{
	}
}
