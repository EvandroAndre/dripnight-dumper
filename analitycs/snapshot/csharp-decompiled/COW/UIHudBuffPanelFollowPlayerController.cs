using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudBuffPanelFollowPlayerController : UIHudNameBaseController
{
	private class EffectSlotWithLifeCycle
	{
		public VFXCreateHelper Helper;

		public UISprite BuffIcon;

		private int m_OriginChildIdx;

		public int ChildIdx;

		public AEIFBHDIIMA DisplayType;

		public float DestroyTime;

		public bool IsAvaliable;

		public void Bind(VFXCreateHelper helper, UISprite buffIcon = null)
		{
		}

		public void Show(AEIFBHDIIMA displayType, ResourceID resourceID, float lifeTime)
		{
		}

		public void ShowCustom(ResourceID resourceID, float lifeTime, ResourceID buffIconResID)
		{
		}

		public void Clear()
		{
		}

		public bool IsExpired(float now)
		{
			return false;
		}

		public void RefreshChildIdx()
		{
		}

		public void ResetChildIdx()
		{
		}

		private static int GetChildIdx(VFXCreateHelper helper)
		{
			return 0;
		}

		private void SetBuffIcon(ResourceID buffIconResID)
		{
		}
	}

	private const int CommonDisplaySlotCount = 3;

	private UIHudBuffPanelFollowPlayerView m_View;

	private BHGGAEEHJCO m_PlayerID;

	private Player m_Player;

	private bool m_IsAskingClose;

	private readonly EffectSlotWithLifeCycle m_SpecialSlot;

	private readonly EffectSlotWithLifeCycle[] m_CommonSlots;

	private readonly Dictionary<AEIFBHDIIMA, float> m_NextAllowedShowTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void BindSlots()
	{
	}

	private void AskClose()
	{
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	private void Update()
	{
	}

	public bool BindPlayer(BHGGAEEHJCO playerID)
	{
		return false;
	}

	public void UnbindPlayer()
	{
	}

	private void ResetForReuse()
	{
	}

	private bool IsBindPlayerInvalid()
	{
		return false;
	}

	public void ShowUIFXFollowPlayer(AEIFBHDIIMA displayType)
	{
	}

	public void ShowCustomUIFXFollowPlayer(ResourceID resourceID, float lifeTime, ResourceID buffIconResID)
	{
	}

	private bool IsSameTypeStillShowing(AEIFBHDIIMA displayType)
	{
		return false;
	}

	private void PlaySFX(AEIFBHDIIMA displayType)
	{
	}

	private void HideAllDisplayEffects()
	{
	}

	private void HideSpecialSlot()
	{
	}

	private void HideCommonSlots()
	{
	}

	private int FindCommonSlotToShow()
	{
		return 0;
	}

	private void MoveCommonSlotToLastChild(int slotIndex)
	{
	}

	private void ResetSlotChildIdx()
	{
	}

	private void ClearCommonDisplaySlot(int slotIndex)
	{
	}

	private EffectSlotWithLifeCycle FindSlot(AEIFBHDIIMA displayType, out int commonSlotIndex)
	{
		commonSlotIndex = default(int);
		return null;
	}

	private bool HasActiveDisplayType()
	{
		return false;
	}

	private void RepositionCommonGrid()
	{
	}

	private bool IsArmorBreakDisplayType(AEIFBHDIIMA displayType)
	{
		return false;
	}

	private ResourceID GetUIFXFollowPlayerResourceID(AEIFBHDIIMA displayType)
	{
		return default(ResourceID);
	}

	private float GetUIFXFollowPlayerLifeTime(AEIFBHDIIMA displayType)
	{
		return 0f;
	}

	private float GetUIFXFollowPlayerCooldown(AEIFBHDIIMA displayType)
	{
		return 0f;
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}
}
