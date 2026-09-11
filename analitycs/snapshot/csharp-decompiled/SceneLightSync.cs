using COW.GamePlay;
using UnityEngine;

public class SceneLightSync : MonoBehaviour
{
	private readonly string MAINLIGHTNAME;

	private readonly string BACKLIGHTNAME;

	private readonly string PREFABNAME;

	public GameObject PrefabScene;

	public Light MainLight;

	public Light BackLight;

	public float CharLightOFF;

	public float CharLightON;

	public bool isBrightness;

	private SceneGraphicsOverride m_sgo;

	private bool m_isInit;
}
