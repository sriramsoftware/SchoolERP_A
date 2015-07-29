/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/29/2012 8:09:18 PM                                    */
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
public partial class TMSQuickLinks
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_QuickLinks]";
	
	#endregion
	
	
	#region Fields
	private System.Int32? _qlId;
	private System.String _qlRole;
	private System.String _qlImage;
	private System.String _qlPageName;
	private System.Boolean? _qlStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int32? QLId
	{
		get
		{
			return _qlId;
		}
		set
		{
			_qlId = value;
		}
	}
	
	public System.String QLRole
	{
		get
		{
			return _qlRole;
		}
		set
		{
			_qlRole = value;
		}
	}
	
	public System.String QLImage
	{
		get
		{
			return _qlImage;
		}
		set
		{
			_qlImage = value;
		}
	}
	
	public System.String QLPageName
	{
		get
		{
			return _qlPageName;
		}
		set
		{
			_qlPageName = value;
		}
	}
	
	public System.Boolean? QLStatus
	{
		get
		{
			return _qlStatus;
		}
		set
		{
			_qlStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("QL_Id", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("QL_Role", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("QL_Image", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("QL_PageName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("QL_Status", typeof(System.Boolean) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (QLId == null)
		dr["QL_Id"] = DBNull.Value;
		else
		dr["QL_Id"] = QLId;
		
		if (QLRole == null)
		dr["QL_Role"] = DBNull.Value;
		else
		dr["QL_Role"] = QLRole;
		
		if (QLImage == null)
		dr["QL_Image"] = DBNull.Value;
		else
		dr["QL_Image"] = QLImage;
		
		if (QLPageName == null)
		dr["QL_PageName"] = DBNull.Value;
		else
		dr["QL_PageName"] = QLPageName;
		
		if (QLStatus == null)
		dr["QL_Status"] = DBNull.Value;
		else
		dr["QL_Status"] = QLStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		QLId = dr["QL_Id"] != DBNull.Value ? Convert.ToInt32(dr["QL_Id"]) : QLId = null;
		QLRole = dr["QL_Role"] != DBNull.Value ? Convert.ToString(dr["QL_Role"]) : QLRole = null;
		QLImage = dr["QL_Image"] != DBNull.Value ? Convert.ToString(dr["QL_Image"]) : QLImage = null;
		QLPageName = dr["QL_PageName"] != DBNull.Value ? Convert.ToString(dr["QL_PageName"]) : QLPageName = null;
		QLStatus = dr["QL_Status"] != DBNull.Value ? Convert.ToBoolean(dr["QL_Status"]) : QLStatus = null;
	}
	
	public static TMSQuickLinks[] MapFrom(DataSet ds)
	{
		List<TMSQuickLinks> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSQuickLinks>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_QuickLinks] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_QuickLinks] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSQuickLinks instance = new TMSQuickLinks();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSQuickLinks Get(System.Int32 qlId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSQuickLinks instance;
		
		
		instance = new TMSQuickLinks();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSQuickLinks_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, qlId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSQuickLinks ID:" + qlId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String qlRole, System.String qlImage, System.String qlPageName, System.Boolean? qlStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSQuickLinks_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, qlRole, qlImage, qlPageName, qlStatus);
		
		if (transaction == null)
		this.QLId = Convert.ToInt32(db.ExecuteScalar(dbCommand));
		else
		this.QLId = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String qlRole, System.String qlImage, System.String qlPageName, System.Boolean? qlStatus)
	{
		Insert(qlRole, qlImage, qlPageName, qlStatus, null);
	}
	/// <summary>
	/// Insert current TMSQuickLinks to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(QLRole, QLImage, QLPageName, QLStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSQuickLinks to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int32? qlId, System.String qlRole, System.String qlImage, System.String qlPageName, System.Boolean? qlStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSQuickLinks_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@qlId"].Value = qlId;
		dbCommand.Parameters["@qlRole"].Value = qlRole;
		dbCommand.Parameters["@qlImage"].Value = qlImage;
		dbCommand.Parameters["@qlPageName"].Value = qlPageName;
		dbCommand.Parameters["@qlStatus"].Value = qlStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int32? qlId, System.String qlRole, System.String qlImage, System.String qlPageName, System.Boolean? qlStatus)
	{
		Update(qlId, qlRole, qlImage, qlPageName, qlStatus, null);
	}
	
	public static void Update(TMSQuickLinks tMSQuickLinks)
	{
		tMSQuickLinks.Update();
	}
	
	public static void Update(TMSQuickLinks tMSQuickLinks, DbTransaction transaction)
	{
		tMSQuickLinks.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSQuickLinks_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@qlId"].SourceColumn = "QL_Id";
		dbCommand.Parameters["@qlRole"].SourceColumn = "QL_Role";
		dbCommand.Parameters["@qlImage"].SourceColumn = "QL_Image";
		dbCommand.Parameters["@qlPageName"].SourceColumn = "QL_PageName";
		dbCommand.Parameters["@qlStatus"].SourceColumn = "QL_Status";
		
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
	public static void Delete(System.Int32? qlId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSQuickLinks_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, qlId);
		
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
	public static void Delete(System.Int32? qlId)
	{
		Delete(
		qlId);
	}
	
	/// <summary>
	/// Delete current TMSQuickLinks from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSQuickLinks_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, QLId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.QLId = null;
	}
	
	/// <summary>
	/// Delete current TMSQuickLinks from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSQuickLinks[] Search(System.Int32? qlId, System.String qlRole, System.String qlImage, System.String qlPageName, System.Boolean? qlStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSQuickLinks_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, qlId, qlRole, qlImage, qlPageName, qlStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSQuickLinks.MapFrom(ds);
	}
	
	
	public static TMSQuickLinks[] Search(TMSQuickLinks searchObject)
	{
		return Search ( searchObject.QLId, searchObject.QLRole, searchObject.QLImage, searchObject.QLPageName, searchObject.QLStatus);
	}
	
	/// <summary>
	/// Returns all TMSQuickLinks objects.
	/// </summary>
	/// <returns>List of all TMSQuickLinks objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSQuickLinks[] Search()
	{
		return Search ( null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

