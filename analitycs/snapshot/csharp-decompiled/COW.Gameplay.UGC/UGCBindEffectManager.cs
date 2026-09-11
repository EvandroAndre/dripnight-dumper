using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCBindEffectManager : MonoBehaviour
{
	private UIPanel _IconParentPanel;

	private UGCEntityDataStore m_ds;

	private UIPanel IconParentPanel => null;

	public static UGCBindEffectManager CreateInstance()
	{
		return null;
	}

	public void Init()
	{
	}

	public void Uninit()
	{
	}

	private void OnRemoveEntity(string entityID)
	{
	}

	private void OnAddPresentIcon(string entityID)
	{
	}

	private void OnAddPresentText(string entityID)
	{
	}

	private void OnAddPresentEffect(string entityID)
	{
	}

	private void OnAddEffectEntity(string entityID)
	{
	}

	private void OnAddPresentSound(string entityID)
	{
	}

	private void OnAddSoundEntity(string entityID)
	{
	}

	private void OnAddAirDropEntity(string entityID)
	{
	}

	private void AddEffectToSubLevel(string entityID, GameObject obj)
	{
	}
}
