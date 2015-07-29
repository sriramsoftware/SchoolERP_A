/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/14/2012 11:12:11 AM                                    */
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
public partial class TMSOtherDepartment
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_OtherDepartment]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _dpscDepartmentId;
	private System.String _dpScDepartmentName;
	private System.String _dpScDepartmentType;
	private System.DateTime? _dpDate;
	private System.Int32? _dpStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? DPSCDepartmentId
	{
		get
		{
			return _dpscDepartmentId;
		}
		set
		{
			_dpscDepartmentId = value;
		}
	}
	
	public System.String DPScDepartmentName
	{
		get
		{
			return _dpScDepartmentName;
		}
		set
		{
			_dpScDepartmentName = value;
		}
	}
	
	public System.String DPScDepartmentType
	{
		get
		{
			return _dpScDepartmentType;
		}
		set
		{
			_dpScDepartmentType = value;
		}
	}
	
	public System.DateTime? DPDate
	{
		get
		{
			return _dpDate;
		}
		set
		{
			_dpDate = value;
		}
	}
	
	public System.Int32? DpStatus
	{
		get
		{
			return _dpStatus;
		}
		set
		{
			_dpStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("DP_SCDepartmentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("DP_ScDepartmentName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("DP_ScDepartmentType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("DP_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("Dp_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (DPSCDepartmentId == null)
		dr["DP_SCDepartmentId"] = DBNull.Value;
		else
		dr["DP_SCDepartmentId"] = DPSCDepartmentId;
		
		if (DPScDepartmentName == null)
		dr["DP_ScDepartmentName"] = DBNull.Value;
		else
		dr["DP_ScDepartmentName"] = DPScDepartmentName;
		
		if (DPScDepartmentType == null)
		dr["DP_ScDepartmentType"] = DBNull.Value;
		else
		dr["DP_ScDepartmentType"] = DPScDepartmentType;
		
		if (DPDate == null)
		dr["DP_Date"] = DBNull.Value;
		else
		dr["DP_Date"] = DPDate;
		
		if (DpStatus == null)
		dr["Dp_Status"] = DBNull.Value;
		else
		dr["Dp_Status"] = DpStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		DPSCDepartmentId = dr["DP_SCDepartmentId"] != DBNull.Value ? Convert.ToInt64(dr["DP_SCDepartmentId"]) : DPSCDepartmentId = null;
		DPScDepartmentName = dr["DP_ScDepartmentName"] != DBNull.Value ? Convert.ToString(dr["DP_ScDepartmentName"]) : DPScDepartmentName = null;
		DPScDepartmentType = dr["DP_ScDepartmentType"] != DBNull.Value ? Convert.ToString(dr["DP_ScDepartmentType"]) : DPScDepartmentType = null;
		DPDate = dr["DP_Date"] != DBNull.Value ? Convert.ToDateTime(dr["DP_Date"]) : DPDate = null;
		DpStatus = dr["Dp_Status"] != DBNull.Value ? Convert.ToInt32(dr["Dp_Status"]) : DpStatus = null;
	}
	
	public static TMSOtherDepartment[] MapFrom(DataSet ds)
	{
		List<TMSOtherDepartment> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSOtherDepartment>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_OtherDepartment] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_OtherDepartment] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSOtherDepartment instance = new TMSOtherDepartment();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSOtherDepartment Get(System.Int64 dpscDepartmentId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSOtherDepartment instance;
		
		
		instance = new TMSOtherDepartment();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSOtherDepartment_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, dpscDepartmentId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSOtherDepartment ID:" + dpscDepartmentId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String dpScDepartmentName, System.String dpScDepartmentType, System.DateTime? dpDate, System.Int32? dpStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSOtherDepartment_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, dpScDepartmentName, dpScDepartmentType, dpDate, dpStatus);
		
		if (transaction == null)
		this.DPSCDepartmentId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.DPSCDepartmentId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String dpScDepartmentName, System.String dpScDepartmentType, System.DateTime? dpDate, System.Int32? dpStatus)
	{
		Insert(dpScDepartmentName, dpScDepartmentType, dpDate, dpStatus, null);
	}
	/// <summary>
	/// Insert current TMSOtherDepartment to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(DPScDepartmentName, DPScDepartmentType, DPDate, DpStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSOtherDepartment to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? dpscDepartmentId, System.String dpScDepartmentName, System.String dpScDepartmentType, System.DateTime? dpDate, System.Int32? dpStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSOtherDepartment_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@dpscDepartmentId"].Value = dpscDepartmentId;
		dbCommand.Parameters["@dpScDepartmentName"].Value = dpScDepartmentName;
		dbCommand.Parameters["@dpScDepartmentType"].Value = dpScDepartmentType;
		dbCommand.Parameters["@dpDate"].Value = dpDate;
		dbCommand.Parameters["@dpStatus"].Value = dpStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? dpscDepartmentId, System.String dpScDepartmentName, System.String dpScDepartmentType, System.DateTime? dpDate, System.Int32? dpStatus)
	{
		Update(dpscDepartmentId, dpScDepartmentName, dpScDepartmentType, dpDate, dpStatus, null);
	}
	
	public static void Update(TMSOtherDepartment tMSOtherDepartment)
	{
		tMSOtherDepartment.Update();
	}
	
	public static void Update(TMSOtherDepartment tMSOtherDepartment, DbTransaction transaction)
	{
		tMSOtherDepartment.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSOtherDepartment_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@dpscDepartmentId"].SourceColumn = "DP_SCDepartmentId";
		dbCommand.Parameters["@dpScDepartmentName"].SourceColumn = "DP_ScDepartmentName";
		dbCommand.Parameters["@dpScDepartmentType"].SourceColumn = "DP_ScDepartmentType";
		dbCommand.Parameters["@dpDate"].SourceColumn = "DP_Date";
		dbCommand.Parameters["@dpStatus"].SourceColumn = "Dp_Status";
		
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
	public static void Delete(System.Int64? dpscDepartmentId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSOtherDepartment_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, dpscDepartmentId);
		
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
	public static void Delete(System.Int64? dpscDepartmentId)
	{
		Delete(
		dpscDepartmentId);
	}
	
	/// <summary>
	/// Delete current TMSOtherDepartment from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSOtherDepartment_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, DPSCDepartmentId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.DPSCDepartmentId = null;
	}
	
	/// <summary>
	/// Delete current TMSOtherDepartment from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSOtherDepartment[] Search(System.Int64? dpscDepartmentId, System.String dpScDepartmentName, System.String dpScDepartmentType, System.DateTime? dpDate, System.Int32? dpStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSOtherDepartment_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, dpscDepartmentId, dpScDepartmentName, dpScDepartmentType, dpDate, dpStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSOtherDepartment.MapFrom(ds);
	}
	
	
	public static TMSOtherDepartment[] Search(TMSOtherDepartment searchObject)
	{
		return Search ( searchObject.DPSCDepartmentId, searchObject.DPScDepartmentName, searchObject.DPScDepartmentType, searchObject.DPDate, searchObject.DpStatus);
	}
	
	/// <summary>
	/// Returns all TMSOtherDepartment objects.
	/// </summary>
	/// <returns>List of all TMSOtherDepartment objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSOtherDepartment[] Search()
	{
		return Search ( null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

