using UnityEngine;

public class UILabelCustomMaterial : MonoBehaviour
{
	public bool addMode;

	public Texture detailTex;

	public Vector2 detailTilling;

	public Vector2 detailPanner;

	public Color color;

	private Material fontMaterial;

	private Vector3 posTemp;

	private UILabel label;

	private int _LabelPos_ID;

	private int _Color_ID;

	private int _rFontSize_ID;

	private int _DetailTex_ID;

	private int _DetailPanner_ID;

	private int LabelPosID => 0;

	private int ColorID => 0;

	private int rFontSizeID => 0;

	private int DetailTexID => 0;

	private int DetailPannerID => 0;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnCustomMaterialRender(Material mat)
	{
	}

	private void SetMaterialProperty(Material mat)
	{
	}
}
