/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/31/2012 4:36:48 PM                                    */
/*                                                                          */
/* www.CodeAuthor.org                                                       */
/****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

[DataObject]
[Serializable]
public partial class TMSVendorItemOrderDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_VendorItemOrderDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _viodDetailsId;
	private System.Int64? _viodVendorManagerId;
	private System.Int64? _viodVendorId;
	private System.Int64? _viodVendorItemId;
	private System.Int32? _viodQuantity;
	private System.String _viodPerItemCost;
	private System.String _viodTotalQuantityCost;
	private System.String _viodTotalCost;
	private System.DateTime? _viodDeliveredDate;
	private System.String _viodDeliveredStatus;
	private System.String _viodOrderRemark;
	private System.DateTime? _viodDate;
	private System.Int32? _viodStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? VIODDetailsId
	{
		get
		{
			return _viodDetailsId;
		}
		set
		{
			_viodDetailsId = value;
		}
	}
	
	public System.Int64? VIODVendorManagerId
	{
		get
		{
			return _viodVendorManagerId;
		}
		set
		{
			_viodVendorManagerId = value;
		}
	}
	
	public System.Int64? VIODVendorId
	{
		get
		{
			return _viodVendorId;
		}
		set
		{
			_viodVendorId = value;
		}
	}
	
	public System.Int64? VIODVendorItemId
	{
		get
		{
			return _viodVendorItemId;
		}
		set
		{
			_viodVendorItemId = value;
		}
	}
	
	public System.Int32? VIODQuantity
	{
		get
		{
			return _viodQuantity;
		}
		set
		{
			_viodQuantity = value;
		}
	}
	
	public System.String VIODPerItemCost
	{
		get
		{
			return _viodPerItemCost;
		}
		set
		{
			_viodPerItemCost = value;
		}
	}
	
	public System.String VIODTotalQuantityCost
	{
		get
		{
			return _viodTotalQuantityCost;
		}
		set
		{
			_viodTotalQuantityCost = value;
		}
	}
	
	public System.String VIODTotalCost
	{
		get
		{
			return _viodTotalCost;
		}
		set
		{
			_viodTotalCost = value;
		}
	}
	
	public System.DateTime? VIODDeliveredDate
	{
		get
		{
			return _viodDeliveredDate;
		}
		set
		{
			_viodDeliveredDate = value;
		}
	}
	
	public System.String VIODDeliveredStatus
	{
		get
		{
			return _viodDeliveredStatus;
		}
		set
		{
			_viodDeliveredStatus = value;
		}
	}
	
	public System.String VIODOrderRemark
	{
		get
		{
			return _viodOrderRemark;
		}
		set
		{
			_viodOrderRemark = value;
		}
	}
	
	public System.DateTime? VIODDate
	{
		get
		{
			return _viodDate;
		}
		set
		{
			_viodDate = value;
		}
	}
	
	public System.Int32? VIODStatus
	{
		get
		{
			return _viodStatus;
		}
		set
		{
			_viodStatus = value;
		}
	}
	
	#endregion
	
	
	#region Methods
	
	
	#region Mapping Methods
	
	protected void MapTo(DataSet ds)
	{
		DataRow dr;
		
		
		if (ds == null)
		ds = new DataSet();
		
		if (ds.Tables["TABLE_NAME"] == null)
		ds.Tables.Add(TABLE_NAME);
		
		ds.Tables[TABLE_NAME].Columns.Add("VIOD_DetailsId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("VIOD_VendorManagerId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("VIOD_VendorId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("VIOD_VendorItemId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("VIOD_Quantity", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("VIOD_PerItemCost", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VIOD_TotalQuantityCost", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VIOD_TotalCost", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VIOD_DeliveredDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("VIOD_DeliveredStatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VIOD_OrderRemark", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VIOD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("VIOD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (VIODDetailsId == null)
		dr["VIOD_DetailsId"] = DBNull.Value;
		else
		dr["VIOD_DetailsId"] = VIODDetailsId;
		
		if (VIODVendorManagerId == null)
		dr["VIOD_VendorManagerId"] = DBNull.Value;
		else
		dr["VIOD_VendorManagerId"] = VIODVendorManagerId;
		
		if (VIODVendorId == null)
		dr["VIOD_VendorId"] = DBNull.Value;
		else
		dr["VIOD_VendorId"] = VIODVendorId;
		
		if (VIODVendorItemId == null)
		dr["VIOD_VendorItemId"] = DBNull.Value;
		else
		dr["VIOD_VendorItemId"] = VIODVendorItemId;
		
		if (VIODQuantity == null)
		dr["VIOD_Quantity"] = DBNull.Value;
		else
		dr["VIOD_Quantity"] = VIODQuantity;
		
		if (VIODPerItemCost == null)
		dr["VIOD_PerItemCost"] = DBNull.Value;
		else
		dr["VIOD_PerItemCost"] = VIODPerItemCost;
		
		if (VIODTotalQuantityCost == null)
		dr["VIOD_TotalQuantityCost"] = DBNull.Value;
		else
		dr["VIOD_TotalQuantityCost"] = VIODTotalQuantityCost;
		
		if (VIODTotalCost == null)
		dr["VIOD_TotalCost"] = DBNull.Value;
		else
		dr["VIOD_TotalCost"] = VIODTotalCost;
		
		if (VIODDeliveredDate == null)
		dr["VIOD_DeliveredDate"] = DBNull.Value;
		else
		dr["VIOD_DeliveredDate"] = VIODDeliveredDate;
		
		if (VIODDeliveredStatus == null)
		dr["VIOD_DeliveredStatus"] = DBNull.Value;
		else
		dr["VIOD_DeliveredStatus"] = VIODDeliveredStatus;
		
		if (VIODOrderRemark == null)
		dr["VIOD_OrderRemark"] = DBNull.Value;
		else
		dr["VIOD_OrderRemark"] = VIODOrderRemark;
		
		if (VIODDate == null)
		dr["VIOD_Date"] = DBNull.Value;
		else
		dr["VIOD_Date"] = VIODDate;
		
		if (VIODStatus == null)
		dr["VIOD_Status"] = DBNull.Value;
		else
		dr["VIOD_Status"] = VIODStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		VIODDetailsId = dr["VIOD_DetailsId"] != DBNull.Value ? Convert.ToInt64(dr["VIOD_DetailsId"]) : VIODDetailsId = null;
		VIODVendorManagerId = dr["VIOD_VendorManagerId"] != DBNull.Value ? Convert.ToInt64(dr["VIOD_VendorManagerId"]) : VIODVendorManagerId = null;
		VIODVendorId = dr["VIOD_VendorId"] != DBNull.Value ? Convert.ToInt64(dr["VIOD_VendorId"]) : VIODVendorId = null;
		VIODVendorItemId = dr["VIOD_VendorItemId"] != DBNull.Value ? Convert.ToInt64(dr["VIOD_VendorItemId"]) : VIODVendorItemId = null;
		VIODQuantity = dr["VIOD_Quantity"] != DBNull.Value ? Convert.ToInt32(dr["VIOD_Quantity"]) : VIODQuantity = null;
		VIODPerItemCost = dr["VIOD_PerItemCost"] != DBNull.Value ? Convert.ToString(dr["VIOD_PerItemCost"]) : VIODPerItemCost = null;
		VIODTotalQuantityCost = dr["VIOD_TotalQuantityCost"] != DBNull.Value ? Convert.ToString(dr["VIOD_TotalQuantityCost"]) : VIODTotalQuantityCost = null;
		VIODTotalCost = dr["VIOD_TotalCost"] != DBNull.Value ? Convert.ToString(dr["VIOD_TotalCost"]) : VIODTotalCost = null;
		VIODDeliveredDate = dr["VIOD_DeliveredDate"] != DBNull.Value ? Convert.ToDateTime(dr["VIOD_DeliveredDate"]) : VIODDeliveredDate = null;
		VIODDeliveredStatus = dr["VIOD_DeliveredStatus"] != DBNull.Value ? Convert.ToString(dr["VIOD_DeliveredStatus"]) : VIODDeliveredStatus = null;
		VIODOrderRemark = dr["VIOD_OrderRemark"] != DBNull.Value ? Convert.ToString(dr["VIOD_OrderRemark"]) : VIODOrderRemark = null;
		VIODDate = dr["VIOD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["VIOD_Date"]) : VIODDate = null;
		VIODStatus = dr["VIOD_Status"] != DBNull.Value ? Convert.ToInt32(dr["VIOD_Status"]) : VIODStatus = null;
	}
	
	public static TMSVendorItemOrderDetails[] MapFrom(DataSet ds)
	{
		List<TMSVendorItemOrderDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSVendorItemOrderDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_VendorItemOrderDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_VendorItemOrderDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSVendorItemOrderDetails instance = new TMSVendorItemOrderDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSVendorItemOrderDetails Get(System.Int64 viodDetailsId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSVendorItemOrderDetails instance;
		
		
		instance = new TMSVendorItemOrderDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVendorItemOrderDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, viodDetailsId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSVendorItemOrderDetails ID:" + viodDetailsId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? viodVendorManagerId, System.Int64? viodVendorId, System.Int64? viodVendorItemId, System.Int32? viodQuantity, System.String viodPerItemCost, System.String viodTotalQuantityCost, System.String viodTotalCost, System.DateTime? viodDeliveredDate, System.String viodDeliveredStatus, System.String viodOrderRemark, System.DateTime? viodDate, System.Int32? viodStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVendorItemOrderDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, viodVendorManagerId, viodVendorId, viodVendorItemId, viodQuantity, viodPerItemCost, viodTotalQuantityCost, viodTotalCost, viodDeliveredDate, viodDeliveredStatus, viodOrderRemark, viodDate, viodStatus);
		
		if (transaction == null)
		this.VIODDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.VIODDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? viodVendorManagerId, System.Int64? viodVendorId, System.Int64? viodVendorItemId, System.Int32? viodQuantity, System.String viodPerItemCost, System.String viodTotalQuantityCost, System.String viodTotalCost, System.DateTime? viodDeliveredDate, System.String viodDeliveredStatus, System.String viodOrderRemark, System.DateTime? viodDate, System.Int32? viodStatus)
	{
		Insert(viodVendorManagerId, viodVendorId, viodVendorItemId, viodQuantity, viodPerItemCost, viodTotalQuantityCost, viodTotalCost, viodDeliveredDate, viodDeliveredStatus, viodOrderRemark, viodDate, viodStatus, null);
	}
	/// <summary>
	/// Insert current TMSVendorItemOrderDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(VIODVendorManagerId, VIODVendorId, VIODVendorItemId, VIODQuantity, VIODPerItemCost, VIODTotalQuantityCost, VIODTotalCost, VIODDeliveredDate, VIODDeliveredStatus, VIODOrderRemark, VIODDate, VIODStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSVendorItemOrderDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? viodDetailsId, System.Int64? viodVendorManagerId, System.Int64? viodVendorId, System.Int64? viodVendorItemId, System.Int32? viodQuantity, System.String viodPerItemCost, System.String viodTotalQuantityCost, System.String viodTotalCost, System.DateTime? viodDeliveredDate, System.String viodDeliveredStatus, System.String viodOrderRemark, System.DateTime? viodDate, System.Int32? viodStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVendorItemOrderDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@viodDetailsId"].Value = viodDetailsId;
		dbCommand.Parameters["@viodVendorManagerId"].Value = viodVendorManagerId;
		dbCommand.Parameters["@viodVendorId"].Value = viodVendorId;
		dbCommand.Parameters["@viodVendorItemId"].Value = viodVendorItemId;
		dbCommand.Parameters["@viodQuantity"].Value = viodQuantity;
		dbCommand.Parameters["@viodPerItemCost"].Value = viodPerItemCost;
		dbCommand.Parameters["@viodTotalQuantityCost"].Value = viodTotalQuantityCost;
		dbCommand.Parameters["@viodTotalCost"].Value = viodTotalCost;
		dbCommand.Parameters["@viodDeliveredDate"].Value = viodDeliveredDate;
		dbCommand.Parameters["@viodDeliveredStatus"].Value = viodDeliveredStatus;
		dbCommand.Parameters["@viodOrderRemark"].Value = viodOrderRemark;
		dbCommand.Parameters["@viodDate"].Value = viodDate;
		dbCommand.Parameters["@viodStatus"].Value = viodStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? viodDetailsId, System.Int64? viodVendorManagerId, System.Int64? viodVendorId, System.Int64? viodVendorItemId, System.Int32? viodQuantity, System.String viodPerItemCost, System.String viodTotalQuantityCost, System.String viodTotalCost, System.DateTime? viodDeliveredDate, System.String viodDeliveredStatus, System.String viodOrderRemark, System.DateTime? viodDate, System.Int32? viodStatus)
	{
		Update(viodDetailsId, viodVendorManagerId, viodVendorId, viodVendorItemId, viodQuantity, viodPerItemCost, viodTotalQuantityCost, viodTotalCost, viodDeliveredDate, viodDeliveredStatus, viodOrderRemark, viodDate, viodStatus, null);
	}
	
	public static void Update(TMSVendorItemOrderDetails tMSVendorItemOrderDetails)
	{
		tMSVendorItemOrderDetails.Update();
	}
	
	public static void Update(TMSVendorItemOrderDetails tMSVendorItemOrderDetails, DbTransaction transaction)
	{
		tMSVendorItemOrderDetails.Update(transaction);
	}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Update(DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVendorItemOrderDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@viodDetailsId"].SourceColumn = "VIOD_DetailsId";
		dbCommand.Parameters["@viodVendorManagerId"].SourceColumn = "VIOD_VendorManagerId";
		dbCommand.Parameters["@viodVendorId"].SourceColumn = "VIOD_VendorId";
		dbCommand.Parameters["@viodVendorItemId"].SourceColumn = "VIOD_VendorItemId";
		dbCommand.Parameters["@viodQuantity"].SourceColumn = "VIOD_Quantity";
		dbCommand.Parameters["@viodPerItemCost"].SourceColumn = "VIOD_PerItemCost";
		dbCommand.Parameters["@viodTotalQuantityCost"].SourceColumn = "VIOD_TotalQuantityCost";
		dbCommand.Parameters["@viodTotalCost"].SourceColumn = "VIOD_TotalCost";
		dbCommand.Parameters["@viodDeliveredDate"].SourceColumn = "VIOD_DeliveredDate";
		dbCommand.Parameters["@viodDeliveredStatus"].SourceColumn = "VIOD_DeliveredStatus";
		dbCommand.Parameters["@viodOrderRemark"].SourceColumn = "VIOD_OrderRemark";
		dbCommand.Parameters["@viodDate"].SourceColumn = "VIOD_Date";
		dbCommand.Parameters["@viodStatus"].SourceColumn = "VIOD_Status";
		
		ds = new DataSet();
		this.MapTo( ds );
		ds.AcceptChanges();
		ds.Tables[0].Rows[0].SetModified();
		if (transaction == null)
		db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, UpdateBehavior.Standard);
		else
		db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, transaction);
		return;
	}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
	public void Update()
	{
		this.Update((DbTransaction)null);
	}
	#endregion
	
	
	#region DELETE
	[DataObjectMethodAttribute(DataObjectMethodType.Delete, false)]
	public static void Delete(System.Int64? viodDetailsId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVendorItemOrderDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, viodDetailsId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
	public static void Delete(System.Int64? viodDetailsId)
	{
		Delete(
		viodDetailsId);
	}
	
	/// <summary>
	/// Delete current TMSVendorItemOrderDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVendorItemOrderDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, VIODDetailsId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.VIODDetailsId = null;
	}
	
	/// <summary>
	/// Delete current TMSVendorItemOrderDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSVendorItemOrderDetails[] Search(System.Int64? viodDetailsId, System.Int64? viodVendorManagerId, System.Int64? viodVendorId, System.Int64? viodVendorItemId, System.Int32? viodQuantity, System.String viodPerItemCost, System.String viodTotalQuantityCost, System.String viodTotalCost, System.DateTime? viodDeliveredDate, System.String viodDeliveredStatus, System.String viodOrderRemark, System.DateTime? viodDate, System.Int32? viodStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVendorItemOrderDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, viodDetailsId, viodVendorManagerId, viodVendorId, viodVendorItemId, viodQuantity, viodPerItemCost, viodTotalQuantityCost, viodTotalCost, viodDeliveredDate, viodDeliveredStatus, viodOrderRemark, viodDate, viodStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSVendorItemOrderDetails.MapFrom(ds);
	}
	
	
	public static TMSVendorItemOrderDetails[] Search(TMSVendorItemOrderDetails searchObject)
	{
		return Search ( searchObject.VIODDetailsId, searchObject.VIODVendorManagerId, searchObject.VIODVendorId, searchObject.VIODVendorItemId, searchObject.VIODQuantity, searchObject.VIODPerItemCost, searchObject.VIODTotalQuantityCost, searchObject.VIODTotalCost, searchObject.VIODDeliveredDate, searchObject.VIODDeliveredStatus, searchObject.VIODOrderRemark, searchObject.VIODDate, searchObject.VIODStatus);
	}
	
	/// <summary>
	/// Returns all TMSVendorItemOrderDetails objects.
	/// </summary>
	/// <returns>List of all TMSVendorItemOrderDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSVendorItemOrderDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

