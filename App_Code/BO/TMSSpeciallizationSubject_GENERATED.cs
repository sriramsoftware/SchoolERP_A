/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/8/2012 1:27:07 PM                                    */
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
public partial class TMSSpeciallizationSubject
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_SpeciallizationSubject]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _sbSubjectId;
	private System.String _sbSubjectName;
	private System.DateTime? _sbDate;
	private System.Int32? _sbStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? SBSubjectId
	{
		get
		{
			return _sbSubjectId;
		}
		set
		{
			_sbSubjectId = value;
		}
	}
	
	public System.String SBSubjectName
	{
		get
		{
			return _sbSubjectName;
		}
		set
		{
			_sbSubjectName = value;
		}
	}
	
	public System.DateTime? SBDate
	{
		get
		{
			return _sbDate;
		}
		set
		{
			_sbDate = value;
		}
	}
	
	public System.Int32? SBStatus
	{
		get
		{
			return _sbStatus;
		}
		set
		{
			_sbStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("SB_SubjectId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SB_SubjectName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SB_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("SB_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (SBSubjectId == null)
		dr["SB_SubjectId"] = DBNull.Value;
		else
		dr["SB_SubjectId"] = SBSubjectId;
		
		if (SBSubjectName == null)
		dr["SB_SubjectName"] = DBNull.Value;
		else
		dr["SB_SubjectName"] = SBSubjectName;
		
		if (SBDate == null)
		dr["SB_Date"] = DBNull.Value;
		else
		dr["SB_Date"] = SBDate;
		
		if (SBStatus == null)
		dr["SB_Status"] = DBNull.Value;
		else
		dr["SB_Status"] = SBStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		SBSubjectId = dr["SB_SubjectId"] != DBNull.Value ? Convert.ToInt64(dr["SB_SubjectId"]) : SBSubjectId = null;
		SBSubjectName = dr["SB_SubjectName"] != DBNull.Value ? Convert.ToString(dr["SB_SubjectName"]) : SBSubjectName = null;
		SBDate = dr["SB_Date"] != DBNull.Value ? Convert.ToDateTime(dr["SB_Date"]) : SBDate = null;
		SBStatus = dr["SB_Status"] != DBNull.Value ? Convert.ToInt32(dr["SB_Status"]) : SBStatus = null;
	}
	
	public static TMSSpeciallizationSubject[] MapFrom(DataSet ds)
	{
		List<TMSSpeciallizationSubject> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSSpeciallizationSubject>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_SpeciallizationSubject] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_SpeciallizationSubject] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSSpeciallizationSubject instance = new TMSSpeciallizationSubject();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSpeciallizationSubject Get(System.Int64 sbSubjectId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSSpeciallizationSubject instance;
		
		
		instance = new TMSSpeciallizationSubject();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSpeciallizationSubject_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sbSubjectId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSSpeciallizationSubject ID:" + sbSubjectId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String sbSubjectName, System.DateTime? sbDate, System.Int32? sbStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSpeciallizationSubject_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sbSubjectName, sbDate, sbStatus);
		
		if (transaction == null)
		this.SBSubjectId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.SBSubjectId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String sbSubjectName, System.DateTime? sbDate, System.Int32? sbStatus)
	{
		Insert(sbSubjectName, sbDate, sbStatus, null);
	}
	/// <summary>
	/// Insert current TMSSpeciallizationSubject to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(SBSubjectName, SBDate, SBStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSSpeciallizationSubject to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? sbSubjectId, System.String sbSubjectName, System.DateTime? sbDate, System.Int32? sbStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSpeciallizationSubject_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@sbSubjectId"].Value = sbSubjectId;
		dbCommand.Parameters["@sbSubjectName"].Value = sbSubjectName;
		dbCommand.Parameters["@sbDate"].Value = sbDate;
		dbCommand.Parameters["@sbStatus"].Value = sbStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? sbSubjectId, System.String sbSubjectName, System.DateTime? sbDate, System.Int32? sbStatus)
	{
		Update(sbSubjectId, sbSubjectName, sbDate, sbStatus, null);
	}
	
	public static void Update(TMSSpeciallizationSubject tMSSpeciallizationSubject)
	{
		tMSSpeciallizationSubject.Update();
	}
	
	public static void Update(TMSSpeciallizationSubject tMSSpeciallizationSubject, DbTransaction transaction)
	{
		tMSSpeciallizationSubject.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSSpeciallizationSubject_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@sbSubjectId"].SourceColumn = "SB_SubjectId";
		dbCommand.Parameters["@sbSubjectName"].SourceColumn = "SB_SubjectName";
		dbCommand.Parameters["@sbDate"].SourceColumn = "SB_Date";
		dbCommand.Parameters["@sbStatus"].SourceColumn = "SB_Status";
		
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
	public static void Delete(System.Int64? sbSubjectId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSpeciallizationSubject_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sbSubjectId);
		
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
	public static void Delete(System.Int64? sbSubjectId)
	{
		Delete(
		sbSubjectId);
	}
	
	/// <summary>
	/// Delete current TMSSpeciallizationSubject from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSpeciallizationSubject_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, SBSubjectId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.SBSubjectId = null;
	}
	
	/// <summary>
	/// Delete current TMSSpeciallizationSubject from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSpeciallizationSubject[] Search(System.Int64? sbSubjectId, System.String sbSubjectName, System.DateTime? sbDate, System.Int32? sbStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSpeciallizationSubject_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sbSubjectId, sbSubjectName, sbDate, sbStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSSpeciallizationSubject.MapFrom(ds);
	}
	
	
	public static TMSSpeciallizationSubject[] Search(TMSSpeciallizationSubject searchObject)
	{
		return Search ( searchObject.SBSubjectId, searchObject.SBSubjectName, searchObject.SBDate, searchObject.SBStatus);
	}
	
	/// <summary>
	/// Returns all TMSSpeciallizationSubject objects.
	/// </summary>
	/// <returns>List of all TMSSpeciallizationSubject objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSSpeciallizationSubject[] Search()
	{
		return Search ( null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

