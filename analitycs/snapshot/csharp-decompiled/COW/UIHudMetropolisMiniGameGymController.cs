using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudMetropolisMiniGameGymController : UIBaseController
{
	public enum EGymSelect
	{
		None,
		Left,
		Right
	}

	private UIHudMetropolisMiniGameGymView m_View;

	private uint m_AreaID;

	private uint m_GameID;

	private uint m_Index;

	private EGymSelect m_Select;

	private BHGGAEEHJCO m_SelectPlayerID;

	private Player m_LeftPlayer;

	private Player m_RightPlayer;

	private ResourceID DefaultWeaponIcon;

	private List<int> m_GuessingList;

	private List<int> m_RewardList;

	private int m_WinReward;

	private bool m_HasInitFromConfig;

	private UITimeLabelHelper m_TimeHelper;

	private UITimeLabelHelper m_SimpleTimeHelper;

	private string WIN_REWARD_TXT;

	private UIModelMetropolis m_ModelMetropolis;

	private bool m_IsSignUp;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void Update()
	{
	}

	public void UpdateMiniGameInfo(uint areaID, uint gameID, UDPClientMessageBase msgInfo)
	{
	}

	private void updatePlayerInfo()
	{
	}

	private void OnClickGuessReward1Btn()
	{
	}

	private void OnClickGuessReward2Btn()
	{
	}

	private void OnClickRightReward3Btn()
	{
	}

	private void OnClickLeftSelectBtn()
	{
	}

	private void OnClickRightSelectBtn()
	{
	}

	private void OnClickCloseGuessBtn()
	{
	}

	private void RefreshGuessContent()
	{
	}

	private void HandleDoGuessing(uint guessIndex)
	{
	}

	private void HideAllElement()
	{
	}

	private void InitFromConfig(uint gameID)
	{
	}

	public void HandlePlayerHPChange(BHGGAEEHJCO id, int oldHP, int curHP, int maxHP)
	{
	}

	private void OnUpdateLeftPlayerHP(int oldHP, int curHP, int maxHP)
	{
	}

	private void OnUpdateRightPlayerHP(int oldHP, int curHP, int maxHP)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
