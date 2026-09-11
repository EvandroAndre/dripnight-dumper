using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class LockAirDropIcon
{
	public static Color ReviveBgNormal;

	public static Color ReviveBgCD;

	public static Color ItemGeneratorBg;

	public static Color ItemGeneratorAuroraBg;

	public static Color LotusLampBg;

	public static Color LotusLampProgress;

	public static Color lockAirDropStep2Color;

	public static Color lockAirDropStep3Color;

	public static Color lotusLampStep2Color;

	public static Color lotusLampStep3Color;

	public static Color lotusLampFinishedColor;

	private InteractiveState m_CurrentState;

	private int m_stepValue;

	private bool m_InTriggerAllIsEnemy;

	private Transform m_IconTrans;

	private UISprite Progress;

	private UISprite StateBg;

	private GameObject StateIcon01;

	private GameObject StateIcon02;

	private GameObject StateIcon03;

	private GameObject TimeIcon;

	private GameObject ProgressPanel;

	private UISprite progressPanelSprite;

	private GameObject FightPanel;

	private VisualInstanceHolder m_InTriggerAllIsEnemyVfx;

	private int m_Step1Value;

	private int m_Step2Value;

	private float[] m_InitValue;

	private float m_FillAmount;

	private DFMAGBNLCHD m_Type;

	private uint m_SubType;

	private int m_Step3Value;

	private string m_SpriteName;

	private string m_OrigStateBgSpriteName;

	private string m_OrigProgressSpriteName;

	public LockAirDropIcon(Transform iconTrans, DFMAGBNLCHD type, uint param, UISprite progressBg, UISprite stateBg, GameObject stateIcon, GameObject stateIcon2, GameObject stateIcon3, GameObject timeIcon, GameObject progressPanel, GameObject fightBg, string spriteName = "", uint subType = 0u)
	{
	}

	public void InitReset(DFMAGBNLCHD type, uint param, string spriteName = "", uint subType = 0u)
	{
	}

	private void SetProcessVisible(bool value)
	{
	}

	private void SetFightVisible(bool value)
	{
	}

	private void SetTimeIconVisible(bool value)
	{
	}

	public void SetState(InteractiveState state)
	{
	}

	public void SetStep(int step)
	{
	}

	public void SetTime(int time)
	{
	}

	public void Reset()
	{
	}

	private void SetStateBgSprite()
	{
	}

	private void SetProgressSprite()
	{
	}

	public void SetInTriggerAllIsEnemy(bool value)
	{
	}

	private void RefreshAllIsEnemy()
	{
	}

	private void ShowAllIsEnemyVfx(bool show)
	{
	}
}
