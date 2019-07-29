//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DXDAL.SPGData;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace SuperiorPackGroup
{
	public class LocationInventoryBLL
	{

		public static void UpdateStock(Session session, int ItemID, int LocationID, float Quantity, string lot = "", int? LPNNumber = null, DateTime? ExpirationDate = null,bool newInventory = true)
		{
            if (newInventory)
            {
                LocationInventory inventory = session.FindObject<LocationInventory>(new BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, ItemID, BinaryOperatorType.Equal) & new BinaryOperator(LocationInventory.Fields.Location.Oid.PropertyName, LocationID, BinaryOperatorType.Equal));

			    if (inventory == null)
			    {
				    inventory = new LocationInventory(session);
				    inventory.LocationInventoryItem = session.GetObjectByKey<Items>(ItemID);
				    inventory.Location = session.GetObjectByKey<Locations>(LocationID);
				    inventory.QuantityOnHand = Quantity;
			    }
			    else
			    {
				    inventory.QuantityOnHand += Quantity;
			    }

			    inventory.Save();
            }
			

			if (((lot == null) || string.IsNullOrEmpty(lot)) && ((LPNNumber == null) || LPNNumber == 0))
			{
				return;
			}

			LocationInventoryByLot inventoryByLot = session.FindObject<LocationInventoryByLot>(new BinaryOperator(LocationInventoryByLot.Fields.LocationInventoryItem.ItemID.PropertyName, ItemID, BinaryOperatorType.Equal) & new BinaryOperator(LocationInventoryByLot.Fields.Location.Oid.PropertyName, LocationID, BinaryOperatorType.Equal) & new BinaryOperator(LocationInventoryByLot.Fields.LocationInventoryLot, lot, BinaryOperatorType.Equal) & new BinaryOperator(LocationInventoryByLot.Fields.LPNNumber, (LPNNumber ?? 0), BinaryOperatorType.Equal));

			if (inventoryByLot == null)
			{
				if (Quantity >= 0)
				{
					inventoryByLot = new LocationInventoryByLot(session);
					inventoryByLot.LocationInventoryItem = session.GetObjectByKey<Items>(ItemID);
					inventoryByLot.Location = session.GetObjectByKey<Locations>(LocationID);
					inventoryByLot.LocationInventoryLot = lot;
					inventoryByLot.LPNNumber = LPNNumber;
					inventoryByLot.QuantityOnHand = Quantity;
					if (ExpirationDate != null)
					{
						inventoryByLot.ExpirationDate = ExpirationDate;
					}
				}
				else
				{
					return;
				}
			}
			else
			{
				inventoryByLot.QuantityOnHand += Quantity;
			}

			inventoryByLot.Save();

		}

	}

}