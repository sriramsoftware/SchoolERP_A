/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 11/1/2012 11:32:19 AM                                    */
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
public partial class TMSScholasticGradeRange
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ScholasticGradeRange]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _sgpGradeId;
	private System.Int64? _sgpScholasticGradeId;
	private System.Int32? _sgpGradeStartRange;
	private System.Int32? _sgpGradeEndRange;
	private System.DateTime? _sgpDate;
	private System.Int32? _sgpStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? SGPGradeId
	{
		get
		{
			return _sgpGradeId;
		}
		set
		{
			_sgpGradeId = value;
		}
	}
	
	public System.Int64? SGPScholasticGradeId
	{
		get
		{
			return _sgpScholasticGradeId;
		}
		set
		{
			_sgpScholasticGradeId = value;
		}
	}
	
	public System.Int32? SGPGradeStartRange
	{
		get
		{
			return _sgpGradeStartRange;
		}
		set
		{
			_sgpGradeStartRange = value;
		}
	}
	
	public System.Int32? SGPGradeEndRange
	{
		get
		{
			return _sgpGradeEndRange;
		}
		set
		{
			_sgpGradeEndRange = value;
		}
	}
	
	public System.DateTime? SGPDate
	{
		get
		{
			return _sgpDate;
		}
		set
		{
			_sgpDate = value;
		}
	}
	
	public System.Int32? SGPStatus
	{
		get
		{
			return _sgpStatus;
		}
		set
		{
			_sgpStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("SGP_GradeId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SGP_ScholasticGradeId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SGP_GradeStartRange", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("SGP_GradeEndRange", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("SGP_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("SGP_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (SGPGradeId == null)
		dr["SGP_GradeId"] = DBNull.Value;
		else
		dr["SGP_GradeId"] = SGPGradeId;
		
		if (SGPScholasticGradeId == null)
		dr["SGP_ScholasticGradeId"] = DBNull.Value;
		else
		dr["SGP_ScholasticGradeId"] = SGPScholasticGradeId;
		
		if (SGPGradeStartRange == null)
		dr["SGP_GradeStartRange"] = DBNull.Value;
		else
		dr["SGP_GradeStartRange"] = SGPGradeStartRange;
		
		if (SGPGradeEndRange == null)
		dr["SGP_GradeEndRange"] = DBNull.Value;
		else
		dr["SGP_GradeEndRange"] = SGPGradeEndRange;
		
		if (SGPDate == null)
		dr["SGP_Date"] = DBNull.Value;
		else
		dr["SGP_Date"] = SGPDate;
		
		if (SGPStatus == null)
		dr["SGP_Status"] = DBNull.Value;
		else
		dr["SGP_Status"] = SGPStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		SGPGradeId = dr["SGP_GradeId"] != DBNull.Value ? Convert.ToInt64(dr["SGP_GradeId"]) : SGPGradeId = null;
		SGPScholasticGradeId = dr["SGP_ScholasticGradeId"] != DBNull.Value ? Convert.ToInt64(dr["SGP_ScholasticGradeId"]) : SGPScholasticGradeId = null;
		SGPGradeStartRange = dr["SGP_GradeStartRange"] != DBNull.Value ? Convert.ToInt32(dr["SGP_GradeStartRange"]) : SGPGradeStartRange = null;
		SGPGradeEndRange = dr["SGP_GradeEndRange"] != DBNull.Value ? Convert.ToInt32(dr["SGP_GradeEndRange"]) : SGPGradeEndRange = null;
		SGPDate = dr["SGP_Date"] != DBNull.Value ? Convert.ToDateTime(dr["SGP_Date"]) : SGPDate = null;
		SGPStatus = dr["SGP_Status"] != DBNull.Value ? Convert.ToInt32(dr["SGP_Status"]) : SGPStatus = null;
	}
	
	public static TMSScholasticGradeRange[] MapFrom(DataSet ds)
	{
		List<TMSScholasticGradeRange> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSScholasticGradeRange>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ScholasticGradeRange] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ScholasticGradeRange] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSScholasticGradeRange instance = new TMSScholasticGradeRange();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSScholasticGradeRange Get(System.Int64 sgpGradeId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSScholasticGradeRange instance;
		
		
		instance = new TMSScholasticGradeRange();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSScholasticGradeRange_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sgpGradeId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSScholasticGradeRange ID:" + sgpGradeId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? sgpScholasticGradeId, System.Int32? sgpGradeStartRange, System.Int32? sgpGradeEndRange, System.DateTime? sgpDate, System.Int32? sgpStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSScholasticGradeRange_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sgpScholasticGradeId, sgpGradeStartRange, sgpGradeEndRange, sgpDate, sgpStatus);
		
		if (transaction == null)
		this.SGPGradeId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.SGPGradeId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? sgpScholasticGradeId, System.Int32? sgpGradeStartRange, System.Int32? sgpGradeEndRange, System.DateTime? sgpDate, System.Int32? sgpStatus)
	{
		Insert(sgpScholasticGradeId, sgpGradeStartRange, sgpGradeEndRange, sgpDate, sgpStatus, null);
	}
	/// <summary>
	/// Insert current TMSScholasticGradeRange to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(SGPScholasticGradeId, SGPGradeStartRange, SGPGradeEndRange, SGPDate, SGPStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSScholasticGradeRange to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? sgpGradeId, System.Int64? sgpScholasticGradeId, System.Int32? sgpGradeStartRange, System.Int32? sgpGradeEndRange, System.DateTime? sgpDate, System.Int32? sgpStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSScholasticGradeRange_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@sgpGradeId"].Value = sgpGradeId;
		dbCommand.Parameters["@sgpScholasticGradeId"].Value = sgpScholasticGradeId;
		dbCommand.Parameters["@sgpGradeStartRange"].Value = sgpGradeStartRange;
		dbCommand.Parameters["@sgpGradeEndRange"].Value = sgpGradeEndRange;
		dbCommand.Parameters["@sgpDate"].Value = sgpDate;
		dbCommand.Parameters["@sgpStatus"].Value = sgpStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? sgpGradeId, System.Int64? sgpScholasticGradeId, System.Int32? sgpGradeStartRange, System.Int32? sgpGradeEndRange, System.DateTime? sgpDate, System.Int32? sgpStatus)
	{
		Update(sgpGradeId, sgpScholasticGradeId, sgpGradeStartRange, sgpGradeEndRange, sgpDate, sgpStatus, null);
	}
	
	public static void Update(TMSScholasticGradeRange tMSScholasticGradeRange)
	{
		tMSScholasticGradeRange.Update();
	}
	
	public static void Update(TMSScholasticGradeRange tMSScholasticGradeRange, DbTransaction transaction)
	{
		tMSScholasticGradeRange.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSScholasticGradeRange_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@sgpGradeId"].SourceColumn = "SGP_GradeId";
		dbCommand.Parameters["@sgpScholasticGradeId"].SourceColumn = "SGP_ScholasticGradeId";
		dbCommand.Parameters["@sgpGradeStartRange"].SourceColumn = "SGP_GradeStartRange";
		dbCommand.Parameters["@sgpGradeEndRange"].SourceColumn = "SGP_GradeEndRange";
		dbCommand.Parameters["@sgpDate"].SourceColumn = "SGP_Date";
		dbCommand.Parameters["@sgpStatus"].SourceColumn = "SGP_Status";
		
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
	public static void Delete(System.Int64? sgpGradeId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSScholasticGradeRange_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sgpGradeId);
		
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
	public static void Delete(System.Int64? sgpGradeId)
	{
		Delete(
		sgpGradeId);
	}
	
	/// <summary>
	/// Delete current TMSScholasticGradeRange from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSScholasticGradeRange_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, SGPGradeId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.SGPGradeId = null;
	}
	
	/// <summary>
	/// Delete current TMSScholasticGradeRange from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSScholasticGradeRange[] Search(System.Int64? sgpGradeId, System.Int64? sgpScholasticGradeId, System.Int32? sgpGradeStartRange, System.Int32? sgpGradeEndRange, System.DateTime? sgpDate, System.Int32? sgpStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSScholasticGradeRange_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sgpGradeId, sgpScholasticGradeId, sgpGradeStartRange, sgpGradeEndRange, sgpDate, sgpStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSScholasticGradeRange.MapFrom(ds);
	}
	
	
	public static TMSScholasticGradeRange[] Search(TMSScholasticGradeRange searchObject)
	{
		return Search ( searchObject.SGPGradeId, searchObject.SGPScholasticGradeId, searchObject.SGPGradeStartRange, searchObject.SGPGradeEndRange, searchObject.SGPDate, searchObject.SGPStatus);
	}
	
	/// <summary>
	/// Returns all TMSScholasticGradeRange objects.
	/// </summary>
	/// <returns>List of all TMSScholasticGradeRange objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSScholasticGradeRange[] Search()
	{
		return Search ( null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

