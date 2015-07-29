/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 8/1/2012 12:35:26 PM                                    */
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
public partial class TMSParentRepresentative
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ParentRepresentative]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _prId;
	private System.Int64? _prParentID;
	private System.Int64? _prStandard;
	private System.Int64? _prDivision;
	private System.String _prType;
	private System.DateTime? _prDate;
	private System.Int32? _prStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? PrId
	{
		get
		{
			return _prId;
		}
		set
		{
			_prId = value;
		}
	}
	
	public System.Int64? PRParentID
	{
		get
		{
			return _prParentID;
		}
		set
		{
			_prParentID = value;
		}
	}
	
	public System.Int64? PRStandard
	{
		get
		{
			return _prStandard;
		}
		set
		{
			_prStandard = value;
		}
	}
	
	public System.Int64? PRDivision
	{
		get
		{
			return _prDivision;
		}
		set
		{
			_prDivision = value;
		}
	}
	
	public System.String PRType
	{
		get
		{
			return _prType;
		}
		set
		{
			_prType = value;
		}
	}
	
	public System.DateTime? PRDate
	{
		get
		{
			return _prDate;
		}
		set
		{
			_prDate = value;
		}
	}
	
	public System.Int32? PRStatus
	{
		get
		{
			return _prStatus;
		}
		set
		{
			_prStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("PR_ID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PR_ParentID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PR_Standard", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PR_Division", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PR_Type", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PR_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("PR_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (PrId == null)
		dr["PR_ID"] = DBNull.Value;
		else
		dr["PR_ID"] = PrId;
		
		if (PRParentID == null)
		dr["PR_ParentID"] = DBNull.Value;
		else
		dr["PR_ParentID"] = PRParentID;
		
		if (PRStandard == null)
		dr["PR_Standard"] = DBNull.Value;
		else
		dr["PR_Standard"] = PRStandard;
		
		if (PRDivision == null)
		dr["PR_Division"] = DBNull.Value;
		else
		dr["PR_Division"] = PRDivision;
		
		if (PRType == null)
		dr["PR_Type"] = DBNull.Value;
		else
		dr["PR_Type"] = PRType;
		
		if (PRDate == null)
		dr["PR_Date"] = DBNull.Value;
		else
		dr["PR_Date"] = PRDate;
		
		if (PRStatus == null)
		dr["PR_Status"] = DBNull.Value;
		else
		dr["PR_Status"] = PRStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		PrId = dr["PR_ID"] != DBNull.Value ? Convert.ToInt64(dr["PR_ID"]) : PrId = null;
		PRParentID = dr["PR_ParentID"] != DBNull.Value ? Convert.ToInt64(dr["PR_ParentID"]) : PRParentID = null;
		PRStandard = dr["PR_Standard"] != DBNull.Value ? Convert.ToInt64(dr["PR_Standard"]) : PRStandard = null;
		PRDivision = dr["PR_Division"] != DBNull.Value ? Convert.ToInt64(dr["PR_Division"]) : PRDivision = null;
		PRType = dr["PR_Type"] != DBNull.Value ? Convert.ToString(dr["PR_Type"]) : PRType = null;
		PRDate = dr["PR_Date"] != DBNull.Value ? Convert.ToDateTime(dr["PR_Date"]) : PRDate = null;
		PRStatus = dr["PR_Status"] != DBNull.Value ? Convert.ToInt32(dr["PR_Status"]) : PRStatus = null;
	}
	
	public static TMSParentRepresentative[] MapFrom(DataSet ds)
	{
		List<TMSParentRepresentative> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSParentRepresentative>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ParentRepresentative] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ParentRepresentative] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSParentRepresentative instance = new TMSParentRepresentative();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSParentRepresentative Get(System.Int64 prId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSParentRepresentative instance;
		
		
		instance = new TMSParentRepresentative();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentRepresentative_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, prId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSParentRepresentative ID:" + prId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? prParentID, System.Int64? prStandard, System.Int64? prDivision, System.String prType, System.DateTime? prDate, System.Int32? prStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentRepresentative_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, prParentID, prStandard, prDivision, prType, prDate, prStatus);
		
		if (transaction == null)
		this.PrId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.PrId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? prParentID, System.Int64? prStandard, System.Int64? prDivision, System.String prType, System.DateTime? prDate, System.Int32? prStatus)
	{
		Insert(prParentID, prStandard, prDivision, prType, prDate, prStatus, null);
	}
	/// <summary>
	/// Insert current TMSParentRepresentative to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(PRParentID, PRStandard, PRDivision, PRType, PRDate, PRStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSParentRepresentative to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? prId, System.Int64? prParentID, System.Int64? prStandard, System.Int64? prDivision, System.String prType, System.DateTime? prDate, System.Int32? prStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentRepresentative_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@prId"].Value = prId;
		dbCommand.Parameters["@prParentID"].Value = prParentID;
		dbCommand.Parameters["@prStandard"].Value = prStandard;
		dbCommand.Parameters["@prDivision"].Value = prDivision;
		dbCommand.Parameters["@prType"].Value = prType;
		dbCommand.Parameters["@prDate"].Value = prDate;
		dbCommand.Parameters["@prStatus"].Value = prStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? prId, System.Int64? prParentID, System.Int64? prStandard, System.Int64? prDivision, System.String prType, System.DateTime? prDate, System.Int32? prStatus)
	{
		Update(prId, prParentID, prStandard, prDivision, prType, prDate, prStatus, null);
	}
	
	public static void Update(TMSParentRepresentative tMSParentRepresentative)
	{
		tMSParentRepresentative.Update();
	}
	
	public static void Update(TMSParentRepresentative tMSParentRepresentative, DbTransaction transaction)
	{
		tMSParentRepresentative.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSParentRepresentative_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@prId"].SourceColumn = "PR_ID";
		dbCommand.Parameters["@prParentID"].SourceColumn = "PR_ParentID";
		dbCommand.Parameters["@prStandard"].SourceColumn = "PR_Standard";
		dbCommand.Parameters["@prDivision"].SourceColumn = "PR_Division";
		dbCommand.Parameters["@prType"].SourceColumn = "PR_Type";
		dbCommand.Parameters["@prDate"].SourceColumn = "PR_Date";
		dbCommand.Parameters["@prStatus"].SourceColumn = "PR_Status";
		
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
	public static void Delete(System.Int64? prId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentRepresentative_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, prId);
		
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
	public static void Delete(System.Int64? prId)
	{
		Delete(
		prId);
	}
	
	/// <summary>
	/// Delete current TMSParentRepresentative from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentRepresentative_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, PrId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.PrId = null;
	}
	
	/// <summary>
	/// Delete current TMSParentRepresentative from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSParentRepresentative[] Search(System.Int64? prId, System.Int64? prParentID, System.Int64? prStandard, System.Int64? prDivision, System.String prType, System.DateTime? prDate, System.Int32? prStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentRepresentative_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, prId, prParentID, prStandard, prDivision, prType, prDate, prStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSParentRepresentative.MapFrom(ds);
	}
	
	
	public static TMSParentRepresentative[] Search(TMSParentRepresentative searchObject)
	{
		return Search ( searchObject.PrId, searchObject.PRParentID, searchObject.PRStandard, searchObject.PRDivision, searchObject.PRType, searchObject.PRDate, searchObject.PRStatus);
	}
	
	/// <summary>
	/// Returns all TMSParentRepresentative objects.
	/// </summary>
	/// <returns>List of all TMSParentRepresentative objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSParentRepresentative[] Search()
	{
		return Search ( null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

