/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/25/2012 10:30:52 AM                                    */
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
public partial class TMSUserLogin
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_UserLogin]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _ulLoginId;
	private System.String _ulUserName;
	private System.String _ulUserPassword;
	private System.String _ulEmailId;
	private System.Int32? _ulUserType;
	private System.Int64? _ulCreatedBy;
	private System.Int64? _ulModifiedBy;
	private System.DateTime? _ulCreatedDate;
	private System.DateTime? _ulModifiedDate;
	private System.DateTime? _ulLastLoginDate;
	private System.Int32? _ulStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? ULLoginId
	{
		get
		{
			return _ulLoginId;
		}
		set
		{
			_ulLoginId = value;
		}
	}
	
	public System.String ULUserName
	{
		get
		{
			return _ulUserName;
		}
		set
		{
			_ulUserName = value;
		}
	}
	
	public System.String ULUserPassword
	{
		get
		{
			return _ulUserPassword;
		}
		set
		{
			_ulUserPassword = value;
		}
	}
	
	public System.String ULEmailId
	{
		get
		{
			return _ulEmailId;
		}
		set
		{
			_ulEmailId = value;
		}
	}
	
	public System.Int32? ULUserType
	{
		get
		{
			return _ulUserType;
		}
		set
		{
			_ulUserType = value;
		}
	}
	
	public System.Int64? ULCreatedBy
	{
		get
		{
			return _ulCreatedBy;
		}
		set
		{
			_ulCreatedBy = value;
		}
	}
	
	public System.Int64? ULModifiedBy
	{
		get
		{
			return _ulModifiedBy;
		}
		set
		{
			_ulModifiedBy = value;
		}
	}
	
	public System.DateTime? ULCreatedDate
	{
		get
		{
			return _ulCreatedDate;
		}
		set
		{
			_ulCreatedDate = value;
		}
	}
	
	public System.DateTime? ULModifiedDate
	{
		get
		{
			return _ulModifiedDate;
		}
		set
		{
			_ulModifiedDate = value;
		}
	}
	
	public System.DateTime? ULLastLoginDate
	{
		get
		{
			return _ulLastLoginDate;
		}
		set
		{
			_ulLastLoginDate = value;
		}
	}
	
	public System.Int32? ULStatus
	{
		get
		{
			return _ulStatus;
		}
		set
		{
			_ulStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("UL_LoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("UL_UserName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("UL_UserPassword", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("UL_EmailId", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("UL_UserType", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("UL_CreatedBy", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("UL_ModifiedBy", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("UL_CreatedDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("UL_ModifiedDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("UL_LastLoginDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("UL_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ULLoginId == null)
		dr["UL_LoginId"] = DBNull.Value;
		else
		dr["UL_LoginId"] = ULLoginId;
		
		if (ULUserName == null)
		dr["UL_UserName"] = DBNull.Value;
		else
		dr["UL_UserName"] = ULUserName;
		
		if (ULUserPassword == null)
		dr["UL_UserPassword"] = DBNull.Value;
		else
		dr["UL_UserPassword"] = ULUserPassword;
		
		if (ULEmailId == null)
		dr["UL_EmailId"] = DBNull.Value;
		else
		dr["UL_EmailId"] = ULEmailId;
		
		if (ULUserType == null)
		dr["UL_UserType"] = DBNull.Value;
		else
		dr["UL_UserType"] = ULUserType;
		
		if (ULCreatedBy == null)
		dr["UL_CreatedBy"] = DBNull.Value;
		else
		dr["UL_CreatedBy"] = ULCreatedBy;
		
		if (ULModifiedBy == null)
		dr["UL_ModifiedBy"] = DBNull.Value;
		else
		dr["UL_ModifiedBy"] = ULModifiedBy;
		
		if (ULCreatedDate == null)
		dr["UL_CreatedDate"] = DBNull.Value;
		else
		dr["UL_CreatedDate"] = ULCreatedDate;
		
		if (ULModifiedDate == null)
		dr["UL_ModifiedDate"] = DBNull.Value;
		else
		dr["UL_ModifiedDate"] = ULModifiedDate;
		
		if (ULLastLoginDate == null)
		dr["UL_LastLoginDate"] = DBNull.Value;
		else
		dr["UL_LastLoginDate"] = ULLastLoginDate;
		
		if (ULStatus == null)
		dr["UL_Status"] = DBNull.Value;
		else
		dr["UL_Status"] = ULStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ULLoginId = dr["UL_LoginId"] != DBNull.Value ? Convert.ToInt64(dr["UL_LoginId"]) : ULLoginId = null;
		ULUserName = dr["UL_UserName"] != DBNull.Value ? Convert.ToString(dr["UL_UserName"]) : ULUserName = null;
		ULUserPassword = dr["UL_UserPassword"] != DBNull.Value ? Convert.ToString(dr["UL_UserPassword"]) : ULUserPassword = null;
		ULEmailId = dr["UL_EmailId"] != DBNull.Value ? Convert.ToString(dr["UL_EmailId"]) : ULEmailId = null;
		ULUserType = dr["UL_UserType"] != DBNull.Value ? Convert.ToInt32(dr["UL_UserType"]) : ULUserType = null;
		ULCreatedBy = dr["UL_CreatedBy"] != DBNull.Value ? Convert.ToInt64(dr["UL_CreatedBy"]) : ULCreatedBy = null;
		ULModifiedBy = dr["UL_ModifiedBy"] != DBNull.Value ? Convert.ToInt64(dr["UL_ModifiedBy"]) : ULModifiedBy = null;
		ULCreatedDate = dr["UL_CreatedDate"] != DBNull.Value ? Convert.ToDateTime(dr["UL_CreatedDate"]) : ULCreatedDate = null;
		ULModifiedDate = dr["UL_ModifiedDate"] != DBNull.Value ? Convert.ToDateTime(dr["UL_ModifiedDate"]) : ULModifiedDate = null;
		ULLastLoginDate = dr["UL_LastLoginDate"] != DBNull.Value ? Convert.ToDateTime(dr["UL_LastLoginDate"]) : ULLastLoginDate = null;
		ULStatus = dr["UL_Status"] != DBNull.Value ? Convert.ToInt32(dr["UL_Status"]) : ULStatus = null;
	}
	
	public static TMSUserLogin[] MapFrom(DataSet ds)
	{
		List<TMSUserLogin> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSUserLogin>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_UserLogin] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_UserLogin] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSUserLogin instance = new TMSUserLogin();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSUserLogin Get(System.Int64 ulLoginId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSUserLogin instance;
		
		
		instance = new TMSUserLogin();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUserLogin_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ulLoginId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSUserLogin ID:" + ulLoginId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String ulUserName, System.String ulUserPassword, System.String ulEmailId, System.Int32? ulUserType, System.Int64? ulCreatedBy, System.Int64? ulModifiedBy, System.DateTime? ulCreatedDate, System.DateTime? ulModifiedDate, System.DateTime? ulLastLoginDate, System.Int32? ulStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUserLogin_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ulUserName, ulUserPassword, ulEmailId, ulUserType, ulCreatedBy, ulModifiedBy, ulCreatedDate, ulModifiedDate, ulLastLoginDate, ulStatus);
		
		if (transaction == null)
		this.ULLoginId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.ULLoginId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String ulUserName, System.String ulUserPassword, System.String ulEmailId, System.Int32? ulUserType, System.Int64? ulCreatedBy, System.Int64? ulModifiedBy, System.DateTime? ulCreatedDate, System.DateTime? ulModifiedDate, System.DateTime? ulLastLoginDate, System.Int32? ulStatus)
	{
		Insert(ulUserName, ulUserPassword, ulEmailId, ulUserType, ulCreatedBy, ulModifiedBy, ulCreatedDate, ulModifiedDate, ulLastLoginDate, ulStatus, null);
	}
	/// <summary>
	/// Insert current TMSUserLogin to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ULUserName, ULUserPassword, ULEmailId, ULUserType, ULCreatedBy, ULModifiedBy, ULCreatedDate, ULModifiedDate, ULLastLoginDate, ULStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSUserLogin to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? ulLoginId, System.String ulUserName, System.String ulUserPassword, System.String ulEmailId, System.Int32? ulUserType, System.Int64? ulCreatedBy, System.Int64? ulModifiedBy, System.DateTime? ulCreatedDate, System.DateTime? ulModifiedDate, System.DateTime? ulLastLoginDate, System.Int32? ulStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUserLogin_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ulLoginId"].Value = ulLoginId;
		dbCommand.Parameters["@ulUserName"].Value = ulUserName;
		dbCommand.Parameters["@ulUserPassword"].Value = ulUserPassword;
		dbCommand.Parameters["@ulEmailId"].Value = ulEmailId;
		dbCommand.Parameters["@ulUserType"].Value = ulUserType;
		dbCommand.Parameters["@ulCreatedBy"].Value = ulCreatedBy;
		dbCommand.Parameters["@ulModifiedBy"].Value = ulModifiedBy;
		dbCommand.Parameters["@ulCreatedDate"].Value = ulCreatedDate;
		dbCommand.Parameters["@ulModifiedDate"].Value = ulModifiedDate;
		dbCommand.Parameters["@ulLastLoginDate"].Value = ulLastLoginDate;
		dbCommand.Parameters["@ulStatus"].Value = ulStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? ulLoginId, System.String ulUserName, System.String ulUserPassword, System.String ulEmailId, System.Int32? ulUserType, System.Int64? ulCreatedBy, System.Int64? ulModifiedBy, System.DateTime? ulCreatedDate, System.DateTime? ulModifiedDate, System.DateTime? ulLastLoginDate, System.Int32? ulStatus)
	{
		Update(ulLoginId, ulUserName, ulUserPassword, ulEmailId, ulUserType, ulCreatedBy, ulModifiedBy, ulCreatedDate, ulModifiedDate, ulLastLoginDate, ulStatus, null);
	}
	
	public static void Update(TMSUserLogin tMSUserLogin)
	{
		tMSUserLogin.Update();
	}
	
	public static void Update(TMSUserLogin tMSUserLogin, DbTransaction transaction)
	{
		tMSUserLogin.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSUserLogin_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ulLoginId"].SourceColumn = "UL_LoginId";
		dbCommand.Parameters["@ulUserName"].SourceColumn = "UL_UserName";
		dbCommand.Parameters["@ulUserPassword"].SourceColumn = "UL_UserPassword";
		dbCommand.Parameters["@ulEmailId"].SourceColumn = "UL_EmailId";
		dbCommand.Parameters["@ulUserType"].SourceColumn = "UL_UserType";
		dbCommand.Parameters["@ulCreatedBy"].SourceColumn = "UL_CreatedBy";
		dbCommand.Parameters["@ulModifiedBy"].SourceColumn = "UL_ModifiedBy";
		dbCommand.Parameters["@ulCreatedDate"].SourceColumn = "UL_CreatedDate";
		dbCommand.Parameters["@ulModifiedDate"].SourceColumn = "UL_ModifiedDate";
		dbCommand.Parameters["@ulLastLoginDate"].SourceColumn = "UL_LastLoginDate";
		dbCommand.Parameters["@ulStatus"].SourceColumn = "UL_Status";
		
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
	public static void Delete(System.Int64? ulLoginId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUserLogin_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ulLoginId);
		
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
	public static void Delete(System.Int64? ulLoginId)
	{
		Delete(
		ulLoginId);
	}
	
	/// <summary>
	/// Delete current TMSUserLogin from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUserLogin_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ULLoginId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ULLoginId = null;
	}
	
	/// <summary>
	/// Delete current TMSUserLogin from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSUserLogin[] Search(System.Int64? ulLoginId, System.String ulUserName, System.String ulUserPassword, System.String ulEmailId, System.Int32? ulUserType, System.Int64? ulCreatedBy, System.Int64? ulModifiedBy, System.DateTime? ulCreatedDate, System.DateTime? ulModifiedDate, System.DateTime? ulLastLoginDate, System.Int32? ulStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUserLogin_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ulLoginId, ulUserName, ulUserPassword, ulEmailId, ulUserType, ulCreatedBy, ulModifiedBy, ulCreatedDate, ulModifiedDate, ulLastLoginDate, ulStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSUserLogin.MapFrom(ds);
	}
	
	
	public static TMSUserLogin[] Search(TMSUserLogin searchObject)
	{
		return Search ( searchObject.ULLoginId, searchObject.ULUserName, searchObject.ULUserPassword, searchObject.ULEmailId, searchObject.ULUserType, searchObject.ULCreatedBy, searchObject.ULModifiedBy, searchObject.ULCreatedDate, searchObject.ULModifiedDate, searchObject.ULLastLoginDate, searchObject.ULStatus);
	}
	
	/// <summary>
	/// Returns all TMSUserLogin objects.
	/// </summary>
	/// <returns>List of all TMSUserLogin objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSUserLogin[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

