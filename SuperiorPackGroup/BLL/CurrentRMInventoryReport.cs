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
	public class CurrentRMInventoryReport
	{


		private static readonly Dictionary<VRMItemKey, VRMItem> CurrentRMInventoryDictionary = new Dictionary<VRMItemKey, VRMItem>();

		private static void AddIGStockAsRM(Session ReportSession, bool OnlyAssignedCustomers)
		{

			XPCollection<LocationInventory> igCollection = null;
			CriteriaOperatorCollection theCriteria = new CriteriaOperatorCollection();
			VRMItemKey VRMKey = new VRMItemKey();

			theCriteria.Add(new BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemType.PropertyName, "IG", BinaryOperatorType.Equal));

			if (OnlyAssignedCustomers)
			{
				theCriteria.Add(new InOperator(LocationInventory.Fields.LocationInventoryItem.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomerIDs(ReportSession)));
			}

			igCollection = new XPCollection<LocationInventory>(ReportSession, new GroupOperator(GroupOperatorType.And, theCriteria));

			foreach (LocationInventory item in igCollection)
			{
				foreach (BOMs bom in item.LocationInventoryItem.ItemBOM)
				{
					VRMKey.ItemCode = bom.BOMRawMatID.ItemCode;
					VRMKey.Location = item.Location.LocationCode;

					if (CurrentRMInventoryDictionary.ContainsKey(VRMKey))
					{
						CurrentRMInventoryDictionary[VRMKey].QuantityOnHand += Convert.ToSingle(item.QuantityOnHand * (bom.BOMQuantity + (bom.BOMQuantity * (bom.ScrapFactor / 100))));
					}
					else
					{
						if (bom.BOMRawMatID.ItemType == "RM")
						{
							CurrentRMInventoryDictionary.Add(VRMKey, new VRMItem() {Item = ReportSession.FindObject<LocationInventory>(new BinaryOperator(LocationInventory.Fields.LocationInventoryItem.PropertyName, bom.BOMRawMatID, BinaryOperatorType.Equal) & new BinaryOperator(LocationInventory.Fields.Location.PropertyName, item.Location, BinaryOperatorType.Equal))});
							CurrentRMInventoryDictionary[VRMKey].QuantityOnHand += Convert.ToSingle(item.QuantityOnHand * (bom.BOMQuantity + (bom.BOMQuantity * (bom.ScrapFactor / 100))));
						}
						else
						{
							foreach (BOMs IGbom in bom.BOMRawMatID.ItemBOM)
							{
								VRMKey.ItemCode = IGbom.BOMRawMatID.ItemCode;
								if (CurrentRMInventoryDictionary.ContainsKey(VRMKey))
								{
									CurrentRMInventoryDictionary[VRMKey].QuantityOnHand += Convert.ToSingle((item.QuantityOnHand * (bom.BOMQuantity + (bom.BOMQuantity * (bom.ScrapFactor / 100)))) * (IGbom.BOMQuantity + (IGbom.BOMQuantity * (IGbom.ScrapFactor / 100))));
								}
								else
								{
									if (IGbom.BOMRawMatID.ItemType == "RM")
									{
										CurrentRMInventoryDictionary.Add(VRMKey, new VRMItem() {Item = ReportSession.FindObject<LocationInventory>(new BinaryOperator(LocationInventory.Fields.LocationInventoryItem.PropertyName, IGbom.BOMRawMatID, BinaryOperatorType.Equal) & new BinaryOperator(LocationInventory.Fields.Location.PropertyName, item.Location, BinaryOperatorType.Equal))});
										CurrentRMInventoryDictionary[VRMKey].QuantityOnHand += Convert.ToSingle((item.QuantityOnHand * (bom.BOMQuantity + (bom.BOMQuantity * (bom.ScrapFactor / 100)))) * (IGbom.BOMQuantity + (IGbom.BOMQuantity * (IGbom.ScrapFactor / 100))));
									}
								}
							}
						}

					}
				}

				foreach (PoolBom pool in item.LocationInventoryItem.ItemPoolBom)
				{
					VRMKey.ItemCode = pool.ItemPoolID.PoolCode;
					VRMKey.Location = item.Location.LocationCode;


					if (CurrentRMInventoryDictionary.ContainsKey(VRMKey))
					{
						//this should always be true, the else is not needed.
						CurrentRMInventoryDictionary[VRMKey].QuantityOnHand += Convert.ToSingle(item.QuantityOnHand * (pool.PoolBomQuantity + (pool.PoolBomQuantity * (pool.ScrapFactor / 100))));
						//Else
						//    CurrentRMInventoryDictionary.Add(VRMKey, New VRMItem() With {.Customer = pool.ItemPoolID.PoolCustomerID, .ItemCode = pool.ItemPoolID.PoolCode, .ItemDescription = pool.ItemPoolID.PoolDescription,
						//                                                                                   .QuantityOnHand = CSng(pool.ItemPoolID.QuantityOnHand), .ItemId = pool.ItemPoolID.Oid})
						//    CurrentRMInventoryDictionary(VRMKey).QuantityOnHand += Convert.ToSingle(item.QuantityOnHand * (pool.PoolBomQuantity + (pool.PoolBomQuantity * (pool.ScrapFactor / 100))))
					}
				}
			}

		}

		private static void AddRMItems(Session ReportSession, bool OnlyAssignedCustomers)
		{

			XPCollection<LocationInventory> itemCollection = null;
			CriteriaOperatorCollection theCriteria = new CriteriaOperatorCollection();
			VRMItemKey VRMKey = new VRMItemKey();

			theCriteria.Add(new BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemType.PropertyName, "RM", BinaryOperatorType.Equal));

			if (OnlyAssignedCustomers)
			{
				theCriteria.Add(new InOperator(LocationInventory.Fields.LocationInventoryItem.ItemCustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomerIDs(ReportSession)));
			}

			itemCollection = new XPCollection<LocationInventory>(ReportSession, new GroupOperator(GroupOperatorType.And, theCriteria));

			foreach (LocationInventory item in itemCollection)
			{
				VRMKey.ItemCode = item.LocationInventoryItem.ItemCode;
				VRMKey.Location = item.Location.LocationCode;

				if (CurrentRMInventoryDictionary.ContainsKey(VRMKey))
				{
					CurrentRMInventoryDictionary[VRMKey].QuantityOnHand += item.QuantityOnHand;
				}
				else
				{
					CurrentRMInventoryDictionary.Add(VRMKey, new VRMItem() {Item = item});
				}
			}

		}

		private static void AddPoolItems(Session ReportSession, bool OnlyAssignedCustomers)
		{

			XPCollection<ItemPool> poolCollection = null;
			VRMItemKey VRMKey = new VRMItemKey();
			float Quantity = 0;

			if (OnlyAssignedCustomers)
			{
				poolCollection = new XPCollection<ItemPool>(ReportSession, new InOperator(ItemPool.Fields.PoolCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomerIDs(ReportSession)));
			}
			else
			{
				poolCollection = new XPCollection<ItemPool>(ReportSession);
			}

			foreach (ItemPool pool in poolCollection)
			{
				foreach (Locations location in new XPCollection<Locations>(ReportSession))
				{
					VRMKey.Location = location.LocationCode;

					foreach (ItemPoolDetails poolDetail in pool.Details)
					{
						VRMKey.ItemCode = poolDetail.ItemID.ItemCode;

						if (CurrentRMInventoryDictionary.ContainsKey(VRMKey))
						{
							Quantity = (float)(Quantity + (CurrentRMInventoryDictionary[VRMKey].QuantityOnHand * poolDetail.ItemPoolRatio));
							CurrentRMInventoryDictionary.Remove(VRMKey);
						}
					}

					VRMKey.ItemCode = pool.PoolCode;

					if (CurrentRMInventoryDictionary.ContainsKey(VRMKey))
					{
						//CurrentRMInventoryDictionary(VRMKey).QuantityOnHand = CSng(CurrentRMInventoryDictionary(pool.PoolCode).QuantityOnHand + pool.QuantityOnHand)
					}
					else
					{
						CurrentRMInventoryDictionary.Add(VRMKey, new VRMItem()
						{
							Customer = pool.PoolCustomerID,
							ItemCode = pool.PoolCode,
							ItemDescription = pool.PoolDescription,
							QuantityOnHand = Quantity,
							ItemId = pool.Oid
						});
					}
					Quantity = 0;
				}
			}

		}

		public static List<VRMItem> GetCurrentRmInventoryReport(bool onlyAssignedCustomers)
		{

			Session rmInvSession = new Session(MyDataLayers.SPGDataLayer);
			List<VRMItem> CurrentRMInventoryList = new List<VRMItem>();
			CurrentRMInventoryDictionary.Clear();
			rmInvSession.DropIdentityMap();

			AddRMItems(rmInvSession, onlyAssignedCustomers);
			AddPoolItems(rmInvSession, onlyAssignedCustomers);
			AddIGStockAsRM(rmInvSession, onlyAssignedCustomers);

			foreach (KeyValuePair<VRMItemKey, VRMItem> item in CurrentRMInventoryDictionary)
			{
				CurrentRMInventoryList.Add(item.Value);
			}

			return CurrentRMInventoryList;

		}

		public class VRMItem
		{

			private LocationInventory _Item;
			private bool _Inactive;

			public Customers Customer {get; set;}

			public bool Inactive
            {
                get
                {
                    if (_Inactive == false)
                    {
                        return false;
                    }
                    else
                    {
                        return _Inactive;
                    }
                }
                set => _Inactive = value;
            }

            public LocationInventory Item
            {
                get => _Item;
                set
                {
                    if (value != null)
                    {
                        Customer = value.LocationInventoryItem.ItemCustomerID;
                        Inactive = value.LocationInventoryItem.Inactive;
                        ItemCode = value.LocationInventoryItem.ItemCode;
                        ItemDescription = value.LocationInventoryItem.ItemDescription;
                        ItemId = value.LocationInventoryItem.ItemID;
                        QuantityOnHand = value.QuantityOnHand;
                        Location = value.Location.LocationCode;
                    }
                    _Item = value;
                }
            }

            public string ItemCode {get; set;}
			public string ItemDescription {get; set;}
			public int ItemId {get; set;}
			public string Location {get; set;}
			public float QuantityOnHand {get; set;}

		}

		public struct VRMItemKey
		{
			public string ItemCode {get; set;}
			public string Location {get; set;}
		}
	}

}