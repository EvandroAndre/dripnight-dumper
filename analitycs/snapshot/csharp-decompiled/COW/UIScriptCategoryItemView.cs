using GCommon;
using UnityEngine;

namespace COW;

public class UIScriptCategoryItemView : UIBaseView
{
	public UIButton ItemBtn;

	public UISprite icon;

	public UILabel Category;

	public GameObject NumberInfo;

	public UILabel Number;

	public UIColor Description;

	public UITable SubItemTb;

	public UISprite DownBtn;

	public UINetworkTexture Texture;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
