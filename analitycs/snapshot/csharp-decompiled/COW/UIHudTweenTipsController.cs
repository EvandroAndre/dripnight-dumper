using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudTweenTipsController : UIBaseController
{
	private sealed class _003CManualHideCoroutine_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudTweenTipsController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CManualHideCoroutine_003Ed__68(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public const uint VISIBILITY_STATE_EighthTips = 1073741824u;

	public const uint VISIBILITY_STATE_EighthStation = 536870912u;

	public const uint VISIBILITY_STATE_DIWALI25GP = 268435456u;

	public const uint VISIBILITY_STATE_MapThrower = 134217728u;

	private UIHudTweenTipsView m_View;

	private uint m_DelayCallID;

	private string IconName_UAV;

	private string IconName_TeleportDoor;

	private string IconName_Zeppelin;

	private string IconName_GuildWar_Box;

	private string IconName_Training_Max_Killer;

	private string IconName_Bomb;

	private string IconName_Common;

	private string IconName_Ludo_BonusDice;

	private string IconName_Ludo_NoMove;

	private string IconName_Zombie;

	private string IconName_DeathMatchKillerKing;

	private string IconName_HalloweenBoss;

	private string Iconname_LockAirDrop;

	private string Iconname_Football;

	private string Iconname_IceWallMaker;

	private string Iconname_HuntingGroundWave;

	private string Iconname_SeafoodLittleGirl;

	private string Iconname_SeafoodCookieShop;

	private string Iconname_SocialLobbyRecruit;

	private string Iconname_SeafoodGlassBridge;

	private string Iconname_HomerSkillUAV;

	private const string IconName_BooyahBountyRankingStatue = "UI_BDBR_icon_Trophy";

	private const float AnimDuration = 2f;

	private float m_TimePlayed;

	private bool m_PauseFinished;

	private uint m_PauseDelay;

	private float m_NeedPauseSecs;

	private UIAtlas m_DefaultIngameHudAtlas;

	private UIAtlas m_DefaultBGAtlas;

	private string m_DefaultBGSpriteName;

	private int m_DefaultBGTopAnchorAbsolute;

	private int m_DefaultBGBottomAnchorAbsolute;

	private int m_DefaultBGLeftAnchorAbsolute;

	private int m_DefaultBGRightAnchorAbsolute;

	private float m_DefaultMsgTxtPosX;

	private Action m_delayCallAction;

	private uint m_AnchorEffectID;

	private Color m_DefaultIconColor;

	private Color m_DefaultTextColor;

	private UILabel.Effect m_DefaultMessageTextEffectStyle;

	private AnimationClip m_clip;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void Update()
	{
	}

	private void PauseFinished()
	{
	}

	private void SetMessageIconAsync(ResourceID iconRes)
	{
	}

	private void SetMessageTextColor(Color color = default(Color))
	{
	}

	private void SetMessageIconColor(Color color = default(Color))
	{
	}

	private void SetMessageTextEffectStyle(bool useShadow = true)
	{
	}

	private void TrySetMsgLabelToCenterIfHasNoIcon()
	{
	}

	public void SetMessage(string message, float duration, InGameEventTipsType tipsType, int offset)
	{
	}

	private void SetBG(InGameEventTipsType tipsType)
	{
	}

	private void SetBgSpriteName(string bgName, string bgAnchor = "")
	{
	}

	public void SetMessageWithIcon(string message, float duration, ResourceID iconRes, int yOffset = 0, Color color = default(Color))
	{
	}

	public void SetMessageWithIconAndBg(string message, float duration, string iconRes, string bgRes, string bgAnchor, Color txtColor, bool useShadow = true, Color iconColor = default(Color), bool disableAnimation = false)
	{
	}

	public void PlayBGEffect(ResourceID effectRes, float duration)
	{
	}

	private void OnAnchorEffectLoaded(uint uniqueID, ResourceID vfxResID, GameObject instance)
	{
	}

	private void DetachAnchorEffect()
	{
	}

	private void SetData(string message, float duration, Color color = default(Color), bool disableAnimation = false)
	{
	}

	public void ManualHide()
	{
	}

	private IEnumerator ManualHideCoroutine()
	{
		return null;
	}

	private string GetIconName(InGameEventTipsType tipsType, ref bool isDefaultIngameHudAtlasIcon)
	{
		return null;
	}

	private void AutoHide()
	{
	}

	private void CancelDelayCall()
	{
	}

	protected override void OnDestroy()
	{
	}

	public Vector3 GetMessagePos()
	{
		return default(Vector3);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
