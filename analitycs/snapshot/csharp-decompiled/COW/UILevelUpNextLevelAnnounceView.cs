using GCommon;
using UnityEngine;

namespace COW;

public class UILevelUpNextLevelAnnounceView : UIBaseView
{
	public GameObject NextLevelLabelGameObject;

	public UILabel NextLevelLabel;

	public UIButton CloseButton;

	public GameObject OneUnlock;

	public GameObject TwoUnlock;

	public Transform UnLockTransForm;

	public Transform FirstUnclokTransform;

	public Transform SecondUnclokTransform;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
