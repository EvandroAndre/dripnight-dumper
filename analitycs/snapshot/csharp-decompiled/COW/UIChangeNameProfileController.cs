using System;
using GCommon;
using proto;
using proto.Login;

namespace COW;

public class UIChangeNameProfileController : UIChangeNameBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<Item> _003C_003E9__14_0;

		internal bool _003CRefreshViewData_003Eb__14_0(Item item)
		{
			return false;
		}
	}

	private UIModelUser m_ModelUser;

	private EGLJDBDMENB m_UserData;

	private RenameCostData m_CostData;

	private bool m_RenameCardEnabled;

	private bool m_HasRequestedRename;

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

	private void OnDiamondBtnClick()
	{
	}

	private void OnCardBtnClick()
	{
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
