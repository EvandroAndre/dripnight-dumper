using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal abstract class UIHudResultShowBaseController : UIHudMatchResultBaseShareController
{
	internal class AvatarProfileInfo
	{
		internal string nickName;

		internal ulong userId;

		internal uint role;

		internal string firstKey;

		internal string firstValue;

		internal string secondKey;

		internal string secondValue;

		internal int teamIndex;

		internal int rank;

		internal uint[] match_event_achievements;

		internal uint title_id;

		internal uint peak_rank_pos;

		internal string region;

		internal BadgeInfoInGame badgeInfoInGame;

		internal float BRRaing;

		internal float CSRaing;

		internal AvatarProfileInfo(PlayerData playerData)
		{
		}

		internal AvatarProfileInfo(PlayerData playerData, string firstKey, string firstValue, string secondKey, string secondValue)
		{
		}

		internal AvatarProfileInfo(UGCPlayerStats playerStats, int[] scoreTypes, int ugcGameMode)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<PlayerData, AvatarProfileInfo> _003C_003E9__31_0;

		internal AvatarProfileInfo _003CPrepareShowAvatarData_003Eb__31_0(PlayerData x)
		{
			return null;
		}
	}

	private sealed class _003CCoPlayEmotionAnimationd_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudResultShowBaseController _003C_003E4__this;

		public uint id;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoPlayEmotionAnimationd_003Ed__28(int _003C_003E1__state)
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

	private sealed class _003CStartUIUnlock_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudResultShowBaseController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartUIUnlock_003Ed__29(int _003C_003E1__state)
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

	protected GameObject ResultShowInfo;

	protected Transform result_Show_pos;

	protected Camera camera_ob_result;

	protected List<UIMaleAvatar> m_AvatarList;

	protected int EMOTE_WAIT_TIME;

	protected int CLOSE_UI_UNLOCK_TIME;

	protected int scene_id_test;

	protected bool uiCloseLock;

	private GameObject m_TeamFormatGO;

	private HashSet<Shader> m_AvatarUsedShaders;

	private Light m_MainLight;

	private Transform m_FillLightTrans;

	private float m_ShadowDistance;

	protected override void OnUIInit()
	{
	}

	private void ShowAvatar()
	{
	}

	protected void InitResultPosition()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected void CreateCamera()
	{
	}

	protected ResourceID GetTeamFormatByCount(int player_count, bool use2DBG = false)
	{
		return default(ResourceID);
	}

	protected void CreateAvatarInMatchResult(List<PlayerData> players, bool win)
	{
	}

	private void UpdateAvatarAnimatorInMatchResult(UIStatedAvatar avatar)
	{
	}

	protected void UISPHudCreateAvatarAndCallSign(List<PlayerData> players)
	{
	}

	protected UIMaleAvatar CreateMaleAvatar(PlayerData playerData, Transform parent, bool isMatchResult = false)
	{
		return null;
	}

	public abstract void CreateProfileCallSign(AvatarProfileInfo data, int index);

	protected bool IsDoubleWeild(WeaponSkinData data)
	{
		return false;
	}

	protected Vector3 ScreenToLocalPosition(UIBaseView view, Vector3 pos)
	{
		return default(Vector3);
	}

	protected virtual void PlayAvatarsEmote()
	{
	}

	private IEnumerator CoPlayEmotionAnimationd(uint id)
	{
		return null;
	}

	private IEnumerator StartUIUnlock()
	{
		return null;
	}

	protected void CreateResultShow2DWindow(bool spectator, out Camera bgCamera, out Camera avatarCamera)
	{
		bgCamera = null;
		avatarCamera = null;
	}

	protected virtual void PrepareShowAvatarData(out List<PlayerData> avatarData, out List<AvatarProfileInfo> profileData)
	{
		avatarData = null;
		profileData = null;
	}

	protected void SetAvatarShaderLod(int lod)
	{
	}

	protected void SetLightAndShadow()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
