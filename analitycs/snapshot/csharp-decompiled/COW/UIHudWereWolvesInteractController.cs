using GCommon;

namespace COW;

public class UIHudWereWolvesInteractController : UIBaseController
{
	private UIHudWereWolvesInteractView m_View;

	private WereWolvesInteractType m_CurType;

	private bool m_IsInCD;

	private float m_CDEndTime;

	private bool m_InNotask;

	private bool m_CanTaskDoInForbid;

	private bool m_IsShow;

	protected BitArrayBoolean m_IsVisibleBit;

	protected const uint ISVISIBLE_TabVote = 1u;

	protected const uint ISVISIBLE_Task = 2u;

	protected const uint ISVISIBLE_Bunker = 4u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void HideVote()
	{
	}

	private void OnShowInteract(object[] data)
	{
	}

	private void SetTableVoteCD()
	{
	}

	private void StartCD()
	{
	}

	private void StopCD()
	{
	}

	private void SetCDShowContent()
	{
	}

	private void OnActClick()
	{
	}

	private void OnTableVote()
	{
	}

	private void OnTask()
	{
	}

	private void RefreshTaskBtnVisible()
	{
	}

	private void OnNoTask(object[] data)
	{
	}

	private void OnBunker()
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdateCd()
	{
	}

	private void SetVisible(uint flag, bool bVisible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
