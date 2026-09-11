using GCommon;
using UnityEngine;

namespace COW.Gameplay;

public class SingleplayerForceTutorialPhaseManager : SingletonModule<SingleplayerForceTutorialPhaseManager>
{
	public enum EForceTutorialContainerType
	{
		None,
		Weapon,
		Grenade,
		SkillCard,
		Medicate
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public SingleplayerForceTutorialPhaseManager _003C_003E4__this;

		public ResourceID resourceID;

		internal void _003CPlayTutorialSound_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public SingleplayerForceTutorialPhaseManager _003C_003E4__this;

		public ResourceID resourceID;

		internal void _003CStopAndPlaySound_003Eb__0()
		{
		}
	}

	public static uint LocalPlayerAvatarID;

	public static uint LocalNPCAvatarID;

	public static uint HealWeaponID;

	private GameObject m_OneShotObj;

	private const float AudioDelayTime = 0.5f;

	private uint m_SoundDelayCallID;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void ShowTopGuide(bool isShow, uint phaseID = 0u, bool force = false, int aliveEnemyNum = 0, int totalEnemyNum = 0)
	{
	}

	public void ShowTutorialGuide(TutorialEventEnum tutorialEvent, uint phaseID = 0u, UIButton btn = null, UIWidget widget = null, int extraInfo = 0)
	{
	}

	public void ShowNavigator(bool isShow, Vector3 groundPos = default(Vector3))
	{
	}

	internal void HudChange(UIForceTutorialGameScene.HudType type, bool isShow = true)
	{
	}

	public void PlayTutorialSound(uint phaseID, int voiceIndex = 0)
	{
	}

	public void StopAndPlaySound(ResourceID resourceID)
	{
	}

	public float GetTutorialSoundLength(uint phaseID, int voiceIndex = 0)
	{
		return 0f;
	}

	private void PlaySound(ResourceID resourceID)
	{
	}

	public uint GetContainerID(EForceTutorialContainerType type)
	{
		return 0u;
	}

	public int GetBotDamageByPlayerHP(uint currentPhase)
	{
		return 0;
	}
}
