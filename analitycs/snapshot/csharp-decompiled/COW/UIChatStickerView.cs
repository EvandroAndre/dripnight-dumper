using GCommon;
using UnityEngine;

namespace COW;

public class UIChatStickerView : UIBaseView
{
	public UIButton CloseStickerBtn;

	public UIToggleButtonGroup StickerToggleBtnGroup;

	public UIGrid StickerTabGrid;

	public StickerTabView StickerTabItemInstance;

	public UIScrollView StickerSpriteList;

	public UIPanel StickerSpriteListPanel;

	public UITable StickerSpriteTable;

	public StickerSpriteView StickerSpriteInstance;

	public GameObject PurchaseGo;

	public UIPanel PurchaseGoPanel;

	public UIButton PurchaseBtn;

	public GameObject DiamondGO;

	public UILabel StickerPriceDiamond;

	public GameObject CoinGO;

	public UILabel StickerPriceCoin;

	public GameObject GoposGo;

	public UILabel StickerPriceGopos;

	public UIPanel Main;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
