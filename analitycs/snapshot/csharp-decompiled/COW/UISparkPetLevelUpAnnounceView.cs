using GCommon;
using UnityEngine;

namespace COW;

public class UISparkPetLevelUpAnnounceView : UIBaseView
{
	public GameObject NextLevelLabelGameObject;

	public UILabel NextLevelLabel;

	public UIButton CloseButton;

	public GameObject OneUnlock;

	public Transform UnLockTransForm;

	public GameObject Unlock_Container;

	public UINetworkTexture SparkPetCDN1;

	public UINetworkTexture SparkPetCDN2;

	public UINetworkTexture SparkPetCDN3;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
