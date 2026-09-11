using GCommon;
using UnityEngine;

namespace COW;

public class UISmallDetailTipsView : UIBaseView
{
	public GameObject PosRoot;

	public GameObject ItemAnchor;

	public GameObject UIStandardItemMini;

	public UILabel ItemName;

	public UISprite TypeIcon;

	public UILabel ItemTime;

	public UISprite TimeIcon;

	public UILabel ItemCount;

	public UITable ContentTable;

	public GameObject TopLine;

	public UIWidget EmptyItem;

	public UILabel Description;

	public GameObject BtnGroup;

	public UIButton CancelBtn;

	public UILabel CancelTitle;

	public UIButton ConfirmBtn;

	public UILabel ConfirmTitle;

	public GameObject BottomLine;

	public GameObject BGPivot;

	public UISprite BG;

	public GameObject ArrowAnchor;

	public UIButton BgBtn;

	public GameObject Mask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
