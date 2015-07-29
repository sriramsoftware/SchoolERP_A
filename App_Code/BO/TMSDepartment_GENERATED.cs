/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/8/2012 12:34:35 PM                                    */
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
public partial class TMSDepartment
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_Department]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _dpDepartmentId;
	private System.String _dpDepartmentName;
	private System.DateTime? _dpDate;
	private System.Int32? _dpStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? DPDepartmentId
	{
		get
		{
			return _dpDepartmentId;
		}
		set
		{
			_dpDepartmentId = value;
		}
	}
	
	public System.String DPDepartmentName
	{
		get
		{
			return _dpDepartmentName;
		}
		set
		{
			_dpDepartmentName = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("DP_DepartmentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("DP_DepartmentName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("DP_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("Dp_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (DPDepartmentId == null)
		dr["DP_DepartmentId"] = DBNull.Value;
		else
		dr["DP_DepartmentId"] = DPDepartmentId;
		
		if (DPDepartmentName == null)
		dr["DP_DepartmentName"] = DBNull.Value;
		else
		dr["DP_DepartmentName"] = DPDepartmentName;
		
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
		DPDepartmentId = dr["DP_DepartmentId"] != DBNull.Value ? Convert.ToInt64(dr["DP_DepartmentId"]) : DPDepartmentId = null;
		DPDepartmentName = dr["DP_DepartmentName"] != DBNull.Value ? Convert.ToString(dr["DP_DepartmentName"]) : DPDepartmentName = null;
		DPDate = dr["DP_Date"] != DBNull.Value ? Convert.ToDateTime(dr["DP_Date"]) : DPDate = null;
		DpStatus = dr["Dp_Status"] != DBNull.Value ? Convert.ToInt32(dr["Dp_Status"]) : DpStatus = null;
	}
	
	public static TMSDepartment[] MapFrom(DataSet ds)
	{
		List<TMSDepartment> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSDepartment>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_Department] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_Department] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSDepartment instance = new TMSDepartment();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSDepartment Get(System.Int64 dpDepartmentId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSDepartment instance;
		
		
		instance = new TMSDepartment();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSDepartment_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, dpDepartmentId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSDepartment ID:" + dpDepartmentId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String dpDepartmentName, System.DateTime? dpDate, System.Int32? dpStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSDepartment_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, dpDepartmentName, dpDate, dpStatus);
		
		if (transaction == null)
		this.DPDepartmentId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.DPDepartmentId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String dpDepartmentName, System.DateTime? dpDate, System.Int32? dpStatus)
	{
		Insert(dpDepartmentName, dpDate, dpStatus, null);
	}
	/// <summary>
	/// Insert current TMSDepartment to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(DPDepartmentName, DPDate, DpStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSDepartment to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? dpDepartmentId, System.String dpDepartmentName, System.DateTime? dpDate, System.Int32? dpStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSDepartment_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@dpDepartmentId"].Value = dpDepartmentId;
		dbCommand.Parameters["@dpDepartmentName"].Value = dpDepartmentName;
		dbCommand.Parameters["@dpDate"].Value = dpDate;
		dbCommand.Parameters["@dpStatus"].Value = dpStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? dpDepartmentId, System.String dpDepartmentName, System.DateTime? dpDate, System.Int32? dpStatus)
	{
		Update(dpDepartmentId, dpDepartmentName, dpDate, dpStatus, null);
	}
	
	public static void Update(TMSDepartment tMSDepartment)
	{
		tMSDepartment.Update();
	}
	
	public static void Update(TMSDepartment tMSDepartment, DbTransaction transaction)
	{
		tMSDepartment.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSDepartment_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@dpDepartmentId"].SourceColumn = "DP_DepartmentId";
		dbCommand.Parameters["@dpDepartmentName"].SourceColumn = "DP_DepartmentName";
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
	public static void Delete(System.Int64? dpDepartmentId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSDepartment_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, dpDepartmentId);
		
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
	public static void Delete(System.Int64? dpDepartmentId)
	{
		Delete(
		dpDepartmentId);
	}
	
	/// <summary>
	/// Delete current TMSDepartment from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSDepartment_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, DPDepartmentId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.DPDepartmentId = null;
	}
	
	/// <summary>
	/// Delete current TMSDepartment from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSDepartment[] Search(System.Int64? dpDepartmentId, System.String dpDepartmentName, System.DateTime? dpDate, System.Int32? dpStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSDepartment_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, dpDepartmentId, dpDepartmentName, dpDate, dpStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSDepartment.MapFrom(ds);
	}
	
	
	public static TMSDepartment[] Search(TMSDepartment searchObject)
	{
		return Search ( searchObject.DPDepartmentId, searchObject.DPDepartmentName, searchObject.DPDate, searchObject.DpStatus);
	}
	
	/// <summary>
	/// Returns all TMSDepartment objects.
	/// </summary>
	/// <returns>List of all TMSDepartment objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSDepartment[] Search()
	{
		return Search ( null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

