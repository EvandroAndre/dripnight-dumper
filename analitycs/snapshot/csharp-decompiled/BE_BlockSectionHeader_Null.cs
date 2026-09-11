using COW.GamePlay;
using COW.Gameplay.UGC.BlockEdit;
using UnityEngine;

public class BE_BlockSectionHeader_Null : MonoBehaviour, JINIKKACLOC
{
	private UIWidget m_Widget;

	private BE_DataBlock m_BelongDataBlock;

	private OEHCJLCDDIE m_BelongHeader;

	private ValueData m_ValueData;

	public UILabel NameLabel;

	public int OffSetX;

	Transform JINIKKACLOC.Transform => null;

	Vector2 JINIKKACLOC.Size => default(Vector2);

	public UIWidget Widget => null;

	public BE_DataBlock BelongDataBlock
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public OEHCJLCDDIE BelongHeader
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ValueData ValueData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void UpdateDepth(int startDepth = 1)
	{
	}

	public void SetValue(string value)
	{
	}
}
