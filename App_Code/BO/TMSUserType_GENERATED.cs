/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/24/2012 2:53:46 PM                                    */
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
public partial class TMSUserType
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_UserType]";
	
	#endregion
	
	
	#region Fields
	private System.Int32? _utTypeId;
	private System.String _utTypeName;
	private System.DateTime? _utDate;
	private System.Int32? _utStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int32? UTTypeId
	{
		get
		{
			return _utTypeId;
		}
		set
		{
			_utTypeId = value;
		}
	}
	
	public System.String UTTypeName
	{
		get
		{
			return _utTypeName;
		}
		set
		{
			_utTypeName = value;
		}
	}
	
	public System.DateTime? UTDate
	{
		get
		{
			return _utDate;
		}
		set
		{
			_utDate = value;
		}
	}
	
	public System.Int32? UTStatus
	{
		get
		{
			return _utStatus;
		}
		set
		{
			_utStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("UT_TypeId", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("UT_TypeName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("UT_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("UT_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (UTTypeId == null)
		dr["UT_TypeId"] = DBNull.Value;
		else
		dr["UT_TypeId"] = UTTypeId;
		
		if (UTTypeName == null)
		dr["UT_TypeName"] = DBNull.Value;
		else
		dr["UT_TypeName"] = UTTypeName;
		
		if (UTDate == null)
		dr["UT_Date"] = DBNull.Value;
		else
		dr["UT_Date"] = UTDate;
		
		if (UTStatus == null)
		dr["UT_Status"] = DBNull.Value;
		else
		dr["UT_Status"] = UTStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		UTTypeId = dr["UT_TypeId"] != DBNull.Value ? Convert.ToInt32(dr["UT_TypeId"]) : UTTypeId = null;
		UTTypeName = dr["UT_TypeName"] != DBNull.Value ? Convert.ToString(dr["UT_TypeName"]) : UTTypeName = null;
		UTDate = dr["UT_Date"] != DBNull.Value ? Convert.ToDateTime(dr["UT_Date"]) : UTDate = null;
		UTStatus = dr["UT_Status"] != DBNull.Value ? Convert.ToInt32(dr["UT_Status"]) : UTStatus = null;
	}
	
	public static TMSUserType[] MapFrom(DataSet ds)
	{
		List<TMSUserType> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSUserType>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_UserType] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_UserType] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSUserType instance = new TMSUserType();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSUserType Get(System.Int32 utTypeId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSUserType instance;
		
		
		instance = new TMSUserType();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUserType_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, utTypeId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSUserType ID:" + utTypeId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String utTypeName, System.DateTime? utDate, System.Int32? utStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUserType_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, utTypeName, utDate, utStatus);
		
		if (transaction == null)
		this.UTTypeId = Convert.ToInt32(db.ExecuteScalar(dbCommand));
		else
		this.UTTypeId = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String utTypeName, System.DateTime? utDate, System.Int32? utStatus)
	{
		Insert(utTypeName, utDate, utStatus, null);
	}
	/// <summary>
	/// Insert current TMSUserType to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(UTTypeName, UTDate, UTStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSUserType to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int32? utTypeId, System.String utTypeName, System.DateTime? utDate, System.Int32? utStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUserType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@utTypeId"].Value = utTypeId;
		dbCommand.Parameters["@utTypeName"].Value = utTypeName;
		dbCommand.Parameters["@utDate"].Value = utDate;
		dbCommand.Parameters["@utStatus"].Value = utStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int32? utTypeId, System.String utTypeName, System.DateTime? utDate, System.Int32? utStatus)
	{
		Update(utTypeId, utTypeName, utDate, utStatus, null);
	}
	
	public static void Update(TMSUserType tMSUserType)
	{
		tMSUserType.Update();
	}
	
	public static void Update(TMSUserType tMSUserType, DbTransaction transaction)
	{
		tMSUserType.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSUserType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@utTypeId"].SourceColumn = "UT_TypeId";
		dbCommand.Parameters["@utTypeName"].SourceColumn = "UT_TypeName";
		dbCommand.Parameters["@utDate"].SourceColumn = "UT_Date";
		dbCommand.Parameters["@utStatus"].SourceColumn = "UT_Status";
		
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
	public static void Delete(System.Int32? utTypeId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUserType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, utTypeId);
		
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
	public static void Delete(System.Int32? utTypeId)
	{
		Delete(
		utTypeId);
	}
	
	/// <summary>
	/// Delete current TMSUserType from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUserType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, UTTypeId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.UTTypeId = null;
	}
	
	/// <summary>
	/// Delete current TMSUserType from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSUserType[] Search(System.Int32? utTypeId, System.String utTypeName, System.DateTime? utDate, System.Int32? utStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUserType_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, utTypeId, utTypeName, utDate, utStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSUserType.MapFrom(ds);
	}
	
	
	public static TMSUserType[] Search(TMSUserType searchObject)
	{
		return Search ( searchObject.UTTypeId, searchObject.UTTypeName, searchObject.UTDate, searchObject.UTStatus);
	}
	
	/// <summary>
	/// Returns all TMSUserType objects.
	/// </summary>
	/// <returns>List of all TMSUserType objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSUserType[] Search()
	{
		return Search ( null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

