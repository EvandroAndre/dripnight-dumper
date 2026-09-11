using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlanarShadowManager : MonoSingleton<PlanarShadowManager>
{
	private const CameraEvent CAMERA_EVENT = CameraEvent.AfterForwardOpaque;

	private Material mainShadowMat;

	private int centerPoint;

	private int planeNormal;

	private int mainLightDir;

	private HashSet<RenderNode_Shadow> m_rendererList;

	private HashSet<LightNode_Shadow> m_lightList;

	private List<PlaneNode_Shadow> m_planeList;

	private LightNode_Shadow m_mainLight;

	private Camera m_camera;

	private Transform m_shadowPlane;

	private Renderer m_shadowPlaneRenderer;

	private ShadowResolution originalShadowResolution;

	public override void Init()
	{
	}

	public void UpdatePlanarShadow(Renderer[] renderers, Camera camera, GameObject avatarLightGo, Transform shadowPlane)
	{
	}

	public void UpdatePlanarShadow(Renderer renderer, Camera camera, GameObject avatarLightGo, Transform shadowPlane)
	{
	}

	public void UpdateRenderer(Renderer[] renderers)
	{
	}

	public void UpdateRenderer(Renderer renderer)
	{
	}

	public void UpdateAvatarLight(GameObject avatarLightGo)
	{
	}

	public void UpdateReceivedShadowPlane(Transform lobbyShadowParent)
	{
	}

	public void UpdateCamera(Camera camera)
	{
	}

	private void FindMainLight(LightNode_Shadow lightNode, bool isActive)
	{
	}

	private void UpdateMainLight()
	{
	}

	private bool CheckShadowCondition(RenderNode_Shadow node)
	{
		return false;
	}

	private void InitCommandBuffer(Renderer renderer, CommandBuffer commandBuffer)
	{
	}

	private void RefreshCommandBuffer()
	{
	}

	private void RefreshCommandBuffer(RenderNode_Shadow node, bool isActive)
	{
	}

	private void MainCameraController(int mode, CommandBuffer commandBuffer = null)
	{
	}

	public void OnRendererStateChanged(RenderNode_Shadow rnode, bool isActive)
	{
	}

	public void OnLightStateChanged(LightNode_Shadow lnode, bool isActive)
	{
	}

	public void OnPlaneStateChanged(PlaneNode_Shadow pnode, bool isActive)
	{
	}

	public void OnCameraStateChanged(CameraNode_Shadow cnode, bool isActive)
	{
	}

	private void InitMainShadowMaterial()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void SwithShadowState(bool drawingPlanarShadow)
	{
	}

	private void ChangeShadowmapSize(bool drawingPlanarShadow)
	{
	}

	private bool IsSkinnedMeshRenderer(Renderer renderer)
	{
		return false;
	}

	private void RefreshReceiveShadowPlane(PlaneNode_Shadow pnode)
	{
	}

	private void RefreshReceiver(PlaneNode_Shadow pnode = null)
	{
	}

	private bool IsVisableInCurCamera(Vector3 pos)
	{
		return false;
	}

	private bool DontCastShadow(Renderer renderer)
	{
		return false;
	}

	private bool DontCastShadow(Renderer renderer, int matIndex)
	{
		return false;
	}
}
