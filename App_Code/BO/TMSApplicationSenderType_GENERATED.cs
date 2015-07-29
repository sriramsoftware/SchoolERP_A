/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/27/2012 3:47:05 PM                                    */
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
public partial class TMSApplicationSenderType
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ApplicationSenderType]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _asSenderId;
	private System.String _asSenderType;
	private System.String _asApplicationType;
	private System.DateTime? _asDate;
	private System.Int32? _asStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? ASSenderId
	{
		get
		{
			return _asSenderId;
		}
		set
		{
			_asSenderId = value;
		}
	}
	
	public System.String ASSenderType
	{
		get
		{
			return _asSenderType;
		}
		set
		{
			_asSenderType = value;
		}
	}
	
	public System.String ASApplicationType
	{
		get
		{
			return _asApplicationType;
		}
		set
		{
			_asApplicationType = value;
		}
	}
	
	public System.DateTime? ASDate
	{
		get
		{
			return _asDate;
		}
		set
		{
			_asDate = value;
		}
	}
	
	public System.Int32? ASStatus
	{
		get
		{
			return _asStatus;
		}
		set
		{
			_asStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("AS_SenderId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AS_SenderType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AS_ApplicationType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AS_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("AS_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ASSenderId == null)
		dr["AS_SenderId"] = DBNull.Value;
		else
		dr["AS_SenderId"] = ASSenderId;
		
		if (ASSenderType == null)
		dr["AS_SenderType"] = DBNull.Value;
		else
		dr["AS_SenderType"] = ASSenderType;
		
		if (ASApplicationType == null)
		dr["AS_ApplicationType"] = DBNull.Value;
		else
		dr["AS_ApplicationType"] = ASApplicationType;
		
		if (ASDate == null)
		dr["AS_Date"] = DBNull.Value;
		else
		dr["AS_Date"] = ASDate;
		
		if (ASStatus == null)
		dr["AS_Status"] = DBNull.Value;
		else
		dr["AS_Status"] = ASStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ASSenderId = dr["AS_SenderId"] != DBNull.Value ? Convert.ToInt64(dr["AS_SenderId"]) : ASSenderId = null;
		ASSenderType = dr["AS_SenderType"] != DBNull.Value ? Convert.ToString(dr["AS_SenderType"]) : ASSenderType = null;
		ASApplicationType = dr["AS_ApplicationType"] != DBNull.Value ? Convert.ToString(dr["AS_ApplicationType"]) : ASApplicationType = null;
		ASDate = dr["AS_Date"] != DBNull.Value ? Convert.ToDateTime(dr["AS_Date"]) : ASDate = null;
		ASStatus = dr["AS_Status"] != DBNull.Value ? Convert.ToInt32(dr["AS_Status"]) : ASStatus = null;
	}
	
	public static TMSApplicationSenderType[] MapFrom(DataSet ds)
	{
		List<TMSApplicationSenderType> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSApplicationSenderType>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ApplicationSenderType] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ApplicationSenderType] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSApplicationSenderType instance = new TMSApplicationSenderType();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSApplicationSenderType Get(System.Int64 asSenderId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSApplicationSenderType instance;
		
		
		instance = new TMSApplicationSenderType();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSApplicationSenderType_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, asSenderId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSApplicationSenderType ID:" + asSenderId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String asSenderType, System.String asApplicationType, System.DateTime? asDate, System.Int32? asStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSApplicationSenderType_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, asSenderType, asApplicationType, asDate, asStatus);
		
		if (transaction == null)
		this.ASSenderId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.ASSenderId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String asSenderType, System.String asApplicationType, System.DateTime? asDate, System.Int32? asStatus)
	{
		Insert(asSenderType, asApplicationType, asDate, asStatus, null);
	}
	/// <summary>
	/// Insert current TMSApplicationSenderType to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ASSenderType, ASApplicationType, ASDate, ASStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSApplicationSenderType to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? asSenderId, System.String asSenderType, System.String asApplicationType, System.DateTime? asDate, System.Int32? asStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSApplicationSenderType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@asSenderId"].Value = asSenderId;
		dbCommand.Parameters["@asSenderType"].Value = asSenderType;
		dbCommand.Parameters["@asApplicationType"].Value = asApplicationType;
		dbCommand.Parameters["@asDate"].Value = asDate;
		dbCommand.Parameters["@asStatus"].Value = asStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? asSenderId, System.String asSenderType, System.String asApplicationType, System.DateTime? asDate, System.Int32? asStatus)
	{
		Update(asSenderId, asSenderType, asApplicationType, asDate, asStatus, null);
	}
	
	public static void Update(TMSApplicationSenderType tMSApplicationSenderType)
	{
		tMSApplicationSenderType.Update();
	}
	
	public static void Update(TMSApplicationSenderType tMSApplicationSenderType, DbTransaction transaction)
	{
		tMSApplicationSenderType.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSApplicationSenderType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@asSenderId"].SourceColumn = "AS_SenderId";
		dbCommand.Parameters["@asSenderType"].SourceColumn = "AS_SenderType";
		dbCommand.Parameters["@asApplicationType"].SourceColumn = "AS_ApplicationType";
		dbCommand.Parameters["@asDate"].SourceColumn = "AS_Date";
		dbCommand.Parameters["@asStatus"].SourceColumn = "AS_Status";
		
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
	public static void Delete(System.Int64? asSenderId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSApplicationSenderType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, asSenderId);
		
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
	public static void Delete(System.Int64? asSenderId)
	{
		Delete(
		asSenderId);
	}
	
	/// <summary>
	/// Delete current TMSApplicationSenderType from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSApplicationSenderType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ASSenderId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ASSenderId = null;
	}
	
	/// <summary>
	/// Delete current TMSApplicationSenderType from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSApplicationSenderType[] Search(System.Int64? asSenderId, System.String asSenderType, System.String asApplicationType, System.DateTime? asDate, System.Int32? asStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSApplicationSenderType_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, asSenderId, asSenderType, asApplicationType, asDate, asStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSApplicationSenderType.MapFrom(ds);
	}
	
	
	public static TMSApplicationSenderType[] Search(TMSApplicationSenderType searchObject)
	{
		return Search ( searchObject.ASSenderId, searchObject.ASSenderType, searchObject.ASApplicationType, searchObject.ASDate, searchObject.ASStatus);
	}
	
	/// <summary>
	/// Returns all TMSApplicationSenderType objects.
	/// </summary>
	/// <returns>List of all TMSApplicationSenderType objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSApplicationSenderType[] Search()
	{
		return Search ( null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

