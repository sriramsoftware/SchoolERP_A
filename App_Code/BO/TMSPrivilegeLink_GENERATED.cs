/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 9/20/2012 10:51:37 AM                                    */
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
public partial class TMSPrivilegeLink
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_PrivilegeLink]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _plLinkId;
	private System.String _plLinkType;
	private System.String _plLinkName;
	private System.String _plSubLinkName;
	private System.DateTime? _plDate;
	private System.Int32? _plStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? PLLinkId
	{
		get
		{
			return _plLinkId;
		}
		set
		{
			_plLinkId = value;
		}
	}
	
	public System.String PLLinkType
	{
		get
		{
			return _plLinkType;
		}
		set
		{
			_plLinkType = value;
		}
	}
	
	public System.String PLLinkName
	{
		get
		{
			return _plLinkName;
		}
		set
		{
			_plLinkName = value;
		}
	}
	
	public System.String PLSubLinkName
	{
		get
		{
			return _plSubLinkName;
		}
		set
		{
			_plSubLinkName = value;
		}
	}
	
	public System.DateTime? PLDate
	{
		get
		{
			return _plDate;
		}
		set
		{
			_plDate = value;
		}
	}
	
	public System.Int32? PLStatus
	{
		get
		{
			return _plStatus;
		}
		set
		{
			_plStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("PL_LinkId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PL_LinkType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PL_LinkName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PL_SubLinkName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PL_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("PL_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (PLLinkId == null)
		dr["PL_LinkId"] = DBNull.Value;
		else
		dr["PL_LinkId"] = PLLinkId;
		
		if (PLLinkType == null)
		dr["PL_LinkType"] = DBNull.Value;
		else
		dr["PL_LinkType"] = PLLinkType;
		
		if (PLLinkName == null)
		dr["PL_LinkName"] = DBNull.Value;
		else
		dr["PL_LinkName"] = PLLinkName;
		
		if (PLSubLinkName == null)
		dr["PL_SubLinkName"] = DBNull.Value;
		else
		dr["PL_SubLinkName"] = PLSubLinkName;
		
		if (PLDate == null)
		dr["PL_Date"] = DBNull.Value;
		else
		dr["PL_Date"] = PLDate;
		
		if (PLStatus == null)
		dr["PL_Status"] = DBNull.Value;
		else
		dr["PL_Status"] = PLStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		PLLinkId = dr["PL_LinkId"] != DBNull.Value ? Convert.ToInt64(dr["PL_LinkId"]) : PLLinkId = null;
		PLLinkType = dr["PL_LinkType"] != DBNull.Value ? Convert.ToString(dr["PL_LinkType"]) : PLLinkType = null;
		PLLinkName = dr["PL_LinkName"] != DBNull.Value ? Convert.ToString(dr["PL_LinkName"]) : PLLinkName = null;
		PLSubLinkName = dr["PL_SubLinkName"] != DBNull.Value ? Convert.ToString(dr["PL_SubLinkName"]) : PLSubLinkName = null;
		PLDate = dr["PL_Date"] != DBNull.Value ? Convert.ToDateTime(dr["PL_Date"]) : PLDate = null;
		PLStatus = dr["PL_Status"] != DBNull.Value ? Convert.ToInt32(dr["PL_Status"]) : PLStatus = null;
	}
	
	public static TMSPrivilegeLink[] MapFrom(DataSet ds)
	{
		List<TMSPrivilegeLink> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSPrivilegeLink>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_PrivilegeLink] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_PrivilegeLink] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSPrivilegeLink instance = new TMSPrivilegeLink();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSPrivilegeLink Get(System.Int64 plLinkId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSPrivilegeLink instance;
		
		
		instance = new TMSPrivilegeLink();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPrivilegeLink_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, plLinkId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSPrivilegeLink ID:" + plLinkId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String plLinkType, System.String plLinkName, System.String plSubLinkName, System.DateTime? plDate, System.Int32? plStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPrivilegeLink_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, plLinkType, plLinkName, plSubLinkName, plDate, plStatus);
		
		if (transaction == null)
		this.PLLinkId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.PLLinkId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String plLinkType, System.String plLinkName, System.String plSubLinkName, System.DateTime? plDate, System.Int32? plStatus)
	{
		Insert(plLinkType, plLinkName, plSubLinkName, plDate, plStatus, null);
	}
	/// <summary>
	/// Insert current TMSPrivilegeLink to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(PLLinkType, PLLinkName, PLSubLinkName, PLDate, PLStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSPrivilegeLink to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? plLinkId, System.String plLinkType, System.String plLinkName, System.String plSubLinkName, System.DateTime? plDate, System.Int32? plStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPrivilegeLink_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@plLinkId"].Value = plLinkId;
		dbCommand.Parameters["@plLinkType"].Value = plLinkType;
		dbCommand.Parameters["@plLinkName"].Value = plLinkName;
		dbCommand.Parameters["@plSubLinkName"].Value = plSubLinkName;
		dbCommand.Parameters["@plDate"].Value = plDate;
		dbCommand.Parameters["@plStatus"].Value = plStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? plLinkId, System.String plLinkType, System.String plLinkName, System.String plSubLinkName, System.DateTime? plDate, System.Int32? plStatus)
	{
		Update(plLinkId, plLinkType, plLinkName, plSubLinkName, plDate, plStatus, null);
	}
	
	public static void Update(TMSPrivilegeLink tMSPrivilegeLink)
	{
		tMSPrivilegeLink.Update();
	}
	
	public static void Update(TMSPrivilegeLink tMSPrivilegeLink, DbTransaction transaction)
	{
		tMSPrivilegeLink.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSPrivilegeLink_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@plLinkId"].SourceColumn = "PL_LinkId";
		dbCommand.Parameters["@plLinkType"].SourceColumn = "PL_LinkType";
		dbCommand.Parameters["@plLinkName"].SourceColumn = "PL_LinkName";
		dbCommand.Parameters["@plSubLinkName"].SourceColumn = "PL_SubLinkName";
		dbCommand.Parameters["@plDate"].SourceColumn = "PL_Date";
		dbCommand.Parameters["@plStatus"].SourceColumn = "PL_Status";
		
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
	public static void Delete(System.Int64? plLinkId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPrivilegeLink_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, plLinkId);
		
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
	public static void Delete(System.Int64? plLinkId)
	{
		Delete(
		plLinkId);
	}
	
	/// <summary>
	/// Delete current TMSPrivilegeLink from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPrivilegeLink_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, PLLinkId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.PLLinkId = null;
	}
	
	/// <summary>
	/// Delete current TMSPrivilegeLink from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSPrivilegeLink[] Search(System.Int64? plLinkId, System.String plLinkType, System.String plLinkName, System.String plSubLinkName, System.DateTime? plDate, System.Int32? plStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPrivilegeLink_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, plLinkId, plLinkType, plLinkName, plSubLinkName, plDate, plStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSPrivilegeLink.MapFrom(ds);
	}
	
	
	public static TMSPrivilegeLink[] Search(TMSPrivilegeLink searchObject)
	{
		return Search ( searchObject.PLLinkId, searchObject.PLLinkType, searchObject.PLLinkName, searchObject.PLSubLinkName, searchObject.PLDate, searchObject.PLStatus);
	}
	
	/// <summary>
	/// Returns all TMSPrivilegeLink objects.
	/// </summary>
	/// <returns>List of all TMSPrivilegeLink objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSPrivilegeLink[] Search()
	{
		return Search ( null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

