using GCommon;
using UnityEngine;

namespace COW;

public class UIChatWhisperNameItemController : UIEasyListItemController, ITipsDelegate
{
	private UIChatWhisperNameItemView m_View;

	private ChatWhisperNameData m_WhisperData;

	private Vector3 m_DefaultRankScale;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private GameObject m_PrimeAvatarFrame;

	private ResourceID m_AvatarFrameRes;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnDeleteClick()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	void ITipsDelegate.OnTipsDataChange(ETipsType type, int num)
	{
	}

	private void RefreshUnreadTips()
	{
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}
}
