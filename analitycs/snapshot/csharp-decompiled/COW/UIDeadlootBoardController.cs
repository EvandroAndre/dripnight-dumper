using GCommon;
using proto;

namespace COW;

public class UIDeadlootBoardController : UIBaseController
{
	private UIDeadlootBoardView m_View;

	private UIModelCollectionCustom m_ModelCollectionCustom;

	private const string LocalCustomItemPrefsKeyFormat = "{0}_CUSTOMITEM_{1}";

	private uint m_PlayerID;

	private UIBaseHeadController m_HeadCtrl;

	private bool m_IsUsedInGame;

	private float _003CCachedDistSqr_003Ek__BackingField;

	public float CachedDistSqr
	{
		get
		{
			return _003CCachedDistSqr_003Ek__BackingField;
		}
		set
		{
			_003CCachedDistSqr_003Ek__BackingField = value;
		}
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnRecycleUIGameObject()
	{
	}

	public void BindDeadBox(uint collectionID, uint playerID)
	{
	}

	public void BindDeadBoxForPreview(uint collectionID)
	{
	}

	private void SetBoardView(PlayerData playerData, uint collectionID)
	{
	}

	private void SetBoardViewForPreview(uint collectionID)
	{
	}

	private bool NeedHideHeadPic()
	{
		return false;
	}

	private bool NeedUseFakeHeadPic()
	{
		return false;
	}

	private bool CanShowHeadPic()
	{
		return false;
	}

	private static string GetCustomMessage(PlayerData playerData, uint collectionID)
	{
		return null;
	}

	private bool IsLocalPlayer(PlayerData playerData)
	{
		return false;
	}

	private bool IsCollectionOwned(uint collectionID)
	{
		return false;
	}

	private string GetLocalCustomData(uint collectionID)
	{
		return null;
	}

	private string GetLootBoxCustomMessage(string custom_info)
	{
		return null;
	}

	private string GetLootBoxCustomMessage(CollectionCustomDesc customDesc)
	{
		return null;
	}

	private string BuildLootBoxCustomMessage(uint[] sort_id_order)
	{
		return null;
	}

	public void SetBoardVisible(bool visible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRecycleUIGameObject()
	{
	}
}
