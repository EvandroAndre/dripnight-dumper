using GCommon;
using UnityEngine;

namespace COW;

public class UICollectionMusicItemView : UIBaseView
{
	public UIButton ItemBtn;

	public GameObject gray;

	public UILabel name;

	public UISprite SpriteQualityPlus;

	public UISprite Quality;

	public UISprite QualityBG;

	public GameObject HL;

	public GameObject equipState;

	public UISprite validSprite;

	public UILabel valid;

	public UISprite defaultTagIcon;

	public UISprite ipTagIcon;

	public UISprite SpriteOrangeQualityPlus;

	public GameObject LoveNode;

	public GameObject VFX_SetLove;

	public BaseItemView2 Container;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
