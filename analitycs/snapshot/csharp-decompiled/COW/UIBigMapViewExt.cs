using UnityEngine;

namespace COW;

internal class UIBigMapViewExt : UIBigMapView
{
	private float MAP_SIZE_HEIGHT;

	private Vector3 m_MapLocalScale;

	private float m_Width;

	private float m_Height;

	private const int ZOOMWIDTH = 659;

	private Vector3 v3_offset;

	public Vector3 MinMapLocalScale => default(Vector3);

	protected override void OnInit(Transform holder)
	{
	}

	public void RefreshScale()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
