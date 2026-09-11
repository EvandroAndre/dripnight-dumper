using GCommon;

namespace COW;

public class UIEditRecPlanNameController : UIChangeNameBaseController, IUIModelDataChangeObserver
{
	private UIModelLoadout m_ModelLoadout;

	private int m_EditPlanIndex;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void Awake()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void RefreshBtnView(bool isShowEnable)
	{
	}

	private void InitView()
	{
	}

	protected override bool CheckNicknameValid(string newName)
	{
		return false;
	}

	private void OnConfirmBtnClick()
	{
	}

	public void SetEditPlanIndex(uint index)
	{
	}

	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshBtnView(bool P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_CheckNicknameValid(string P0)
	{
		return false;
	}
}
