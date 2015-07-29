/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 10/10/2012 12:29:31 PM                                    */
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
public partial class TMSAdminUserOne
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_AdminUserOne]";
	
	#endregion
	
	
	#region Fields
	private System.Int32? _adminId;
	private System.String _adminFName;
	private System.String _adminLName;
	private System.String _adminEmailId;
	private System.String _adminUserName;
	private System.String _adminPassword;
	private System.Int32? _adminType;
	private System.DateTime? _adminRegisteredDate;
	private System.Boolean? _adminStatus;
	private System.Boolean? _adminDeletedStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int32? AdminId
	{
		get
		{
			return _adminId;
		}
		set
		{
			_adminId = value;
		}
	}
	
	public System.String AdminFName
	{
		get
		{
			return _adminFName;
		}
		set
		{
			_adminFName = value;
		}
	}
	
	public System.String AdminLName
	{
		get
		{
			return _adminLName;
		}
		set
		{
			_adminLName = value;
		}
	}
	
	public System.String AdminEmailId
	{
		get
		{
			return _adminEmailId;
		}
		set
		{
			_adminEmailId = value;
		}
	}
	
	public System.String AdminUserName
	{
		get
		{
			return _adminUserName;
		}
		set
		{
			_adminUserName = value;
		}
	}
	
	public System.String AdminPassword
	{
		get
		{
			return _adminPassword;
		}
		set
		{
			_adminPassword = value;
		}
	}
	
	public System.Int32? AdminType
	{
		get
		{
			return _adminType;
		}
		set
		{
			_adminType = value;
		}
	}
	
	public System.DateTime? AdminRegisteredDate
	{
		get
		{
			return _adminRegisteredDate;
		}
		set
		{
			_adminRegisteredDate = value;
		}
	}
	
	public System.Boolean? AdminStatus
	{
		get
		{
			return _adminStatus;
		}
		set
		{
			_adminStatus = value;
		}
	}
	
	public System.Boolean? AdminDeletedStatus
	{
		get
		{
			return _adminDeletedStatus;
		}
		set
		{
			_adminDeletedStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("Admin_Id", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("Admin_FName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Admin_LName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Admin_EmailId", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Admin_UserName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Admin_Password", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Admin_Type", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("Admin_RegisteredDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("Admin_Status", typeof(System.Boolean) );
		ds.Tables[TABLE_NAME].Columns.Add("Admin_DeletedStatus", typeof(System.Boolean) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (AdminId == null)
		dr["Admin_Id"] = DBNull.Value;
		else
		dr["Admin_Id"] = AdminId;
		
		if (AdminFName == null)
		dr["Admin_FName"] = DBNull.Value;
		else
		dr["Admin_FName"] = AdminFName;
		
		if (AdminLName == null)
		dr["Admin_LName"] = DBNull.Value;
		else
		dr["Admin_LName"] = AdminLName;
		
		if (AdminEmailId == null)
		dr["Admin_EmailId"] = DBNull.Value;
		else
		dr["Admin_EmailId"] = AdminEmailId;
		
		if (AdminUserName == null)
		dr["Admin_UserName"] = DBNull.Value;
		else
		dr["Admin_UserName"] = AdminUserName;
		
		if (AdminPassword == null)
		dr["Admin_Password"] = DBNull.Value;
		else
		dr["Admin_Password"] = AdminPassword;
		
		if (AdminType == null)
		dr["Admin_Type"] = DBNull.Value;
		else
		dr["Admin_Type"] = AdminType;
		
		if (AdminRegisteredDate == null)
		dr["Admin_RegisteredDate"] = DBNull.Value;
		else
		dr["Admin_RegisteredDate"] = AdminRegisteredDate;
		
		if (AdminStatus == null)
		dr["Admin_Status"] = DBNull.Value;
		else
		dr["Admin_Status"] = AdminStatus;
		
		if (AdminDeletedStatus == null)
		dr["Admin_DeletedStatus"] = DBNull.Value;
		else
		dr["Admin_DeletedStatus"] = AdminDeletedStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		AdminId = dr["Admin_Id"] != DBNull.Value ? Convert.ToInt32(dr["Admin_Id"]) : AdminId = null;
		AdminFName = dr["Admin_FName"] != DBNull.Value ? Convert.ToString(dr["Admin_FName"]) : AdminFName = null;
		AdminLName = dr["Admin_LName"] != DBNull.Value ? Convert.ToString(dr["Admin_LName"]) : AdminLName = null;
		AdminEmailId = dr["Admin_EmailId"] != DBNull.Value ? Convert.ToString(dr["Admin_EmailId"]) : AdminEmailId = null;
		AdminUserName = dr["Admin_UserName"] != DBNull.Value ? Convert.ToString(dr["Admin_UserName"]) : AdminUserName = null;
		AdminPassword = dr["Admin_Password"] != DBNull.Value ? Convert.ToString(dr["Admin_Password"]) : AdminPassword = null;
		AdminType = dr["Admin_Type"] != DBNull.Value ? Convert.ToInt32(dr["Admin_Type"]) : AdminType = null;
		AdminRegisteredDate = dr["Admin_RegisteredDate"] != DBNull.Value ? Convert.ToDateTime(dr["Admin_RegisteredDate"]) : AdminRegisteredDate = null;
		AdminStatus = dr["Admin_Status"] != DBNull.Value ? Convert.ToBoolean(dr["Admin_Status"]) : AdminStatus = null;
		AdminDeletedStatus = dr["Admin_DeletedStatus"] != DBNull.Value ? Convert.ToBoolean(dr["Admin_DeletedStatus"]) : AdminDeletedStatus = null;
	}
	
	public static TMSAdminUserOne[] MapFrom(DataSet ds)
	{
		List<TMSAdminUserOne> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSAdminUserOne>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_AdminUserOne] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_AdminUserOne] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSAdminUserOne instance = new TMSAdminUserOne();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSAdminUserOne Get(System.Int32 adminId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSAdminUserOne instance;
		
		
		instance = new TMSAdminUserOne();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdminUserOne_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adminId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSAdminUserOne ID:" + adminId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String adminFName, System.String adminLName, System.String adminEmailId, System.String adminUserName, System.String adminPassword, System.Int32? adminType, System.DateTime? adminRegisteredDate, System.Boolean? adminStatus, System.Boolean? adminDeletedStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdminUserOne_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adminFName, adminLName, adminEmailId, adminUserName, adminPassword, adminType, adminRegisteredDate, adminStatus, adminDeletedStatus);
		
		if (transaction == null)
		this.AdminId = Convert.ToInt32(db.ExecuteScalar(dbCommand));
		else
		this.AdminId = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String adminFName, System.String adminLName, System.String adminEmailId, System.String adminUserName, System.String adminPassword, System.Int32? adminType, System.DateTime? adminRegisteredDate, System.Boolean? adminStatus, System.Boolean? adminDeletedStatus)
	{
		Insert(adminFName, adminLName, adminEmailId, adminUserName, adminPassword, adminType, adminRegisteredDate, adminStatus, adminDeletedStatus, null);
	}
	/// <summary>
	/// Insert current TMSAdminUserOne to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(AdminFName, AdminLName, AdminEmailId, AdminUserName, AdminPassword, AdminType, AdminRegisteredDate, AdminStatus, AdminDeletedStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSAdminUserOne to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int32? adminId, System.String adminFName, System.String adminLName, System.String adminEmailId, System.String adminUserName, System.String adminPassword, System.Int32? adminType, System.DateTime? adminRegisteredDate, System.Boolean? adminStatus, System.Boolean? adminDeletedStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdminUserOne_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@adminId"].Value = adminId;
		dbCommand.Parameters["@adminFName"].Value = adminFName;
		dbCommand.Parameters["@adminLName"].Value = adminLName;
		dbCommand.Parameters["@adminEmailId"].Value = adminEmailId;
		dbCommand.Parameters["@adminUserName"].Value = adminUserName;
		dbCommand.Parameters["@adminPassword"].Value = adminPassword;
		dbCommand.Parameters["@adminType"].Value = adminType;
		dbCommand.Parameters["@adminRegisteredDate"].Value = adminRegisteredDate;
		dbCommand.Parameters["@adminStatus"].Value = adminStatus;
		dbCommand.Parameters["@adminDeletedStatus"].Value = adminDeletedStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int32? adminId, System.String adminFName, System.String adminLName, System.String adminEmailId, System.String adminUserName, System.String adminPassword, System.Int32? adminType, System.DateTime? adminRegisteredDate, System.Boolean? adminStatus, System.Boolean? adminDeletedStatus)
	{
		Update(adminId, adminFName, adminLName, adminEmailId, adminUserName, adminPassword, adminType, adminRegisteredDate, adminStatus, adminDeletedStatus, null);
	}
	
	public static void Update(TMSAdminUserOne tMSAdminUserOne)
	{
		tMSAdminUserOne.Update();
	}
	
	public static void Update(TMSAdminUserOne tMSAdminUserOne, DbTransaction transaction)
	{
		tMSAdminUserOne.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSAdminUserOne_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@adminId"].SourceColumn = "Admin_Id";
		dbCommand.Parameters["@adminFName"].SourceColumn = "Admin_FName";
		dbCommand.Parameters["@adminLName"].SourceColumn = "Admin_LName";
		dbCommand.Parameters["@adminEmailId"].SourceColumn = "Admin_EmailId";
		dbCommand.Parameters["@adminUserName"].SourceColumn = "Admin_UserName";
		dbCommand.Parameters["@adminPassword"].SourceColumn = "Admin_Password";
		dbCommand.Parameters["@adminType"].SourceColumn = "Admin_Type";
		dbCommand.Parameters["@adminRegisteredDate"].SourceColumn = "Admin_RegisteredDate";
		dbCommand.Parameters["@adminStatus"].SourceColumn = "Admin_Status";
		dbCommand.Parameters["@adminDeletedStatus"].SourceColumn = "Admin_DeletedStatus";
		
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
	public static void Delete(System.Int32? adminId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdminUserOne_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adminId);
		
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
	public static void Delete(System.Int32? adminId)
	{
		Delete(
		adminId);
	}
	
	/// <summary>
	/// Delete current TMSAdminUserOne from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdminUserOne_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, AdminId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.AdminId = null;
	}
	
	/// <summary>
	/// Delete current TMSAdminUserOne from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSAdminUserOne[] Search(System.Int32? adminId, System.String adminFName, System.String adminLName, System.String adminEmailId, System.String adminUserName, System.String adminPassword, System.Int32? adminType, System.DateTime? adminRegisteredDate, System.Boolean? adminStatus, System.Boolean? adminDeletedStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdminUserOne_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adminId, adminFName, adminLName, adminEmailId, adminUserName, adminPassword, adminType, adminRegisteredDate, adminStatus, adminDeletedStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSAdminUserOne.MapFrom(ds);
	}
	
	
	public static TMSAdminUserOne[] Search(TMSAdminUserOne searchObject)
	{
		return Search ( searchObject.AdminId, searchObject.AdminFName, searchObject.AdminLName, searchObject.AdminEmailId, searchObject.AdminUserName, searchObject.AdminPassword, searchObject.AdminType, searchObject.AdminRegisteredDate, searchObject.AdminStatus, searchObject.AdminDeletedStatus);
	}
	
	/// <summary>
	/// Returns all TMSAdminUserOne objects.
	/// </summary>
	/// <returns>List of all TMSAdminUserOne objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSAdminUserOne[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

