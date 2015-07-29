/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 12/21/2012 4:23:04 PM                                    */
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
public partial class TMSBusStaffDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_BusStaffDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _bsdStaffId;
	private System.Int64? _bsdTransportManagerID;
	private System.String _bsdStaffType;
	private System.String _bsdStaffName;
	private System.String _bsdImage;
	private System.Int64? _bsdAddressId;
	private System.DateTime? _bsdDateOfJoining;
	private System.String _bsdLicenceNo;
	private System.DateTime? _bsdDate;
	private System.Int32? _bsdStatus;
	private System.String _bsdBusStaffId;
	private System.String _bsdBusLicenceImage;
	
	#endregion
	
	
	#region Properties
	public System.Int64? BSDStaffId
	{
		get
		{
			return _bsdStaffId;
		}
		set
		{
			_bsdStaffId = value;
		}
	}
	
	public System.Int64? BSDTransportManagerID
	{
		get
		{
			return _bsdTransportManagerID;
		}
		set
		{
			_bsdTransportManagerID = value;
		}
	}
	
	public System.String BSDStaffType
	{
		get
		{
			return _bsdStaffType;
		}
		set
		{
			_bsdStaffType = value;
		}
	}
	
	public System.String BSDStaffName
	{
		get
		{
			return _bsdStaffName;
		}
		set
		{
			_bsdStaffName = value;
		}
	}
	
	public System.String BSDImage
	{
		get
		{
			return _bsdImage;
		}
		set
		{
			_bsdImage = value;
		}
	}
	
	public System.Int64? BSDAddressId
	{
		get
		{
			return _bsdAddressId;
		}
		set
		{
			_bsdAddressId = value;
		}
	}
	
	public System.DateTime? BSDDateOfJoining
	{
		get
		{
			return _bsdDateOfJoining;
		}
		set
		{
			_bsdDateOfJoining = value;
		}
	}
	
	public System.String BSDLicenceNo
	{
		get
		{
			return _bsdLicenceNo;
		}
		set
		{
			_bsdLicenceNo = value;
		}
	}
	
	public System.DateTime? BSDDate
	{
		get
		{
			return _bsdDate;
		}
		set
		{
			_bsdDate = value;
		}
	}
	
	public System.Int32? BSDStatus
	{
		get
		{
			return _bsdStatus;
		}
		set
		{
			_bsdStatus = value;
		}
	}
	
	public System.String BSDBusStaffId
	{
		get
		{
			return _bsdBusStaffId;
		}
		set
		{
			_bsdBusStaffId = value;
		}
	}
	
	public System.String BSDBusLicenceImage
	{
		get
		{
			return _bsdBusLicenceImage;
		}
		set
		{
			_bsdBusLicenceImage = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("BSD_StaffId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BSD_TransportManagerID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BSD_StaffType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BSD_StaffName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BSD_Image", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BSD_AddressId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BSD_DateOfJoining", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("BSD_LicenceNo", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BSD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("BSD_Status", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("BSD_BusStaffId", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BSD_BusLicenceImage", typeof(System.String) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (BSDStaffId == null)
		dr["BSD_StaffId"] = DBNull.Value;
		else
		dr["BSD_StaffId"] = BSDStaffId;
		
		if (BSDTransportManagerID == null)
		dr["BSD_TransportManagerID"] = DBNull.Value;
		else
		dr["BSD_TransportManagerID"] = BSDTransportManagerID;
		
		if (BSDStaffType == null)
		dr["BSD_StaffType"] = DBNull.Value;
		else
		dr["BSD_StaffType"] = BSDStaffType;
		
		if (BSDStaffName == null)
		dr["BSD_StaffName"] = DBNull.Value;
		else
		dr["BSD_StaffName"] = BSDStaffName;
		
		if (BSDImage == null)
		dr["BSD_Image"] = DBNull.Value;
		else
		dr["BSD_Image"] = BSDImage;
		
		if (BSDAddressId == null)
		dr["BSD_AddressId"] = DBNull.Value;
		else
		dr["BSD_AddressId"] = BSDAddressId;
		
		if (BSDDateOfJoining == null)
		dr["BSD_DateOfJoining"] = DBNull.Value;
		else
		dr["BSD_DateOfJoining"] = BSDDateOfJoining;
		
		if (BSDLicenceNo == null)
		dr["BSD_LicenceNo"] = DBNull.Value;
		else
		dr["BSD_LicenceNo"] = BSDLicenceNo;
		
		if (BSDDate == null)
		dr["BSD_Date"] = DBNull.Value;
		else
		dr["BSD_Date"] = BSDDate;
		
		if (BSDStatus == null)
		dr["BSD_Status"] = DBNull.Value;
		else
		dr["BSD_Status"] = BSDStatus;
		
		if (BSDBusStaffId == null)
		dr["BSD_BusStaffId"] = DBNull.Value;
		else
		dr["BSD_BusStaffId"] = BSDBusStaffId;
		
		if (BSDBusLicenceImage == null)
		dr["BSD_BusLicenceImage"] = DBNull.Value;
		else
		dr["BSD_BusLicenceImage"] = BSDBusLicenceImage;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		BSDStaffId = dr["BSD_StaffId"] != DBNull.Value ? Convert.ToInt64(dr["BSD_StaffId"]) : BSDStaffId = null;
		BSDTransportManagerID = dr["BSD_TransportManagerID"] != DBNull.Value ? Convert.ToInt64(dr["BSD_TransportManagerID"]) : BSDTransportManagerID = null;
		BSDStaffType = dr["BSD_StaffType"] != DBNull.Value ? Convert.ToString(dr["BSD_StaffType"]) : BSDStaffType = null;
		BSDStaffName = dr["BSD_StaffName"] != DBNull.Value ? Convert.ToString(dr["BSD_StaffName"]) : BSDStaffName = null;
		BSDImage = dr["BSD_Image"] != DBNull.Value ? Convert.ToString(dr["BSD_Image"]) : BSDImage = null;
		BSDAddressId = dr["BSD_AddressId"] != DBNull.Value ? Convert.ToInt64(dr["BSD_AddressId"]) : BSDAddressId = null;
		BSDDateOfJoining = dr["BSD_DateOfJoining"] != DBNull.Value ? Convert.ToDateTime(dr["BSD_DateOfJoining"]) : BSDDateOfJoining = null;
		BSDLicenceNo = dr["BSD_LicenceNo"] != DBNull.Value ? Convert.ToString(dr["BSD_LicenceNo"]) : BSDLicenceNo = null;
		BSDDate = dr["BSD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["BSD_Date"]) : BSDDate = null;
		BSDStatus = dr["BSD_Status"] != DBNull.Value ? Convert.ToInt32(dr["BSD_Status"]) : BSDStatus = null;
		BSDBusStaffId = dr["BSD_BusStaffId"] != DBNull.Value ? Convert.ToString(dr["BSD_BusStaffId"]) : BSDBusStaffId = null;
		BSDBusLicenceImage = dr["BSD_BusLicenceImage"] != DBNull.Value ? Convert.ToString(dr["BSD_BusLicenceImage"]) : BSDBusLicenceImage = null;
	}
	
	public static TMSBusStaffDetails[] MapFrom(DataSet ds)
	{
		List<TMSBusStaffDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSBusStaffDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_BusStaffDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_BusStaffDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSBusStaffDetails instance = new TMSBusStaffDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBusStaffDetails Get(System.Int64 bsdStaffId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSBusStaffDetails instance;
		
		
		instance = new TMSBusStaffDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusStaffDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bsdStaffId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSBusStaffDetails ID:" + bsdStaffId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? bsdTransportManagerID, System.String bsdStaffType, System.String bsdStaffName, System.String bsdImage, System.Int64? bsdAddressId, System.DateTime? bsdDateOfJoining, System.String bsdLicenceNo, System.DateTime? bsdDate, System.Int32? bsdStatus, System.String bsdBusLicenceImage, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusStaffDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bsdTransportManagerID, bsdStaffType, bsdStaffName, bsdImage, bsdAddressId, bsdDateOfJoining, bsdLicenceNo, bsdDate, bsdStatus, bsdBusLicenceImage);
		
		if (transaction == null)
		this.BSDStaffId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.BSDStaffId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? bsdTransportManagerID, System.String bsdStaffType, System.String bsdStaffName, System.String bsdImage, System.Int64? bsdAddressId, System.DateTime? bsdDateOfJoining, System.String bsdLicenceNo, System.DateTime? bsdDate, System.Int32? bsdStatus, System.String bsdBusLicenceImage)
	{
		Insert(bsdTransportManagerID, bsdStaffType, bsdStaffName, bsdImage, bsdAddressId, bsdDateOfJoining, bsdLicenceNo, bsdDate, bsdStatus, bsdBusLicenceImage, null);
	}
	/// <summary>
	/// Insert current TMSBusStaffDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(BSDTransportManagerID, BSDStaffType, BSDStaffName, BSDImage, BSDAddressId, BSDDateOfJoining, BSDLicenceNo, BSDDate, BSDStatus, BSDBusLicenceImage, transaction);
	}
	
	/// <summary>
	/// Insert current TMSBusStaffDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? bsdStaffId, System.Int64? bsdTransportManagerID, System.String bsdStaffType, System.String bsdStaffName, System.String bsdImage, System.Int64? bsdAddressId, System.DateTime? bsdDateOfJoining, System.String bsdLicenceNo, System.DateTime? bsdDate, System.Int32? bsdStatus, System.String bsdBusStaffId, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusStaffDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@bsdStaffId"].Value = bsdStaffId;
		dbCommand.Parameters["@bsdTransportManagerID"].Value = bsdTransportManagerID;
		dbCommand.Parameters["@bsdStaffType"].Value = bsdStaffType;
		dbCommand.Parameters["@bsdStaffName"].Value = bsdStaffName;
		dbCommand.Parameters["@bsdImage"].Value = bsdImage;
		dbCommand.Parameters["@bsdAddressId"].Value = bsdAddressId;
		dbCommand.Parameters["@bsdDateOfJoining"].Value = bsdDateOfJoining;
		dbCommand.Parameters["@bsdLicenceNo"].Value = bsdLicenceNo;
		dbCommand.Parameters["@bsdDate"].Value = bsdDate;
		dbCommand.Parameters["@bsdStatus"].Value = bsdStatus;
		dbCommand.Parameters["@bsdBusLicenceImage"].Value = bsdBusStaffId;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? bsdStaffId, System.Int64? bsdTransportManagerID, System.String bsdStaffType, System.String bsdStaffName, System.String bsdImage, System.Int64? bsdAddressId, System.DateTime? bsdDateOfJoining, System.String bsdLicenceNo, System.DateTime? bsdDate, System.Int32? bsdStatus, System.String bsdBusStaffId)
	{
		Update(bsdStaffId, bsdTransportManagerID, bsdStaffType, bsdStaffName, bsdImage, bsdAddressId, bsdDateOfJoining, bsdLicenceNo, bsdDate, bsdStatus, bsdBusStaffId, null);
	}
	
	public static void Update(TMSBusStaffDetails tMSBusStaffDetails)
	{
		tMSBusStaffDetails.Update();
	}
	
	public static void Update(TMSBusStaffDetails tMSBusStaffDetails, DbTransaction transaction)
	{
		tMSBusStaffDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSBusStaffDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@bsdStaffId"].SourceColumn = "BSD_StaffId";
		dbCommand.Parameters["@bsdTransportManagerID"].SourceColumn = "BSD_TransportManagerID";
		dbCommand.Parameters["@bsdStaffType"].SourceColumn = "BSD_StaffType";
		dbCommand.Parameters["@bsdStaffName"].SourceColumn = "BSD_StaffName";
		dbCommand.Parameters["@bsdImage"].SourceColumn = "BSD_Image";
		dbCommand.Parameters["@bsdAddressId"].SourceColumn = "BSD_AddressId";
		dbCommand.Parameters["@bsdDateOfJoining"].SourceColumn = "BSD_DateOfJoining";
		dbCommand.Parameters["@bsdLicenceNo"].SourceColumn = "BSD_LicenceNo";
		dbCommand.Parameters["@bsdDate"].SourceColumn = "BSD_Date";
		dbCommand.Parameters["@bsdStatus"].SourceColumn = "BSD_Status";
		dbCommand.Parameters["@bsdBusLicenceImage"].SourceColumn = "BSD_BusLicenceImage";
		
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
	public static void Delete(System.Int64? bsdStaffId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusStaffDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bsdStaffId);
		
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
	public static void Delete(System.Int64? bsdStaffId)
	{
		Delete(
		bsdStaffId);
	}
	
	/// <summary>
	/// Delete current TMSBusStaffDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusStaffDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, BSDStaffId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.BSDStaffId = null;
	}
	
	/// <summary>
	/// Delete current TMSBusStaffDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBusStaffDetails[] Search(System.Int64? bsdStaffId, System.Int64? bsdTransportManagerID, System.String bsdStaffType, System.String bsdStaffName, System.String bsdImage, System.Int64? bsdAddressId, System.DateTime? bsdDateOfJoining, System.String bsdLicenceNo, System.DateTime? bsdDate, System.Int32? bsdStatus, System.String bsdBusStaffId, System.String bsdBusLicenceImage)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusStaffDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bsdStaffId, bsdTransportManagerID, bsdStaffType, bsdStaffName, bsdImage, bsdAddressId, bsdDateOfJoining, bsdLicenceNo, bsdDate, bsdStatus, bsdBusStaffId, bsdBusLicenceImage);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSBusStaffDetails.MapFrom(ds);
	}
	
	
	public static TMSBusStaffDetails[] Search(TMSBusStaffDetails searchObject)
	{
		return Search ( searchObject.BSDStaffId, searchObject.BSDTransportManagerID, searchObject.BSDStaffType, searchObject.BSDStaffName, searchObject.BSDImage, searchObject.BSDAddressId, searchObject.BSDDateOfJoining, searchObject.BSDLicenceNo, searchObject.BSDDate, searchObject.BSDStatus, searchObject.BSDBusStaffId, searchObject.BSDBusLicenceImage);
	}
	
	/// <summary>
	/// Returns all TMSBusStaffDetails objects.
	/// </summary>
	/// <returns>List of all TMSBusStaffDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSBusStaffDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

