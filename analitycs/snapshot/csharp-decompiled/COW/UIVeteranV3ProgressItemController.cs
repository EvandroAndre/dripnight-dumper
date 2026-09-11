using GCommon;
using proto;

namespace COW;

public class UIVeteranV3ProgressItemController : UIBaseController
{
	private UIVeteranV3ProgressItemView m_View;

	private UIModelVeteran m_ModelVeteran;

	private VeteranAwardDesc m_veteranAwardDesc;

	private UIVeteranV3AwardItemController m_AwardItemCtrl;

	private int m_LevelID;

	private uint m_CurProgress;

	private const string REACHED_LABELBG_SPRITENAME = "FF_UI_Veteran_barNo02";

	private const string UNREACHED_LABELBG_SPRITENAME = "FF_UI_Veteran_barNo01";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnClickItem()
	{
	}

	private void LoadStaticContent()
	{
	}

	private void RefreshDynamicContent()
	{
	}

	private void RefreshView()
	{
	}

	private void SetCanClaimState()
	{
	}

	private void SetGameObjectActive(VFXCreateHelper go, bool isActive)
	{
	}

	public void SetViewData(VeteranAwardDesc veteranAwardDesc, int level)
	{
	}

	public void OnSelect()
	{
	}

	public void OnCancelSelect()
	{
	}

	public void HideProgressLabel()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
