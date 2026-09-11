using GCommon;
using UnityEngine;

namespace COW;

public class UILoadoutV2ItemLevelProgressView : UIBaseView
{
	public UILabel LevelLabel;

	public GameObject Normal;

	public GameObject Lock;

	public GameObject NormalLine;

	public GameObject LockLine;

	public ParticleSystem Arrow;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
