using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBigEvent_CustomCardGiveWndController : UIBaseController, IUIModelDataChangeObserver, IEasyList, IBigEventTemplateIdentifier
{
	private enum TipsEm
	{
		Friend_Empty,
		Card_Empty,
		Normal
	}

	private UIBigEvent_CustomCardGiveWndView m_View;

	private UIModelBigEvent_CustomCard m_UIModelCustomCard;

	private UIModelFriends m_UIModelFriends;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	public EBigEventTemplateUseType TemplateUseType
	{
		get
		{
			return _003CTemplateUseType_003Ek__BackingField;
		}
		private set
		{
			_003CTemplateUseType_003Ek__BackingField = value;
		}
	}

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

	private void RefershTips(TipsEm tips)
	{
	}

	private void RefershCardList()
	{
	}

	private int ComparaTo(CSCustomCardReleaseListRes.releaseCardInfo left, CSCustomCardReleaseListRes.releaseCardInfo right)
	{
		return 0;
	}

	protected override void OnUIDestory()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnClickAddFriendBtn()
	{
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
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
}
