using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileAlbumItemView : UIBaseView
{
	public UIButton ClickBtn;

	public UITexture Texture;

	public UILabel memorySize;

	public UILabel time;

	public UILabel name;

	public GameObject DefaultPicture;

	public GameObject SelectContainer;

	public GameObject SelectedSprite;

	public UIButton SelectBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
