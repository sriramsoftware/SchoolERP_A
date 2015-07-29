/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/23/2012 8:13:55 PM                                    */
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
public partial class TMSVendorItemDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_VendorItemDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _vidDetailsId;
	private System.Int64? _vidVendorId;
	private System.String _vidItemType;
	private System.String _vidSchoolType;
	private System.String _vidSchoolSubType;
	private System.String _vidBoys;
	private System.String _vidGirls;
	private System.String _vidItemName;
	private System.String _vidBookName;
	private System.String _vidItemColor;
	private System.String _vidItemBookAuthor;
	private System.String _vidItemBookPublication;
	private System.String _vidItemSize;
	private System.String _vidItemCost;
	private System.String _vidItemStatus;
	private System.DateTime? _vidDate;
	private System.Int32? _vidStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? VIDDetailsId
	{
		get
		{
			return _vidDetailsId;
		}
		set
		{
			_vidDetailsId = value;
		}
	}
	
	public System.Int64? VIDVendorId
	{
		get
		{
			return _vidVendorId;
		}
		set
		{
			_vidVendorId = value;
		}
	}
	
	public System.String VIDItemType
	{
		get
		{
			return _vidItemType;
		}
		set
		{
			_vidItemType = value;
		}
	}
	
	public System.String VIDSchoolType
	{
		get
		{
			return _vidSchoolType;
		}
		set
		{
			_vidSchoolType = value;
		}
	}
	
	public System.String VIDSchoolSubType
	{
		get
		{
			return _vidSchoolSubType;
		}
		set
		{
			_vidSchoolSubType = value;
		}
	}
	
	public System.String VIDBoys
	{
		get
		{
			return _vidBoys;
		}
		set
		{
			_vidBoys = value;
		}
	}
	
	public System.String VIDGirls
	{
		get
		{
			return _vidGirls;
		}
		set
		{
			_vidGirls = value;
		}
	}
	
	public System.String VIDItemName
	{
		get
		{
			return _vidItemName;
		}
		set
		{
			_vidItemName = value;
		}
	}
	
	public System.String VIDBookName
	{
		get
		{
			return _vidBookName;
		}
		set
		{
			_vidBookName = value;
		}
	}
	
	public System.String VIDItemColor
	{
		get
		{
			return _vidItemColor;
		}
		set
		{
			_vidItemColor = value;
		}
	}
	
	public System.String VIDItemBookAuthor
	{
		get
		{
			return _vidItemBookAuthor;
		}
		set
		{
			_vidItemBookAuthor = value;
		}
	}
	
	public System.String VIDItemBookPublication
	{
		get
		{
			return _vidItemBookPublication;
		}
		set
		{
			_vidItemBookPublication = value;
		}
	}
	
	public System.String VIDItemSize
	{
		get
		{
			return _vidItemSize;
		}
		set
		{
			_vidItemSize = value;
		}
	}
	
	public System.String VIDItemCost
	{
		get
		{
			return _vidItemCost;
		}
		set
		{
			_vidItemCost = value;
		}
	}
	
	public System.String VIDItemStatus
	{
		get
		{
			return _vidItemStatus;
		}
		set
		{
			_vidItemStatus = value;
		}
	}
	
	public System.DateTime? VIDDate
	{
		get
		{
			return _vidDate;
		}
		set
		{
			_vidDate = value;
		}
	}
	
	public System.Int32? VIDStatus
	{
		get
		{
			return _vidStatus;
		}
		set
		{
			_vidStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("VID_DetailsId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("VID_VendorId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("VID_ItemType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VID_SchoolType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VID_SchoolSubType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VID_Boys", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VID_Girls", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VID_ItemName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VID_BookName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VID_ItemColor", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VID_ItemBookAuthor", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VID_ItemBookPublication", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VID_ItemSize", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VID_ItemCost", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VID_ItemStatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VID_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("VID_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (VIDDetailsId == null)
		dr["VID_DetailsId"] = DBNull.Value;
		else
		dr["VID_DetailsId"] = VIDDetailsId;
		
		if (VIDVendorId == null)
		dr["VID_VendorId"] = DBNull.Value;
		else
		dr["VID_VendorId"] = VIDVendorId;
		
		if (VIDItemType == null)
		dr["VID_ItemType"] = DBNull.Value;
		else
		dr["VID_ItemType"] = VIDItemType;
		
		if (VIDSchoolType == null)
		dr["VID_SchoolType"] = DBNull.Value;
		else
		dr["VID_SchoolType"] = VIDSchoolType;
		
		if (VIDSchoolSubType == null)
		dr["VID_SchoolSubType"] = DBNull.Value;
		else
		dr["VID_SchoolSubType"] = VIDSchoolSubType;
		
		if (VIDBoys == null)
		dr["VID_Boys"] = DBNull.Value;
		else
		dr["VID_Boys"] = VIDBoys;
		
		if (VIDGirls == null)
		dr["VID_Girls"] = DBNull.Value;
		else
		dr["VID_Girls"] = VIDGirls;
		
		if (VIDItemName == null)
		dr["VID_ItemName"] = DBNull.Value;
		else
		dr["VID_ItemName"] = VIDItemName;
		
		if (VIDBookName == null)
		dr["VID_BookName"] = DBNull.Value;
		else
		dr["VID_BookName"] = VIDBookName;
		
		if (VIDItemColor == null)
		dr["VID_ItemColor"] = DBNull.Value;
		else
		dr["VID_ItemColor"] = VIDItemColor;
		
		if (VIDItemBookAuthor == null)
		dr["VID_ItemBookAuthor"] = DBNull.Value;
		else
		dr["VID_ItemBookAuthor"] = VIDItemBookAuthor;
		
		if (VIDItemBookPublication == null)
		dr["VID_ItemBookPublication"] = DBNull.Value;
		else
		dr["VID_ItemBookPublication"] = VIDItemBookPublication;
		
		if (VIDItemSize == null)
		dr["VID_ItemSize"] = DBNull.Value;
		else
		dr["VID_ItemSize"] = VIDItemSize;
		
		if (VIDItemCost == null)
		dr["VID_ItemCost"] = DBNull.Value;
		else
		dr["VID_ItemCost"] = VIDItemCost;
		
		if (VIDItemStatus == null)
		dr["VID_ItemStatus"] = DBNull.Value;
		else
		dr["VID_ItemStatus"] = VIDItemStatus;
		
		if (VIDDate == null)
		dr["VID_Date"] = DBNull.Value;
		else
		dr["VID_Date"] = VIDDate;
		
		if (VIDStatus == null)
		dr["VID_Status"] = DBNull.Value;
		else
		dr["VID_Status"] = VIDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		VIDDetailsId = dr["VID_DetailsId"] != DBNull.Value ? Convert.ToInt64(dr["VID_DetailsId"]) : VIDDetailsId = null;
		VIDVendorId = dr["VID_VendorId"] != DBNull.Value ? Convert.ToInt64(dr["VID_VendorId"]) : VIDVendorId = null;
		VIDItemType = dr["VID_ItemType"] != DBNull.Value ? Convert.ToString(dr["VID_ItemType"]) : VIDItemType = null;
		VIDSchoolType = dr["VID_SchoolType"] != DBNull.Value ? Convert.ToString(dr["VID_SchoolType"]) : VIDSchoolType = null;
		VIDSchoolSubType = dr["VID_SchoolSubType"] != DBNull.Value ? Convert.ToString(dr["VID_SchoolSubType"]) : VIDSchoolSubType = null;
		VIDBoys = dr["VID_Boys"] != DBNull.Value ? Convert.ToString(dr["VID_Boys"]) : VIDBoys = null;
		VIDGirls = dr["VID_Girls"] != DBNull.Value ? Convert.ToString(dr["VID_Girls"]) : VIDGirls = null;
		VIDItemName = dr["VID_ItemName"] != DBNull.Value ? Convert.ToString(dr["VID_ItemName"]) : VIDItemName = null;
		VIDBookName = dr["VID_BookName"] != DBNull.Value ? Convert.ToString(dr["VID_BookName"]) : VIDBookName = null;
		VIDItemColor = dr["VID_ItemColor"] != DBNull.Value ? Convert.ToString(dr["VID_ItemColor"]) : VIDItemColor = null;
		VIDItemBookAuthor = dr["VID_ItemBookAuthor"] != DBNull.Value ? Convert.ToString(dr["VID_ItemBookAuthor"]) : VIDItemBookAuthor = null;
		VIDItemBookPublication = dr["VID_ItemBookPublication"] != DBNull.Value ? Convert.ToString(dr["VID_ItemBookPublication"]) : VIDItemBookPublication = null;
		VIDItemSize = dr["VID_ItemSize"] != DBNull.Value ? Convert.ToString(dr["VID_ItemSize"]) : VIDItemSize = null;
		VIDItemCost = dr["VID_ItemCost"] != DBNull.Value ? Convert.ToString(dr["VID_ItemCost"]) : VIDItemCost = null;
		VIDItemStatus = dr["VID_ItemStatus"] != DBNull.Value ? Convert.ToString(dr["VID_ItemStatus"]) : VIDItemStatus = null;
		VIDDate = dr["VID_Date"] != DBNull.Value ? Convert.ToDateTime(dr["VID_Date"]) : VIDDate = null;
		VIDStatus = dr["VID_Status"] != DBNull.Value ? Convert.ToInt32(dr["VID_Status"]) : VIDStatus = null;
	}
	
	public static TMSVendorItemDetails[] MapFrom(DataSet ds)
	{
		List<TMSVendorItemDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSVendorItemDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_VendorItemDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_VendorItemDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSVendorItemDetails instance = new TMSVendorItemDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSVendorItemDetails Get(System.Int64 vidDetailsId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSVendorItemDetails instance;
		
		
		instance = new TMSVendorItemDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVendorItemDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, vidDetailsId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSVendorItemDetails ID:" + vidDetailsId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? vidVendorId, System.String vidItemType, System.String vidSchoolType, System.String vidSchoolSubType, System.String vidBoys, System.String vidGirls, System.String vidItemName, System.String vidBookName, System.String vidItemColor, System.String vidItemBookAuthor, System.String vidItemBookPublication, System.String vidItemSize, System.String vidItemCost, System.String vidItemStatus, System.DateTime? vidDate, System.Int32? vidStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVendorItemDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, vidVendorId, vidItemType, vidSchoolType, vidSchoolSubType, vidBoys, vidGirls, vidItemName, vidBookName, vidItemColor, vidItemBookAuthor, vidItemBookPublication, vidItemSize, vidItemCost, vidItemStatus, vidDate, vidStatus);
		
		if (transaction == null)
		this.VIDDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.VIDDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? vidVendorId, System.String vidItemType, System.String vidSchoolType, System.String vidSchoolSubType, System.String vidBoys, System.String vidGirls, System.String vidItemName, System.String vidBookName, System.String vidItemColor, System.String vidItemBookAuthor, System.String vidItemBookPublication, System.String vidItemSize, System.String vidItemCost, System.String vidItemStatus, System.DateTime? vidDate, System.Int32? vidStatus)
	{
		Insert(vidVendorId, vidItemType, vidSchoolType, vidSchoolSubType, vidBoys, vidGirls, vidItemName, vidBookName, vidItemColor, vidItemBookAuthor, vidItemBookPublication, vidItemSize, vidItemCost, vidItemStatus, vidDate, vidStatus, null);
	}
	/// <summary>
	/// Insert current TMSVendorItemDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(VIDVendorId, VIDItemType, VIDSchoolType, VIDSchoolSubType, VIDBoys, VIDGirls, VIDItemName, VIDBookName, VIDItemColor, VIDItemBookAuthor, VIDItemBookPublication, VIDItemSize, VIDItemCost, VIDItemStatus, VIDDate, VIDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSVendorItemDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? vidDetailsId, System.Int64? vidVendorId, System.String vidItemType, System.String vidSchoolType, System.String vidSchoolSubType, System.String vidBoys, System.String vidGirls, System.String vidItemName, System.String vidBookName, System.String vidItemColor, System.String vidItemBookAuthor, System.String vidItemBookPublication, System.String vidItemSize, System.String vidItemCost, System.String vidItemStatus, System.DateTime? vidDate, System.Int32? vidStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVendorItemDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@vidDetailsId"].Value = vidDetailsId;
		dbCommand.Parameters["@vidVendorId"].Value = vidVendorId;
		dbCommand.Parameters["@vidItemType"].Value = vidItemType;
		dbCommand.Parameters["@vidSchoolType"].Value = vidSchoolType;
		dbCommand.Parameters["@vidSchoolSubType"].Value = vidSchoolSubType;
		dbCommand.Parameters["@vidBoys"].Value = vidBoys;
		dbCommand.Parameters["@vidGirls"].Value = vidGirls;
		dbCommand.Parameters["@vidItemName"].Value = vidItemName;
		dbCommand.Parameters["@vidBookName"].Value = vidBookName;
		dbCommand.Parameters["@vidItemColor"].Value = vidItemColor;
		dbCommand.Parameters["@vidItemBookAuthor"].Value = vidItemBookAuthor;
		dbCommand.Parameters["@vidItemBookPublication"].Value = vidItemBookPublication;
		dbCommand.Parameters["@vidItemSize"].Value = vidItemSize;
		dbCommand.Parameters["@vidItemCost"].Value = vidItemCost;
		dbCommand.Parameters["@vidItemStatus"].Value = vidItemStatus;
		dbCommand.Parameters["@vidDate"].Value = vidDate;
		dbCommand.Parameters["@vidStatus"].Value = vidStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? vidDetailsId, System.Int64? vidVendorId, System.String vidItemType, System.String vidSchoolType, System.String vidSchoolSubType, System.String vidBoys, System.String vidGirls, System.String vidItemName, System.String vidBookName, System.String vidItemColor, System.String vidItemBookAuthor, System.String vidItemBookPublication, System.String vidItemSize, System.String vidItemCost, System.String vidItemStatus, System.DateTime? vidDate, System.Int32? vidStatus)
	{
		Update(vidDetailsId, vidVendorId, vidItemType, vidSchoolType, vidSchoolSubType, vidBoys, vidGirls, vidItemName, vidBookName, vidItemColor, vidItemBookAuthor, vidItemBookPublication, vidItemSize, vidItemCost, vidItemStatus, vidDate, vidStatus, null);
	}
	
	public static void Update(TMSVendorItemDetails tMSVendorItemDetails)
	{
		tMSVendorItemDetails.Update();
	}
	
	public static void Update(TMSVendorItemDetails tMSVendorItemDetails, DbTransaction transaction)
	{
		tMSVendorItemDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSVendorItemDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@vidDetailsId"].SourceColumn = "VID_DetailsId";
		dbCommand.Parameters["@vidVendorId"].SourceColumn = "VID_VendorId";
		dbCommand.Parameters["@vidItemType"].SourceColumn = "VID_ItemType";
		dbCommand.Parameters["@vidSchoolType"].SourceColumn = "VID_SchoolType";
		dbCommand.Parameters["@vidSchoolSubType"].SourceColumn = "VID_SchoolSubType";
		dbCommand.Parameters["@vidBoys"].SourceColumn = "VID_Boys";
		dbCommand.Parameters["@vidGirls"].SourceColumn = "VID_Girls";
		dbCommand.Parameters["@vidItemName"].SourceColumn = "VID_ItemName";
		dbCommand.Parameters["@vidBookName"].SourceColumn = "VID_BookName";
		dbCommand.Parameters["@vidItemColor"].SourceColumn = "VID_ItemColor";
		dbCommand.Parameters["@vidItemBookAuthor"].SourceColumn = "VID_ItemBookAuthor";
		dbCommand.Parameters["@vidItemBookPublication"].SourceColumn = "VID_ItemBookPublication";
		dbCommand.Parameters["@vidItemSize"].SourceColumn = "VID_ItemSize";
		dbCommand.Parameters["@vidItemCost"].SourceColumn = "VID_ItemCost";
		dbCommand.Parameters["@vidItemStatus"].SourceColumn = "VID_ItemStatus";
		dbCommand.Parameters["@vidDate"].SourceColumn = "VID_Date";
		dbCommand.Parameters["@vidStatus"].SourceColumn = "VID_Status";
		
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
	public static void Delete(System.Int64? vidDetailsId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVendorItemDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, vidDetailsId);
		
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
	public static void Delete(System.Int64? vidDetailsId)
	{
		Delete(
		vidDetailsId);
	}
	
	/// <summary>
	/// Delete current TMSVendorItemDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVendorItemDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, VIDDetailsId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.VIDDetailsId = null;
	}
	
	/// <summary>
	/// Delete current TMSVendorItemDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSVendorItemDetails[] Search(System.Int64? vidDetailsId, System.Int64? vidVendorId, System.String vidItemType, System.String vidSchoolType, System.String vidSchoolSubType, System.String vidBoys, System.String vidGirls, System.String vidItemName, System.String vidBookName, System.String vidItemColor, System.String vidItemBookAuthor, System.String vidItemBookPublication, System.String vidItemSize, System.String vidItemCost, System.String vidItemStatus, System.DateTime? vidDate, System.Int32? vidStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVendorItemDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, vidDetailsId, vidVendorId, vidItemType, vidSchoolType, vidSchoolSubType, vidBoys, vidGirls, vidItemName, vidBookName, vidItemColor, vidItemBookAuthor, vidItemBookPublication, vidItemSize, vidItemCost, vidItemStatus, vidDate, vidStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSVendorItemDetails.MapFrom(ds);
	}
	
	
	public static TMSVendorItemDetails[] Search(TMSVendorItemDetails searchObject)
	{
		return Search ( searchObject.VIDDetailsId, searchObject.VIDVendorId, searchObject.VIDItemType, searchObject.VIDSchoolType, searchObject.VIDSchoolSubType, searchObject.VIDBoys, searchObject.VIDGirls, searchObject.VIDItemName, searchObject.VIDBookName, searchObject.VIDItemColor, searchObject.VIDItemBookAuthor, searchObject.VIDItemBookPublication, searchObject.VIDItemSize, searchObject.VIDItemCost, searchObject.VIDItemStatus, searchObject.VIDDate, searchObject.VIDStatus);
	}
	
	/// <summary>
	/// Returns all TMSVendorItemDetails objects.
	/// </summary>
	/// <returns>List of all TMSVendorItemDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSVendorItemDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

