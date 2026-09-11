using System.Text;
using GCommon;

namespace COW;

public class UIHUDArmsRaceTeamMatchInfoController : UIBaseController
{
	private UIHUDArmsRaceTeamMatchInfoView m_View;

	private int m_SelfArmLevel;

	private int m_OpponentArmLevel;

	private uint m_GameEndTimeMS;

	private uint mSeconds;

	private StringBuilder m_Timer;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnGameArmsListCome(object[] param)
	{
	}

	private void UpdateMaxLevel()
	{
	}

	private void OnBattleTimeCome(object[] parma)
	{
	}

	private void OnSelfArmLevelCome(object[] param)
	{
	}

	private void OnOpponentArmLevelCome(object[] param)
	{
	}

	private void UpdateSelfArmInfo()
	{
	}

	private void UpdateOpponentArmInfo()
	{
	}

	private void SetWeaponIcon(uint weaponID, UISprite uiSprite)
	{
	}

	private void Update()
	{
	}

	private void OpenScoreBoard()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
