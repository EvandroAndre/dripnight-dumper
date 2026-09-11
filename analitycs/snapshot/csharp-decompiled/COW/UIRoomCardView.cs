using UnityEngine;
using proto;

namespace COW;

public class UIRoomCardView : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public UIRoomCardView _003C_003E4__this;

		public EInventory.ItemSubType type;

		internal void _003CRefreshLabel_003Eb__0()
		{
		}
	}

	public UIButton Button;

	public UILabel Label;

	public UISprite Sprite;

	public UIWidget Widget;

	public BoxCollider ButtonCollider;

	public Transform Container;

	public UISprite Tag;

	private UICountDownLabel m_CountDownLabel;

	private UIModelInventory m_ModelInventory;

	private BaseItemInfo m_CardItemInfo;

	private EInventory.ItemSubType m_ItemSubType;

	public void SetActive(bool active)
	{
	}

	public void Init(EInventory.ItemSubType type, bool showTime)
	{
	}

	private void OnBtnClick()
	{
	}

	public void RefreshLabel(EInventory.ItemSubType type, bool showTime)
	{
	}

	public void RefreshCount(EInventory.ItemSubType type, bool unlimited)
	{
	}

	public void UpdateWidget(uint padding = 0u)
	{
	}

	private void UpdateItemData(EInventory.ItemSubType type, bool showTime)
	{
	}
}
