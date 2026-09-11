using UnityEngine;

namespace COW;

public class ShareCamera : MonoBehaviour
{
	public delegate void AfterRender();

	private bool RenderFlag;

	private Camera ShareCam;

	private AfterRender m_AfterRenderCallBack;

	private int delayCall;

	public void RenderScreenshot(RenderTexture rt, AfterRender callback)
	{
	}

	private void OnPostRender()
	{
	}
}
