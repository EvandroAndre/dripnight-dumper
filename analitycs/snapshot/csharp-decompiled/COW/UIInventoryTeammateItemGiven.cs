using UnityEngine;

namespace COW;

public class UIInventoryTeammateItemGiven : MonoBehaviour
{
	public enum EState
	{
		EState_None,
		EState_Normal,
		EState_Enabled,
		EState_BagFull,
		EState_Disabled
	}

	public UIInventoryItemDragDropContainer Container;

	public GameObject NormalNode;

	public UILabel NormalIndex;

	public UILabel NormalName;

	public UISprite NormalBg;

	public GameObject EnableNode;

	public UILabel EnableName;

	public UISprite EnableBg;

	public GameObject BagFullNode;

	public UILabel BagFullName;

	public UISprite BagFullBg;

	public GameObject DisableNode;

	public UILabel DisableIndex;

	public UILabel DisableName;

	public UISprite DisableBg;

	private EState m_CurState;

	public int TeamIndex;

	public void SetState(EState state)
	{
	}
}
