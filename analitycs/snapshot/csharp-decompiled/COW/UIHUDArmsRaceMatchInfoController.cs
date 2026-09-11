using System.Text;
using GCommon;

namespace COW;

public class UIHUDArmsRaceMatchInfoController : UIBaseController
{
	private UIHUDArmsRaceMatchInfoView m_View;

	private int m_SelfRank;

	private int m_SelfArmLevel;

	private int m_TopArmLevel;

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

	private void OnBattleTimeCome(object[] parma)
	{
	}

	private void OnSelfArmLevelCome(object[] param)
	{
	}

	private void OnSelfRankCome(object[] param)
	{
	}

	private void OnTopPlayerArmLevelCome(object[] param)
	{
	}

	private void UpdateMaxLevel()
	{
	}

	private void UpdateSelfArmInfo()
	{
	}

	private void UpdateTopArmInfo()
	{
	}

	private void UpdateSelfRank()
	{
	}

	private void SetWeaponIcon(uint weaponID, UISprite uiSprite)
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
