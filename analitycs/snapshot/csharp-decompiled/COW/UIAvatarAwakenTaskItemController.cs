using UnityEngine;
using proto;

namespace COW;

public class UIAvatarAwakenTaskItemController : MonoBehaviour
{
	public UILabel Desc;

	public UILabel Process;

	public Transform AwardItem;

	public Transform AwardItem2;

	public UIButton StateButton;

	public GameObject OperateAwarded;

	public GameObject OperateFinished;

	public GameObject OperateReceived;

	public UIWidget TaskWidget;

	public UIWidget AdjustWidget;

	private uint m_TaskID;

	private int m_Index;

	private uint m_AvatarID;

	private UIModelAvatarProfile m_Model;

	private EProfile.TaskState m_State;

	private UIStandardItemMiniController m_CacheAward1;

	private UIStandardItemMiniController m_CacheAward2;

	private void Start()
	{
	}

	public void SetData(uint avatarID, AwakenTask taskData, int index)
	{
	}

	public uint GetTaskID()
	{
		return 0u;
	}

	public int GetUIIndex()
	{
		return 0;
	}

	private void OnButtonClick()
	{
	}

	private void UpdateButtonState(EProfile.TaskState state)
	{
	}

	private uint GetUnitRatio(uint val, bool needChangeVal)
	{
		return 0u;
	}
}
