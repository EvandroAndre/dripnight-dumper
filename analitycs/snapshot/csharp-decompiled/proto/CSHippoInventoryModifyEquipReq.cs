using System.Collections.Generic;

namespace proto;

public class CSHippoInventoryModifyEquipReq
{
	public class ModifyInfo
	{
		public enum Type
		{
			MoveTo,
			AttachmentEquip,
			AttachmentUnEquip,
			AttachmentMove,
			Purchases
		}

		public Type type;

		public EHippoInventory.EquipType moveto_src_equip_type;

		public ulong moveto_src_inst_id;

		public uint moveto_src_item_id;

		public EHippoInventory.EquipType moveto_dst_equip_type;

		public uint moveto_dst_slot;

		public uint moveto_amount;

		public EHippoInventory.EquipType attachment_equip_src_equip_type;

		public ulong attachment_equip_src_inst_id;

		public EHippoInventory.EquipType attachment_equip_dst_equip_type;

		public ulong attachment_equip_dst_inst_id;

		public uint attachment_equip_dst_slot;

		public uint attachment_equip_src_item_id;

		public EHippoInventory.EquipType attachment_unequip_src_equip_type;

		public ulong attachment_unequip_src_inst_id;

		public uint attachment_unequip_src_slot;

		public EHippoInventory.EquipType attachment_unequip_dst_equip_type;

		public EHippoInventory.EquipType attachment_move_src_equip_type;

		public ulong attachment_move_src_inst_id;

		public uint attachment_move_src_slot;

		public EHippoInventory.EquipType attachment_move_dst_equip_type;

		public ulong attachment_move_dst_inst_id;

		public uint attachment_move_dst_slot;

		public uint purchases_store_id;

		public uint purchases_amount;

		public bool purchases_free_buy;
	}

	public List<ModifyInfo> modify_list;

	public ulong group_id;

	public ulong room_id;
}
