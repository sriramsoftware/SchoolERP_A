/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/23/2012 10:26:46 AM                                    */
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
public partial class TMSLibrianDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_LibrianDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _ldLibrianId;
	private System.Int64? _ldLibraryId;
	private System.Int64? _ldLibraryManagerId;
	private System.String _ldSchoolType;
	private System.String _ldName;
	private System.String _ldImage;
	private System.Int64? _ldAddressId;
	private System.DateTime? _ldDateOfJoining;
	private System.DateTime? _ldDate;
	private System.Int32? _ldStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? LDLibrianId
	{
		get
		{
			return _ldLibrianId;
		}
		set
		{
			_ldLibrianId = value;
		}
	}
	
	public System.Int64? LDLibraryId
	{
		get
		{
			return _ldLibraryId;
		}
		set
		{
			_ldLibraryId = value;
		}
	}
	
	public System.Int64? LDLibraryManagerId
	{
		get
		{
			return _ldLibraryManagerId;
		}
		set
		{
			_ldLibraryManagerId = value;
		}
	}
	
	public System.String LDSchoolType
	{
		get
		{
			return _ldSchoolType;
		}
		set
		{
			_ldSchoolType = value;
		}
	}
	
	public System.String LDName
	{
		get
		{
			return _ldName;
		}
		set
		{
			_ldName = value;
		}
	}
	
	public System.String LDImage
	{
		get
		{
			return _ldImage;
		}
		set
		{
			_ldImage = value;
		}
	}
	
	public System.Int64? LDAddressId
	{
		get
		{
			return _ldAddressId;
		}
		set
		{
			_ldAddressId = value;
		}
	}
	
	public System.DateTime? LDDateOfJoining
	{
		get
		{
			return _ldDateOfJoining;
		}
		set
		{
			_ldDateOfJoining = value;
		}
	}
	
	public System.DateTime? LDDate
	{
		get
		{
			return _ldDate;
		}
		set
		{
			_ldDate = value;
		}
	}
	
	public System.Int32? LDStatus
	{
		get
		{
			return _ldStatus;
		}
		set
		{
			_ldStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("LD_LibrianId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_LibraryId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_LibraryManagerId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_SchoolType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_Name", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_Image", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_AddressId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_DateOfJoining", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (LDLibrianId == null)
		dr["LD_LibrianId"] = DBNull.Value;
		else
		dr["LD_LibrianId"] = LDLibrianId;
		
		if (LDLibraryId == null)
		dr["LD_LibraryId"] = DBNull.Value;
		else
		dr["LD_LibraryId"] = LDLibraryId;
		
		if (LDLibraryManagerId == null)
		dr["LD_LibraryManagerId"] = DBNull.Value;
		else
		dr["LD_LibraryManagerId"] = LDLibraryManagerId;
		
		if (LDSchoolType == null)
		dr["LD_SchoolType"] = DBNull.Value;
		else
		dr["LD_SchoolType"] = LDSchoolType;
		
		if (LDName == null)
		dr["LD_Name"] = DBNull.Value;
		else
		dr["LD_Name"] = LDName;
		
		if (LDImage == null)
		dr["LD_Image"] = DBNull.Value;
		else
		dr["LD_Image"] = LDImage;
		
		if (LDAddressId == null)
		dr["LD_AddressId"] = DBNull.Value;
		else
		dr["LD_AddressId"] = LDAddressId;
		
		if (LDDateOfJoining == null)
		dr["LD_DateOfJoining"] = DBNull.Value;
		else
		dr["LD_DateOfJoining"] = LDDateOfJoining;
		
		if (LDDate == null)
		dr["LD_Date"] = DBNull.Value;
		else
		dr["LD_Date"] = LDDate;
		
		if (LDStatus == null)
		dr["LD_Status"] = DBNull.Value;
		else
		dr["LD_Status"] = LDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		LDLibrianId = dr["LD_LibrianId"] != DBNull.Value ? Convert.ToInt64(dr["LD_LibrianId"]) : LDLibrianId = null;
		//LDLibraryId = dr["LD_LibraryId"] != DBNull.Value ? Convert.ToInt64(dr["LD_LibraryId"]) : LDLibraryId = null;
		LDLibraryManagerId = dr["LD_LibraryManagerId"] != DBNull.Value ? Convert.ToInt64(dr["LD_LibraryManagerId"]) : LDLibraryManagerId = null;
		LDSchoolType = dr["LD_SchoolType"] != DBNull.Value ? Convert.ToString(dr["LD_SchoolType"]) : LDSchoolType = null;
		LDName = dr["LD_Name"] != DBNull.Value ? Convert.ToString(dr["LD_Name"]) : LDName = null;
		LDImage = dr["LD_Image"] != DBNull.Value ? Convert.ToString(dr["LD_Image"]) : LDImage = null;
		LDAddressId = dr["LD_AddressId"] != DBNull.Value ? Convert.ToInt64(dr["LD_AddressId"]) : LDAddressId = null;
		LDDateOfJoining = dr["LD_DateOfJoining"] != DBNull.Value ? Convert.ToDateTime(dr["LD_DateOfJoining"]) : LDDateOfJoining = null;
		LDDate = dr["LD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["LD_Date"]) : LDDate = null;
		LDStatus = dr["LD_Status"] != DBNull.Value ? Convert.ToInt32(dr["LD_Status"]) : LDStatus = null;
	}
	
	public static TMSLibrianDetails[] MapFrom(DataSet ds)
	{
		List<TMSLibrianDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSLibrianDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_LibrianDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_LibrianDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSLibrianDetails instance = new TMSLibrianDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSLibrianDetails Get(System.Int64 ldLibrianId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSLibrianDetails instance;
		
		
		instance = new TMSLibrianDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLibrianDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ldLibrianId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSLibrianDetails ID:" + ldLibrianId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert( System.Int64? ldLibraryManagerId, System.String ldSchoolType, System.String ldName, System.String ldImage, System.Int64? ldAddressId, System.DateTime? ldDateOfJoining, System.DateTime? ldDate, System.Int32? ldStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLibrianDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand,  ldLibraryManagerId, ldSchoolType, ldName, ldImage, ldAddressId, ldDateOfJoining, ldDate, ldStatus);
		
		if (transaction == null)
		this.LDLibrianId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.LDLibrianId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert( System.Int64? ldLibraryManagerId, System.String ldSchoolType, System.String ldName, System.String ldImage, System.Int64? ldAddressId, System.DateTime? ldDateOfJoining, System.DateTime? ldDate, System.Int32? ldStatus)
	{
		Insert( ldLibraryManagerId, ldSchoolType, ldName, ldImage, ldAddressId, ldDateOfJoining, ldDate, ldStatus, null);
	}
	/// <summary>
	/// Insert current TMSLibrianDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert( LDLibraryManagerId, LDSchoolType, LDName, LDImage, LDAddressId, LDDateOfJoining, LDDate, LDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSLibrianDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? ldLibrianId, System.Int64? ldLibraryId, System.Int64? ldLibraryManagerId, System.String ldSchoolType, System.String ldName, System.String ldImage, System.Int64? ldAddressId, System.DateTime? ldDateOfJoining, System.DateTime? ldDate, System.Int32? ldStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLibrianDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ldLibrianId"].Value = ldLibrianId;
        //dbCommand.Parameters["@ldLibraryId"].Value = ldLibraryId;
		dbCommand.Parameters["@ldLibraryManagerId"].Value = ldLibraryManagerId;
		dbCommand.Parameters["@ldSchoolType"].Value = ldSchoolType;
		dbCommand.Parameters["@ldName"].Value = ldName;
		dbCommand.Parameters["@ldImage"].Value = ldImage;
		dbCommand.Parameters["@ldAddressId"].Value = ldAddressId;
		dbCommand.Parameters["@ldDateOfJoining"].Value = ldDateOfJoining;
		dbCommand.Parameters["@ldDate"].Value = ldDate;
		dbCommand.Parameters["@ldStatus"].Value = ldStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? ldLibrianId, System.Int64? ldLibraryId, System.Int64? ldLibraryManagerId, System.String ldSchoolType, System.String ldName, System.String ldImage, System.Int64? ldAddressId, System.DateTime? ldDateOfJoining, System.DateTime? ldDate, System.Int32? ldStatus)
	{
		Update(ldLibrianId, ldLibraryId, ldLibraryManagerId, ldSchoolType, ldName, ldImage, ldAddressId, ldDateOfJoining, ldDate, ldStatus, null);
	}
	
	public static void Update(TMSLibrianDetails tMSLibrianDetails)
	{
		tMSLibrianDetails.Update();
	}
	
	public static void Update(TMSLibrianDetails tMSLibrianDetails, DbTransaction transaction)
	{
		tMSLibrianDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSLibrianDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ldLibrianId"].SourceColumn = "LD_LibrianId";
        //dbCommand.Parameters["@ldLibraryId"].SourceColumn = "LD_LibraryId";
		dbCommand.Parameters["@ldLibraryManagerId"].SourceColumn = "LD_LibraryManagerId";
		dbCommand.Parameters["@ldSchoolType"].SourceColumn = "LD_SchoolType";
		dbCommand.Parameters["@ldName"].SourceColumn = "LD_Name";
		dbCommand.Parameters["@ldImage"].SourceColumn = "LD_Image";
		dbCommand.Parameters["@ldAddressId"].SourceColumn = "LD_AddressId";
		dbCommand.Parameters["@ldDateOfJoining"].SourceColumn = "LD_DateOfJoining";
		dbCommand.Parameters["@ldDate"].SourceColumn = "LD_Date";
		dbCommand.Parameters["@ldStatus"].SourceColumn = "LD_Status";
		
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
	public static void Delete(System.Int64? ldLibrianId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLibrianDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ldLibrianId);
		
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
	public static void Delete(System.Int64? ldLibrianId)
	{
		Delete(
		ldLibrianId);
	}
	
	/// <summary>
	/// Delete current TMSLibrianDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLibrianDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, LDLibrianId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.LDLibrianId = null;
	}
	
	/// <summary>
	/// Delete current TMSLibrianDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSLibrianDetails[] Search(System.Int64? ldLibrianId, System.Int64? ldLibraryId, System.Int64? ldLibraryManagerId, System.String ldSchoolType, System.String ldName, System.String ldImage, System.Int64? ldAddressId, System.DateTime? ldDateOfJoining, System.DateTime? ldDate, System.Int32? ldStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLibrianDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ldLibrianId, ldLibraryId, ldLibraryManagerId, ldSchoolType, ldName, ldImage, ldAddressId, ldDateOfJoining, ldDate, ldStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSLibrianDetails.MapFrom(ds);
	}
	
	
	public static TMSLibrianDetails[] Search(TMSLibrianDetails searchObject)
	{
		return Search ( searchObject.LDLibrianId, searchObject.LDLibraryId, searchObject.LDLibraryManagerId, searchObject.LDSchoolType, searchObject.LDName, searchObject.LDImage, searchObject.LDAddressId, searchObject.LDDateOfJoining, searchObject.LDDate, searchObject.LDStatus);
	}
	
	/// <summary>
	/// Returns all TMSLibrianDetails objects.
	/// </summary>
	/// <returns>List of all TMSLibrianDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSLibrianDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

