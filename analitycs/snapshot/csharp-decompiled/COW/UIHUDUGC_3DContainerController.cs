using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using COW.Gameplay.UGC;
using UnityEngine;

namespace COW;

public class UIHUDUGC_3DContainerController : UIHUDUGC_WidgetBaseController
{
	public UGCHud3DContainer m_Container;

	private UGCHud3DContainerRepItem m_ContainerCmpt;

	private string m_ResourceID;

	private const string PREFABID_PREFIX_REGEX = "/\\d*/";

	private string m_GOEntityID;

	private List<UGCEffectEntityRepItem> m_EffectList;

	protected override void OnDestroy()
	{
	}

	protected override void InitEntityData()
	{
	}

	public override void DestroyEntity()
	{
	}

	protected override void RefreshWidgetInfo()
	{
	}

	public void OnResourceIDChanged(string id)
	{
	}

	protected void OnScaleChanged(Vector3 cur)
	{
	}

	protected void OnRotationChanged(Vector3 cur)
	{
	}

	protected override void TryBindWidget()
	{
	}

	private bool IsPrefabID(string resourceID)
	{
		return false;
	}

	private void TryCreate3DGameObject()
	{
	}

	public override void DynamicCreateWidget(Transform parent)
	{
	}

	private void RegisterRepChangeEvent(string entityID, UGCRuntime ugcRuntime, IUGCModuleTransform trs)
	{
	}

	private void UnRegisterRepChangeEvent()
	{
	}

	public void OnEffectTypeChanged(string valueNew)
	{
	}

	public void RefreshHudDepth()
	{
	}

	private void _003CTryCreate3DGameObject_003Eb__15_0(bool succ, UGCGameObject resObj)
	{
	}

	public void _003C_003EiFixBaseProxy_InitEntityData()
	{
	}

	public new void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshWidgetInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_TryBindWidget()
	{
	}

	public void _003C_003EiFixBaseProxy_DynamicCreateWidget(Transform P0)
	{
	}
}
