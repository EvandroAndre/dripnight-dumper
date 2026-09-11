using GCommon;
using proto;

namespace COW;

public class UIChangeNamePetController : UIChangeNameBaseController
{
	private UIModelPet m_ModelPet;

	private PetInfo m_PetData;

	private PetRenameCostData m_CostData;

	private bool m_HasRequestedRename;

	private bool isFree;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void EnterByReturn()
	{
	}

	protected override void Awake()
	{
	}

	protected override void RefreshBtnView(bool isShowEnable)
	{
	}

	protected override bool CheckNicknameValid(string newName)
	{
		return false;
	}

	private void InitView()
	{
	}

	private void RefreshInputNewName(string curName)
	{
	}

	private void RefreshViewData()
	{
	}

	private void OnDiamondBtnClick()
	{
	}

	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_EnterByReturn()
	{
	}

	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshBtnView(bool P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_CheckNicknameValid(string P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return 0u;
	}
}
