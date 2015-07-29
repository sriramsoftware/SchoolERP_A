/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 8/6/2012 10:56:14 AM                                    */
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
public partial class TMSFeesInstallmentsType
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_FeesInstallmentsType]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _fitTypeId;
	private System.String _fitTypeName;
	private System.String _fitExtra1;
	private System.DateTime? _fitDate;
	private System.Int32? _fitStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? FITTypeId
	{
		get
		{
			return _fitTypeId;
		}
		set
		{
			_fitTypeId = value;
		}
	}
	
	public System.String FITTypeName
	{
		get
		{
			return _fitTypeName;
		}
		set
		{
			_fitTypeName = value;
		}
	}
	
	public System.String FITExtra1
	{
		get
		{
			return _fitExtra1;
		}
		set
		{
			_fitExtra1 = value;
		}
	}
	
	public System.DateTime? FITDate
	{
		get
		{
			return _fitDate;
		}
		set
		{
			_fitDate = value;
		}
	}
	
	public System.Int32? FITStatus
	{
		get
		{
			return _fitStatus;
		}
		set
		{
			_fitStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("FIT_TypeId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FIT_TypeName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FIT_Extra1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FIT_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("FIT_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (FITTypeId == null)
		dr["FIT_TypeId"] = DBNull.Value;
		else
		dr["FIT_TypeId"] = FITTypeId;
		
		if (FITTypeName == null)
		dr["FIT_TypeName"] = DBNull.Value;
		else
		dr["FIT_TypeName"] = FITTypeName;
		
		if (FITExtra1 == null)
		dr["FIT_Extra1"] = DBNull.Value;
		else
		dr["FIT_Extra1"] = FITExtra1;
		
		if (FITDate == null)
		dr["FIT_Date"] = DBNull.Value;
		else
		dr["FIT_Date"] = FITDate;
		
		if (FITStatus == null)
		dr["FIT_Status"] = DBNull.Value;
		else
		dr["FIT_Status"] = FITStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		FITTypeId = dr["FIT_TypeId"] != DBNull.Value ? Convert.ToInt64(dr["FIT_TypeId"]) : FITTypeId = null;
		FITTypeName = dr["FIT_TypeName"] != DBNull.Value ? Convert.ToString(dr["FIT_TypeName"]) : FITTypeName = null;
		FITExtra1 = dr["FIT_Extra1"] != DBNull.Value ? Convert.ToString(dr["FIT_Extra1"]) : FITExtra1 = null;
		FITDate = dr["FIT_Date"] != DBNull.Value ? Convert.ToDateTime(dr["FIT_Date"]) : FITDate = null;
		FITStatus = dr["FIT_Status"] != DBNull.Value ? Convert.ToInt32(dr["FIT_Status"]) : FITStatus = null;
	}
	
	public static TMSFeesInstallmentsType[] MapFrom(DataSet ds)
	{
		List<TMSFeesInstallmentsType> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSFeesInstallmentsType>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_FeesInstallmentsType] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_FeesInstallmentsType] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSFeesInstallmentsType instance = new TMSFeesInstallmentsType();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFeesInstallmentsType Get(System.Int64 fitTypeId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSFeesInstallmentsType instance;
		
		
		instance = new TMSFeesInstallmentsType();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesInstallmentsType_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fitTypeId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSFeesInstallmentsType ID:" + fitTypeId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String fitTypeName, System.String fitExtra1, System.DateTime? fitDate, System.Int32? fitStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesInstallmentsType_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fitTypeName, fitExtra1, fitDate, fitStatus);
		
		if (transaction == null)
		this.FITTypeId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.FITTypeId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String fitTypeName, System.String fitExtra1, System.DateTime? fitDate, System.Int32? fitStatus)
	{
		Insert(fitTypeName, fitExtra1, fitDate, fitStatus, null);
	}
	/// <summary>
	/// Insert current TMSFeesInstallmentsType to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(FITTypeName, FITExtra1, FITDate, FITStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSFeesInstallmentsType to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? fitTypeId, System.String fitTypeName, System.String fitExtra1, System.DateTime? fitDate, System.Int32? fitStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesInstallmentsType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@fitTypeId"].Value = fitTypeId;
		dbCommand.Parameters["@fitTypeName"].Value = fitTypeName;
		dbCommand.Parameters["@fitExtra1"].Value = fitExtra1;
		dbCommand.Parameters["@fitDate"].Value = fitDate;
		dbCommand.Parameters["@fitStatus"].Value = fitStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? fitTypeId, System.String fitTypeName, System.String fitExtra1, System.DateTime? fitDate, System.Int32? fitStatus)
	{
		Update(fitTypeId, fitTypeName, fitExtra1, fitDate, fitStatus, null);
	}
	
	public static void Update(TMSFeesInstallmentsType tMSFeesInstallmentsType)
	{
		tMSFeesInstallmentsType.Update();
	}
	
	public static void Update(TMSFeesInstallmentsType tMSFeesInstallmentsType, DbTransaction transaction)
	{
		tMSFeesInstallmentsType.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSFeesInstallmentsType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@fitTypeId"].SourceColumn = "FIT_TypeId";
		dbCommand.Parameters["@fitTypeName"].SourceColumn = "FIT_TypeName";
		dbCommand.Parameters["@fitExtra1"].SourceColumn = "FIT_Extra1";
		dbCommand.Parameters["@fitDate"].SourceColumn = "FIT_Date";
		dbCommand.Parameters["@fitStatus"].SourceColumn = "FIT_Status";
		
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
	public static void Delete(System.Int64? fitTypeId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesInstallmentsType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fitTypeId);
		
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
	public static void Delete(System.Int64? fitTypeId)
	{
		Delete(
		fitTypeId);
	}
	
	/// <summary>
	/// Delete current TMSFeesInstallmentsType from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesInstallmentsType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, FITTypeId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.FITTypeId = null;
	}
	
	/// <summary>
	/// Delete current TMSFeesInstallmentsType from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFeesInstallmentsType[] Search(System.Int64? fitTypeId, System.String fitTypeName, System.String fitExtra1, System.DateTime? fitDate, System.Int32? fitStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesInstallmentsType_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fitTypeId, fitTypeName, fitExtra1, fitDate, fitStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSFeesInstallmentsType.MapFrom(ds);
	}
	
	
	public static TMSFeesInstallmentsType[] Search(TMSFeesInstallmentsType searchObject)
	{
		return Search ( searchObject.FITTypeId, searchObject.FITTypeName, searchObject.FITExtra1, searchObject.FITDate, searchObject.FITStatus);
	}
	
	/// <summary>
	/// Returns all TMSFeesInstallmentsType objects.
	/// </summary>
	/// <returns>List of all TMSFeesInstallmentsType objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSFeesInstallmentsType[] Search()
	{
		return Search ( null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

