using GCommon;

namespace COW;

public class UIEditUploadHudNameController : UIChangeNameBaseController, IUIModelDataChangeObserver
{
	private UIModelKolHud m_ModelKolHud;

	private int m_EditPlanIndex;

	private string m_DefaultName;

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

	public void SetEditNameIndex(uint index)
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
