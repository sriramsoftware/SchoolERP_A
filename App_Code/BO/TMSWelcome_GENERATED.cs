/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/13/2012 12:30:40 PM                                    */
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
public partial class TMSWelcome
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_Welcome]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _wdId;
	private System.String _wdDescriptipon;
	private System.DateTime? _wdDate;
	private System.String _wdVideoPath;
	private System.String _wdThumb;
	private System.String _wdTitle;
	private System.Int32? _wdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? WdId
	{
		get
		{
			return _wdId;
		}
		set
		{
			_wdId = value;
		}
	}
	
	public System.String WDDescriptipon
	{
		get
		{
			return _wdDescriptipon;
		}
		set
		{
			_wdDescriptipon = value;
		}
	}
	
	public System.DateTime? WDDate
	{
		get
		{
			return _wdDate;
		}
		set
		{
			_wdDate = value;
		}
	}
	
	public System.String WDVideoPath
	{
		get
		{
			return _wdVideoPath;
		}
		set
		{
			_wdVideoPath = value;
		}
	}
	
	public System.String WDThumb
	{
		get
		{
			return _wdThumb;
		}
		set
		{
			_wdThumb = value;
		}
	}
	
	public System.String WDTitle
	{
		get
		{
			return _wdTitle;
		}
		set
		{
			_wdTitle = value;
		}
	}
	
	public System.Int32? WDStatus
	{
		get
		{
			return _wdStatus;
		}
		set
		{
			_wdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("WD_ID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("WD_Descriptipon", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("WD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("WD_VideoPath", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("WD_Thumb", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("WD_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("WD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (WdId == null)
		dr["WD_ID"] = DBNull.Value;
		else
		dr["WD_ID"] = WdId;
		
		if (WDDescriptipon == null)
		dr["WD_Descriptipon"] = DBNull.Value;
		else
		dr["WD_Descriptipon"] = WDDescriptipon;
		
		if (WDDate == null)
		dr["WD_Date"] = DBNull.Value;
		else
		dr["WD_Date"] = WDDate;
		
		if (WDVideoPath == null)
		dr["WD_VideoPath"] = DBNull.Value;
		else
		dr["WD_VideoPath"] = WDVideoPath;
		
		if (WDThumb == null)
		dr["WD_Thumb"] = DBNull.Value;
		else
		dr["WD_Thumb"] = WDThumb;
		
		if (WDTitle == null)
		dr["WD_Title"] = DBNull.Value;
		else
		dr["WD_Title"] = WDTitle;
		
		if (WDStatus == null)
		dr["WD_Status"] = DBNull.Value;
		else
		dr["WD_Status"] = WDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		WdId = dr["WD_ID"] != DBNull.Value ? Convert.ToInt64(dr["WD_ID"]) : WdId = null;
		WDDescriptipon = dr["WD_Descriptipon"] != DBNull.Value ? Convert.ToString(dr["WD_Descriptipon"]) : WDDescriptipon = null;
		WDDate = dr["WD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["WD_Date"]) : WDDate = null;
		WDVideoPath = dr["WD_VideoPath"] != DBNull.Value ? Convert.ToString(dr["WD_VideoPath"]) : WDVideoPath = null;
		WDThumb = dr["WD_Thumb"] != DBNull.Value ? Convert.ToString(dr["WD_Thumb"]) : WDThumb = null;
		WDTitle = dr["WD_Title"] != DBNull.Value ? Convert.ToString(dr["WD_Title"]) : WDTitle = null;
		WDStatus = dr["WD_Status"] != DBNull.Value ? Convert.ToInt32(dr["WD_Status"]) : WDStatus = null;
	}
	
	public static TMSWelcome[] MapFrom(DataSet ds)
	{
		List<TMSWelcome> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSWelcome>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_Welcome] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_Welcome] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSWelcome instance = new TMSWelcome();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSWelcome Get(System.Int64 wdId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSWelcome instance;
		
		
		instance = new TMSWelcome();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSWelcome_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, wdId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSWelcome ID:" + wdId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String wdDescriptipon, System.DateTime? wdDate, System.String wdVideoPath, System.String wdThumb, System.String wdTitle, System.Int32? wdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSWelcome_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, wdDescriptipon, wdDate, wdVideoPath, wdThumb, wdTitle, wdStatus);
		
		if (transaction == null)
		this.WdId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.WdId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String wdDescriptipon, System.DateTime? wdDate, System.String wdVideoPath, System.String wdThumb, System.String wdTitle, System.Int32? wdStatus)
	{
		Insert(wdDescriptipon, wdDate, wdVideoPath, wdThumb, wdTitle, wdStatus, null);
	}
	/// <summary>
	/// Insert current TMSWelcome to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(WDDescriptipon, WDDate, WDVideoPath, WDThumb, WDTitle, WDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSWelcome to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? wdId, System.String wdDescriptipon, System.DateTime? wdDate, System.String wdVideoPath, System.String wdThumb, System.String wdTitle, System.Int32? wdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSWelcome_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@wdId"].Value = wdId;
		dbCommand.Parameters["@wdDescriptipon"].Value = wdDescriptipon;
		dbCommand.Parameters["@wdDate"].Value = wdDate;
		dbCommand.Parameters["@wdVideoPath"].Value = wdVideoPath;
		dbCommand.Parameters["@wdThumb"].Value = wdThumb;
		dbCommand.Parameters["@wdTitle"].Value = wdTitle;
		dbCommand.Parameters["@wdStatus"].Value = wdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? wdId, System.String wdDescriptipon, System.DateTime? wdDate, System.String wdVideoPath, System.String wdThumb, System.String wdTitle, System.Int32? wdStatus)
	{
		Update(wdId, wdDescriptipon, wdDate, wdVideoPath, wdThumb, wdTitle, wdStatus, null);
	}
	
	public static void Update(TMSWelcome tMSWelcome)
	{
		tMSWelcome.Update();
	}
	
	public static void Update(TMSWelcome tMSWelcome, DbTransaction transaction)
	{
		tMSWelcome.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSWelcome_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@wdId"].SourceColumn = "WD_ID";
		dbCommand.Parameters["@wdDescriptipon"].SourceColumn = "WD_Descriptipon";
		dbCommand.Parameters["@wdDate"].SourceColumn = "WD_Date";
		dbCommand.Parameters["@wdVideoPath"].SourceColumn = "WD_VideoPath";
		dbCommand.Parameters["@wdThumb"].SourceColumn = "WD_Thumb";
		dbCommand.Parameters["@wdTitle"].SourceColumn = "WD_Title";
		dbCommand.Parameters["@wdStatus"].SourceColumn = "WD_Status";
		
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
	public static void Delete(System.Int64? wdId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSWelcome_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, wdId);
		
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
	public static void Delete(System.Int64? wdId)
	{
		Delete(
		wdId);
	}
	
	/// <summary>
	/// Delete current TMSWelcome from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSWelcome_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, WdId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.WdId = null;
	}
	
	/// <summary>
	/// Delete current TMSWelcome from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSWelcome[] Search(System.Int64? wdId, System.String wdDescriptipon, System.DateTime? wdDate, System.String wdVideoPath, System.String wdThumb, System.String wdTitle, System.Int32? wdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSWelcome_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, wdId, wdDescriptipon, wdDate, wdVideoPath, wdThumb, wdTitle, wdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSWelcome.MapFrom(ds);
	}
	
	
	public static TMSWelcome[] Search(TMSWelcome searchObject)
	{
		return Search ( searchObject.WdId, searchObject.WDDescriptipon, searchObject.WDDate, searchObject.WDVideoPath, searchObject.WDThumb, searchObject.WDTitle, searchObject.WDStatus);
	}
	
	/// <summary>
	/// Returns all TMSWelcome objects.
	/// </summary>
	/// <returns>List of all TMSWelcome objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSWelcome[] Search()
	{
		return Search ( null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

