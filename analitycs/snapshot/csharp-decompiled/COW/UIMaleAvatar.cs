using System.Collections.Generic;
using GCommon;
using UMA;
using UnityEngine;
using UnityEngine.Rendering;
using tcp;

namespace COW;

public class UIMaleAvatar : UIStatedAvatar
{
	public class EffectBundle
	{
		public Material Mat;

		public CommandBuffer Command;

		public Camera Camera;

		public CameraEvent CamEvent;

		public bool EnableLightingFix;
	}

	public static UIMaleAvatar LocalAvatar;

	public static uint WaitedFrames;

	private GameObject m_PlaneGO;

	private int m_LayerReplaceMask;

	private Dictionary<Renderer, int> m_VFXRenderersWithLayer;

	private LazyDictionary<int, EffectBundle> m_EffectBundleDic;

	private int m_LayerEntityValue;

	private int m_LayerEntityOthers;

	private int m_MaterialIndex;

	private string playFlightAnimID;

	public bool IsAvatarReady => false;

	public ulong AccountId
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public static UIMaleAvatar GetLocalAvatar()
	{
		return null;
	}

	private static void SetLocalAvatar(UIMaleAvatar s)
	{
	}

	public static UIMaleAvatar CreateAvatar(bool female)
	{
		return null;
	}

	public override void RegisterPausableManager()
	{
	}

	public override void InitAvatar(bool isLocal, bool isPreviewAvatar = false, int textureScale = 1, FrontEndPreviewComponent frontEndPreviewComponent = null, bool isTeammate = false)
	{
	}

	private void OnDisable()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	private void OnQualityChanged(object[] data)
	{
	}

	public void SetLightVisble(bool isVisble)
	{
	}

	public void SetLightLayer(int layer)
	{
	}

	protected override void CharacterUpdateCallBack(UMAData umaData)
	{
	}

	public void SetCastShadow(bool castShadow, EFrontendPlannarShadowType ePlannarShadowType = EFrontendPlannarShadowType.Main)
	{
	}

	public void SetAvatarPlaneShow(bool isShow)
	{
	}

	private void InitPlaneGo()
	{
	}

	public void StartShowGachaPose()
	{
	}

	public void SetAvatarData(UIModelAvatarBase.AvatarData aData, uint collectionid = 0u, uint collectionLevel = 3u)
	{
	}

	public void OnClothUpdate(object[] data)
	{
	}

	public void SetForceChangeRace()
	{
	}

	public void ResetToModelCurrentAvatar(bool resetcollection = true)
	{
	}

	public void InitMatchResultTeammatesAnim(bool win, bool hasWeapon, bool isKnife, GunType gunType)
	{
	}

	public void InitMatchResultMVPAnim(bool win)
	{
	}

	public void PlayMVPAnim()
	{
	}

	public float PlayGroupAnimAsMVP(ResourceID resID)
	{
		return 0f;
	}

	public float PlayFreezeGroupAnimAsMvp(ResourceID groupAnimId, ResourceID freezeIdleAnimId)
	{
		return 0f;
	}

	protected override void DoUpdate()
	{
	}

	public void SetAvatarForward(bool isForward, bool adaptBackpack)
	{
	}

	public void SetAvatarPos(Vector3 localPos)
	{
	}

	public void SetAvatarPosOffset(Vector3 localPos)
	{
	}

	public Vector3 GetAvatarWorldPos()
	{
		return default(Vector3);
	}

	public Transform GetAvatarTransform()
	{
		return null;
	}

	public void SetAvatarPosByWorldPos(Vector3 worldPos)
	{
	}

	public void SetAvatarRotate(float rotateY, bool offsetParentY = false)
	{
	}

	public void AnimationHide(int hideEffect)
	{
	}

	public void AnimationShow(int showEffect)
	{
	}

	public override void UpdateAnimationEvent(bool flag = true, bool effectFlag = true)
	{
	}

	public void VFXHide(int showEffect)
	{
	}

	public void VFXShow(int showEffect)
	{
	}

	public bool GetVisibleState()
	{
		return false;
	}

	public void PreviewPermanentEffect(uint effectItemID)
	{
	}

	public void LoadTailorClothTriggerEffect(uint effectItemID)
	{
	}

	public void PreviewEventTriggerEffect(uint effectItemID)
	{
	}

	public void ShowPrivilegeTriggerEffect()
	{
	}

	public void PreviewEventTriggerEffect(ClothTriggerEffectPreviewData data)
	{
	}

	public void PreviewMultipleTriggerEffectAnim(ClothTriggerEffectPreviewData data, ResourceID animId)
	{
	}

	public void PreviewTailorFootHalo()
	{
	}

	public void PreviewTailorSpotLight()
	{
	}

	public void SetTailorLobbyEffectVisible(bool show)
	{
	}

	public void RefreshTailorEffect()
	{
	}

	public int SetAdditiveEffect(Material mat, Camera cam, CameraEvent cameraEvent = CameraEvent.AfterForwardAlpha, bool enableLightingFix = false)
	{
		return 0;
	}

	public void RemoveAdditiveEffect(int index)
	{
	}

	private void RemoveCommand(int index)
	{
	}

	private void RemoveDic(int index)
	{
	}

	public void OnEffectDestory()
	{
	}

	private void RemoveCommandBuffer(int index)
	{
	}

	private Light ResolveAdditiveMainLight()
	{
		return null;
	}

	private void AddCommandBuffer(int index)
	{
	}

	public static UIMaleAvatar GetUIMaleAvatarComponent(GameObject gameObject)
	{
		return null;
	}

	public static TransformEmoteInfo GetTransformEmoteInfo()
	{
		return null;
	}

	public void PlayAvatarAnimOnFlight(string animId)
	{
	}

	private void UpdateAvatarAnimOnFlight(UIStatedAvatar s)
	{
	}

	public void ResetFlightPreviewAnim()
	{
	}

	public void _003C_003EiFixBaseProxy_RegisterPausableManager()
	{
	}

	public new void _003C_003EiFixBaseProxy_InitAvatar(bool P0, bool P1, int P2, FrontEndPreviewComponent P3, bool P4)
	{
	}

	public void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_CharacterUpdateCallBack(UMAData P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DoUpdate()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateAnimationEvent(bool P0, bool P1)
	{
	}
}
