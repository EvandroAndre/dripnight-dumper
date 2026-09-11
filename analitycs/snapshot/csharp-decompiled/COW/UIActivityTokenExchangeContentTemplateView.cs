using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityTokenExchangeContentTemplateView : UIBaseView
{
	public GameObject ScrollView;

	public UITable ContentTable;

	public UILabel Introduction;

	public UILabel Time;

	public UIDragScrollView DragArea;

	public UIWidget DragWidget;

	public GameObject UIActivityTokenExchangeContentTemplate;

	public UITable ItemTable;

	public UILabel TokenLabel;

	public GameObject MainTokenBg;

	public UINetworkTexture TokenTitleBgCnd;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
