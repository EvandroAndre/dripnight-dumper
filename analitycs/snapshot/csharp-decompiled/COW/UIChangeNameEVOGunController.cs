using GCommon;
using proto;

namespace COW;

public class UIChangeNameEVOGunController : UIChangeNameBaseController
{
	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private SkinOwnAndOpenInfo m_SkinOwnAndOpenInfo;

	private WeaponSkinStat m_WeaponSkinStat;

	private bool m_HasRequestedRename;

	private float m_NextCanConfirmTime;

	private readonly ulong m_ConfirmCD;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
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

	public void RefreshViewData(SkinOwnAndOpenInfo info)
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	private void ChangeWeaponSkinStat(string newName)
	{
	}

	private void OnReSetBtnClick()
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
